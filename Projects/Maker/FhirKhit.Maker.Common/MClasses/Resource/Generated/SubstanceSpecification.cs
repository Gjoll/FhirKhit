using System;                                                                                                                               // MakerGen.cs:457
using System.Diagnostics;                                                                                                                   // MakerGen.cs:458
using System.IO;                                                                                                                            // MakerGen.cs:459
using System.Linq;                                                                                                                          // MakerGen.cs:460
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:461
                                                                                                                                            // MakerGen.cs:462
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:463
{                                                                                                                                           // MakerGen.cs:464
    #region Json                                                                                                                            // MakerGen.cs:465
    #if NEVER                                                                                                                               // MakerGen.cs:466
    {
      "resourceType": "StructureDefinition",
      "id": "SubstanceSpecification",
      "url": "http://hl7.org/fhir/StructureDefinition/SubstanceSpecification",
      "version": "4.0.0",
      "name": "SubstanceSpecification",
      "status": "draft",
      "publisher": "Health Level Seven International (Biomedical Research and Regulation)",
      "description": "The detailed description of a substance, typically at a level beyond what is used for prescribing.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "SubstanceSpecification",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "SubstanceSpecification",
            "path": "SubstanceSpecification",
            "short": "The detailed description of a substance, typically at a level beyond what is used for prescribing",
            "definition": "The detailed description of a substance, typically at a level beyond what is used for prescribing.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "SubstanceSpecification.identifier",
            "path": "SubstanceSpecification.identifier",
            "short": "Identifier by which this substance is known",
            "definition": "Identifier by which this substance is known.",
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
            "id": "SubstanceSpecification.type",
            "path": "SubstanceSpecification.type",
            "short": "High level categorization, e.g. polymer or nucleic acid",
            "definition": "High level categorization, e.g. polymer or nucleic acid.",
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
            "id": "SubstanceSpecification.status",
            "path": "SubstanceSpecification.status",
            "short": "Status of substance within the catalogue e.g. approved",
            "definition": "Status of substance within the catalogue e.g. approved.",
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
            "id": "SubstanceSpecification.domain",
            "path": "SubstanceSpecification.domain",
            "short": "If the substance applies to only human or veterinary use",
            "definition": "If the substance applies to only human or veterinary use.",
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
            "id": "SubstanceSpecification.description",
            "path": "SubstanceSpecification.description",
            "short": "Textual description of the substance",
            "definition": "Textual description of the substance.",
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
            "id": "SubstanceSpecification.source",
            "path": "SubstanceSpecification.source",
            "short": "Supporting literature",
            "definition": "Supporting literature.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceSpecification.comment",
            "path": "SubstanceSpecification.comment",
            "short": "Textual comment about this record of a substance",
            "definition": "Textual comment about this record of a substance.",
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
            "id": "SubstanceSpecification.moiety",
            "path": "SubstanceSpecification.moiety",
            "short": "Moiety, for structural modifications",
            "definition": "Moiety, for structural modifications.",
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
            "id": "SubstanceSpecification.moiety.role",
            "path": "SubstanceSpecification.moiety.role",
            "short": "Role that the moiety is playing",
            "definition": "Role that the moiety is playing.",
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
            "id": "SubstanceSpecification.moiety.identifier",
            "path": "SubstanceSpecification.moiety.identifier",
            "short": "Identifier by which this moiety substance is known",
            "definition": "Identifier by which this moiety substance is known.",
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
            "id": "SubstanceSpecification.moiety.name",
            "path": "SubstanceSpecification.moiety.name",
            "short": "Textual name for this moiety substance",
            "definition": "Textual name for this moiety substance.",
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
            "id": "SubstanceSpecification.moiety.stereochemistry",
            "path": "SubstanceSpecification.moiety.stereochemistry",
            "short": "Stereochemistry type",
            "definition": "Stereochemistry type.",
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
            "id": "SubstanceSpecification.moiety.opticalActivity",
            "path": "SubstanceSpecification.moiety.opticalActivity",
            "short": "Optical activity type",
            "definition": "Optical activity type.",
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
            "id": "SubstanceSpecification.moiety.molecularFormula",
            "path": "SubstanceSpecification.moiety.molecularFormula",
            "short": "Molecular formula",
            "definition": "Molecular formula.",
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
            "id": "SubstanceSpecification.moiety.amount[x]",
            "path": "SubstanceSpecification.moiety.amount[x]",
            "short": "Quantitative value for this moiety",
            "definition": "Quantitative value for this moiety.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity"
              },
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceSpecification.property",
            "path": "SubstanceSpecification.property",
            "short": "General specifications for this substance, including how it is related to other substances",
            "definition": "General specifications for this substance, including how it is related to other substances.",
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
            "id": "SubstanceSpecification.property.category",
            "path": "SubstanceSpecification.property.category",
            "short": "A category for this property, e.g. Physical, Chemical, Enzymatic",
            "definition": "A category for this property, e.g. Physical, Chemical, Enzymatic.",
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
            "id": "SubstanceSpecification.property.code",
            "path": "SubstanceSpecification.property.code",
            "short": "Property type e.g. viscosity, pH, isoelectric point",
            "definition": "Property type e.g. viscosity, pH, isoelectric point.",
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
            "id": "SubstanceSpecification.property.parameters",
            "path": "SubstanceSpecification.property.parameters",
            "short": "Parameters that were used in the measurement of a property (e.g. for viscosity: measured at 20C with a pH of 7.1)",
            "definition": "Parameters that were used in the measurement of a property (e.g. for viscosity: measured at 20C with a pH of 7.1).",
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
            "id": "SubstanceSpecification.property.definingSubstance[x]",
            "path": "SubstanceSpecification.property.definingSubstance[x]",
            "short": "A substance upon which a defining property depends (e.g. for solubility: in water, in alcohol)",
            "definition": "A substance upon which a defining property depends (e.g. for solubility: in water, in alcohol).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/SubstanceSpecification",
                  "http://hl7.org/fhir/StructureDefinition/Substance"
                ]
              },
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceSpecification.property.amount[x]",
            "path": "SubstanceSpecification.property.amount[x]",
            "short": "Quantitative value for this property",
            "definition": "Quantitative value for this property.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity"
              },
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceSpecification.referenceInformation",
            "path": "SubstanceSpecification.referenceInformation",
            "short": "General information detailing this substance",
            "definition": "General information detailing this substance.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/SubstanceReferenceInformation"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceSpecification.structure",
            "path": "SubstanceSpecification.structure",
            "short": "Structural information",
            "definition": "Structural information.",
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
            "id": "SubstanceSpecification.structure.stereochemistry",
            "path": "SubstanceSpecification.structure.stereochemistry",
            "short": "Stereochemistry type",
            "definition": "Stereochemistry type.",
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
            "id": "SubstanceSpecification.structure.opticalActivity",
            "path": "SubstanceSpecification.structure.opticalActivity",
            "short": "Optical activity type",
            "definition": "Optical activity type.",
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
            "id": "SubstanceSpecification.structure.molecularFormula",
            "path": "SubstanceSpecification.structure.molecularFormula",
            "short": "Molecular formula",
            "definition": "Molecular formula.",
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
            "id": "SubstanceSpecification.structure.molecularFormulaByMoiety",
            "path": "SubstanceSpecification.structure.molecularFormulaByMoiety",
            "short": "Specified per moiety according to the Hill system, i.e. first C, then H, then alphabetical, each moiety separated by a dot",
            "definition": "Specified per moiety according to the Hill system, i.e. first C, then H, then alphabetical, each moiety separated by a dot.",
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
            "id": "SubstanceSpecification.structure.isotope",
            "path": "SubstanceSpecification.structure.isotope",
            "short": "Applicable for single substances that contain a radionuclide or a non-natural isotopic ratio",
            "definition": "Applicable for single substances that contain a radionuclide or a non-natural isotopic ratio.",
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
            "id": "SubstanceSpecification.structure.isotope.identifier",
            "path": "SubstanceSpecification.structure.isotope.identifier",
            "short": "Substance identifier for each non-natural or radioisotope",
            "definition": "Substance identifier for each non-natural or radioisotope.",
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
            "id": "SubstanceSpecification.structure.isotope.name",
            "path": "SubstanceSpecification.structure.isotope.name",
            "short": "Substance name for each non-natural or radioisotope",
            "definition": "Substance name for each non-natural or radioisotope.",
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
            "id": "SubstanceSpecification.structure.isotope.substitution",
            "path": "SubstanceSpecification.structure.isotope.substitution",
            "short": "The type of isotopic substitution present in a single substance",
            "definition": "The type of isotopic substitution present in a single substance.",
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
            "id": "SubstanceSpecification.structure.isotope.halfLife",
            "path": "SubstanceSpecification.structure.isotope.halfLife",
            "short": "Half life - for a non-natural nuclide",
            "definition": "Half life - for a non-natural nuclide.",
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
            "id": "SubstanceSpecification.structure.isotope.molecularWeight",
            "path": "SubstanceSpecification.structure.isotope.molecularWeight",
            "short": "The molecular weight or weight range (for proteins, polymers or nucleic acids)",
            "definition": "The molecular weight or weight range (for proteins, polymers or nucleic acids).",
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
            "id": "SubstanceSpecification.structure.isotope.molecularWeight.method",
            "path": "SubstanceSpecification.structure.isotope.molecularWeight.method",
            "short": "The method by which the molecular weight was determined",
            "definition": "The method by which the molecular weight was determined.",
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
            "id": "SubstanceSpecification.structure.isotope.molecularWeight.type",
            "path": "SubstanceSpecification.structure.isotope.molecularWeight.type",
            "short": "Type of molecular weight such as exact, average (also known as. number average), weight average",
            "definition": "Type of molecular weight such as exact, average (also known as. number average), weight average.",
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
            "id": "SubstanceSpecification.structure.isotope.molecularWeight.amount",
            "path": "SubstanceSpecification.structure.isotope.molecularWeight.amount",
            "short": "Used to capture quantitative values for a variety of elements. If only limits are given, the arithmetic mean would be the average. If only a single definite value for a given element is given, it would be captured in this field",
            "definition": "Used to capture quantitative values for a variety of elements. If only limits are given, the arithmetic mean would be the average. If only a single definite value for a given element is given, it would be captured in this field.",
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
            "id": "SubstanceSpecification.structure.molecularWeight",
            "path": "SubstanceSpecification.structure.molecularWeight",
            "short": "The molecular weight or weight range (for proteins, polymers or nucleic acids)",
            "definition": "The molecular weight or weight range (for proteins, polymers or nucleic acids).",
            "min": 0,
            "max": "1",
            "contentReference": "#SubstanceSpecification.structure.isotope.molecularWeight",
            "isSummary": true
          },
          {
            "id": "SubstanceSpecification.structure.source",
            "path": "SubstanceSpecification.structure.source",
            "short": "Supporting literature",
            "definition": "Supporting literature.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceSpecification.structure.representation",
            "path": "SubstanceSpecification.structure.representation",
            "short": "Molecular structural representation",
            "definition": "Molecular structural representation.",
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
            "id": "SubstanceSpecification.structure.representation.type",
            "path": "SubstanceSpecification.structure.representation.type",
            "short": "The type of structure (e.g. Full, Partial, Representative)",
            "definition": "The type of structure (e.g. Full, Partial, Representative).",
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
            "id": "SubstanceSpecification.structure.representation.representation",
            "path": "SubstanceSpecification.structure.representation.representation",
            "short": "The structural representation as text string in a format e.g. InChI, SMILES, MOLFILE, CDX",
            "definition": "The structural representation as text string in a format e.g. InChI, SMILES, MOLFILE, CDX.",
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
            "id": "SubstanceSpecification.structure.representation.attachment",
            "path": "SubstanceSpecification.structure.representation.attachment",
            "short": "An attached file with the structural representation",
            "definition": "An attached file with the structural representation.",
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
            "id": "SubstanceSpecification.code",
            "path": "SubstanceSpecification.code",
            "short": "Codes associated with the substance",
            "definition": "Codes associated with the substance.",
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
            "id": "SubstanceSpecification.code.code",
            "path": "SubstanceSpecification.code.code",
            "short": "The specific code",
            "definition": "The specific code.",
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
            "id": "SubstanceSpecification.code.status",
            "path": "SubstanceSpecification.code.status",
            "short": "Status of the code assignment",
            "definition": "Status of the code assignment.",
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
            "id": "SubstanceSpecification.code.statusDate",
            "path": "SubstanceSpecification.code.statusDate",
            "short": "The date at which the code status is changed as part of the terminology maintenance",
            "definition": "The date at which the code status is changed as part of the terminology maintenance.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceSpecification.code.comment",
            "path": "SubstanceSpecification.code.comment",
            "short": "Any comment can be provided in this field, if necessary",
            "definition": "Any comment can be provided in this field, if necessary.",
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
            "id": "SubstanceSpecification.code.source",
            "path": "SubstanceSpecification.code.source",
            "short": "Supporting literature",
            "definition": "Supporting literature.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceSpecification.name",
            "path": "SubstanceSpecification.name",
            "short": "Names applicable to this substance",
            "definition": "Names applicable to this substance.",
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
            "id": "SubstanceSpecification.name.name",
            "path": "SubstanceSpecification.name.name",
            "short": "The actual name",
            "definition": "The actual name.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceSpecification.name.type",
            "path": "SubstanceSpecification.name.type",
            "short": "Name type",
            "definition": "Name type.",
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
            "id": "SubstanceSpecification.name.status",
            "path": "SubstanceSpecification.name.status",
            "short": "The status of the name",
            "definition": "The status of the name.",
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
            "id": "SubstanceSpecification.name.preferred",
            "path": "SubstanceSpecification.name.preferred",
            "short": "If this is the preferred name for this substance",
            "definition": "If this is the preferred name for this substance.",
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
            "id": "SubstanceSpecification.name.language",
            "path": "SubstanceSpecification.name.language",
            "short": "Language of the name",
            "definition": "Language of the name.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceSpecification.name.domain",
            "path": "SubstanceSpecification.name.domain",
            "short": "The use context of this name for example if there is a different name a drug active ingredient as opposed to a food colour additive",
            "definition": "The use context of this name for example if there is a different name a drug active ingredient as opposed to a food colour additive.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceSpecification.name.jurisdiction",
            "path": "SubstanceSpecification.name.jurisdiction",
            "short": "The jurisdiction where this name applies",
            "definition": "The jurisdiction where this name applies.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceSpecification.name.synonym",
            "path": "SubstanceSpecification.name.synonym",
            "short": "A synonym of this name",
            "definition": "A synonym of this name.",
            "min": 0,
            "max": "*",
            "contentReference": "#SubstanceSpecification.name",
            "isSummary": true
          },
          {
            "id": "SubstanceSpecification.name.translation",
            "path": "SubstanceSpecification.name.translation",
            "short": "A translation for this name",
            "definition": "A translation for this name.",
            "min": 0,
            "max": "*",
            "contentReference": "#SubstanceSpecification.name",
            "isSummary": true
          },
          {
            "id": "SubstanceSpecification.name.official",
            "path": "SubstanceSpecification.name.official",
            "short": "Details of the official nature of this name",
            "definition": "Details of the official nature of this name.",
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
            "id": "SubstanceSpecification.name.official.authority",
            "path": "SubstanceSpecification.name.official.authority",
            "short": "Which authority uses this official name",
            "definition": "Which authority uses this official name.",
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
            "id": "SubstanceSpecification.name.official.status",
            "path": "SubstanceSpecification.name.official.status",
            "short": "The status of the official name",
            "definition": "The status of the official name.",
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
            "id": "SubstanceSpecification.name.official.date",
            "path": "SubstanceSpecification.name.official.date",
            "short": "Date of official name change",
            "definition": "Date of official name change.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceSpecification.name.source",
            "path": "SubstanceSpecification.name.source",
            "short": "Supporting literature",
            "definition": "Supporting literature.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceSpecification.molecularWeight",
            "path": "SubstanceSpecification.molecularWeight",
            "short": "The molecular weight or weight range (for proteins, polymers or nucleic acids)",
            "definition": "The molecular weight or weight range (for proteins, polymers or nucleic acids).",
            "min": 0,
            "max": "*",
            "contentReference": "#SubstanceSpecification.structure.isotope.molecularWeight",
            "isSummary": true
          },
          {
            "id": "SubstanceSpecification.relationship",
            "path": "SubstanceSpecification.relationship",
            "short": "A link between this substance and another, with details of the relationship",
            "definition": "A link between this substance and another, with details of the relationship.",
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
            "id": "SubstanceSpecification.relationship.substance[x]",
            "path": "SubstanceSpecification.relationship.substance[x]",
            "short": "A pointer to another substance, as a resource or just a representational code",
            "definition": "A pointer to another substance, as a resource or just a representational code.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/SubstanceSpecification"
                ]
              },
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceSpecification.relationship.relationship",
            "path": "SubstanceSpecification.relationship.relationship",
            "short": "For example \"salt to parent\", \"active moiety\", \"starting material\"",
            "definition": "For example \"salt to parent\", \"active moiety\", \"starting material\".",
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
            "id": "SubstanceSpecification.relationship.isDefining",
            "path": "SubstanceSpecification.relationship.isDefining",
            "short": "For example where an enzyme strongly bonds with a particular substance, this is a defining relationship for that enzyme, out of several possible substance relationships",
            "definition": "For example where an enzyme strongly bonds with a particular substance, this is a defining relationship for that enzyme, out of several possible substance relationships.",
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
            "id": "SubstanceSpecification.relationship.amount[x]",
            "path": "SubstanceSpecification.relationship.amount[x]",
            "short": "A numeric factor for the relationship, for instance to express that the salt of a substance has some percentage of the active substance in relation to some other",
            "definition": "A numeric factor for the relationship, for instance to express that the salt of a substance has some percentage of the active substance in relation to some other.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity"
              },
              {
                "code": "Range"
              },
              {
                "code": "Ratio"
              },
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceSpecification.relationship.amountRatioLowLimit",
            "path": "SubstanceSpecification.relationship.amountRatioLowLimit",
            "short": "For use when the numeric",
            "definition": "For use when the numeric.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Ratio"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceSpecification.relationship.amountType",
            "path": "SubstanceSpecification.relationship.amountType",
            "short": "An operator for the amount, for example \"average\", \"approximately\", \"less than\"",
            "definition": "An operator for the amount, for example \"average\", \"approximately\", \"less than\".",
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
            "id": "SubstanceSpecification.relationship.source",
            "path": "SubstanceSpecification.relationship.source",
            "short": "Supporting literature",
            "definition": "Supporting literature.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceSpecification.nucleicAcid",
            "path": "SubstanceSpecification.nucleicAcid",
            "short": "Data items specific to nucleic acids",
            "definition": "Data items specific to nucleic acids.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/SubstanceNucleicAcid"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceSpecification.polymer",
            "path": "SubstanceSpecification.polymer",
            "short": "Data items specific to polymers",
            "definition": "Data items specific to polymers.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/SubstancePolymer"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceSpecification.protein",
            "path": "SubstanceSpecification.protein",
            "short": "Data items specific to proteins",
            "definition": "Data items specific to proteins.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/SubstanceProtein"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "SubstanceSpecification.sourceMaterial",
            "path": "SubstanceSpecification.sourceMaterial",
            "short": "Material or taxonomic/anatomical source for the substance",
            "definition": "Material or taxonomic/anatomical source for the substance.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/SubstanceSourceMaterial"
                ]
              }
            ],
            "isSummary": true
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:469
    /// <summary>
    /// Fhir resource 'SubstanceSpecification'
    /// </summary>
    // 0. SubstanceSpecification
    public class SubstanceSpecification : FhirKhit.Maker.Common.Resource.ResourceBase                                                       // MakerGen.cs:379
    {                                                                                                                                       // MakerGen.cs:380
        public class SubstanceSpecification_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                          // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 8. SubstanceSpecification.moiety
            public class Type_Moiety : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:379
            {                                                                                                                               // MakerGen.cs:380
                public class Type_Moiety_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                             // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 9. SubstanceSpecification.moiety.role
                    public ElementDefinitionInfo Role;                                                                                      // MakerGen.cs:211
                    // 10. SubstanceSpecification.moiety.identifier
                    public ElementDefinitionInfo Identifier;                                                                                // MakerGen.cs:211
                    // 11. SubstanceSpecification.moiety.name
                    public ElementDefinitionInfo Name;                                                                                      // MakerGen.cs:211
                    // 12. SubstanceSpecification.moiety.stereochemistry
                    public ElementDefinitionInfo Stereochemistry;                                                                           // MakerGen.cs:211
                    // 13. SubstanceSpecification.moiety.opticalActivity
                    public ElementDefinitionInfo OpticalActivity;                                                                           // MakerGen.cs:211
                    // 14. SubstanceSpecification.moiety.molecularFormula
                    public ElementDefinitionInfo MolecularFormula;                                                                          // MakerGen.cs:211
                    // 15. SubstanceSpecification.moiety.amount[x]
                    public ElementDefinitionInfo Amount;                                                                                    // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                    public Type_Moiety_Elements()                                                                                           // MakerGen.cs:387
                    {                                                                                                                       // MakerGen.cs:388
                        {                                                                                                                   // MakerGen.cs:226
                            // 9. SubstanceSpecification.moiety.role
                            this.Role = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Role",                                                                                              // MakerGen.cs:230
                                Path= "SubstanceSpecification.moiety.role",                                                                 // MakerGen.cs:231
                                Id = "SubstanceSpecification.moiety.role",                                                                  // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 10. SubstanceSpecification.moiety.identifier
                            this.Identifier = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Identifier",                                                                                        // MakerGen.cs:230
                                Path= "SubstanceSpecification.moiety.identifier",                                                           // MakerGen.cs:231
                                Id = "SubstanceSpecification.moiety.identifier",                                                            // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Identifier                                                            // MakerGen.cs:353
                                    {                                                                                                       // MakerGen.cs:354
                                    }                                                                                                       // MakerGen.cs:355
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 11. SubstanceSpecification.moiety.name
                            this.Name = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Name",                                                                                              // MakerGen.cs:230
                                Path= "SubstanceSpecification.moiety.name",                                                                 // MakerGen.cs:231
                                Id = "SubstanceSpecification.moiety.name",                                                                  // MakerGen.cs:232
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
                            // 12. SubstanceSpecification.moiety.stereochemistry
                            this.Stereochemistry = new ElementDefinitionInfo                                                                // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Stereochemistry",                                                                                   // MakerGen.cs:230
                                Path= "SubstanceSpecification.moiety.stereochemistry",                                                      // MakerGen.cs:231
                                Id = "SubstanceSpecification.moiety.stereochemistry",                                                       // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 13. SubstanceSpecification.moiety.opticalActivity
                            this.OpticalActivity = new ElementDefinitionInfo                                                                // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "OpticalActivity",                                                                                   // MakerGen.cs:230
                                Path= "SubstanceSpecification.moiety.opticalActivity",                                                      // MakerGen.cs:231
                                Id = "SubstanceSpecification.moiety.opticalActivity",                                                       // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 14. SubstanceSpecification.moiety.molecularFormula
                            this.MolecularFormula = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "MolecularFormula",                                                                                  // MakerGen.cs:230
                                Path= "SubstanceSpecification.moiety.molecularFormula",                                                     // MakerGen.cs:231
                                Id = "SubstanceSpecification.moiety.molecularFormula",                                                      // MakerGen.cs:232
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
                            // 15. SubstanceSpecification.moiety.amount[x]
                            this.Amount = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Amount",                                                                                            // MakerGen.cs:230
                                Path= "SubstanceSpecification.moiety.amount[x]",                                                            // MakerGen.cs:231
                                Id = "SubstanceSpecification.moiety.amount[x]",                                                             // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Quantity                                                              // MakerGen.cs:353
                                    {                                                                                                       // MakerGen.cs:354
                                    },                                                                                                      // MakerGen.cs:355
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        base.Write(sDef);                                                                                                   // MakerGen.cs:395
                        Role.Write(sDef);                                                                                                   // MakerGen.cs:215
                        Identifier.Write(sDef);                                                                                             // MakerGen.cs:215
                        Name.Write(sDef);                                                                                                   // MakerGen.cs:215
                        Stereochemistry.Write(sDef);                                                                                        // MakerGen.cs:215
                        OpticalActivity.Write(sDef);                                                                                        // MakerGen.cs:215
                        MolecularFormula.Write(sDef);                                                                                       // MakerGen.cs:215
                        Amount.Write(sDef);                                                                                                 // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:397
                }                                                                                                                           // MakerGen.cs:399
                public Type_Moiety_Elements Elements                                                                                        // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    get                                                                                                                     // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:404
                        if (this.elements == null)                                                                                          // MakerGen.cs:405
                            this.elements = new Type_Moiety_Elements();                                                                     // MakerGen.cs:406
                        return this.elements;                                                                                               // MakerGen.cs:407
                    }                                                                                                                       // MakerGen.cs:408
                }                                                                                                                           // MakerGen.cs:409
                Type_Moiety_Elements elements;                                                                                              // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                public Type_Moiety()                                                                                                        // MakerGen.cs:413
                {                                                                                                                           // MakerGen.cs:414
                }                                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:419
                {                                                                                                                           // MakerGen.cs:420
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:421
                    {                                                                                                                       // MakerGen.cs:422
                        Path = "SubstanceSpecification.moiety",                                                                             // MakerGen.cs:423
                        ElementId = "SubstanceSpecification.moiety"                                                                         // MakerGen.cs:424
                    });                                                                                                                     // MakerGen.cs:425
                    if (this.elements != null)                                                                                              // MakerGen.cs:426
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:427
                }                                                                                                                           // MakerGen.cs:428
            }                                                                                                                               // MakerGen.cs:429
            // 16. SubstanceSpecification.property
            public class Type_Property : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:379
            {                                                                                                                               // MakerGen.cs:380
                public class Type_Property_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                           // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 17. SubstanceSpecification.property.category
                    public ElementDefinitionInfo Category;                                                                                  // MakerGen.cs:211
                    // 18. SubstanceSpecification.property.code
                    public ElementDefinitionInfo Code;                                                                                      // MakerGen.cs:211
                    // 19. SubstanceSpecification.property.parameters
                    public ElementDefinitionInfo Parameters;                                                                                // MakerGen.cs:211
                    // 20. SubstanceSpecification.property.definingSubstance[x]
                    public ElementDefinitionInfo DefiningSubstance;                                                                         // MakerGen.cs:211
                    // 21. SubstanceSpecification.property.amount[x]
                    public ElementDefinitionInfo Amount;                                                                                    // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                    public Type_Property_Elements()                                                                                         // MakerGen.cs:387
                    {                                                                                                                       // MakerGen.cs:388
                        {                                                                                                                   // MakerGen.cs:226
                            // 17. SubstanceSpecification.property.category
                            this.Category = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Category",                                                                                          // MakerGen.cs:230
                                Path= "SubstanceSpecification.property.category",                                                           // MakerGen.cs:231
                                Id = "SubstanceSpecification.property.category",                                                            // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 18. SubstanceSpecification.property.code
                            this.Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Code",                                                                                              // MakerGen.cs:230
                                Path= "SubstanceSpecification.property.code",                                                               // MakerGen.cs:231
                                Id = "SubstanceSpecification.property.code",                                                                // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 19. SubstanceSpecification.property.parameters
                            this.Parameters = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Parameters",                                                                                        // MakerGen.cs:230
                                Path= "SubstanceSpecification.property.parameters",                                                         // MakerGen.cs:231
                                Id = "SubstanceSpecification.property.parameters",                                                          // MakerGen.cs:232
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
                            // 20. SubstanceSpecification.property.definingSubstance[x]
                            this.DefiningSubstance = new ElementDefinitionInfo                                                              // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "DefiningSubstance",                                                                                 // MakerGen.cs:230
                                Path= "SubstanceSpecification.property.definingSubstance[x]",                                               // MakerGen.cs:231
                                Id = "SubstanceSpecification.property.definingSubstance[x]",                                                // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:341
                                    {                                                                                                       // MakerGen.cs:342
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:344
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/SubstanceSpecification",                               // MakerGen.cs:344
                                            "http://hl7.org/fhir/StructureDefinition/Substance"                                             // MakerGen.cs:344
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    },                                                                                                      // MakerGen.cs:345
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 21. SubstanceSpecification.property.amount[x]
                            this.Amount = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Amount",                                                                                            // MakerGen.cs:230
                                Path= "SubstanceSpecification.property.amount[x]",                                                          // MakerGen.cs:231
                                Id = "SubstanceSpecification.property.amount[x]",                                                           // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Quantity                                                              // MakerGen.cs:353
                                    {                                                                                                       // MakerGen.cs:354
                                    },                                                                                                      // MakerGen.cs:355
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        base.Write(sDef);                                                                                                   // MakerGen.cs:395
                        Category.Write(sDef);                                                                                               // MakerGen.cs:215
                        Code.Write(sDef);                                                                                                   // MakerGen.cs:215
                        Parameters.Write(sDef);                                                                                             // MakerGen.cs:215
                        DefiningSubstance.Write(sDef);                                                                                      // MakerGen.cs:215
                        Amount.Write(sDef);                                                                                                 // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:397
                }                                                                                                                           // MakerGen.cs:399
                public Type_Property_Elements Elements                                                                                      // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    get                                                                                                                     // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:404
                        if (this.elements == null)                                                                                          // MakerGen.cs:405
                            this.elements = new Type_Property_Elements();                                                                   // MakerGen.cs:406
                        return this.elements;                                                                                               // MakerGen.cs:407
                    }                                                                                                                       // MakerGen.cs:408
                }                                                                                                                           // MakerGen.cs:409
                Type_Property_Elements elements;                                                                                            // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                public Type_Property()                                                                                                      // MakerGen.cs:413
                {                                                                                                                           // MakerGen.cs:414
                }                                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:419
                {                                                                                                                           // MakerGen.cs:420
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:421
                    {                                                                                                                       // MakerGen.cs:422
                        Path = "SubstanceSpecification.property",                                                                           // MakerGen.cs:423
                        ElementId = "SubstanceSpecification.property"                                                                       // MakerGen.cs:424
                    });                                                                                                                     // MakerGen.cs:425
                    if (this.elements != null)                                                                                              // MakerGen.cs:426
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:427
                }                                                                                                                           // MakerGen.cs:428
            }                                                                                                                               // MakerGen.cs:429
            // 23. SubstanceSpecification.structure
            public class Type_Structure : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:379
            {                                                                                                                               // MakerGen.cs:380
                public class Type_Structure_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                          // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 28. SubstanceSpecification.structure.isotope
                    public class Type_Isotope : FhirKhit.Maker.Common.Complex.ComplexBase                                                   // MakerGen.cs:379
                    {                                                                                                                       // MakerGen.cs:380
                        public class Type_Isotope_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                    // MakerGen.cs:381
                        {                                                                                                                   // MakerGen.cs:382
                            // 33. SubstanceSpecification.structure.isotope.molecularWeight
                            public class Type_MolecularWeight : FhirKhit.Maker.Common.Complex.ComplexBase                                   // MakerGen.cs:379
                            {                                                                                                               // MakerGen.cs:380
                                public class Type_MolecularWeight_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                    // MakerGen.cs:381
                                {                                                                                                           // MakerGen.cs:382
                                    // 34. SubstanceSpecification.structure.isotope.molecularWeight.method
                                    public ElementDefinitionInfo Method;                                                                    // MakerGen.cs:211
                                    // 35. SubstanceSpecification.structure.isotope.molecularWeight.type
                                    public ElementDefinitionInfo Type;                                                                      // MakerGen.cs:211
                                    // 36. SubstanceSpecification.structure.isotope.molecularWeight.amount
                                    public ElementDefinitionInfo Amount;                                                                    // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                                    public Type_MolecularWeight_Elements()                                                                  // MakerGen.cs:387
                                    {                                                                                                       // MakerGen.cs:388
                                        {                                                                                                   // MakerGen.cs:226
                                            // 34. SubstanceSpecification.structure.isotope.molecularWeight.method
                                            this.Method = new ElementDefinitionInfo                                                         // MakerGen.cs:228
                                            {                                                                                               // MakerGen.cs:229
                                                Name = "Method",                                                                            // MakerGen.cs:230
                                                Path= "SubstanceSpecification.structure.isotope.molecularWeight.method",                    // MakerGen.cs:231
                                                Id = "SubstanceSpecification.structure.isotope.molecularWeight.method",                     // MakerGen.cs:232
                                                Min = 0,                                                                                    // MakerGen.cs:233
                                                Max = 1,                                                                                    // MakerGen.cs:234
                                                Types = new BaseType[]                                                                      // MakerGen.cs:235
                                                {                                                                                           // MakerGen.cs:236
                                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                       // MakerGen.cs:310
                                                    {                                                                                       // MakerGen.cs:311
                                                    }                                                                                       // MakerGen.cs:314
                                                }                                                                                           // MakerGen.cs:238
                                            };                                                                                              // MakerGen.cs:239
                                        }                                                                                                   // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:226
                                            // 35. SubstanceSpecification.structure.isotope.molecularWeight.type
                                            this.Type = new ElementDefinitionInfo                                                           // MakerGen.cs:228
                                            {                                                                                               // MakerGen.cs:229
                                                Name = "Type",                                                                              // MakerGen.cs:230
                                                Path= "SubstanceSpecification.structure.isotope.molecularWeight.type",                      // MakerGen.cs:231
                                                Id = "SubstanceSpecification.structure.isotope.molecularWeight.type",                       // MakerGen.cs:232
                                                Min = 0,                                                                                    // MakerGen.cs:233
                                                Max = 1,                                                                                    // MakerGen.cs:234
                                                Types = new BaseType[]                                                                      // MakerGen.cs:235
                                                {                                                                                           // MakerGen.cs:236
                                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                       // MakerGen.cs:310
                                                    {                                                                                       // MakerGen.cs:311
                                                    }                                                                                       // MakerGen.cs:314
                                                }                                                                                           // MakerGen.cs:238
                                            };                                                                                              // MakerGen.cs:239
                                        }                                                                                                   // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:226
                                            // 36. SubstanceSpecification.structure.isotope.molecularWeight.amount
                                            this.Amount = new ElementDefinitionInfo                                                         // MakerGen.cs:228
                                            {                                                                                               // MakerGen.cs:229
                                                Name = "Amount",                                                                            // MakerGen.cs:230
                                                Path= "SubstanceSpecification.structure.isotope.molecularWeight.amount",                    // MakerGen.cs:231
                                                Id = "SubstanceSpecification.structure.isotope.molecularWeight.amount",                     // MakerGen.cs:232
                                                Min = 0,                                                                                    // MakerGen.cs:233
                                                Max = 1,                                                                                    // MakerGen.cs:234
                                                Types = new BaseType[]                                                                      // MakerGen.cs:235
                                                {                                                                                           // MakerGen.cs:236
                                                    new FhirKhit.Maker.Common.Complex.Quantity                                              // MakerGen.cs:353
                                                    {                                                                                       // MakerGen.cs:354
                                                    }                                                                                       // MakerGen.cs:355
                                                }                                                                                           // MakerGen.cs:238
                                            };                                                                                              // MakerGen.cs:239
                                        }                                                                                                   // MakerGen.cs:240
                                    }                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                     // MakerGen.cs:393
                                    {                                                                                                       // MakerGen.cs:394
                                        base.Write(sDef);                                                                                   // MakerGen.cs:395
                                        Method.Write(sDef);                                                                                 // MakerGen.cs:215
                                        Type.Write(sDef);                                                                                   // MakerGen.cs:215
                                        Amount.Write(sDef);                                                                                 // MakerGen.cs:215
                                    }                                                                                                       // MakerGen.cs:397
                                }                                                                                                           // MakerGen.cs:399
                                public Type_MolecularWeight_Elements Elements                                                               // MakerGen.cs:401
                                {                                                                                                           // MakerGen.cs:402
                                    get                                                                                                     // MakerGen.cs:403
                                    {                                                                                                       // MakerGen.cs:404
                                        if (this.elements == null)                                                                          // MakerGen.cs:405
                                            this.elements = new Type_MolecularWeight_Elements();                                            // MakerGen.cs:406
                                        return this.elements;                                                                               // MakerGen.cs:407
                                    }                                                                                                       // MakerGen.cs:408
                                }                                                                                                           // MakerGen.cs:409
                                Type_MolecularWeight_Elements elements;                                                                     // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                                public Type_MolecularWeight()                                                                               // MakerGen.cs:413
                                {                                                                                                           // MakerGen.cs:414
                                }                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                         // MakerGen.cs:419
                                {                                                                                                           // MakerGen.cs:420
                                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                      // MakerGen.cs:421
                                    {                                                                                                       // MakerGen.cs:422
                                        Path = "SubstanceSpecification.structure.isotope.molecularWeight",                                  // MakerGen.cs:423
                                        ElementId = "SubstanceSpecification.structure.isotope.molecularWeight"                              // MakerGen.cs:424
                                    });                                                                                                     // MakerGen.cs:425
                                    if (this.elements != null)                                                                              // MakerGen.cs:426
                                        this.elements.Write(sDef);                                                                          // MakerGen.cs:427
                                }                                                                                                           // MakerGen.cs:428
                            }                                                                                                               // MakerGen.cs:429
                            // 29. SubstanceSpecification.structure.isotope.identifier
                            public ElementDefinitionInfo Identifier;                                                                        // MakerGen.cs:211
                            // 30. SubstanceSpecification.structure.isotope.name
                            public ElementDefinitionInfo Name;                                                                              // MakerGen.cs:211
                            // 31. SubstanceSpecification.structure.isotope.substitution
                            public ElementDefinitionInfo Substitution;                                                                      // MakerGen.cs:211
                            // 32. SubstanceSpecification.structure.isotope.halfLife
                            public ElementDefinitionInfo HalfLife;                                                                          // MakerGen.cs:211
                            // 33. SubstanceSpecification.structure.isotope.molecularWeight
                            public ElementDefinitionInfo MolecularWeight;                                                                   // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                            public Type_Isotope_Elements()                                                                                  // MakerGen.cs:387
                            {                                                                                                               // MakerGen.cs:388
                                {                                                                                                           // MakerGen.cs:226
                                    // 29. SubstanceSpecification.structure.isotope.identifier
                                    this.Identifier = new ElementDefinitionInfo                                                             // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Identifier",                                                                                // MakerGen.cs:230
                                        Path= "SubstanceSpecification.structure.isotope.identifier",                                        // MakerGen.cs:231
                                        Id = "SubstanceSpecification.structure.isotope.identifier",                                         // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Identifier                                                    // MakerGen.cs:353
                                            {                                                                                               // MakerGen.cs:354
                                            }                                                                                               // MakerGen.cs:355
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 30. SubstanceSpecification.structure.isotope.name
                                    this.Name = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Name",                                                                                      // MakerGen.cs:230
                                        Path= "SubstanceSpecification.structure.isotope.name",                                              // MakerGen.cs:231
                                        Id = "SubstanceSpecification.structure.isotope.name",                                               // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:310
                                            {                                                                                               // MakerGen.cs:311
                                            }                                                                                               // MakerGen.cs:314
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 31. SubstanceSpecification.structure.isotope.substitution
                                    this.Substitution = new ElementDefinitionInfo                                                           // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Substitution",                                                                              // MakerGen.cs:230
                                        Path= "SubstanceSpecification.structure.isotope.substitution",                                      // MakerGen.cs:231
                                        Id = "SubstanceSpecification.structure.isotope.substitution",                                       // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:310
                                            {                                                                                               // MakerGen.cs:311
                                            }                                                                                               // MakerGen.cs:314
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 32. SubstanceSpecification.structure.isotope.halfLife
                                    this.HalfLife = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "HalfLife",                                                                                  // MakerGen.cs:230
                                        Path= "SubstanceSpecification.structure.isotope.halfLife",                                          // MakerGen.cs:231
                                        Id = "SubstanceSpecification.structure.isotope.halfLife",                                           // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Quantity                                                      // MakerGen.cs:353
                                            {                                                                                               // MakerGen.cs:354
                                            }                                                                                               // MakerGen.cs:355
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 33. SubstanceSpecification.structure.isotope.molecularWeight
                                    this.MolecularWeight = new ElementDefinitionInfo                                                        // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "MolecularWeight",                                                                           // MakerGen.cs:230
                                        Path= "SubstanceSpecification.structure.isotope.molecularWeight",                                   // MakerGen.cs:231
                                        Id = "SubstanceSpecification.structure.isotope.molecularWeight",                                    // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new Type_MolecularWeight                                                                        // MakerGen.cs:254
                                            {                                                                                               // MakerGen.cs:255
                                            }                                                                                               // MakerGen.cs:256
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:393
                            {                                                                                                               // MakerGen.cs:394
                                base.Write(sDef);                                                                                           // MakerGen.cs:395
                                Identifier.Write(sDef);                                                                                     // MakerGen.cs:215
                                Name.Write(sDef);                                                                                           // MakerGen.cs:215
                                Substitution.Write(sDef);                                                                                   // MakerGen.cs:215
                                HalfLife.Write(sDef);                                                                                       // MakerGen.cs:215
                                MolecularWeight.Write(sDef);                                                                                // MakerGen.cs:215
                            }                                                                                                               // MakerGen.cs:397
                        }                                                                                                                   // MakerGen.cs:399
                        public Type_Isotope_Elements Elements                                                                               // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            get                                                                                                             // MakerGen.cs:403
                            {                                                                                                               // MakerGen.cs:404
                                if (this.elements == null)                                                                                  // MakerGen.cs:405
                                    this.elements = new Type_Isotope_Elements();                                                            // MakerGen.cs:406
                                return this.elements;                                                                                       // MakerGen.cs:407
                            }                                                                                                               // MakerGen.cs:408
                        }                                                                                                                   // MakerGen.cs:409
                        Type_Isotope_Elements elements;                                                                                     // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                        public Type_Isotope()                                                                                               // MakerGen.cs:413
                        {                                                                                                                   // MakerGen.cs:414
                        }                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:419
                        {                                                                                                                   // MakerGen.cs:420
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:421
                            {                                                                                                               // MakerGen.cs:422
                                Path = "SubstanceSpecification.structure.isotope",                                                          // MakerGen.cs:423
                                ElementId = "SubstanceSpecification.structure.isotope"                                                      // MakerGen.cs:424
                            });                                                                                                             // MakerGen.cs:425
                            if (this.elements != null)                                                                                      // MakerGen.cs:426
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:427
                        }                                                                                                                   // MakerGen.cs:428
                    }                                                                                                                       // MakerGen.cs:429
                    // 39. SubstanceSpecification.structure.representation
                    public class Type_Representation : FhirKhit.Maker.Common.Complex.ComplexBase                                            // MakerGen.cs:379
                    {                                                                                                                       // MakerGen.cs:380
                        public class Type_Representation_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                             // MakerGen.cs:381
                        {                                                                                                                   // MakerGen.cs:382
                            // 40. SubstanceSpecification.structure.representation.type
                            public ElementDefinitionInfo Type;                                                                              // MakerGen.cs:211
                            // 41. SubstanceSpecification.structure.representation.representation
                            public ElementDefinitionInfo Representation;                                                                    // MakerGen.cs:211
                            // 42. SubstanceSpecification.structure.representation.attachment
                            public ElementDefinitionInfo Attachment;                                                                        // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                            public Type_Representation_Elements()                                                                           // MakerGen.cs:387
                            {                                                                                                               // MakerGen.cs:388
                                {                                                                                                           // MakerGen.cs:226
                                    // 40. SubstanceSpecification.structure.representation.type
                                    this.Type = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Type",                                                                                      // MakerGen.cs:230
                                        Path= "SubstanceSpecification.structure.representation.type",                                       // MakerGen.cs:231
                                        Id = "SubstanceSpecification.structure.representation.type",                                        // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:310
                                            {                                                                                               // MakerGen.cs:311
                                            }                                                                                               // MakerGen.cs:314
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 41. SubstanceSpecification.structure.representation.representation
                                    this.Representation = new ElementDefinitionInfo                                                         // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Representation",                                                                            // MakerGen.cs:230
                                        Path= "SubstanceSpecification.structure.representation.representation",                             // MakerGen.cs:231
                                        Id = "SubstanceSpecification.structure.representation.representation",                              // MakerGen.cs:232
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
                                    // 42. SubstanceSpecification.structure.representation.attachment
                                    this.Attachment = new ElementDefinitionInfo                                                             // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Attachment",                                                                                // MakerGen.cs:230
                                        Path= "SubstanceSpecification.structure.representation.attachment",                                 // MakerGen.cs:231
                                        Id = "SubstanceSpecification.structure.representation.attachment",                                  // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Attachment                                                    // MakerGen.cs:353
                                            {                                                                                               // MakerGen.cs:354
                                            }                                                                                               // MakerGen.cs:355
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:393
                            {                                                                                                               // MakerGen.cs:394
                                base.Write(sDef);                                                                                           // MakerGen.cs:395
                                Type.Write(sDef);                                                                                           // MakerGen.cs:215
                                Representation.Write(sDef);                                                                                 // MakerGen.cs:215
                                Attachment.Write(sDef);                                                                                     // MakerGen.cs:215
                            }                                                                                                               // MakerGen.cs:397
                        }                                                                                                                   // MakerGen.cs:399
                        public Type_Representation_Elements Elements                                                                        // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            get                                                                                                             // MakerGen.cs:403
                            {                                                                                                               // MakerGen.cs:404
                                if (this.elements == null)                                                                                  // MakerGen.cs:405
                                    this.elements = new Type_Representation_Elements();                                                     // MakerGen.cs:406
                                return this.elements;                                                                                       // MakerGen.cs:407
                            }                                                                                                               // MakerGen.cs:408
                        }                                                                                                                   // MakerGen.cs:409
                        Type_Representation_Elements elements;                                                                              // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                        public Type_Representation()                                                                                        // MakerGen.cs:413
                        {                                                                                                                   // MakerGen.cs:414
                        }                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:419
                        {                                                                                                                   // MakerGen.cs:420
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:421
                            {                                                                                                               // MakerGen.cs:422
                                Path = "SubstanceSpecification.structure.representation",                                                   // MakerGen.cs:423
                                ElementId = "SubstanceSpecification.structure.representation"                                               // MakerGen.cs:424
                            });                                                                                                             // MakerGen.cs:425
                            if (this.elements != null)                                                                                      // MakerGen.cs:426
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:427
                        }                                                                                                                   // MakerGen.cs:428
                    }                                                                                                                       // MakerGen.cs:429
                    // 24. SubstanceSpecification.structure.stereochemistry
                    public ElementDefinitionInfo Stereochemistry;                                                                           // MakerGen.cs:211
                    // 25. SubstanceSpecification.structure.opticalActivity
                    public ElementDefinitionInfo OpticalActivity;                                                                           // MakerGen.cs:211
                    // 26. SubstanceSpecification.structure.molecularFormula
                    public ElementDefinitionInfo MolecularFormula;                                                                          // MakerGen.cs:211
                    // 27. SubstanceSpecification.structure.molecularFormulaByMoiety
                    public ElementDefinitionInfo MolecularFormulaByMoiety;                                                                  // MakerGen.cs:211
                    // 28. SubstanceSpecification.structure.isotope
                    public ElementDefinitionInfo Isotope;                                                                                   // MakerGen.cs:211
                    // 37. SubstanceSpecification.structure.molecularWeight
                    public ElementDefinitionInfo MolecularWeight;                                                                           // MakerGen.cs:211
                    // 38. SubstanceSpecification.structure.source
                    public ElementDefinitionInfo Source;                                                                                    // MakerGen.cs:211
                    // 39. SubstanceSpecification.structure.representation
                    public ElementDefinitionInfo Representation;                                                                            // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                    public Type_Structure_Elements()                                                                                        // MakerGen.cs:387
                    {                                                                                                                       // MakerGen.cs:388
                        {                                                                                                                   // MakerGen.cs:226
                            // 24. SubstanceSpecification.structure.stereochemistry
                            this.Stereochemistry = new ElementDefinitionInfo                                                                // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Stereochemistry",                                                                                   // MakerGen.cs:230
                                Path= "SubstanceSpecification.structure.stereochemistry",                                                   // MakerGen.cs:231
                                Id = "SubstanceSpecification.structure.stereochemistry",                                                    // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 25. SubstanceSpecification.structure.opticalActivity
                            this.OpticalActivity = new ElementDefinitionInfo                                                                // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "OpticalActivity",                                                                                   // MakerGen.cs:230
                                Path= "SubstanceSpecification.structure.opticalActivity",                                                   // MakerGen.cs:231
                                Id = "SubstanceSpecification.structure.opticalActivity",                                                    // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 26. SubstanceSpecification.structure.molecularFormula
                            this.MolecularFormula = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "MolecularFormula",                                                                                  // MakerGen.cs:230
                                Path= "SubstanceSpecification.structure.molecularFormula",                                                  // MakerGen.cs:231
                                Id = "SubstanceSpecification.structure.molecularFormula",                                                   // MakerGen.cs:232
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
                            // 27. SubstanceSpecification.structure.molecularFormulaByMoiety
                            this.MolecularFormulaByMoiety = new ElementDefinitionInfo                                                       // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "MolecularFormulaByMoiety",                                                                          // MakerGen.cs:230
                                Path= "SubstanceSpecification.structure.molecularFormulaByMoiety",                                          // MakerGen.cs:231
                                Id = "SubstanceSpecification.structure.molecularFormulaByMoiety",                                           // MakerGen.cs:232
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
                            // 28. SubstanceSpecification.structure.isotope
                            this.Isotope = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Isotope",                                                                                           // MakerGen.cs:230
                                Path= "SubstanceSpecification.structure.isotope",                                                           // MakerGen.cs:231
                                Id = "SubstanceSpecification.structure.isotope",                                                            // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new Type_Isotope                                                                                        // MakerGen.cs:254
                                    {                                                                                                       // MakerGen.cs:255
                                    }                                                                                                       // MakerGen.cs:256
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 37. SubstanceSpecification.structure.molecularWeight
                            this.MolecularWeight = new ElementDefinitionInfo                                                                // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "MolecularWeight",                                                                                   // MakerGen.cs:230
                                Path= "SubstanceSpecification.structure.molecularWeight",                                                   // MakerGen.cs:231
                                Id = "SubstanceSpecification.structure.molecularWeight",                                                    // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 38. SubstanceSpecification.structure.source
                            this.Source = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Source",                                                                                            // MakerGen.cs:230
                                Path= "SubstanceSpecification.structure.source",                                                            // MakerGen.cs:231
                                Id = "SubstanceSpecification.structure.source",                                                             // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:341
                                    {                                                                                                       // MakerGen.cs:342
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:344
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/DocumentReference"                                     // MakerGen.cs:344
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:345
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 39. SubstanceSpecification.structure.representation
                            this.Representation = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Representation",                                                                                    // MakerGen.cs:230
                                Path= "SubstanceSpecification.structure.representation",                                                    // MakerGen.cs:231
                                Id = "SubstanceSpecification.structure.representation",                                                     // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new Type_Representation                                                                                 // MakerGen.cs:254
                                    {                                                                                                       // MakerGen.cs:255
                                    }                                                                                                       // MakerGen.cs:256
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        base.Write(sDef);                                                                                                   // MakerGen.cs:395
                        Stereochemistry.Write(sDef);                                                                                        // MakerGen.cs:215
                        OpticalActivity.Write(sDef);                                                                                        // MakerGen.cs:215
                        MolecularFormula.Write(sDef);                                                                                       // MakerGen.cs:215
                        MolecularFormulaByMoiety.Write(sDef);                                                                               // MakerGen.cs:215
                        Isotope.Write(sDef);                                                                                                // MakerGen.cs:215
                        MolecularWeight.Write(sDef);                                                                                        // MakerGen.cs:215
                        Source.Write(sDef);                                                                                                 // MakerGen.cs:215
                        Representation.Write(sDef);                                                                                         // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:397
                }                                                                                                                           // MakerGen.cs:399
                public Type_Structure_Elements Elements                                                                                     // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    get                                                                                                                     // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:404
                        if (this.elements == null)                                                                                          // MakerGen.cs:405
                            this.elements = new Type_Structure_Elements();                                                                  // MakerGen.cs:406
                        return this.elements;                                                                                               // MakerGen.cs:407
                    }                                                                                                                       // MakerGen.cs:408
                }                                                                                                                           // MakerGen.cs:409
                Type_Structure_Elements elements;                                                                                           // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                public Type_Structure()                                                                                                     // MakerGen.cs:413
                {                                                                                                                           // MakerGen.cs:414
                }                                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:419
                {                                                                                                                           // MakerGen.cs:420
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:421
                    {                                                                                                                       // MakerGen.cs:422
                        Path = "SubstanceSpecification.structure",                                                                          // MakerGen.cs:423
                        ElementId = "SubstanceSpecification.structure"                                                                      // MakerGen.cs:424
                    });                                                                                                                     // MakerGen.cs:425
                    if (this.elements != null)                                                                                              // MakerGen.cs:426
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:427
                }                                                                                                                           // MakerGen.cs:428
            }                                                                                                                               // MakerGen.cs:429
            // 43. SubstanceSpecification.code
            public class Type_Code : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:379
            {                                                                                                                               // MakerGen.cs:380
                public class Type_Code_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                               // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 44. SubstanceSpecification.code.code
                    public ElementDefinitionInfo Code;                                                                                      // MakerGen.cs:211
                    // 45. SubstanceSpecification.code.status
                    public ElementDefinitionInfo Status;                                                                                    // MakerGen.cs:211
                    // 46. SubstanceSpecification.code.statusDate
                    public ElementDefinitionInfo StatusDate;                                                                                // MakerGen.cs:211
                    // 47. SubstanceSpecification.code.comment
                    public ElementDefinitionInfo Comment;                                                                                   // MakerGen.cs:211
                    // 48. SubstanceSpecification.code.source
                    public ElementDefinitionInfo Source;                                                                                    // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                    public Type_Code_Elements()                                                                                             // MakerGen.cs:387
                    {                                                                                                                       // MakerGen.cs:388
                        {                                                                                                                   // MakerGen.cs:226
                            // 44. SubstanceSpecification.code.code
                            this.Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Code",                                                                                              // MakerGen.cs:230
                                Path= "SubstanceSpecification.code.code",                                                                   // MakerGen.cs:231
                                Id = "SubstanceSpecification.code.code",                                                                    // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 45. SubstanceSpecification.code.status
                            this.Status = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Status",                                                                                            // MakerGen.cs:230
                                Path= "SubstanceSpecification.code.status",                                                                 // MakerGen.cs:231
                                Id = "SubstanceSpecification.code.status",                                                                  // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 46. SubstanceSpecification.code.statusDate
                            this.StatusDate = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "StatusDate",                                                                                        // MakerGen.cs:230
                                Path= "SubstanceSpecification.code.statusDate",                                                             // MakerGen.cs:231
                                Id = "SubstanceSpecification.code.statusDate",                                                              // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.DateTime                                                            // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 47. SubstanceSpecification.code.comment
                            this.Comment = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Comment",                                                                                           // MakerGen.cs:230
                                Path= "SubstanceSpecification.code.comment",                                                                // MakerGen.cs:231
                                Id = "SubstanceSpecification.code.comment",                                                                 // MakerGen.cs:232
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
                            // 48. SubstanceSpecification.code.source
                            this.Source = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Source",                                                                                            // MakerGen.cs:230
                                Path= "SubstanceSpecification.code.source",                                                                 // MakerGen.cs:231
                                Id = "SubstanceSpecification.code.source",                                                                  // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:341
                                    {                                                                                                       // MakerGen.cs:342
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:344
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/DocumentReference"                                     // MakerGen.cs:344
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:345
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        base.Write(sDef);                                                                                                   // MakerGen.cs:395
                        Code.Write(sDef);                                                                                                   // MakerGen.cs:215
                        Status.Write(sDef);                                                                                                 // MakerGen.cs:215
                        StatusDate.Write(sDef);                                                                                             // MakerGen.cs:215
                        Comment.Write(sDef);                                                                                                // MakerGen.cs:215
                        Source.Write(sDef);                                                                                                 // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:397
                }                                                                                                                           // MakerGen.cs:399
                public Type_Code_Elements Elements                                                                                          // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    get                                                                                                                     // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:404
                        if (this.elements == null)                                                                                          // MakerGen.cs:405
                            this.elements = new Type_Code_Elements();                                                                       // MakerGen.cs:406
                        return this.elements;                                                                                               // MakerGen.cs:407
                    }                                                                                                                       // MakerGen.cs:408
                }                                                                                                                           // MakerGen.cs:409
                Type_Code_Elements elements;                                                                                                // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                public Type_Code()                                                                                                          // MakerGen.cs:413
                {                                                                                                                           // MakerGen.cs:414
                }                                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:419
                {                                                                                                                           // MakerGen.cs:420
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:421
                    {                                                                                                                       // MakerGen.cs:422
                        Path = "SubstanceSpecification.code",                                                                               // MakerGen.cs:423
                        ElementId = "SubstanceSpecification.code"                                                                           // MakerGen.cs:424
                    });                                                                                                                     // MakerGen.cs:425
                    if (this.elements != null)                                                                                              // MakerGen.cs:426
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:427
                }                                                                                                                           // MakerGen.cs:428
            }                                                                                                                               // MakerGen.cs:429
            // 49. SubstanceSpecification.name
            public class Type_Name : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:379
            {                                                                                                                               // MakerGen.cs:380
                public class Type_Name_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                               // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 59. SubstanceSpecification.name.official
                    public class Type_Official : FhirKhit.Maker.Common.Complex.ComplexBase                                                  // MakerGen.cs:379
                    {                                                                                                                       // MakerGen.cs:380
                        public class Type_Official_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                   // MakerGen.cs:381
                        {                                                                                                                   // MakerGen.cs:382
                            // 60. SubstanceSpecification.name.official.authority
                            public ElementDefinitionInfo Authority;                                                                         // MakerGen.cs:211
                            // 61. SubstanceSpecification.name.official.status
                            public ElementDefinitionInfo Status;                                                                            // MakerGen.cs:211
                            // 62. SubstanceSpecification.name.official.date
                            public ElementDefinitionInfo Date;                                                                              // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                            public Type_Official_Elements()                                                                                 // MakerGen.cs:387
                            {                                                                                                               // MakerGen.cs:388
                                {                                                                                                           // MakerGen.cs:226
                                    // 60. SubstanceSpecification.name.official.authority
                                    this.Authority = new ElementDefinitionInfo                                                              // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Authority",                                                                                 // MakerGen.cs:230
                                        Path= "SubstanceSpecification.name.official.authority",                                             // MakerGen.cs:231
                                        Id = "SubstanceSpecification.name.official.authority",                                              // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:310
                                            {                                                                                               // MakerGen.cs:311
                                            }                                                                                               // MakerGen.cs:314
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 61. SubstanceSpecification.name.official.status
                                    this.Status = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Status",                                                                                    // MakerGen.cs:230
                                        Path= "SubstanceSpecification.name.official.status",                                                // MakerGen.cs:231
                                        Id = "SubstanceSpecification.name.official.status",                                                 // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:310
                                            {                                                                                               // MakerGen.cs:311
                                            }                                                                                               // MakerGen.cs:314
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 62. SubstanceSpecification.name.official.date
                                    this.Date = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Date",                                                                                      // MakerGen.cs:230
                                        Path= "SubstanceSpecification.name.official.date",                                                  // MakerGen.cs:231
                                        Id = "SubstanceSpecification.name.official.date",                                                   // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.DateTime                                                    // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:393
                            {                                                                                                               // MakerGen.cs:394
                                base.Write(sDef);                                                                                           // MakerGen.cs:395
                                Authority.Write(sDef);                                                                                      // MakerGen.cs:215
                                Status.Write(sDef);                                                                                         // MakerGen.cs:215
                                Date.Write(sDef);                                                                                           // MakerGen.cs:215
                            }                                                                                                               // MakerGen.cs:397
                        }                                                                                                                   // MakerGen.cs:399
                        public Type_Official_Elements Elements                                                                              // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            get                                                                                                             // MakerGen.cs:403
                            {                                                                                                               // MakerGen.cs:404
                                if (this.elements == null)                                                                                  // MakerGen.cs:405
                                    this.elements = new Type_Official_Elements();                                                           // MakerGen.cs:406
                                return this.elements;                                                                                       // MakerGen.cs:407
                            }                                                                                                               // MakerGen.cs:408
                        }                                                                                                                   // MakerGen.cs:409
                        Type_Official_Elements elements;                                                                                    // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                        public Type_Official()                                                                                              // MakerGen.cs:413
                        {                                                                                                                   // MakerGen.cs:414
                        }                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:419
                        {                                                                                                                   // MakerGen.cs:420
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:421
                            {                                                                                                               // MakerGen.cs:422
                                Path = "SubstanceSpecification.name.official",                                                              // MakerGen.cs:423
                                ElementId = "SubstanceSpecification.name.official"                                                          // MakerGen.cs:424
                            });                                                                                                             // MakerGen.cs:425
                            if (this.elements != null)                                                                                      // MakerGen.cs:426
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:427
                        }                                                                                                                   // MakerGen.cs:428
                    }                                                                                                                       // MakerGen.cs:429
                    // 50. SubstanceSpecification.name.name
                    public ElementDefinitionInfo Name;                                                                                      // MakerGen.cs:211
                    // 51. SubstanceSpecification.name.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:211
                    // 52. SubstanceSpecification.name.status
                    public ElementDefinitionInfo Status;                                                                                    // MakerGen.cs:211
                    // 53. SubstanceSpecification.name.preferred
                    public ElementDefinitionInfo Preferred;                                                                                 // MakerGen.cs:211
                    // 54. SubstanceSpecification.name.language
                    public ElementDefinitionInfo Language;                                                                                  // MakerGen.cs:211
                    // 55. SubstanceSpecification.name.domain
                    public ElementDefinitionInfo Domain;                                                                                    // MakerGen.cs:211
                    // 56. SubstanceSpecification.name.jurisdiction
                    public ElementDefinitionInfo Jurisdiction;                                                                              // MakerGen.cs:211
                    // 57. SubstanceSpecification.name.synonym
                    public ElementDefinitionInfo Synonym;                                                                                   // MakerGen.cs:211
                    // 58. SubstanceSpecification.name.translation
                    public ElementDefinitionInfo Translation;                                                                               // MakerGen.cs:211
                    // 59. SubstanceSpecification.name.official
                    public ElementDefinitionInfo Official;                                                                                  // MakerGen.cs:211
                    // 63. SubstanceSpecification.name.source
                    public ElementDefinitionInfo Source;                                                                                    // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                    public Type_Name_Elements()                                                                                             // MakerGen.cs:387
                    {                                                                                                                       // MakerGen.cs:388
                        {                                                                                                                   // MakerGen.cs:226
                            // 50. SubstanceSpecification.name.name
                            this.Name = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Name",                                                                                              // MakerGen.cs:230
                                Path= "SubstanceSpecification.name.name",                                                                   // MakerGen.cs:231
                                Id = "SubstanceSpecification.name.name",                                                                    // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
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
                            // 51. SubstanceSpecification.name.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Type",                                                                                              // MakerGen.cs:230
                                Path= "SubstanceSpecification.name.type",                                                                   // MakerGen.cs:231
                                Id = "SubstanceSpecification.name.type",                                                                    // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 52. SubstanceSpecification.name.status
                            this.Status = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Status",                                                                                            // MakerGen.cs:230
                                Path= "SubstanceSpecification.name.status",                                                                 // MakerGen.cs:231
                                Id = "SubstanceSpecification.name.status",                                                                  // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 53. SubstanceSpecification.name.preferred
                            this.Preferred = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Preferred",                                                                                         // MakerGen.cs:230
                                Path= "SubstanceSpecification.name.preferred",                                                              // MakerGen.cs:231
                                Id = "SubstanceSpecification.name.preferred",                                                               // MakerGen.cs:232
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
                            // 54. SubstanceSpecification.name.language
                            this.Language = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Language",                                                                                          // MakerGen.cs:230
                                Path= "SubstanceSpecification.name.language",                                                               // MakerGen.cs:231
                                Id = "SubstanceSpecification.name.language",                                                                // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 55. SubstanceSpecification.name.domain
                            this.Domain = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Domain",                                                                                            // MakerGen.cs:230
                                Path= "SubstanceSpecification.name.domain",                                                                 // MakerGen.cs:231
                                Id = "SubstanceSpecification.name.domain",                                                                  // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 56. SubstanceSpecification.name.jurisdiction
                            this.Jurisdiction = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Jurisdiction",                                                                                      // MakerGen.cs:230
                                Path= "SubstanceSpecification.name.jurisdiction",                                                           // MakerGen.cs:231
                                Id = "SubstanceSpecification.name.jurisdiction",                                                            // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 57. SubstanceSpecification.name.synonym
                            this.Synonym = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Synonym",                                                                                           // MakerGen.cs:230
                                Path= "SubstanceSpecification.name.synonym",                                                                // MakerGen.cs:231
                                Id = "SubstanceSpecification.name.synonym",                                                                 // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 58. SubstanceSpecification.name.translation
                            this.Translation = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Translation",                                                                                       // MakerGen.cs:230
                                Path= "SubstanceSpecification.name.translation",                                                            // MakerGen.cs:231
                                Id = "SubstanceSpecification.name.translation",                                                             // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 59. SubstanceSpecification.name.official
                            this.Official = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Official",                                                                                          // MakerGen.cs:230
                                Path= "SubstanceSpecification.name.official",                                                               // MakerGen.cs:231
                                Id = "SubstanceSpecification.name.official",                                                                // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new Type_Official                                                                                       // MakerGen.cs:254
                                    {                                                                                                       // MakerGen.cs:255
                                    }                                                                                                       // MakerGen.cs:256
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 63. SubstanceSpecification.name.source
                            this.Source = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Source",                                                                                            // MakerGen.cs:230
                                Path= "SubstanceSpecification.name.source",                                                                 // MakerGen.cs:231
                                Id = "SubstanceSpecification.name.source",                                                                  // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:341
                                    {                                                                                                       // MakerGen.cs:342
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:344
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/DocumentReference"                                     // MakerGen.cs:344
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:345
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        base.Write(sDef);                                                                                                   // MakerGen.cs:395
                        Name.Write(sDef);                                                                                                   // MakerGen.cs:215
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:215
                        Status.Write(sDef);                                                                                                 // MakerGen.cs:215
                        Preferred.Write(sDef);                                                                                              // MakerGen.cs:215
                        Language.Write(sDef);                                                                                               // MakerGen.cs:215
                        Domain.Write(sDef);                                                                                                 // MakerGen.cs:215
                        Jurisdiction.Write(sDef);                                                                                           // MakerGen.cs:215
                        Synonym.Write(sDef);                                                                                                // MakerGen.cs:215
                        Translation.Write(sDef);                                                                                            // MakerGen.cs:215
                        Official.Write(sDef);                                                                                               // MakerGen.cs:215
                        Source.Write(sDef);                                                                                                 // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:397
                }                                                                                                                           // MakerGen.cs:399
                public Type_Name_Elements Elements                                                                                          // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    get                                                                                                                     // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:404
                        if (this.elements == null)                                                                                          // MakerGen.cs:405
                            this.elements = new Type_Name_Elements();                                                                       // MakerGen.cs:406
                        return this.elements;                                                                                               // MakerGen.cs:407
                    }                                                                                                                       // MakerGen.cs:408
                }                                                                                                                           // MakerGen.cs:409
                Type_Name_Elements elements;                                                                                                // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                public Type_Name()                                                                                                          // MakerGen.cs:413
                {                                                                                                                           // MakerGen.cs:414
                }                                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:419
                {                                                                                                                           // MakerGen.cs:420
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:421
                    {                                                                                                                       // MakerGen.cs:422
                        Path = "SubstanceSpecification.name",                                                                               // MakerGen.cs:423
                        ElementId = "SubstanceSpecification.name"                                                                           // MakerGen.cs:424
                    });                                                                                                                     // MakerGen.cs:425
                    if (this.elements != null)                                                                                              // MakerGen.cs:426
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:427
                }                                                                                                                           // MakerGen.cs:428
            }                                                                                                                               // MakerGen.cs:429
            // 65. SubstanceSpecification.relationship
            public class Type_Relationship : FhirKhit.Maker.Common.Complex.ComplexBase                                                      // MakerGen.cs:379
            {                                                                                                                               // MakerGen.cs:380
                public class Type_Relationship_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                       // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 66. SubstanceSpecification.relationship.substance[x]
                    public ElementDefinitionInfo Substance;                                                                                 // MakerGen.cs:211
                    // 67. SubstanceSpecification.relationship.relationship
                    public ElementDefinitionInfo Relationship;                                                                              // MakerGen.cs:211
                    // 68. SubstanceSpecification.relationship.isDefining
                    public ElementDefinitionInfo IsDefining;                                                                                // MakerGen.cs:211
                    // 69. SubstanceSpecification.relationship.amount[x]
                    public ElementDefinitionInfo Amount;                                                                                    // MakerGen.cs:211
                    // 70. SubstanceSpecification.relationship.amountRatioLowLimit
                    public ElementDefinitionInfo AmountRatioLowLimit;                                                                       // MakerGen.cs:211
                    // 71. SubstanceSpecification.relationship.amountType
                    public ElementDefinitionInfo AmountType;                                                                                // MakerGen.cs:211
                    // 72. SubstanceSpecification.relationship.source
                    public ElementDefinitionInfo Source;                                                                                    // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                    public Type_Relationship_Elements()                                                                                     // MakerGen.cs:387
                    {                                                                                                                       // MakerGen.cs:388
                        {                                                                                                                   // MakerGen.cs:226
                            // 66. SubstanceSpecification.relationship.substance[x]
                            this.Substance = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Substance",                                                                                         // MakerGen.cs:230
                                Path= "SubstanceSpecification.relationship.substance[x]",                                                   // MakerGen.cs:231
                                Id = "SubstanceSpecification.relationship.substance[x]",                                                    // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:341
                                    {                                                                                                       // MakerGen.cs:342
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:344
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/SubstanceSpecification"                                // MakerGen.cs:344
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    },                                                                                                      // MakerGen.cs:345
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 67. SubstanceSpecification.relationship.relationship
                            this.Relationship = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Relationship",                                                                                      // MakerGen.cs:230
                                Path= "SubstanceSpecification.relationship.relationship",                                                   // MakerGen.cs:231
                                Id = "SubstanceSpecification.relationship.relationship",                                                    // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 68. SubstanceSpecification.relationship.isDefining
                            this.IsDefining = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "IsDefining",                                                                                        // MakerGen.cs:230
                                Path= "SubstanceSpecification.relationship.isDefining",                                                     // MakerGen.cs:231
                                Id = "SubstanceSpecification.relationship.isDefining",                                                      // MakerGen.cs:232
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
                            // 69. SubstanceSpecification.relationship.amount[x]
                            this.Amount = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Amount",                                                                                            // MakerGen.cs:230
                                Path= "SubstanceSpecification.relationship.amount[x]",                                                      // MakerGen.cs:231
                                Id = "SubstanceSpecification.relationship.amount[x]",                                                       // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Quantity                                                              // MakerGen.cs:353
                                    {                                                                                                       // MakerGen.cs:354
                                    },                                                                                                      // MakerGen.cs:355
                                    new FhirKhit.Maker.Common.Complex.Range                                                                 // MakerGen.cs:353
                                    {                                                                                                       // MakerGen.cs:354
                                    },                                                                                                      // MakerGen.cs:355
                                    new FhirKhit.Maker.Common.Complex.Ratio                                                                 // MakerGen.cs:353
                                    {                                                                                                       // MakerGen.cs:354
                                    },                                                                                                      // MakerGen.cs:355
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 70. SubstanceSpecification.relationship.amountRatioLowLimit
                            this.AmountRatioLowLimit = new ElementDefinitionInfo                                                            // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "AmountRatioLowLimit",                                                                               // MakerGen.cs:230
                                Path= "SubstanceSpecification.relationship.amountRatioLowLimit",                                            // MakerGen.cs:231
                                Id = "SubstanceSpecification.relationship.amountRatioLowLimit",                                             // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Ratio                                                                 // MakerGen.cs:353
                                    {                                                                                                       // MakerGen.cs:354
                                    }                                                                                                       // MakerGen.cs:355
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 71. SubstanceSpecification.relationship.amountType
                            this.AmountType = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "AmountType",                                                                                        // MakerGen.cs:230
                                Path= "SubstanceSpecification.relationship.amountType",                                                     // MakerGen.cs:231
                                Id = "SubstanceSpecification.relationship.amountType",                                                      // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 72. SubstanceSpecification.relationship.source
                            this.Source = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Source",                                                                                            // MakerGen.cs:230
                                Path= "SubstanceSpecification.relationship.source",                                                         // MakerGen.cs:231
                                Id = "SubstanceSpecification.relationship.source",                                                          // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:341
                                    {                                                                                                       // MakerGen.cs:342
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:344
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/DocumentReference"                                     // MakerGen.cs:344
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:345
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        base.Write(sDef);                                                                                                   // MakerGen.cs:395
                        Substance.Write(sDef);                                                                                              // MakerGen.cs:215
                        Relationship.Write(sDef);                                                                                           // MakerGen.cs:215
                        IsDefining.Write(sDef);                                                                                             // MakerGen.cs:215
                        Amount.Write(sDef);                                                                                                 // MakerGen.cs:215
                        AmountRatioLowLimit.Write(sDef);                                                                                    // MakerGen.cs:215
                        AmountType.Write(sDef);                                                                                             // MakerGen.cs:215
                        Source.Write(sDef);                                                                                                 // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:397
                }                                                                                                                           // MakerGen.cs:399
                public Type_Relationship_Elements Elements                                                                                  // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    get                                                                                                                     // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:404
                        if (this.elements == null)                                                                                          // MakerGen.cs:405
                            this.elements = new Type_Relationship_Elements();                                                               // MakerGen.cs:406
                        return this.elements;                                                                                               // MakerGen.cs:407
                    }                                                                                                                       // MakerGen.cs:408
                }                                                                                                                           // MakerGen.cs:409
                Type_Relationship_Elements elements;                                                                                        // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                public Type_Relationship()                                                                                                  // MakerGen.cs:413
                {                                                                                                                           // MakerGen.cs:414
                }                                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:419
                {                                                                                                                           // MakerGen.cs:420
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:421
                    {                                                                                                                       // MakerGen.cs:422
                        Path = "SubstanceSpecification.relationship",                                                                       // MakerGen.cs:423
                        ElementId = "SubstanceSpecification.relationship"                                                                   // MakerGen.cs:424
                    });                                                                                                                     // MakerGen.cs:425
                    if (this.elements != null)                                                                                              // MakerGen.cs:426
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:427
                }                                                                                                                           // MakerGen.cs:428
            }                                                                                                                               // MakerGen.cs:429
            // 1. SubstanceSpecification.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:211
            // 2. SubstanceSpecification.type
            public ElementDefinitionInfo Type;                                                                                              // MakerGen.cs:211
            // 3. SubstanceSpecification.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:211
            // 4. SubstanceSpecification.domain
            public ElementDefinitionInfo Domain;                                                                                            // MakerGen.cs:211
            // 5. SubstanceSpecification.description
            public ElementDefinitionInfo Description;                                                                                       // MakerGen.cs:211
            // 6. SubstanceSpecification.source
            public ElementDefinitionInfo Source;                                                                                            // MakerGen.cs:211
            // 7. SubstanceSpecification.comment
            public ElementDefinitionInfo Comment;                                                                                           // MakerGen.cs:211
            // 8. SubstanceSpecification.moiety
            public ElementDefinitionInfo Moiety;                                                                                            // MakerGen.cs:211
            // 16. SubstanceSpecification.property
            public ElementDefinitionInfo Property;                                                                                          // MakerGen.cs:211
            // 22. SubstanceSpecification.referenceInformation
            public ElementDefinitionInfo ReferenceInformation;                                                                              // MakerGen.cs:211
            // 23. SubstanceSpecification.structure
            public ElementDefinitionInfo Structure;                                                                                         // MakerGen.cs:211
            // 43. SubstanceSpecification.code
            public ElementDefinitionInfo Code;                                                                                              // MakerGen.cs:211
            // 49. SubstanceSpecification.name
            public ElementDefinitionInfo Name;                                                                                              // MakerGen.cs:211
            // 64. SubstanceSpecification.molecularWeight
            public ElementDefinitionInfo MolecularWeight;                                                                                   // MakerGen.cs:211
            // 65. SubstanceSpecification.relationship
            public ElementDefinitionInfo Relationship;                                                                                      // MakerGen.cs:211
            // 73. SubstanceSpecification.nucleicAcid
            public ElementDefinitionInfo NucleicAcid;                                                                                       // MakerGen.cs:211
            // 74. SubstanceSpecification.polymer
            public ElementDefinitionInfo Polymer;                                                                                           // MakerGen.cs:211
            // 75. SubstanceSpecification.protein
            public ElementDefinitionInfo Protein;                                                                                           // MakerGen.cs:211
            // 76. SubstanceSpecification.sourceMaterial
            public ElementDefinitionInfo SourceMaterial;                                                                                    // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
            public SubstanceSpecification_Elements()                                                                                        // MakerGen.cs:387
            {                                                                                                                               // MakerGen.cs:388
                {                                                                                                                           // MakerGen.cs:226
                    // 1. SubstanceSpecification.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Identifier",                                                                                                // MakerGen.cs:230
                        Path= "SubstanceSpecification.identifier",                                                                          // MakerGen.cs:231
                        Id = "SubstanceSpecification.identifier",                                                                           // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 2. SubstanceSpecification.type
                    this.Type = new ElementDefinitionInfo                                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Type",                                                                                                      // MakerGen.cs:230
                        Path= "SubstanceSpecification.type",                                                                                // MakerGen.cs:231
                        Id = "SubstanceSpecification.type",                                                                                 // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 3. SubstanceSpecification.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Status",                                                                                                    // MakerGen.cs:230
                        Path= "SubstanceSpecification.status",                                                                              // MakerGen.cs:231
                        Id = "SubstanceSpecification.status",                                                                               // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 4. SubstanceSpecification.domain
                    this.Domain = new ElementDefinitionInfo                                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Domain",                                                                                                    // MakerGen.cs:230
                        Path= "SubstanceSpecification.domain",                                                                              // MakerGen.cs:231
                        Id = "SubstanceSpecification.domain",                                                                               // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 5. SubstanceSpecification.description
                    this.Description = new ElementDefinitionInfo                                                                            // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Description",                                                                                               // MakerGen.cs:230
                        Path= "SubstanceSpecification.description",                                                                         // MakerGen.cs:231
                        Id = "SubstanceSpecification.description",                                                                          // MakerGen.cs:232
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
                    // 6. SubstanceSpecification.source
                    this.Source = new ElementDefinitionInfo                                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Source",                                                                                                    // MakerGen.cs:230
                        Path= "SubstanceSpecification.source",                                                                              // MakerGen.cs:231
                        Id = "SubstanceSpecification.source",                                                                               // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/DocumentReference"                                             // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 7. SubstanceSpecification.comment
                    this.Comment = new ElementDefinitionInfo                                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Comment",                                                                                                   // MakerGen.cs:230
                        Path= "SubstanceSpecification.comment",                                                                             // MakerGen.cs:231
                        Id = "SubstanceSpecification.comment",                                                                              // MakerGen.cs:232
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
                    // 8. SubstanceSpecification.moiety
                    this.Moiety = new ElementDefinitionInfo                                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Moiety",                                                                                                    // MakerGen.cs:230
                        Path= "SubstanceSpecification.moiety",                                                                              // MakerGen.cs:231
                        Id = "SubstanceSpecification.moiety",                                                                               // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Moiety                                                                                                 // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 16. SubstanceSpecification.property
                    this.Property = new ElementDefinitionInfo                                                                               // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Property",                                                                                                  // MakerGen.cs:230
                        Path= "SubstanceSpecification.property",                                                                            // MakerGen.cs:231
                        Id = "SubstanceSpecification.property",                                                                             // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Property                                                                                               // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 22. SubstanceSpecification.referenceInformation
                    this.ReferenceInformation = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "ReferenceInformation",                                                                                      // MakerGen.cs:230
                        Path= "SubstanceSpecification.referenceInformation",                                                                // MakerGen.cs:231
                        Id = "SubstanceSpecification.referenceInformation",                                                                 // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/SubstanceReferenceInformation"                                 // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 23. SubstanceSpecification.structure
                    this.Structure = new ElementDefinitionInfo                                                                              // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Structure",                                                                                                 // MakerGen.cs:230
                        Path= "SubstanceSpecification.structure",                                                                           // MakerGen.cs:231
                        Id = "SubstanceSpecification.structure",                                                                            // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Structure                                                                                              // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 43. SubstanceSpecification.code
                    this.Code = new ElementDefinitionInfo                                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Code",                                                                                                      // MakerGen.cs:230
                        Path= "SubstanceSpecification.code",                                                                                // MakerGen.cs:231
                        Id = "SubstanceSpecification.code",                                                                                 // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Code                                                                                                   // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 49. SubstanceSpecification.name
                    this.Name = new ElementDefinitionInfo                                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Name",                                                                                                      // MakerGen.cs:230
                        Path= "SubstanceSpecification.name",                                                                                // MakerGen.cs:231
                        Id = "SubstanceSpecification.name",                                                                                 // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Name                                                                                                   // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 64. SubstanceSpecification.molecularWeight
                    this.MolecularWeight = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "MolecularWeight",                                                                                           // MakerGen.cs:230
                        Path= "SubstanceSpecification.molecularWeight",                                                                     // MakerGen.cs:231
                        Id = "SubstanceSpecification.molecularWeight",                                                                      // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 65. SubstanceSpecification.relationship
                    this.Relationship = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Relationship",                                                                                              // MakerGen.cs:230
                        Path= "SubstanceSpecification.relationship",                                                                        // MakerGen.cs:231
                        Id = "SubstanceSpecification.relationship",                                                                         // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Relationship                                                                                           // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 73. SubstanceSpecification.nucleicAcid
                    this.NucleicAcid = new ElementDefinitionInfo                                                                            // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "NucleicAcid",                                                                                               // MakerGen.cs:230
                        Path= "SubstanceSpecification.nucleicAcid",                                                                         // MakerGen.cs:231
                        Id = "SubstanceSpecification.nucleicAcid",                                                                          // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/SubstanceNucleicAcid"                                          // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 74. SubstanceSpecification.polymer
                    this.Polymer = new ElementDefinitionInfo                                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Polymer",                                                                                                   // MakerGen.cs:230
                        Path= "SubstanceSpecification.polymer",                                                                             // MakerGen.cs:231
                        Id = "SubstanceSpecification.polymer",                                                                              // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/SubstancePolymer"                                              // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 75. SubstanceSpecification.protein
                    this.Protein = new ElementDefinitionInfo                                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Protein",                                                                                                   // MakerGen.cs:230
                        Path= "SubstanceSpecification.protein",                                                                             // MakerGen.cs:231
                        Id = "SubstanceSpecification.protein",                                                                              // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/SubstanceProtein"                                              // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 76. SubstanceSpecification.sourceMaterial
                    this.SourceMaterial = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "SourceMaterial",                                                                                            // MakerGen.cs:230
                        Path= "SubstanceSpecification.sourceMaterial",                                                                      // MakerGen.cs:231
                        Id = "SubstanceSpecification.sourceMaterial",                                                                       // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/SubstanceSourceMaterial"                                       // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                base.Write(sDef);                                                                                                           // MakerGen.cs:395
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:215
                Type.Write(sDef);                                                                                                           // MakerGen.cs:215
                Status.Write(sDef);                                                                                                         // MakerGen.cs:215
                Domain.Write(sDef);                                                                                                         // MakerGen.cs:215
                Description.Write(sDef);                                                                                                    // MakerGen.cs:215
                Source.Write(sDef);                                                                                                         // MakerGen.cs:215
                Comment.Write(sDef);                                                                                                        // MakerGen.cs:215
                Moiety.Write(sDef);                                                                                                         // MakerGen.cs:215
                Property.Write(sDef);                                                                                                       // MakerGen.cs:215
                ReferenceInformation.Write(sDef);                                                                                           // MakerGen.cs:215
                Structure.Write(sDef);                                                                                                      // MakerGen.cs:215
                Code.Write(sDef);                                                                                                           // MakerGen.cs:215
                Name.Write(sDef);                                                                                                           // MakerGen.cs:215
                MolecularWeight.Write(sDef);                                                                                                // MakerGen.cs:215
                Relationship.Write(sDef);                                                                                                   // MakerGen.cs:215
                NucleicAcid.Write(sDef);                                                                                                    // MakerGen.cs:215
                Polymer.Write(sDef);                                                                                                        // MakerGen.cs:215
                Protein.Write(sDef);                                                                                                        // MakerGen.cs:215
                SourceMaterial.Write(sDef);                                                                                                 // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:397
        }                                                                                                                                   // MakerGen.cs:399
        public SubstanceSpecification_Elements Elements                                                                                     // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            get                                                                                                                             // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:404
                if (this.elements == null)                                                                                                  // MakerGen.cs:405
                    this.elements = new SubstanceSpecification_Elements();                                                                  // MakerGen.cs:406
                return this.elements;                                                                                                       // MakerGen.cs:407
            }                                                                                                                               // MakerGen.cs:408
        }                                                                                                                                   // MakerGen.cs:409
        SubstanceSpecification_Elements elements;                                                                                           // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
        public SubstanceSpecification()                                                                                                     // MakerGen.cs:413
        {                                                                                                                                   // MakerGen.cs:414
            this.Name = "SubstanceSpecification";                                                                                           // MakerGen.cs:487
            this.Uri = "http://hl7.org/fhir/StructureDefinition/SubstanceSpecification";                                                    // MakerGen.cs:488
        }                                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:419
        {                                                                                                                                   // MakerGen.cs:420
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:421
            {                                                                                                                               // MakerGen.cs:422
                Path = "SubstanceSpecification",                                                                                            // MakerGen.cs:423
                ElementId = "SubstanceSpecification"                                                                                        // MakerGen.cs:424
            });                                                                                                                             // MakerGen.cs:425
            if (this.elements != null)                                                                                                      // MakerGen.cs:426
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:427
        }                                                                                                                                   // MakerGen.cs:428
    }                                                                                                                                       // MakerGen.cs:429
}                                                                                                                                           // MakerGen.cs:474
