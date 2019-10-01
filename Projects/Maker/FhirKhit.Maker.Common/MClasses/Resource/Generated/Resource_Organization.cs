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
    #endregion                                                                                                                              // MakerGen.cs:440
    /// <summary>
    /// Fhir resource 'Organization'
    /// </summary>
    // 0. Organization
    public class Resource_Organization : FhirKhit.Maker.Common.Resource.ResourceBase                                                        // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        // 9. Organization.contact
        public class Type_Contact : FhirKhit.Maker.Common.Complex.ComplexBase                                                               // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 10. Organization.contact.purpose
            public ElementDefinitionInfo Element_Purpose;                                                                                   // MakerGen.cs:212
            // 11. Organization.contact.name
            public ElementDefinitionInfo Element_Name;                                                                                      // MakerGen.cs:212
            // 12. Organization.contact.telecom
            public ElementDefinitionInfo Element_Telecom;                                                                                   // MakerGen.cs:212
            // 13. Organization.contact.address
            public ElementDefinitionInfo Element_Address;                                                                                   // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "Organization.contact",                                                                                          // MakerGen.cs:388
                    ElementId = "Organization.contact"                                                                                      // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Purpose.Write(sDef);                                                                                                // MakerGen.cs:216
                Element_Name.Write(sDef);                                                                                                   // MakerGen.cs:216
                Element_Telecom.Write(sDef);                                                                                                // MakerGen.cs:216
                Element_Address.Write(sDef);                                                                                                // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_Contact()                                                                                                           // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 10. Organization.contact.purpose
                    this.Element_Purpose = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Purpose",                                                                                           // MakerGen.cs:231
                        Path= "Organization.contact.purpose",                                                                               // MakerGen.cs:232
                        Id = "Organization.contact.purpose",                                                                                // MakerGen.cs:233
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
                    // 11. Organization.contact.name
                    this.Element_Name = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Name",                                                                                              // MakerGen.cs:231
                        Path= "Organization.contact.name",                                                                                  // MakerGen.cs:232
                        Id = "Organization.contact.name",                                                                                   // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_HumanName                                                                // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            }                                                                                                               // MakerGen.cs:353
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 12. Organization.contact.telecom
                    this.Element_Telecom = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Telecom",                                                                                           // MakerGen.cs:231
                        Path= "Organization.contact.telecom",                                                                               // MakerGen.cs:232
                        Id = "Organization.contact.telecom",                                                                                // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_ContactPoint                                                             // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            }                                                                                                               // MakerGen.cs:353
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 13. Organization.contact.address
                    this.Element_Address = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Address",                                                                                           // MakerGen.cs:231
                        Path= "Organization.contact.address",                                                                               // MakerGen.cs:232
                        Id = "Organization.contact.address",                                                                                // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Address                                                                  // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            }                                                                                                               // MakerGen.cs:353
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 1. Organization.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:212
        // 2. Organization.active
        public ElementDefinitionInfo Element_Active;                                                                                        // MakerGen.cs:212
        // 3. Organization.type
        public ElementDefinitionInfo Element_Type;                                                                                          // MakerGen.cs:212
        // 4. Organization.name
        public ElementDefinitionInfo Element_Name;                                                                                          // MakerGen.cs:212
        // 5. Organization.alias
        public ElementDefinitionInfo Element_Alias;                                                                                         // MakerGen.cs:212
        // 6. Organization.telecom
        public ElementDefinitionInfo Element_Telecom;                                                                                       // MakerGen.cs:212
        // 7. Organization.address
        public ElementDefinitionInfo Element_Address;                                                                                       // MakerGen.cs:212
        // 8. Organization.partOf
        public ElementDefinitionInfo Element_PartOf;                                                                                        // MakerGen.cs:212
        // 9. Organization.contact
        public ElementDefinitionInfo Element_Contact;                                                                                       // MakerGen.cs:212
        // 14. Organization.endpoint
        public ElementDefinitionInfo Element_Endpoint;                                                                                      // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            base.Write(sDef);                                                                                                               // MakerGen.cs:385
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:386
            {                                                                                                                               // MakerGen.cs:387
                Path = "Organization",                                                                                                      // MakerGen.cs:388
                ElementId = "Organization"                                                                                                  // MakerGen.cs:389
            });                                                                                                                             // MakerGen.cs:390
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_Active.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_Type.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_Name.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_Alias.Write(sDef);                                                                                                      // MakerGen.cs:216
            Element_Telecom.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Address.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_PartOf.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_Contact.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Endpoint.Write(sDef);                                                                                                   // MakerGen.cs:216
        }                                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
        public Resource_Organization()                                                                                                      // MakerGen.cs:395
        {                                                                                                                                   // MakerGen.cs:396
            {                                                                                                                               // MakerGen.cs:227
                // 1. Organization.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:231
                    Path= "Organization.identifier",                                                                                        // MakerGen.cs:232
                    Id = "Organization.identifier",                                                                                         // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 2. Organization.active
                this.Element_Active = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Active",                                                                                                // MakerGen.cs:231
                    Path= "Organization.active",                                                                                            // MakerGen.cs:232
                    Id = "Organization.active",                                                                                             // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                               // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 3. Organization.type
                this.Element_Type = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Type",                                                                                                  // MakerGen.cs:231
                    Path= "Organization.type",                                                                                              // MakerGen.cs:232
                    Id = "Organization.type",                                                                                               // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 4. Organization.name
                this.Element_Name = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Name",                                                                                                  // MakerGen.cs:231
                    Path= "Organization.name",                                                                                              // MakerGen.cs:232
                    Id = "Organization.name",                                                                                               // MakerGen.cs:233
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
                // 5. Organization.alias
                this.Element_Alias = new ElementDefinitionInfo                                                                              // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Alias",                                                                                                 // MakerGen.cs:231
                    Path= "Organization.alias",                                                                                             // MakerGen.cs:232
                    Id = "Organization.alias",                                                                                              // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 6. Organization.telecom
                this.Element_Telecom = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Telecom",                                                                                               // MakerGen.cs:231
                    Path= "Organization.telecom",                                                                                           // MakerGen.cs:232
                    Id = "Organization.telecom",                                                                                            // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_ContactPoint                                                                 // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 7. Organization.address
                this.Element_Address = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Address",                                                                                               // MakerGen.cs:231
                    Path= "Organization.address",                                                                                           // MakerGen.cs:232
                    Id = "Organization.address",                                                                                            // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Address                                                                      // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 8. Organization.partOf
                this.Element_PartOf = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_PartOf",                                                                                                // MakerGen.cs:231
                    Path= "Organization.partOf",                                                                                            // MakerGen.cs:232
                    Id = "Organization.partOf",                                                                                             // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Organization"                                                      // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 9. Organization.contact
                this.Element_Contact = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Contact",                                                                                               // MakerGen.cs:231
                    Path= "Organization.contact",                                                                                           // MakerGen.cs:232
                    Id = "Organization.contact",                                                                                            // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_Contact                                                                                                    // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 14. Organization.endpoint
                this.Element_Endpoint = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Endpoint",                                                                                              // MakerGen.cs:231
                    Path= "Organization.endpoint",                                                                                          // MakerGen.cs:232
                    Id = "Organization.endpoint",                                                                                           // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Endpoint"                                                          // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            this.Name = "Organization";                                                                                                     // MakerGen.cs:458
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Organization";                                                              // MakerGen.cs:459
        }                                                                                                                                   // MakerGen.cs:398
    }                                                                                                                                       // MakerGen.cs:400
}                                                                                                                                           // MakerGen.cs:445
