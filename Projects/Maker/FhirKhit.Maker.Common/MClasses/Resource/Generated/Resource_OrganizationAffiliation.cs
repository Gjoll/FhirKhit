using System;                                                                                                                               // MakerGen.cs:454
using System.Diagnostics;                                                                                                                   // MakerGen.cs:455
using System.IO;                                                                                                                            // MakerGen.cs:456
using System.Linq;                                                                                                                          // MakerGen.cs:457
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:458
                                                                                                                                            // MakerGen.cs:459
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:460
{                                                                                                                                           // MakerGen.cs:461
    #region Json                                                                                                                            // MakerGen.cs:462
    #if NEVER                                                                                                                               // MakerGen.cs:463
    {
      "resourceType": "StructureDefinition",
      "id": "OrganizationAffiliation",
      "url": "http://hl7.org/fhir/StructureDefinition/OrganizationAffiliation",
      "version": "4.0.0",
      "name": "OrganizationAffiliation",
      "status": "draft",
      "publisher": "Health Level Seven International (Patient Administration)",
      "description": "Defines an affiliation/assotiation/relationship between 2 distinct oganizations, that is not a part-of relationship/sub-division relationship.",
      "purpose": "Need to define relationships between organizations that are not sub-divisions of the same organization (part-of relationships).",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "OrganizationAffiliation",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "OrganizationAffiliation",
            "path": "OrganizationAffiliation",
            "short": "Defines an affiliation/assotiation/relationship between 2 distinct oganizations, that is not a part-of relationship/sub-division relationship",
            "definition": "Defines an affiliation/assotiation/relationship between 2 distinct oganizations, that is not a part-of relationship/sub-division relationship.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "OrganizationAffiliation.identifier",
            "path": "OrganizationAffiliation.identifier",
            "short": "Business identifiers that are specific to this role",
            "definition": "Business identifiers that are specific to this role.",
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
            "id": "OrganizationAffiliation.active",
            "path": "OrganizationAffiliation.active",
            "short": "Whether this organization affiliation record is in active use",
            "definition": "Whether this organization affiliation record is in active use.",
            "comment": "If this value is false, you may refer to the period to see when the role was in active use. If there is no period specified, no inference can be made about when it was active.",
            "requirements": "Need to be able to mark an organization affiliation record as not to be used because it was created in error, or otherwise no longer in active use.",
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
            "id": "OrganizationAffiliation.period",
            "path": "OrganizationAffiliation.period",
            "short": "The period during which the participatingOrganization is affiliated with the primary organization",
            "definition": "The period during which the participatingOrganization is affiliated with the primary organization.",
            "requirements": "An affiliation may be created ahead of time and only be active for a defined period of time. Once the affiliation is complete, the fact that it existed may still be required.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Period"
              }
            ],
            "isSummary": true
          },
          {
            "id": "OrganizationAffiliation.organization",
            "path": "OrganizationAffiliation.organization",
            "short": "Organization where the role is available",
            "definition": "Organization where the role is available (primary organization/has members).",
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
            "id": "OrganizationAffiliation.participatingOrganization",
            "path": "OrganizationAffiliation.participatingOrganization",
            "short": "Organization that provides/performs the role (e.g. providing services or is a member of)",
            "definition": "The Participating Organization provides/performs the role(s) defined by the code to the Primary Organization (e.g. providing services or is a member of).",
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
            "id": "OrganizationAffiliation.network",
            "path": "OrganizationAffiliation.network",
            "short": "Health insurance provider network in which the participatingOrganization provides the role's services (if defined) at the indicated locations (if defined)",
            "definition": "Health insurance provider network in which the participatingOrganization provides the role's services (if defined) at the indicated locations (if defined).",
            "min": 0,
            "max": "*",
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
            "id": "OrganizationAffiliation.code",
            "path": "OrganizationAffiliation.code",
            "short": "Definition of the role the participatingOrganization plays",
            "definition": "Definition of the role the participatingOrganization plays in the association.",
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
                  "valueString": "OrganizationAffiliation"
                }
              ],
              "strength": "example",
              "description": "The role the participating organization providing services to the primary organization.",
              "valueSet": "http://hl7.org/fhir/ValueSet/organization-role"
            }
          },
          {
            "id": "OrganizationAffiliation.specialty",
            "path": "OrganizationAffiliation.specialty",
            "short": "Specific specialty of the participatingOrganization in the context of the role",
            "definition": "Specific specialty of the participatingOrganization in the context of the role.",
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
                  "valueString": "OrganizationSpecialty"
                }
              ],
              "strength": "preferred",
              "description": "Specific specialty associated with the participating organization.",
              "valueSet": "http://hl7.org/fhir/ValueSet/c80-practice-codes"
            }
          },
          {
            "id": "OrganizationAffiliation.location",
            "path": "OrganizationAffiliation.location",
            "short": "The location(s) at which the role occurs",
            "definition": "The location(s) at which the role occurs.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Location"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "OrganizationAffiliation.healthcareService",
            "path": "OrganizationAffiliation.healthcareService",
            "short": "Healthcare services provided through the role",
            "definition": "Healthcare services provided through the role.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/HealthcareService"
                ]
              }
            ]
          },
          {
            "id": "OrganizationAffiliation.telecom",
            "path": "OrganizationAffiliation.telecom",
            "short": "Contact details at the participatingOrganization relevant to this Affiliation",
            "definition": "Contact details at the participatingOrganization relevant to this Affiliation.",
            "requirements": "Sometimes a participating organization provides dedicated contacts to handle enquiries specifically for the role provided to the affiliated organization.",
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
            "id": "OrganizationAffiliation.endpoint",
            "path": "OrganizationAffiliation.endpoint",
            "short": "Technical endpoints providing access to services operated for this role",
            "definition": "Technical endpoints providing access to services operated for this role.",
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
    #endregion                                                                                                                              // MakerGen.cs:466
    /// <summary>
    /// Fhir resource 'OrganizationAffiliation'
    /// </summary>
    // 0. OrganizationAffiliation
    public class Resource_OrganizationAffiliation : FhirKhit.Maker.Common.Resource.ResourceBase                                             // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        public class Resource_OrganizationAffiliation_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                // MakerGen.cs:378
        {                                                                                                                                   // MakerGen.cs:379
            // 1. OrganizationAffiliation.identifier
            public ElementDefinitionInfo Element_Identifier;                                                                                // MakerGen.cs:211
            // 2. OrganizationAffiliation.active
            public ElementDefinitionInfo Element_Active;                                                                                    // MakerGen.cs:211
            // 3. OrganizationAffiliation.period
            public ElementDefinitionInfo Element_Period;                                                                                    // MakerGen.cs:211
            // 4. OrganizationAffiliation.organization
            public ElementDefinitionInfo Element_Organization;                                                                              // MakerGen.cs:211
            // 5. OrganizationAffiliation.participatingOrganization
            public ElementDefinitionInfo Element_ParticipatingOrganization;                                                                 // MakerGen.cs:211
            // 6. OrganizationAffiliation.network
            public ElementDefinitionInfo Element_Network;                                                                                   // MakerGen.cs:211
            // 7. OrganizationAffiliation.code
            public ElementDefinitionInfo Element_Code;                                                                                      // MakerGen.cs:211
            // 8. OrganizationAffiliation.specialty
            public ElementDefinitionInfo Element_Specialty;                                                                                 // MakerGen.cs:211
            // 9. OrganizationAffiliation.location
            public ElementDefinitionInfo Element_Location;                                                                                  // MakerGen.cs:211
            // 10. OrganizationAffiliation.healthcareService
            public ElementDefinitionInfo Element_HealthcareService;                                                                         // MakerGen.cs:211
            // 11. OrganizationAffiliation.telecom
            public ElementDefinitionInfo Element_Telecom;                                                                                   // MakerGen.cs:211
            // 12. OrganizationAffiliation.endpoint
            public ElementDefinitionInfo Element_Endpoint;                                                                                  // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
            public Resource_OrganizationAffiliation_Elements()                                                                              // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:226
                    // 1. OrganizationAffiliation.identifier
                    this.Element_Identifier = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Identifier",                                                                                        // MakerGen.cs:230
                        Path= "OrganizationAffiliation.identifier",                                                                         // MakerGen.cs:231
                        Id = "OrganizationAffiliation.identifier",                                                                          // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Identifier                                                               // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 2. OrganizationAffiliation.active
                    this.Element_Active = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Active",                                                                                            // MakerGen.cs:230
                        Path= "OrganizationAffiliation.active",                                                                             // MakerGen.cs:231
                        Id = "OrganizationAffiliation.active",                                                                              // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Boolean                                                                     // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 3. OrganizationAffiliation.period
                    this.Element_Period = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Period",                                                                                            // MakerGen.cs:230
                        Path= "OrganizationAffiliation.period",                                                                             // MakerGen.cs:231
                        Id = "OrganizationAffiliation.period",                                                                              // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Period                                                                   // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 4. OrganizationAffiliation.organization
                    this.Element_Organization = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Organization",                                                                                      // MakerGen.cs:230
                        Path= "OrganizationAffiliation.organization",                                                                       // MakerGen.cs:231
                        Id = "OrganizationAffiliation.organization",                                                                        // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 5. OrganizationAffiliation.participatingOrganization
                    this.Element_ParticipatingOrganization = new ElementDefinitionInfo                                                      // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_ParticipatingOrganization",                                                                         // MakerGen.cs:230
                        Path= "OrganizationAffiliation.participatingOrganization",                                                          // MakerGen.cs:231
                        Id = "OrganizationAffiliation.participatingOrganization",                                                           // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 6. OrganizationAffiliation.network
                    this.Element_Network = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Network",                                                                                           // MakerGen.cs:230
                        Path= "OrganizationAffiliation.network",                                                                            // MakerGen.cs:231
                        Id = "OrganizationAffiliation.network",                                                                             // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 7. OrganizationAffiliation.code
                    this.Element_Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Code",                                                                                              // MakerGen.cs:230
                        Path= "OrganizationAffiliation.code",                                                                               // MakerGen.cs:231
                        Id = "OrganizationAffiliation.code",                                                                                // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 8. OrganizationAffiliation.specialty
                    this.Element_Specialty = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Specialty",                                                                                         // MakerGen.cs:230
                        Path= "OrganizationAffiliation.specialty",                                                                          // MakerGen.cs:231
                        Id = "OrganizationAffiliation.specialty",                                                                           // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 9. OrganizationAffiliation.location
                    this.Element_Location = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Location",                                                                                          // MakerGen.cs:230
                        Path= "OrganizationAffiliation.location",                                                                           // MakerGen.cs:231
                        Id = "OrganizationAffiliation.location",                                                                            // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Location"                                                      // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 10. OrganizationAffiliation.healthcareService
                    this.Element_HealthcareService = new ElementDefinitionInfo                                                              // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_HealthcareService",                                                                                 // MakerGen.cs:230
                        Path= "OrganizationAffiliation.healthcareService",                                                                  // MakerGen.cs:231
                        Id = "OrganizationAffiliation.healthcareService",                                                                   // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/HealthcareService"                                             // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 11. OrganizationAffiliation.telecom
                    this.Element_Telecom = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Telecom",                                                                                           // MakerGen.cs:230
                        Path= "OrganizationAffiliation.telecom",                                                                            // MakerGen.cs:231
                        Id = "OrganizationAffiliation.telecom",                                                                             // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_ContactPoint                                                             // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 12. OrganizationAffiliation.endpoint
                    this.Element_Endpoint = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Endpoint",                                                                                          // MakerGen.cs:230
                        Path= "OrganizationAffiliation.endpoint",                                                                           // MakerGen.cs:231
                        Id = "OrganizationAffiliation.endpoint",                                                                            // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Endpoint"                                                      // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                Element_Identifier.Write(sDef);                                                                                             // MakerGen.cs:215
                Element_Active.Write(sDef);                                                                                                 // MakerGen.cs:215
                Element_Period.Write(sDef);                                                                                                 // MakerGen.cs:215
                Element_Organization.Write(sDef);                                                                                           // MakerGen.cs:215
                Element_ParticipatingOrganization.Write(sDef);                                                                              // MakerGen.cs:215
                Element_Network.Write(sDef);                                                                                                // MakerGen.cs:215
                Element_Code.Write(sDef);                                                                                                   // MakerGen.cs:215
                Element_Specialty.Write(sDef);                                                                                              // MakerGen.cs:215
                Element_Location.Write(sDef);                                                                                               // MakerGen.cs:215
                Element_HealthcareService.Write(sDef);                                                                                      // MakerGen.cs:215
                Element_Telecom.Write(sDef);                                                                                                // MakerGen.cs:215
                Element_Endpoint.Write(sDef);                                                                                               // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:394
        }                                                                                                                                   // MakerGen.cs:396
        public Resource_OrganizationAffiliation_Elements Elements                                                                           // MakerGen.cs:398
        {                                                                                                                                   // MakerGen.cs:399
            get                                                                                                                             // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                if (this.elements == null)                                                                                                  // MakerGen.cs:402
                    this.elements = new Resource_OrganizationAffiliation_Elements();                                                        // MakerGen.cs:403
                return this.elements;                                                                                                       // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:406
        Resource_OrganizationAffiliation_Elements elements;                                                                                 // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
        public Resource_OrganizationAffiliation()                                                                                           // MakerGen.cs:410
        {                                                                                                                                   // MakerGen.cs:411
            this.Name = "OrganizationAffiliation";                                                                                          // MakerGen.cs:484
            this.Uri = "http://hl7.org/fhir/StructureDefinition/OrganizationAffiliation";                                                   // MakerGen.cs:485
        }                                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:416
        {                                                                                                                                   // MakerGen.cs:417
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:418
            {                                                                                                                               // MakerGen.cs:419
                Path = "OrganizationAffiliation",                                                                                           // MakerGen.cs:420
                ElementId = "OrganizationAffiliation"                                                                                       // MakerGen.cs:421
            });                                                                                                                             // MakerGen.cs:422
            if (this.elements != null)                                                                                                      // MakerGen.cs:423
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:424
        }                                                                                                                                   // MakerGen.cs:425
    }                                                                                                                                       // MakerGen.cs:426
}                                                                                                                                           // MakerGen.cs:471
