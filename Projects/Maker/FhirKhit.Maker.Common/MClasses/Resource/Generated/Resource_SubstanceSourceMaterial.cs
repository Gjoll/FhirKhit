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
    #endregion
    /// <summary>
    /// Fhir resource 'SubstanceSourceMaterial'
    /// </summary>
    // 0. SubstanceSourceMaterial
    public class Resource_SubstanceSourceMaterial : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 11. SubstanceSourceMaterial.fractionDescription
        public class Type_FractionDescription : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 12. SubstanceSourceMaterial.fractionDescription.fraction
            public ElementDefinitionInfo Element_Fraction;
            // 13. SubstanceSourceMaterial.fractionDescription.materialType
            public ElementDefinitionInfo Element_MaterialType;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "SubstanceSourceMaterial.fractionDescription",
                    ElementId = "SubstanceSourceMaterial.fractionDescription"
                });
                Element_Fraction.Write(sDef);
                Element_MaterialType.Write(sDef);
            }
            
            public Type_FractionDescription()
            {
                {
                    // 12. SubstanceSourceMaterial.fractionDescription.fraction
                    this.Element_Fraction = new ElementDefinitionInfo
                    {
                        Name = "Element_Fraction",
                        Path= "SubstanceSourceMaterial.fractionDescription.fraction",
                        Id = "SubstanceSourceMaterial.fractionDescription.fraction",
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
                    // 13. SubstanceSourceMaterial.fractionDescription.materialType
                    this.Element_MaterialType = new ElementDefinitionInfo
                    {
                        Name = "Element_MaterialType",
                        Path= "SubstanceSourceMaterial.fractionDescription.materialType",
                        Id = "SubstanceSourceMaterial.fractionDescription.materialType",
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
            }
        }
        // 14. SubstanceSourceMaterial.organism
        public class Type_Organism : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 20. SubstanceSourceMaterial.organism.author
            public class Type_Author : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 21. SubstanceSourceMaterial.organism.author.authorType
                public ElementDefinitionInfo Element_AuthorType;
                // 22. SubstanceSourceMaterial.organism.author.authorDescription
                public ElementDefinitionInfo Element_AuthorDescription;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "SubstanceSourceMaterial.organism.author",
                        ElementId = "SubstanceSourceMaterial.organism.author"
                    });
                    Element_AuthorType.Write(sDef);
                    Element_AuthorDescription.Write(sDef);
                }
                
                public Type_Author()
                {
                    {
                        // 21. SubstanceSourceMaterial.organism.author.authorType
                        this.Element_AuthorType = new ElementDefinitionInfo
                        {
                            Name = "Element_AuthorType",
                            Path= "SubstanceSourceMaterial.organism.author.authorType",
                            Id = "SubstanceSourceMaterial.organism.author.authorType",
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
                        // 22. SubstanceSourceMaterial.organism.author.authorDescription
                        this.Element_AuthorDescription = new ElementDefinitionInfo
                        {
                            Name = "Element_AuthorDescription",
                            Path= "SubstanceSourceMaterial.organism.author.authorDescription",
                            Id = "SubstanceSourceMaterial.organism.author.authorDescription",
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
            // 23. SubstanceSourceMaterial.organism.hybrid
            public class Type_Hybrid : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 24. SubstanceSourceMaterial.organism.hybrid.maternalOrganismId
                public ElementDefinitionInfo Element_MaternalOrganismId;
                // 25. SubstanceSourceMaterial.organism.hybrid.maternalOrganismName
                public ElementDefinitionInfo Element_MaternalOrganismName;
                // 26. SubstanceSourceMaterial.organism.hybrid.paternalOrganismId
                public ElementDefinitionInfo Element_PaternalOrganismId;
                // 27. SubstanceSourceMaterial.organism.hybrid.paternalOrganismName
                public ElementDefinitionInfo Element_PaternalOrganismName;
                // 28. SubstanceSourceMaterial.organism.hybrid.hybridType
                public ElementDefinitionInfo Element_HybridType;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "SubstanceSourceMaterial.organism.hybrid",
                        ElementId = "SubstanceSourceMaterial.organism.hybrid"
                    });
                    Element_MaternalOrganismId.Write(sDef);
                    Element_MaternalOrganismName.Write(sDef);
                    Element_PaternalOrganismId.Write(sDef);
                    Element_PaternalOrganismName.Write(sDef);
                    Element_HybridType.Write(sDef);
                }
                
                public Type_Hybrid()
                {
                    {
                        // 24. SubstanceSourceMaterial.organism.hybrid.maternalOrganismId
                        this.Element_MaternalOrganismId = new ElementDefinitionInfo
                        {
                            Name = "Element_MaternalOrganismId",
                            Path= "SubstanceSourceMaterial.organism.hybrid.maternalOrganismId",
                            Id = "SubstanceSourceMaterial.organism.hybrid.maternalOrganismId",
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
                        // 25. SubstanceSourceMaterial.organism.hybrid.maternalOrganismName
                        this.Element_MaternalOrganismName = new ElementDefinitionInfo
                        {
                            Name = "Element_MaternalOrganismName",
                            Path= "SubstanceSourceMaterial.organism.hybrid.maternalOrganismName",
                            Id = "SubstanceSourceMaterial.organism.hybrid.maternalOrganismName",
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
                        // 26. SubstanceSourceMaterial.organism.hybrid.paternalOrganismId
                        this.Element_PaternalOrganismId = new ElementDefinitionInfo
                        {
                            Name = "Element_PaternalOrganismId",
                            Path= "SubstanceSourceMaterial.organism.hybrid.paternalOrganismId",
                            Id = "SubstanceSourceMaterial.organism.hybrid.paternalOrganismId",
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
                        // 27. SubstanceSourceMaterial.organism.hybrid.paternalOrganismName
                        this.Element_PaternalOrganismName = new ElementDefinitionInfo
                        {
                            Name = "Element_PaternalOrganismName",
                            Path= "SubstanceSourceMaterial.organism.hybrid.paternalOrganismName",
                            Id = "SubstanceSourceMaterial.organism.hybrid.paternalOrganismName",
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
                        // 28. SubstanceSourceMaterial.organism.hybrid.hybridType
                        this.Element_HybridType = new ElementDefinitionInfo
                        {
                            Name = "Element_HybridType",
                            Path= "SubstanceSourceMaterial.organism.hybrid.hybridType",
                            Id = "SubstanceSourceMaterial.organism.hybrid.hybridType",
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
                }
            }
            // 29. SubstanceSourceMaterial.organism.organismGeneral
            public class Type_OrganismGeneral : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 30. SubstanceSourceMaterial.organism.organismGeneral.kingdom
                public ElementDefinitionInfo Element_Kingdom;
                // 31. SubstanceSourceMaterial.organism.organismGeneral.phylum
                public ElementDefinitionInfo Element_Phylum;
                // 32. SubstanceSourceMaterial.organism.organismGeneral.class
                public ElementDefinitionInfo Element_Class;
                // 33. SubstanceSourceMaterial.organism.organismGeneral.order
                public ElementDefinitionInfo Element_Order;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "SubstanceSourceMaterial.organism.organismGeneral",
                        ElementId = "SubstanceSourceMaterial.organism.organismGeneral"
                    });
                    Element_Kingdom.Write(sDef);
                    Element_Phylum.Write(sDef);
                    Element_Class.Write(sDef);
                    Element_Order.Write(sDef);
                }
                
                public Type_OrganismGeneral()
                {
                    {
                        // 30. SubstanceSourceMaterial.organism.organismGeneral.kingdom
                        this.Element_Kingdom = new ElementDefinitionInfo
                        {
                            Name = "Element_Kingdom",
                            Path= "SubstanceSourceMaterial.organism.organismGeneral.kingdom",
                            Id = "SubstanceSourceMaterial.organism.organismGeneral.kingdom",
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
                        // 31. SubstanceSourceMaterial.organism.organismGeneral.phylum
                        this.Element_Phylum = new ElementDefinitionInfo
                        {
                            Name = "Element_Phylum",
                            Path= "SubstanceSourceMaterial.organism.organismGeneral.phylum",
                            Id = "SubstanceSourceMaterial.organism.organismGeneral.phylum",
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
                        // 32. SubstanceSourceMaterial.organism.organismGeneral.class
                        this.Element_Class = new ElementDefinitionInfo
                        {
                            Name = "Element_Class",
                            Path= "SubstanceSourceMaterial.organism.organismGeneral.class",
                            Id = "SubstanceSourceMaterial.organism.organismGeneral.class",
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
                        // 33. SubstanceSourceMaterial.organism.organismGeneral.order
                        this.Element_Order = new ElementDefinitionInfo
                        {
                            Name = "Element_Order",
                            Path= "SubstanceSourceMaterial.organism.organismGeneral.order",
                            Id = "SubstanceSourceMaterial.organism.organismGeneral.order",
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
                }
            }
            // 15. SubstanceSourceMaterial.organism.family
            public ElementDefinitionInfo Element_Family;
            // 16. SubstanceSourceMaterial.organism.genus
            public ElementDefinitionInfo Element_Genus;
            // 17. SubstanceSourceMaterial.organism.species
            public ElementDefinitionInfo Element_Species;
            // 18. SubstanceSourceMaterial.organism.intraspecificType
            public ElementDefinitionInfo Element_IntraspecificType;
            // 19. SubstanceSourceMaterial.organism.intraspecificDescription
            public ElementDefinitionInfo Element_IntraspecificDescription;
            // 20. SubstanceSourceMaterial.organism.author
            public ElementDefinitionInfo Element_Author;
            // 23. SubstanceSourceMaterial.organism.hybrid
            public ElementDefinitionInfo Element_Hybrid;
            // 29. SubstanceSourceMaterial.organism.organismGeneral
            public ElementDefinitionInfo Element_OrganismGeneral;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "SubstanceSourceMaterial.organism",
                    ElementId = "SubstanceSourceMaterial.organism"
                });
                Element_Family.Write(sDef);
                Element_Genus.Write(sDef);
                Element_Species.Write(sDef);
                Element_IntraspecificType.Write(sDef);
                Element_IntraspecificDescription.Write(sDef);
                Element_Author.Write(sDef);
                Element_Hybrid.Write(sDef);
                Element_OrganismGeneral.Write(sDef);
            }
            
            public Type_Organism()
            {
                {
                    // 15. SubstanceSourceMaterial.organism.family
                    this.Element_Family = new ElementDefinitionInfo
                    {
                        Name = "Element_Family",
                        Path= "SubstanceSourceMaterial.organism.family",
                        Id = "SubstanceSourceMaterial.organism.family",
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
                    // 16. SubstanceSourceMaterial.organism.genus
                    this.Element_Genus = new ElementDefinitionInfo
                    {
                        Name = "Element_Genus",
                        Path= "SubstanceSourceMaterial.organism.genus",
                        Id = "SubstanceSourceMaterial.organism.genus",
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
                    // 17. SubstanceSourceMaterial.organism.species
                    this.Element_Species = new ElementDefinitionInfo
                    {
                        Name = "Element_Species",
                        Path= "SubstanceSourceMaterial.organism.species",
                        Id = "SubstanceSourceMaterial.organism.species",
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
                    // 18. SubstanceSourceMaterial.organism.intraspecificType
                    this.Element_IntraspecificType = new ElementDefinitionInfo
                    {
                        Name = "Element_IntraspecificType",
                        Path= "SubstanceSourceMaterial.organism.intraspecificType",
                        Id = "SubstanceSourceMaterial.organism.intraspecificType",
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
                    // 19. SubstanceSourceMaterial.organism.intraspecificDescription
                    this.Element_IntraspecificDescription = new ElementDefinitionInfo
                    {
                        Name = "Element_IntraspecificDescription",
                        Path= "SubstanceSourceMaterial.organism.intraspecificDescription",
                        Id = "SubstanceSourceMaterial.organism.intraspecificDescription",
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
                    // 20. SubstanceSourceMaterial.organism.author
                    this.Element_Author = new ElementDefinitionInfo
                    {
                        Name = "Element_Author",
                        Path= "SubstanceSourceMaterial.organism.author",
                        Id = "SubstanceSourceMaterial.organism.author",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Author
                            {
                            }
                        }
                    };
                }
                {
                    // 23. SubstanceSourceMaterial.organism.hybrid
                    this.Element_Hybrid = new ElementDefinitionInfo
                    {
                        Name = "Element_Hybrid",
                        Path= "SubstanceSourceMaterial.organism.hybrid",
                        Id = "SubstanceSourceMaterial.organism.hybrid",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new Type_Hybrid
                            {
                            }
                        }
                    };
                }
                {
                    // 29. SubstanceSourceMaterial.organism.organismGeneral
                    this.Element_OrganismGeneral = new ElementDefinitionInfo
                    {
                        Name = "Element_OrganismGeneral",
                        Path= "SubstanceSourceMaterial.organism.organismGeneral",
                        Id = "SubstanceSourceMaterial.organism.organismGeneral",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new Type_OrganismGeneral
                            {
                            }
                        }
                    };
                }
            }
        }
        // 34. SubstanceSourceMaterial.partDescription
        public class Type_PartDescription : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 35. SubstanceSourceMaterial.partDescription.part
            public ElementDefinitionInfo Element_Part;
            // 36. SubstanceSourceMaterial.partDescription.partLocation
            public ElementDefinitionInfo Element_PartLocation;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "SubstanceSourceMaterial.partDescription",
                    ElementId = "SubstanceSourceMaterial.partDescription"
                });
                Element_Part.Write(sDef);
                Element_PartLocation.Write(sDef);
            }
            
            public Type_PartDescription()
            {
                {
                    // 35. SubstanceSourceMaterial.partDescription.part
                    this.Element_Part = new ElementDefinitionInfo
                    {
                        Name = "Element_Part",
                        Path= "SubstanceSourceMaterial.partDescription.part",
                        Id = "SubstanceSourceMaterial.partDescription.part",
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
                    // 36. SubstanceSourceMaterial.partDescription.partLocation
                    this.Element_PartLocation = new ElementDefinitionInfo
                    {
                        Name = "Element_PartLocation",
                        Path= "SubstanceSourceMaterial.partDescription.partLocation",
                        Id = "SubstanceSourceMaterial.partDescription.partLocation",
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
            }
        }
        // 1. SubstanceSourceMaterial.sourceMaterialClass
        public ElementDefinitionInfo Element_SourceMaterialClass;
        // 2. SubstanceSourceMaterial.sourceMaterialType
        public ElementDefinitionInfo Element_SourceMaterialType;
        // 3. SubstanceSourceMaterial.sourceMaterialState
        public ElementDefinitionInfo Element_SourceMaterialState;
        // 4. SubstanceSourceMaterial.organismId
        public ElementDefinitionInfo Element_OrganismId;
        // 5. SubstanceSourceMaterial.organismName
        public ElementDefinitionInfo Element_OrganismName;
        // 6. SubstanceSourceMaterial.parentSubstanceId
        public ElementDefinitionInfo Element_ParentSubstanceId;
        // 7. SubstanceSourceMaterial.parentSubstanceName
        public ElementDefinitionInfo Element_ParentSubstanceName;
        // 8. SubstanceSourceMaterial.countryOfOrigin
        public ElementDefinitionInfo Element_CountryOfOrigin;
        // 9. SubstanceSourceMaterial.geographicalLocation
        public ElementDefinitionInfo Element_GeographicalLocation;
        // 10. SubstanceSourceMaterial.developmentStage
        public ElementDefinitionInfo Element_DevelopmentStage;
        // 11. SubstanceSourceMaterial.fractionDescription
        public ElementDefinitionInfo Element_FractionDescription;
        // 14. SubstanceSourceMaterial.organism
        public ElementDefinitionInfo Element_Organism;
        // 34. SubstanceSourceMaterial.partDescription
        public ElementDefinitionInfo Element_PartDescription;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "SubstanceSourceMaterial",
                ElementId = "SubstanceSourceMaterial"
            });
            Element_SourceMaterialClass.Write(sDef);
            Element_SourceMaterialType.Write(sDef);
            Element_SourceMaterialState.Write(sDef);
            Element_OrganismId.Write(sDef);
            Element_OrganismName.Write(sDef);
            Element_ParentSubstanceId.Write(sDef);
            Element_ParentSubstanceName.Write(sDef);
            Element_CountryOfOrigin.Write(sDef);
            Element_GeographicalLocation.Write(sDef);
            Element_DevelopmentStage.Write(sDef);
            Element_FractionDescription.Write(sDef);
            Element_Organism.Write(sDef);
            Element_PartDescription.Write(sDef);
        }
        
        public Resource_SubstanceSourceMaterial()
        {
            {
                // 1. SubstanceSourceMaterial.sourceMaterialClass
                this.Element_SourceMaterialClass = new ElementDefinitionInfo
                {
                    Name = "Element_SourceMaterialClass",
                    Path= "SubstanceSourceMaterial.sourceMaterialClass",
                    Id = "SubstanceSourceMaterial.sourceMaterialClass",
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
                // 2. SubstanceSourceMaterial.sourceMaterialType
                this.Element_SourceMaterialType = new ElementDefinitionInfo
                {
                    Name = "Element_SourceMaterialType",
                    Path= "SubstanceSourceMaterial.sourceMaterialType",
                    Id = "SubstanceSourceMaterial.sourceMaterialType",
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
                // 3. SubstanceSourceMaterial.sourceMaterialState
                this.Element_SourceMaterialState = new ElementDefinitionInfo
                {
                    Name = "Element_SourceMaterialState",
                    Path= "SubstanceSourceMaterial.sourceMaterialState",
                    Id = "SubstanceSourceMaterial.sourceMaterialState",
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
                // 4. SubstanceSourceMaterial.organismId
                this.Element_OrganismId = new ElementDefinitionInfo
                {
                    Name = "Element_OrganismId",
                    Path= "SubstanceSourceMaterial.organismId",
                    Id = "SubstanceSourceMaterial.organismId",
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
                // 5. SubstanceSourceMaterial.organismName
                this.Element_OrganismName = new ElementDefinitionInfo
                {
                    Name = "Element_OrganismName",
                    Path= "SubstanceSourceMaterial.organismName",
                    Id = "SubstanceSourceMaterial.organismName",
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
                // 6. SubstanceSourceMaterial.parentSubstanceId
                this.Element_ParentSubstanceId = new ElementDefinitionInfo
                {
                    Name = "Element_ParentSubstanceId",
                    Path= "SubstanceSourceMaterial.parentSubstanceId",
                    Id = "SubstanceSourceMaterial.parentSubstanceId",
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
                // 7. SubstanceSourceMaterial.parentSubstanceName
                this.Element_ParentSubstanceName = new ElementDefinitionInfo
                {
                    Name = "Element_ParentSubstanceName",
                    Path= "SubstanceSourceMaterial.parentSubstanceName",
                    Id = "SubstanceSourceMaterial.parentSubstanceName",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_String
                        {
                        }
                    }
                };
            }
            {
                // 8. SubstanceSourceMaterial.countryOfOrigin
                this.Element_CountryOfOrigin = new ElementDefinitionInfo
                {
                    Name = "Element_CountryOfOrigin",
                    Path= "SubstanceSourceMaterial.countryOfOrigin",
                    Id = "SubstanceSourceMaterial.countryOfOrigin",
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
                // 9. SubstanceSourceMaterial.geographicalLocation
                this.Element_GeographicalLocation = new ElementDefinitionInfo
                {
                    Name = "Element_GeographicalLocation",
                    Path= "SubstanceSourceMaterial.geographicalLocation",
                    Id = "SubstanceSourceMaterial.geographicalLocation",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_String
                        {
                        }
                    }
                };
            }
            {
                // 10. SubstanceSourceMaterial.developmentStage
                this.Element_DevelopmentStage = new ElementDefinitionInfo
                {
                    Name = "Element_DevelopmentStage",
                    Path= "SubstanceSourceMaterial.developmentStage",
                    Id = "SubstanceSourceMaterial.developmentStage",
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
                // 11. SubstanceSourceMaterial.fractionDescription
                this.Element_FractionDescription = new ElementDefinitionInfo
                {
                    Name = "Element_FractionDescription",
                    Path= "SubstanceSourceMaterial.fractionDescription",
                    Id = "SubstanceSourceMaterial.fractionDescription",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_FractionDescription
                        {
                        }
                    }
                };
            }
            {
                // 14. SubstanceSourceMaterial.organism
                this.Element_Organism = new ElementDefinitionInfo
                {
                    Name = "Element_Organism",
                    Path= "SubstanceSourceMaterial.organism",
                    Id = "SubstanceSourceMaterial.organism",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new Type_Organism
                        {
                        }
                    }
                };
            }
            {
                // 34. SubstanceSourceMaterial.partDescription
                this.Element_PartDescription = new ElementDefinitionInfo
                {
                    Name = "Element_PartDescription",
                    Path= "SubstanceSourceMaterial.partDescription",
                    Id = "SubstanceSourceMaterial.partDescription",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_PartDescription
                        {
                        }
                    }
                };
            }
            this.Name = "SubstanceSourceMaterial";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/SubstanceSourceMaterial";
        }
    }
}
