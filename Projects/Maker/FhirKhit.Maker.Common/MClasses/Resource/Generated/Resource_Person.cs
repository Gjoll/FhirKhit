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
      "id": "Person",
      "url": "http://hl7.org/fhir/StructureDefinition/Person",
      "version": "4.0.0",
      "name": "Person",
      "status": "draft",
      "publisher": "Health Level Seven International (Patient Administration)",
      "description": "Demographics and administrative information about a person independent of a specific health-related context.",
      "purpose": "Need to track persons potentially across multiple roles.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "Person",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Person",
            "path": "Person",
            "short": "A generic person record",
            "definition": "Demographics and administrative information about a person independent of a specific health-related context.",
            "comment": "The Person resource does justice to person registries that keep track of persons regardless of their role. The Person resource is also a primary resource to point to for people acting in a particular role such as SubjectofCare, Practitioner, and Agent. Very few attributes are specific to any role and so Person is kept lean. Most attributes are expected to be tied to the role the Person plays rather than the Person himself. Examples of that are Guardian (SubjectofCare), ContactParty (SubjectOfCare, Practitioner), and multipleBirthInd (SubjectofCare).",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Person.identifier",
            "path": "Person.identifier",
            "short": "A human identifier for this person",
            "definition": "Identifier for a person within a particular scope.",
            "requirements": "People are known by a variety of ids. Some institutions maintain several, and most collect identifiers for exchange with other organizations concerning the person. Examples are national person identifier and local identifier.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Identifier"
              }
            ]
          },
          {
            "id": "Person.name",
            "path": "Person.name",
            "short": "A name associated with the person",
            "definition": "A name associated with the person.",
            "comment": "Person may have multiple names with different uses or applicable periods.",
            "requirements": "Need to be able to track the person by multiple names. Examples are your official name and a partner name.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "HumanName"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Person.telecom",
            "path": "Person.telecom",
            "short": "A contact detail for the person",
            "definition": "A contact detail for the person, e.g. a telephone number or an email address.",
            "comment": "Person may have multiple ways to be contacted with different uses or applicable periods.  May need to have options for contacting the person urgently and also to help with identification.",
            "requirements": "People have (primary) ways to contact them in some way such as phone, email.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "ContactPoint"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Person.gender",
            "path": "Person.gender",
            "short": "male | female | other | unknown",
            "definition": "Administrative Gender.",
            "comment": "The gender might not match the biological sex as determined by genetics, or the individual's preferred identification. Note that for both humans and particularly animals, there are other legitimate possibilities than M and F, though a clear majority of systems and contexts only support M and F.",
            "requirements": "Needed for identification of the person, in combination with (at least) name and birth date. Gender of person drives many clinical processes.",
            "min": 0,
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
                  "valueString": "AdministrativeGender"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "required",
              "description": "The gender of a person used for administrative purposes.",
              "valueSet": "http://hl7.org/fhir/ValueSet/administrative-gender|4.0.0"
            }
          },
          {
            "id": "Person.birthDate",
            "path": "Person.birthDate",
            "short": "The date on which the person was born",
            "definition": "The birth date for the person.",
            "comment": "At least an estimated year should be provided as a guess if the real DOB is unknown.",
            "requirements": "Age of person drives many clinical processes, and is often used in performing identification of the person. Times are not included so as to not confuse things with potential timezone issues.",
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
            "id": "Person.address",
            "path": "Person.address",
            "short": "One or more addresses for the person",
            "definition": "One or more addresses for the person.",
            "comment": "Person may have multiple addresses with different uses or applicable periods.",
            "requirements": "May need to keep track of person's addresses for contacting, billing or reporting requirements and also to help with identification.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Address"
              }
            ]
          },
          {
            "id": "Person.photo",
            "path": "Person.photo",
            "short": "Image of the person",
            "definition": "An image that can be displayed as a thumbnail of the person to enhance the identification of the individual.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Attachment"
              }
            ]
          },
          {
            "id": "Person.managingOrganization",
            "path": "Person.managingOrganization",
            "short": "The organization that is the custodian of the person record",
            "definition": "The organization that is the custodian of the person record.",
            "requirements": "Need to know who recognizes this person record, manages and updates it.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Person.active",
            "path": "Person.active",
            "short": "This person's record is in active use",
            "definition": "Whether this person's record is in active use.",
            "requirements": "Need to be able to mark a person record as not to be used because it was created in error.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "isModifier": true,
            "isModifierReason": "This element is labelled as a modifier because it is a status element that can indicate that a record should not be treated as valid",
            "isSummary": true
          },
          {
            "id": "Person.link",
            "path": "Person.link",
            "short": "Link to a resource that concerns the same actual person",
            "definition": "Link to a resource that concerns the same actual person.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Person.link.target",
            "path": "Person.link.target",
            "short": "The resource to which this actual person is associated",
            "definition": "The resource to which this actual person is associated.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                  "http://hl7.org/fhir/StructureDefinition/Person"
                ]
              }
            ]
          },
          {
            "id": "Person.link.assurance",
            "path": "Person.link.assurance",
            "short": "level1 | level2 | level3 | level4",
            "definition": "Level of assurance that this link is associated with the target resource.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "IdentityAssuranceLevel"
                }
              ],
              "strength": "required",
              "description": "The level of confidence that this link represents the same actual person, based on NIST Authentication Levels.",
              "valueSet": "http://hl7.org/fhir/ValueSet/identity-assuranceLevel|4.0.0"
            }
          }
        ]
      }
    }
    #endif
    #endregion
    /// <summary>
    /// Fhir resource 'Person'
    /// </summary>
    // 0. Person
    public class Resource_Person : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 10. Person.link
        public class Type_Link : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 11. Person.link.target
            public ElementDefinitionInfo Element_Target;
            // 12. Person.link.assurance
            public ElementDefinitionInfo Element_Assurance;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Person.link",
                    ElementId = "Person.link"
                });
                Element_Target.Write(sDef);
                Element_Assurance.Write(sDef);
            }
            
            public Type_Link()
            {
                {
                    // 11. Person.link.target
                    this.Element_Target = new ElementDefinitionInfo
                    {
                        Name = "Element_Target",
                        Path= "Person.link.target",
                        Id = "Person.link.target",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Patient",
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                                    "http://hl7.org/fhir/StructureDefinition/Person"
                                }
                            }
                        }
                    };
                }
                {
                    // 12. Person.link.assurance
                    this.Element_Assurance = new ElementDefinitionInfo
                    {
                        Name = "Element_Assurance",
                        Path= "Person.link.assurance",
                        Id = "Person.link.assurance",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Code
                            {
                            }
                        }
                    };
                }
            }
        }
        // 1. Person.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. Person.name
        public ElementDefinitionInfo Element_Name;
        // 3. Person.telecom
        public ElementDefinitionInfo Element_Telecom;
        // 4. Person.gender
        public ElementDefinitionInfo Element_Gender;
        // 5. Person.birthDate
        public ElementDefinitionInfo Element_BirthDate;
        // 6. Person.address
        public ElementDefinitionInfo Element_Address;
        // 7. Person.photo
        public ElementDefinitionInfo Element_Photo;
        // 8. Person.managingOrganization
        public ElementDefinitionInfo Element_ManagingOrganization;
        // 9. Person.active
        public ElementDefinitionInfo Element_Active;
        // 10. Person.link
        public ElementDefinitionInfo Element_Link;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "Person",
                ElementId = "Person"
            });
            Element_Identifier.Write(sDef);
            Element_Name.Write(sDef);
            Element_Telecom.Write(sDef);
            Element_Gender.Write(sDef);
            Element_BirthDate.Write(sDef);
            Element_Address.Write(sDef);
            Element_Photo.Write(sDef);
            Element_ManagingOrganization.Write(sDef);
            Element_Active.Write(sDef);
            Element_Link.Write(sDef);
        }
        
        public Resource_Person()
        {
            {
                // 1. Person.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "Person.identifier",
                    Id = "Person.identifier",
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
                // 2. Person.name
                this.Element_Name = new ElementDefinitionInfo
                {
                    Name = "Element_Name",
                    Path= "Person.name",
                    Id = "Person.name",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_HumanName
                        {
                        }
                    }
                };
            }
            {
                // 3. Person.telecom
                this.Element_Telecom = new ElementDefinitionInfo
                {
                    Name = "Element_Telecom",
                    Path= "Person.telecom",
                    Id = "Person.telecom",
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
                // 4. Person.gender
                this.Element_Gender = new ElementDefinitionInfo
                {
                    Name = "Element_Gender",
                    Path= "Person.gender",
                    Id = "Person.gender",
                    Min = 0,
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
                // 5. Person.birthDate
                this.Element_BirthDate = new ElementDefinitionInfo
                {
                    Name = "Element_BirthDate",
                    Path= "Person.birthDate",
                    Id = "Person.birthDate",
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
                // 6. Person.address
                this.Element_Address = new ElementDefinitionInfo
                {
                    Name = "Element_Address",
                    Path= "Person.address",
                    Id = "Person.address",
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
                // 7. Person.photo
                this.Element_Photo = new ElementDefinitionInfo
                {
                    Name = "Element_Photo",
                    Path= "Person.photo",
                    Id = "Person.photo",
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
            {
                // 8. Person.managingOrganization
                this.Element_ManagingOrganization = new ElementDefinitionInfo
                {
                    Name = "Element_ManagingOrganization",
                    Path= "Person.managingOrganization",
                    Id = "Person.managingOrganization",
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
                // 9. Person.active
                this.Element_Active = new ElementDefinitionInfo
                {
                    Name = "Element_Active",
                    Path= "Person.active",
                    Id = "Person.active",
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
                // 10. Person.link
                this.Element_Link = new ElementDefinitionInfo
                {
                    Name = "Element_Link",
                    Path= "Person.link",
                    Id = "Person.link",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Link
                        {
                        }
                    }
                };
            }
            this.Name = "Person";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Person";
        }
    }
}
