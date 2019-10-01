using System;                                                                                                                               // MakerGen.cs:449
using System.Diagnostics;                                                                                                                   // MakerGen.cs:450
using System.IO;                                                                                                                            // MakerGen.cs:451
using System.Linq;                                                                                                                          // MakerGen.cs:452
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:453
                                                                                                                                            // MakerGen.cs:454
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:455
{                                                                                                                                           // MakerGen.cs:456
    #region Json                                                                                                                            // MakerGen.cs:457
    #if NEVER                                                                                                                               // MakerGen.cs:458
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
    #endregion                                                                                                                              // MakerGen.cs:461
    /// <summary>
    /// Fhir resource 'SubstanceSourceMaterial'
    /// </summary>
    // 0. SubstanceSourceMaterial
    public class SubstanceSourceMaterial : FhirKhit.Maker.Common.Resource.ResourceBase                                                      // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        public class SubstanceSourceMaterial_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                         // MakerGen.cs:385
        {                                                                                                                                   // MakerGen.cs:386
            // 11. SubstanceSourceMaterial.fractionDescription
            public class Type_FractionDescription : FhirKhit.Maker.Common.Complex.ComplexBase                                               // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_FractionDescription_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 12. SubstanceSourceMaterial.fractionDescription.fraction
                    public ElementDefinitionInfo Fraction;                                                                                  // MakerGen.cs:216
                    // 13. SubstanceSourceMaterial.fractionDescription.materialType
                    public ElementDefinitionInfo MaterialType;                                                                              // MakerGen.cs:216
                    public Type_FractionDescription_Elements()                                                                              // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 12. SubstanceSourceMaterial.fractionDescription.fraction
                            this.Fraction = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Fraction",                                                                                          // MakerGen.cs:235
                                Path= "SubstanceSourceMaterial.fractionDescription.fraction",                                               // MakerGen.cs:236
                                Id = "SubstanceSourceMaterial.fractionDescription.fraction",                                                // MakerGen.cs:237
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
                            // 13. SubstanceSourceMaterial.fractionDescription.materialType
                            this.MaterialType = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "MaterialType",                                                                                      // MakerGen.cs:235
                                Path= "SubstanceSourceMaterial.fractionDescription.materialType",                                           // MakerGen.cs:236
                                Id = "SubstanceSourceMaterial.fractionDescription.materialType",                                            // MakerGen.cs:237
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
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        Fraction.Write(sDef);                                                                                               // MakerGen.cs:220
                        MaterialType.Write(sDef);                                                                                           // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_FractionDescription_Elements Elements { get; }                                                                  // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_FractionDescription()                                                                                           // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_FractionDescription_Elements();                                                                // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 14. SubstanceSourceMaterial.organism
            public class Type_Organism : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_Organism_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                           // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 20. SubstanceSourceMaterial.organism.author
                    public class Type_Author : FhirKhit.Maker.Common.Complex.ComplexBase                                                    // MakerGen.cs:383
                    {                                                                                                                       // MakerGen.cs:384
                        public class Type_Author_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                     // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:386
                            // 21. SubstanceSourceMaterial.organism.author.authorType
                            public ElementDefinitionInfo AuthorType;                                                                        // MakerGen.cs:216
                            // 22. SubstanceSourceMaterial.organism.author.authorDescription
                            public ElementDefinitionInfo AuthorDescription;                                                                 // MakerGen.cs:216
                            public Type_Author_Elements()                                                                                   // MakerGen.cs:407
                            {                                                                                                               // MakerGen.cs:408
                                {                                                                                                           // MakerGen.cs:231
                                    // 21. SubstanceSourceMaterial.organism.author.authorType
                                    this.AuthorType = new ElementDefinitionInfo                                                             // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "AuthorType",                                                                                // MakerGen.cs:235
                                        Path= "SubstanceSourceMaterial.organism.author.authorType",                                         // MakerGen.cs:236
                                        Id = "SubstanceSourceMaterial.organism.author.authorType",                                          // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:315
                                            {                                                                                               // MakerGen.cs:316
                                            }                                                                                               // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 22. SubstanceSourceMaterial.organism.author.authorDescription
                                    this.AuthorDescription = new ElementDefinitionInfo                                                      // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "AuthorDescription",                                                                         // MakerGen.cs:235
                                        Path= "SubstanceSourceMaterial.organism.author.authorDescription",                                  // MakerGen.cs:236
                                        Id = "SubstanceSourceMaterial.organism.author.authorDescription",                                   // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                            }                                                                                                               // MakerGen.cs:427
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:412
                            {                                                                                                               // MakerGen.cs:413
                                base.Write(sDef);                                                                                           // MakerGen.cs:414
                                AuthorType.Write(sDef);                                                                                     // MakerGen.cs:220
                                AuthorDescription.Write(sDef);                                                                              // MakerGen.cs:220
                            }                                                                                                               // MakerGen.cs:431
                        }                                                                                                                   // MakerGen.cs:391
                        public Type_Author_Elements Elements { get; }                                                                       // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                        public Type_Author()                                                                                                // MakerGen.cs:394
                        {                                                                                                                   // MakerGen.cs:395
                            this.Elements = new Type_Author_Elements();                                                                     // MakerGen.cs:396
                        }                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:399
                        {                                                                                                                   // MakerGen.cs:400
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:401
                        }                                                                                                                   // MakerGen.cs:402
                    }                                                                                                                       // MakerGen.cs:403
                    // 23. SubstanceSourceMaterial.organism.hybrid
                    public class Type_Hybrid : FhirKhit.Maker.Common.Complex.ComplexBase                                                    // MakerGen.cs:383
                    {                                                                                                                       // MakerGen.cs:384
                        public class Type_Hybrid_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                     // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:386
                            // 24. SubstanceSourceMaterial.organism.hybrid.maternalOrganismId
                            public ElementDefinitionInfo MaternalOrganismId;                                                                // MakerGen.cs:216
                            // 25. SubstanceSourceMaterial.organism.hybrid.maternalOrganismName
                            public ElementDefinitionInfo MaternalOrganismName;                                                              // MakerGen.cs:216
                            // 26. SubstanceSourceMaterial.organism.hybrid.paternalOrganismId
                            public ElementDefinitionInfo PaternalOrganismId;                                                                // MakerGen.cs:216
                            // 27. SubstanceSourceMaterial.organism.hybrid.paternalOrganismName
                            public ElementDefinitionInfo PaternalOrganismName;                                                              // MakerGen.cs:216
                            // 28. SubstanceSourceMaterial.organism.hybrid.hybridType
                            public ElementDefinitionInfo HybridType;                                                                        // MakerGen.cs:216
                            public Type_Hybrid_Elements()                                                                                   // MakerGen.cs:407
                            {                                                                                                               // MakerGen.cs:408
                                {                                                                                                           // MakerGen.cs:231
                                    // 24. SubstanceSourceMaterial.organism.hybrid.maternalOrganismId
                                    this.MaternalOrganismId = new ElementDefinitionInfo                                                     // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "MaternalOrganismId",                                                                        // MakerGen.cs:235
                                        Path= "SubstanceSourceMaterial.organism.hybrid.maternalOrganismId",                                 // MakerGen.cs:236
                                        Id = "SubstanceSourceMaterial.organism.hybrid.maternalOrganismId",                                  // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 25. SubstanceSourceMaterial.organism.hybrid.maternalOrganismName
                                    this.MaternalOrganismName = new ElementDefinitionInfo                                                   // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "MaternalOrganismName",                                                                      // MakerGen.cs:235
                                        Path= "SubstanceSourceMaterial.organism.hybrid.maternalOrganismName",                               // MakerGen.cs:236
                                        Id = "SubstanceSourceMaterial.organism.hybrid.maternalOrganismName",                                // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 26. SubstanceSourceMaterial.organism.hybrid.paternalOrganismId
                                    this.PaternalOrganismId = new ElementDefinitionInfo                                                     // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "PaternalOrganismId",                                                                        // MakerGen.cs:235
                                        Path= "SubstanceSourceMaterial.organism.hybrid.paternalOrganismId",                                 // MakerGen.cs:236
                                        Id = "SubstanceSourceMaterial.organism.hybrid.paternalOrganismId",                                  // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 27. SubstanceSourceMaterial.organism.hybrid.paternalOrganismName
                                    this.PaternalOrganismName = new ElementDefinitionInfo                                                   // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "PaternalOrganismName",                                                                      // MakerGen.cs:235
                                        Path= "SubstanceSourceMaterial.organism.hybrid.paternalOrganismName",                               // MakerGen.cs:236
                                        Id = "SubstanceSourceMaterial.organism.hybrid.paternalOrganismName",                                // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 28. SubstanceSourceMaterial.organism.hybrid.hybridType
                                    this.HybridType = new ElementDefinitionInfo                                                             // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "HybridType",                                                                                // MakerGen.cs:235
                                        Path= "SubstanceSourceMaterial.organism.hybrid.hybridType",                                         // MakerGen.cs:236
                                        Id = "SubstanceSourceMaterial.organism.hybrid.hybridType",                                          // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:315
                                            {                                                                                               // MakerGen.cs:316
                                            }                                                                                               // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                            }                                                                                                               // MakerGen.cs:427
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:412
                            {                                                                                                               // MakerGen.cs:413
                                base.Write(sDef);                                                                                           // MakerGen.cs:414
                                MaternalOrganismId.Write(sDef);                                                                             // MakerGen.cs:220
                                MaternalOrganismName.Write(sDef);                                                                           // MakerGen.cs:220
                                PaternalOrganismId.Write(sDef);                                                                             // MakerGen.cs:220
                                PaternalOrganismName.Write(sDef);                                                                           // MakerGen.cs:220
                                HybridType.Write(sDef);                                                                                     // MakerGen.cs:220
                            }                                                                                                               // MakerGen.cs:431
                        }                                                                                                                   // MakerGen.cs:391
                        public Type_Hybrid_Elements Elements { get; }                                                                       // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                        public Type_Hybrid()                                                                                                // MakerGen.cs:394
                        {                                                                                                                   // MakerGen.cs:395
                            this.Elements = new Type_Hybrid_Elements();                                                                     // MakerGen.cs:396
                        }                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:399
                        {                                                                                                                   // MakerGen.cs:400
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:401
                        }                                                                                                                   // MakerGen.cs:402
                    }                                                                                                                       // MakerGen.cs:403
                    // 29. SubstanceSourceMaterial.organism.organismGeneral
                    public class Type_OrganismGeneral : FhirKhit.Maker.Common.Complex.ComplexBase                                           // MakerGen.cs:383
                    {                                                                                                                       // MakerGen.cs:384
                        public class Type_OrganismGeneral_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                            // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:386
                            // 30. SubstanceSourceMaterial.organism.organismGeneral.kingdom
                            public ElementDefinitionInfo Kingdom;                                                                           // MakerGen.cs:216
                            // 31. SubstanceSourceMaterial.organism.organismGeneral.phylum
                            public ElementDefinitionInfo Phylum;                                                                            // MakerGen.cs:216
                            // 32. SubstanceSourceMaterial.organism.organismGeneral.class
                            public ElementDefinitionInfo Class;                                                                             // MakerGen.cs:216
                            // 33. SubstanceSourceMaterial.organism.organismGeneral.order
                            public ElementDefinitionInfo Order;                                                                             // MakerGen.cs:216
                            public Type_OrganismGeneral_Elements()                                                                          // MakerGen.cs:407
                            {                                                                                                               // MakerGen.cs:408
                                {                                                                                                           // MakerGen.cs:231
                                    // 30. SubstanceSourceMaterial.organism.organismGeneral.kingdom
                                    this.Kingdom = new ElementDefinitionInfo                                                                // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Kingdom",                                                                                   // MakerGen.cs:235
                                        Path= "SubstanceSourceMaterial.organism.organismGeneral.kingdom",                                   // MakerGen.cs:236
                                        Id = "SubstanceSourceMaterial.organism.organismGeneral.kingdom",                                    // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:315
                                            {                                                                                               // MakerGen.cs:316
                                            }                                                                                               // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 31. SubstanceSourceMaterial.organism.organismGeneral.phylum
                                    this.Phylum = new ElementDefinitionInfo                                                                 // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Phylum",                                                                                    // MakerGen.cs:235
                                        Path= "SubstanceSourceMaterial.organism.organismGeneral.phylum",                                    // MakerGen.cs:236
                                        Id = "SubstanceSourceMaterial.organism.organismGeneral.phylum",                                     // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:315
                                            {                                                                                               // MakerGen.cs:316
                                            }                                                                                               // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 32. SubstanceSourceMaterial.organism.organismGeneral.class
                                    this.Class = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Class",                                                                                     // MakerGen.cs:235
                                        Path= "SubstanceSourceMaterial.organism.organismGeneral.class",                                     // MakerGen.cs:236
                                        Id = "SubstanceSourceMaterial.organism.organismGeneral.class",                                      // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:315
                                            {                                                                                               // MakerGen.cs:316
                                            }                                                                                               // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 33. SubstanceSourceMaterial.organism.organismGeneral.order
                                    this.Order = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Order",                                                                                     // MakerGen.cs:235
                                        Path= "SubstanceSourceMaterial.organism.organismGeneral.order",                                     // MakerGen.cs:236
                                        Id = "SubstanceSourceMaterial.organism.organismGeneral.order",                                      // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:315
                                            {                                                                                               // MakerGen.cs:316
                                            }                                                                                               // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                            }                                                                                                               // MakerGen.cs:427
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:412
                            {                                                                                                               // MakerGen.cs:413
                                base.Write(sDef);                                                                                           // MakerGen.cs:414
                                Kingdom.Write(sDef);                                                                                        // MakerGen.cs:220
                                Phylum.Write(sDef);                                                                                         // MakerGen.cs:220
                                Class.Write(sDef);                                                                                          // MakerGen.cs:220
                                Order.Write(sDef);                                                                                          // MakerGen.cs:220
                            }                                                                                                               // MakerGen.cs:431
                        }                                                                                                                   // MakerGen.cs:391
                        public Type_OrganismGeneral_Elements Elements { get; }                                                              // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                        public Type_OrganismGeneral()                                                                                       // MakerGen.cs:394
                        {                                                                                                                   // MakerGen.cs:395
                            this.Elements = new Type_OrganismGeneral_Elements();                                                            // MakerGen.cs:396
                        }                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:399
                        {                                                                                                                   // MakerGen.cs:400
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:401
                        }                                                                                                                   // MakerGen.cs:402
                    }                                                                                                                       // MakerGen.cs:403
                    // 15. SubstanceSourceMaterial.organism.family
                    public ElementDefinitionInfo Family;                                                                                    // MakerGen.cs:216
                    // 16. SubstanceSourceMaterial.organism.genus
                    public ElementDefinitionInfo Genus;                                                                                     // MakerGen.cs:216
                    // 17. SubstanceSourceMaterial.organism.species
                    public ElementDefinitionInfo Species;                                                                                   // MakerGen.cs:216
                    // 18. SubstanceSourceMaterial.organism.intraspecificType
                    public ElementDefinitionInfo IntraspecificType;                                                                         // MakerGen.cs:216
                    // 19. SubstanceSourceMaterial.organism.intraspecificDescription
                    public ElementDefinitionInfo IntraspecificDescription;                                                                  // MakerGen.cs:216
                    // 20. SubstanceSourceMaterial.organism.author
                    public ElementDefinitionInfo Author;                                                                                    // MakerGen.cs:216
                    // 23. SubstanceSourceMaterial.organism.hybrid
                    public ElementDefinitionInfo Hybrid;                                                                                    // MakerGen.cs:216
                    // 29. SubstanceSourceMaterial.organism.organismGeneral
                    public ElementDefinitionInfo OrganismGeneral;                                                                           // MakerGen.cs:216
                    public Type_Organism_Elements()                                                                                         // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 15. SubstanceSourceMaterial.organism.family
                            this.Family = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Family",                                                                                            // MakerGen.cs:235
                                Path= "SubstanceSourceMaterial.organism.family",                                                            // MakerGen.cs:236
                                Id = "SubstanceSourceMaterial.organism.family",                                                             // MakerGen.cs:237
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
                            // 16. SubstanceSourceMaterial.organism.genus
                            this.Genus = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Genus",                                                                                             // MakerGen.cs:235
                                Path= "SubstanceSourceMaterial.organism.genus",                                                             // MakerGen.cs:236
                                Id = "SubstanceSourceMaterial.organism.genus",                                                              // MakerGen.cs:237
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
                            // 17. SubstanceSourceMaterial.organism.species
                            this.Species = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Species",                                                                                           // MakerGen.cs:235
                                Path= "SubstanceSourceMaterial.organism.species",                                                           // MakerGen.cs:236
                                Id = "SubstanceSourceMaterial.organism.species",                                                            // MakerGen.cs:237
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
                            // 18. SubstanceSourceMaterial.organism.intraspecificType
                            this.IntraspecificType = new ElementDefinitionInfo                                                              // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "IntraspecificType",                                                                                 // MakerGen.cs:235
                                Path= "SubstanceSourceMaterial.organism.intraspecificType",                                                 // MakerGen.cs:236
                                Id = "SubstanceSourceMaterial.organism.intraspecificType",                                                  // MakerGen.cs:237
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
                            // 19. SubstanceSourceMaterial.organism.intraspecificDescription
                            this.IntraspecificDescription = new ElementDefinitionInfo                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "IntraspecificDescription",                                                                          // MakerGen.cs:235
                                Path= "SubstanceSourceMaterial.organism.intraspecificDescription",                                          // MakerGen.cs:236
                                Id = "SubstanceSourceMaterial.organism.intraspecificDescription",                                           // MakerGen.cs:237
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
                            // 20. SubstanceSourceMaterial.organism.author
                            this.Author = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Author",                                                                                            // MakerGen.cs:235
                                Path= "SubstanceSourceMaterial.organism.author",                                                            // MakerGen.cs:236
                                Id = "SubstanceSourceMaterial.organism.author",                                                             // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new Type_Author                                                                                         // MakerGen.cs:259
                                    {                                                                                                       // MakerGen.cs:260
                                    }                                                                                                       // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 23. SubstanceSourceMaterial.organism.hybrid
                            this.Hybrid = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Hybrid",                                                                                            // MakerGen.cs:235
                                Path= "SubstanceSourceMaterial.organism.hybrid",                                                            // MakerGen.cs:236
                                Id = "SubstanceSourceMaterial.organism.hybrid",                                                             // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new Type_Hybrid                                                                                         // MakerGen.cs:259
                                    {                                                                                                       // MakerGen.cs:260
                                    }                                                                                                       // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 29. SubstanceSourceMaterial.organism.organismGeneral
                            this.OrganismGeneral = new ElementDefinitionInfo                                                                // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "OrganismGeneral",                                                                                   // MakerGen.cs:235
                                Path= "SubstanceSourceMaterial.organism.organismGeneral",                                                   // MakerGen.cs:236
                                Id = "SubstanceSourceMaterial.organism.organismGeneral",                                                    // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new Type_OrganismGeneral                                                                                // MakerGen.cs:259
                                    {                                                                                                       // MakerGen.cs:260
                                    }                                                                                                       // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        Family.Write(sDef);                                                                                                 // MakerGen.cs:220
                        Genus.Write(sDef);                                                                                                  // MakerGen.cs:220
                        Species.Write(sDef);                                                                                                // MakerGen.cs:220
                        IntraspecificType.Write(sDef);                                                                                      // MakerGen.cs:220
                        IntraspecificDescription.Write(sDef);                                                                               // MakerGen.cs:220
                        Author.Write(sDef);                                                                                                 // MakerGen.cs:220
                        Hybrid.Write(sDef);                                                                                                 // MakerGen.cs:220
                        OrganismGeneral.Write(sDef);                                                                                        // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_Organism_Elements Elements { get; }                                                                             // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_Organism()                                                                                                      // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_Organism_Elements();                                                                           // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 34. SubstanceSourceMaterial.partDescription
            public class Type_PartDescription : FhirKhit.Maker.Common.Complex.ComplexBase                                                   // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_PartDescription_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                    // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 35. SubstanceSourceMaterial.partDescription.part
                    public ElementDefinitionInfo Part;                                                                                      // MakerGen.cs:216
                    // 36. SubstanceSourceMaterial.partDescription.partLocation
                    public ElementDefinitionInfo PartLocation;                                                                              // MakerGen.cs:216
                    public Type_PartDescription_Elements()                                                                                  // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 35. SubstanceSourceMaterial.partDescription.part
                            this.Part = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Part",                                                                                              // MakerGen.cs:235
                                Path= "SubstanceSourceMaterial.partDescription.part",                                                       // MakerGen.cs:236
                                Id = "SubstanceSourceMaterial.partDescription.part",                                                        // MakerGen.cs:237
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
                            // 36. SubstanceSourceMaterial.partDescription.partLocation
                            this.PartLocation = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "PartLocation",                                                                                      // MakerGen.cs:235
                                Path= "SubstanceSourceMaterial.partDescription.partLocation",                                               // MakerGen.cs:236
                                Id = "SubstanceSourceMaterial.partDescription.partLocation",                                                // MakerGen.cs:237
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
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        Part.Write(sDef);                                                                                                   // MakerGen.cs:220
                        PartLocation.Write(sDef);                                                                                           // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_PartDescription_Elements Elements { get; }                                                                      // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_PartDescription()                                                                                               // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_PartDescription_Elements();                                                                    // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 1. SubstanceSourceMaterial.sourceMaterialClass
            public ElementDefinitionInfo SourceMaterialClass;                                                                               // MakerGen.cs:216
            // 2. SubstanceSourceMaterial.sourceMaterialType
            public ElementDefinitionInfo SourceMaterialType;                                                                                // MakerGen.cs:216
            // 3. SubstanceSourceMaterial.sourceMaterialState
            public ElementDefinitionInfo SourceMaterialState;                                                                               // MakerGen.cs:216
            // 4. SubstanceSourceMaterial.organismId
            public ElementDefinitionInfo OrganismId;                                                                                        // MakerGen.cs:216
            // 5. SubstanceSourceMaterial.organismName
            public ElementDefinitionInfo OrganismName;                                                                                      // MakerGen.cs:216
            // 6. SubstanceSourceMaterial.parentSubstanceId
            public ElementDefinitionInfo ParentSubstanceId;                                                                                 // MakerGen.cs:216
            // 7. SubstanceSourceMaterial.parentSubstanceName
            public ElementDefinitionInfo ParentSubstanceName;                                                                               // MakerGen.cs:216
            // 8. SubstanceSourceMaterial.countryOfOrigin
            public ElementDefinitionInfo CountryOfOrigin;                                                                                   // MakerGen.cs:216
            // 9. SubstanceSourceMaterial.geographicalLocation
            public ElementDefinitionInfo GeographicalLocation;                                                                              // MakerGen.cs:216
            // 10. SubstanceSourceMaterial.developmentStage
            public ElementDefinitionInfo DevelopmentStage;                                                                                  // MakerGen.cs:216
            // 11. SubstanceSourceMaterial.fractionDescription
            public ElementDefinitionInfo FractionDescription;                                                                               // MakerGen.cs:216
            // 14. SubstanceSourceMaterial.organism
            public ElementDefinitionInfo Organism;                                                                                          // MakerGen.cs:216
            // 34. SubstanceSourceMaterial.partDescription
            public ElementDefinitionInfo PartDescription;                                                                                   // MakerGen.cs:216
            public SubstanceSourceMaterial_Elements()                                                                                       // MakerGen.cs:407
            {                                                                                                                               // MakerGen.cs:408
                {                                                                                                                           // MakerGen.cs:231
                    // 1. SubstanceSourceMaterial.sourceMaterialClass
                    this.SourceMaterialClass = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "SourceMaterialClass",                                                                                       // MakerGen.cs:235
                        Path= "SubstanceSourceMaterial.sourceMaterialClass",                                                                // MakerGen.cs:236
                        Id = "SubstanceSourceMaterial.sourceMaterialClass",                                                                 // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 2. SubstanceSourceMaterial.sourceMaterialType
                    this.SourceMaterialType = new ElementDefinitionInfo                                                                     // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "SourceMaterialType",                                                                                        // MakerGen.cs:235
                        Path= "SubstanceSourceMaterial.sourceMaterialType",                                                                 // MakerGen.cs:236
                        Id = "SubstanceSourceMaterial.sourceMaterialType",                                                                  // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 3. SubstanceSourceMaterial.sourceMaterialState
                    this.SourceMaterialState = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "SourceMaterialState",                                                                                       // MakerGen.cs:235
                        Path= "SubstanceSourceMaterial.sourceMaterialState",                                                                // MakerGen.cs:236
                        Id = "SubstanceSourceMaterial.sourceMaterialState",                                                                 // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 4. SubstanceSourceMaterial.organismId
                    this.OrganismId = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "OrganismId",                                                                                                // MakerGen.cs:235
                        Path= "SubstanceSourceMaterial.organismId",                                                                         // MakerGen.cs:236
                        Id = "SubstanceSourceMaterial.organismId",                                                                          // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 5. SubstanceSourceMaterial.organismName
                    this.OrganismName = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "OrganismName",                                                                                              // MakerGen.cs:235
                        Path= "SubstanceSourceMaterial.organismName",                                                                       // MakerGen.cs:236
                        Id = "SubstanceSourceMaterial.organismName",                                                                        // MakerGen.cs:237
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
                    // 6. SubstanceSourceMaterial.parentSubstanceId
                    this.ParentSubstanceId = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ParentSubstanceId",                                                                                         // MakerGen.cs:235
                        Path= "SubstanceSourceMaterial.parentSubstanceId",                                                                  // MakerGen.cs:236
                        Id = "SubstanceSourceMaterial.parentSubstanceId",                                                                   // MakerGen.cs:237
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
                    // 7. SubstanceSourceMaterial.parentSubstanceName
                    this.ParentSubstanceName = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ParentSubstanceName",                                                                                       // MakerGen.cs:235
                        Path= "SubstanceSourceMaterial.parentSubstanceName",                                                                // MakerGen.cs:236
                        Id = "SubstanceSourceMaterial.parentSubstanceName",                                                                 // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 8. SubstanceSourceMaterial.countryOfOrigin
                    this.CountryOfOrigin = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "CountryOfOrigin",                                                                                           // MakerGen.cs:235
                        Path= "SubstanceSourceMaterial.countryOfOrigin",                                                                    // MakerGen.cs:236
                        Id = "SubstanceSourceMaterial.countryOfOrigin",                                                                     // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 9. SubstanceSourceMaterial.geographicalLocation
                    this.GeographicalLocation = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "GeographicalLocation",                                                                                      // MakerGen.cs:235
                        Path= "SubstanceSourceMaterial.geographicalLocation",                                                               // MakerGen.cs:236
                        Id = "SubstanceSourceMaterial.geographicalLocation",                                                                // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 10. SubstanceSourceMaterial.developmentStage
                    this.DevelopmentStage = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "DevelopmentStage",                                                                                          // MakerGen.cs:235
                        Path= "SubstanceSourceMaterial.developmentStage",                                                                   // MakerGen.cs:236
                        Id = "SubstanceSourceMaterial.developmentStage",                                                                    // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 11. SubstanceSourceMaterial.fractionDescription
                    this.FractionDescription = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "FractionDescription",                                                                                       // MakerGen.cs:235
                        Path= "SubstanceSourceMaterial.fractionDescription",                                                                // MakerGen.cs:236
                        Id = "SubstanceSourceMaterial.fractionDescription",                                                                 // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_FractionDescription                                                                                    // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 14. SubstanceSourceMaterial.organism
                    this.Organism = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Organism",                                                                                                  // MakerGen.cs:235
                        Path= "SubstanceSourceMaterial.organism",                                                                           // MakerGen.cs:236
                        Id = "SubstanceSourceMaterial.organism",                                                                            // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Organism                                                                                               // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 34. SubstanceSourceMaterial.partDescription
                    this.PartDescription = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "PartDescription",                                                                                           // MakerGen.cs:235
                        Path= "SubstanceSourceMaterial.partDescription",                                                                    // MakerGen.cs:236
                        Id = "SubstanceSourceMaterial.partDescription",                                                                     // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_PartDescription                                                                                        // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:427
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:412
            {                                                                                                                               // MakerGen.cs:413
                base.Write(sDef);                                                                                                           // MakerGen.cs:414
                SourceMaterialClass.Write(sDef);                                                                                            // MakerGen.cs:220
                SourceMaterialType.Write(sDef);                                                                                             // MakerGen.cs:220
                SourceMaterialState.Write(sDef);                                                                                            // MakerGen.cs:220
                OrganismId.Write(sDef);                                                                                                     // MakerGen.cs:220
                OrganismName.Write(sDef);                                                                                                   // MakerGen.cs:220
                ParentSubstanceId.Write(sDef);                                                                                              // MakerGen.cs:220
                ParentSubstanceName.Write(sDef);                                                                                            // MakerGen.cs:220
                CountryOfOrigin.Write(sDef);                                                                                                // MakerGen.cs:220
                GeographicalLocation.Write(sDef);                                                                                           // MakerGen.cs:220
                DevelopmentStage.Write(sDef);                                                                                               // MakerGen.cs:220
                FractionDescription.Write(sDef);                                                                                            // MakerGen.cs:220
                Organism.Write(sDef);                                                                                                       // MakerGen.cs:220
                PartDescription.Write(sDef);                                                                                                // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:431
        }                                                                                                                                   // MakerGen.cs:391
        public SubstanceSourceMaterial_Elements Elements { get; }                                                                           // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
        public SubstanceSourceMaterial()                                                                                                    // MakerGen.cs:394
        {                                                                                                                                   // MakerGen.cs:395
            this.Elements = new SubstanceSourceMaterial_Elements();                                                                         // MakerGen.cs:396
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:399
        {                                                                                                                                   // MakerGen.cs:400
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:401
        }                                                                                                                                   // MakerGen.cs:402
    }                                                                                                                                       // MakerGen.cs:403
}                                                                                                                                           // MakerGen.cs:466
