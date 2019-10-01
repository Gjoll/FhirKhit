using System;                                                                                                                               // MakerGen.cs:399
using System.Diagnostics;                                                                                                                   // MakerGen.cs:400
using System.IO;                                                                                                                            // MakerGen.cs:401
using System.Linq;                                                                                                                          // MakerGen.cs:402
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:403
                                                                                                                                            // MakerGen.cs:404
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:405
{                                                                                                                                           // MakerGen.cs:406
    #region Json                                                                                                                            // MakerGen.cs:407
    #if NEVER                                                                                                                               // MakerGen.cs:408
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
    #endregion                                                                                                                              // MakerGen.cs:411
    /// <summary>
    /// Fhir resource 'MolecularSequence'
    /// </summary>
    // 0. MolecularSequence
    public class MolecularSequence : FhirKhit.Maker.Common.Resource.ResourceBase                                                            // MakerGen.cs:360
    {                                                                                                                                       // MakerGen.cs:361
        // 9. MolecularSequence.referenceSeq
        public class Type_ReferenceSeq : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:360
        {                                                                                                                                   // MakerGen.cs:361
            // 10. MolecularSequence.referenceSeq.chromosome
            public MakerElementInstance Element_Chromosome;                                                                                 // MakerGen.cs:232
            // 11. MolecularSequence.referenceSeq.genomeBuild
            public MakerElementInstance Element_GenomeBuild;                                                                                // MakerGen.cs:232
            // 12. MolecularSequence.referenceSeq.orientation
            public MakerElementInstance Element_Orientation;                                                                                // MakerGen.cs:232
            // 13. MolecularSequence.referenceSeq.referenceSeqId
            public MakerElementInstance Element_ReferenceSeqId;                                                                             // MakerGen.cs:232
            // 14. MolecularSequence.referenceSeq.referenceSeqPointer
            public MakerElementInstance Element_ReferenceSeqPointer;                                                                        // MakerGen.cs:232
            // 15. MolecularSequence.referenceSeq.referenceSeqString
            public MakerElementInstance Element_ReferenceSeqString;                                                                         // MakerGen.cs:232
            // 16. MolecularSequence.referenceSeq.strand
            public MakerElementInstance Element_Strand;                                                                                     // MakerGen.cs:232
            // 17. MolecularSequence.referenceSeq.windowStart
            public MakerElementInstance Element_WindowStart;                                                                                // MakerGen.cs:232
            // 18. MolecularSequence.referenceSeq.windowEnd
            public MakerElementInstance Element_WindowEnd;                                                                                  // MakerGen.cs:232
            public Type_ReferenceSeq()                                                                                                      // MakerGen.cs:369
            {                                                                                                                               // MakerGen.cs:370
                {                                                                                                                           // MakerGen.cs:243
                    // 10. MolecularSequence.referenceSeq.chromosome
                    this.Element_Chromosome = new MakerElementInstance                                                                      // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Chromosome",                                                                                        // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:297
                            {                                                                                                               // MakerGen.cs:298
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 11. MolecularSequence.referenceSeq.genomeBuild
                    this.Element_GenomeBuild = new MakerElementInstance                                                                     // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_GenomeBuild",                                                                                       // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 12. MolecularSequence.referenceSeq.orientation
                    this.Element_Orientation = new MakerElementInstance                                                                     // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Orientation",                                                                                       // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 13. MolecularSequence.referenceSeq.referenceSeqId
                    this.Element_ReferenceSeqId = new MakerElementInstance                                                                  // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_ReferenceSeqId",                                                                                    // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:297
                            {                                                                                                               // MakerGen.cs:298
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 14. MolecularSequence.referenceSeq.referenceSeqPointer
                    this.Element_ReferenceSeqPointer = new MakerElementInstance                                                             // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_ReferenceSeqPointer",                                                                               // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 15. MolecularSequence.referenceSeq.referenceSeqString
                    this.Element_ReferenceSeqString = new MakerElementInstance                                                              // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_ReferenceSeqString",                                                                                // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 16. MolecularSequence.referenceSeq.strand
                    this.Element_Strand = new MakerElementInstance                                                                          // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Strand",                                                                                            // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 17. MolecularSequence.referenceSeq.windowStart
                    this.Element_WindowStart = new MakerElementInstance                                                                     // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_WindowStart",                                                                                       // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Integer                                                                     // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 18. MolecularSequence.referenceSeq.windowEnd
                    this.Element_WindowEnd = new MakerElementInstance                                                                       // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_WindowEnd",                                                                                         // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Integer                                                                     // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
            }                                                                                                                               // MakerGen.cs:381
        }                                                                                                                                   // MakerGen.cs:365
        // 19. MolecularSequence.variant
        public class Type_Variant : FhirKhit.Maker.Common.Complex.ComplexBase                                                               // MakerGen.cs:360
        {                                                                                                                                   // MakerGen.cs:361
            // 20. MolecularSequence.variant.start
            public MakerElementInstance Element_Start;                                                                                      // MakerGen.cs:232
            // 21. MolecularSequence.variant.end
            public MakerElementInstance Element_End;                                                                                        // MakerGen.cs:232
            // 22. MolecularSequence.variant.observedAllele
            public MakerElementInstance Element_ObservedAllele;                                                                             // MakerGen.cs:232
            // 23. MolecularSequence.variant.referenceAllele
            public MakerElementInstance Element_ReferenceAllele;                                                                            // MakerGen.cs:232
            // 24. MolecularSequence.variant.cigar
            public MakerElementInstance Element_Cigar;                                                                                      // MakerGen.cs:232
            // 25. MolecularSequence.variant.variantPointer
            public MakerElementInstance Element_VariantPointer;                                                                             // MakerGen.cs:232
            public Type_Variant()                                                                                                           // MakerGen.cs:369
            {                                                                                                                               // MakerGen.cs:370
                {                                                                                                                           // MakerGen.cs:243
                    // 20. MolecularSequence.variant.start
                    this.Element_Start = new MakerElementInstance                                                                           // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Start",                                                                                             // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Integer                                                                     // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 21. MolecularSequence.variant.end
                    this.Element_End = new MakerElementInstance                                                                             // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_End",                                                                                               // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Integer                                                                     // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 22. MolecularSequence.variant.observedAllele
                    this.Element_ObservedAllele = new MakerElementInstance                                                                  // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_ObservedAllele",                                                                                    // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 23. MolecularSequence.variant.referenceAllele
                    this.Element_ReferenceAllele = new MakerElementInstance                                                                 // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_ReferenceAllele",                                                                                   // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 24. MolecularSequence.variant.cigar
                    this.Element_Cigar = new MakerElementInstance                                                                           // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Cigar",                                                                                             // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 25. MolecularSequence.variant.variantPointer
                    this.Element_VariantPointer = new MakerElementInstance                                                                  // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_VariantPointer",                                                                                    // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
            }                                                                                                                               // MakerGen.cs:381
        }                                                                                                                                   // MakerGen.cs:365
        // 27. MolecularSequence.quality
        public class Type_Quality : FhirKhit.Maker.Common.Complex.ComplexBase                                                               // MakerGen.cs:360
        {                                                                                                                                   // MakerGen.cs:361
            // 42. MolecularSequence.quality.roc
            public class Type_Roc : FhirKhit.Maker.Common.Complex.ComplexBase                                                               // MakerGen.cs:360
            {                                                                                                                               // MakerGen.cs:361
                // 43. MolecularSequence.quality.roc.score
                public MakerElementInstance Element_Score;                                                                                  // MakerGen.cs:232
                // 44. MolecularSequence.quality.roc.numTP
                public MakerElementInstance Element_NumTP;                                                                                  // MakerGen.cs:232
                // 45. MolecularSequence.quality.roc.numFP
                public MakerElementInstance Element_NumFP;                                                                                  // MakerGen.cs:232
                // 46. MolecularSequence.quality.roc.numFN
                public MakerElementInstance Element_NumFN;                                                                                  // MakerGen.cs:232
                // 47. MolecularSequence.quality.roc.precision
                public MakerElementInstance Element_Precision;                                                                              // MakerGen.cs:232
                // 48. MolecularSequence.quality.roc.sensitivity
                public MakerElementInstance Element_Sensitivity;                                                                            // MakerGen.cs:232
                // 49. MolecularSequence.quality.roc.fMeasure
                public MakerElementInstance Element_FMeasure;                                                                               // MakerGen.cs:232
                public Type_Roc()                                                                                                           // MakerGen.cs:369
                {                                                                                                                           // MakerGen.cs:370
                    {                                                                                                                       // MakerGen.cs:243
                        // 43. MolecularSequence.quality.roc.score
                        this.Element_Score = new MakerElementInstance                                                                       // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Score",                                                                                         // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Integer                                                                 // MakerGen.cs:287
                                {                                                                                                           // MakerGen.cs:288
                                }                                                                                                           // MakerGen.cs:289
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:342
                    {                                                                                                                       // MakerGen.cs:243
                        // 44. MolecularSequence.quality.roc.numTP
                        this.Element_NumTP = new MakerElementInstance                                                                       // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_NumTP",                                                                                         // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Integer                                                                 // MakerGen.cs:287
                                {                                                                                                           // MakerGen.cs:288
                                }                                                                                                           // MakerGen.cs:289
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:342
                    {                                                                                                                       // MakerGen.cs:243
                        // 45. MolecularSequence.quality.roc.numFP
                        this.Element_NumFP = new MakerElementInstance                                                                       // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_NumFP",                                                                                         // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Integer                                                                 // MakerGen.cs:287
                                {                                                                                                           // MakerGen.cs:288
                                }                                                                                                           // MakerGen.cs:289
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:342
                    {                                                                                                                       // MakerGen.cs:243
                        // 46. MolecularSequence.quality.roc.numFN
                        this.Element_NumFN = new MakerElementInstance                                                                       // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_NumFN",                                                                                         // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Integer                                                                 // MakerGen.cs:287
                                {                                                                                                           // MakerGen.cs:288
                                }                                                                                                           // MakerGen.cs:289
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:342
                    {                                                                                                                       // MakerGen.cs:243
                        // 47. MolecularSequence.quality.roc.precision
                        this.Element_Precision = new MakerElementInstance                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Precision",                                                                                     // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Decimal                                                                 // MakerGen.cs:287
                                {                                                                                                           // MakerGen.cs:288
                                }                                                                                                           // MakerGen.cs:289
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:342
                    {                                                                                                                       // MakerGen.cs:243
                        // 48. MolecularSequence.quality.roc.sensitivity
                        this.Element_Sensitivity = new MakerElementInstance                                                                 // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Sensitivity",                                                                                   // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Decimal                                                                 // MakerGen.cs:287
                                {                                                                                                           // MakerGen.cs:288
                                }                                                                                                           // MakerGen.cs:289
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:342
                    {                                                                                                                       // MakerGen.cs:243
                        // 49. MolecularSequence.quality.roc.fMeasure
                        this.Element_FMeasure = new MakerElementInstance                                                                    // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_FMeasure",                                                                                      // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Decimal                                                                 // MakerGen.cs:287
                                {                                                                                                           // MakerGen.cs:288
                                }                                                                                                           // MakerGen.cs:289
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:342
                }                                                                                                                           // MakerGen.cs:381
            }                                                                                                                               // MakerGen.cs:365
            // 28. MolecularSequence.quality.type
            public MakerElementInstance Element_Type;                                                                                       // MakerGen.cs:232
            // 29. MolecularSequence.quality.standardSequence
            public MakerElementInstance Element_StandardSequence;                                                                           // MakerGen.cs:232
            // 30. MolecularSequence.quality.start
            public MakerElementInstance Element_Start;                                                                                      // MakerGen.cs:232
            // 31. MolecularSequence.quality.end
            public MakerElementInstance Element_End;                                                                                        // MakerGen.cs:232
            // 32. MolecularSequence.quality.score
            public MakerElementInstance Element_Score;                                                                                      // MakerGen.cs:232
            // 33. MolecularSequence.quality.method
            public MakerElementInstance Element_Method;                                                                                     // MakerGen.cs:232
            // 34. MolecularSequence.quality.truthTP
            public MakerElementInstance Element_TruthTP;                                                                                    // MakerGen.cs:232
            // 35. MolecularSequence.quality.queryTP
            public MakerElementInstance Element_QueryTP;                                                                                    // MakerGen.cs:232
            // 36. MolecularSequence.quality.truthFN
            public MakerElementInstance Element_TruthFN;                                                                                    // MakerGen.cs:232
            // 37. MolecularSequence.quality.queryFP
            public MakerElementInstance Element_QueryFP;                                                                                    // MakerGen.cs:232
            // 38. MolecularSequence.quality.gtFP
            public MakerElementInstance Element_GtFP;                                                                                       // MakerGen.cs:232
            // 39. MolecularSequence.quality.precision
            public MakerElementInstance Element_Precision;                                                                                  // MakerGen.cs:232
            // 40. MolecularSequence.quality.recall
            public MakerElementInstance Element_Recall;                                                                                     // MakerGen.cs:232
            // 41. MolecularSequence.quality.fScore
            public MakerElementInstance Element_FScore;                                                                                     // MakerGen.cs:232
            public Type_Quality()                                                                                                           // MakerGen.cs:369
            {                                                                                                                               // MakerGen.cs:370
                {                                                                                                                           // MakerGen.cs:243
                    // 28. MolecularSequence.quality.type
                    this.Element_Type = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Type",                                                                                              // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 29. MolecularSequence.quality.standardSequence
                    this.Element_StandardSequence = new MakerElementInstance                                                                // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_StandardSequence",                                                                                  // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:297
                            {                                                                                                               // MakerGen.cs:298
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 30. MolecularSequence.quality.start
                    this.Element_Start = new MakerElementInstance                                                                           // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Start",                                                                                             // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Integer                                                                     // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 31. MolecularSequence.quality.end
                    this.Element_End = new MakerElementInstance                                                                             // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_End",                                                                                               // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Integer                                                                     // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 32. MolecularSequence.quality.score
                    this.Element_Score = new MakerElementInstance                                                                           // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Score",                                                                                             // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 33. MolecularSequence.quality.method
                    this.Element_Method = new MakerElementInstance                                                                          // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Method",                                                                                            // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:297
                            {                                                                                                               // MakerGen.cs:298
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 34. MolecularSequence.quality.truthTP
                    this.Element_TruthTP = new MakerElementInstance                                                                         // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_TruthTP",                                                                                           // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Decimal                                                                     // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 35. MolecularSequence.quality.queryTP
                    this.Element_QueryTP = new MakerElementInstance                                                                         // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_QueryTP",                                                                                           // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Decimal                                                                     // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 36. MolecularSequence.quality.truthFN
                    this.Element_TruthFN = new MakerElementInstance                                                                         // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_TruthFN",                                                                                           // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Decimal                                                                     // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 37. MolecularSequence.quality.queryFP
                    this.Element_QueryFP = new MakerElementInstance                                                                         // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_QueryFP",                                                                                           // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Decimal                                                                     // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 38. MolecularSequence.quality.gtFP
                    this.Element_GtFP = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_GtFP",                                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Decimal                                                                     // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 39. MolecularSequence.quality.precision
                    this.Element_Precision = new MakerElementInstance                                                                       // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Precision",                                                                                         // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Decimal                                                                     // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 40. MolecularSequence.quality.recall
                    this.Element_Recall = new MakerElementInstance                                                                          // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Recall",                                                                                            // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Decimal                                                                     // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 41. MolecularSequence.quality.fScore
                    this.Element_FScore = new MakerElementInstance                                                                          // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_FScore",                                                                                            // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Decimal                                                                     // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
            }                                                                                                                               // MakerGen.cs:381
        }                                                                                                                                   // MakerGen.cs:365
        // 51. MolecularSequence.repository
        public class Type_Repository : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:360
        {                                                                                                                                   // MakerGen.cs:361
            // 52. MolecularSequence.repository.type
            public MakerElementInstance Element_Type;                                                                                       // MakerGen.cs:232
            // 53. MolecularSequence.repository.url
            public MakerElementInstance Element_Url;                                                                                        // MakerGen.cs:232
            // 54. MolecularSequence.repository.name
            public MakerElementInstance Element_Name;                                                                                       // MakerGen.cs:232
            // 55. MolecularSequence.repository.datasetId
            public MakerElementInstance Element_DatasetId;                                                                                  // MakerGen.cs:232
            // 56. MolecularSequence.repository.variantsetId
            public MakerElementInstance Element_VariantsetId;                                                                               // MakerGen.cs:232
            // 57. MolecularSequence.repository.readsetId
            public MakerElementInstance Element_ReadsetId;                                                                                  // MakerGen.cs:232
            public Type_Repository()                                                                                                        // MakerGen.cs:369
            {                                                                                                                               // MakerGen.cs:370
                {                                                                                                                           // MakerGen.cs:243
                    // 52. MolecularSequence.repository.type
                    this.Element_Type = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Type",                                                                                              // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 53. MolecularSequence.repository.url
                    this.Element_Url = new MakerElementInstance                                                                             // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Url",                                                                                               // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Uri                                                                         // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 54. MolecularSequence.repository.name
                    this.Element_Name = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Name",                                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 55. MolecularSequence.repository.datasetId
                    this.Element_DatasetId = new MakerElementInstance                                                                       // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_DatasetId",                                                                                         // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 56. MolecularSequence.repository.variantsetId
                    this.Element_VariantsetId = new MakerElementInstance                                                                    // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_VariantsetId",                                                                                      // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 57. MolecularSequence.repository.readsetId
                    this.Element_ReadsetId = new MakerElementInstance                                                                       // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_ReadsetId",                                                                                         // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
            }                                                                                                                               // MakerGen.cs:381
        }                                                                                                                                   // MakerGen.cs:365
        // 59. MolecularSequence.structureVariant
        public class Type_StructureVariant : FhirKhit.Maker.Common.Complex.ComplexBase                                                      // MakerGen.cs:360
        {                                                                                                                                   // MakerGen.cs:361
            // 63. MolecularSequence.structureVariant.outer
            public class Type_Outer : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:360
            {                                                                                                                               // MakerGen.cs:361
                // 64. MolecularSequence.structureVariant.outer.start
                public MakerElementInstance Element_Start;                                                                                  // MakerGen.cs:232
                // 65. MolecularSequence.structureVariant.outer.end
                public MakerElementInstance Element_End;                                                                                    // MakerGen.cs:232
                public Type_Outer()                                                                                                         // MakerGen.cs:369
                {                                                                                                                           // MakerGen.cs:370
                    {                                                                                                                       // MakerGen.cs:243
                        // 64. MolecularSequence.structureVariant.outer.start
                        this.Element_Start = new MakerElementInstance                                                                       // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Start",                                                                                         // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Integer                                                                 // MakerGen.cs:287
                                {                                                                                                           // MakerGen.cs:288
                                }                                                                                                           // MakerGen.cs:289
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:342
                    {                                                                                                                       // MakerGen.cs:243
                        // 65. MolecularSequence.structureVariant.outer.end
                        this.Element_End = new MakerElementInstance                                                                         // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_End",                                                                                           // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Integer                                                                 // MakerGen.cs:287
                                {                                                                                                           // MakerGen.cs:288
                                }                                                                                                           // MakerGen.cs:289
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:342
                }                                                                                                                           // MakerGen.cs:381
            }                                                                                                                               // MakerGen.cs:365
            // 66. MolecularSequence.structureVariant.inner
            public class Type_Inner : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:360
            {                                                                                                                               // MakerGen.cs:361
                // 67. MolecularSequence.structureVariant.inner.start
                public MakerElementInstance Element_Start;                                                                                  // MakerGen.cs:232
                // 68. MolecularSequence.structureVariant.inner.end
                public MakerElementInstance Element_End;                                                                                    // MakerGen.cs:232
                public Type_Inner()                                                                                                         // MakerGen.cs:369
                {                                                                                                                           // MakerGen.cs:370
                    {                                                                                                                       // MakerGen.cs:243
                        // 67. MolecularSequence.structureVariant.inner.start
                        this.Element_Start = new MakerElementInstance                                                                       // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Start",                                                                                         // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Integer                                                                 // MakerGen.cs:287
                                {                                                                                                           // MakerGen.cs:288
                                }                                                                                                           // MakerGen.cs:289
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:342
                    {                                                                                                                       // MakerGen.cs:243
                        // 68. MolecularSequence.structureVariant.inner.end
                        this.Element_End = new MakerElementInstance                                                                         // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_End",                                                                                           // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Integer                                                                 // MakerGen.cs:287
                                {                                                                                                           // MakerGen.cs:288
                                }                                                                                                           // MakerGen.cs:289
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:342
                }                                                                                                                           // MakerGen.cs:381
            }                                                                                                                               // MakerGen.cs:365
            // 60. MolecularSequence.structureVariant.variantType
            public MakerElementInstance Element_VariantType;                                                                                // MakerGen.cs:232
            // 61. MolecularSequence.structureVariant.exact
            public MakerElementInstance Element_Exact;                                                                                      // MakerGen.cs:232
            // 62. MolecularSequence.structureVariant.length
            public MakerElementInstance Element_Length;                                                                                     // MakerGen.cs:232
            public Type_StructureVariant()                                                                                                  // MakerGen.cs:369
            {                                                                                                                               // MakerGen.cs:370
                {                                                                                                                           // MakerGen.cs:243
                    // 60. MolecularSequence.structureVariant.variantType
                    this.Element_VariantType = new MakerElementInstance                                                                     // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_VariantType",                                                                                       // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:297
                            {                                                                                                               // MakerGen.cs:298
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 61. MolecularSequence.structureVariant.exact
                    this.Element_Exact = new MakerElementInstance                                                                           // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Exact",                                                                                             // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Boolean                                                                     // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:342
                {                                                                                                                           // MakerGen.cs:243
                    // 62. MolecularSequence.structureVariant.length
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
                }                                                                                                                           // MakerGen.cs:342
            }                                                                                                                               // MakerGen.cs:381
        }                                                                                                                                   // MakerGen.cs:365
        // 1. MolecularSequence.identifier
        public MakerElementInstance Element_Identifier;                                                                                     // MakerGen.cs:232
        // 2. MolecularSequence.type
        public MakerElementInstance Element_Type;                                                                                           // MakerGen.cs:232
        // 3. MolecularSequence.coordinateSystem
        public MakerElementInstance Element_CoordinateSystem;                                                                               // MakerGen.cs:232
        // 4. MolecularSequence.patient
        public MakerElementInstance Element_Patient;                                                                                        // MakerGen.cs:232
        // 5. MolecularSequence.specimen
        public MakerElementInstance Element_Specimen;                                                                                       // MakerGen.cs:232
        // 6. MolecularSequence.device
        public MakerElementInstance Element_Device;                                                                                         // MakerGen.cs:232
        // 7. MolecularSequence.performer
        public MakerElementInstance Element_Performer;                                                                                      // MakerGen.cs:232
        // 8. MolecularSequence.quantity
        public MakerElementInstance Element_Quantity;                                                                                       // MakerGen.cs:232
        // 26. MolecularSequence.observedSeq
        public MakerElementInstance Element_ObservedSeq;                                                                                    // MakerGen.cs:232
        // 50. MolecularSequence.readCoverage
        public MakerElementInstance Element_ReadCoverage;                                                                                   // MakerGen.cs:232
        // 58. MolecularSequence.pointer
        public MakerElementInstance Element_Pointer;                                                                                        // MakerGen.cs:232
        public MolecularSequence()                                                                                                          // MakerGen.cs:369
        {                                                                                                                                   // MakerGen.cs:370
            {                                                                                                                               // MakerGen.cs:243
                // 1. MolecularSequence.identifier
                this.Element_Identifier = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 2. MolecularSequence.type
                this.Element_Type = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Type",                                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Code                                                                            // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 3. MolecularSequence.coordinateSystem
                this.Element_CoordinateSystem = new MakerElementInstance                                                                    // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_CoordinateSystem",                                                                                      // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Integer                                                                         // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 4. MolecularSequence.patient
                this.Element_Patient = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Patient",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 5. MolecularSequence.specimen
                this.Element_Specimen = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Specimen",                                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 6. MolecularSequence.device
                this.Element_Device = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Device",                                                                                                // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 7. MolecularSequence.performer
                this.Element_Performer = new MakerElementInstance                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Performer",                                                                                             // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 8. MolecularSequence.quantity
                this.Element_Quantity = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Quantity",                                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 26. MolecularSequence.observedSeq
                this.Element_ObservedSeq = new MakerElementInstance                                                                         // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ObservedSeq",                                                                                           // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String                                                                          // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 50. MolecularSequence.readCoverage
                this.Element_ReadCoverage = new MakerElementInstance                                                                        // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ReadCoverage",                                                                                          // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Integer                                                                         // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
            {                                                                                                                               // MakerGen.cs:243
                // 58. MolecularSequence.pointer
                this.Element_Pointer = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Pointer",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:342
        }                                                                                                                                   // MakerGen.cs:381
    }                                                                                                                                       // MakerGen.cs:365
}                                                                                                                                           // MakerGen.cs:416
