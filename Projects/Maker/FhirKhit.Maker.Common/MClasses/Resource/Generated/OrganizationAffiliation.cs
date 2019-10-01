using System;                                                                                                                               // MakerGen.cs:462
using System.Diagnostics;                                                                                                                   // MakerGen.cs:463
using System.IO;                                                                                                                            // MakerGen.cs:464
using System.Linq;                                                                                                                          // MakerGen.cs:465
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:466
                                                                                                                                            // MakerGen.cs:467
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:468
{                                                                                                                                           // MakerGen.cs:469
    #region Json                                                                                                                            // MakerGen.cs:470
    #if NEVER                                                                                                                               // MakerGen.cs:471
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
    #endregion                                                                                                                              // MakerGen.cs:474
    /// <summary>
    /// Fhir resource 'OrganizationAffiliation'
    /// </summary>
    // 0. OrganizationAffiliation
    public class OrganizationAffiliation : FhirKhit.Maker.Common.Resource.ResourceBase                                                      // MakerGen.cs:384
    {                                                                                                                                       // MakerGen.cs:385
        public class OrganizationAffiliation_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                         // MakerGen.cs:386
        {                                                                                                                                   // MakerGen.cs:387
            // 1. OrganizationAffiliation.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:216
            // 2. OrganizationAffiliation.active
            public ElementDefinitionInfo Active;                                                                                            // MakerGen.cs:216
            // 3. OrganizationAffiliation.period
            public ElementDefinitionInfo Period;                                                                                            // MakerGen.cs:216
            // 4. OrganizationAffiliation.organization
            public ElementDefinitionInfo Organization;                                                                                      // MakerGen.cs:216
            // 5. OrganizationAffiliation.participatingOrganization
            public ElementDefinitionInfo ParticipatingOrganization;                                                                         // MakerGen.cs:216
            // 6. OrganizationAffiliation.network
            public ElementDefinitionInfo Network;                                                                                           // MakerGen.cs:216
            // 7. OrganizationAffiliation.code
            public ElementDefinitionInfo Code;                                                                                              // MakerGen.cs:216
            // 8. OrganizationAffiliation.specialty
            public ElementDefinitionInfo Specialty;                                                                                         // MakerGen.cs:216
            // 9. OrganizationAffiliation.location
            public ElementDefinitionInfo Location;                                                                                          // MakerGen.cs:216
            // 10. OrganizationAffiliation.healthcareService
            public ElementDefinitionInfo HealthcareService;                                                                                 // MakerGen.cs:216
            // 11. OrganizationAffiliation.telecom
            public ElementDefinitionInfo Telecom;                                                                                           // MakerGen.cs:216
            // 12. OrganizationAffiliation.endpoint
            public ElementDefinitionInfo Endpoint;                                                                                          // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
            public OrganizationAffiliation_Elements()                                                                                       // MakerGen.cs:392
            {                                                                                                                               // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:231
                    // 1. OrganizationAffiliation.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Identifier",                                                                                                // MakerGen.cs:235
                        Path= "OrganizationAffiliation.identifier",                                                                         // MakerGen.cs:236
                        Id = "OrganizationAffiliation.identifier",                                                                          // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 2. OrganizationAffiliation.active
                    this.Active = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Active",                                                                                                    // MakerGen.cs:235
                        Path= "OrganizationAffiliation.active",                                                                             // MakerGen.cs:236
                        Id = "OrganizationAffiliation.active",                                                                              // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Boolean                                                                     // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 3. OrganizationAffiliation.period
                    this.Period = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Period",                                                                                                    // MakerGen.cs:235
                        Path= "OrganizationAffiliation.period",                                                                             // MakerGen.cs:236
                        Id = "OrganizationAffiliation.period",                                                                              // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 4. OrganizationAffiliation.organization
                    this.Organization = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Organization",                                                                                              // MakerGen.cs:235
                        Path= "OrganizationAffiliation.organization",                                                                       // MakerGen.cs:236
                        Id = "OrganizationAffiliation.organization",                                                                        // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 5. OrganizationAffiliation.participatingOrganization
                    this.ParticipatingOrganization = new ElementDefinitionInfo                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ParticipatingOrganization",                                                                                 // MakerGen.cs:235
                        Path= "OrganizationAffiliation.participatingOrganization",                                                          // MakerGen.cs:236
                        Id = "OrganizationAffiliation.participatingOrganization",                                                           // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 6. OrganizationAffiliation.network
                    this.Network = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Network",                                                                                                   // MakerGen.cs:235
                        Path= "OrganizationAffiliation.network",                                                                            // MakerGen.cs:236
                        Id = "OrganizationAffiliation.network",                                                                             // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 7. OrganizationAffiliation.code
                    this.Code = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Code",                                                                                                      // MakerGen.cs:235
                        Path= "OrganizationAffiliation.code",                                                                               // MakerGen.cs:236
                        Id = "OrganizationAffiliation.code",                                                                                // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 8. OrganizationAffiliation.specialty
                    this.Specialty = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Specialty",                                                                                                 // MakerGen.cs:235
                        Path= "OrganizationAffiliation.specialty",                                                                          // MakerGen.cs:236
                        Id = "OrganizationAffiliation.specialty",                                                                           // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 9. OrganizationAffiliation.location
                    this.Location = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Location",                                                                                                  // MakerGen.cs:235
                        Path= "OrganizationAffiliation.location",                                                                           // MakerGen.cs:236
                        Id = "OrganizationAffiliation.location",                                                                            // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Location"                                                      // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 10. OrganizationAffiliation.healthcareService
                    this.HealthcareService = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "HealthcareService",                                                                                         // MakerGen.cs:235
                        Path= "OrganizationAffiliation.healthcareService",                                                                  // MakerGen.cs:236
                        Id = "OrganizationAffiliation.healthcareService",                                                                   // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/HealthcareService"                                             // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 11. OrganizationAffiliation.telecom
                    this.Telecom = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Telecom",                                                                                                   // MakerGen.cs:235
                        Path= "OrganizationAffiliation.telecom",                                                                            // MakerGen.cs:236
                        Id = "OrganizationAffiliation.telecom",                                                                             // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.ContactPoint                                                                  // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 12. OrganizationAffiliation.endpoint
                    this.Endpoint = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Endpoint",                                                                                                  // MakerGen.cs:235
                        Path= "OrganizationAffiliation.endpoint",                                                                           // MakerGen.cs:236
                        Id = "OrganizationAffiliation.endpoint",                                                                            // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Endpoint"                                                      // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:398
            {                                                                                                                               // MakerGen.cs:399
                base.Write(sDef);                                                                                                           // MakerGen.cs:400
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:220
                Active.Write(sDef);                                                                                                         // MakerGen.cs:220
                Period.Write(sDef);                                                                                                         // MakerGen.cs:220
                Organization.Write(sDef);                                                                                                   // MakerGen.cs:220
                ParticipatingOrganization.Write(sDef);                                                                                      // MakerGen.cs:220
                Network.Write(sDef);                                                                                                        // MakerGen.cs:220
                Code.Write(sDef);                                                                                                           // MakerGen.cs:220
                Specialty.Write(sDef);                                                                                                      // MakerGen.cs:220
                Location.Write(sDef);                                                                                                       // MakerGen.cs:220
                HealthcareService.Write(sDef);                                                                                              // MakerGen.cs:220
                Telecom.Write(sDef);                                                                                                        // MakerGen.cs:220
                Endpoint.Write(sDef);                                                                                                       // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:402
        }                                                                                                                                   // MakerGen.cs:404
        public OrganizationAffiliation_Elements Elements                                                                                    // MakerGen.cs:406
        {                                                                                                                                   // MakerGen.cs:407
            get                                                                                                                             // MakerGen.cs:408
            {                                                                                                                               // MakerGen.cs:409
                if (this.elements == null)                                                                                                  // MakerGen.cs:410
                    this.elements = new OrganizationAffiliation_Elements();                                                                 // MakerGen.cs:411
                return this.elements;                                                                                                       // MakerGen.cs:412
            }                                                                                                                               // MakerGen.cs:413
        }                                                                                                                                   // MakerGen.cs:414
        OrganizationAffiliation_Elements elements;                                                                                          // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
        public OrganizationAffiliation()                                                                                                    // MakerGen.cs:418
        {                                                                                                                                   // MakerGen.cs:419
            this.Name = "OrganizationAffiliation";                                                                                          // MakerGen.cs:492
            this.Uri = "http://hl7.org/fhir/StructureDefinition/OrganizationAffiliation";                                                   // MakerGen.cs:493
        }                                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:424
        {                                                                                                                                   // MakerGen.cs:425
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:426
            {                                                                                                                               // MakerGen.cs:427
                Path = "OrganizationAffiliation",                                                                                           // MakerGen.cs:428
                ElementId = "OrganizationAffiliation"                                                                                       // MakerGen.cs:429
            });                                                                                                                             // MakerGen.cs:430
            if (this.elements != null)                                                                                                      // MakerGen.cs:431
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:432
        }                                                                                                                                   // MakerGen.cs:433
    }                                                                                                                                       // MakerGen.cs:434
}                                                                                                                                           // MakerGen.cs:479
