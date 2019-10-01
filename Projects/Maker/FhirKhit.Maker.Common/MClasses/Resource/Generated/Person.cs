using System;                                                                                                                               // MakerGen.cs:451
using System.Diagnostics;                                                                                                                   // MakerGen.cs:452
using System.IO;                                                                                                                            // MakerGen.cs:453
using System.Linq;                                                                                                                          // MakerGen.cs:454
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:455
                                                                                                                                            // MakerGen.cs:456
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:457
{                                                                                                                                           // MakerGen.cs:458
    #region Json                                                                                                                            // MakerGen.cs:459
    #if NEVER                                                                                                                               // MakerGen.cs:460
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
    #endregion                                                                                                                              // MakerGen.cs:463
    /// <summary>
    /// Fhir resource 'Person'
    /// </summary>
    // 0. Person
    public class Person : FhirKhit.Maker.Common.Resource.ResourceBase                                                                       // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class Person_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                          // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 10. Person.link
            public class Type_Link : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Link_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                               // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 11. Person.link.target
                    public ElementDefinitionInfo Target;                                                                                    // MakerGen.cs:236
                    // 12. Person.link.assurance
                    public ElementDefinitionInfo Assurance;                                                                                 // MakerGen.cs:236
                    public Type_Link_Elements()                                                                                             // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 11. Person.link.target
                            this.Target = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Target",                                                                                            // MakerGen.cs:255
                                Path= "Person.link.target",                                                                                 // MakerGen.cs:256
                                Id = "Person.link.target",                                                                                  // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Patient",                                              // MakerGen.cs:348
                                            "http://hl7.org/fhir/StructureDefinition/Practitioner",                                         // MakerGen.cs:348
                                            "http://hl7.org/fhir/StructureDefinition/RelatedPerson",                                        // MakerGen.cs:348
                                            "http://hl7.org/fhir/StructureDefinition/Person"                                                // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 12. Person.link.assurance
                            this.Assurance = new ElementDefinitionInfo                                                                      // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Assurance",                                                                                         // MakerGen.cs:255
                                Path= "Person.link.assurance",                                                                              // MakerGen.cs:256
                                Id = "Person.link.assurance",                                                                               // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Target.Write(sDef);                                                                                                 // MakerGen.cs:240
                        Assurance.Write(sDef);                                                                                              // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Link_Elements Elements { get; }                                                                                 // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Link()                                                                                                          // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Link_Elements();                                                                               // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 1. Person.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:236
            // 2. Person.name
            public ElementDefinitionInfo Name;                                                                                              // MakerGen.cs:236
            // 3. Person.telecom
            public ElementDefinitionInfo Telecom;                                                                                           // MakerGen.cs:236
            // 4. Person.gender
            public ElementDefinitionInfo Gender;                                                                                            // MakerGen.cs:236
            // 5. Person.birthDate
            public ElementDefinitionInfo BirthDate;                                                                                         // MakerGen.cs:236
            // 6. Person.address
            public ElementDefinitionInfo Address;                                                                                           // MakerGen.cs:236
            // 7. Person.photo
            public ElementDefinitionInfo Photo;                                                                                             // MakerGen.cs:236
            // 8. Person.managingOrganization
            public ElementDefinitionInfo ManagingOrganization;                                                                              // MakerGen.cs:236
            // 9. Person.active
            public ElementDefinitionInfo Active;                                                                                            // MakerGen.cs:236
            public Person_Elements()                                                                                                        // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:251
                    // 1. Person.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Identifier",                                                                                                // MakerGen.cs:255
                        Path= "Person.identifier",                                                                                          // MakerGen.cs:256
                        Id = "Person.identifier",                                                                                           // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 2. Person.name
                    this.Name = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Name",                                                                                                      // MakerGen.cs:255
                        Path= "Person.name",                                                                                                // MakerGen.cs:256
                        Id = "Person.name",                                                                                                 // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.HumanName                                                                     // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 3. Person.telecom
                    this.Telecom = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Telecom",                                                                                                   // MakerGen.cs:255
                        Path= "Person.telecom",                                                                                             // MakerGen.cs:256
                        Id = "Person.telecom",                                                                                              // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.ContactPoint                                                                  // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 4. Person.gender
                    this.Gender = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Gender",                                                                                                    // MakerGen.cs:255
                        Path= "Person.gender",                                                                                              // MakerGen.cs:256
                        Id = "Person.gender",                                                                                               // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 5. Person.birthDate
                    this.BirthDate = new ElementDefinitionInfo                                                                              // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "BirthDate",                                                                                                 // MakerGen.cs:255
                        Path= "Person.birthDate",                                                                                           // MakerGen.cs:256
                        Id = "Person.birthDate",                                                                                            // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Date                                                                        // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 6. Person.address
                    this.Address = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Address",                                                                                                   // MakerGen.cs:255
                        Path= "Person.address",                                                                                             // MakerGen.cs:256
                        Id = "Person.address",                                                                                              // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Address                                                                       // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 7. Person.photo
                    this.Photo = new ElementDefinitionInfo                                                                                  // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Photo",                                                                                                     // MakerGen.cs:255
                        Path= "Person.photo",                                                                                               // MakerGen.cs:256
                        Id = "Person.photo",                                                                                                // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Attachment                                                                    // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 8. Person.managingOrganization
                    this.ManagingOrganization = new ElementDefinitionInfo                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "ManagingOrganization",                                                                                      // MakerGen.cs:255
                        Path= "Person.managingOrganization",                                                                                // MakerGen.cs:256
                        Id = "Person.managingOrganization",                                                                                 // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 9. Person.active
                    this.Active = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Active",                                                                                                    // MakerGen.cs:255
                        Path= "Person.active",                                                                                              // MakerGen.cs:256
                        Id = "Person.active",                                                                                               // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Boolean                                                                     // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:429
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:414
            {                                                                                                                               // MakerGen.cs:415
                base.Write(sDef);                                                                                                           // MakerGen.cs:416
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:240
                Name.Write(sDef);                                                                                                           // MakerGen.cs:240
                Telecom.Write(sDef);                                                                                                        // MakerGen.cs:240
                Gender.Write(sDef);                                                                                                         // MakerGen.cs:240
                BirthDate.Write(sDef);                                                                                                      // MakerGen.cs:240
                Address.Write(sDef);                                                                                                        // MakerGen.cs:240
                Photo.Write(sDef);                                                                                                          // MakerGen.cs:240
                ManagingOrganization.Write(sDef);                                                                                           // MakerGen.cs:240
                Active.Write(sDef);                                                                                                         // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public Person_Elements Elements { get; }                                                                                            // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public Person()                                                                                                                     // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new Person_Elements();                                                                                          // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:468
