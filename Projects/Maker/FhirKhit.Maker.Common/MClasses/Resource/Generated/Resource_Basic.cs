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
      "id": "Basic",
      "url": "http://hl7.org/fhir/StructureDefinition/Basic",
      "version": "4.0.0",
      "name": "Basic",
      "status": "draft",
      "publisher": "Health Level Seven International (FHIR Infrastructure)",
      "description": "Basic is used for handling concepts not yet defined in FHIR, narrative-only resources that don't map to an existing resource, and custom resources not appropriate for inclusion in the FHIR specification.",
      "purpose": "Need some way to safely (without breaking interoperability) allow implementers to exchange content not supported by the initial set of declared resources.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "Basic",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Basic",
            "path": "Basic",
            "short": "Resource for non-supported content",
            "definition": "Basic is used for handling concepts not yet defined in FHIR, narrative-only resources that don't map to an existing resource, and custom resources not appropriate for inclusion in the FHIR specification.",
            "alias": [
              "Z-resource",
              "Extension-resource",
              "Custom-resource"
            ],
            "min": 0,
            "max": "*"
          },
          {
            "id": "Basic.identifier",
            "path": "Basic.identifier",
            "short": "Business identifier",
            "definition": "Identifier assigned to the resource for business purposes, outside the context of FHIR.",
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
            "id": "Basic.code",
            "path": "Basic.code",
            "short": "Kind of Resource",
            "definition": "Identifies the 'type' of resource - equivalent to the resource name for other resources.",
            "comment": "Because resource references will only be able to indicate 'Basic', the type of reference will need to be specified in a Profile identified as part of the resource.  Refer to the resource notes section for information on appropriate terminologies for this code.\n\nThis element is labeled as a modifier because it defines the meaning of the resource and cannot be ignored.",
            "requirements": "Must be able to distinguish different types of Basic resources.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isModifier": true,
            "isModifierReason": "This element determines what kind of resource is being represented which drives the meaning of all of the other elements.",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "BasicResourceType"
                }
              ],
              "strength": "example",
              "description": "Codes for identifying types of resources not yet defined by FHIR.",
              "valueSet": "http://hl7.org/fhir/ValueSet/basic-resource-type"
            }
          },
          {
            "id": "Basic.subject",
            "path": "Basic.subject",
            "short": "Identifies the focus of this resource",
            "definition": "Identifies the patient, practitioner, device or any other resource that is the \"focus\" of this resource.",
            "comment": "Optional as not all potential resources will have subjects.  Resources associated with multiple subjects can handle this via extension.",
            "requirements": "Needed for partitioning the resource by Patient.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Resource"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Basic.created",
            "path": "Basic.created",
            "short": "When created",
            "definition": "Identifies when the resource was first created.",
            "requirements": "Allows ordering resource instances by time.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "date"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Basic.author",
            "path": "Basic.author",
            "short": "Who created",
            "definition": "Indicates who was responsible for creating the resource instance.",
            "requirements": "Needed for partitioning the resource.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                  "http://hl7.org/fhir/StructureDefinition/Organization"
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
    /// Fhir resource 'Basic'
    /// </summary>
    // 0. Basic
    public partial class Resource_Basic : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 1. Basic.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. Basic.code
        public ElementDefinitionInfo Element_Code;
        // 3. Basic.subject
        public ElementDefinitionInfo Element_Subject;
        // 4. Basic.created
        public ElementDefinitionInfo Element_Created;
        // 5. Basic.author
        public ElementDefinitionInfo Element_Author;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "Basic",
                ElementId = "Basic"
            });
            Element_Identifier.Write(sDef);
            Element_Code.Write(sDef);
            Element_Subject.Write(sDef);
            Element_Created.Write(sDef);
            Element_Author.Write(sDef);
        }
        
        public Resource_Basic()
        {
            {
                // 1. Basic.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "Basic.identifier",
                    Id = "Basic.identifier",
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
                // 2. Basic.code
                this.Element_Code = new ElementDefinitionInfo
                {
                    Name = "Element_Code",
                    Path= "Basic.code",
                    Id = "Basic.code",
                    Min = 1,
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
                // 3. Basic.subject
                this.Element_Subject = new ElementDefinitionInfo
                {
                    Name = "Element_Subject",
                    Path= "Basic.subject",
                    Id = "Basic.subject",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Resource"
                            }
                        }
                    }
                };
            }
            {
                // 4. Basic.created
                this.Element_Created = new ElementDefinitionInfo
                {
                    Name = "Element_Created",
                    Path= "Basic.created",
                    Id = "Basic.created",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Date
                        {
                        }
                    }
                };
            }
            {
                // 5. Basic.author
                this.Element_Author = new ElementDefinitionInfo
                {
                    Name = "Element_Author",
                    Path= "Basic.author",
                    Id = "Basic.author",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                                "http://hl7.org/fhir/StructureDefinition/Patient",
                                "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                                "http://hl7.org/fhir/StructureDefinition/Organization"
                            }
                        }
                    }
                };
            }
            this.Name = "Basic";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Basic";
        }
    }
}
