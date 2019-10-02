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
      "id": "Practitioner",
      "url": "http://hl7.org/fhir/StructureDefinition/Practitioner",
      "version": "4.0.0",
      "name": "Practitioner",
      "status": "draft",
      "publisher": "Health Level Seven International (Patient Administration)",
      "description": "A person who is directly or indirectly involved in the provisioning of healthcare.",
      "purpose": "Need to track doctors, staff, locums etc. for both healthcare practitioners, funders, etc.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "Practitioner",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Practitioner",
            "path": "Practitioner",
            "short": "A person with a  formal responsibility in the provisioning of healthcare or related services",
            "definition": "A person who is directly or indirectly involved in the provisioning of healthcare.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Practitioner.identifier",
            "path": "Practitioner.identifier",
            "short": "An identifier for the person as this agent",
            "definition": "An identifier that applies to this person in this role.",
            "requirements": "Often, specific identities are assigned for the agent.",
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
            "id": "Practitioner.active",
            "path": "Practitioner.active",
            "short": "Whether this practitioner's record is in active use",
            "definition": "Whether this practitioner's record is in active use.",
            "comment": "If the practitioner is not in use by one organization, then it should mark the period on the PractitonerRole with an end date (even if they are active) as they may be active in another role.",
            "requirements": "Need to be able to mark a practitioner record as not to be used because it was created in error.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "meaningWhenMissing": "This resource is generally assumed to be active if no value is provided for the active element",
            "isSummary": true
          },
          {
            "id": "Practitioner.name",
            "path": "Practitioner.name",
            "short": "The name(s) associated with the practitioner",
            "definition": "The name(s) associated with the practitioner.",
            "comment": "The selection of the use property should ensure that there is a single usual name specified, and others use the nickname (alias), old, or other values as appropriate.  \r\rIn general, select the value to be used in the ResourceReference.display based on this:\r\r1. There is more than 1 name\r2. Use = usual\r3. Period is current to the date of the usage\r4. Use = official\r5. Other order as decided by internal business rules.",
            "requirements": "The name(s) that a Practitioner is known by. Where there are multiple, the name that the practitioner is usually known as should be used in the display.",
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
            "id": "Practitioner.telecom",
            "path": "Practitioner.telecom",
            "short": "A contact detail for the practitioner (that apply to all roles)",
            "definition": "A contact detail for the practitioner, e.g. a telephone number or an email address.",
            "comment": "Person may have multiple ways to be contacted with different uses or applicable periods.  May need to have options for contacting the person urgently and to help with identification.  These typically will have home numbers, or mobile numbers that are not role specific.",
            "requirements": "Need to know how to reach a practitioner independent to any roles the practitioner may have.",
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
            "id": "Practitioner.address",
            "path": "Practitioner.address",
            "short": "Address(es) of the practitioner that are not role specific (typically home address)",
            "definition": "Address(es) of the practitioner that are not role specific (typically home address). \rWork addresses are not typically entered in this property as they are usually role dependent.",
            "comment": "The PractitionerRole does not have an address value on it, as it is expected that the location property be used for this purpose (which has an address).",
            "requirements": "The home/mailing address of the practitioner is often required for employee administration purposes, and also for some rostering services where the start point (practitioners home) can be used in calculations.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Address"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Practitioner.gender",
            "path": "Practitioner.gender",
            "short": "male | female | other | unknown",
            "definition": "Administrative Gender - the gender that the person is considered to have for administration and record keeping purposes.",
            "requirements": "Needed to address the person correctly.",
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
            "id": "Practitioner.birthDate",
            "path": "Practitioner.birthDate",
            "short": "The date  on which the practitioner was born",
            "definition": "The date of birth for the practitioner.",
            "requirements": "Needed for identification.",
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
            "id": "Practitioner.photo",
            "path": "Practitioner.photo",
            "short": "Image of the person",
            "definition": "Image of the person.",
            "requirements": "Many EHR systems have the capability to capture an image of patients and personnel. Fits with newer social media usage too.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Attachment"
              }
            ]
          },
          {
            "id": "Practitioner.qualification",
            "path": "Practitioner.qualification",
            "short": "Certification, licenses, or training pertaining to the provision of care",
            "definition": "The official certifications, training, and licenses that authorize or otherwise pertain to the provision of care by the practitioner.  For example, a medical license issued by a medical board authorizing the practitioner to practice medicine within a certian locality.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Practitioner.qualification.identifier",
            "path": "Practitioner.qualification.identifier",
            "short": "An identifier for this qualification for the practitioner",
            "definition": "An identifier that applies to this person's qualification in this role.",
            "requirements": "Often, specific identities are assigned for the qualification.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Identifier"
              }
            ]
          },
          {
            "id": "Practitioner.qualification.code",
            "path": "Practitioner.qualification.code",
            "short": "Coded representation of the qualification",
            "definition": "Coded representation of the qualification.",
            "min": 1,
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
                  "valueString": "Qualification"
                }
              ],
              "strength": "example",
              "description": "Specific qualification the practitioner has to provide a service.",
              "valueSet": "http://terminology.hl7.org/ValueSet/v2-2.7-0360"
            }
          },
          {
            "id": "Practitioner.qualification.period",
            "path": "Practitioner.qualification.period",
            "short": "Period during which the qualification is valid",
            "definition": "Period during which the qualification is valid.",
            "requirements": "Qualifications are often for a limited period of time, and can be revoked.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Period"
              }
            ]
          },
          {
            "id": "Practitioner.qualification.issuer",
            "path": "Practitioner.qualification.issuer",
            "short": "Organization that regulates and issues the qualification",
            "definition": "Organization that regulates and issues the qualification.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ]
          },
          {
            "id": "Practitioner.communication",
            "path": "Practitioner.communication",
            "short": "A language the practitioner can use in patient communication",
            "definition": "A language the practitioner can use in patient communication.",
            "comment": "The structure aa-BB with this exact casing is one the most widely used notations for locale. However not all systems code this but instead have it as free text. Hence CodeableConcept instead of code as the data type.",
            "requirements": "Knowing which language a practitioner speaks can help in facilitating communication with patients.",
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
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-maxValueSet",
                  "valueCanonical": "http://hl7.org/fhir/ValueSet/all-languages"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "Language"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "preferred",
              "description": "A human language.",
              "valueSet": "http://hl7.org/fhir/ValueSet/languages"
            }
          }
        ]
      }
    }
    #endif
    #endregion
    /// <summary>
    /// Fhir resource 'Practitioner'
    /// </summary>
    // 0. Practitioner
    public partial class Resource_Practitioner : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 9. Practitioner.qualification
        public partial class Type_Qualification : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 10. Practitioner.qualification.identifier
            public ElementDefinitionInfo Element_Identifier;
            // 11. Practitioner.qualification.code
            public ElementDefinitionInfo Element_Code;
            // 12. Practitioner.qualification.period
            public ElementDefinitionInfo Element_Period;
            // 13. Practitioner.qualification.issuer
            public ElementDefinitionInfo Element_Issuer;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Practitioner.qualification",
                    ElementId = "Practitioner.qualification"
                });
                Element_Identifier.Write(sDef);
                Element_Code.Write(sDef);
                Element_Period.Write(sDef);
                Element_Issuer.Write(sDef);
            }
            
            public Type_Qualification()
            {
                {
                    // 10. Practitioner.qualification.identifier
                    this.Element_Identifier = new ElementDefinitionInfo
                    {
                        Name = "Element_Identifier",
                        Path= "Practitioner.qualification.identifier",
                        Id = "Practitioner.qualification.identifier",
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
                    // 11. Practitioner.qualification.code
                    this.Element_Code = new ElementDefinitionInfo
                    {
                        Name = "Element_Code",
                        Path= "Practitioner.qualification.code",
                        Id = "Practitioner.qualification.code",
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
                    // 12. Practitioner.qualification.period
                    this.Element_Period = new ElementDefinitionInfo
                    {
                        Name = "Element_Period",
                        Path= "Practitioner.qualification.period",
                        Id = "Practitioner.qualification.period",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Period
                            {
                            }
                        }
                    };
                }
                {
                    // 13. Practitioner.qualification.issuer
                    this.Element_Issuer = new ElementDefinitionInfo
                    {
                        Name = "Element_Issuer",
                        Path= "Practitioner.qualification.issuer",
                        Id = "Practitioner.qualification.issuer",
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
            }
        }
        // 1. Practitioner.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. Practitioner.active
        public ElementDefinitionInfo Element_Active;
        // 3. Practitioner.name
        public ElementDefinitionInfo Element_Name;
        // 4. Practitioner.telecom
        public ElementDefinitionInfo Element_Telecom;
        // 5. Practitioner.address
        public ElementDefinitionInfo Element_Address;
        // 6. Practitioner.gender
        public ElementDefinitionInfo Element_Gender;
        // 7. Practitioner.birthDate
        public ElementDefinitionInfo Element_BirthDate;
        // 8. Practitioner.photo
        public ElementDefinitionInfo Element_Photo;
        // 9. Practitioner.qualification
        public ElementDefinitionInfo Element_Qualification;
        // 14. Practitioner.communication
        public ElementDefinitionInfo Element_Communication;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "Practitioner",
                ElementId = "Practitioner"
            });
            Element_Identifier.Write(sDef);
            Element_Active.Write(sDef);
            Element_Name.Write(sDef);
            Element_Telecom.Write(sDef);
            Element_Address.Write(sDef);
            Element_Gender.Write(sDef);
            Element_BirthDate.Write(sDef);
            Element_Photo.Write(sDef);
            Element_Qualification.Write(sDef);
            Element_Communication.Write(sDef);
        }
        
        public Resource_Practitioner()
        {
            {
                // 1. Practitioner.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "Practitioner.identifier",
                    Id = "Practitioner.identifier",
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
                // 2. Practitioner.active
                this.Element_Active = new ElementDefinitionInfo
                {
                    Name = "Element_Active",
                    Path= "Practitioner.active",
                    Id = "Practitioner.active",
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
                // 3. Practitioner.name
                this.Element_Name = new ElementDefinitionInfo
                {
                    Name = "Element_Name",
                    Path= "Practitioner.name",
                    Id = "Practitioner.name",
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
                // 4. Practitioner.telecom
                this.Element_Telecom = new ElementDefinitionInfo
                {
                    Name = "Element_Telecom",
                    Path= "Practitioner.telecom",
                    Id = "Practitioner.telecom",
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
                // 5. Practitioner.address
                this.Element_Address = new ElementDefinitionInfo
                {
                    Name = "Element_Address",
                    Path= "Practitioner.address",
                    Id = "Practitioner.address",
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
                // 6. Practitioner.gender
                this.Element_Gender = new ElementDefinitionInfo
                {
                    Name = "Element_Gender",
                    Path= "Practitioner.gender",
                    Id = "Practitioner.gender",
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
                // 7. Practitioner.birthDate
                this.Element_BirthDate = new ElementDefinitionInfo
                {
                    Name = "Element_BirthDate",
                    Path= "Practitioner.birthDate",
                    Id = "Practitioner.birthDate",
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
                // 8. Practitioner.photo
                this.Element_Photo = new ElementDefinitionInfo
                {
                    Name = "Element_Photo",
                    Path= "Practitioner.photo",
                    Id = "Practitioner.photo",
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
                // 9. Practitioner.qualification
                this.Element_Qualification = new ElementDefinitionInfo
                {
                    Name = "Element_Qualification",
                    Path= "Practitioner.qualification",
                    Id = "Practitioner.qualification",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Qualification
                        {
                        }
                    }
                };
            }
            {
                // 14. Practitioner.communication
                this.Element_Communication = new ElementDefinitionInfo
                {
                    Name = "Element_Communication",
                    Path= "Practitioner.communication",
                    Id = "Practitioner.communication",
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
            this.Name = "Practitioner";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Practitioner";
        }
    }
}
