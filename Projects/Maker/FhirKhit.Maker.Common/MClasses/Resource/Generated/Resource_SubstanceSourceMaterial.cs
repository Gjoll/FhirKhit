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
      "id": "SubstanceSourceMaterial",
      "url": "http://hl7.org/fhir/StructureDefinition/SubstanceSourceMaterial",
      "version": "4.0.0",
      "name": "SubstanceSourceMaterial",
      "status": "draft",
      "publisher": "Health Level Seven International (Biomedical Research and Regulation)",
      "description": "Source material shall capture information on the taxonomic and anatomical origins as well as the fraction of a material that can result in or can be modified to form a substance. This set of data elements shall be used to define polymer substances isolated from biological matrices. Taxonomic and anatomical origins shall be described using a controlled vocabulary as required. This information is captured for naturally derived polymers ( . starch) and structurally diverse substances. For Organisms belonging to the Kingdom Plantae the Substance level defines the fresh material of a single species or infraspecies, the Herbal Drug and the Herbal preparation. For Herbal preparations, the fraction information will be captured at the Substance information level and additional information for herbal extracts will be captured at the Specified Substance Group 1 information level. See for further explanation the Substance Class: Structurally Diverse and the herbal annex.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "SubstanceSourceMaterial",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "SubstanceSourceMaterial",
            "path": "SubstanceSourceMaterial",
            "short": "Source material shall capture information on the taxonomic and anatomical origins as well as the fraction of a material that can result in or can be modified to form a substance. This set of data elements shall be used to define polymer substances isolated from biological matrices. Taxonomic and anatomical origins shall be described using a controlled vocabulary as required. This information is captured for naturally derived polymers ( . starch) and structurally diverse substances. For Organisms belonging to the Kingdom Plantae the Substance level defines the fresh material of a single species or infraspecies, the Herbal Drug and the Herbal preparation. For Herbal preparations, the fraction information will be captured at the Substance information level and additional information for herbal extracts will be captured at the Specified Substance Group 1 information level. See for further explanation the Substance Class: Structurally Diverse and the herbal annex",
            "definition": "Source material shall capture information on the taxonomic and anatomical origins as well as the fraction of a material that can result in or can be modified to form a substance. This set of data elements shall be used to define polymer substances isolated from biological matrices. Taxonomic and anatomical origins shall be described using a controlled vocabulary as required. This information is captured for naturally derived polymers ( . starch) and structurally diverse substances. For Organisms belonging to the Kingdom Plantae the Substance level defines the fresh material of a single species or infraspecies, the Herbal Drug and the Herbal preparation. For Herbal preparations, the fraction information will be captured at the Substance information level and additional information for herbal extracts will be captured at the Specified Substance Group 1 information level. See for further explanation the Substance Class: Structurally Diverse and the herbal annex.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "SubstanceSourceMaterial.sourceMaterialClass",
            "path": "SubstanceSourceMaterial.sourceMaterialClass",
            "short": "General high level classification of the source material specific to the origin of the material",
            "definition": "General high level classification of the source material specific to the origin of the material.",
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
            "id": "SubstanceSourceMaterial.sourceMaterialType",
            "path": "SubstanceSourceMaterial.sourceMaterialType",
            "short": "The type of the source material shall be specified based on a controlled vocabulary. For vaccines, this subclause refers to the class of infectious agent",
            "definition": "The type of the source material shall be specified based on a controlled vocabulary. For vaccines, this subclause refers to the class of infectious agent.",
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
            "id": "SubstanceSourceMaterial.sourceMaterialState",
            "path": "SubstanceSourceMaterial.sourceMaterialState",
            "short": "The state of the source material when extracted",
            "definition": "The state of the source material when extracted.",
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
            "id": "SubstanceSourceMaterial.organismId",
            "path": "SubstanceSourceMaterial.organismId",
            "short": "The unique identifier associated with the source material parent organism shall be specified",
            "definition": "The unique identifier associated with the source material parent organism shall be specified.",
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
            "id": "SubstanceSourceMaterial.organismName",
            "path": "SubstanceSourceMaterial.organismName",
            "short": "The organism accepted Scientific name shall be provided based on the organism taxonomy",
            "definition": "The organism accepted Scientific name shall be provided based on the organism taxonomy.",
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
            "id": "SubstanceSourceMaterial.parentSubstanceId",
            "path": "SubstanceSourceMaterial.parentSubstanceId",
            "short": "The parent of the herbal drug Ginkgo biloba, Leaf is the substance ID of the substance (fresh) of Ginkgo biloba L. or Ginkgo biloba L. (Whole plant)",
            "definition": "The parent of the herbal drug Ginkgo biloba, Leaf is the substance ID of the substance (fresh) of Ginkgo biloba L. or Ginkgo biloba L. (Whole plant).",
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
            "id": "SubstanceSourceMaterial.parentSubstanceName",
            "path": "SubstanceSourceMaterial.parentSubstanceName",
            "short": "The parent substance of the Herbal Drug, or Herbal preparation",
            "definition": "The parent substance of the Herbal Drug, or Herbal preparation.",
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
            "id": "SubstanceSourceMaterial.countryOfOrigin",
            "path": "SubstanceSourceMaterial.countryOfOrigin",
            "short": "The country where the plant material is harvested or the countries where the plasma is sourced from as laid down in accordance with the Plasma Master File. For “Plasma-derived substances” the attribute country of origin provides information about the countries used for the manufacturing of the Cryopoor plama or Crioprecipitate",
            "definition": "The country where the plant material is harvested or the countries where the plasma is sourced from as laid down in accordance with the Plasma Master File. For “Plasma-derived substances” the attribute country of origin provides information about the countries used for the manufacturing of the Cryopoor plama or Crioprecipitate.",
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
            "id": "SubstanceSourceMaterial.geographicalLocation",
            "path": "SubstanceSourceMaterial.geographicalLocation",
            "short": "The place/region where the plant is harvested or the places/regions where the animal source material has its habitat",
            "definition": "The place/region where the plant is harvested or the places/regions where the animal source material has its habitat.",
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
            "id": "SubstanceSourceMaterial.developmentStage",
            "path": "SubstanceSourceMaterial.developmentStage",
            "short": "Stage of life for animals, plants, insects and microorganisms. This information shall be provided only when the substance is significantly different in these stages (e.g. foetal bovine serum)",
            "definition": "Stage of life for animals, plants, insects and microorganisms. This information shall be provided only when the substance is significantly different in these stages (e.g. foetal bovine serum).",
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
            "id": "SubstanceSourceMaterial.fractionDescription",
            "path": "SubstanceSourceMaterial.fractionDescription",
            "short": "Many complex materials are fractions of parts of plants, animals, or minerals. Fraction elements are often necessary to define both Substances and Specified Group 1 Substances. For substances derived from Plants, fraction information will be captured at the Substance information level ( . Oils, Juices and Exudates). Additional information for Extracts, such as extraction solvent composition, will be captured at the Specified Substance Group 1 information level. For plasma-derived products fraction information will be captured at the Substance and the Specified Substance Group 1 levels",
            "definition": "Many complex materials are fractions of parts of plants, animals, or minerals. Fraction elements are often necessary to define both Substances and Specified Group 1 Substances. For substances derived from Plants, fraction information will be captured at the Substance information level ( . Oils, Juices and Exudates). Additional information for Extracts, such as extraction solvent composition, will be captured at the Specified Substance Group 1 information level. For plasma-derived products fraction information will be captured at the Substance and the Specified Substance Group 1 levels.",
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
            "id": "SubstanceSourceMaterial.fractionDescription.fraction",
            "path": "SubstanceSourceMaterial.fractionDescription.fraction",
            "short": "This element is capturing information about the fraction of a plant part, or human plasma for fractionation",
            "definition": "This element is capturing information about the fraction of a plant part, or human plasma for fractionation.",
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
            "id": "SubstanceSourceMaterial.fractionDescription.materialType",
            "path": "SubstanceSourceMaterial.fractionDescription.materialType",
            "short": "The specific type of the material constituting the component. For Herbal preparations the particulars of the extracts (liquid/dry) is described in Specified Substance Group 1",
            "definition": "The specific type of the material constituting the component. For Herbal preparations the particulars of the extracts (liquid/dry) is described in Specified Substance Group 1.",
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
            "id": "SubstanceSourceMaterial.organism",
            "path": "SubstanceSourceMaterial.organism",
            "short": "This subclause describes the organism which the substance is derived from. For vaccines, the parent organism shall be specified based on these subclause elements. As an example, full taxonomy will be described for the Substance Name: ., Leaf",
            "definition": "This subclause describes the organism which the substance is derived from. For vaccines, the parent organism shall be specified based on these subclause elements. As an example, full taxonomy will be described for the Substance Name: ., Leaf.",
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
            "id": "SubstanceSourceMaterial.organism.family",
            "path": "SubstanceSourceMaterial.organism.family",
            "short": "The family of an organism shall be specified",
            "definition": "The family of an organism shall be specified.",
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
            "id": "SubstanceSourceMaterial.organism.genus",
            "path": "SubstanceSourceMaterial.organism.genus",
            "short": "The genus of an organism shall be specified; refers to the Latin epithet of the genus element of the plant/animal scientific name; it is present in names for genera, species and infraspecies",
            "definition": "The genus of an organism shall be specified; refers to the Latin epithet of the genus element of the plant/animal scientific name; it is present in names for genera, species and infraspecies.",
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
            "id": "SubstanceSourceMaterial.organism.species",
            "path": "SubstanceSourceMaterial.organism.species",
            "short": "The species of an organism shall be specified; refers to the Latin epithet of the species of the plant/animal; it is present in names for species and infraspecies",
            "definition": "The species of an organism shall be specified; refers to the Latin epithet of the species of the plant/animal; it is present in names for species and infraspecies.",
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
            "id": "SubstanceSourceMaterial.organism.intraspecificType",
            "path": "SubstanceSourceMaterial.organism.intraspecificType",
            "short": "The Intraspecific type of an organism shall be specified",
            "definition": "The Intraspecific type of an organism shall be specified.",
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
            "id": "SubstanceSourceMaterial.organism.intraspecificDescription",
            "path": "SubstanceSourceMaterial.organism.intraspecificDescription",
            "short": "The intraspecific description of an organism shall be specified based on a controlled vocabulary. For Influenza Vaccine, the intraspecific description shall contain the syntax of the antigen in line with the WHO convention",
            "definition": "The intraspecific description of an organism shall be specified based on a controlled vocabulary. For Influenza Vaccine, the intraspecific description shall contain the syntax of the antigen in line with the WHO convention.",
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
            "id": "SubstanceSourceMaterial.organism.author",
            "path": "SubstanceSourceMaterial.organism.author",
            "short": "4.9.13.6.1 Author type (Conditional)",
            "definition": "4.9.13.6.1 Author type (Conditional).",
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
            "id": "SubstanceSourceMaterial.organism.author.authorType",
            "path": "SubstanceSourceMaterial.organism.author.authorType",
            "short": "The type of author of an organism species shall be specified. The parenthetical author of an organism species refers to the first author who published the plant/animal name (of any rank). The primary author of an organism species refers to the first author(s), who validly published the plant/animal name",
            "definition": "The type of author of an organism species shall be specified. The parenthetical author of an organism species refers to the first author who published the plant/animal name (of any rank). The primary author of an organism species refers to the first author(s), who validly published the plant/animal name.",
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
            "id": "SubstanceSourceMaterial.organism.author.authorDescription",
            "path": "SubstanceSourceMaterial.organism.author.authorDescription",
            "short": "The author of an organism species shall be specified. The author year of an organism shall also be specified when applicable; refers to the year in which the first author(s) published the infraspecific plant/animal name (of any rank)",
            "definition": "The author of an organism species shall be specified. The author year of an organism shall also be specified when applicable; refers to the year in which the first author(s) published the infraspecific plant/animal name (of any rank).",
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
            "id": "SubstanceSourceMaterial.organism.hybrid",
            "path": "SubstanceSourceMaterial.organism.hybrid",
            "short": "4.9.13.8.1 Hybrid species maternal organism ID (Optional)",
            "definition": "4.9.13.8.1 Hybrid species maternal organism ID (Optional).",
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
            "id": "SubstanceSourceMaterial.organism.hybrid.maternalOrganismId",
            "path": "SubstanceSourceMaterial.organism.hybrid.maternalOrganismId",
            "short": "The identifier of the maternal species constituting the hybrid organism shall be specified based on a controlled vocabulary. For plants, the parents aren’t always known, and it is unlikely that it will be known which is maternal and which is paternal",
            "definition": "The identifier of the maternal species constituting the hybrid organism shall be specified based on a controlled vocabulary. For plants, the parents aren’t always known, and it is unlikely that it will be known which is maternal and which is paternal.",
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
            "id": "SubstanceSourceMaterial.organism.hybrid.maternalOrganismName",
            "path": "SubstanceSourceMaterial.organism.hybrid.maternalOrganismName",
            "short": "The name of the maternal species constituting the hybrid organism shall be specified. For plants, the parents aren’t always known, and it is unlikely that it will be known which is maternal and which is paternal",
            "definition": "The name of the maternal species constituting the hybrid organism shall be specified. For plants, the parents aren’t always known, and it is unlikely that it will be known which is maternal and which is paternal.",
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
            "id": "SubstanceSourceMaterial.organism.hybrid.paternalOrganismId",
            "path": "SubstanceSourceMaterial.organism.hybrid.paternalOrganismId",
            "short": "The identifier of the paternal species constituting the hybrid organism shall be specified based on a controlled vocabulary",
            "definition": "The identifier of the paternal species constituting the hybrid organism shall be specified based on a controlled vocabulary.",
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
            "id": "SubstanceSourceMaterial.organism.hybrid.paternalOrganismName",
            "path": "SubstanceSourceMaterial.organism.hybrid.paternalOrganismName",
            "short": "The name of the paternal species constituting the hybrid organism shall be specified",
            "definition": "The name of the paternal species constituting the hybrid organism shall be specified.",
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
            "id": "SubstanceSourceMaterial.organism.hybrid.hybridType",
            "path": "SubstanceSourceMaterial.organism.hybrid.hybridType",
            "short": "The hybrid type of an organism shall be specified",
            "definition": "The hybrid type of an organism shall be specified.",
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
            "id": "SubstanceSourceMaterial.organism.organismGeneral",
            "path": "SubstanceSourceMaterial.organism.organismGeneral",
            "short": "4.9.13.7.1 Kingdom (Conditional)",
            "definition": "4.9.13.7.1 Kingdom (Conditional).",
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
            "id": "SubstanceSourceMaterial.organism.organismGeneral.kingdom",
            "path": "SubstanceSourceMaterial.organism.organismGeneral.kingdom",
            "short": "The kingdom of an organism shall be specified",
            "definition": "The kingdom of an organism shall be specified.",
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
            "id": "SubstanceSourceMaterial.organism.organismGeneral.phylum",
            "path": "SubstanceSourceMaterial.organism.organismGeneral.phylum",
            "short": "The phylum of an organism shall be specified",
            "definition": "The phylum of an organism shall be specified.",
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
            "id": "SubstanceSourceMaterial.organism.organismGeneral.class",
            "path": "SubstanceSourceMaterial.organism.organismGeneral.class",
            "short": "The class of an organism shall be specified",
            "definition": "The class of an organism shall be specified.",
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
            "id": "SubstanceSourceMaterial.organism.organismGeneral.order",
            "path": "SubstanceSourceMaterial.organism.organismGeneral.order",
            "short": "The order of an organism shall be specified,",
            "definition": "The order of an organism shall be specified,.",
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
            "id": "SubstanceSourceMaterial.partDescription",
            "path": "SubstanceSourceMaterial.partDescription",
            "short": "To do",
            "definition": "To do.",
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
            "id": "SubstanceSourceMaterial.partDescription.part",
            "path": "SubstanceSourceMaterial.partDescription.part",
            "short": "Entity of anatomical origin of source material within an organism",
            "definition": "Entity of anatomical origin of source material within an organism.",
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
            "id": "SubstanceSourceMaterial.partDescription.partLocation",
            "path": "SubstanceSourceMaterial.partDescription.partLocation",
            "short": "The detailed anatomic location when the part can be extracted from different anatomical locations of the organism. Multiple alternative locations may apply",
            "definition": "The detailed anatomic location when the part can be extracted from different anatomical locations of the organism. Multiple alternative locations may apply.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
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
    /// Fhir resource 'SubstanceSourceMaterial'
    /// </summary>
    // 0. SubstanceSourceMaterial
    public class Resource_SubstanceSourceMaterial : FhirKhit.Maker.Common.Resource.Resource_DomainResource                                  // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        // 11. SubstanceSourceMaterial.fractionDescription
        public class Type_FractionDescription : FhirKhit.Maker.Common.Complex.ComplexBase                                                   // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 12. SubstanceSourceMaterial.fractionDescription.fraction
            public ElementDefinitionInfo Element_Fraction;                                                                                  // MakerGen.cs:219
            // 13. SubstanceSourceMaterial.fractionDescription.materialType
            public ElementDefinitionInfo Element_MaterialType;                                                                              // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "SubstanceSourceMaterial.fractionDescription",                                                                   // MakerGen.cs:395
                    ElementId = "SubstanceSourceMaterial.fractionDescription"                                                               // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Fraction.Write(sDef);                                                                                               // MakerGen.cs:223
                Element_MaterialType.Write(sDef);                                                                                           // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_FractionDescription()                                                                                               // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 12. SubstanceSourceMaterial.fractionDescription.fraction
                    this.Element_Fraction = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Fraction",                                                                                          // MakerGen.cs:238
                        Path= "SubstanceSourceMaterial.fractionDescription.fraction",                                                       // MakerGen.cs:239
                        Id = "SubstanceSourceMaterial.fractionDescription.fraction",                                                        // MakerGen.cs:240
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
                    // 13. SubstanceSourceMaterial.fractionDescription.materialType
                    this.Element_MaterialType = new ElementDefinitionInfo                                                                   // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_MaterialType",                                                                                      // MakerGen.cs:238
                        Path= "SubstanceSourceMaterial.fractionDescription.materialType",                                                   // MakerGen.cs:239
                        Id = "SubstanceSourceMaterial.fractionDescription.materialType",                                                    // MakerGen.cs:240
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
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 14. SubstanceSourceMaterial.organism
        public class Type_Organism : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 20. SubstanceSourceMaterial.organism.author
            public class Type_Author : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                // 21. SubstanceSourceMaterial.organism.author.authorType
                public ElementDefinitionInfo Element_AuthorType;                                                                            // MakerGen.cs:219
                // 22. SubstanceSourceMaterial.organism.author.authorDescription
                public ElementDefinitionInfo Element_AuthorDescription;                                                                     // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:390
                {                                                                                                                           // MakerGen.cs:391
                    base.Write(sDef);                                                                                                       // MakerGen.cs:392
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        Path = "SubstanceSourceMaterial.organism.author",                                                                   // MakerGen.cs:395
                        ElementId = "SubstanceSourceMaterial.organism.author"                                                               // MakerGen.cs:396
                    });                                                                                                                     // MakerGen.cs:397
                    Element_AuthorType.Write(sDef);                                                                                         // MakerGen.cs:223
                    Element_AuthorDescription.Write(sDef);                                                                                  // MakerGen.cs:223
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
                public Type_Author()                                                                                                        // MakerGen.cs:402
                {                                                                                                                           // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:234
                        // 21. SubstanceSourceMaterial.organism.author.authorType
                        this.Element_AuthorType = new ElementDefinitionInfo                                                                 // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_AuthorType",                                                                                    // MakerGen.cs:238
                            Path= "SubstanceSourceMaterial.organism.author.authorType",                                                     // MakerGen.cs:239
                            Id = "SubstanceSourceMaterial.organism.author.authorType",                                                      // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:318
                                {                                                                                                           // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:322
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 22. SubstanceSourceMaterial.organism.author.authorDescription
                        this.Element_AuthorDescription = new ElementDefinitionInfo                                                          // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_AuthorDescription",                                                                             // MakerGen.cs:238
                            Path= "SubstanceSourceMaterial.organism.author.authorDescription",                                              // MakerGen.cs:239
                            Id = "SubstanceSourceMaterial.organism.author.authorDescription",                                               // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Primitive.Primitive_String                                                        // MakerGen.cs:303
                                {                                                                                                           // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:307
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                }                                                                                                                           // MakerGen.cs:405
            }                                                                                                                               // MakerGen.cs:407
            // 23. SubstanceSourceMaterial.organism.hybrid
            public class Type_Hybrid : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                // 24. SubstanceSourceMaterial.organism.hybrid.maternalOrganismId
                public ElementDefinitionInfo Element_MaternalOrganismId;                                                                    // MakerGen.cs:219
                // 25. SubstanceSourceMaterial.organism.hybrid.maternalOrganismName
                public ElementDefinitionInfo Element_MaternalOrganismName;                                                                  // MakerGen.cs:219
                // 26. SubstanceSourceMaterial.organism.hybrid.paternalOrganismId
                public ElementDefinitionInfo Element_PaternalOrganismId;                                                                    // MakerGen.cs:219
                // 27. SubstanceSourceMaterial.organism.hybrid.paternalOrganismName
                public ElementDefinitionInfo Element_PaternalOrganismName;                                                                  // MakerGen.cs:219
                // 28. SubstanceSourceMaterial.organism.hybrid.hybridType
                public ElementDefinitionInfo Element_HybridType;                                                                            // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:390
                {                                                                                                                           // MakerGen.cs:391
                    base.Write(sDef);                                                                                                       // MakerGen.cs:392
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        Path = "SubstanceSourceMaterial.organism.hybrid",                                                                   // MakerGen.cs:395
                        ElementId = "SubstanceSourceMaterial.organism.hybrid"                                                               // MakerGen.cs:396
                    });                                                                                                                     // MakerGen.cs:397
                    Element_MaternalOrganismId.Write(sDef);                                                                                 // MakerGen.cs:223
                    Element_MaternalOrganismName.Write(sDef);                                                                               // MakerGen.cs:223
                    Element_PaternalOrganismId.Write(sDef);                                                                                 // MakerGen.cs:223
                    Element_PaternalOrganismName.Write(sDef);                                                                               // MakerGen.cs:223
                    Element_HybridType.Write(sDef);                                                                                         // MakerGen.cs:223
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
                public Type_Hybrid()                                                                                                        // MakerGen.cs:402
                {                                                                                                                           // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:234
                        // 24. SubstanceSourceMaterial.organism.hybrid.maternalOrganismId
                        this.Element_MaternalOrganismId = new ElementDefinitionInfo                                                         // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_MaternalOrganismId",                                                                            // MakerGen.cs:238
                            Path= "SubstanceSourceMaterial.organism.hybrid.maternalOrganismId",                                             // MakerGen.cs:239
                            Id = "SubstanceSourceMaterial.organism.hybrid.maternalOrganismId",                                              // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Primitive.Primitive_String                                                        // MakerGen.cs:303
                                {                                                                                                           // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:307
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 25. SubstanceSourceMaterial.organism.hybrid.maternalOrganismName
                        this.Element_MaternalOrganismName = new ElementDefinitionInfo                                                       // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_MaternalOrganismName",                                                                          // MakerGen.cs:238
                            Path= "SubstanceSourceMaterial.organism.hybrid.maternalOrganismName",                                           // MakerGen.cs:239
                            Id = "SubstanceSourceMaterial.organism.hybrid.maternalOrganismName",                                            // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Primitive.Primitive_String                                                        // MakerGen.cs:303
                                {                                                                                                           // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:307
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 26. SubstanceSourceMaterial.organism.hybrid.paternalOrganismId
                        this.Element_PaternalOrganismId = new ElementDefinitionInfo                                                         // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_PaternalOrganismId",                                                                            // MakerGen.cs:238
                            Path= "SubstanceSourceMaterial.organism.hybrid.paternalOrganismId",                                             // MakerGen.cs:239
                            Id = "SubstanceSourceMaterial.organism.hybrid.paternalOrganismId",                                              // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Primitive.Primitive_String                                                        // MakerGen.cs:303
                                {                                                                                                           // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:307
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 27. SubstanceSourceMaterial.organism.hybrid.paternalOrganismName
                        this.Element_PaternalOrganismName = new ElementDefinitionInfo                                                       // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_PaternalOrganismName",                                                                          // MakerGen.cs:238
                            Path= "SubstanceSourceMaterial.organism.hybrid.paternalOrganismName",                                           // MakerGen.cs:239
                            Id = "SubstanceSourceMaterial.organism.hybrid.paternalOrganismName",                                            // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Primitive.Primitive_String                                                        // MakerGen.cs:303
                                {                                                                                                           // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:307
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 28. SubstanceSourceMaterial.organism.hybrid.hybridType
                        this.Element_HybridType = new ElementDefinitionInfo                                                                 // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_HybridType",                                                                                    // MakerGen.cs:238
                            Path= "SubstanceSourceMaterial.organism.hybrid.hybridType",                                                     // MakerGen.cs:239
                            Id = "SubstanceSourceMaterial.organism.hybrid.hybridType",                                                      // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:318
                                {                                                                                                           // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:322
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                }                                                                                                                           // MakerGen.cs:405
            }                                                                                                                               // MakerGen.cs:407
            // 29. SubstanceSourceMaterial.organism.organismGeneral
            public class Type_OrganismGeneral : FhirKhit.Maker.Common.Complex.ComplexBase                                                   // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                // 30. SubstanceSourceMaterial.organism.organismGeneral.kingdom
                public ElementDefinitionInfo Element_Kingdom;                                                                               // MakerGen.cs:219
                // 31. SubstanceSourceMaterial.organism.organismGeneral.phylum
                public ElementDefinitionInfo Element_Phylum;                                                                                // MakerGen.cs:219
                // 32. SubstanceSourceMaterial.organism.organismGeneral.class
                public ElementDefinitionInfo Element_Class;                                                                                 // MakerGen.cs:219
                // 33. SubstanceSourceMaterial.organism.organismGeneral.order
                public ElementDefinitionInfo Element_Order;                                                                                 // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:390
                {                                                                                                                           // MakerGen.cs:391
                    base.Write(sDef);                                                                                                       // MakerGen.cs:392
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        Path = "SubstanceSourceMaterial.organism.organismGeneral",                                                          // MakerGen.cs:395
                        ElementId = "SubstanceSourceMaterial.organism.organismGeneral"                                                      // MakerGen.cs:396
                    });                                                                                                                     // MakerGen.cs:397
                    Element_Kingdom.Write(sDef);                                                                                            // MakerGen.cs:223
                    Element_Phylum.Write(sDef);                                                                                             // MakerGen.cs:223
                    Element_Class.Write(sDef);                                                                                              // MakerGen.cs:223
                    Element_Order.Write(sDef);                                                                                              // MakerGen.cs:223
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
                public Type_OrganismGeneral()                                                                                               // MakerGen.cs:402
                {                                                                                                                           // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:234
                        // 30. SubstanceSourceMaterial.organism.organismGeneral.kingdom
                        this.Element_Kingdom = new ElementDefinitionInfo                                                                    // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Kingdom",                                                                                       // MakerGen.cs:238
                            Path= "SubstanceSourceMaterial.organism.organismGeneral.kingdom",                                               // MakerGen.cs:239
                            Id = "SubstanceSourceMaterial.organism.organismGeneral.kingdom",                                                // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:318
                                {                                                                                                           // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:322
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 31. SubstanceSourceMaterial.organism.organismGeneral.phylum
                        this.Element_Phylum = new ElementDefinitionInfo                                                                     // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Phylum",                                                                                        // MakerGen.cs:238
                            Path= "SubstanceSourceMaterial.organism.organismGeneral.phylum",                                                // MakerGen.cs:239
                            Id = "SubstanceSourceMaterial.organism.organismGeneral.phylum",                                                 // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:318
                                {                                                                                                           // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:322
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 32. SubstanceSourceMaterial.organism.organismGeneral.class
                        this.Element_Class = new ElementDefinitionInfo                                                                      // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Class",                                                                                         // MakerGen.cs:238
                            Path= "SubstanceSourceMaterial.organism.organismGeneral.class",                                                 // MakerGen.cs:239
                            Id = "SubstanceSourceMaterial.organism.organismGeneral.class",                                                  // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:318
                                {                                                                                                           // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:322
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 33. SubstanceSourceMaterial.organism.organismGeneral.order
                        this.Element_Order = new ElementDefinitionInfo                                                                      // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Order",                                                                                         // MakerGen.cs:238
                            Path= "SubstanceSourceMaterial.organism.organismGeneral.order",                                                 // MakerGen.cs:239
                            Id = "SubstanceSourceMaterial.organism.organismGeneral.order",                                                  // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:318
                                {                                                                                                           // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:322
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                }                                                                                                                           // MakerGen.cs:405
            }                                                                                                                               // MakerGen.cs:407
            // 15. SubstanceSourceMaterial.organism.family
            public ElementDefinitionInfo Element_Family;                                                                                    // MakerGen.cs:219
            // 16. SubstanceSourceMaterial.organism.genus
            public ElementDefinitionInfo Element_Genus;                                                                                     // MakerGen.cs:219
            // 17. SubstanceSourceMaterial.organism.species
            public ElementDefinitionInfo Element_Species;                                                                                   // MakerGen.cs:219
            // 18. SubstanceSourceMaterial.organism.intraspecificType
            public ElementDefinitionInfo Element_IntraspecificType;                                                                         // MakerGen.cs:219
            // 19. SubstanceSourceMaterial.organism.intraspecificDescription
            public ElementDefinitionInfo Element_IntraspecificDescription;                                                                  // MakerGen.cs:219
            // 20. SubstanceSourceMaterial.organism.author
            public ElementDefinitionInfo Element_Author;                                                                                    // MakerGen.cs:219
            // 23. SubstanceSourceMaterial.organism.hybrid
            public ElementDefinitionInfo Element_Hybrid;                                                                                    // MakerGen.cs:219
            // 29. SubstanceSourceMaterial.organism.organismGeneral
            public ElementDefinitionInfo Element_OrganismGeneral;                                                                           // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "SubstanceSourceMaterial.organism",                                                                              // MakerGen.cs:395
                    ElementId = "SubstanceSourceMaterial.organism"                                                                          // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Family.Write(sDef);                                                                                                 // MakerGen.cs:223
                Element_Genus.Write(sDef);                                                                                                  // MakerGen.cs:223
                Element_Species.Write(sDef);                                                                                                // MakerGen.cs:223
                Element_IntraspecificType.Write(sDef);                                                                                      // MakerGen.cs:223
                Element_IntraspecificDescription.Write(sDef);                                                                               // MakerGen.cs:223
                Element_Author.Write(sDef);                                                                                                 // MakerGen.cs:223
                Element_Hybrid.Write(sDef);                                                                                                 // MakerGen.cs:223
                Element_OrganismGeneral.Write(sDef);                                                                                        // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_Organism()                                                                                                          // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 15. SubstanceSourceMaterial.organism.family
                    this.Element_Family = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Family",                                                                                            // MakerGen.cs:238
                        Path= "SubstanceSourceMaterial.organism.family",                                                                    // MakerGen.cs:239
                        Id = "SubstanceSourceMaterial.organism.family",                                                                     // MakerGen.cs:240
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
                    // 16. SubstanceSourceMaterial.organism.genus
                    this.Element_Genus = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Genus",                                                                                             // MakerGen.cs:238
                        Path= "SubstanceSourceMaterial.organism.genus",                                                                     // MakerGen.cs:239
                        Id = "SubstanceSourceMaterial.organism.genus",                                                                      // MakerGen.cs:240
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
                    // 17. SubstanceSourceMaterial.organism.species
                    this.Element_Species = new ElementDefinitionInfo                                                                        // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Species",                                                                                           // MakerGen.cs:238
                        Path= "SubstanceSourceMaterial.organism.species",                                                                   // MakerGen.cs:239
                        Id = "SubstanceSourceMaterial.organism.species",                                                                    // MakerGen.cs:240
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
                    // 18. SubstanceSourceMaterial.organism.intraspecificType
                    this.Element_IntraspecificType = new ElementDefinitionInfo                                                              // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_IntraspecificType",                                                                                 // MakerGen.cs:238
                        Path= "SubstanceSourceMaterial.organism.intraspecificType",                                                         // MakerGen.cs:239
                        Id = "SubstanceSourceMaterial.organism.intraspecificType",                                                          // MakerGen.cs:240
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
                    // 19. SubstanceSourceMaterial.organism.intraspecificDescription
                    this.Element_IntraspecificDescription = new ElementDefinitionInfo                                                       // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_IntraspecificDescription",                                                                          // MakerGen.cs:238
                        Path= "SubstanceSourceMaterial.organism.intraspecificDescription",                                                  // MakerGen.cs:239
                        Id = "SubstanceSourceMaterial.organism.intraspecificDescription",                                                   // MakerGen.cs:240
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
                    // 20. SubstanceSourceMaterial.organism.author
                    this.Element_Author = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Author",                                                                                            // MakerGen.cs:238
                        Path= "SubstanceSourceMaterial.organism.author",                                                                    // MakerGen.cs:239
                        Id = "SubstanceSourceMaterial.organism.author",                                                                     // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new Type_Author                                                                                                 // MakerGen.cs:262
                            {                                                                                                               // MakerGen.cs:263
                            }                                                                                                               // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 23. SubstanceSourceMaterial.organism.hybrid
                    this.Element_Hybrid = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Hybrid",                                                                                            // MakerGen.cs:238
                        Path= "SubstanceSourceMaterial.organism.hybrid",                                                                    // MakerGen.cs:239
                        Id = "SubstanceSourceMaterial.organism.hybrid",                                                                     // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new Type_Hybrid                                                                                                 // MakerGen.cs:262
                            {                                                                                                               // MakerGen.cs:263
                            }                                                                                                               // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 29. SubstanceSourceMaterial.organism.organismGeneral
                    this.Element_OrganismGeneral = new ElementDefinitionInfo                                                                // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_OrganismGeneral",                                                                                   // MakerGen.cs:238
                        Path= "SubstanceSourceMaterial.organism.organismGeneral",                                                           // MakerGen.cs:239
                        Id = "SubstanceSourceMaterial.organism.organismGeneral",                                                            // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new Type_OrganismGeneral                                                                                        // MakerGen.cs:262
                            {                                                                                                               // MakerGen.cs:263
                            }                                                                                                               // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 34. SubstanceSourceMaterial.partDescription
        public class Type_PartDescription : FhirKhit.Maker.Common.Complex.ComplexBase                                                       // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 35. SubstanceSourceMaterial.partDescription.part
            public ElementDefinitionInfo Element_Part;                                                                                      // MakerGen.cs:219
            // 36. SubstanceSourceMaterial.partDescription.partLocation
            public ElementDefinitionInfo Element_PartLocation;                                                                              // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "SubstanceSourceMaterial.partDescription",                                                                       // MakerGen.cs:395
                    ElementId = "SubstanceSourceMaterial.partDescription"                                                                   // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Part.Write(sDef);                                                                                                   // MakerGen.cs:223
                Element_PartLocation.Write(sDef);                                                                                           // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_PartDescription()                                                                                                   // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 35. SubstanceSourceMaterial.partDescription.part
                    this.Element_Part = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Part",                                                                                              // MakerGen.cs:238
                        Path= "SubstanceSourceMaterial.partDescription.part",                                                               // MakerGen.cs:239
                        Id = "SubstanceSourceMaterial.partDescription.part",                                                                // MakerGen.cs:240
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
                    // 36. SubstanceSourceMaterial.partDescription.partLocation
                    this.Element_PartLocation = new ElementDefinitionInfo                                                                   // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_PartLocation",                                                                                      // MakerGen.cs:238
                        Path= "SubstanceSourceMaterial.partDescription.partLocation",                                                       // MakerGen.cs:239
                        Id = "SubstanceSourceMaterial.partDescription.partLocation",                                                        // MakerGen.cs:240
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
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 1. SubstanceSourceMaterial.sourceMaterialClass
        public ElementDefinitionInfo Element_SourceMaterialClass;                                                                           // MakerGen.cs:219
        // 2. SubstanceSourceMaterial.sourceMaterialType
        public ElementDefinitionInfo Element_SourceMaterialType;                                                                            // MakerGen.cs:219
        // 3. SubstanceSourceMaterial.sourceMaterialState
        public ElementDefinitionInfo Element_SourceMaterialState;                                                                           // MakerGen.cs:219
        // 4. SubstanceSourceMaterial.organismId
        public ElementDefinitionInfo Element_OrganismId;                                                                                    // MakerGen.cs:219
        // 5. SubstanceSourceMaterial.organismName
        public ElementDefinitionInfo Element_OrganismName;                                                                                  // MakerGen.cs:219
        // 6. SubstanceSourceMaterial.parentSubstanceId
        public ElementDefinitionInfo Element_ParentSubstanceId;                                                                             // MakerGen.cs:219
        // 7. SubstanceSourceMaterial.parentSubstanceName
        public ElementDefinitionInfo Element_ParentSubstanceName;                                                                           // MakerGen.cs:219
        // 8. SubstanceSourceMaterial.countryOfOrigin
        public ElementDefinitionInfo Element_CountryOfOrigin;                                                                               // MakerGen.cs:219
        // 9. SubstanceSourceMaterial.geographicalLocation
        public ElementDefinitionInfo Element_GeographicalLocation;                                                                          // MakerGen.cs:219
        // 10. SubstanceSourceMaterial.developmentStage
        public ElementDefinitionInfo Element_DevelopmentStage;                                                                              // MakerGen.cs:219
        // 11. SubstanceSourceMaterial.fractionDescription
        public ElementDefinitionInfo Element_FractionDescription;                                                                           // MakerGen.cs:219
        // 14. SubstanceSourceMaterial.organism
        public ElementDefinitionInfo Element_Organism;                                                                                      // MakerGen.cs:219
        // 34. SubstanceSourceMaterial.partDescription
        public ElementDefinitionInfo Element_PartDescription;                                                                               // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:390
        {                                                                                                                                   // MakerGen.cs:391
            base.Write(sDef);                                                                                                               // MakerGen.cs:392
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                Path = "SubstanceSourceMaterial",                                                                                           // MakerGen.cs:395
                ElementId = "SubstanceSourceMaterial"                                                                                       // MakerGen.cs:396
            });                                                                                                                             // MakerGen.cs:397
            Element_SourceMaterialClass.Write(sDef);                                                                                        // MakerGen.cs:223
            Element_SourceMaterialType.Write(sDef);                                                                                         // MakerGen.cs:223
            Element_SourceMaterialState.Write(sDef);                                                                                        // MakerGen.cs:223
            Element_OrganismId.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_OrganismName.Write(sDef);                                                                                               // MakerGen.cs:223
            Element_ParentSubstanceId.Write(sDef);                                                                                          // MakerGen.cs:223
            Element_ParentSubstanceName.Write(sDef);                                                                                        // MakerGen.cs:223
            Element_CountryOfOrigin.Write(sDef);                                                                                            // MakerGen.cs:223
            Element_GeographicalLocation.Write(sDef);                                                                                       // MakerGen.cs:223
            Element_DevelopmentStage.Write(sDef);                                                                                           // MakerGen.cs:223
            Element_FractionDescription.Write(sDef);                                                                                        // MakerGen.cs:223
            Element_Organism.Write(sDef);                                                                                                   // MakerGen.cs:223
            Element_PartDescription.Write(sDef);                                                                                            // MakerGen.cs:223
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
        public Resource_SubstanceSourceMaterial()                                                                                           // MakerGen.cs:402
        {                                                                                                                                   // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:234
                // 1. SubstanceSourceMaterial.sourceMaterialClass
                this.Element_SourceMaterialClass = new ElementDefinitionInfo                                                                // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_SourceMaterialClass",                                                                                   // MakerGen.cs:238
                    Path= "SubstanceSourceMaterial.sourceMaterialClass",                                                                    // MakerGen.cs:239
                    Id = "SubstanceSourceMaterial.sourceMaterialClass",                                                                     // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 2. SubstanceSourceMaterial.sourceMaterialType
                this.Element_SourceMaterialType = new ElementDefinitionInfo                                                                 // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_SourceMaterialType",                                                                                    // MakerGen.cs:238
                    Path= "SubstanceSourceMaterial.sourceMaterialType",                                                                     // MakerGen.cs:239
                    Id = "SubstanceSourceMaterial.sourceMaterialType",                                                                      // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 3. SubstanceSourceMaterial.sourceMaterialState
                this.Element_SourceMaterialState = new ElementDefinitionInfo                                                                // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_SourceMaterialState",                                                                                   // MakerGen.cs:238
                    Path= "SubstanceSourceMaterial.sourceMaterialState",                                                                    // MakerGen.cs:239
                    Id = "SubstanceSourceMaterial.sourceMaterialState",                                                                     // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 4. SubstanceSourceMaterial.organismId
                this.Element_OrganismId = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_OrganismId",                                                                                            // MakerGen.cs:238
                    Path= "SubstanceSourceMaterial.organismId",                                                                             // MakerGen.cs:239
                    Id = "SubstanceSourceMaterial.organismId",                                                                              // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 5. SubstanceSourceMaterial.organismName
                this.Element_OrganismName = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_OrganismName",                                                                                          // MakerGen.cs:238
                    Path= "SubstanceSourceMaterial.organismName",                                                                           // MakerGen.cs:239
                    Id = "SubstanceSourceMaterial.organismName",                                                                            // MakerGen.cs:240
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
                // 6. SubstanceSourceMaterial.parentSubstanceId
                this.Element_ParentSubstanceId = new ElementDefinitionInfo                                                                  // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_ParentSubstanceId",                                                                                     // MakerGen.cs:238
                    Path= "SubstanceSourceMaterial.parentSubstanceId",                                                                      // MakerGen.cs:239
                    Id = "SubstanceSourceMaterial.parentSubstanceId",                                                                       // MakerGen.cs:240
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
                // 7. SubstanceSourceMaterial.parentSubstanceName
                this.Element_ParentSubstanceName = new ElementDefinitionInfo                                                                // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_ParentSubstanceName",                                                                                   // MakerGen.cs:238
                    Path= "SubstanceSourceMaterial.parentSubstanceName",                                                                    // MakerGen.cs:239
                    Id = "SubstanceSourceMaterial.parentSubstanceName",                                                                     // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 8. SubstanceSourceMaterial.countryOfOrigin
                this.Element_CountryOfOrigin = new ElementDefinitionInfo                                                                    // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_CountryOfOrigin",                                                                                       // MakerGen.cs:238
                    Path= "SubstanceSourceMaterial.countryOfOrigin",                                                                        // MakerGen.cs:239
                    Id = "SubstanceSourceMaterial.countryOfOrigin",                                                                         // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 9. SubstanceSourceMaterial.geographicalLocation
                this.Element_GeographicalLocation = new ElementDefinitionInfo                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_GeographicalLocation",                                                                                  // MakerGen.cs:238
                    Path= "SubstanceSourceMaterial.geographicalLocation",                                                                   // MakerGen.cs:239
                    Id = "SubstanceSourceMaterial.geographicalLocation",                                                                    // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 10. SubstanceSourceMaterial.developmentStage
                this.Element_DevelopmentStage = new ElementDefinitionInfo                                                                   // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_DevelopmentStage",                                                                                      // MakerGen.cs:238
                    Path= "SubstanceSourceMaterial.developmentStage",                                                                       // MakerGen.cs:239
                    Id = "SubstanceSourceMaterial.developmentStage",                                                                        // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 11. SubstanceSourceMaterial.fractionDescription
                this.Element_FractionDescription = new ElementDefinitionInfo                                                                // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_FractionDescription",                                                                                   // MakerGen.cs:238
                    Path= "SubstanceSourceMaterial.fractionDescription",                                                                    // MakerGen.cs:239
                    Id = "SubstanceSourceMaterial.fractionDescription",                                                                     // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_FractionDescription                                                                                        // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 14. SubstanceSourceMaterial.organism
                this.Element_Organism = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Organism",                                                                                              // MakerGen.cs:238
                    Path= "SubstanceSourceMaterial.organism",                                                                               // MakerGen.cs:239
                    Id = "SubstanceSourceMaterial.organism",                                                                                // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_Organism                                                                                                   // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 34. SubstanceSourceMaterial.partDescription
                this.Element_PartDescription = new ElementDefinitionInfo                                                                    // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_PartDescription",                                                                                       // MakerGen.cs:238
                    Path= "SubstanceSourceMaterial.partDescription",                                                                        // MakerGen.cs:239
                    Id = "SubstanceSourceMaterial.partDescription",                                                                         // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_PartDescription                                                                                            // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            this.Name = "SubstanceSourceMaterial";                                                                                          // MakerGen.cs:471
            this.Uri = "http://hl7.org/fhir/StructureDefinition/SubstanceSourceMaterial";                                                   // MakerGen.cs:472
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:407
}                                                                                                                                           // MakerGen.cs:452
