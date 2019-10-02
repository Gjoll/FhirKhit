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
      "id": "BodyStructure",
      "url": "http://hl7.org/fhir/StructureDefinition/BodyStructure",
      "version": "4.0.0",
      "name": "BodyStructure",
      "status": "draft",
      "publisher": "Health Level Seven International (Orders and Observations)",
      "description": "Record details about an anatomical structure.  This resource may be used when a coded concept does not provide the necessary detail needed for the use case.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "BodyStructure",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "BodyStructure",
            "path": "BodyStructure",
            "short": "Specific and identified anatomical structure",
            "definition": "Record details about an anatomical structure.  This resource may be used when a coded concept does not provide the necessary detail needed for the use case.",
            "alias": [
              "anatomical location"
            ],
            "min": 0,
            "max": "*"
          },
          {
            "id": "BodyStructure.identifier",
            "path": "BodyStructure.identifier",
            "short": "Bodystructure identifier",
            "definition": "Identifier for this instance of the anatomical structure.",
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
            "id": "BodyStructure.active",
            "path": "BodyStructure.active",
            "short": "Whether this record is in active use",
            "definition": "Whether this body site is in active use.",
            "comment": "This element is labeled as a modifier because it may be used to mark that the resource was created in error.",
            "requirements": "Need to be able to mark a body site entry as not to be used because it was created in error.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "meaningWhenMissing": "This resource is generally assumed to be active if no value is provided for the active element",
            "isModifier": true,
            "isModifierReason": "This element is labelled as a modifier because it is a status element that can indicate that a record should not be treated as valid",
            "isSummary": true
          },
          {
            "id": "BodyStructure.morphology",
            "path": "BodyStructure.morphology",
            "short": "Kind of Structure",
            "definition": "The kind of structure being represented by the body structure at `BodyStructure.location`.  This can define both normal and abnormal morphologies.",
            "comment": "The minimum cardinality of 0 supports the use case of specifying a location without defining a morphology.",
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
                  "valueString": "BodyStructureCode"
                }
              ],
              "strength": "example",
              "description": "Codes describing anatomic morphology.",
              "valueSet": "http://hl7.org/fhir/ValueSet/bodystructure-code"
            }
          },
          {
            "id": "BodyStructure.location",
            "path": "BodyStructure.location",
            "short": "Body site",
            "definition": "The anatomical location or region of the specimen, lesion, or body structure.",
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
                  "valueString": "BodySite"
                }
              ],
              "strength": "example",
              "description": "Codes describing anatomical locations. May include laterality.",
              "valueSet": "http://hl7.org/fhir/ValueSet/body-site"
            }
          },
          {
            "id": "BodyStructure.locationQualifier",
            "path": "BodyStructure.locationQualifier",
            "short": "Body site modifier",
            "definition": "Qualifier to refine the anatomical location.  These include qualifiers for laterality, relative location, directionality, number, and plane.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "BodyStructureQualifier"
                }
              ],
              "strength": "example",
              "description": "Concepts modifying the anatomic location.",
              "valueSet": "http://hl7.org/fhir/ValueSet/bodystructure-relative-location"
            }
          },
          {
            "id": "BodyStructure.description",
            "path": "BodyStructure.description",
            "short": "Text description",
            "definition": "A summary, characterization or explanation of the body structure.",
            "comment": "This description could include any visual markings used to orientate the viewer e.g. external reference points, special sutures, ink markings.",
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
            "id": "BodyStructure.image",
            "path": "BodyStructure.image",
            "short": "Attached images",
            "definition": "Image or images used to identify a location.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Attachment"
              }
            ]
          },
          {
            "id": "BodyStructure.patient",
            "path": "BodyStructure.patient",
            "short": "Who this is about",
            "definition": "The person to which the body site belongs.",
            "min": 1,
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
          }
        ]
      }
    }
    #endif
    #endregion
    /// <summary>
    /// Fhir resource 'BodyStructure'
    /// </summary>
    // 0. BodyStructure
    public partial class Resource_BodyStructure : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 1. BodyStructure.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. BodyStructure.active
        public ElementDefinitionInfo Element_Active;
        // 3. BodyStructure.morphology
        public ElementDefinitionInfo Element_Morphology;
        // 4. BodyStructure.location
        public ElementDefinitionInfo Element_Location;
        // 5. BodyStructure.locationQualifier
        public ElementDefinitionInfo Element_LocationQualifier;
        // 6. BodyStructure.description
        public ElementDefinitionInfo Element_Description;
        // 7. BodyStructure.image
        public ElementDefinitionInfo Element_Image;
        // 8. BodyStructure.patient
        public ElementDefinitionInfo Element_Patient;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "BodyStructure",
                ElementId = "BodyStructure"
            });
            Element_Identifier.Write(sDef);
            Element_Active.Write(sDef);
            Element_Morphology.Write(sDef);
            Element_Location.Write(sDef);
            Element_LocationQualifier.Write(sDef);
            Element_Description.Write(sDef);
            Element_Image.Write(sDef);
            Element_Patient.Write(sDef);
        }
        
        public Resource_BodyStructure()
        {
            {
                // 1. BodyStructure.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "BodyStructure.identifier",
                    Id = "BodyStructure.identifier",
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
                // 2. BodyStructure.active
                this.Element_Active = new ElementDefinitionInfo
                {
                    Name = "Element_Active",
                    Path= "BodyStructure.active",
                    Id = "BodyStructure.active",
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
                // 3. BodyStructure.morphology
                this.Element_Morphology = new ElementDefinitionInfo
                {
                    Name = "Element_Morphology",
                    Path= "BodyStructure.morphology",
                    Id = "BodyStructure.morphology",
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
                // 4. BodyStructure.location
                this.Element_Location = new ElementDefinitionInfo
                {
                    Name = "Element_Location",
                    Path= "BodyStructure.location",
                    Id = "BodyStructure.location",
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
                // 5. BodyStructure.locationQualifier
                this.Element_LocationQualifier = new ElementDefinitionInfo
                {
                    Name = "Element_LocationQualifier",
                    Path= "BodyStructure.locationQualifier",
                    Id = "BodyStructure.locationQualifier",
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
                // 6. BodyStructure.description
                this.Element_Description = new ElementDefinitionInfo
                {
                    Name = "Element_Description",
                    Path= "BodyStructure.description",
                    Id = "BodyStructure.description",
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
                // 7. BodyStructure.image
                this.Element_Image = new ElementDefinitionInfo
                {
                    Name = "Element_Image",
                    Path= "BodyStructure.image",
                    Id = "BodyStructure.image",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Attachment
                        {
                        }
                    }
                };
            }
            {
                // 8. BodyStructure.patient
                this.Element_Patient = new ElementDefinitionInfo
                {
                    Name = "Element_Patient",
                    Path= "BodyStructure.patient",
                    Id = "BodyStructure.patient",
                    Min = 1,
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
            this.Name = "BodyStructure";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/BodyStructure";
        }
    }
}
