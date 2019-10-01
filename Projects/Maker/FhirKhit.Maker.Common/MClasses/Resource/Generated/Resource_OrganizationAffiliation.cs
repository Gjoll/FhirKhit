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
    #endregion                                                                                                                              // MakerGen.cs:440
    /// <summary>
    /// Fhir resource 'OrganizationAffiliation'
    /// </summary>
    // 0. OrganizationAffiliation
    public class Resource_OrganizationAffiliation : FhirKhit.Maker.Common.Resource.ResourceBase                                             // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        // 1. OrganizationAffiliation.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:212
        // 2. OrganizationAffiliation.active
        public ElementDefinitionInfo Element_Active;                                                                                        // MakerGen.cs:212
        // 3. OrganizationAffiliation.period
        public ElementDefinitionInfo Element_Period;                                                                                        // MakerGen.cs:212
        // 4. OrganizationAffiliation.organization
        public ElementDefinitionInfo Element_Organization;                                                                                  // MakerGen.cs:212
        // 5. OrganizationAffiliation.participatingOrganization
        public ElementDefinitionInfo Element_ParticipatingOrganization;                                                                     // MakerGen.cs:212
        // 6. OrganizationAffiliation.network
        public ElementDefinitionInfo Element_Network;                                                                                       // MakerGen.cs:212
        // 7. OrganizationAffiliation.code
        public ElementDefinitionInfo Element_Code;                                                                                          // MakerGen.cs:212
        // 8. OrganizationAffiliation.specialty
        public ElementDefinitionInfo Element_Specialty;                                                                                     // MakerGen.cs:212
        // 9. OrganizationAffiliation.location
        public ElementDefinitionInfo Element_Location;                                                                                      // MakerGen.cs:212
        // 10. OrganizationAffiliation.healthcareService
        public ElementDefinitionInfo Element_HealthcareService;                                                                             // MakerGen.cs:212
        // 11. OrganizationAffiliation.telecom
        public ElementDefinitionInfo Element_Telecom;                                                                                       // MakerGen.cs:212
        // 12. OrganizationAffiliation.endpoint
        public ElementDefinitionInfo Element_Endpoint;                                                                                      // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            base.Write(sDef);                                                                                                               // MakerGen.cs:385
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:386
            {                                                                                                                               // MakerGen.cs:387
                Path = "OrganizationAffiliation",                                                                                           // MakerGen.cs:388
                ElementId = "OrganizationAffiliation"                                                                                       // MakerGen.cs:389
            });                                                                                                                             // MakerGen.cs:390
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_Active.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_Period.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_Organization.Write(sDef);                                                                                               // MakerGen.cs:216
            Element_ParticipatingOrganization.Write(sDef);                                                                                  // MakerGen.cs:216
            Element_Network.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Code.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_Specialty.Write(sDef);                                                                                                  // MakerGen.cs:216
            Element_Location.Write(sDef);                                                                                                   // MakerGen.cs:216
            Element_HealthcareService.Write(sDef);                                                                                          // MakerGen.cs:216
            Element_Telecom.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Endpoint.Write(sDef);                                                                                                   // MakerGen.cs:216
        }                                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
        public Resource_OrganizationAffiliation()                                                                                           // MakerGen.cs:395
        {                                                                                                                                   // MakerGen.cs:396
            {                                                                                                                               // MakerGen.cs:227
                // 1. OrganizationAffiliation.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:231
                    Path= "OrganizationAffiliation.identifier",                                                                             // MakerGen.cs:232
                    Id = "OrganizationAffiliation.identifier",                                                                              // MakerGen.cs:233
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
                // 2. OrganizationAffiliation.active
                this.Element_Active = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Active",                                                                                                // MakerGen.cs:231
                    Path= "OrganizationAffiliation.active",                                                                                 // MakerGen.cs:232
                    Id = "OrganizationAffiliation.active",                                                                                  // MakerGen.cs:233
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
                // 3. OrganizationAffiliation.period
                this.Element_Period = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Period",                                                                                                // MakerGen.cs:231
                    Path= "OrganizationAffiliation.period",                                                                                 // MakerGen.cs:232
                    Id = "OrganizationAffiliation.period",                                                                                  // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Period                                                                       // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 4. OrganizationAffiliation.organization
                this.Element_Organization = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Organization",                                                                                          // MakerGen.cs:231
                    Path= "OrganizationAffiliation.organization",                                                                           // MakerGen.cs:232
                    Id = "OrganizationAffiliation.organization",                                                                            // MakerGen.cs:233
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
                // 5. OrganizationAffiliation.participatingOrganization
                this.Element_ParticipatingOrganization = new ElementDefinitionInfo                                                          // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_ParticipatingOrganization",                                                                             // MakerGen.cs:231
                    Path= "OrganizationAffiliation.participatingOrganization",                                                              // MakerGen.cs:232
                    Id = "OrganizationAffiliation.participatingOrganization",                                                               // MakerGen.cs:233
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
                // 6. OrganizationAffiliation.network
                this.Element_Network = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Network",                                                                                               // MakerGen.cs:231
                    Path= "OrganizationAffiliation.network",                                                                                // MakerGen.cs:232
                    Id = "OrganizationAffiliation.network",                                                                                 // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
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
                // 7. OrganizationAffiliation.code
                this.Element_Code = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Code",                                                                                                  // MakerGen.cs:231
                    Path= "OrganizationAffiliation.code",                                                                                   // MakerGen.cs:232
                    Id = "OrganizationAffiliation.code",                                                                                    // MakerGen.cs:233
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
                // 8. OrganizationAffiliation.specialty
                this.Element_Specialty = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Specialty",                                                                                             // MakerGen.cs:231
                    Path= "OrganizationAffiliation.specialty",                                                                              // MakerGen.cs:232
                    Id = "OrganizationAffiliation.specialty",                                                                               // MakerGen.cs:233
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
                // 9. OrganizationAffiliation.location
                this.Element_Location = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Location",                                                                                              // MakerGen.cs:231
                    Path= "OrganizationAffiliation.location",                                                                               // MakerGen.cs:232
                    Id = "OrganizationAffiliation.location",                                                                                // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Location"                                                          // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 10. OrganizationAffiliation.healthcareService
                this.Element_HealthcareService = new ElementDefinitionInfo                                                                  // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_HealthcareService",                                                                                     // MakerGen.cs:231
                    Path= "OrganizationAffiliation.healthcareService",                                                                      // MakerGen.cs:232
                    Id = "OrganizationAffiliation.healthcareService",                                                                       // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/HealthcareService"                                                 // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 11. OrganizationAffiliation.telecom
                this.Element_Telecom = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Telecom",                                                                                               // MakerGen.cs:231
                    Path= "OrganizationAffiliation.telecom",                                                                                // MakerGen.cs:232
                    Id = "OrganizationAffiliation.telecom",                                                                                 // MakerGen.cs:233
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
                // 12. OrganizationAffiliation.endpoint
                this.Element_Endpoint = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Endpoint",                                                                                              // MakerGen.cs:231
                    Path= "OrganizationAffiliation.endpoint",                                                                               // MakerGen.cs:232
                    Id = "OrganizationAffiliation.endpoint",                                                                                // MakerGen.cs:233
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
            this.Name = "OrganizationAffiliation";                                                                                          // MakerGen.cs:458
            this.Uri = "http://hl7.org/fhir/StructureDefinition/OrganizationAffiliation";                                                   // MakerGen.cs:459
        }                                                                                                                                   // MakerGen.cs:398
    }                                                                                                                                       // MakerGen.cs:400
}                                                                                                                                           // MakerGen.cs:445
