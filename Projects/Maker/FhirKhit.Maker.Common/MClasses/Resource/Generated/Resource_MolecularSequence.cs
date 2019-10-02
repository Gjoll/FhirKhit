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
    #endregion
    /// <summary>
    /// Fhir resource 'MolecularSequence'
    /// </summary>
    // 0. MolecularSequence
    public class Resource_MolecularSequence : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 9. MolecularSequence.referenceSeq
        public class Type_ReferenceSeq : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 10. MolecularSequence.referenceSeq.chromosome
            public ElementDefinitionInfo Element_Chromosome;
            // 11. MolecularSequence.referenceSeq.genomeBuild
            public ElementDefinitionInfo Element_GenomeBuild;
            // 12. MolecularSequence.referenceSeq.orientation
            public ElementDefinitionInfo Element_Orientation;
            // 13. MolecularSequence.referenceSeq.referenceSeqId
            public ElementDefinitionInfo Element_ReferenceSeqId;
            // 14. MolecularSequence.referenceSeq.referenceSeqPointer
            public ElementDefinitionInfo Element_ReferenceSeqPointer;
            // 15. MolecularSequence.referenceSeq.referenceSeqString
            public ElementDefinitionInfo Element_ReferenceSeqString;
            // 16. MolecularSequence.referenceSeq.strand
            public ElementDefinitionInfo Element_Strand;
            // 17. MolecularSequence.referenceSeq.windowStart
            public ElementDefinitionInfo Element_WindowStart;
            // 18. MolecularSequence.referenceSeq.windowEnd
            public ElementDefinitionInfo Element_WindowEnd;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "MolecularSequence.referenceSeq",
                    ElementId = "MolecularSequence.referenceSeq"
                });
                Element_Chromosome.Write(sDef);
                Element_GenomeBuild.Write(sDef);
                Element_Orientation.Write(sDef);
                Element_ReferenceSeqId.Write(sDef);
                Element_ReferenceSeqPointer.Write(sDef);
                Element_ReferenceSeqString.Write(sDef);
                Element_Strand.Write(sDef);
                Element_WindowStart.Write(sDef);
                Element_WindowEnd.Write(sDef);
            }
            
            public Type_ReferenceSeq()
            {
                {
                    // 10. MolecularSequence.referenceSeq.chromosome
                    this.Element_Chromosome = new ElementDefinitionInfo
                    {
                        Name = "Element_Chromosome",
                        Path= "MolecularSequence.referenceSeq.chromosome",
                        Id = "MolecularSequence.referenceSeq.chromosome",
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
                    // 11. MolecularSequence.referenceSeq.genomeBuild
                    this.Element_GenomeBuild = new ElementDefinitionInfo
                    {
                        Name = "Element_GenomeBuild",
                        Path= "MolecularSequence.referenceSeq.genomeBuild",
                        Id = "MolecularSequence.referenceSeq.genomeBuild",
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
                    // 12. MolecularSequence.referenceSeq.orientation
                    this.Element_Orientation = new ElementDefinitionInfo
                    {
                        Name = "Element_Orientation",
                        Path= "MolecularSequence.referenceSeq.orientation",
                        Id = "MolecularSequence.referenceSeq.orientation",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Code
                            {
                            }
                        }
                    };
                }
                {
                    // 13. MolecularSequence.referenceSeq.referenceSeqId
                    this.Element_ReferenceSeqId = new ElementDefinitionInfo
                    {
                        Name = "Element_ReferenceSeqId",
                        Path= "MolecularSequence.referenceSeq.referenceSeqId",
                        Id = "MolecularSequence.referenceSeq.referenceSeqId",
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
                    // 14. MolecularSequence.referenceSeq.referenceSeqPointer
                    this.Element_ReferenceSeqPointer = new ElementDefinitionInfo
                    {
                        Name = "Element_ReferenceSeqPointer",
                        Path= "MolecularSequence.referenceSeq.referenceSeqPointer",
                        Id = "MolecularSequence.referenceSeq.referenceSeqPointer",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/MolecularSequence"
                                }
                            }
                        }
                    };
                }
                {
                    // 15. MolecularSequence.referenceSeq.referenceSeqString
                    this.Element_ReferenceSeqString = new ElementDefinitionInfo
                    {
                        Name = "Element_ReferenceSeqString",
                        Path= "MolecularSequence.referenceSeq.referenceSeqString",
                        Id = "MolecularSequence.referenceSeq.referenceSeqString",
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
                    // 16. MolecularSequence.referenceSeq.strand
                    this.Element_Strand = new ElementDefinitionInfo
                    {
                        Name = "Element_Strand",
                        Path= "MolecularSequence.referenceSeq.strand",
                        Id = "MolecularSequence.referenceSeq.strand",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Code
                            {
                            }
                        }
                    };
                }
                {
                    // 17. MolecularSequence.referenceSeq.windowStart
                    this.Element_WindowStart = new ElementDefinitionInfo
                    {
                        Name = "Element_WindowStart",
                        Path= "MolecularSequence.referenceSeq.windowStart",
                        Id = "MolecularSequence.referenceSeq.windowStart",
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
                    // 18. MolecularSequence.referenceSeq.windowEnd
                    this.Element_WindowEnd = new ElementDefinitionInfo
                    {
                        Name = "Element_WindowEnd",
                        Path= "MolecularSequence.referenceSeq.windowEnd",
                        Id = "MolecularSequence.referenceSeq.windowEnd",
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
            }
        }
        // 19. MolecularSequence.variant
        public class Type_Variant : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 20. MolecularSequence.variant.start
            public ElementDefinitionInfo Element_Start;
            // 21. MolecularSequence.variant.end
            public ElementDefinitionInfo Element_End;
            // 22. MolecularSequence.variant.observedAllele
            public ElementDefinitionInfo Element_ObservedAllele;
            // 23. MolecularSequence.variant.referenceAllele
            public ElementDefinitionInfo Element_ReferenceAllele;
            // 24. MolecularSequence.variant.cigar
            public ElementDefinitionInfo Element_Cigar;
            // 25. MolecularSequence.variant.variantPointer
            public ElementDefinitionInfo Element_VariantPointer;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "MolecularSequence.variant",
                    ElementId = "MolecularSequence.variant"
                });
                Element_Start.Write(sDef);
                Element_End.Write(sDef);
                Element_ObservedAllele.Write(sDef);
                Element_ReferenceAllele.Write(sDef);
                Element_Cigar.Write(sDef);
                Element_VariantPointer.Write(sDef);
            }
            
            public Type_Variant()
            {
                {
                    // 20. MolecularSequence.variant.start
                    this.Element_Start = new ElementDefinitionInfo
                    {
                        Name = "Element_Start",
                        Path= "MolecularSequence.variant.start",
                        Id = "MolecularSequence.variant.start",
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
                    // 21. MolecularSequence.variant.end
                    this.Element_End = new ElementDefinitionInfo
                    {
                        Name = "Element_End",
                        Path= "MolecularSequence.variant.end",
                        Id = "MolecularSequence.variant.end",
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
                    // 22. MolecularSequence.variant.observedAllele
                    this.Element_ObservedAllele = new ElementDefinitionInfo
                    {
                        Name = "Element_ObservedAllele",
                        Path= "MolecularSequence.variant.observedAllele",
                        Id = "MolecularSequence.variant.observedAllele",
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
                    // 23. MolecularSequence.variant.referenceAllele
                    this.Element_ReferenceAllele = new ElementDefinitionInfo
                    {
                        Name = "Element_ReferenceAllele",
                        Path= "MolecularSequence.variant.referenceAllele",
                        Id = "MolecularSequence.variant.referenceAllele",
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
                    // 24. MolecularSequence.variant.cigar
                    this.Element_Cigar = new ElementDefinitionInfo
                    {
                        Name = "Element_Cigar",
                        Path= "MolecularSequence.variant.cigar",
                        Id = "MolecularSequence.variant.cigar",
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
                    // 25. MolecularSequence.variant.variantPointer
                    this.Element_VariantPointer = new ElementDefinitionInfo
                    {
                        Name = "Element_VariantPointer",
                        Path= "MolecularSequence.variant.variantPointer",
                        Id = "MolecularSequence.variant.variantPointer",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Observation"
                                }
                            }
                        }
                    };
                }
            }
        }
        // 27. MolecularSequence.quality
        public class Type_Quality : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 42. MolecularSequence.quality.roc
            public class Type_Roc : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 43. MolecularSequence.quality.roc.score
                public ElementDefinitionInfo Element_Score;
                // 44. MolecularSequence.quality.roc.numTP
                public ElementDefinitionInfo Element_NumTP;
                // 45. MolecularSequence.quality.roc.numFP
                public ElementDefinitionInfo Element_NumFP;
                // 46. MolecularSequence.quality.roc.numFN
                public ElementDefinitionInfo Element_NumFN;
                // 47. MolecularSequence.quality.roc.precision
                public ElementDefinitionInfo Element_Precision;
                // 48. MolecularSequence.quality.roc.sensitivity
                public ElementDefinitionInfo Element_Sensitivity;
                // 49. MolecularSequence.quality.roc.fMeasure
                public ElementDefinitionInfo Element_FMeasure;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "MolecularSequence.quality.roc",
                        ElementId = "MolecularSequence.quality.roc"
                    });
                    Element_Score.Write(sDef);
                    Element_NumTP.Write(sDef);
                    Element_NumFP.Write(sDef);
                    Element_NumFN.Write(sDef);
                    Element_Precision.Write(sDef);
                    Element_Sensitivity.Write(sDef);
                    Element_FMeasure.Write(sDef);
                }
                
                public Type_Roc()
                {
                    {
                        // 43. MolecularSequence.quality.roc.score
                        this.Element_Score = new ElementDefinitionInfo
                        {
                            Name = "Element_Score",
                            Path= "MolecularSequence.quality.roc.score",
                            Id = "MolecularSequence.quality.roc.score",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_Integer
                                {
                                }
                            }
                        };
                    }
                    {
                        // 44. MolecularSequence.quality.roc.numTP
                        this.Element_NumTP = new ElementDefinitionInfo
                        {
                            Name = "Element_NumTP",
                            Path= "MolecularSequence.quality.roc.numTP",
                            Id = "MolecularSequence.quality.roc.numTP",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_Integer
                                {
                                }
                            }
                        };
                    }
                    {
                        // 45. MolecularSequence.quality.roc.numFP
                        this.Element_NumFP = new ElementDefinitionInfo
                        {
                            Name = "Element_NumFP",
                            Path= "MolecularSequence.quality.roc.numFP",
                            Id = "MolecularSequence.quality.roc.numFP",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_Integer
                                {
                                }
                            }
                        };
                    }
                    {
                        // 46. MolecularSequence.quality.roc.numFN
                        this.Element_NumFN = new ElementDefinitionInfo
                        {
                            Name = "Element_NumFN",
                            Path= "MolecularSequence.quality.roc.numFN",
                            Id = "MolecularSequence.quality.roc.numFN",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_Integer
                                {
                                }
                            }
                        };
                    }
                    {
                        // 47. MolecularSequence.quality.roc.precision
                        this.Element_Precision = new ElementDefinitionInfo
                        {
                            Name = "Element_Precision",
                            Path= "MolecularSequence.quality.roc.precision",
                            Id = "MolecularSequence.quality.roc.precision",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_Decimal
                                {
                                }
                            }
                        };
                    }
                    {
                        // 48. MolecularSequence.quality.roc.sensitivity
                        this.Element_Sensitivity = new ElementDefinitionInfo
                        {
                            Name = "Element_Sensitivity",
                            Path= "MolecularSequence.quality.roc.sensitivity",
                            Id = "MolecularSequence.quality.roc.sensitivity",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_Decimal
                                {
                                }
                            }
                        };
                    }
                    {
                        // 49. MolecularSequence.quality.roc.fMeasure
                        this.Element_FMeasure = new ElementDefinitionInfo
                        {
                            Name = "Element_FMeasure",
                            Path= "MolecularSequence.quality.roc.fMeasure",
                            Id = "MolecularSequence.quality.roc.fMeasure",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_Decimal
                                {
                                }
                            }
                        };
                    }
                }
            }
            // 28. MolecularSequence.quality.type
            public ElementDefinitionInfo Element_Type;
            // 29. MolecularSequence.quality.standardSequence
            public ElementDefinitionInfo Element_StandardSequence;
            // 30. MolecularSequence.quality.start
            public ElementDefinitionInfo Element_Start;
            // 31. MolecularSequence.quality.end
            public ElementDefinitionInfo Element_End;
            // 32. MolecularSequence.quality.score
            public ElementDefinitionInfo Element_Score;
            // 33. MolecularSequence.quality.method
            public ElementDefinitionInfo Element_Method;
            // 34. MolecularSequence.quality.truthTP
            public ElementDefinitionInfo Element_TruthTP;
            // 35. MolecularSequence.quality.queryTP
            public ElementDefinitionInfo Element_QueryTP;
            // 36. MolecularSequence.quality.truthFN
            public ElementDefinitionInfo Element_TruthFN;
            // 37. MolecularSequence.quality.queryFP
            public ElementDefinitionInfo Element_QueryFP;
            // 38. MolecularSequence.quality.gtFP
            public ElementDefinitionInfo Element_GtFP;
            // 39. MolecularSequence.quality.precision
            public ElementDefinitionInfo Element_Precision;
            // 40. MolecularSequence.quality.recall
            public ElementDefinitionInfo Element_Recall;
            // 41. MolecularSequence.quality.fScore
            public ElementDefinitionInfo Element_FScore;
            // 42. MolecularSequence.quality.roc
            public ElementDefinitionInfo Element_Roc;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "MolecularSequence.quality",
                    ElementId = "MolecularSequence.quality"
                });
                Element_Type.Write(sDef);
                Element_StandardSequence.Write(sDef);
                Element_Start.Write(sDef);
                Element_End.Write(sDef);
                Element_Score.Write(sDef);
                Element_Method.Write(sDef);
                Element_TruthTP.Write(sDef);
                Element_QueryTP.Write(sDef);
                Element_TruthFN.Write(sDef);
                Element_QueryFP.Write(sDef);
                Element_GtFP.Write(sDef);
                Element_Precision.Write(sDef);
                Element_Recall.Write(sDef);
                Element_FScore.Write(sDef);
                Element_Roc.Write(sDef);
            }
            
            public Type_Quality()
            {
                {
                    // 28. MolecularSequence.quality.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "MolecularSequence.quality.type",
                        Id = "MolecularSequence.quality.type",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Code
                            {
                            }
                        }
                    };
                }
                {
                    // 29. MolecularSequence.quality.standardSequence
                    this.Element_StandardSequence = new ElementDefinitionInfo
                    {
                        Name = "Element_StandardSequence",
                        Path= "MolecularSequence.quality.standardSequence",
                        Id = "MolecularSequence.quality.standardSequence",
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
                    // 30. MolecularSequence.quality.start
                    this.Element_Start = new ElementDefinitionInfo
                    {
                        Name = "Element_Start",
                        Path= "MolecularSequence.quality.start",
                        Id = "MolecularSequence.quality.start",
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
                    // 31. MolecularSequence.quality.end
                    this.Element_End = new ElementDefinitionInfo
                    {
                        Name = "Element_End",
                        Path= "MolecularSequence.quality.end",
                        Id = "MolecularSequence.quality.end",
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
                    // 32. MolecularSequence.quality.score
                    this.Element_Score = new ElementDefinitionInfo
                    {
                        Name = "Element_Score",
                        Path= "MolecularSequence.quality.score",
                        Id = "MolecularSequence.quality.score",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Quantity
                            {
                            }
                        }
                    };
                }
                {
                    // 33. MolecularSequence.quality.method
                    this.Element_Method = new ElementDefinitionInfo
                    {
                        Name = "Element_Method",
                        Path= "MolecularSequence.quality.method",
                        Id = "MolecularSequence.quality.method",
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
                    // 34. MolecularSequence.quality.truthTP
                    this.Element_TruthTP = new ElementDefinitionInfo
                    {
                        Name = "Element_TruthTP",
                        Path= "MolecularSequence.quality.truthTP",
                        Id = "MolecularSequence.quality.truthTP",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Decimal
                            {
                            }
                        }
                    };
                }
                {
                    // 35. MolecularSequence.quality.queryTP
                    this.Element_QueryTP = new ElementDefinitionInfo
                    {
                        Name = "Element_QueryTP",
                        Path= "MolecularSequence.quality.queryTP",
                        Id = "MolecularSequence.quality.queryTP",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Decimal
                            {
                            }
                        }
                    };
                }
                {
                    // 36. MolecularSequence.quality.truthFN
                    this.Element_TruthFN = new ElementDefinitionInfo
                    {
                        Name = "Element_TruthFN",
                        Path= "MolecularSequence.quality.truthFN",
                        Id = "MolecularSequence.quality.truthFN",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Decimal
                            {
                            }
                        }
                    };
                }
                {
                    // 37. MolecularSequence.quality.queryFP
                    this.Element_QueryFP = new ElementDefinitionInfo
                    {
                        Name = "Element_QueryFP",
                        Path= "MolecularSequence.quality.queryFP",
                        Id = "MolecularSequence.quality.queryFP",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Decimal
                            {
                            }
                        }
                    };
                }
                {
                    // 38. MolecularSequence.quality.gtFP
                    this.Element_GtFP = new ElementDefinitionInfo
                    {
                        Name = "Element_GtFP",
                        Path= "MolecularSequence.quality.gtFP",
                        Id = "MolecularSequence.quality.gtFP",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Decimal
                            {
                            }
                        }
                    };
                }
                {
                    // 39. MolecularSequence.quality.precision
                    this.Element_Precision = new ElementDefinitionInfo
                    {
                        Name = "Element_Precision",
                        Path= "MolecularSequence.quality.precision",
                        Id = "MolecularSequence.quality.precision",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Decimal
                            {
                            }
                        }
                    };
                }
                {
                    // 40. MolecularSequence.quality.recall
                    this.Element_Recall = new ElementDefinitionInfo
                    {
                        Name = "Element_Recall",
                        Path= "MolecularSequence.quality.recall",
                        Id = "MolecularSequence.quality.recall",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Decimal
                            {
                            }
                        }
                    };
                }
                {
                    // 41. MolecularSequence.quality.fScore
                    this.Element_FScore = new ElementDefinitionInfo
                    {
                        Name = "Element_FScore",
                        Path= "MolecularSequence.quality.fScore",
                        Id = "MolecularSequence.quality.fScore",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Decimal
                            {
                            }
                        }
                    };
                }
                {
                    // 42. MolecularSequence.quality.roc
                    this.Element_Roc = new ElementDefinitionInfo
                    {
                        Name = "Element_Roc",
                        Path= "MolecularSequence.quality.roc",
                        Id = "MolecularSequence.quality.roc",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new Type_Roc
                            {
                            }
                        }
                    };
                }
            }
        }
        // 51. MolecularSequence.repository
        public class Type_Repository : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 52. MolecularSequence.repository.type
            public ElementDefinitionInfo Element_Type;
            // 53. MolecularSequence.repository.url
            public ElementDefinitionInfo Element_Url;
            // 54. MolecularSequence.repository.name
            public ElementDefinitionInfo Element_Name;
            // 55. MolecularSequence.repository.datasetId
            public ElementDefinitionInfo Element_DatasetId;
            // 56. MolecularSequence.repository.variantsetId
            public ElementDefinitionInfo Element_VariantsetId;
            // 57. MolecularSequence.repository.readsetId
            public ElementDefinitionInfo Element_ReadsetId;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "MolecularSequence.repository",
                    ElementId = "MolecularSequence.repository"
                });
                Element_Type.Write(sDef);
                Element_Url.Write(sDef);
                Element_Name.Write(sDef);
                Element_DatasetId.Write(sDef);
                Element_VariantsetId.Write(sDef);
                Element_ReadsetId.Write(sDef);
            }
            
            public Type_Repository()
            {
                {
                    // 52. MolecularSequence.repository.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "MolecularSequence.repository.type",
                        Id = "MolecularSequence.repository.type",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Code
                            {
                            }
                        }
                    };
                }
                {
                    // 53. MolecularSequence.repository.url
                    this.Element_Url = new ElementDefinitionInfo
                    {
                        Name = "Element_Url",
                        Path= "MolecularSequence.repository.url",
                        Id = "MolecularSequence.repository.url",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Uri
                            {
                            }
                        }
                    };
                }
                {
                    // 54. MolecularSequence.repository.name
                    this.Element_Name = new ElementDefinitionInfo
                    {
                        Name = "Element_Name",
                        Path= "MolecularSequence.repository.name",
                        Id = "MolecularSequence.repository.name",
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
                    // 55. MolecularSequence.repository.datasetId
                    this.Element_DatasetId = new ElementDefinitionInfo
                    {
                        Name = "Element_DatasetId",
                        Path= "MolecularSequence.repository.datasetId",
                        Id = "MolecularSequence.repository.datasetId",
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
                    // 56. MolecularSequence.repository.variantsetId
                    this.Element_VariantsetId = new ElementDefinitionInfo
                    {
                        Name = "Element_VariantsetId",
                        Path= "MolecularSequence.repository.variantsetId",
                        Id = "MolecularSequence.repository.variantsetId",
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
                    // 57. MolecularSequence.repository.readsetId
                    this.Element_ReadsetId = new ElementDefinitionInfo
                    {
                        Name = "Element_ReadsetId",
                        Path= "MolecularSequence.repository.readsetId",
                        Id = "MolecularSequence.repository.readsetId",
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
        // 59. MolecularSequence.structureVariant
        public class Type_StructureVariant : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 63. MolecularSequence.structureVariant.outer
            public class Type_Outer : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 64. MolecularSequence.structureVariant.outer.start
                public ElementDefinitionInfo Element_Start;
                // 65. MolecularSequence.structureVariant.outer.end
                public ElementDefinitionInfo Element_End;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "MolecularSequence.structureVariant.outer",
                        ElementId = "MolecularSequence.structureVariant.outer"
                    });
                    Element_Start.Write(sDef);
                    Element_End.Write(sDef);
                }
                
                public Type_Outer()
                {
                    {
                        // 64. MolecularSequence.structureVariant.outer.start
                        this.Element_Start = new ElementDefinitionInfo
                        {
                            Name = "Element_Start",
                            Path= "MolecularSequence.structureVariant.outer.start",
                            Id = "MolecularSequence.structureVariant.outer.start",
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
                        // 65. MolecularSequence.structureVariant.outer.end
                        this.Element_End = new ElementDefinitionInfo
                        {
                            Name = "Element_End",
                            Path= "MolecularSequence.structureVariant.outer.end",
                            Id = "MolecularSequence.structureVariant.outer.end",
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
                }
            }
            // 66. MolecularSequence.structureVariant.inner
            public class Type_Inner : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 67. MolecularSequence.structureVariant.inner.start
                public ElementDefinitionInfo Element_Start;
                // 68. MolecularSequence.structureVariant.inner.end
                public ElementDefinitionInfo Element_End;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "MolecularSequence.structureVariant.inner",
                        ElementId = "MolecularSequence.structureVariant.inner"
                    });
                    Element_Start.Write(sDef);
                    Element_End.Write(sDef);
                }
                
                public Type_Inner()
                {
                    {
                        // 67. MolecularSequence.structureVariant.inner.start
                        this.Element_Start = new ElementDefinitionInfo
                        {
                            Name = "Element_Start",
                            Path= "MolecularSequence.structureVariant.inner.start",
                            Id = "MolecularSequence.structureVariant.inner.start",
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
                        // 68. MolecularSequence.structureVariant.inner.end
                        this.Element_End = new ElementDefinitionInfo
                        {
                            Name = "Element_End",
                            Path= "MolecularSequence.structureVariant.inner.end",
                            Id = "MolecularSequence.structureVariant.inner.end",
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
                }
            }
            // 60. MolecularSequence.structureVariant.variantType
            public ElementDefinitionInfo Element_VariantType;
            // 61. MolecularSequence.structureVariant.exact
            public ElementDefinitionInfo Element_Exact;
            // 62. MolecularSequence.structureVariant.length
            public ElementDefinitionInfo Element_Length;
            // 63. MolecularSequence.structureVariant.outer
            public ElementDefinitionInfo Element_Outer;
            // 66. MolecularSequence.structureVariant.inner
            public ElementDefinitionInfo Element_Inner;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "MolecularSequence.structureVariant",
                    ElementId = "MolecularSequence.structureVariant"
                });
                Element_VariantType.Write(sDef);
                Element_Exact.Write(sDef);
                Element_Length.Write(sDef);
                Element_Outer.Write(sDef);
                Element_Inner.Write(sDef);
            }
            
            public Type_StructureVariant()
            {
                {
                    // 60. MolecularSequence.structureVariant.variantType
                    this.Element_VariantType = new ElementDefinitionInfo
                    {
                        Name = "Element_VariantType",
                        Path= "MolecularSequence.structureVariant.variantType",
                        Id = "MolecularSequence.structureVariant.variantType",
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
                    // 61. MolecularSequence.structureVariant.exact
                    this.Element_Exact = new ElementDefinitionInfo
                    {
                        Name = "Element_Exact",
                        Path= "MolecularSequence.structureVariant.exact",
                        Id = "MolecularSequence.structureVariant.exact",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Boolean
                            {
                            }
                        }
                    };
                }
                {
                    // 62. MolecularSequence.structureVariant.length
                    this.Element_Length = new ElementDefinitionInfo
                    {
                        Name = "Element_Length",
                        Path= "MolecularSequence.structureVariant.length",
                        Id = "MolecularSequence.structureVariant.length",
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
                    // 63. MolecularSequence.structureVariant.outer
                    this.Element_Outer = new ElementDefinitionInfo
                    {
                        Name = "Element_Outer",
                        Path= "MolecularSequence.structureVariant.outer",
                        Id = "MolecularSequence.structureVariant.outer",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new Type_Outer
                            {
                            }
                        }
                    };
                }
                {
                    // 66. MolecularSequence.structureVariant.inner
                    this.Element_Inner = new ElementDefinitionInfo
                    {
                        Name = "Element_Inner",
                        Path= "MolecularSequence.structureVariant.inner",
                        Id = "MolecularSequence.structureVariant.inner",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new Type_Inner
                            {
                            }
                        }
                    };
                }
            }
        }
        // 1. MolecularSequence.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. MolecularSequence.type
        public ElementDefinitionInfo Element_Type;
        // 3. MolecularSequence.coordinateSystem
        public ElementDefinitionInfo Element_CoordinateSystem;
        // 4. MolecularSequence.patient
        public ElementDefinitionInfo Element_Patient;
        // 5. MolecularSequence.specimen
        public ElementDefinitionInfo Element_Specimen;
        // 6. MolecularSequence.device
        public ElementDefinitionInfo Element_Device;
        // 7. MolecularSequence.performer
        public ElementDefinitionInfo Element_Performer;
        // 8. MolecularSequence.quantity
        public ElementDefinitionInfo Element_Quantity;
        // 9. MolecularSequence.referenceSeq
        public ElementDefinitionInfo Element_ReferenceSeq;
        // 19. MolecularSequence.variant
        public ElementDefinitionInfo Element_Variant;
        // 26. MolecularSequence.observedSeq
        public ElementDefinitionInfo Element_ObservedSeq;
        // 27. MolecularSequence.quality
        public ElementDefinitionInfo Element_Quality;
        // 50. MolecularSequence.readCoverage
        public ElementDefinitionInfo Element_ReadCoverage;
        // 51. MolecularSequence.repository
        public ElementDefinitionInfo Element_Repository;
        // 58. MolecularSequence.pointer
        public ElementDefinitionInfo Element_Pointer;
        // 59. MolecularSequence.structureVariant
        public ElementDefinitionInfo Element_StructureVariant;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "MolecularSequence",
                ElementId = "MolecularSequence"
            });
            Element_Identifier.Write(sDef);
            Element_Type.Write(sDef);
            Element_CoordinateSystem.Write(sDef);
            Element_Patient.Write(sDef);
            Element_Specimen.Write(sDef);
            Element_Device.Write(sDef);
            Element_Performer.Write(sDef);
            Element_Quantity.Write(sDef);
            Element_ReferenceSeq.Write(sDef);
            Element_Variant.Write(sDef);
            Element_ObservedSeq.Write(sDef);
            Element_Quality.Write(sDef);
            Element_ReadCoverage.Write(sDef);
            Element_Repository.Write(sDef);
            Element_Pointer.Write(sDef);
            Element_StructureVariant.Write(sDef);
        }
        
        public Resource_MolecularSequence()
        {
            {
                // 1. MolecularSequence.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "MolecularSequence.identifier",
                    Id = "MolecularSequence.identifier",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Identifier
                        {
                        }
                    }
                };
            }
            {
                // 2. MolecularSequence.type
                this.Element_Type = new ElementDefinitionInfo
                {
                    Name = "Element_Type",
                    Path= "MolecularSequence.type",
                    Id = "MolecularSequence.type",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code
                        {
                        }
                    }
                };
            }
            {
                // 3. MolecularSequence.coordinateSystem
                this.Element_CoordinateSystem = new ElementDefinitionInfo
                {
                    Name = "Element_CoordinateSystem",
                    Path= "MolecularSequence.coordinateSystem",
                    Id = "MolecularSequence.coordinateSystem",
                    Min = 1,
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
                // 4. MolecularSequence.patient
                this.Element_Patient = new ElementDefinitionInfo
                {
                    Name = "Element_Patient",
                    Path= "MolecularSequence.patient",
                    Id = "MolecularSequence.patient",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Patient"
                            }
                        }
                    }
                };
            }
            {
                // 5. MolecularSequence.specimen
                this.Element_Specimen = new ElementDefinitionInfo
                {
                    Name = "Element_Specimen",
                    Path= "MolecularSequence.specimen",
                    Id = "MolecularSequence.specimen",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Specimen"
                            }
                        }
                    }
                };
            }
            {
                // 6. MolecularSequence.device
                this.Element_Device = new ElementDefinitionInfo
                {
                    Name = "Element_Device",
                    Path= "MolecularSequence.device",
                    Id = "MolecularSequence.device",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Device"
                            }
                        }
                    }
                };
            }
            {
                // 7. MolecularSequence.performer
                this.Element_Performer = new ElementDefinitionInfo
                {
                    Name = "Element_Performer",
                    Path= "MolecularSequence.performer",
                    Id = "MolecularSequence.performer",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Organization"
                            }
                        }
                    }
                };
            }
            {
                // 8. MolecularSequence.quantity
                this.Element_Quantity = new ElementDefinitionInfo
                {
                    Name = "Element_Quantity",
                    Path= "MolecularSequence.quantity",
                    Id = "MolecularSequence.quantity",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Quantity
                        {
                        }
                    }
                };
            }
            {
                // 9. MolecularSequence.referenceSeq
                this.Element_ReferenceSeq = new ElementDefinitionInfo
                {
                    Name = "Element_ReferenceSeq",
                    Path= "MolecularSequence.referenceSeq",
                    Id = "MolecularSequence.referenceSeq",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new Type_ReferenceSeq
                        {
                        }
                    }
                };
            }
            {
                // 19. MolecularSequence.variant
                this.Element_Variant = new ElementDefinitionInfo
                {
                    Name = "Element_Variant",
                    Path= "MolecularSequence.variant",
                    Id = "MolecularSequence.variant",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Variant
                        {
                        }
                    }
                };
            }
            {
                // 26. MolecularSequence.observedSeq
                this.Element_ObservedSeq = new ElementDefinitionInfo
                {
                    Name = "Element_ObservedSeq",
                    Path= "MolecularSequence.observedSeq",
                    Id = "MolecularSequence.observedSeq",
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
                // 27. MolecularSequence.quality
                this.Element_Quality = new ElementDefinitionInfo
                {
                    Name = "Element_Quality",
                    Path= "MolecularSequence.quality",
                    Id = "MolecularSequence.quality",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Quality
                        {
                        }
                    }
                };
            }
            {
                // 50. MolecularSequence.readCoverage
                this.Element_ReadCoverage = new ElementDefinitionInfo
                {
                    Name = "Element_ReadCoverage",
                    Path= "MolecularSequence.readCoverage",
                    Id = "MolecularSequence.readCoverage",
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
                // 51. MolecularSequence.repository
                this.Element_Repository = new ElementDefinitionInfo
                {
                    Name = "Element_Repository",
                    Path= "MolecularSequence.repository",
                    Id = "MolecularSequence.repository",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Repository
                        {
                        }
                    }
                };
            }
            {
                // 58. MolecularSequence.pointer
                this.Element_Pointer = new ElementDefinitionInfo
                {
                    Name = "Element_Pointer",
                    Path= "MolecularSequence.pointer",
                    Id = "MolecularSequence.pointer",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/MolecularSequence"
                            }
                        }
                    }
                };
            }
            {
                // 59. MolecularSequence.structureVariant
                this.Element_StructureVariant = new ElementDefinitionInfo
                {
                    Name = "Element_StructureVariant",
                    Path= "MolecularSequence.structureVariant",
                    Id = "MolecularSequence.structureVariant",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_StructureVariant
                        {
                        }
                    }
                };
            }
            this.Name = "MolecularSequence";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/MolecularSequence";
        }
    }
}
