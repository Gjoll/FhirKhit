using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;

namespace FhirKhit.Maker.Common.Complex
{
    #region Json
    #if NEVER
    {
      "resourceType": "StructureDefinition",
      "id": "Contributor",
      "url": "http://hl7.org/fhir/StructureDefinition/Contributor",
      "version": "4.0.0",
      "name": "Contributor",
      "status": "draft",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for Contributor Type: A contributor to the content of a knowledge asset, including authors, editors, reviewers, and endorsers.",
      "purpose": "Need to track contributor information in the same way across multiple resources.",
      "fhirVersion": "4.0.0",
      "kind": "complex-type",
      "abstract": false,
      "type": "Contributor",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Contributor",
            "path": "Contributor",
            "short": "Contributor information",
            "definition": "A contributor to the content of a knowledge asset, including authors, editors, reviewers, and endorsers.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Contributor.type",
            "path": "Contributor.type",
            "short": "author | editor | reviewer | endorser",
            "definition": "The type of contributor.",
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
                  "valueString": "ContributorType"
                }
              ],
              "strength": "required",
              "description": "The type of contributor.",
              "valueSet": "http://hl7.org/fhir/ValueSet/contributor-type|4.0.0"
            }
          },
          {
            "id": "Contributor.name",
            "path": "Contributor.name",
            "short": "Who contributed the content",
            "definition": "The name of the individual or organization responsible for the contribution.",
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
            "id": "Contributor.contact",
            "path": "Contributor.contact",
            "short": "Contact details of the contributor",
            "definition": "Contact details to assist a user in finding and communicating with the contributor.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "ContactDetail"
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
    /// Fhir complex 'Contributor'
    /// </summary>
    // 0. Contributor
    public partial class Type_Contributor : FhirKhit.Maker.Common.Complex.ComplexBase
    {
        // 1. Contributor.type
        public ElementDefinitionInfo Element_Type;
        // 2. Contributor.name
        public ElementDefinitionInfo Element_Name;
        // 3. Contributor.contact
        public ElementDefinitionInfo Element_Contact;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "Contributor",
                ElementId = "Contributor"
            });
            Element_Type.Write(sDef);
            Element_Name.Write(sDef);
            Element_Contact.Write(sDef);
        }
        
        public Type_Contributor()
        {
            {
                // 1. Contributor.type
                this.Element_Type = new ElementDefinitionInfo
                {
                    Name = "Element_Type",
                    Path= "Contributor.type",
                    Id = "Contributor.type",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code
                        {
                        }
                    }
                };
            }
            {
                // 2. Contributor.name
                this.Element_Name = new ElementDefinitionInfo
                {
                    Name = "Element_Name",
                    Path= "Contributor.name",
                    Id = "Contributor.name",
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
                // 3. Contributor.contact
                this.Element_Contact = new ElementDefinitionInfo
                {
                    Name = "Element_Contact",
                    Path= "Contributor.contact",
                    Id = "Contributor.contact",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_ContactDetail
                        {
                        }
                    }
                };
            }
        }
    }
}
