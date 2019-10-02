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
    #endregion
    /// <summary>
    /// Fhir resource 'SubstanceSpecification'
    /// </summary>
    // 0. SubstanceSpecification
    public class Resource_SubstanceSpecification : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 8. SubstanceSpecification.moiety
        public class Type_Moiety : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 9. SubstanceSpecification.moiety.role
            public ElementDefinitionInfo Element_Role;
            // 10. SubstanceSpecification.moiety.identifier
            public ElementDefinitionInfo Element_Identifier;
            // 11. SubstanceSpecification.moiety.name
            public ElementDefinitionInfo Element_Name;
            // 12. SubstanceSpecification.moiety.stereochemistry
            public ElementDefinitionInfo Element_Stereochemistry;
            // 13. SubstanceSpecification.moiety.opticalActivity
            public ElementDefinitionInfo Element_OpticalActivity;
            // 14. SubstanceSpecification.moiety.molecularFormula
            public ElementDefinitionInfo Element_MolecularFormula;
            // 15. SubstanceSpecification.moiety.amount[x]
            public ElementDefinitionInfo Element_Amount;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "SubstanceSpecification.moiety",
                    ElementId = "SubstanceSpecification.moiety"
                });
                Element_Role.Write(sDef);
                Element_Identifier.Write(sDef);
                Element_Name.Write(sDef);
                Element_Stereochemistry.Write(sDef);
                Element_OpticalActivity.Write(sDef);
                Element_MolecularFormula.Write(sDef);
                Element_Amount.Write(sDef);
            }
            
            public Type_Moiety()
            {
                {
                    // 9. SubstanceSpecification.moiety.role
                    this.Element_Role = new ElementDefinitionInfo
                    {
                        Name = "Element_Role",
                        Path= "SubstanceSpecification.moiety.role",
                        Id = "SubstanceSpecification.moiety.role",
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
                    // 10. SubstanceSpecification.moiety.identifier
                    this.Element_Identifier = new ElementDefinitionInfo
                    {
                        Name = "Element_Identifier",
                        Path= "SubstanceSpecification.moiety.identifier",
                        Id = "SubstanceSpecification.moiety.identifier",
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
                    // 11. SubstanceSpecification.moiety.name
                    this.Element_Name = new ElementDefinitionInfo
                    {
                        Name = "Element_Name",
                        Path= "SubstanceSpecification.moiety.name",
                        Id = "SubstanceSpecification.moiety.name",
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
                    // 12. SubstanceSpecification.moiety.stereochemistry
                    this.Element_Stereochemistry = new ElementDefinitionInfo
                    {
                        Name = "Element_Stereochemistry",
                        Path= "SubstanceSpecification.moiety.stereochemistry",
                        Id = "SubstanceSpecification.moiety.stereochemistry",
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
                    // 13. SubstanceSpecification.moiety.opticalActivity
                    this.Element_OpticalActivity = new ElementDefinitionInfo
                    {
                        Name = "Element_OpticalActivity",
                        Path= "SubstanceSpecification.moiety.opticalActivity",
                        Id = "SubstanceSpecification.moiety.opticalActivity",
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
                    // 14. SubstanceSpecification.moiety.molecularFormula
                    this.Element_MolecularFormula = new ElementDefinitionInfo
                    {
                        Name = "Element_MolecularFormula",
                        Path= "SubstanceSpecification.moiety.molecularFormula",
                        Id = "SubstanceSpecification.moiety.molecularFormula",
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
                    // 15. SubstanceSpecification.moiety.amount[x]
                    this.Element_Amount = new ElementDefinitionInfo
                    {
                        Name = "Element_Amount",
                        Path= "SubstanceSpecification.moiety.amount[x]",
                        Id = "SubstanceSpecification.moiety.amount[x]",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Quantity
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_String
                            {
                            }
                        }
                    };
                }
            }
        }
        // 16. SubstanceSpecification.property
        public class Type_Property : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 17. SubstanceSpecification.property.category
            public ElementDefinitionInfo Element_Category;
            // 18. SubstanceSpecification.property.code
            public ElementDefinitionInfo Element_Code;
            // 19. SubstanceSpecification.property.parameters
            public ElementDefinitionInfo Element_Parameters;
            // 20. SubstanceSpecification.property.definingSubstance[x]
            public ElementDefinitionInfo Element_DefiningSubstance;
            // 21. SubstanceSpecification.property.amount[x]
            public ElementDefinitionInfo Element_Amount;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "SubstanceSpecification.property",
                    ElementId = "SubstanceSpecification.property"
                });
                Element_Category.Write(sDef);
                Element_Code.Write(sDef);
                Element_Parameters.Write(sDef);
                Element_DefiningSubstance.Write(sDef);
                Element_Amount.Write(sDef);
            }
            
            public Type_Property()
            {
                {
                    // 17. SubstanceSpecification.property.category
                    this.Element_Category = new ElementDefinitionInfo
                    {
                        Name = "Element_Category",
                        Path= "SubstanceSpecification.property.category",
                        Id = "SubstanceSpecification.property.category",
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
                    // 18. SubstanceSpecification.property.code
                    this.Element_Code = new ElementDefinitionInfo
                    {
                        Name = "Element_Code",
                        Path= "SubstanceSpecification.property.code",
                        Id = "SubstanceSpecification.property.code",
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
                    // 19. SubstanceSpecification.property.parameters
                    this.Element_Parameters = new ElementDefinitionInfo
                    {
                        Name = "Element_Parameters",
                        Path= "SubstanceSpecification.property.parameters",
                        Id = "SubstanceSpecification.property.parameters",
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
                    // 20. SubstanceSpecification.property.definingSubstance[x]
                    this.Element_DefiningSubstance = new ElementDefinitionInfo
                    {
                        Name = "Element_DefiningSubstance",
                        Path= "SubstanceSpecification.property.definingSubstance[x]",
                        Id = "SubstanceSpecification.property.definingSubstance[x]",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/SubstanceSpecification",
                                    "http://hl7.org/fhir/StructureDefinition/Substance"
                                }
                            },
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                            {
                            }
                        }
                    };
                }
                {
                    // 21. SubstanceSpecification.property.amount[x]
                    this.Element_Amount = new ElementDefinitionInfo
                    {
                        Name = "Element_Amount",
                        Path= "SubstanceSpecification.property.amount[x]",
                        Id = "SubstanceSpecification.property.amount[x]",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Quantity
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_String
                            {
                            }
                        }
                    };
                }
            }
        }
        // 23. SubstanceSpecification.structure
        public class Type_Structure : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 28. SubstanceSpecification.structure.isotope
            public class Type_Isotope : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 33. SubstanceSpecification.structure.isotope.molecularWeight
                public class Type_MolecularWeight : FhirKhit.Maker.Common.Complex.ComplexBase
                {
                    // 34. SubstanceSpecification.structure.isotope.molecularWeight.method
                    public ElementDefinitionInfo Element_Method;
                    // 35. SubstanceSpecification.structure.isotope.molecularWeight.type
                    public ElementDefinitionInfo Element_Type;
                    // 36. SubstanceSpecification.structure.isotope.molecularWeight.amount
                    public ElementDefinitionInfo Element_Amount;
                    
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                    {
                        base.Write(sDef);
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                        {
                            Path = "SubstanceSpecification.structure.isotope.molecularWeight",
                            ElementId = "SubstanceSpecification.structure.isotope.molecularWeight"
                        });
                        Element_Method.Write(sDef);
                        Element_Type.Write(sDef);
                        Element_Amount.Write(sDef);
                    }
                    
                    public Type_MolecularWeight()
                    {
                        {
                            // 34. SubstanceSpecification.structure.isotope.molecularWeight.method
                            this.Element_Method = new ElementDefinitionInfo
                            {
                                Name = "Element_Method",
                                Path= "SubstanceSpecification.structure.isotope.molecularWeight.method",
                                Id = "SubstanceSpecification.structure.isotope.molecularWeight.method",
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
                            // 35. SubstanceSpecification.structure.isotope.molecularWeight.type
                            this.Element_Type = new ElementDefinitionInfo
                            {
                                Name = "Element_Type",
                                Path= "SubstanceSpecification.structure.isotope.molecularWeight.type",
                                Id = "SubstanceSpecification.structure.isotope.molecularWeight.type",
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
                            // 36. SubstanceSpecification.structure.isotope.molecularWeight.amount
                            this.Element_Amount = new ElementDefinitionInfo
                            {
                                Name = "Element_Amount",
                                Path= "SubstanceSpecification.structure.isotope.molecularWeight.amount",
                                Id = "SubstanceSpecification.structure.isotope.molecularWeight.amount",
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
                    }
                }
                // 29. SubstanceSpecification.structure.isotope.identifier
                public ElementDefinitionInfo Element_Identifier;
                // 30. SubstanceSpecification.structure.isotope.name
                public ElementDefinitionInfo Element_Name;
                // 31. SubstanceSpecification.structure.isotope.substitution
                public ElementDefinitionInfo Element_Substitution;
                // 32. SubstanceSpecification.structure.isotope.halfLife
                public ElementDefinitionInfo Element_HalfLife;
                // 33. SubstanceSpecification.structure.isotope.molecularWeight
                public ElementDefinitionInfo Element_MolecularWeight;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "SubstanceSpecification.structure.isotope",
                        ElementId = "SubstanceSpecification.structure.isotope"
                    });
                    Element_Identifier.Write(sDef);
                    Element_Name.Write(sDef);
                    Element_Substitution.Write(sDef);
                    Element_HalfLife.Write(sDef);
                    Element_MolecularWeight.Write(sDef);
                }
                
                public Type_Isotope()
                {
                    {
                        // 29. SubstanceSpecification.structure.isotope.identifier
                        this.Element_Identifier = new ElementDefinitionInfo
                        {
                            Name = "Element_Identifier",
                            Path= "SubstanceSpecification.structure.isotope.identifier",
                            Id = "SubstanceSpecification.structure.isotope.identifier",
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
                        // 30. SubstanceSpecification.structure.isotope.name
                        this.Element_Name = new ElementDefinitionInfo
                        {
                            Name = "Element_Name",
                            Path= "SubstanceSpecification.structure.isotope.name",
                            Id = "SubstanceSpecification.structure.isotope.name",
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
                        // 31. SubstanceSpecification.structure.isotope.substitution
                        this.Element_Substitution = new ElementDefinitionInfo
                        {
                            Name = "Element_Substitution",
                            Path= "SubstanceSpecification.structure.isotope.substitution",
                            Id = "SubstanceSpecification.structure.isotope.substitution",
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
                        // 32. SubstanceSpecification.structure.isotope.halfLife
                        this.Element_HalfLife = new ElementDefinitionInfo
                        {
                            Name = "Element_HalfLife",
                            Path= "SubstanceSpecification.structure.isotope.halfLife",
                            Id = "SubstanceSpecification.structure.isotope.halfLife",
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
                        // 33. SubstanceSpecification.structure.isotope.molecularWeight
                        this.Element_MolecularWeight = new ElementDefinitionInfo
                        {
                            Name = "Element_MolecularWeight",
                            Path= "SubstanceSpecification.structure.isotope.molecularWeight",
                            Id = "SubstanceSpecification.structure.isotope.molecularWeight",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new Type_MolecularWeight
                                {
                                }
                            }
                        };
                    }
                }
            }
            // 39. SubstanceSpecification.structure.representation
            public class Type_Representation : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 40. SubstanceSpecification.structure.representation.type
                public ElementDefinitionInfo Element_Type;
                // 41. SubstanceSpecification.structure.representation.representation
                public ElementDefinitionInfo Element_Representation;
                // 42. SubstanceSpecification.structure.representation.attachment
                public ElementDefinitionInfo Element_Attachment;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "SubstanceSpecification.structure.representation",
                        ElementId = "SubstanceSpecification.structure.representation"
                    });
                    Element_Type.Write(sDef);
                    Element_Representation.Write(sDef);
                    Element_Attachment.Write(sDef);
                }
                
                public Type_Representation()
                {
                    {
                        // 40. SubstanceSpecification.structure.representation.type
                        this.Element_Type = new ElementDefinitionInfo
                        {
                            Name = "Element_Type",
                            Path= "SubstanceSpecification.structure.representation.type",
                            Id = "SubstanceSpecification.structure.representation.type",
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
                        // 41. SubstanceSpecification.structure.representation.representation
                        this.Element_Representation = new ElementDefinitionInfo
                        {
                            Name = "Element_Representation",
                            Path= "SubstanceSpecification.structure.representation.representation",
                            Id = "SubstanceSpecification.structure.representation.representation",
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
                        // 42. SubstanceSpecification.structure.representation.attachment
                        this.Element_Attachment = new ElementDefinitionInfo
                        {
                            Name = "Element_Attachment",
                            Path= "SubstanceSpecification.structure.representation.attachment",
                            Id = "SubstanceSpecification.structure.representation.attachment",
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
                }
            }
            // 24. SubstanceSpecification.structure.stereochemistry
            public ElementDefinitionInfo Element_Stereochemistry;
            // 25. SubstanceSpecification.structure.opticalActivity
            public ElementDefinitionInfo Element_OpticalActivity;
            // 26. SubstanceSpecification.structure.molecularFormula
            public ElementDefinitionInfo Element_MolecularFormula;
            // 27. SubstanceSpecification.structure.molecularFormulaByMoiety
            public ElementDefinitionInfo Element_MolecularFormulaByMoiety;
            // 28. SubstanceSpecification.structure.isotope
            public ElementDefinitionInfo Element_Isotope;
            // 37. SubstanceSpecification.structure.molecularWeight
            public ElementDefinitionInfo Element_MolecularWeight;
            // 38. SubstanceSpecification.structure.source
            public ElementDefinitionInfo Element_Source;
            // 39. SubstanceSpecification.structure.representation
            public ElementDefinitionInfo Element_Representation;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "SubstanceSpecification.structure",
                    ElementId = "SubstanceSpecification.structure"
                });
                Element_Stereochemistry.Write(sDef);
                Element_OpticalActivity.Write(sDef);
                Element_MolecularFormula.Write(sDef);
                Element_MolecularFormulaByMoiety.Write(sDef);
                Element_Isotope.Write(sDef);
                Element_MolecularWeight.Write(sDef);
                Element_Source.Write(sDef);
                Element_Representation.Write(sDef);
            }
            
            public Type_Structure()
            {
                {
                    // 24. SubstanceSpecification.structure.stereochemistry
                    this.Element_Stereochemistry = new ElementDefinitionInfo
                    {
                        Name = "Element_Stereochemistry",
                        Path= "SubstanceSpecification.structure.stereochemistry",
                        Id = "SubstanceSpecification.structure.stereochemistry",
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
                    // 25. SubstanceSpecification.structure.opticalActivity
                    this.Element_OpticalActivity = new ElementDefinitionInfo
                    {
                        Name = "Element_OpticalActivity",
                        Path= "SubstanceSpecification.structure.opticalActivity",
                        Id = "SubstanceSpecification.structure.opticalActivity",
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
                    // 26. SubstanceSpecification.structure.molecularFormula
                    this.Element_MolecularFormula = new ElementDefinitionInfo
                    {
                        Name = "Element_MolecularFormula",
                        Path= "SubstanceSpecification.structure.molecularFormula",
                        Id = "SubstanceSpecification.structure.molecularFormula",
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
                    // 27. SubstanceSpecification.structure.molecularFormulaByMoiety
                    this.Element_MolecularFormulaByMoiety = new ElementDefinitionInfo
                    {
                        Name = "Element_MolecularFormulaByMoiety",
                        Path= "SubstanceSpecification.structure.molecularFormulaByMoiety",
                        Id = "SubstanceSpecification.structure.molecularFormulaByMoiety",
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
                    // 28. SubstanceSpecification.structure.isotope
                    this.Element_Isotope = new ElementDefinitionInfo
                    {
                        Name = "Element_Isotope",
                        Path= "SubstanceSpecification.structure.isotope",
                        Id = "SubstanceSpecification.structure.isotope",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Isotope
                            {
                            }
                        }
                    };
                }
                {
                    // 37. SubstanceSpecification.structure.molecularWeight
                    this.Element_MolecularWeight = new ElementDefinitionInfo
                    {
                        Name = "Element_MolecularWeight",
                        Path= "SubstanceSpecification.structure.molecularWeight",
                        Id = "SubstanceSpecification.structure.molecularWeight",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                        }
                    };
                }
                {
                    // 38. SubstanceSpecification.structure.source
                    this.Element_Source = new ElementDefinitionInfo
                    {
                        Name = "Element_Source",
                        Path= "SubstanceSpecification.structure.source",
                        Id = "SubstanceSpecification.structure.source",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                                }
                            }
                        }
                    };
                }
                {
                    // 39. SubstanceSpecification.structure.representation
                    this.Element_Representation = new ElementDefinitionInfo
                    {
                        Name = "Element_Representation",
                        Path= "SubstanceSpecification.structure.representation",
                        Id = "SubstanceSpecification.structure.representation",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Representation
                            {
                            }
                        }
                    };
                }
            }
        }
        // 43. SubstanceSpecification.code
        public class Type_Code : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 44. SubstanceSpecification.code.code
            public ElementDefinitionInfo Element_Code;
            // 45. SubstanceSpecification.code.status
            public ElementDefinitionInfo Element_Status;
            // 46. SubstanceSpecification.code.statusDate
            public ElementDefinitionInfo Element_StatusDate;
            // 47. SubstanceSpecification.code.comment
            public ElementDefinitionInfo Element_Comment;
            // 48. SubstanceSpecification.code.source
            public ElementDefinitionInfo Element_Source;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "SubstanceSpecification.code",
                    ElementId = "SubstanceSpecification.code"
                });
                Element_Code.Write(sDef);
                Element_Status.Write(sDef);
                Element_StatusDate.Write(sDef);
                Element_Comment.Write(sDef);
                Element_Source.Write(sDef);
            }
            
            public Type_Code()
            {
                {
                    // 44. SubstanceSpecification.code.code
                    this.Element_Code = new ElementDefinitionInfo
                    {
                        Name = "Element_Code",
                        Path= "SubstanceSpecification.code.code",
                        Id = "SubstanceSpecification.code.code",
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
                    // 45. SubstanceSpecification.code.status
                    this.Element_Status = new ElementDefinitionInfo
                    {
                        Name = "Element_Status",
                        Path= "SubstanceSpecification.code.status",
                        Id = "SubstanceSpecification.code.status",
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
                    // 46. SubstanceSpecification.code.statusDate
                    this.Element_StatusDate = new ElementDefinitionInfo
                    {
                        Name = "Element_StatusDate",
                        Path= "SubstanceSpecification.code.statusDate",
                        Id = "SubstanceSpecification.code.statusDate",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                            {
                            }
                        }
                    };
                }
                {
                    // 47. SubstanceSpecification.code.comment
                    this.Element_Comment = new ElementDefinitionInfo
                    {
                        Name = "Element_Comment",
                        Path= "SubstanceSpecification.code.comment",
                        Id = "SubstanceSpecification.code.comment",
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
                    // 48. SubstanceSpecification.code.source
                    this.Element_Source = new ElementDefinitionInfo
                    {
                        Name = "Element_Source",
                        Path= "SubstanceSpecification.code.source",
                        Id = "SubstanceSpecification.code.source",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                                }
                            }
                        }
                    };
                }
            }
        }
        // 49. SubstanceSpecification.name
        public class Type_Name : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 59. SubstanceSpecification.name.official
            public class Type_Official : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 60. SubstanceSpecification.name.official.authority
                public ElementDefinitionInfo Element_Authority;
                // 61. SubstanceSpecification.name.official.status
                public ElementDefinitionInfo Element_Status;
                // 62. SubstanceSpecification.name.official.date
                public ElementDefinitionInfo Element_Date;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "SubstanceSpecification.name.official",
                        ElementId = "SubstanceSpecification.name.official"
                    });
                    Element_Authority.Write(sDef);
                    Element_Status.Write(sDef);
                    Element_Date.Write(sDef);
                }
                
                public Type_Official()
                {
                    {
                        // 60. SubstanceSpecification.name.official.authority
                        this.Element_Authority = new ElementDefinitionInfo
                        {
                            Name = "Element_Authority",
                            Path= "SubstanceSpecification.name.official.authority",
                            Id = "SubstanceSpecification.name.official.authority",
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
                        // 61. SubstanceSpecification.name.official.status
                        this.Element_Status = new ElementDefinitionInfo
                        {
                            Name = "Element_Status",
                            Path= "SubstanceSpecification.name.official.status",
                            Id = "SubstanceSpecification.name.official.status",
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
                        // 62. SubstanceSpecification.name.official.date
                        this.Element_Date = new ElementDefinitionInfo
                        {
                            Name = "Element_Date",
                            Path= "SubstanceSpecification.name.official.date",
                            Id = "SubstanceSpecification.name.official.date",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                                {
                                }
                            }
                        };
                    }
                }
            }
            // 50. SubstanceSpecification.name.name
            public ElementDefinitionInfo Element_Name;
            // 51. SubstanceSpecification.name.type
            public ElementDefinitionInfo Element_Type;
            // 52. SubstanceSpecification.name.status
            public ElementDefinitionInfo Element_Status;
            // 53. SubstanceSpecification.name.preferred
            public ElementDefinitionInfo Element_Preferred;
            // 54. SubstanceSpecification.name.language
            public ElementDefinitionInfo Element_Language;
            // 55. SubstanceSpecification.name.domain
            public ElementDefinitionInfo Element_Domain;
            // 56. SubstanceSpecification.name.jurisdiction
            public ElementDefinitionInfo Element_Jurisdiction;
            // 57. SubstanceSpecification.name.synonym
            public ElementDefinitionInfo Element_Synonym;
            // 58. SubstanceSpecification.name.translation
            public ElementDefinitionInfo Element_Translation;
            // 59. SubstanceSpecification.name.official
            public ElementDefinitionInfo Element_Official;
            // 63. SubstanceSpecification.name.source
            public ElementDefinitionInfo Element_Source;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "SubstanceSpecification.name",
                    ElementId = "SubstanceSpecification.name"
                });
                Element_Name.Write(sDef);
                Element_Type.Write(sDef);
                Element_Status.Write(sDef);
                Element_Preferred.Write(sDef);
                Element_Language.Write(sDef);
                Element_Domain.Write(sDef);
                Element_Jurisdiction.Write(sDef);
                Element_Synonym.Write(sDef);
                Element_Translation.Write(sDef);
                Element_Official.Write(sDef);
                Element_Source.Write(sDef);
            }
            
            public Type_Name()
            {
                {
                    // 50. SubstanceSpecification.name.name
                    this.Element_Name = new ElementDefinitionInfo
                    {
                        Name = "Element_Name",
                        Path= "SubstanceSpecification.name.name",
                        Id = "SubstanceSpecification.name.name",
                        Min = 1,
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
                    // 51. SubstanceSpecification.name.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "SubstanceSpecification.name.type",
                        Id = "SubstanceSpecification.name.type",
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
                    // 52. SubstanceSpecification.name.status
                    this.Element_Status = new ElementDefinitionInfo
                    {
                        Name = "Element_Status",
                        Path= "SubstanceSpecification.name.status",
                        Id = "SubstanceSpecification.name.status",
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
                    // 53. SubstanceSpecification.name.preferred
                    this.Element_Preferred = new ElementDefinitionInfo
                    {
                        Name = "Element_Preferred",
                        Path= "SubstanceSpecification.name.preferred",
                        Id = "SubstanceSpecification.name.preferred",
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
                    // 54. SubstanceSpecification.name.language
                    this.Element_Language = new ElementDefinitionInfo
                    {
                        Name = "Element_Language",
                        Path= "SubstanceSpecification.name.language",
                        Id = "SubstanceSpecification.name.language",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                            {
                            }
                        }
                    };
                }
                {
                    // 55. SubstanceSpecification.name.domain
                    this.Element_Domain = new ElementDefinitionInfo
                    {
                        Name = "Element_Domain",
                        Path= "SubstanceSpecification.name.domain",
                        Id = "SubstanceSpecification.name.domain",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                            {
                            }
                        }
                    };
                }
                {
                    // 56. SubstanceSpecification.name.jurisdiction
                    this.Element_Jurisdiction = new ElementDefinitionInfo
                    {
                        Name = "Element_Jurisdiction",
                        Path= "SubstanceSpecification.name.jurisdiction",
                        Id = "SubstanceSpecification.name.jurisdiction",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                            {
                            }
                        }
                    };
                }
                {
                    // 57. SubstanceSpecification.name.synonym
                    this.Element_Synonym = new ElementDefinitionInfo
                    {
                        Name = "Element_Synonym",
                        Path= "SubstanceSpecification.name.synonym",
                        Id = "SubstanceSpecification.name.synonym",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                        }
                    };
                }
                {
                    // 58. SubstanceSpecification.name.translation
                    this.Element_Translation = new ElementDefinitionInfo
                    {
                        Name = "Element_Translation",
                        Path= "SubstanceSpecification.name.translation",
                        Id = "SubstanceSpecification.name.translation",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                        }
                    };
                }
                {
                    // 59. SubstanceSpecification.name.official
                    this.Element_Official = new ElementDefinitionInfo
                    {
                        Name = "Element_Official",
                        Path= "SubstanceSpecification.name.official",
                        Id = "SubstanceSpecification.name.official",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Official
                            {
                            }
                        }
                    };
                }
                {
                    // 63. SubstanceSpecification.name.source
                    this.Element_Source = new ElementDefinitionInfo
                    {
                        Name = "Element_Source",
                        Path= "SubstanceSpecification.name.source",
                        Id = "SubstanceSpecification.name.source",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                                }
                            }
                        }
                    };
                }
            }
        }
        // 65. SubstanceSpecification.relationship
        public class Type_Relationship : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 66. SubstanceSpecification.relationship.substance[x]
            public ElementDefinitionInfo Element_Substance;
            // 67. SubstanceSpecification.relationship.relationship
            public ElementDefinitionInfo Element_Relationship;
            // 68. SubstanceSpecification.relationship.isDefining
            public ElementDefinitionInfo Element_IsDefining;
            // 69. SubstanceSpecification.relationship.amount[x]
            public ElementDefinitionInfo Element_Amount;
            // 70. SubstanceSpecification.relationship.amountRatioLowLimit
            public ElementDefinitionInfo Element_AmountRatioLowLimit;
            // 71. SubstanceSpecification.relationship.amountType
            public ElementDefinitionInfo Element_AmountType;
            // 72. SubstanceSpecification.relationship.source
            public ElementDefinitionInfo Element_Source;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "SubstanceSpecification.relationship",
                    ElementId = "SubstanceSpecification.relationship"
                });
                Element_Substance.Write(sDef);
                Element_Relationship.Write(sDef);
                Element_IsDefining.Write(sDef);
                Element_Amount.Write(sDef);
                Element_AmountRatioLowLimit.Write(sDef);
                Element_AmountType.Write(sDef);
                Element_Source.Write(sDef);
            }
            
            public Type_Relationship()
            {
                {
                    // 66. SubstanceSpecification.relationship.substance[x]
                    this.Element_Substance = new ElementDefinitionInfo
                    {
                        Name = "Element_Substance",
                        Path= "SubstanceSpecification.relationship.substance[x]",
                        Id = "SubstanceSpecification.relationship.substance[x]",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/SubstanceSpecification"
                                }
                            },
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                            {
                            }
                        }
                    };
                }
                {
                    // 67. SubstanceSpecification.relationship.relationship
                    this.Element_Relationship = new ElementDefinitionInfo
                    {
                        Name = "Element_Relationship",
                        Path= "SubstanceSpecification.relationship.relationship",
                        Id = "SubstanceSpecification.relationship.relationship",
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
                    // 68. SubstanceSpecification.relationship.isDefining
                    this.Element_IsDefining = new ElementDefinitionInfo
                    {
                        Name = "Element_IsDefining",
                        Path= "SubstanceSpecification.relationship.isDefining",
                        Id = "SubstanceSpecification.relationship.isDefining",
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
                    // 69. SubstanceSpecification.relationship.amount[x]
                    this.Element_Amount = new ElementDefinitionInfo
                    {
                        Name = "Element_Amount",
                        Path= "SubstanceSpecification.relationship.amount[x]",
                        Id = "SubstanceSpecification.relationship.amount[x]",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Quantity
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Range
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Ratio
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_String
                            {
                            }
                        }
                    };
                }
                {
                    // 70. SubstanceSpecification.relationship.amountRatioLowLimit
                    this.Element_AmountRatioLowLimit = new ElementDefinitionInfo
                    {
                        Name = "Element_AmountRatioLowLimit",
                        Path= "SubstanceSpecification.relationship.amountRatioLowLimit",
                        Id = "SubstanceSpecification.relationship.amountRatioLowLimit",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Ratio
                            {
                            }
                        }
                    };
                }
                {
                    // 71. SubstanceSpecification.relationship.amountType
                    this.Element_AmountType = new ElementDefinitionInfo
                    {
                        Name = "Element_AmountType",
                        Path= "SubstanceSpecification.relationship.amountType",
                        Id = "SubstanceSpecification.relationship.amountType",
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
                    // 72. SubstanceSpecification.relationship.source
                    this.Element_Source = new ElementDefinitionInfo
                    {
                        Name = "Element_Source",
                        Path= "SubstanceSpecification.relationship.source",
                        Id = "SubstanceSpecification.relationship.source",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                                }
                            }
                        }
                    };
                }
            }
        }
        // 1. SubstanceSpecification.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. SubstanceSpecification.type
        public ElementDefinitionInfo Element_Type;
        // 3. SubstanceSpecification.status
        public ElementDefinitionInfo Element_Status;
        // 4. SubstanceSpecification.domain
        public ElementDefinitionInfo Element_Domain;
        // 5. SubstanceSpecification.description
        public ElementDefinitionInfo Element_Description;
        // 6. SubstanceSpecification.source
        public ElementDefinitionInfo Element_Source;
        // 7. SubstanceSpecification.comment
        public ElementDefinitionInfo Element_Comment;
        // 8. SubstanceSpecification.moiety
        public ElementDefinitionInfo Element_Moiety;
        // 16. SubstanceSpecification.property
        public ElementDefinitionInfo Element_Property;
        // 22. SubstanceSpecification.referenceInformation
        public ElementDefinitionInfo Element_ReferenceInformation;
        // 23. SubstanceSpecification.structure
        public ElementDefinitionInfo Element_Structure;
        // 43. SubstanceSpecification.code
        public ElementDefinitionInfo Element_Code;
        // 49. SubstanceSpecification.name
        public ElementDefinitionInfo Element_Name;
        // 64. SubstanceSpecification.molecularWeight
        public ElementDefinitionInfo Element_MolecularWeight;
        // 65. SubstanceSpecification.relationship
        public ElementDefinitionInfo Element_Relationship;
        // 73. SubstanceSpecification.nucleicAcid
        public ElementDefinitionInfo Element_NucleicAcid;
        // 74. SubstanceSpecification.polymer
        public ElementDefinitionInfo Element_Polymer;
        // 75. SubstanceSpecification.protein
        public ElementDefinitionInfo Element_Protein;
        // 76. SubstanceSpecification.sourceMaterial
        public ElementDefinitionInfo Element_SourceMaterial;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "SubstanceSpecification",
                ElementId = "SubstanceSpecification"
            });
            Element_Identifier.Write(sDef);
            Element_Type.Write(sDef);
            Element_Status.Write(sDef);
            Element_Domain.Write(sDef);
            Element_Description.Write(sDef);
            Element_Source.Write(sDef);
            Element_Comment.Write(sDef);
            Element_Moiety.Write(sDef);
            Element_Property.Write(sDef);
            Element_ReferenceInformation.Write(sDef);
            Element_Structure.Write(sDef);
            Element_Code.Write(sDef);
            Element_Name.Write(sDef);
            Element_MolecularWeight.Write(sDef);
            Element_Relationship.Write(sDef);
            Element_NucleicAcid.Write(sDef);
            Element_Polymer.Write(sDef);
            Element_Protein.Write(sDef);
            Element_SourceMaterial.Write(sDef);
        }
        
        public Resource_SubstanceSpecification()
        {
            {
                // 1. SubstanceSpecification.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "SubstanceSpecification.identifier",
                    Id = "SubstanceSpecification.identifier",
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
                // 2. SubstanceSpecification.type
                this.Element_Type = new ElementDefinitionInfo
                {
                    Name = "Element_Type",
                    Path= "SubstanceSpecification.type",
                    Id = "SubstanceSpecification.type",
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
                // 3. SubstanceSpecification.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "SubstanceSpecification.status",
                    Id = "SubstanceSpecification.status",
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
                // 4. SubstanceSpecification.domain
                this.Element_Domain = new ElementDefinitionInfo
                {
                    Name = "Element_Domain",
                    Path= "SubstanceSpecification.domain",
                    Id = "SubstanceSpecification.domain",
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
                // 5. SubstanceSpecification.description
                this.Element_Description = new ElementDefinitionInfo
                {
                    Name = "Element_Description",
                    Path= "SubstanceSpecification.description",
                    Id = "SubstanceSpecification.description",
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
                // 6. SubstanceSpecification.source
                this.Element_Source = new ElementDefinitionInfo
                {
                    Name = "Element_Source",
                    Path= "SubstanceSpecification.source",
                    Id = "SubstanceSpecification.source",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                            }
                        }
                    }
                };
            }
            {
                // 7. SubstanceSpecification.comment
                this.Element_Comment = new ElementDefinitionInfo
                {
                    Name = "Element_Comment",
                    Path= "SubstanceSpecification.comment",
                    Id = "SubstanceSpecification.comment",
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
                // 8. SubstanceSpecification.moiety
                this.Element_Moiety = new ElementDefinitionInfo
                {
                    Name = "Element_Moiety",
                    Path= "SubstanceSpecification.moiety",
                    Id = "SubstanceSpecification.moiety",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Moiety
                        {
                        }
                    }
                };
            }
            {
                // 16. SubstanceSpecification.property
                this.Element_Property = new ElementDefinitionInfo
                {
                    Name = "Element_Property",
                    Path= "SubstanceSpecification.property",
                    Id = "SubstanceSpecification.property",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Property
                        {
                        }
                    }
                };
            }
            {
                // 22. SubstanceSpecification.referenceInformation
                this.Element_ReferenceInformation = new ElementDefinitionInfo
                {
                    Name = "Element_ReferenceInformation",
                    Path= "SubstanceSpecification.referenceInformation",
                    Id = "SubstanceSpecification.referenceInformation",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/SubstanceReferenceInformation"
                            }
                        }
                    }
                };
            }
            {
                // 23. SubstanceSpecification.structure
                this.Element_Structure = new ElementDefinitionInfo
                {
                    Name = "Element_Structure",
                    Path= "SubstanceSpecification.structure",
                    Id = "SubstanceSpecification.structure",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new Type_Structure
                        {
                        }
                    }
                };
            }
            {
                // 43. SubstanceSpecification.code
                this.Element_Code = new ElementDefinitionInfo
                {
                    Name = "Element_Code",
                    Path= "SubstanceSpecification.code",
                    Id = "SubstanceSpecification.code",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Code
                        {
                        }
                    }
                };
            }
            {
                // 49. SubstanceSpecification.name
                this.Element_Name = new ElementDefinitionInfo
                {
                    Name = "Element_Name",
                    Path= "SubstanceSpecification.name",
                    Id = "SubstanceSpecification.name",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Name
                        {
                        }
                    }
                };
            }
            {
                // 64. SubstanceSpecification.molecularWeight
                this.Element_MolecularWeight = new ElementDefinitionInfo
                {
                    Name = "Element_MolecularWeight",
                    Path= "SubstanceSpecification.molecularWeight",
                    Id = "SubstanceSpecification.molecularWeight",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                    }
                };
            }
            {
                // 65. SubstanceSpecification.relationship
                this.Element_Relationship = new ElementDefinitionInfo
                {
                    Name = "Element_Relationship",
                    Path= "SubstanceSpecification.relationship",
                    Id = "SubstanceSpecification.relationship",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Relationship
                        {
                        }
                    }
                };
            }
            {
                // 73. SubstanceSpecification.nucleicAcid
                this.Element_NucleicAcid = new ElementDefinitionInfo
                {
                    Name = "Element_NucleicAcid",
                    Path= "SubstanceSpecification.nucleicAcid",
                    Id = "SubstanceSpecification.nucleicAcid",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/SubstanceNucleicAcid"
                            }
                        }
                    }
                };
            }
            {
                // 74. SubstanceSpecification.polymer
                this.Element_Polymer = new ElementDefinitionInfo
                {
                    Name = "Element_Polymer",
                    Path= "SubstanceSpecification.polymer",
                    Id = "SubstanceSpecification.polymer",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/SubstancePolymer"
                            }
                        }
                    }
                };
            }
            {
                // 75. SubstanceSpecification.protein
                this.Element_Protein = new ElementDefinitionInfo
                {
                    Name = "Element_Protein",
                    Path= "SubstanceSpecification.protein",
                    Id = "SubstanceSpecification.protein",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/SubstanceProtein"
                            }
                        }
                    }
                };
            }
            {
                // 76. SubstanceSpecification.sourceMaterial
                this.Element_SourceMaterial = new ElementDefinitionInfo
                {
                    Name = "Element_SourceMaterial",
                    Path= "SubstanceSpecification.sourceMaterial",
                    Id = "SubstanceSpecification.sourceMaterial",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/SubstanceSourceMaterial"
                            }
                        }
                    }
                };
            }
            this.Name = "SubstanceSpecification";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/SubstanceSpecification";
        }
    }
}
