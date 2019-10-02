using System;                                                                                                                               // MakerGen.cs:435
using System.Diagnostics;                                                                                                                   // MakerGen.cs:436
using System.IO;                                                                                                                            // MakerGen.cs:437
using System.Linq;                                                                                                                          // MakerGen.cs:438
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:439
                                                                                                                                            // MakerGen.cs:440
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:441
{                                                                                                                                           // MakerGen.cs:442
    #region Json                                                                                                                            // MakerGen.cs:443
    #if NEVER                                                                                                                               // MakerGen.cs:444
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
    #endregion                                                                                                                              // MakerGen.cs:447
    /// <summary>
    /// Fhir resource 'MolecularSequence'
    /// </summary>
    // 0. MolecularSequence
    public class Resource_MolecularSequence : FhirKhit.Maker.Common.Resource.Resource_DomainResource                                        // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        // 9. MolecularSequence.referenceSeq
        public class Type_ReferenceSeq : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 10. MolecularSequence.referenceSeq.chromosome
            public ElementDefinitionInfo Element_Chromosome;                                                                                // MakerGen.cs:219
            // 11. MolecularSequence.referenceSeq.genomeBuild
            public ElementDefinitionInfo Element_GenomeBuild;                                                                               // MakerGen.cs:219
            // 12. MolecularSequence.referenceSeq.orientation
            public ElementDefinitionInfo Element_Orientation;                                                                               // MakerGen.cs:219
            // 13. MolecularSequence.referenceSeq.referenceSeqId
            public ElementDefinitionInfo Element_ReferenceSeqId;                                                                            // MakerGen.cs:219
            // 14. MolecularSequence.referenceSeq.referenceSeqPointer
            public ElementDefinitionInfo Element_ReferenceSeqPointer;                                                                       // MakerGen.cs:219
            // 15. MolecularSequence.referenceSeq.referenceSeqString
            public ElementDefinitionInfo Element_ReferenceSeqString;                                                                        // MakerGen.cs:219
            // 16. MolecularSequence.referenceSeq.strand
            public ElementDefinitionInfo Element_Strand;                                                                                    // MakerGen.cs:219
            // 17. MolecularSequence.referenceSeq.windowStart
            public ElementDefinitionInfo Element_WindowStart;                                                                               // MakerGen.cs:219
            // 18. MolecularSequence.referenceSeq.windowEnd
            public ElementDefinitionInfo Element_WindowEnd;                                                                                 // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "MolecularSequence.referenceSeq",                                                                                // MakerGen.cs:395
                    ElementId = "MolecularSequence.referenceSeq"                                                                            // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Chromosome.Write(sDef);                                                                                             // MakerGen.cs:223
                Element_GenomeBuild.Write(sDef);                                                                                            // MakerGen.cs:223
                Element_Orientation.Write(sDef);                                                                                            // MakerGen.cs:223
                Element_ReferenceSeqId.Write(sDef);                                                                                         // MakerGen.cs:223
                Element_ReferenceSeqPointer.Write(sDef);                                                                                    // MakerGen.cs:223
                Element_ReferenceSeqString.Write(sDef);                                                                                     // MakerGen.cs:223
                Element_Strand.Write(sDef);                                                                                                 // MakerGen.cs:223
                Element_WindowStart.Write(sDef);                                                                                            // MakerGen.cs:223
                Element_WindowEnd.Write(sDef);                                                                                              // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_ReferenceSeq()                                                                                                      // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 10. MolecularSequence.referenceSeq.chromosome
                    this.Element_Chromosome = new ElementDefinitionInfo                                                                     // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Chromosome",                                                                                        // MakerGen.cs:238
                        Path= "MolecularSequence.referenceSeq.chromosome",                                                                  // MakerGen.cs:239
                        Id = "MolecularSequence.referenceSeq.chromosome",                                                                   // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            }                                                                                                               // MakerGen.cs:322
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 11. MolecularSequence.referenceSeq.genomeBuild
                    this.Element_GenomeBuild = new ElementDefinitionInfo                                                                    // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_GenomeBuild",                                                                                       // MakerGen.cs:238
                        Path= "MolecularSequence.referenceSeq.genomeBuild",                                                                 // MakerGen.cs:239
                        Id = "MolecularSequence.referenceSeq.genomeBuild",                                                                  // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 12. MolecularSequence.referenceSeq.orientation
                    this.Element_Orientation = new ElementDefinitionInfo                                                                    // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Orientation",                                                                                       // MakerGen.cs:238
                        Path= "MolecularSequence.referenceSeq.orientation",                                                                 // MakerGen.cs:239
                        Id = "MolecularSequence.referenceSeq.orientation",                                                                  // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                              // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 13. MolecularSequence.referenceSeq.referenceSeqId
                    this.Element_ReferenceSeqId = new ElementDefinitionInfo                                                                 // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_ReferenceSeqId",                                                                                    // MakerGen.cs:238
                        Path= "MolecularSequence.referenceSeq.referenceSeqId",                                                              // MakerGen.cs:239
                        Id = "MolecularSequence.referenceSeq.referenceSeqId",                                                               // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            }                                                                                                               // MakerGen.cs:322
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 14. MolecularSequence.referenceSeq.referenceSeqPointer
                    this.Element_ReferenceSeqPointer = new ElementDefinitionInfo                                                            // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_ReferenceSeqPointer",                                                                               // MakerGen.cs:238
                        Path= "MolecularSequence.referenceSeq.referenceSeqPointer",                                                         // MakerGen.cs:239
                        Id = "MolecularSequence.referenceSeq.referenceSeqPointer",                                                          // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/MolecularSequence"                                             // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 15. MolecularSequence.referenceSeq.referenceSeqString
                    this.Element_ReferenceSeqString = new ElementDefinitionInfo                                                             // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_ReferenceSeqString",                                                                                // MakerGen.cs:238
                        Path= "MolecularSequence.referenceSeq.referenceSeqString",                                                          // MakerGen.cs:239
                        Id = "MolecularSequence.referenceSeq.referenceSeqString",                                                           // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 16. MolecularSequence.referenceSeq.strand
                    this.Element_Strand = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Strand",                                                                                            // MakerGen.cs:238
                        Path= "MolecularSequence.referenceSeq.strand",                                                                      // MakerGen.cs:239
                        Id = "MolecularSequence.referenceSeq.strand",                                                                       // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                              // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 17. MolecularSequence.referenceSeq.windowStart
                    this.Element_WindowStart = new ElementDefinitionInfo                                                                    // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_WindowStart",                                                                                       // MakerGen.cs:238
                        Path= "MolecularSequence.referenceSeq.windowStart",                                                                 // MakerGen.cs:239
                        Id = "MolecularSequence.referenceSeq.windowStart",                                                                  // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Integer                                                           // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 18. MolecularSequence.referenceSeq.windowEnd
                    this.Element_WindowEnd = new ElementDefinitionInfo                                                                      // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_WindowEnd",                                                                                         // MakerGen.cs:238
                        Path= "MolecularSequence.referenceSeq.windowEnd",                                                                   // MakerGen.cs:239
                        Id = "MolecularSequence.referenceSeq.windowEnd",                                                                    // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Integer                                                           // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 19. MolecularSequence.variant
        public class Type_Variant : FhirKhit.Maker.Common.Complex.ComplexBase                                                               // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 20. MolecularSequence.variant.start
            public ElementDefinitionInfo Element_Start;                                                                                     // MakerGen.cs:219
            // 21. MolecularSequence.variant.end
            public ElementDefinitionInfo Element_End;                                                                                       // MakerGen.cs:219
            // 22. MolecularSequence.variant.observedAllele
            public ElementDefinitionInfo Element_ObservedAllele;                                                                            // MakerGen.cs:219
            // 23. MolecularSequence.variant.referenceAllele
            public ElementDefinitionInfo Element_ReferenceAllele;                                                                           // MakerGen.cs:219
            // 24. MolecularSequence.variant.cigar
            public ElementDefinitionInfo Element_Cigar;                                                                                     // MakerGen.cs:219
            // 25. MolecularSequence.variant.variantPointer
            public ElementDefinitionInfo Element_VariantPointer;                                                                            // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "MolecularSequence.variant",                                                                                     // MakerGen.cs:395
                    ElementId = "MolecularSequence.variant"                                                                                 // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Start.Write(sDef);                                                                                                  // MakerGen.cs:223
                Element_End.Write(sDef);                                                                                                    // MakerGen.cs:223
                Element_ObservedAllele.Write(sDef);                                                                                         // MakerGen.cs:223
                Element_ReferenceAllele.Write(sDef);                                                                                        // MakerGen.cs:223
                Element_Cigar.Write(sDef);                                                                                                  // MakerGen.cs:223
                Element_VariantPointer.Write(sDef);                                                                                         // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_Variant()                                                                                                           // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 20. MolecularSequence.variant.start
                    this.Element_Start = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Start",                                                                                             // MakerGen.cs:238
                        Path= "MolecularSequence.variant.start",                                                                            // MakerGen.cs:239
                        Id = "MolecularSequence.variant.start",                                                                             // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Integer                                                           // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 21. MolecularSequence.variant.end
                    this.Element_End = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_End",                                                                                               // MakerGen.cs:238
                        Path= "MolecularSequence.variant.end",                                                                              // MakerGen.cs:239
                        Id = "MolecularSequence.variant.end",                                                                               // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Integer                                                           // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 22. MolecularSequence.variant.observedAllele
                    this.Element_ObservedAllele = new ElementDefinitionInfo                                                                 // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_ObservedAllele",                                                                                    // MakerGen.cs:238
                        Path= "MolecularSequence.variant.observedAllele",                                                                   // MakerGen.cs:239
                        Id = "MolecularSequence.variant.observedAllele",                                                                    // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 23. MolecularSequence.variant.referenceAllele
                    this.Element_ReferenceAllele = new ElementDefinitionInfo                                                                // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_ReferenceAllele",                                                                                   // MakerGen.cs:238
                        Path= "MolecularSequence.variant.referenceAllele",                                                                  // MakerGen.cs:239
                        Id = "MolecularSequence.variant.referenceAllele",                                                                   // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 24. MolecularSequence.variant.cigar
                    this.Element_Cigar = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Cigar",                                                                                             // MakerGen.cs:238
                        Path= "MolecularSequence.variant.cigar",                                                                            // MakerGen.cs:239
                        Id = "MolecularSequence.variant.cigar",                                                                             // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 25. MolecularSequence.variant.variantPointer
                    this.Element_VariantPointer = new ElementDefinitionInfo                                                                 // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_VariantPointer",                                                                                    // MakerGen.cs:238
                        Path= "MolecularSequence.variant.variantPointer",                                                                   // MakerGen.cs:239
                        Id = "MolecularSequence.variant.variantPointer",                                                                    // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Observation"                                                   // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 27. MolecularSequence.quality
        public class Type_Quality : FhirKhit.Maker.Common.Complex.ComplexBase                                                               // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 42. MolecularSequence.quality.roc
            public class Type_Roc : FhirKhit.Maker.Common.Complex.ComplexBase                                                               // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                // 43. MolecularSequence.quality.roc.score
                public ElementDefinitionInfo Element_Score;                                                                                 // MakerGen.cs:219
                // 44. MolecularSequence.quality.roc.numTP
                public ElementDefinitionInfo Element_NumTP;                                                                                 // MakerGen.cs:219
                // 45. MolecularSequence.quality.roc.numFP
                public ElementDefinitionInfo Element_NumFP;                                                                                 // MakerGen.cs:219
                // 46. MolecularSequence.quality.roc.numFN
                public ElementDefinitionInfo Element_NumFN;                                                                                 // MakerGen.cs:219
                // 47. MolecularSequence.quality.roc.precision
                public ElementDefinitionInfo Element_Precision;                                                                             // MakerGen.cs:219
                // 48. MolecularSequence.quality.roc.sensitivity
                public ElementDefinitionInfo Element_Sensitivity;                                                                           // MakerGen.cs:219
                // 49. MolecularSequence.quality.roc.fMeasure
                public ElementDefinitionInfo Element_FMeasure;                                                                              // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:390
                {                                                                                                                           // MakerGen.cs:391
                    base.Write(sDef);                                                                                                       // MakerGen.cs:392
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        Path = "MolecularSequence.quality.roc",                                                                             // MakerGen.cs:395
                        ElementId = "MolecularSequence.quality.roc"                                                                         // MakerGen.cs:396
                    });                                                                                                                     // MakerGen.cs:397
                    Element_Score.Write(sDef);                                                                                              // MakerGen.cs:223
                    Element_NumTP.Write(sDef);                                                                                              // MakerGen.cs:223
                    Element_NumFP.Write(sDef);                                                                                              // MakerGen.cs:223
                    Element_NumFN.Write(sDef);                                                                                              // MakerGen.cs:223
                    Element_Precision.Write(sDef);                                                                                          // MakerGen.cs:223
                    Element_Sensitivity.Write(sDef);                                                                                        // MakerGen.cs:223
                    Element_FMeasure.Write(sDef);                                                                                           // MakerGen.cs:223
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
                public Type_Roc()                                                                                                           // MakerGen.cs:402
                {                                                                                                                           // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:234
                        // 43. MolecularSequence.quality.roc.score
                        this.Element_Score = new ElementDefinitionInfo                                                                      // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Score",                                                                                         // MakerGen.cs:238
                            Path= "MolecularSequence.quality.roc.score",                                                                    // MakerGen.cs:239
                            Id = "MolecularSequence.quality.roc.score",                                                                     // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = -1,                                                                                                       // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Primitive.Primitive_Integer                                                       // MakerGen.cs:303
                                {                                                                                                           // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:307
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 44. MolecularSequence.quality.roc.numTP
                        this.Element_NumTP = new ElementDefinitionInfo                                                                      // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_NumTP",                                                                                         // MakerGen.cs:238
                            Path= "MolecularSequence.quality.roc.numTP",                                                                    // MakerGen.cs:239
                            Id = "MolecularSequence.quality.roc.numTP",                                                                     // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = -1,                                                                                                       // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Primitive.Primitive_Integer                                                       // MakerGen.cs:303
                                {                                                                                                           // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:307
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 45. MolecularSequence.quality.roc.numFP
                        this.Element_NumFP = new ElementDefinitionInfo                                                                      // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_NumFP",                                                                                         // MakerGen.cs:238
                            Path= "MolecularSequence.quality.roc.numFP",                                                                    // MakerGen.cs:239
                            Id = "MolecularSequence.quality.roc.numFP",                                                                     // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = -1,                                                                                                       // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Primitive.Primitive_Integer                                                       // MakerGen.cs:303
                                {                                                                                                           // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:307
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 46. MolecularSequence.quality.roc.numFN
                        this.Element_NumFN = new ElementDefinitionInfo                                                                      // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_NumFN",                                                                                         // MakerGen.cs:238
                            Path= "MolecularSequence.quality.roc.numFN",                                                                    // MakerGen.cs:239
                            Id = "MolecularSequence.quality.roc.numFN",                                                                     // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = -1,                                                                                                       // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Primitive.Primitive_Integer                                                       // MakerGen.cs:303
                                {                                                                                                           // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:307
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 47. MolecularSequence.quality.roc.precision
                        this.Element_Precision = new ElementDefinitionInfo                                                                  // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Precision",                                                                                     // MakerGen.cs:238
                            Path= "MolecularSequence.quality.roc.precision",                                                                // MakerGen.cs:239
                            Id = "MolecularSequence.quality.roc.precision",                                                                 // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = -1,                                                                                                       // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Primitive.Primitive_Decimal                                                       // MakerGen.cs:303
                                {                                                                                                           // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:307
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 48. MolecularSequence.quality.roc.sensitivity
                        this.Element_Sensitivity = new ElementDefinitionInfo                                                                // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Sensitivity",                                                                                   // MakerGen.cs:238
                            Path= "MolecularSequence.quality.roc.sensitivity",                                                              // MakerGen.cs:239
                            Id = "MolecularSequence.quality.roc.sensitivity",                                                               // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = -1,                                                                                                       // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Primitive.Primitive_Decimal                                                       // MakerGen.cs:303
                                {                                                                                                           // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:307
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 49. MolecularSequence.quality.roc.fMeasure
                        this.Element_FMeasure = new ElementDefinitionInfo                                                                   // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_FMeasure",                                                                                      // MakerGen.cs:238
                            Path= "MolecularSequence.quality.roc.fMeasure",                                                                 // MakerGen.cs:239
                            Id = "MolecularSequence.quality.roc.fMeasure",                                                                  // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = -1,                                                                                                       // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Primitive.Primitive_Decimal                                                       // MakerGen.cs:303
                                {                                                                                                           // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:307
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                }                                                                                                                           // MakerGen.cs:405
            }                                                                                                                               // MakerGen.cs:407
            // 28. MolecularSequence.quality.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:219
            // 29. MolecularSequence.quality.standardSequence
            public ElementDefinitionInfo Element_StandardSequence;                                                                          // MakerGen.cs:219
            // 30. MolecularSequence.quality.start
            public ElementDefinitionInfo Element_Start;                                                                                     // MakerGen.cs:219
            // 31. MolecularSequence.quality.end
            public ElementDefinitionInfo Element_End;                                                                                       // MakerGen.cs:219
            // 32. MolecularSequence.quality.score
            public ElementDefinitionInfo Element_Score;                                                                                     // MakerGen.cs:219
            // 33. MolecularSequence.quality.method
            public ElementDefinitionInfo Element_Method;                                                                                    // MakerGen.cs:219
            // 34. MolecularSequence.quality.truthTP
            public ElementDefinitionInfo Element_TruthTP;                                                                                   // MakerGen.cs:219
            // 35. MolecularSequence.quality.queryTP
            public ElementDefinitionInfo Element_QueryTP;                                                                                   // MakerGen.cs:219
            // 36. MolecularSequence.quality.truthFN
            public ElementDefinitionInfo Element_TruthFN;                                                                                   // MakerGen.cs:219
            // 37. MolecularSequence.quality.queryFP
            public ElementDefinitionInfo Element_QueryFP;                                                                                   // MakerGen.cs:219
            // 38. MolecularSequence.quality.gtFP
            public ElementDefinitionInfo Element_GtFP;                                                                                      // MakerGen.cs:219
            // 39. MolecularSequence.quality.precision
            public ElementDefinitionInfo Element_Precision;                                                                                 // MakerGen.cs:219
            // 40. MolecularSequence.quality.recall
            public ElementDefinitionInfo Element_Recall;                                                                                    // MakerGen.cs:219
            // 41. MolecularSequence.quality.fScore
            public ElementDefinitionInfo Element_FScore;                                                                                    // MakerGen.cs:219
            // 42. MolecularSequence.quality.roc
            public ElementDefinitionInfo Element_Roc;                                                                                       // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "MolecularSequence.quality",                                                                                     // MakerGen.cs:395
                    ElementId = "MolecularSequence.quality"                                                                                 // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:223
                Element_StandardSequence.Write(sDef);                                                                                       // MakerGen.cs:223
                Element_Start.Write(sDef);                                                                                                  // MakerGen.cs:223
                Element_End.Write(sDef);                                                                                                    // MakerGen.cs:223
                Element_Score.Write(sDef);                                                                                                  // MakerGen.cs:223
                Element_Method.Write(sDef);                                                                                                 // MakerGen.cs:223
                Element_TruthTP.Write(sDef);                                                                                                // MakerGen.cs:223
                Element_QueryTP.Write(sDef);                                                                                                // MakerGen.cs:223
                Element_TruthFN.Write(sDef);                                                                                                // MakerGen.cs:223
                Element_QueryFP.Write(sDef);                                                                                                // MakerGen.cs:223
                Element_GtFP.Write(sDef);                                                                                                   // MakerGen.cs:223
                Element_Precision.Write(sDef);                                                                                              // MakerGen.cs:223
                Element_Recall.Write(sDef);                                                                                                 // MakerGen.cs:223
                Element_FScore.Write(sDef);                                                                                                 // MakerGen.cs:223
                Element_Roc.Write(sDef);                                                                                                    // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_Quality()                                                                                                           // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 28. MolecularSequence.quality.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Type",                                                                                              // MakerGen.cs:238
                        Path= "MolecularSequence.quality.type",                                                                             // MakerGen.cs:239
                        Id = "MolecularSequence.quality.type",                                                                              // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                              // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 29. MolecularSequence.quality.standardSequence
                    this.Element_StandardSequence = new ElementDefinitionInfo                                                               // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_StandardSequence",                                                                                  // MakerGen.cs:238
                        Path= "MolecularSequence.quality.standardSequence",                                                                 // MakerGen.cs:239
                        Id = "MolecularSequence.quality.standardSequence",                                                                  // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            }                                                                                                               // MakerGen.cs:322
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 30. MolecularSequence.quality.start
                    this.Element_Start = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Start",                                                                                             // MakerGen.cs:238
                        Path= "MolecularSequence.quality.start",                                                                            // MakerGen.cs:239
                        Id = "MolecularSequence.quality.start",                                                                             // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Integer                                                           // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 31. MolecularSequence.quality.end
                    this.Element_End = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_End",                                                                                               // MakerGen.cs:238
                        Path= "MolecularSequence.quality.end",                                                                              // MakerGen.cs:239
                        Id = "MolecularSequence.quality.end",                                                                               // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Integer                                                           // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 32. MolecularSequence.quality.score
                    this.Element_Score = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Score",                                                                                             // MakerGen.cs:238
                        Path= "MolecularSequence.quality.score",                                                                            // MakerGen.cs:239
                        Id = "MolecularSequence.quality.score",                                                                             // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                 // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 33. MolecularSequence.quality.method
                    this.Element_Method = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Method",                                                                                            // MakerGen.cs:238
                        Path= "MolecularSequence.quality.method",                                                                           // MakerGen.cs:239
                        Id = "MolecularSequence.quality.method",                                                                            // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            }                                                                                                               // MakerGen.cs:322
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 34. MolecularSequence.quality.truthTP
                    this.Element_TruthTP = new ElementDefinitionInfo                                                                        // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_TruthTP",                                                                                           // MakerGen.cs:238
                        Path= "MolecularSequence.quality.truthTP",                                                                          // MakerGen.cs:239
                        Id = "MolecularSequence.quality.truthTP",                                                                           // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Decimal                                                           // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 35. MolecularSequence.quality.queryTP
                    this.Element_QueryTP = new ElementDefinitionInfo                                                                        // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_QueryTP",                                                                                           // MakerGen.cs:238
                        Path= "MolecularSequence.quality.queryTP",                                                                          // MakerGen.cs:239
                        Id = "MolecularSequence.quality.queryTP",                                                                           // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Decimal                                                           // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 36. MolecularSequence.quality.truthFN
                    this.Element_TruthFN = new ElementDefinitionInfo                                                                        // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_TruthFN",                                                                                           // MakerGen.cs:238
                        Path= "MolecularSequence.quality.truthFN",                                                                          // MakerGen.cs:239
                        Id = "MolecularSequence.quality.truthFN",                                                                           // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Decimal                                                           // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 37. MolecularSequence.quality.queryFP
                    this.Element_QueryFP = new ElementDefinitionInfo                                                                        // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_QueryFP",                                                                                           // MakerGen.cs:238
                        Path= "MolecularSequence.quality.queryFP",                                                                          // MakerGen.cs:239
                        Id = "MolecularSequence.quality.queryFP",                                                                           // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Decimal                                                           // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 38. MolecularSequence.quality.gtFP
                    this.Element_GtFP = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_GtFP",                                                                                              // MakerGen.cs:238
                        Path= "MolecularSequence.quality.gtFP",                                                                             // MakerGen.cs:239
                        Id = "MolecularSequence.quality.gtFP",                                                                              // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Decimal                                                           // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 39. MolecularSequence.quality.precision
                    this.Element_Precision = new ElementDefinitionInfo                                                                      // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Precision",                                                                                         // MakerGen.cs:238
                        Path= "MolecularSequence.quality.precision",                                                                        // MakerGen.cs:239
                        Id = "MolecularSequence.quality.precision",                                                                         // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Decimal                                                           // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 40. MolecularSequence.quality.recall
                    this.Element_Recall = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Recall",                                                                                            // MakerGen.cs:238
                        Path= "MolecularSequence.quality.recall",                                                                           // MakerGen.cs:239
                        Id = "MolecularSequence.quality.recall",                                                                            // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Decimal                                                           // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 41. MolecularSequence.quality.fScore
                    this.Element_FScore = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_FScore",                                                                                            // MakerGen.cs:238
                        Path= "MolecularSequence.quality.fScore",                                                                           // MakerGen.cs:239
                        Id = "MolecularSequence.quality.fScore",                                                                            // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Decimal                                                           // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 42. MolecularSequence.quality.roc
                    this.Element_Roc = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Roc",                                                                                               // MakerGen.cs:238
                        Path= "MolecularSequence.quality.roc",                                                                              // MakerGen.cs:239
                        Id = "MolecularSequence.quality.roc",                                                                               // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new Type_Roc                                                                                                    // MakerGen.cs:262
                            {                                                                                                               // MakerGen.cs:263
                            }                                                                                                               // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 51. MolecularSequence.repository
        public class Type_Repository : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 52. MolecularSequence.repository.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:219
            // 53. MolecularSequence.repository.url
            public ElementDefinitionInfo Element_Url;                                                                                       // MakerGen.cs:219
            // 54. MolecularSequence.repository.name
            public ElementDefinitionInfo Element_Name;                                                                                      // MakerGen.cs:219
            // 55. MolecularSequence.repository.datasetId
            public ElementDefinitionInfo Element_DatasetId;                                                                                 // MakerGen.cs:219
            // 56. MolecularSequence.repository.variantsetId
            public ElementDefinitionInfo Element_VariantsetId;                                                                              // MakerGen.cs:219
            // 57. MolecularSequence.repository.readsetId
            public ElementDefinitionInfo Element_ReadsetId;                                                                                 // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "MolecularSequence.repository",                                                                                  // MakerGen.cs:395
                    ElementId = "MolecularSequence.repository"                                                                              // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:223
                Element_Url.Write(sDef);                                                                                                    // MakerGen.cs:223
                Element_Name.Write(sDef);                                                                                                   // MakerGen.cs:223
                Element_DatasetId.Write(sDef);                                                                                              // MakerGen.cs:223
                Element_VariantsetId.Write(sDef);                                                                                           // MakerGen.cs:223
                Element_ReadsetId.Write(sDef);                                                                                              // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_Repository()                                                                                                        // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 52. MolecularSequence.repository.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Type",                                                                                              // MakerGen.cs:238
                        Path= "MolecularSequence.repository.type",                                                                          // MakerGen.cs:239
                        Id = "MolecularSequence.repository.type",                                                                           // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                              // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 53. MolecularSequence.repository.url
                    this.Element_Url = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Url",                                                                                               // MakerGen.cs:238
                        Path= "MolecularSequence.repository.url",                                                                           // MakerGen.cs:239
                        Id = "MolecularSequence.repository.url",                                                                            // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Uri                                                               // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 54. MolecularSequence.repository.name
                    this.Element_Name = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Name",                                                                                              // MakerGen.cs:238
                        Path= "MolecularSequence.repository.name",                                                                          // MakerGen.cs:239
                        Id = "MolecularSequence.repository.name",                                                                           // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 55. MolecularSequence.repository.datasetId
                    this.Element_DatasetId = new ElementDefinitionInfo                                                                      // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_DatasetId",                                                                                         // MakerGen.cs:238
                        Path= "MolecularSequence.repository.datasetId",                                                                     // MakerGen.cs:239
                        Id = "MolecularSequence.repository.datasetId",                                                                      // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 56. MolecularSequence.repository.variantsetId
                    this.Element_VariantsetId = new ElementDefinitionInfo                                                                   // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_VariantsetId",                                                                                      // MakerGen.cs:238
                        Path= "MolecularSequence.repository.variantsetId",                                                                  // MakerGen.cs:239
                        Id = "MolecularSequence.repository.variantsetId",                                                                   // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 57. MolecularSequence.repository.readsetId
                    this.Element_ReadsetId = new ElementDefinitionInfo                                                                      // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_ReadsetId",                                                                                         // MakerGen.cs:238
                        Path= "MolecularSequence.repository.readsetId",                                                                     // MakerGen.cs:239
                        Id = "MolecularSequence.repository.readsetId",                                                                      // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 59. MolecularSequence.structureVariant
        public class Type_StructureVariant : FhirKhit.Maker.Common.Complex.ComplexBase                                                      // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 63. MolecularSequence.structureVariant.outer
            public class Type_Outer : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                // 64. MolecularSequence.structureVariant.outer.start
                public ElementDefinitionInfo Element_Start;                                                                                 // MakerGen.cs:219
                // 65. MolecularSequence.structureVariant.outer.end
                public ElementDefinitionInfo Element_End;                                                                                   // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:390
                {                                                                                                                           // MakerGen.cs:391
                    base.Write(sDef);                                                                                                       // MakerGen.cs:392
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        Path = "MolecularSequence.structureVariant.outer",                                                                  // MakerGen.cs:395
                        ElementId = "MolecularSequence.structureVariant.outer"                                                              // MakerGen.cs:396
                    });                                                                                                                     // MakerGen.cs:397
                    Element_Start.Write(sDef);                                                                                              // MakerGen.cs:223
                    Element_End.Write(sDef);                                                                                                // MakerGen.cs:223
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
                public Type_Outer()                                                                                                         // MakerGen.cs:402
                {                                                                                                                           // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:234
                        // 64. MolecularSequence.structureVariant.outer.start
                        this.Element_Start = new ElementDefinitionInfo                                                                      // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Start",                                                                                         // MakerGen.cs:238
                            Path= "MolecularSequence.structureVariant.outer.start",                                                         // MakerGen.cs:239
                            Id = "MolecularSequence.structureVariant.outer.start",                                                          // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Primitive.Primitive_Integer                                                       // MakerGen.cs:303
                                {                                                                                                           // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:307
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 65. MolecularSequence.structureVariant.outer.end
                        this.Element_End = new ElementDefinitionInfo                                                                        // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_End",                                                                                           // MakerGen.cs:238
                            Path= "MolecularSequence.structureVariant.outer.end",                                                           // MakerGen.cs:239
                            Id = "MolecularSequence.structureVariant.outer.end",                                                            // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Primitive.Primitive_Integer                                                       // MakerGen.cs:303
                                {                                                                                                           // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:307
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                }                                                                                                                           // MakerGen.cs:405
            }                                                                                                                               // MakerGen.cs:407
            // 66. MolecularSequence.structureVariant.inner
            public class Type_Inner : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                // 67. MolecularSequence.structureVariant.inner.start
                public ElementDefinitionInfo Element_Start;                                                                                 // MakerGen.cs:219
                // 68. MolecularSequence.structureVariant.inner.end
                public ElementDefinitionInfo Element_End;                                                                                   // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:390
                {                                                                                                                           // MakerGen.cs:391
                    base.Write(sDef);                                                                                                       // MakerGen.cs:392
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        Path = "MolecularSequence.structureVariant.inner",                                                                  // MakerGen.cs:395
                        ElementId = "MolecularSequence.structureVariant.inner"                                                              // MakerGen.cs:396
                    });                                                                                                                     // MakerGen.cs:397
                    Element_Start.Write(sDef);                                                                                              // MakerGen.cs:223
                    Element_End.Write(sDef);                                                                                                // MakerGen.cs:223
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
                public Type_Inner()                                                                                                         // MakerGen.cs:402
                {                                                                                                                           // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:234
                        // 67. MolecularSequence.structureVariant.inner.start
                        this.Element_Start = new ElementDefinitionInfo                                                                      // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Start",                                                                                         // MakerGen.cs:238
                            Path= "MolecularSequence.structureVariant.inner.start",                                                         // MakerGen.cs:239
                            Id = "MolecularSequence.structureVariant.inner.start",                                                          // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Primitive.Primitive_Integer                                                       // MakerGen.cs:303
                                {                                                                                                           // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:307
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 68. MolecularSequence.structureVariant.inner.end
                        this.Element_End = new ElementDefinitionInfo                                                                        // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_End",                                                                                           // MakerGen.cs:238
                            Path= "MolecularSequence.structureVariant.inner.end",                                                           // MakerGen.cs:239
                            Id = "MolecularSequence.structureVariant.inner.end",                                                            // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Primitive.Primitive_Integer                                                       // MakerGen.cs:303
                                {                                                                                                           // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:307
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                }                                                                                                                           // MakerGen.cs:405
            }                                                                                                                               // MakerGen.cs:407
            // 60. MolecularSequence.structureVariant.variantType
            public ElementDefinitionInfo Element_VariantType;                                                                               // MakerGen.cs:219
            // 61. MolecularSequence.structureVariant.exact
            public ElementDefinitionInfo Element_Exact;                                                                                     // MakerGen.cs:219
            // 62. MolecularSequence.structureVariant.length
            public ElementDefinitionInfo Element_Length;                                                                                    // MakerGen.cs:219
            // 63. MolecularSequence.structureVariant.outer
            public ElementDefinitionInfo Element_Outer;                                                                                     // MakerGen.cs:219
            // 66. MolecularSequence.structureVariant.inner
            public ElementDefinitionInfo Element_Inner;                                                                                     // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "MolecularSequence.structureVariant",                                                                            // MakerGen.cs:395
                    ElementId = "MolecularSequence.structureVariant"                                                                        // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_VariantType.Write(sDef);                                                                                            // MakerGen.cs:223
                Element_Exact.Write(sDef);                                                                                                  // MakerGen.cs:223
                Element_Length.Write(sDef);                                                                                                 // MakerGen.cs:223
                Element_Outer.Write(sDef);                                                                                                  // MakerGen.cs:223
                Element_Inner.Write(sDef);                                                                                                  // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_StructureVariant()                                                                                                  // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 60. MolecularSequence.structureVariant.variantType
                    this.Element_VariantType = new ElementDefinitionInfo                                                                    // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_VariantType",                                                                                       // MakerGen.cs:238
                        Path= "MolecularSequence.structureVariant.variantType",                                                             // MakerGen.cs:239
                        Id = "MolecularSequence.structureVariant.variantType",                                                              // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            }                                                                                                               // MakerGen.cs:322
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 61. MolecularSequence.structureVariant.exact
                    this.Element_Exact = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Exact",                                                                                             // MakerGen.cs:238
                        Path= "MolecularSequence.structureVariant.exact",                                                                   // MakerGen.cs:239
                        Id = "MolecularSequence.structureVariant.exact",                                                                    // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                           // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 62. MolecularSequence.structureVariant.length
                    this.Element_Length = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Length",                                                                                            // MakerGen.cs:238
                        Path= "MolecularSequence.structureVariant.length",                                                                  // MakerGen.cs:239
                        Id = "MolecularSequence.structureVariant.length",                                                                   // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Integer                                                           // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 63. MolecularSequence.structureVariant.outer
                    this.Element_Outer = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Outer",                                                                                             // MakerGen.cs:238
                        Path= "MolecularSequence.structureVariant.outer",                                                                   // MakerGen.cs:239
                        Id = "MolecularSequence.structureVariant.outer",                                                                    // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new Type_Outer                                                                                                  // MakerGen.cs:262
                            {                                                                                                               // MakerGen.cs:263
                            }                                                                                                               // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 66. MolecularSequence.structureVariant.inner
                    this.Element_Inner = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Inner",                                                                                             // MakerGen.cs:238
                        Path= "MolecularSequence.structureVariant.inner",                                                                   // MakerGen.cs:239
                        Id = "MolecularSequence.structureVariant.inner",                                                                    // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new Type_Inner                                                                                                  // MakerGen.cs:262
                            {                                                                                                               // MakerGen.cs:263
                            }                                                                                                               // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 1. MolecularSequence.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:219
        // 2. MolecularSequence.type
        public ElementDefinitionInfo Element_Type;                                                                                          // MakerGen.cs:219
        // 3. MolecularSequence.coordinateSystem
        public ElementDefinitionInfo Element_CoordinateSystem;                                                                              // MakerGen.cs:219
        // 4. MolecularSequence.patient
        public ElementDefinitionInfo Element_Patient;                                                                                       // MakerGen.cs:219
        // 5. MolecularSequence.specimen
        public ElementDefinitionInfo Element_Specimen;                                                                                      // MakerGen.cs:219
        // 6. MolecularSequence.device
        public ElementDefinitionInfo Element_Device;                                                                                        // MakerGen.cs:219
        // 7. MolecularSequence.performer
        public ElementDefinitionInfo Element_Performer;                                                                                     // MakerGen.cs:219
        // 8. MolecularSequence.quantity
        public ElementDefinitionInfo Element_Quantity;                                                                                      // MakerGen.cs:219
        // 9. MolecularSequence.referenceSeq
        public ElementDefinitionInfo Element_ReferenceSeq;                                                                                  // MakerGen.cs:219
        // 19. MolecularSequence.variant
        public ElementDefinitionInfo Element_Variant;                                                                                       // MakerGen.cs:219
        // 26. MolecularSequence.observedSeq
        public ElementDefinitionInfo Element_ObservedSeq;                                                                                   // MakerGen.cs:219
        // 27. MolecularSequence.quality
        public ElementDefinitionInfo Element_Quality;                                                                                       // MakerGen.cs:219
        // 50. MolecularSequence.readCoverage
        public ElementDefinitionInfo Element_ReadCoverage;                                                                                  // MakerGen.cs:219
        // 51. MolecularSequence.repository
        public ElementDefinitionInfo Element_Repository;                                                                                    // MakerGen.cs:219
        // 58. MolecularSequence.pointer
        public ElementDefinitionInfo Element_Pointer;                                                                                       // MakerGen.cs:219
        // 59. MolecularSequence.structureVariant
        public ElementDefinitionInfo Element_StructureVariant;                                                                              // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:390
        {                                                                                                                                   // MakerGen.cs:391
            base.Write(sDef);                                                                                                               // MakerGen.cs:392
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                Path = "MolecularSequence",                                                                                                 // MakerGen.cs:395
                ElementId = "MolecularSequence"                                                                                             // MakerGen.cs:396
            });                                                                                                                             // MakerGen.cs:397
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_Type.Write(sDef);                                                                                                       // MakerGen.cs:223
            Element_CoordinateSystem.Write(sDef);                                                                                           // MakerGen.cs:223
            Element_Patient.Write(sDef);                                                                                                    // MakerGen.cs:223
            Element_Specimen.Write(sDef);                                                                                                   // MakerGen.cs:223
            Element_Device.Write(sDef);                                                                                                     // MakerGen.cs:223
            Element_Performer.Write(sDef);                                                                                                  // MakerGen.cs:223
            Element_Quantity.Write(sDef);                                                                                                   // MakerGen.cs:223
            Element_ReferenceSeq.Write(sDef);                                                                                               // MakerGen.cs:223
            Element_Variant.Write(sDef);                                                                                                    // MakerGen.cs:223
            Element_ObservedSeq.Write(sDef);                                                                                                // MakerGen.cs:223
            Element_Quality.Write(sDef);                                                                                                    // MakerGen.cs:223
            Element_ReadCoverage.Write(sDef);                                                                                               // MakerGen.cs:223
            Element_Repository.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_Pointer.Write(sDef);                                                                                                    // MakerGen.cs:223
            Element_StructureVariant.Write(sDef);                                                                                           // MakerGen.cs:223
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
        public Resource_MolecularSequence()                                                                                                 // MakerGen.cs:402
        {                                                                                                                                   // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:234
                // 1. MolecularSequence.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:238
                    Path= "MolecularSequence.identifier",                                                                                   // MakerGen.cs:239
                    Id = "MolecularSequence.identifier",                                                                                    // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 2. MolecularSequence.type
                this.Element_Type = new ElementDefinitionInfo                                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Type",                                                                                                  // MakerGen.cs:238
                    Path= "MolecularSequence.type",                                                                                         // MakerGen.cs:239
                    Id = "MolecularSequence.type",                                                                                          // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 3. MolecularSequence.coordinateSystem
                this.Element_CoordinateSystem = new ElementDefinitionInfo                                                                   // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_CoordinateSystem",                                                                                      // MakerGen.cs:238
                    Path= "MolecularSequence.coordinateSystem",                                                                             // MakerGen.cs:239
                    Id = "MolecularSequence.coordinateSystem",                                                                              // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Integer                                                               // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 4. MolecularSequence.patient
                this.Element_Patient = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Patient",                                                                                               // MakerGen.cs:238
                    Path= "MolecularSequence.patient",                                                                                      // MakerGen.cs:239
                    Id = "MolecularSequence.patient",                                                                                       // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Patient"                                                           // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 5. MolecularSequence.specimen
                this.Element_Specimen = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Specimen",                                                                                              // MakerGen.cs:238
                    Path= "MolecularSequence.specimen",                                                                                     // MakerGen.cs:239
                    Id = "MolecularSequence.specimen",                                                                                      // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Specimen"                                                          // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 6. MolecularSequence.device
                this.Element_Device = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Device",                                                                                                // MakerGen.cs:238
                    Path= "MolecularSequence.device",                                                                                       // MakerGen.cs:239
                    Id = "MolecularSequence.device",                                                                                        // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Device"                                                            // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 7. MolecularSequence.performer
                this.Element_Performer = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Performer",                                                                                             // MakerGen.cs:238
                    Path= "MolecularSequence.performer",                                                                                    // MakerGen.cs:239
                    Id = "MolecularSequence.performer",                                                                                     // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Organization"                                                      // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 8. MolecularSequence.quantity
                this.Element_Quantity = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Quantity",                                                                                              // MakerGen.cs:238
                    Path= "MolecularSequence.quantity",                                                                                     // MakerGen.cs:239
                    Id = "MolecularSequence.quantity",                                                                                      // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                     // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 9. MolecularSequence.referenceSeq
                this.Element_ReferenceSeq = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_ReferenceSeq",                                                                                          // MakerGen.cs:238
                    Path= "MolecularSequence.referenceSeq",                                                                                 // MakerGen.cs:239
                    Id = "MolecularSequence.referenceSeq",                                                                                  // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_ReferenceSeq                                                                                               // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 19. MolecularSequence.variant
                this.Element_Variant = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Variant",                                                                                               // MakerGen.cs:238
                    Path= "MolecularSequence.variant",                                                                                      // MakerGen.cs:239
                    Id = "MolecularSequence.variant",                                                                                       // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_Variant                                                                                                    // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 26. MolecularSequence.observedSeq
                this.Element_ObservedSeq = new ElementDefinitionInfo                                                                        // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_ObservedSeq",                                                                                           // MakerGen.cs:238
                    Path= "MolecularSequence.observedSeq",                                                                                  // MakerGen.cs:239
                    Id = "MolecularSequence.observedSeq",                                                                                   // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 27. MolecularSequence.quality
                this.Element_Quality = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Quality",                                                                                               // MakerGen.cs:238
                    Path= "MolecularSequence.quality",                                                                                      // MakerGen.cs:239
                    Id = "MolecularSequence.quality",                                                                                       // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_Quality                                                                                                    // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 50. MolecularSequence.readCoverage
                this.Element_ReadCoverage = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_ReadCoverage",                                                                                          // MakerGen.cs:238
                    Path= "MolecularSequence.readCoverage",                                                                                 // MakerGen.cs:239
                    Id = "MolecularSequence.readCoverage",                                                                                  // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Integer                                                               // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 51. MolecularSequence.repository
                this.Element_Repository = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Repository",                                                                                            // MakerGen.cs:238
                    Path= "MolecularSequence.repository",                                                                                   // MakerGen.cs:239
                    Id = "MolecularSequence.repository",                                                                                    // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_Repository                                                                                                 // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 58. MolecularSequence.pointer
                this.Element_Pointer = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Pointer",                                                                                               // MakerGen.cs:238
                    Path= "MolecularSequence.pointer",                                                                                      // MakerGen.cs:239
                    Id = "MolecularSequence.pointer",                                                                                       // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/MolecularSequence"                                                 // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 59. MolecularSequence.structureVariant
                this.Element_StructureVariant = new ElementDefinitionInfo                                                                   // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_StructureVariant",                                                                                      // MakerGen.cs:238
                    Path= "MolecularSequence.structureVariant",                                                                             // MakerGen.cs:239
                    Id = "MolecularSequence.structureVariant",                                                                              // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_StructureVariant                                                                                           // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            this.Name = "MolecularSequence";                                                                                                // MakerGen.cs:471
            this.Uri = "http://hl7.org/fhir/StructureDefinition/MolecularSequence";                                                         // MakerGen.cs:472
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:407
}                                                                                                                                           // MakerGen.cs:452
