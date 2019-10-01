using System;                                                                                                                               // MakerGen.cs:428
using System.Diagnostics;                                                                                                                   // MakerGen.cs:429
using System.IO;                                                                                                                            // MakerGen.cs:430
using System.Linq;                                                                                                                          // MakerGen.cs:431
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:432
                                                                                                                                            // MakerGen.cs:433
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:434
{                                                                                                                                           // MakerGen.cs:435
    #region Json                                                                                                                            // MakerGen.cs:436
    #if NEVER                                                                                                                               // MakerGen.cs:437
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
    #endregion                                                                                                                              // MakerGen.cs:440
    /// <summary>
    /// Fhir resource 'SubstanceSpecification'
    /// </summary>
    // 0. SubstanceSpecification
    public class Resource_SubstanceSpecification : FhirKhit.Maker.Common.Resource.ResourceBase                                              // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        // 8. SubstanceSpecification.moiety
        public class Type_Moiety : FhirKhit.Maker.Common.Complex.ComplexBase                                                                // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 9. SubstanceSpecification.moiety.role
            public ElementDefinitionInfo Element_Role;                                                                                      // MakerGen.cs:212
            // 10. SubstanceSpecification.moiety.identifier
            public ElementDefinitionInfo Element_Identifier;                                                                                // MakerGen.cs:212
            // 11. SubstanceSpecification.moiety.name
            public ElementDefinitionInfo Element_Name;                                                                                      // MakerGen.cs:212
            // 12. SubstanceSpecification.moiety.stereochemistry
            public ElementDefinitionInfo Element_Stereochemistry;                                                                           // MakerGen.cs:212
            // 13. SubstanceSpecification.moiety.opticalActivity
            public ElementDefinitionInfo Element_OpticalActivity;                                                                           // MakerGen.cs:212
            // 14. SubstanceSpecification.moiety.molecularFormula
            public ElementDefinitionInfo Element_MolecularFormula;                                                                          // MakerGen.cs:212
            // 15. SubstanceSpecification.moiety.amount[x]
            public ElementDefinitionInfo Element_Amount;                                                                                    // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "SubstanceSpecification.moiety",                                                                                 // MakerGen.cs:388
                    ElementId = "SubstanceSpecification.moiety"                                                                             // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Role.Write(sDef);                                                                                                   // MakerGen.cs:216
                Element_Identifier.Write(sDef);                                                                                             // MakerGen.cs:216
                Element_Name.Write(sDef);                                                                                                   // MakerGen.cs:216
                Element_Stereochemistry.Write(sDef);                                                                                        // MakerGen.cs:216
                Element_OpticalActivity.Write(sDef);                                                                                        // MakerGen.cs:216
                Element_MolecularFormula.Write(sDef);                                                                                       // MakerGen.cs:216
                Element_Amount.Write(sDef);                                                                                                 // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_Moiety()                                                                                                            // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 9. SubstanceSpecification.moiety.role
                    this.Element_Role = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Role",                                                                                              // MakerGen.cs:231
                        Path= "SubstanceSpecification.moiety.role",                                                                         // MakerGen.cs:232
                        Id = "SubstanceSpecification.moiety.role",                                                                          // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 10. SubstanceSpecification.moiety.identifier
                    this.Element_Identifier = new ElementDefinitionInfo                                                                     // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Identifier",                                                                                        // MakerGen.cs:231
                        Path= "SubstanceSpecification.moiety.identifier",                                                                   // MakerGen.cs:232
                        Id = "SubstanceSpecification.moiety.identifier",                                                                    // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Identifier                                                               // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            }                                                                                                               // MakerGen.cs:353
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 11. SubstanceSpecification.moiety.name
                    this.Element_Name = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Name",                                                                                              // MakerGen.cs:231
                        Path= "SubstanceSpecification.moiety.name",                                                                         // MakerGen.cs:232
                        Id = "SubstanceSpecification.moiety.name",                                                                          // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 12. SubstanceSpecification.moiety.stereochemistry
                    this.Element_Stereochemistry = new ElementDefinitionInfo                                                                // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Stereochemistry",                                                                                   // MakerGen.cs:231
                        Path= "SubstanceSpecification.moiety.stereochemistry",                                                              // MakerGen.cs:232
                        Id = "SubstanceSpecification.moiety.stereochemistry",                                                               // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 13. SubstanceSpecification.moiety.opticalActivity
                    this.Element_OpticalActivity = new ElementDefinitionInfo                                                                // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_OpticalActivity",                                                                                   // MakerGen.cs:231
                        Path= "SubstanceSpecification.moiety.opticalActivity",                                                              // MakerGen.cs:232
                        Id = "SubstanceSpecification.moiety.opticalActivity",                                                               // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 14. SubstanceSpecification.moiety.molecularFormula
                    this.Element_MolecularFormula = new ElementDefinitionInfo                                                               // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_MolecularFormula",                                                                                  // MakerGen.cs:231
                        Path= "SubstanceSpecification.moiety.molecularFormula",                                                             // MakerGen.cs:232
                        Id = "SubstanceSpecification.moiety.molecularFormula",                                                              // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 15. SubstanceSpecification.moiety.amount[x]
                    this.Element_Amount = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Amount",                                                                                            // MakerGen.cs:231
                        Path= "SubstanceSpecification.moiety.amount[x]",                                                                    // MakerGen.cs:232
                        Id = "SubstanceSpecification.moiety.amount[x]",                                                                     // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                 // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            },                                                                                                              // MakerGen.cs:353
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 16. SubstanceSpecification.property
        public class Type_Property : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 17. SubstanceSpecification.property.category
            public ElementDefinitionInfo Element_Category;                                                                                  // MakerGen.cs:212
            // 18. SubstanceSpecification.property.code
            public ElementDefinitionInfo Element_Code;                                                                                      // MakerGen.cs:212
            // 19. SubstanceSpecification.property.parameters
            public ElementDefinitionInfo Element_Parameters;                                                                                // MakerGen.cs:212
            // 20. SubstanceSpecification.property.definingSubstance[x]
            public ElementDefinitionInfo Element_DefiningSubstance;                                                                         // MakerGen.cs:212
            // 21. SubstanceSpecification.property.amount[x]
            public ElementDefinitionInfo Element_Amount;                                                                                    // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "SubstanceSpecification.property",                                                                               // MakerGen.cs:388
                    ElementId = "SubstanceSpecification.property"                                                                           // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Category.Write(sDef);                                                                                               // MakerGen.cs:216
                Element_Code.Write(sDef);                                                                                                   // MakerGen.cs:216
                Element_Parameters.Write(sDef);                                                                                             // MakerGen.cs:216
                Element_DefiningSubstance.Write(sDef);                                                                                      // MakerGen.cs:216
                Element_Amount.Write(sDef);                                                                                                 // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_Property()                                                                                                          // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 17. SubstanceSpecification.property.category
                    this.Element_Category = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Category",                                                                                          // MakerGen.cs:231
                        Path= "SubstanceSpecification.property.category",                                                                   // MakerGen.cs:232
                        Id = "SubstanceSpecification.property.category",                                                                    // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 18. SubstanceSpecification.property.code
                    this.Element_Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Code",                                                                                              // MakerGen.cs:231
                        Path= "SubstanceSpecification.property.code",                                                                       // MakerGen.cs:232
                        Id = "SubstanceSpecification.property.code",                                                                        // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 19. SubstanceSpecification.property.parameters
                    this.Element_Parameters = new ElementDefinitionInfo                                                                     // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Parameters",                                                                                        // MakerGen.cs:231
                        Path= "SubstanceSpecification.property.parameters",                                                                 // MakerGen.cs:232
                        Id = "SubstanceSpecification.property.parameters",                                                                  // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 20. SubstanceSpecification.property.definingSubstance[x]
                    this.Element_DefiningSubstance = new ElementDefinitionInfo                                                              // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_DefiningSubstance",                                                                                 // MakerGen.cs:231
                        Path= "SubstanceSpecification.property.definingSubstance[x]",                                                       // MakerGen.cs:232
                        Id = "SubstanceSpecification.property.definingSubstance[x]",                                                        // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:339
                            {                                                                                                               // MakerGen.cs:340
                                TargetProfile = new String[]                                                                                // MakerGen.cs:342
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/SubstanceSpecification",                                       // MakerGen.cs:342
                                    "http://hl7.org/fhir/StructureDefinition/Substance"                                                     // MakerGen.cs:342
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            },                                                                                                              // MakerGen.cs:343
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 21. SubstanceSpecification.property.amount[x]
                    this.Element_Amount = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Amount",                                                                                            // MakerGen.cs:231
                        Path= "SubstanceSpecification.property.amount[x]",                                                                  // MakerGen.cs:232
                        Id = "SubstanceSpecification.property.amount[x]",                                                                   // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                 // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            },                                                                                                              // MakerGen.cs:353
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 23. SubstanceSpecification.structure
        public class Type_Structure : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 28. SubstanceSpecification.structure.isotope
            public class Type_Isotope : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                // 33. SubstanceSpecification.structure.isotope.molecularWeight
                public class Type_MolecularWeight : FhirKhit.Maker.Common.Complex.ComplexBase                                               // MakerGen.cs:376
                {                                                                                                                           // MakerGen.cs:377
                    // 34. SubstanceSpecification.structure.isotope.molecularWeight.method
                    public ElementDefinitionInfo Element_Method;                                                                            // MakerGen.cs:212
                    // 35. SubstanceSpecification.structure.isotope.molecularWeight.type
                    public ElementDefinitionInfo Element_Type;                                                                              // MakerGen.cs:212
                    // 36. SubstanceSpecification.structure.isotope.molecularWeight.amount
                    public ElementDefinitionInfo Element_Amount;                                                                            // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:383
                    {                                                                                                                       // MakerGen.cs:384
                        base.Write(sDef);                                                                                                   // MakerGen.cs:385
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                  // MakerGen.cs:386
                        {                                                                                                                   // MakerGen.cs:387
                            Path = "SubstanceSpecification.structure.isotope.molecularWeight",                                              // MakerGen.cs:388
                            ElementId = "SubstanceSpecification.structure.isotope.molecularWeight"                                          // MakerGen.cs:389
                        });                                                                                                                 // MakerGen.cs:390
                        Element_Method.Write(sDef);                                                                                         // MakerGen.cs:216
                        Element_Type.Write(sDef);                                                                                           // MakerGen.cs:216
                        Element_Amount.Write(sDef);                                                                                         // MakerGen.cs:216
                    }                                                                                                                       // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
                    public Type_MolecularWeight()                                                                                           // MakerGen.cs:395
                    {                                                                                                                       // MakerGen.cs:396
                        {                                                                                                                   // MakerGen.cs:227
                            // 34. SubstanceSpecification.structure.isotope.molecularWeight.method
                            this.Element_Method = new ElementDefinitionInfo                                                                 // MakerGen.cs:229
                            {                                                                                                               // MakerGen.cs:230
                                Name = "Element_Method",                                                                                    // MakerGen.cs:231
                                Path= "SubstanceSpecification.structure.isotope.molecularWeight.method",                                    // MakerGen.cs:232
                                Id = "SubstanceSpecification.structure.isotope.molecularWeight.method",                                     // MakerGen.cs:233
                                Min = 0,                                                                                                    // MakerGen.cs:234
                                Max = 1,                                                                                                    // MakerGen.cs:235
                                Types = new BaseType[]                                                                                      // MakerGen.cs:236
                                {                                                                                                           // MakerGen.cs:237
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:311
                                    {                                                                                                       // MakerGen.cs:312
                                    }                                                                                                       // MakerGen.cs:315
                                }                                                                                                           // MakerGen.cs:239
                            };                                                                                                              // MakerGen.cs:240
                        }                                                                                                                   // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:227
                            // 35. SubstanceSpecification.structure.isotope.molecularWeight.type
                            this.Element_Type = new ElementDefinitionInfo                                                                   // MakerGen.cs:229
                            {                                                                                                               // MakerGen.cs:230
                                Name = "Element_Type",                                                                                      // MakerGen.cs:231
                                Path= "SubstanceSpecification.structure.isotope.molecularWeight.type",                                      // MakerGen.cs:232
                                Id = "SubstanceSpecification.structure.isotope.molecularWeight.type",                                       // MakerGen.cs:233
                                Min = 0,                                                                                                    // MakerGen.cs:234
                                Max = 1,                                                                                                    // MakerGen.cs:235
                                Types = new BaseType[]                                                                                      // MakerGen.cs:236
                                {                                                                                                           // MakerGen.cs:237
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:311
                                    {                                                                                                       // MakerGen.cs:312
                                    }                                                                                                       // MakerGen.cs:315
                                }                                                                                                           // MakerGen.cs:239
                            };                                                                                                              // MakerGen.cs:240
                        }                                                                                                                   // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:227
                            // 36. SubstanceSpecification.structure.isotope.molecularWeight.amount
                            this.Element_Amount = new ElementDefinitionInfo                                                                 // MakerGen.cs:229
                            {                                                                                                               // MakerGen.cs:230
                                Name = "Element_Amount",                                                                                    // MakerGen.cs:231
                                Path= "SubstanceSpecification.structure.isotope.molecularWeight.amount",                                    // MakerGen.cs:232
                                Id = "SubstanceSpecification.structure.isotope.molecularWeight.amount",                                     // MakerGen.cs:233
                                Min = 0,                                                                                                    // MakerGen.cs:234
                                Max = 1,                                                                                                    // MakerGen.cs:235
                                Types = new BaseType[]                                                                                      // MakerGen.cs:236
                                {                                                                                                           // MakerGen.cs:237
                                    new FhirKhit.Maker.Common.Complex.Type_Quantity                                                         // MakerGen.cs:351
                                    {                                                                                                       // MakerGen.cs:352
                                    }                                                                                                       // MakerGen.cs:353
                                }                                                                                                           // MakerGen.cs:239
                            };                                                                                                              // MakerGen.cs:240
                        }                                                                                                                   // MakerGen.cs:241
                    }                                                                                                                       // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:400
                // 29. SubstanceSpecification.structure.isotope.identifier
                public ElementDefinitionInfo Element_Identifier;                                                                            // MakerGen.cs:212
                // 30. SubstanceSpecification.structure.isotope.name
                public ElementDefinitionInfo Element_Name;                                                                                  // MakerGen.cs:212
                // 31. SubstanceSpecification.structure.isotope.substitution
                public ElementDefinitionInfo Element_Substitution;                                                                          // MakerGen.cs:212
                // 32. SubstanceSpecification.structure.isotope.halfLife
                public ElementDefinitionInfo Element_HalfLife;                                                                              // MakerGen.cs:212
                // 33. SubstanceSpecification.structure.isotope.molecularWeight
                public ElementDefinitionInfo Element_MolecularWeight;                                                                       // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:383
                {                                                                                                                           // MakerGen.cs:384
                    base.Write(sDef);                                                                                                       // MakerGen.cs:385
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:386
                    {                                                                                                                       // MakerGen.cs:387
                        Path = "SubstanceSpecification.structure.isotope",                                                                  // MakerGen.cs:388
                        ElementId = "SubstanceSpecification.structure.isotope"                                                              // MakerGen.cs:389
                    });                                                                                                                     // MakerGen.cs:390
                    Element_Identifier.Write(sDef);                                                                                         // MakerGen.cs:216
                    Element_Name.Write(sDef);                                                                                               // MakerGen.cs:216
                    Element_Substitution.Write(sDef);                                                                                       // MakerGen.cs:216
                    Element_HalfLife.Write(sDef);                                                                                           // MakerGen.cs:216
                    Element_MolecularWeight.Write(sDef);                                                                                    // MakerGen.cs:216
                }                                                                                                                           // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
                public Type_Isotope()                                                                                                       // MakerGen.cs:395
                {                                                                                                                           // MakerGen.cs:396
                    {                                                                                                                       // MakerGen.cs:227
                        // 29. SubstanceSpecification.structure.isotope.identifier
                        this.Element_Identifier = new ElementDefinitionInfo                                                                 // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Identifier",                                                                                    // MakerGen.cs:231
                            Path= "SubstanceSpecification.structure.isotope.identifier",                                                    // MakerGen.cs:232
                            Id = "SubstanceSpecification.structure.isotope.identifier",                                                     // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Complex.Type_Identifier                                                           // MakerGen.cs:351
                                {                                                                                                           // MakerGen.cs:352
                                }                                                                                                           // MakerGen.cs:353
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 30. SubstanceSpecification.structure.isotope.name
                        this.Element_Name = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Name",                                                                                          // MakerGen.cs:231
                            Path= "SubstanceSpecification.structure.isotope.name",                                                          // MakerGen.cs:232
                            Id = "SubstanceSpecification.structure.isotope.name",                                                           // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:311
                                {                                                                                                           // MakerGen.cs:312
                                }                                                                                                           // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 31. SubstanceSpecification.structure.isotope.substitution
                        this.Element_Substitution = new ElementDefinitionInfo                                                               // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Substitution",                                                                                  // MakerGen.cs:231
                            Path= "SubstanceSpecification.structure.isotope.substitution",                                                  // MakerGen.cs:232
                            Id = "SubstanceSpecification.structure.isotope.substitution",                                                   // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:311
                                {                                                                                                           // MakerGen.cs:312
                                }                                                                                                           // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 32. SubstanceSpecification.structure.isotope.halfLife
                        this.Element_HalfLife = new ElementDefinitionInfo                                                                   // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_HalfLife",                                                                                      // MakerGen.cs:231
                            Path= "SubstanceSpecification.structure.isotope.halfLife",                                                      // MakerGen.cs:232
                            Id = "SubstanceSpecification.structure.isotope.halfLife",                                                       // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Complex.Type_Quantity                                                             // MakerGen.cs:351
                                {                                                                                                           // MakerGen.cs:352
                                }                                                                                                           // MakerGen.cs:353
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 33. SubstanceSpecification.structure.isotope.molecularWeight
                        this.Element_MolecularWeight = new ElementDefinitionInfo                                                            // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_MolecularWeight",                                                                               // MakerGen.cs:231
                            Path= "SubstanceSpecification.structure.isotope.molecularWeight",                                               // MakerGen.cs:232
                            Id = "SubstanceSpecification.structure.isotope.molecularWeight",                                                // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new Type_MolecularWeight                                                                                    // MakerGen.cs:255
                                {                                                                                                           // MakerGen.cs:256
                                }                                                                                                           // MakerGen.cs:257
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                }                                                                                                                           // MakerGen.cs:398
            }                                                                                                                               // MakerGen.cs:400
            // 39. SubstanceSpecification.structure.representation
            public class Type_Representation : FhirKhit.Maker.Common.Complex.ComplexBase                                                    // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                // 40. SubstanceSpecification.structure.representation.type
                public ElementDefinitionInfo Element_Type;                                                                                  // MakerGen.cs:212
                // 41. SubstanceSpecification.structure.representation.representation
                public ElementDefinitionInfo Element_Representation;                                                                        // MakerGen.cs:212
                // 42. SubstanceSpecification.structure.representation.attachment
                public ElementDefinitionInfo Element_Attachment;                                                                            // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:383
                {                                                                                                                           // MakerGen.cs:384
                    base.Write(sDef);                                                                                                       // MakerGen.cs:385
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:386
                    {                                                                                                                       // MakerGen.cs:387
                        Path = "SubstanceSpecification.structure.representation",                                                           // MakerGen.cs:388
                        ElementId = "SubstanceSpecification.structure.representation"                                                       // MakerGen.cs:389
                    });                                                                                                                     // MakerGen.cs:390
                    Element_Type.Write(sDef);                                                                                               // MakerGen.cs:216
                    Element_Representation.Write(sDef);                                                                                     // MakerGen.cs:216
                    Element_Attachment.Write(sDef);                                                                                         // MakerGen.cs:216
                }                                                                                                                           // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
                public Type_Representation()                                                                                                // MakerGen.cs:395
                {                                                                                                                           // MakerGen.cs:396
                    {                                                                                                                       // MakerGen.cs:227
                        // 40. SubstanceSpecification.structure.representation.type
                        this.Element_Type = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Type",                                                                                          // MakerGen.cs:231
                            Path= "SubstanceSpecification.structure.representation.type",                                                   // MakerGen.cs:232
                            Id = "SubstanceSpecification.structure.representation.type",                                                    // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:311
                                {                                                                                                           // MakerGen.cs:312
                                }                                                                                                           // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 41. SubstanceSpecification.structure.representation.representation
                        this.Element_Representation = new ElementDefinitionInfo                                                             // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Representation",                                                                                // MakerGen.cs:231
                            Path= "SubstanceSpecification.structure.representation.representation",                                         // MakerGen.cs:232
                            Id = "SubstanceSpecification.structure.representation.representation",                                          // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Primitive.Primitive_String                                                        // MakerGen.cs:296
                                {                                                                                                           // MakerGen.cs:297
                                }                                                                                                           // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 42. SubstanceSpecification.structure.representation.attachment
                        this.Element_Attachment = new ElementDefinitionInfo                                                                 // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Attachment",                                                                                    // MakerGen.cs:231
                            Path= "SubstanceSpecification.structure.representation.attachment",                                             // MakerGen.cs:232
                            Id = "SubstanceSpecification.structure.representation.attachment",                                              // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Complex.Type_Attachment                                                           // MakerGen.cs:351
                                {                                                                                                           // MakerGen.cs:352
                                }                                                                                                           // MakerGen.cs:353
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                }                                                                                                                           // MakerGen.cs:398
            }                                                                                                                               // MakerGen.cs:400
            // 24. SubstanceSpecification.structure.stereochemistry
            public ElementDefinitionInfo Element_Stereochemistry;                                                                           // MakerGen.cs:212
            // 25. SubstanceSpecification.structure.opticalActivity
            public ElementDefinitionInfo Element_OpticalActivity;                                                                           // MakerGen.cs:212
            // 26. SubstanceSpecification.structure.molecularFormula
            public ElementDefinitionInfo Element_MolecularFormula;                                                                          // MakerGen.cs:212
            // 27. SubstanceSpecification.structure.molecularFormulaByMoiety
            public ElementDefinitionInfo Element_MolecularFormulaByMoiety;                                                                  // MakerGen.cs:212
            // 28. SubstanceSpecification.structure.isotope
            public ElementDefinitionInfo Element_Isotope;                                                                                   // MakerGen.cs:212
            // 37. SubstanceSpecification.structure.molecularWeight
            public ElementDefinitionInfo Element_MolecularWeight;                                                                           // MakerGen.cs:212
            // 38. SubstanceSpecification.structure.source
            public ElementDefinitionInfo Element_Source;                                                                                    // MakerGen.cs:212
            // 39. SubstanceSpecification.structure.representation
            public ElementDefinitionInfo Element_Representation;                                                                            // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "SubstanceSpecification.structure",                                                                              // MakerGen.cs:388
                    ElementId = "SubstanceSpecification.structure"                                                                          // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Stereochemistry.Write(sDef);                                                                                        // MakerGen.cs:216
                Element_OpticalActivity.Write(sDef);                                                                                        // MakerGen.cs:216
                Element_MolecularFormula.Write(sDef);                                                                                       // MakerGen.cs:216
                Element_MolecularFormulaByMoiety.Write(sDef);                                                                               // MakerGen.cs:216
                Element_Isotope.Write(sDef);                                                                                                // MakerGen.cs:216
                Element_MolecularWeight.Write(sDef);                                                                                        // MakerGen.cs:216
                Element_Source.Write(sDef);                                                                                                 // MakerGen.cs:216
                Element_Representation.Write(sDef);                                                                                         // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_Structure()                                                                                                         // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 24. SubstanceSpecification.structure.stereochemistry
                    this.Element_Stereochemistry = new ElementDefinitionInfo                                                                // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Stereochemistry",                                                                                   // MakerGen.cs:231
                        Path= "SubstanceSpecification.structure.stereochemistry",                                                           // MakerGen.cs:232
                        Id = "SubstanceSpecification.structure.stereochemistry",                                                            // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 25. SubstanceSpecification.structure.opticalActivity
                    this.Element_OpticalActivity = new ElementDefinitionInfo                                                                // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_OpticalActivity",                                                                                   // MakerGen.cs:231
                        Path= "SubstanceSpecification.structure.opticalActivity",                                                           // MakerGen.cs:232
                        Id = "SubstanceSpecification.structure.opticalActivity",                                                            // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 26. SubstanceSpecification.structure.molecularFormula
                    this.Element_MolecularFormula = new ElementDefinitionInfo                                                               // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_MolecularFormula",                                                                                  // MakerGen.cs:231
                        Path= "SubstanceSpecification.structure.molecularFormula",                                                          // MakerGen.cs:232
                        Id = "SubstanceSpecification.structure.molecularFormula",                                                           // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 27. SubstanceSpecification.structure.molecularFormulaByMoiety
                    this.Element_MolecularFormulaByMoiety = new ElementDefinitionInfo                                                       // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_MolecularFormulaByMoiety",                                                                          // MakerGen.cs:231
                        Path= "SubstanceSpecification.structure.molecularFormulaByMoiety",                                                  // MakerGen.cs:232
                        Id = "SubstanceSpecification.structure.molecularFormulaByMoiety",                                                   // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 28. SubstanceSpecification.structure.isotope
                    this.Element_Isotope = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Isotope",                                                                                           // MakerGen.cs:231
                        Path= "SubstanceSpecification.structure.isotope",                                                                   // MakerGen.cs:232
                        Id = "SubstanceSpecification.structure.isotope",                                                                    // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new Type_Isotope                                                                                                // MakerGen.cs:255
                            {                                                                                                               // MakerGen.cs:256
                            }                                                                                                               // MakerGen.cs:257
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 37. SubstanceSpecification.structure.molecularWeight
                    this.Element_MolecularWeight = new ElementDefinitionInfo                                                                // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_MolecularWeight",                                                                                   // MakerGen.cs:231
                        Path= "SubstanceSpecification.structure.molecularWeight",                                                           // MakerGen.cs:232
                        Id = "SubstanceSpecification.structure.molecularWeight",                                                            // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 38. SubstanceSpecification.structure.source
                    this.Element_Source = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Source",                                                                                            // MakerGen.cs:231
                        Path= "SubstanceSpecification.structure.source",                                                                    // MakerGen.cs:232
                        Id = "SubstanceSpecification.structure.source",                                                                     // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:339
                            {                                                                                                               // MakerGen.cs:340
                                TargetProfile = new String[]                                                                                // MakerGen.cs:342
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/DocumentReference"                                             // MakerGen.cs:342
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:343
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 39. SubstanceSpecification.structure.representation
                    this.Element_Representation = new ElementDefinitionInfo                                                                 // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Representation",                                                                                    // MakerGen.cs:231
                        Path= "SubstanceSpecification.structure.representation",                                                            // MakerGen.cs:232
                        Id = "SubstanceSpecification.structure.representation",                                                             // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new Type_Representation                                                                                         // MakerGen.cs:255
                            {                                                                                                               // MakerGen.cs:256
                            }                                                                                                               // MakerGen.cs:257
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 43. SubstanceSpecification.code
        public class Type_Code : FhirKhit.Maker.Common.Complex.ComplexBase                                                                  // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 44. SubstanceSpecification.code.code
            public ElementDefinitionInfo Element_Code;                                                                                      // MakerGen.cs:212
            // 45. SubstanceSpecification.code.status
            public ElementDefinitionInfo Element_Status;                                                                                    // MakerGen.cs:212
            // 46. SubstanceSpecification.code.statusDate
            public ElementDefinitionInfo Element_StatusDate;                                                                                // MakerGen.cs:212
            // 47. SubstanceSpecification.code.comment
            public ElementDefinitionInfo Element_Comment;                                                                                   // MakerGen.cs:212
            // 48. SubstanceSpecification.code.source
            public ElementDefinitionInfo Element_Source;                                                                                    // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "SubstanceSpecification.code",                                                                                   // MakerGen.cs:388
                    ElementId = "SubstanceSpecification.code"                                                                               // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Code.Write(sDef);                                                                                                   // MakerGen.cs:216
                Element_Status.Write(sDef);                                                                                                 // MakerGen.cs:216
                Element_StatusDate.Write(sDef);                                                                                             // MakerGen.cs:216
                Element_Comment.Write(sDef);                                                                                                // MakerGen.cs:216
                Element_Source.Write(sDef);                                                                                                 // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_Code()                                                                                                              // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 44. SubstanceSpecification.code.code
                    this.Element_Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Code",                                                                                              // MakerGen.cs:231
                        Path= "SubstanceSpecification.code.code",                                                                           // MakerGen.cs:232
                        Id = "SubstanceSpecification.code.code",                                                                            // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 45. SubstanceSpecification.code.status
                    this.Element_Status = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Status",                                                                                            // MakerGen.cs:231
                        Path= "SubstanceSpecification.code.status",                                                                         // MakerGen.cs:232
                        Id = "SubstanceSpecification.code.status",                                                                          // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 46. SubstanceSpecification.code.statusDate
                    this.Element_StatusDate = new ElementDefinitionInfo                                                                     // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_StatusDate",                                                                                        // MakerGen.cs:231
                        Path= "SubstanceSpecification.code.statusDate",                                                                     // MakerGen.cs:232
                        Id = "SubstanceSpecification.code.statusDate",                                                                      // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                          // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 47. SubstanceSpecification.code.comment
                    this.Element_Comment = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Comment",                                                                                           // MakerGen.cs:231
                        Path= "SubstanceSpecification.code.comment",                                                                        // MakerGen.cs:232
                        Id = "SubstanceSpecification.code.comment",                                                                         // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 48. SubstanceSpecification.code.source
                    this.Element_Source = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Source",                                                                                            // MakerGen.cs:231
                        Path= "SubstanceSpecification.code.source",                                                                         // MakerGen.cs:232
                        Id = "SubstanceSpecification.code.source",                                                                          // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:339
                            {                                                                                                               // MakerGen.cs:340
                                TargetProfile = new String[]                                                                                // MakerGen.cs:342
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/DocumentReference"                                             // MakerGen.cs:342
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:343
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 49. SubstanceSpecification.name
        public class Type_Name : FhirKhit.Maker.Common.Complex.ComplexBase                                                                  // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 59. SubstanceSpecification.name.official
            public class Type_Official : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                // 60. SubstanceSpecification.name.official.authority
                public ElementDefinitionInfo Element_Authority;                                                                             // MakerGen.cs:212
                // 61. SubstanceSpecification.name.official.status
                public ElementDefinitionInfo Element_Status;                                                                                // MakerGen.cs:212
                // 62. SubstanceSpecification.name.official.date
                public ElementDefinitionInfo Element_Date;                                                                                  // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:383
                {                                                                                                                           // MakerGen.cs:384
                    base.Write(sDef);                                                                                                       // MakerGen.cs:385
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:386
                    {                                                                                                                       // MakerGen.cs:387
                        Path = "SubstanceSpecification.name.official",                                                                      // MakerGen.cs:388
                        ElementId = "SubstanceSpecification.name.official"                                                                  // MakerGen.cs:389
                    });                                                                                                                     // MakerGen.cs:390
                    Element_Authority.Write(sDef);                                                                                          // MakerGen.cs:216
                    Element_Status.Write(sDef);                                                                                             // MakerGen.cs:216
                    Element_Date.Write(sDef);                                                                                               // MakerGen.cs:216
                }                                                                                                                           // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
                public Type_Official()                                                                                                      // MakerGen.cs:395
                {                                                                                                                           // MakerGen.cs:396
                    {                                                                                                                       // MakerGen.cs:227
                        // 60. SubstanceSpecification.name.official.authority
                        this.Element_Authority = new ElementDefinitionInfo                                                                  // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Authority",                                                                                     // MakerGen.cs:231
                            Path= "SubstanceSpecification.name.official.authority",                                                         // MakerGen.cs:232
                            Id = "SubstanceSpecification.name.official.authority",                                                          // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:311
                                {                                                                                                           // MakerGen.cs:312
                                }                                                                                                           // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 61. SubstanceSpecification.name.official.status
                        this.Element_Status = new ElementDefinitionInfo                                                                     // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Status",                                                                                        // MakerGen.cs:231
                            Path= "SubstanceSpecification.name.official.status",                                                            // MakerGen.cs:232
                            Id = "SubstanceSpecification.name.official.status",                                                             // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:311
                                {                                                                                                           // MakerGen.cs:312
                                }                                                                                                           // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 62. SubstanceSpecification.name.official.date
                        this.Element_Date = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Date",                                                                                          // MakerGen.cs:231
                            Path= "SubstanceSpecification.name.official.date",                                                              // MakerGen.cs:232
                            Id = "SubstanceSpecification.name.official.date",                                                               // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                      // MakerGen.cs:296
                                {                                                                                                           // MakerGen.cs:297
                                }                                                                                                           // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                }                                                                                                                           // MakerGen.cs:398
            }                                                                                                                               // MakerGen.cs:400
            // 50. SubstanceSpecification.name.name
            public ElementDefinitionInfo Element_Name;                                                                                      // MakerGen.cs:212
            // 51. SubstanceSpecification.name.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:212
            // 52. SubstanceSpecification.name.status
            public ElementDefinitionInfo Element_Status;                                                                                    // MakerGen.cs:212
            // 53. SubstanceSpecification.name.preferred
            public ElementDefinitionInfo Element_Preferred;                                                                                 // MakerGen.cs:212
            // 54. SubstanceSpecification.name.language
            public ElementDefinitionInfo Element_Language;                                                                                  // MakerGen.cs:212
            // 55. SubstanceSpecification.name.domain
            public ElementDefinitionInfo Element_Domain;                                                                                    // MakerGen.cs:212
            // 56. SubstanceSpecification.name.jurisdiction
            public ElementDefinitionInfo Element_Jurisdiction;                                                                              // MakerGen.cs:212
            // 57. SubstanceSpecification.name.synonym
            public ElementDefinitionInfo Element_Synonym;                                                                                   // MakerGen.cs:212
            // 58. SubstanceSpecification.name.translation
            public ElementDefinitionInfo Element_Translation;                                                                               // MakerGen.cs:212
            // 59. SubstanceSpecification.name.official
            public ElementDefinitionInfo Element_Official;                                                                                  // MakerGen.cs:212
            // 63. SubstanceSpecification.name.source
            public ElementDefinitionInfo Element_Source;                                                                                    // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "SubstanceSpecification.name",                                                                                   // MakerGen.cs:388
                    ElementId = "SubstanceSpecification.name"                                                                               // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Name.Write(sDef);                                                                                                   // MakerGen.cs:216
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:216
                Element_Status.Write(sDef);                                                                                                 // MakerGen.cs:216
                Element_Preferred.Write(sDef);                                                                                              // MakerGen.cs:216
                Element_Language.Write(sDef);                                                                                               // MakerGen.cs:216
                Element_Domain.Write(sDef);                                                                                                 // MakerGen.cs:216
                Element_Jurisdiction.Write(sDef);                                                                                           // MakerGen.cs:216
                Element_Synonym.Write(sDef);                                                                                                // MakerGen.cs:216
                Element_Translation.Write(sDef);                                                                                            // MakerGen.cs:216
                Element_Official.Write(sDef);                                                                                               // MakerGen.cs:216
                Element_Source.Write(sDef);                                                                                                 // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_Name()                                                                                                              // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 50. SubstanceSpecification.name.name
                    this.Element_Name = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Name",                                                                                              // MakerGen.cs:231
                        Path= "SubstanceSpecification.name.name",                                                                           // MakerGen.cs:232
                        Id = "SubstanceSpecification.name.name",                                                                            // MakerGen.cs:233
                        Min = 1,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 51. SubstanceSpecification.name.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Type",                                                                                              // MakerGen.cs:231
                        Path= "SubstanceSpecification.name.type",                                                                           // MakerGen.cs:232
                        Id = "SubstanceSpecification.name.type",                                                                            // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 52. SubstanceSpecification.name.status
                    this.Element_Status = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Status",                                                                                            // MakerGen.cs:231
                        Path= "SubstanceSpecification.name.status",                                                                         // MakerGen.cs:232
                        Id = "SubstanceSpecification.name.status",                                                                          // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 53. SubstanceSpecification.name.preferred
                    this.Element_Preferred = new ElementDefinitionInfo                                                                      // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Preferred",                                                                                         // MakerGen.cs:231
                        Path= "SubstanceSpecification.name.preferred",                                                                      // MakerGen.cs:232
                        Id = "SubstanceSpecification.name.preferred",                                                                       // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                           // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 54. SubstanceSpecification.name.language
                    this.Element_Language = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Language",                                                                                          // MakerGen.cs:231
                        Path= "SubstanceSpecification.name.language",                                                                       // MakerGen.cs:232
                        Id = "SubstanceSpecification.name.language",                                                                        // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 55. SubstanceSpecification.name.domain
                    this.Element_Domain = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Domain",                                                                                            // MakerGen.cs:231
                        Path= "SubstanceSpecification.name.domain",                                                                         // MakerGen.cs:232
                        Id = "SubstanceSpecification.name.domain",                                                                          // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 56. SubstanceSpecification.name.jurisdiction
                    this.Element_Jurisdiction = new ElementDefinitionInfo                                                                   // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Jurisdiction",                                                                                      // MakerGen.cs:231
                        Path= "SubstanceSpecification.name.jurisdiction",                                                                   // MakerGen.cs:232
                        Id = "SubstanceSpecification.name.jurisdiction",                                                                    // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 57. SubstanceSpecification.name.synonym
                    this.Element_Synonym = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Synonym",                                                                                           // MakerGen.cs:231
                        Path= "SubstanceSpecification.name.synonym",                                                                        // MakerGen.cs:232
                        Id = "SubstanceSpecification.name.synonym",                                                                         // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 58. SubstanceSpecification.name.translation
                    this.Element_Translation = new ElementDefinitionInfo                                                                    // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Translation",                                                                                       // MakerGen.cs:231
                        Path= "SubstanceSpecification.name.translation",                                                                    // MakerGen.cs:232
                        Id = "SubstanceSpecification.name.translation",                                                                     // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 59. SubstanceSpecification.name.official
                    this.Element_Official = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Official",                                                                                          // MakerGen.cs:231
                        Path= "SubstanceSpecification.name.official",                                                                       // MakerGen.cs:232
                        Id = "SubstanceSpecification.name.official",                                                                        // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new Type_Official                                                                                               // MakerGen.cs:255
                            {                                                                                                               // MakerGen.cs:256
                            }                                                                                                               // MakerGen.cs:257
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 63. SubstanceSpecification.name.source
                    this.Element_Source = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Source",                                                                                            // MakerGen.cs:231
                        Path= "SubstanceSpecification.name.source",                                                                         // MakerGen.cs:232
                        Id = "SubstanceSpecification.name.source",                                                                          // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:339
                            {                                                                                                               // MakerGen.cs:340
                                TargetProfile = new String[]                                                                                // MakerGen.cs:342
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/DocumentReference"                                             // MakerGen.cs:342
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:343
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 65. SubstanceSpecification.relationship
        public class Type_Relationship : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 66. SubstanceSpecification.relationship.substance[x]
            public ElementDefinitionInfo Element_Substance;                                                                                 // MakerGen.cs:212
            // 67. SubstanceSpecification.relationship.relationship
            public ElementDefinitionInfo Element_Relationship;                                                                              // MakerGen.cs:212
            // 68. SubstanceSpecification.relationship.isDefining
            public ElementDefinitionInfo Element_IsDefining;                                                                                // MakerGen.cs:212
            // 69. SubstanceSpecification.relationship.amount[x]
            public ElementDefinitionInfo Element_Amount;                                                                                    // MakerGen.cs:212
            // 70. SubstanceSpecification.relationship.amountRatioLowLimit
            public ElementDefinitionInfo Element_AmountRatioLowLimit;                                                                       // MakerGen.cs:212
            // 71. SubstanceSpecification.relationship.amountType
            public ElementDefinitionInfo Element_AmountType;                                                                                // MakerGen.cs:212
            // 72. SubstanceSpecification.relationship.source
            public ElementDefinitionInfo Element_Source;                                                                                    // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "SubstanceSpecification.relationship",                                                                           // MakerGen.cs:388
                    ElementId = "SubstanceSpecification.relationship"                                                                       // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Substance.Write(sDef);                                                                                              // MakerGen.cs:216
                Element_Relationship.Write(sDef);                                                                                           // MakerGen.cs:216
                Element_IsDefining.Write(sDef);                                                                                             // MakerGen.cs:216
                Element_Amount.Write(sDef);                                                                                                 // MakerGen.cs:216
                Element_AmountRatioLowLimit.Write(sDef);                                                                                    // MakerGen.cs:216
                Element_AmountType.Write(sDef);                                                                                             // MakerGen.cs:216
                Element_Source.Write(sDef);                                                                                                 // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_Relationship()                                                                                                      // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 66. SubstanceSpecification.relationship.substance[x]
                    this.Element_Substance = new ElementDefinitionInfo                                                                      // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Substance",                                                                                         // MakerGen.cs:231
                        Path= "SubstanceSpecification.relationship.substance[x]",                                                           // MakerGen.cs:232
                        Id = "SubstanceSpecification.relationship.substance[x]",                                                            // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:339
                            {                                                                                                               // MakerGen.cs:340
                                TargetProfile = new String[]                                                                                // MakerGen.cs:342
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/SubstanceSpecification"                                        // MakerGen.cs:342
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            },                                                                                                              // MakerGen.cs:343
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 67. SubstanceSpecification.relationship.relationship
                    this.Element_Relationship = new ElementDefinitionInfo                                                                   // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Relationship",                                                                                      // MakerGen.cs:231
                        Path= "SubstanceSpecification.relationship.relationship",                                                           // MakerGen.cs:232
                        Id = "SubstanceSpecification.relationship.relationship",                                                            // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 68. SubstanceSpecification.relationship.isDefining
                    this.Element_IsDefining = new ElementDefinitionInfo                                                                     // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_IsDefining",                                                                                        // MakerGen.cs:231
                        Path= "SubstanceSpecification.relationship.isDefining",                                                             // MakerGen.cs:232
                        Id = "SubstanceSpecification.relationship.isDefining",                                                              // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                           // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 69. SubstanceSpecification.relationship.amount[x]
                    this.Element_Amount = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Amount",                                                                                            // MakerGen.cs:231
                        Path= "SubstanceSpecification.relationship.amount[x]",                                                              // MakerGen.cs:232
                        Id = "SubstanceSpecification.relationship.amount[x]",                                                               // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                 // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            },                                                                                                              // MakerGen.cs:353
                            new FhirKhit.Maker.Common.Complex.Type_Range                                                                    // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            },                                                                                                              // MakerGen.cs:353
                            new FhirKhit.Maker.Common.Complex.Type_Ratio                                                                    // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            },                                                                                                              // MakerGen.cs:353
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 70. SubstanceSpecification.relationship.amountRatioLowLimit
                    this.Element_AmountRatioLowLimit = new ElementDefinitionInfo                                                            // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_AmountRatioLowLimit",                                                                               // MakerGen.cs:231
                        Path= "SubstanceSpecification.relationship.amountRatioLowLimit",                                                    // MakerGen.cs:232
                        Id = "SubstanceSpecification.relationship.amountRatioLowLimit",                                                     // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Ratio                                                                    // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            }                                                                                                               // MakerGen.cs:353
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 71. SubstanceSpecification.relationship.amountType
                    this.Element_AmountType = new ElementDefinitionInfo                                                                     // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_AmountType",                                                                                        // MakerGen.cs:231
                        Path= "SubstanceSpecification.relationship.amountType",                                                             // MakerGen.cs:232
                        Id = "SubstanceSpecification.relationship.amountType",                                                              // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 72. SubstanceSpecification.relationship.source
                    this.Element_Source = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Source",                                                                                            // MakerGen.cs:231
                        Path= "SubstanceSpecification.relationship.source",                                                                 // MakerGen.cs:232
                        Id = "SubstanceSpecification.relationship.source",                                                                  // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:339
                            {                                                                                                               // MakerGen.cs:340
                                TargetProfile = new String[]                                                                                // MakerGen.cs:342
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/DocumentReference"                                             // MakerGen.cs:342
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:343
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 1. SubstanceSpecification.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:212
        // 2. SubstanceSpecification.type
        public ElementDefinitionInfo Element_Type;                                                                                          // MakerGen.cs:212
        // 3. SubstanceSpecification.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:212
        // 4. SubstanceSpecification.domain
        public ElementDefinitionInfo Element_Domain;                                                                                        // MakerGen.cs:212
        // 5. SubstanceSpecification.description
        public ElementDefinitionInfo Element_Description;                                                                                   // MakerGen.cs:212
        // 6. SubstanceSpecification.source
        public ElementDefinitionInfo Element_Source;                                                                                        // MakerGen.cs:212
        // 7. SubstanceSpecification.comment
        public ElementDefinitionInfo Element_Comment;                                                                                       // MakerGen.cs:212
        // 8. SubstanceSpecification.moiety
        public ElementDefinitionInfo Element_Moiety;                                                                                        // MakerGen.cs:212
        // 16. SubstanceSpecification.property
        public ElementDefinitionInfo Element_Property;                                                                                      // MakerGen.cs:212
        // 22. SubstanceSpecification.referenceInformation
        public ElementDefinitionInfo Element_ReferenceInformation;                                                                          // MakerGen.cs:212
        // 23. SubstanceSpecification.structure
        public ElementDefinitionInfo Element_Structure;                                                                                     // MakerGen.cs:212
        // 43. SubstanceSpecification.code
        public ElementDefinitionInfo Element_Code;                                                                                          // MakerGen.cs:212
        // 49. SubstanceSpecification.name
        public ElementDefinitionInfo Element_Name;                                                                                          // MakerGen.cs:212
        // 64. SubstanceSpecification.molecularWeight
        public ElementDefinitionInfo Element_MolecularWeight;                                                                               // MakerGen.cs:212
        // 65. SubstanceSpecification.relationship
        public ElementDefinitionInfo Element_Relationship;                                                                                  // MakerGen.cs:212
        // 73. SubstanceSpecification.nucleicAcid
        public ElementDefinitionInfo Element_NucleicAcid;                                                                                   // MakerGen.cs:212
        // 74. SubstanceSpecification.polymer
        public ElementDefinitionInfo Element_Polymer;                                                                                       // MakerGen.cs:212
        // 75. SubstanceSpecification.protein
        public ElementDefinitionInfo Element_Protein;                                                                                       // MakerGen.cs:212
        // 76. SubstanceSpecification.sourceMaterial
        public ElementDefinitionInfo Element_SourceMaterial;                                                                                // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            base.Write(sDef);                                                                                                               // MakerGen.cs:385
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:386
            {                                                                                                                               // MakerGen.cs:387
                Path = "SubstanceSpecification",                                                                                            // MakerGen.cs:388
                ElementId = "SubstanceSpecification"                                                                                        // MakerGen.cs:389
            });                                                                                                                             // MakerGen.cs:390
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_Type.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_Domain.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_Description.Write(sDef);                                                                                                // MakerGen.cs:216
            Element_Source.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_Comment.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Moiety.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_Property.Write(sDef);                                                                                                   // MakerGen.cs:216
            Element_ReferenceInformation.Write(sDef);                                                                                       // MakerGen.cs:216
            Element_Structure.Write(sDef);                                                                                                  // MakerGen.cs:216
            Element_Code.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_Name.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_MolecularWeight.Write(sDef);                                                                                            // MakerGen.cs:216
            Element_Relationship.Write(sDef);                                                                                               // MakerGen.cs:216
            Element_NucleicAcid.Write(sDef);                                                                                                // MakerGen.cs:216
            Element_Polymer.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Protein.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_SourceMaterial.Write(sDef);                                                                                             // MakerGen.cs:216
        }                                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
        public Resource_SubstanceSpecification()                                                                                            // MakerGen.cs:395
        {                                                                                                                                   // MakerGen.cs:396
            {                                                                                                                               // MakerGen.cs:227
                // 1. SubstanceSpecification.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:231
                    Path= "SubstanceSpecification.identifier",                                                                              // MakerGen.cs:232
                    Id = "SubstanceSpecification.identifier",                                                                               // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 2. SubstanceSpecification.type
                this.Element_Type = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Type",                                                                                                  // MakerGen.cs:231
                    Path= "SubstanceSpecification.type",                                                                                    // MakerGen.cs:232
                    Id = "SubstanceSpecification.type",                                                                                     // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 3. SubstanceSpecification.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Status",                                                                                                // MakerGen.cs:231
                    Path= "SubstanceSpecification.status",                                                                                  // MakerGen.cs:232
                    Id = "SubstanceSpecification.status",                                                                                   // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 4. SubstanceSpecification.domain
                this.Element_Domain = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Domain",                                                                                                // MakerGen.cs:231
                    Path= "SubstanceSpecification.domain",                                                                                  // MakerGen.cs:232
                    Id = "SubstanceSpecification.domain",                                                                                   // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 5. SubstanceSpecification.description
                this.Element_Description = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Description",                                                                                           // MakerGen.cs:231
                    Path= "SubstanceSpecification.description",                                                                             // MakerGen.cs:232
                    Id = "SubstanceSpecification.description",                                                                              // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 6. SubstanceSpecification.source
                this.Element_Source = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Source",                                                                                                // MakerGen.cs:231
                    Path= "SubstanceSpecification.source",                                                                                  // MakerGen.cs:232
                    Id = "SubstanceSpecification.source",                                                                                   // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/DocumentReference"                                                 // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 7. SubstanceSpecification.comment
                this.Element_Comment = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Comment",                                                                                               // MakerGen.cs:231
                    Path= "SubstanceSpecification.comment",                                                                                 // MakerGen.cs:232
                    Id = "SubstanceSpecification.comment",                                                                                  // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 8. SubstanceSpecification.moiety
                this.Element_Moiety = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Moiety",                                                                                                // MakerGen.cs:231
                    Path= "SubstanceSpecification.moiety",                                                                                  // MakerGen.cs:232
                    Id = "SubstanceSpecification.moiety",                                                                                   // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_Moiety                                                                                                     // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 16. SubstanceSpecification.property
                this.Element_Property = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Property",                                                                                              // MakerGen.cs:231
                    Path= "SubstanceSpecification.property",                                                                                // MakerGen.cs:232
                    Id = "SubstanceSpecification.property",                                                                                 // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_Property                                                                                                   // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 22. SubstanceSpecification.referenceInformation
                this.Element_ReferenceInformation = new ElementDefinitionInfo                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_ReferenceInformation",                                                                                  // MakerGen.cs:231
                    Path= "SubstanceSpecification.referenceInformation",                                                                    // MakerGen.cs:232
                    Id = "SubstanceSpecification.referenceInformation",                                                                     // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/SubstanceReferenceInformation"                                     // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 23. SubstanceSpecification.structure
                this.Element_Structure = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Structure",                                                                                             // MakerGen.cs:231
                    Path= "SubstanceSpecification.structure",                                                                               // MakerGen.cs:232
                    Id = "SubstanceSpecification.structure",                                                                                // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_Structure                                                                                                  // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 43. SubstanceSpecification.code
                this.Element_Code = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Code",                                                                                                  // MakerGen.cs:231
                    Path= "SubstanceSpecification.code",                                                                                    // MakerGen.cs:232
                    Id = "SubstanceSpecification.code",                                                                                     // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_Code                                                                                                       // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 49. SubstanceSpecification.name
                this.Element_Name = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Name",                                                                                                  // MakerGen.cs:231
                    Path= "SubstanceSpecification.name",                                                                                    // MakerGen.cs:232
                    Id = "SubstanceSpecification.name",                                                                                     // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_Name                                                                                                       // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 64. SubstanceSpecification.molecularWeight
                this.Element_MolecularWeight = new ElementDefinitionInfo                                                                    // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_MolecularWeight",                                                                                       // MakerGen.cs:231
                    Path= "SubstanceSpecification.molecularWeight",                                                                         // MakerGen.cs:232
                    Id = "SubstanceSpecification.molecularWeight",                                                                          // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 65. SubstanceSpecification.relationship
                this.Element_Relationship = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Relationship",                                                                                          // MakerGen.cs:231
                    Path= "SubstanceSpecification.relationship",                                                                            // MakerGen.cs:232
                    Id = "SubstanceSpecification.relationship",                                                                             // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_Relationship                                                                                               // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 73. SubstanceSpecification.nucleicAcid
                this.Element_NucleicAcid = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_NucleicAcid",                                                                                           // MakerGen.cs:231
                    Path= "SubstanceSpecification.nucleicAcid",                                                                             // MakerGen.cs:232
                    Id = "SubstanceSpecification.nucleicAcid",                                                                              // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/SubstanceNucleicAcid"                                              // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 74. SubstanceSpecification.polymer
                this.Element_Polymer = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Polymer",                                                                                               // MakerGen.cs:231
                    Path= "SubstanceSpecification.polymer",                                                                                 // MakerGen.cs:232
                    Id = "SubstanceSpecification.polymer",                                                                                  // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/SubstancePolymer"                                                  // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 75. SubstanceSpecification.protein
                this.Element_Protein = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Protein",                                                                                               // MakerGen.cs:231
                    Path= "SubstanceSpecification.protein",                                                                                 // MakerGen.cs:232
                    Id = "SubstanceSpecification.protein",                                                                                  // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/SubstanceProtein"                                                  // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 76. SubstanceSpecification.sourceMaterial
                this.Element_SourceMaterial = new ElementDefinitionInfo                                                                     // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_SourceMaterial",                                                                                        // MakerGen.cs:231
                    Path= "SubstanceSpecification.sourceMaterial",                                                                          // MakerGen.cs:232
                    Id = "SubstanceSpecification.sourceMaterial",                                                                           // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/SubstanceSourceMaterial"                                           // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            this.Name = "SubstanceSpecification";                                                                                           // MakerGen.cs:458
            this.Uri = "http://hl7.org/fhir/StructureDefinition/SubstanceSpecification";                                                    // MakerGen.cs:459
        }                                                                                                                                   // MakerGen.cs:398
    }                                                                                                                                       // MakerGen.cs:400
}                                                                                                                                           // MakerGen.cs:445
