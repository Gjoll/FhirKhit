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
    #endregion                                                                                                                              // MakerGen.cs:463
    /// <summary>
    /// Fhir resource 'OrganizationAffiliation'
    /// </summary>
    // 0. OrganizationAffiliation
    public class OrganizationAffiliation : FhirKhit.Maker.Common.Resource.ResourceBase                                                      // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class OrganizationAffiliation_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                         // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 1. OrganizationAffiliation.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:236
            // 2. OrganizationAffiliation.active
            public ElementDefinitionInfo Active;                                                                                            // MakerGen.cs:236
            // 3. OrganizationAffiliation.period
            public ElementDefinitionInfo Period;                                                                                            // MakerGen.cs:236
            // 4. OrganizationAffiliation.organization
            public ElementDefinitionInfo Organization;                                                                                      // MakerGen.cs:236
            // 5. OrganizationAffiliation.participatingOrganization
            public ElementDefinitionInfo ParticipatingOrganization;                                                                         // MakerGen.cs:236
            // 6. OrganizationAffiliation.network
            public ElementDefinitionInfo Network;                                                                                           // MakerGen.cs:236
            // 7. OrganizationAffiliation.code
            public ElementDefinitionInfo Code;                                                                                              // MakerGen.cs:236
            // 8. OrganizationAffiliation.specialty
            public ElementDefinitionInfo Specialty;                                                                                         // MakerGen.cs:236
            // 9. OrganizationAffiliation.location
            public ElementDefinitionInfo Location;                                                                                          // MakerGen.cs:236
            // 10. OrganizationAffiliation.healthcareService
            public ElementDefinitionInfo HealthcareService;                                                                                 // MakerGen.cs:236
            // 11. OrganizationAffiliation.telecom
            public ElementDefinitionInfo Telecom;                                                                                           // MakerGen.cs:236
            // 12. OrganizationAffiliation.endpoint
            public ElementDefinitionInfo Endpoint;                                                                                          // MakerGen.cs:236
            public OrganizationAffiliation_Elements()                                                                                       // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:251
                    // 1. OrganizationAffiliation.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Identifier",                                                                                                // MakerGen.cs:255
                        Path= "OrganizationAffiliation.identifier",                                                                         // MakerGen.cs:256
                        Id = "OrganizationAffiliation.identifier",                                                                          // MakerGen.cs:257
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
                    // 2. OrganizationAffiliation.active
                    this.Active = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Active",                                                                                                    // MakerGen.cs:255
                        Path= "OrganizationAffiliation.active",                                                                             // MakerGen.cs:256
                        Id = "OrganizationAffiliation.active",                                                                              // MakerGen.cs:257
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
                {                                                                                                                           // MakerGen.cs:251
                    // 3. OrganizationAffiliation.period
                    this.Period = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Period",                                                                                                    // MakerGen.cs:255
                        Path= "OrganizationAffiliation.period",                                                                             // MakerGen.cs:256
                        Id = "OrganizationAffiliation.period",                                                                              // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 4. OrganizationAffiliation.organization
                    this.Organization = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Organization",                                                                                              // MakerGen.cs:255
                        Path= "OrganizationAffiliation.organization",                                                                       // MakerGen.cs:256
                        Id = "OrganizationAffiliation.organization",                                                                        // MakerGen.cs:257
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
                    // 5. OrganizationAffiliation.participatingOrganization
                    this.ParticipatingOrganization = new ElementDefinitionInfo                                                              // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "ParticipatingOrganization",                                                                                 // MakerGen.cs:255
                        Path= "OrganizationAffiliation.participatingOrganization",                                                          // MakerGen.cs:256
                        Id = "OrganizationAffiliation.participatingOrganization",                                                           // MakerGen.cs:257
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
                    // 6. OrganizationAffiliation.network
                    this.Network = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Network",                                                                                                   // MakerGen.cs:255
                        Path= "OrganizationAffiliation.network",                                                                            // MakerGen.cs:256
                        Id = "OrganizationAffiliation.network",                                                                             // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
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
                    // 7. OrganizationAffiliation.code
                    this.Code = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Code",                                                                                                      // MakerGen.cs:255
                        Path= "OrganizationAffiliation.code",                                                                               // MakerGen.cs:256
                        Id = "OrganizationAffiliation.code",                                                                                // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:314
                            {                                                                                                               // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:318
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 8. OrganizationAffiliation.specialty
                    this.Specialty = new ElementDefinitionInfo                                                                              // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Specialty",                                                                                                 // MakerGen.cs:255
                        Path= "OrganizationAffiliation.specialty",                                                                          // MakerGen.cs:256
                        Id = "OrganizationAffiliation.specialty",                                                                           // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:314
                            {                                                                                                               // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:318
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 9. OrganizationAffiliation.location
                    this.Location = new ElementDefinitionInfo                                                                               // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Location",                                                                                                  // MakerGen.cs:255
                        Path= "OrganizationAffiliation.location",                                                                           // MakerGen.cs:256
                        Id = "OrganizationAffiliation.location",                                                                            // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Location"                                                      // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 10. OrganizationAffiliation.healthcareService
                    this.HealthcareService = new ElementDefinitionInfo                                                                      // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "HealthcareService",                                                                                         // MakerGen.cs:255
                        Path= "OrganizationAffiliation.healthcareService",                                                                  // MakerGen.cs:256
                        Id = "OrganizationAffiliation.healthcareService",                                                                   // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/HealthcareService"                                             // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 11. OrganizationAffiliation.telecom
                    this.Telecom = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Telecom",                                                                                                   // MakerGen.cs:255
                        Path= "OrganizationAffiliation.telecom",                                                                            // MakerGen.cs:256
                        Id = "OrganizationAffiliation.telecom",                                                                             // MakerGen.cs:257
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
                    // 12. OrganizationAffiliation.endpoint
                    this.Endpoint = new ElementDefinitionInfo                                                                               // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Endpoint",                                                                                                  // MakerGen.cs:255
                        Path= "OrganizationAffiliation.endpoint",                                                                           // MakerGen.cs:256
                        Id = "OrganizationAffiliation.endpoint",                                                                            // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Endpoint"                                                      // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:429
            public void override Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:414
            {                                                                                                                               // MakerGen.cs:415
                base.Write(sDef);                                                                                                           // MakerGen.cs:416
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:240
                Active.Write(sDef);                                                                                                         // MakerGen.cs:240
                Period.Write(sDef);                                                                                                         // MakerGen.cs:240
                Organization.Write(sDef);                                                                                                   // MakerGen.cs:240
                ParticipatingOrganization.Write(sDef);                                                                                      // MakerGen.cs:240
                Network.Write(sDef);                                                                                                        // MakerGen.cs:240
                Code.Write(sDef);                                                                                                           // MakerGen.cs:240
                Specialty.Write(sDef);                                                                                                      // MakerGen.cs:240
                Location.Write(sDef);                                                                                                       // MakerGen.cs:240
                HealthcareService.Write(sDef);                                                                                              // MakerGen.cs:240
                Telecom.Write(sDef);                                                                                                        // MakerGen.cs:240
                Endpoint.Write(sDef);                                                                                                       // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public OrganizationAffiliation_Elements Elements { get; }                                                                           // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public OrganizationAffiliation()                                                                                                    // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new OrganizationAffiliation_Elements();                                                                         // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:468
