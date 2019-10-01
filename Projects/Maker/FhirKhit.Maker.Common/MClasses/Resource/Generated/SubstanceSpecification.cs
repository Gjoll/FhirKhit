using System;                                                                                                                               // MakerGen.cs:391
using System.Diagnostics;                                                                                                                   // MakerGen.cs:392
using System.IO;                                                                                                                            // MakerGen.cs:393
using System.Linq;                                                                                                                          // MakerGen.cs:394
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:396
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:397
{                                                                                                                                           // MakerGen.cs:398
    #region Json                                                                                                                            // MakerGen.cs:399
    #if NEVER                                                                                                                               // MakerGen.cs:400
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
    #endregion                                                                                                                              // MakerGen.cs:403
    /// <summary>
    /// Fhir resource 'SubstanceSpecification'
    /// </summary>
    // 0. SubstanceSpecification
    public class SubstanceSpecification : FhirKhit.Maker.Common.Resource.ResourceBase                                                       // MakerGen.cs:352
    {                                                                                                                                       // MakerGen.cs:353
        // 8. SubstanceSpecification.moiety
        public class Type_Moiety : FhirKhit.Maker.Common.Complex.ComplexBase                                                                // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 9. SubstanceSpecification.moiety.role
            public MakerElementInstance Element_Role;                                                                                       // MakerGen.cs:232
            // 10. SubstanceSpecification.moiety.identifier
            public MakerElementInstance Element_Identifier;                                                                                 // MakerGen.cs:232
            // 11. SubstanceSpecification.moiety.name
            public MakerElementInstance Element_Name;                                                                                       // MakerGen.cs:232
            // 12. SubstanceSpecification.moiety.stereochemistry
            public MakerElementInstance Element_Stereochemistry;                                                                            // MakerGen.cs:232
            // 13. SubstanceSpecification.moiety.opticalActivity
            public MakerElementInstance Element_OpticalActivity;                                                                            // MakerGen.cs:232
            // 14. SubstanceSpecification.moiety.molecularFormula
            public MakerElementInstance Element_MolecularFormula;                                                                           // MakerGen.cs:232
            // 15. SubstanceSpecification.moiety.amount[x]
            public MakerElementInstance Element_Amount;                                                                                     // MakerGen.cs:232
            public Type_Moiety()                                                                                                            // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 9. SubstanceSpecification.moiety.role
                    this.Element_Role = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Role",                                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 10. SubstanceSpecification.moiety.identifier
                    this.Element_Identifier = new MakerElementInstance                                                                      // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Identifier",                                                                                        // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 11. SubstanceSpecification.moiety.name
                    this.Element_Name = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Name",                                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String()                                                                    // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 12. SubstanceSpecification.moiety.stereochemistry
                    this.Element_Stereochemistry = new MakerElementInstance                                                                 // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Stereochemistry",                                                                                   // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 13. SubstanceSpecification.moiety.opticalActivity
                    this.Element_OpticalActivity = new MakerElementInstance                                                                 // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_OpticalActivity",                                                                                   // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 14. SubstanceSpecification.moiety.molecularFormula
                    this.Element_MolecularFormula = new MakerElementInstance                                                                // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_MolecularFormula",                                                                                  // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String()                                                                    // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 15. SubstanceSpecification.moiety.amount[x]
                    this.Element_Amount = new MakerElementInstance                                                                          // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Amount",                                                                                            // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String()                                                                    // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 16. SubstanceSpecification.property
        public class Type_Property : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 17. SubstanceSpecification.property.category
            public MakerElementInstance Element_Category;                                                                                   // MakerGen.cs:232
            // 18. SubstanceSpecification.property.code
            public MakerElementInstance Element_Code;                                                                                       // MakerGen.cs:232
            // 19. SubstanceSpecification.property.parameters
            public MakerElementInstance Element_Parameters;                                                                                 // MakerGen.cs:232
            // 20. SubstanceSpecification.property.definingSubstance[x]
            public MakerElementInstance Element_DefiningSubstance;                                                                          // MakerGen.cs:232
            // 21. SubstanceSpecification.property.amount[x]
            public MakerElementInstance Element_Amount;                                                                                     // MakerGen.cs:232
            public Type_Property()                                                                                                          // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 17. SubstanceSpecification.property.category
                    this.Element_Category = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Category",                                                                                          // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 18. SubstanceSpecification.property.code
                    this.Element_Code = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Code",                                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 19. SubstanceSpecification.property.parameters
                    this.Element_Parameters = new MakerElementInstance                                                                      // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Parameters",                                                                                        // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String()                                                                    // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 20. SubstanceSpecification.property.definingSubstance[x]
                    this.Element_DefiningSubstance = new MakerElementInstance                                                               // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_DefiningSubstance",                                                                                 // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 21. SubstanceSpecification.property.amount[x]
                    this.Element_Amount = new MakerElementInstance                                                                          // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Amount",                                                                                            // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String()                                                                    // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 23. SubstanceSpecification.structure
        public class Type_Structure : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 28. SubstanceSpecification.structure.isotope
            public class Type_Isotope : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:352
            {                                                                                                                               // MakerGen.cs:353
                // 33. SubstanceSpecification.structure.isotope.molecularWeight
                public class Type_MolecularWeight : FhirKhit.Maker.Common.Complex.ComplexBase                                               // MakerGen.cs:352
                {                                                                                                                           // MakerGen.cs:353
                    // 34. SubstanceSpecification.structure.isotope.molecularWeight.method
                    public MakerElementInstance Element_Method;                                                                             // MakerGen.cs:232
                    // 35. SubstanceSpecification.structure.isotope.molecularWeight.type
                    public MakerElementInstance Element_Type;                                                                               // MakerGen.cs:232
                    // 36. SubstanceSpecification.structure.isotope.molecularWeight.amount
                    public MakerElementInstance Element_Amount;                                                                             // MakerGen.cs:232
                    public Type_MolecularWeight()                                                                                           // MakerGen.cs:361
                    {                                                                                                                       // MakerGen.cs:362
                        {                                                                                                                   // MakerGen.cs:243
                            // 34. SubstanceSpecification.structure.isotope.molecularWeight.method
                            this.Element_Method = new MakerElementInstance                                                                  // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Method",                                                                                    // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                     // MakerGen.cs:292
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 35. SubstanceSpecification.structure.isotope.molecularWeight.type
                            this.Element_Type = new MakerElementInstance                                                                    // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Type",                                                                                      // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                     // MakerGen.cs:292
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 36. SubstanceSpecification.structure.isotope.molecularWeight.amount
                            this.Element_Amount = new MakerElementInstance                                                                  // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Amount",                                                                                    // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                    }                                                                                                                       // MakerGen.cs:373
                }                                                                                                                           // MakerGen.cs:357
                // 29. SubstanceSpecification.structure.isotope.identifier
                public MakerElementInstance Element_Identifier;                                                                             // MakerGen.cs:232
                // 30. SubstanceSpecification.structure.isotope.name
                public MakerElementInstance Element_Name;                                                                                   // MakerGen.cs:232
                // 31. SubstanceSpecification.structure.isotope.substitution
                public MakerElementInstance Element_Substitution;                                                                           // MakerGen.cs:232
                // 32. SubstanceSpecification.structure.isotope.halfLife
                public MakerElementInstance Element_HalfLife;                                                                               // MakerGen.cs:232
                public Type_Isotope()                                                                                                       // MakerGen.cs:361
                {                                                                                                                           // MakerGen.cs:362
                    {                                                                                                                       // MakerGen.cs:243
                        // 29. SubstanceSpecification.structure.isotope.identifier
                        this.Element_Identifier = new MakerElementInstance                                                                  // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Identifier",                                                                                    // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 30. SubstanceSpecification.structure.isotope.name
                        this.Element_Name = new MakerElementInstance                                                                        // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Name",                                                                                          // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                         // MakerGen.cs:292
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 31. SubstanceSpecification.structure.isotope.substitution
                        this.Element_Substitution = new MakerElementInstance                                                                // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Substitution",                                                                                  // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                         // MakerGen.cs:292
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 32. SubstanceSpecification.structure.isotope.halfLife
                        this.Element_HalfLife = new MakerElementInstance                                                                    // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_HalfLife",                                                                                      // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                }                                                                                                                           // MakerGen.cs:373
            }                                                                                                                               // MakerGen.cs:357
            // 39. SubstanceSpecification.structure.representation
            public class Type_Representation : FhirKhit.Maker.Common.Complex.ComplexBase                                                    // MakerGen.cs:352
            {                                                                                                                               // MakerGen.cs:353
                // 40. SubstanceSpecification.structure.representation.type
                public MakerElementInstance Element_Type;                                                                                   // MakerGen.cs:232
                // 41. SubstanceSpecification.structure.representation.representation
                public MakerElementInstance Element_Representation;                                                                         // MakerGen.cs:232
                // 42. SubstanceSpecification.structure.representation.attachment
                public MakerElementInstance Element_Attachment;                                                                             // MakerGen.cs:232
                public Type_Representation()                                                                                                // MakerGen.cs:361
                {                                                                                                                           // MakerGen.cs:362
                    {                                                                                                                       // MakerGen.cs:243
                        // 40. SubstanceSpecification.structure.representation.type
                        this.Element_Type = new MakerElementInstance                                                                        // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Type",                                                                                          // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                         // MakerGen.cs:292
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 41. SubstanceSpecification.structure.representation.representation
                        this.Element_Representation = new MakerElementInstance                                                              // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Representation",                                                                                // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.String()                                                                // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 42. SubstanceSpecification.structure.representation.attachment
                        this.Element_Attachment = new MakerElementInstance                                                                  // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Attachment",                                                                                    // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                }                                                                                                                           // MakerGen.cs:373
            }                                                                                                                               // MakerGen.cs:357
            // 24. SubstanceSpecification.structure.stereochemistry
            public MakerElementInstance Element_Stereochemistry;                                                                            // MakerGen.cs:232
            // 25. SubstanceSpecification.structure.opticalActivity
            public MakerElementInstance Element_OpticalActivity;                                                                            // MakerGen.cs:232
            // 26. SubstanceSpecification.structure.molecularFormula
            public MakerElementInstance Element_MolecularFormula;                                                                           // MakerGen.cs:232
            // 27. SubstanceSpecification.structure.molecularFormulaByMoiety
            public MakerElementInstance Element_MolecularFormulaByMoiety;                                                                   // MakerGen.cs:232
            // 37. SubstanceSpecification.structure.molecularWeight
            public MakerElementInstance Element_MolecularWeight;                                                                            // MakerGen.cs:232
            // 38. SubstanceSpecification.structure.source
            public MakerElementInstance Element_Source;                                                                                     // MakerGen.cs:232
            public Type_Structure()                                                                                                         // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 24. SubstanceSpecification.structure.stereochemistry
                    this.Element_Stereochemistry = new MakerElementInstance                                                                 // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Stereochemistry",                                                                                   // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 25. SubstanceSpecification.structure.opticalActivity
                    this.Element_OpticalActivity = new MakerElementInstance                                                                 // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_OpticalActivity",                                                                                   // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 26. SubstanceSpecification.structure.molecularFormula
                    this.Element_MolecularFormula = new MakerElementInstance                                                                // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_MolecularFormula",                                                                                  // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String()                                                                    // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 27. SubstanceSpecification.structure.molecularFormulaByMoiety
                    this.Element_MolecularFormulaByMoiety = new MakerElementInstance                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_MolecularFormulaByMoiety",                                                                          // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String()                                                                    // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 37. SubstanceSpecification.structure.molecularWeight
                    this.Element_MolecularWeight = new MakerElementInstance                                                                 // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_MolecularWeight",                                                                                   // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 38. SubstanceSpecification.structure.source
                    this.Element_Source = new MakerElementInstance                                                                          // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Source",                                                                                            // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 43. SubstanceSpecification.code
        public class Type_Code : FhirKhit.Maker.Common.Complex.ComplexBase                                                                  // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 44. SubstanceSpecification.code.code
            public MakerElementInstance Element_Code;                                                                                       // MakerGen.cs:232
            // 45. SubstanceSpecification.code.status
            public MakerElementInstance Element_Status;                                                                                     // MakerGen.cs:232
            // 46. SubstanceSpecification.code.statusDate
            public MakerElementInstance Element_StatusDate;                                                                                 // MakerGen.cs:232
            // 47. SubstanceSpecification.code.comment
            public MakerElementInstance Element_Comment;                                                                                    // MakerGen.cs:232
            // 48. SubstanceSpecification.code.source
            public MakerElementInstance Element_Source;                                                                                     // MakerGen.cs:232
            public Type_Code()                                                                                                              // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 44. SubstanceSpecification.code.code
                    this.Element_Code = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Code",                                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 45. SubstanceSpecification.code.status
                    this.Element_Status = new MakerElementInstance                                                                          // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Status",                                                                                            // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 46. SubstanceSpecification.code.statusDate
                    this.Element_StatusDate = new MakerElementInstance                                                                      // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_StatusDate",                                                                                        // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.DateTime()                                                                  // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 47. SubstanceSpecification.code.comment
                    this.Element_Comment = new MakerElementInstance                                                                         // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Comment",                                                                                           // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String()                                                                    // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 48. SubstanceSpecification.code.source
                    this.Element_Source = new MakerElementInstance                                                                          // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Source",                                                                                            // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 49. SubstanceSpecification.name
        public class Type_Name : FhirKhit.Maker.Common.Complex.ComplexBase                                                                  // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 59. SubstanceSpecification.name.official
            public class Type_Official : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:352
            {                                                                                                                               // MakerGen.cs:353
                // 60. SubstanceSpecification.name.official.authority
                public MakerElementInstance Element_Authority;                                                                              // MakerGen.cs:232
                // 61. SubstanceSpecification.name.official.status
                public MakerElementInstance Element_Status;                                                                                 // MakerGen.cs:232
                // 62. SubstanceSpecification.name.official.date
                public MakerElementInstance Element_Date;                                                                                   // MakerGen.cs:232
                public Type_Official()                                                                                                      // MakerGen.cs:361
                {                                                                                                                           // MakerGen.cs:362
                    {                                                                                                                       // MakerGen.cs:243
                        // 60. SubstanceSpecification.name.official.authority
                        this.Element_Authority = new MakerElementInstance                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Authority",                                                                                     // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                         // MakerGen.cs:292
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 61. SubstanceSpecification.name.official.status
                        this.Element_Status = new MakerElementInstance                                                                      // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Status",                                                                                        // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                         // MakerGen.cs:292
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 62. SubstanceSpecification.name.official.date
                        this.Element_Date = new MakerElementInstance                                                                        // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Date",                                                                                          // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.DateTime()                                                              // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                }                                                                                                                           // MakerGen.cs:373
            }                                                                                                                               // MakerGen.cs:357
            // 50. SubstanceSpecification.name.name
            public MakerElementInstance Element_Name;                                                                                       // MakerGen.cs:232
            // 51. SubstanceSpecification.name.type
            public MakerElementInstance Element_Type;                                                                                       // MakerGen.cs:232
            // 52. SubstanceSpecification.name.status
            public MakerElementInstance Element_Status;                                                                                     // MakerGen.cs:232
            // 53. SubstanceSpecification.name.preferred
            public MakerElementInstance Element_Preferred;                                                                                  // MakerGen.cs:232
            // 54. SubstanceSpecification.name.language
            public MakerElementInstance Element_Language;                                                                                   // MakerGen.cs:232
            // 55. SubstanceSpecification.name.domain
            public MakerElementInstance Element_Domain;                                                                                     // MakerGen.cs:232
            // 56. SubstanceSpecification.name.jurisdiction
            public MakerElementInstance Element_Jurisdiction;                                                                               // MakerGen.cs:232
            // 57. SubstanceSpecification.name.synonym
            public MakerElementInstance Element_Synonym;                                                                                    // MakerGen.cs:232
            // 58. SubstanceSpecification.name.translation
            public MakerElementInstance Element_Translation;                                                                                // MakerGen.cs:232
            // 63. SubstanceSpecification.name.source
            public MakerElementInstance Element_Source;                                                                                     // MakerGen.cs:232
            public Type_Name()                                                                                                              // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 50. SubstanceSpecification.name.name
                    this.Element_Name = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Name",                                                                                              // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String()                                                                    // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 51. SubstanceSpecification.name.type
                    this.Element_Type = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Type",                                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 52. SubstanceSpecification.name.status
                    this.Element_Status = new MakerElementInstance                                                                          // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Status",                                                                                            // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 53. SubstanceSpecification.name.preferred
                    this.Element_Preferred = new MakerElementInstance                                                                       // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Preferred",                                                                                         // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Boolean()                                                                   // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 54. SubstanceSpecification.name.language
                    this.Element_Language = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Language",                                                                                          // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 55. SubstanceSpecification.name.domain
                    this.Element_Domain = new MakerElementInstance                                                                          // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Domain",                                                                                            // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 56. SubstanceSpecification.name.jurisdiction
                    this.Element_Jurisdiction = new MakerElementInstance                                                                    // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Jurisdiction",                                                                                      // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 57. SubstanceSpecification.name.synonym
                    this.Element_Synonym = new MakerElementInstance                                                                         // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Synonym",                                                                                           // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 58. SubstanceSpecification.name.translation
                    this.Element_Translation = new MakerElementInstance                                                                     // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Translation",                                                                                       // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 63. SubstanceSpecification.name.source
                    this.Element_Source = new MakerElementInstance                                                                          // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Source",                                                                                            // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 65. SubstanceSpecification.relationship
        public class Type_Relationship : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 66. SubstanceSpecification.relationship.substance[x]
            public MakerElementInstance Element_Substance;                                                                                  // MakerGen.cs:232
            // 67. SubstanceSpecification.relationship.relationship
            public MakerElementInstance Element_Relationship;                                                                               // MakerGen.cs:232
            // 68. SubstanceSpecification.relationship.isDefining
            public MakerElementInstance Element_IsDefining;                                                                                 // MakerGen.cs:232
            // 69. SubstanceSpecification.relationship.amount[x]
            public MakerElementInstance Element_Amount;                                                                                     // MakerGen.cs:232
            // 70. SubstanceSpecification.relationship.amountRatioLowLimit
            public MakerElementInstance Element_AmountRatioLowLimit;                                                                        // MakerGen.cs:232
            // 71. SubstanceSpecification.relationship.amountType
            public MakerElementInstance Element_AmountType;                                                                                 // MakerGen.cs:232
            // 72. SubstanceSpecification.relationship.source
            public MakerElementInstance Element_Source;                                                                                     // MakerGen.cs:232
            public Type_Relationship()                                                                                                      // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 66. SubstanceSpecification.relationship.substance[x]
                    this.Element_Substance = new MakerElementInstance                                                                       // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Substance",                                                                                         // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 67. SubstanceSpecification.relationship.relationship
                    this.Element_Relationship = new MakerElementInstance                                                                    // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Relationship",                                                                                      // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 68. SubstanceSpecification.relationship.isDefining
                    this.Element_IsDefining = new MakerElementInstance                                                                      // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_IsDefining",                                                                                        // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Boolean()                                                                   // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 69. SubstanceSpecification.relationship.amount[x]
                    this.Element_Amount = new MakerElementInstance                                                                          // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Amount",                                                                                            // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String()                                                                    // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 70. SubstanceSpecification.relationship.amountRatioLowLimit
                    this.Element_AmountRatioLowLimit = new MakerElementInstance                                                             // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_AmountRatioLowLimit",                                                                               // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 71. SubstanceSpecification.relationship.amountType
                    this.Element_AmountType = new MakerElementInstance                                                                      // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_AmountType",                                                                                        // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 72. SubstanceSpecification.relationship.source
                    this.Element_Source = new MakerElementInstance                                                                          // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Source",                                                                                            // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 1. SubstanceSpecification.identifier
        public MakerElementInstance Element_Identifier;                                                                                     // MakerGen.cs:232
        // 2. SubstanceSpecification.type
        public MakerElementInstance Element_Type;                                                                                           // MakerGen.cs:232
        // 3. SubstanceSpecification.status
        public MakerElementInstance Element_Status;                                                                                         // MakerGen.cs:232
        // 4. SubstanceSpecification.domain
        public MakerElementInstance Element_Domain;                                                                                         // MakerGen.cs:232
        // 5. SubstanceSpecification.description
        public MakerElementInstance Element_Description;                                                                                    // MakerGen.cs:232
        // 6. SubstanceSpecification.source
        public MakerElementInstance Element_Source;                                                                                         // MakerGen.cs:232
        // 7. SubstanceSpecification.comment
        public MakerElementInstance Element_Comment;                                                                                        // MakerGen.cs:232
        // 22. SubstanceSpecification.referenceInformation
        public MakerElementInstance Element_ReferenceInformation;                                                                           // MakerGen.cs:232
        // 64. SubstanceSpecification.molecularWeight
        public MakerElementInstance Element_MolecularWeight;                                                                                // MakerGen.cs:232
        // 73. SubstanceSpecification.nucleicAcid
        public MakerElementInstance Element_NucleicAcid;                                                                                    // MakerGen.cs:232
        // 74. SubstanceSpecification.polymer
        public MakerElementInstance Element_Polymer;                                                                                        // MakerGen.cs:232
        // 75. SubstanceSpecification.protein
        public MakerElementInstance Element_Protein;                                                                                        // MakerGen.cs:232
        // 76. SubstanceSpecification.sourceMaterial
        public MakerElementInstance Element_SourceMaterial;                                                                                 // MakerGen.cs:232
        public SubstanceSpecification()                                                                                                     // MakerGen.cs:361
        {                                                                                                                                   // MakerGen.cs:362
            {                                                                                                                               // MakerGen.cs:243
                // 1. SubstanceSpecification.identifier
                this.Element_Identifier = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 2. SubstanceSpecification.type
                this.Element_Type = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Type",                                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 3. SubstanceSpecification.status
                this.Element_Status = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Status",                                                                                                // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 4. SubstanceSpecification.domain
                this.Element_Domain = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Domain",                                                                                                // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 5. SubstanceSpecification.description
                this.Element_Description = new MakerElementInstance                                                                         // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Description",                                                                                           // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String()                                                                        // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 6. SubstanceSpecification.source
                this.Element_Source = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Source",                                                                                                // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 7. SubstanceSpecification.comment
                this.Element_Comment = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Comment",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String()                                                                        // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 22. SubstanceSpecification.referenceInformation
                this.Element_ReferenceInformation = new MakerElementInstance                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ReferenceInformation",                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 64. SubstanceSpecification.molecularWeight
                this.Element_MolecularWeight = new MakerElementInstance                                                                     // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_MolecularWeight",                                                                                       // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 73. SubstanceSpecification.nucleicAcid
                this.Element_NucleicAcid = new MakerElementInstance                                                                         // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_NucleicAcid",                                                                                           // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 74. SubstanceSpecification.polymer
                this.Element_Polymer = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Polymer",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 75. SubstanceSpecification.protein
                this.Element_Protein = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Protein",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 76. SubstanceSpecification.sourceMaterial
                this.Element_SourceMaterial = new MakerElementInstance                                                                      // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_SourceMaterial",                                                                                        // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
        }                                                                                                                                   // MakerGen.cs:373
    }                                                                                                                                       // MakerGen.cs:357
}                                                                                                                                           // MakerGen.cs:408
