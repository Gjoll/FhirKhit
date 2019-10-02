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
      "id": "Organization",
      "url": "http://hl7.org/fhir/StructureDefinition/Organization",
      "version": "4.0.0",
      "name": "Organization",
      "status": "draft",
      "publisher": "Health Level Seven International (Patient Administration)",
      "description": "A formally or informally recognized grouping of people or organizations formed for the purpose of achieving some form of collective action.  Includes companies, institutions, corporations, departments, community groups, healthcare practice groups, payer/insurer, etc.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "Organization",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Organization",
            "path": "Organization",
            "short": "A grouping of people or organizations with a common purpose",
            "definition": "A formally or informally recognized grouping of people or organizations formed for the purpose of achieving some form of collective action.  Includes companies, institutions, corporations, departments, community groups, healthcare practice groups, payer/insurer, etc.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Organization.identifier",
            "path": "Organization.identifier",
            "short": "Identifies this organization  across multiple systems",
            "definition": "Identifier for the organization that is used to identify the organization across multiple disparate systems.",
            "requirements": "Organizations are known by a variety of ids. Some institutions maintain several, and most collect identifiers for exchange with other organizations concerning the organization.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Identifier"
              }
            ],
            "condition": [
              "org-1"
            ],
            "isSummary": true
          },
          {
            "id": "Organization.active",
            "path": "Organization.active",
            "short": "Whether the organization's record is still in active use",
            "definition": "Whether the organization's record is still in active use.",
            "comment": "This active flag is not intended to be used to mark an organization as temporarily closed or under construction. Instead the Location(s) within the Organization should have the suspended status. If further details of the reason for the suspension are required, then an extension on this element should be used.\n\nThis element is labeled as a modifier because it may be used to mark that the resource was created in error.",
            "requirements": "Need a flag to indicate a record is no longer to be used and should generally be hidden for the user in the UI.",
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
            "id": "Organization.type",
            "path": "Organization.type",
            "short": "Kind of organization",
            "definition": "The kind(s) of organization that this is.",
            "comment": "Organizations can be corporations, wards, sections, clinical teams, government departments, etc. Note that code is generally a classifier of the type of organization; in many applications, codes are used to identity a particular organization (say, ward) as opposed to another of the same type - these are identifiers, not codes\n\nWhen considering if multiple types are appropriate, you should evaluate if child organizations would be a more appropriate use of the concept, as different types likely are in different sub-areas of the organization. This is most likely to be used where type values have orthogonal values, such as a religious, academic and medical center.\n\nWe expect that some jurisdictions will profile this optionality to be a single cardinality.",
            "requirements": "Need to be able to track the kind of organization that this is - different organization types have different uses.",
            "min": 0,
            "max": "*",
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
                  "valueString": "OrganizationType"
                }
              ],
              "strength": "example",
              "description": "Used to categorize the organization.",
              "valueSet": "http://hl7.org/fhir/ValueSet/organization-type"
            }
          },
          {
            "id": "Organization.name",
            "path": "Organization.name",
            "short": "Name used for the organization",
            "definition": "A name associated with the organization.",
            "comment": "If the name of an organization changes, consider putting the old name in the alias column so that it can still be located through searches.",
            "requirements": "Need to use the name as the label of the organization.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "condition": [
              "org-1"
            ],
            "isSummary": true
          },
          {
            "id": "Organization.alias",
            "path": "Organization.alias",
            "short": "A list of alternate names that the organization is known as, or was known as in the past",
            "definition": "A list of alternate names that the organization is known as, or was known as in the past.",
            "comment": "There are no dates associated with the alias/historic names, as this is not intended to track when names were used, but to assist in searching so that older names can still result in identifying the organization.",
            "requirements": "Over time locations and organizations go through many changes and can be known by different names.\n\nFor searching knowing previous names that the organization was known by can be very useful.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "Organization.telecom",
            "path": "Organization.telecom",
            "short": "A contact detail for the organization",
            "definition": "A contact detail for the organization.",
            "comment": "The use code 'home' is not to be used. Note that these contacts are not the contact details of people who are employed by or represent the organization, but official contacts for the organization itself.",
            "requirements": "Human contact for the organization.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "ContactPoint"
              }
            ],
            "condition": [
              "org-3"
            ]
          },
          {
            "id": "Organization.address",
            "path": "Organization.address",
            "short": "An address for the organization",
            "definition": "An address for the organization.",
            "comment": "Organization may have multiple addresses with different uses or applicable periods. The use code 'home' is not to be used.",
            "requirements": "May need to keep track of the organization's addresses for contacting, billing or reporting requirements.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Address"
              }
            ],
            "condition": [
              "org-2"
            ]
          },
          {
            "id": "Organization.partOf",
            "path": "Organization.partOf",
            "short": "The organization of which this organization forms a part",
            "definition": "The organization of which this organization forms a part.",
            "requirements": "Need to be able to track the hierarchy of organizations within an organization.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "extension": [
                  {
                    "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-hierarchy",
                    "valueBoolean": true
                  }
                ],
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Organization.contact",
            "path": "Organization.contact",
            "short": "Contact for the organization for a certain purpose",
            "definition": "Contact for the organization for a certain purpose.",
            "comment": "Where multiple contacts for the same purpose are provided there is a standard extension that can be used to determine which one is the preferred contact to use.",
            "requirements": "Need to keep track of assigned contact points within bigger organization.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Organization.contact.purpose",
            "path": "Organization.contact.purpose",
            "short": "The type of contact",
            "definition": "Indicates a purpose for which the contact can be reached.",
            "requirements": "Need to distinguish between multiple contact persons.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ContactPartyType"
                }
              ],
              "strength": "extensible",
              "description": "The purpose for which you would contact a contact party.",
              "valueSet": "http://hl7.org/fhir/ValueSet/contactentity-type"
            }
          },
          {
            "id": "Organization.contact.name",
            "path": "Organization.contact.name",
            "short": "A name associated with the contact",
            "definition": "A name associated with the contact.",
            "requirements": "Need to be able to track the person by name.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "HumanName"
              }
            ]
          },
          {
            "id": "Organization.contact.telecom",
            "path": "Organization.contact.telecom",
            "short": "Contact details (telephone, email, etc.)  for a contact",
            "definition": "A contact detail (e.g. a telephone number or an email address) by which the party may be contacted.",
            "requirements": "People have (primary) ways to contact them in some way such as phone, email.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "ContactPoint"
              }
            ]
          },
          {
            "id": "Organization.contact.address",
            "path": "Organization.contact.address",
            "short": "Visiting or postal addresses for the contact",
            "definition": "Visiting or postal addresses for the contact.",
            "requirements": "May need to keep track of a contact party's address for contacting, billing or reporting requirements.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Address"
              }
            ]
          },
          {
            "id": "Organization.endpoint",
            "path": "Organization.endpoint",
            "short": "Technical endpoints providing access to services operated for the organization",
            "definition": "Technical endpoints providing access to services operated for the organization.",
            "requirements": "Organizations have multiple systems that provide various services and need to be able to define the technical connection details for how to connect to them, and for what purpose.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Endpoint"
                ]
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion
    /// <summary>
    /// Fhir resource 'Organization'
    /// </summary>
    // 0. Organization
    public class Resource_Organization : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 9. Organization.contact
        public class Type_Contact : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 10. Organization.contact.purpose
            public ElementDefinitionInfo Element_Purpose;
            // 11. Organization.contact.name
            public ElementDefinitionInfo Element_Name;
            // 12. Organization.contact.telecom
            public ElementDefinitionInfo Element_Telecom;
            // 13. Organization.contact.address
            public ElementDefinitionInfo Element_Address;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Organization.contact",
                    ElementId = "Organization.contact"
                });
                Element_Purpose.Write(sDef);
                Element_Name.Write(sDef);
                Element_Telecom.Write(sDef);
                Element_Address.Write(sDef);
            }
            
            public Type_Contact()
            {
                {
                    // 10. Organization.contact.purpose
                    this.Element_Purpose = new ElementDefinitionInfo
                    {
                        Name = "Element_Purpose",
                        Path= "Organization.contact.purpose",
                        Id = "Organization.contact.purpose",
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
                    // 11. Organization.contact.name
                    this.Element_Name = new ElementDefinitionInfo
                    {
                        Name = "Element_Name",
                        Path= "Organization.contact.name",
                        Id = "Organization.contact.name",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_HumanName
                            {
                            }
                        }
                    };
                }
                {
                    // 12. Organization.contact.telecom
                    this.Element_Telecom = new ElementDefinitionInfo
                    {
                        Name = "Element_Telecom",
                        Path= "Organization.contact.telecom",
                        Id = "Organization.contact.telecom",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_ContactPoint
                            {
                            }
                        }
                    };
                }
                {
                    // 13. Organization.contact.address
                    this.Element_Address = new ElementDefinitionInfo
                    {
                        Name = "Element_Address",
                        Path= "Organization.contact.address",
                        Id = "Organization.contact.address",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Address
                            {
                            }
                        }
                    };
                }
            }
        }
        // 1. Organization.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. Organization.active
        public ElementDefinitionInfo Element_Active;
        // 3. Organization.type
        public ElementDefinitionInfo Element_Type;
        // 4. Organization.name
        public ElementDefinitionInfo Element_Name;
        // 5. Organization.alias
        public ElementDefinitionInfo Element_Alias;
        // 6. Organization.telecom
        public ElementDefinitionInfo Element_Telecom;
        // 7. Organization.address
        public ElementDefinitionInfo Element_Address;
        // 8. Organization.partOf
        public ElementDefinitionInfo Element_PartOf;
        // 9. Organization.contact
        public ElementDefinitionInfo Element_Contact;
        // 14. Organization.endpoint
        public ElementDefinitionInfo Element_Endpoint;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "Organization",
                ElementId = "Organization"
            });
            Element_Identifier.Write(sDef);
            Element_Active.Write(sDef);
            Element_Type.Write(sDef);
            Element_Name.Write(sDef);
            Element_Alias.Write(sDef);
            Element_Telecom.Write(sDef);
            Element_Address.Write(sDef);
            Element_PartOf.Write(sDef);
            Element_Contact.Write(sDef);
            Element_Endpoint.Write(sDef);
        }
        
        public Resource_Organization()
        {
            {
                // 1. Organization.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "Organization.identifier",
                    Id = "Organization.identifier",
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
                // 2. Organization.active
                this.Element_Active = new ElementDefinitionInfo
                {
                    Name = "Element_Active",
                    Path= "Organization.active",
                    Id = "Organization.active",
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
                // 3. Organization.type
                this.Element_Type = new ElementDefinitionInfo
                {
                    Name = "Element_Type",
                    Path= "Organization.type",
                    Id = "Organization.type",
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
                // 4. Organization.name
                this.Element_Name = new ElementDefinitionInfo
                {
                    Name = "Element_Name",
                    Path= "Organization.name",
                    Id = "Organization.name",
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
                // 5. Organization.alias
                this.Element_Alias = new ElementDefinitionInfo
                {
                    Name = "Element_Alias",
                    Path= "Organization.alias",
                    Id = "Organization.alias",
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
                // 6. Organization.telecom
                this.Element_Telecom = new ElementDefinitionInfo
                {
                    Name = "Element_Telecom",
                    Path= "Organization.telecom",
                    Id = "Organization.telecom",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_ContactPoint
                        {
                        }
                    }
                };
            }
            {
                // 7. Organization.address
                this.Element_Address = new ElementDefinitionInfo
                {
                    Name = "Element_Address",
                    Path= "Organization.address",
                    Id = "Organization.address",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Address
                        {
                        }
                    }
                };
            }
            {
                // 8. Organization.partOf
                this.Element_PartOf = new ElementDefinitionInfo
                {
                    Name = "Element_PartOf",
                    Path= "Organization.partOf",
                    Id = "Organization.partOf",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Organization"
                            }
                        }
                    }
                };
            }
            {
                // 9. Organization.contact
                this.Element_Contact = new ElementDefinitionInfo
                {
                    Name = "Element_Contact",
                    Path= "Organization.contact",
                    Id = "Organization.contact",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Contact
                        {
                        }
                    }
                };
            }
            {
                // 14. Organization.endpoint
                this.Element_Endpoint = new ElementDefinitionInfo
                {
                    Name = "Element_Endpoint",
                    Path= "Organization.endpoint",
                    Id = "Organization.endpoint",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Endpoint"
                            }
                        }
                    }
                };
            }
            this.Name = "Organization";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Organization";
        }
    }
}
