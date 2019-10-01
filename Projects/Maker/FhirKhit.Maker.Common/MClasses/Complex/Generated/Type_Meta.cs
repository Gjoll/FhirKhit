using System;                                                                                                                               // MakerGen.cs:482
using System.Diagnostics;                                                                                                                   // MakerGen.cs:483
using System.IO;                                                                                                                            // MakerGen.cs:484
using System.Linq;                                                                                                                          // MakerGen.cs:485
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:486
                                                                                                                                            // MakerGen.cs:487
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:488
{                                                                                                                                           // MakerGen.cs:489
    #region Json                                                                                                                            // MakerGen.cs:490
    #if NEVER
    {
      "resourceType": "StructureDefinition",
      "id": "Meta",
      "url": "http://hl7.org/fhir/StructureDefinition/Meta",
      "version": "4.0.0",
      "name": "Meta",
      "status": "active",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for Meta Type: The metadata about a resource. This is content in the resource that is maintained by the infrastructure. Changes to the content might not always be associated with version changes to the resource.",
      "fhirVersion": "4.0.0",
      "kind": "complex-type",
      "abstract": false,
      "type": "Meta",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Meta",
            "path": "Meta",
            "short": "Metadata about a resource",
            "definition": "The metadata about a resource. This is content in the resource that is maintained by the infrastructure. Changes to the content might not always be associated with version changes to the resource.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Meta.versionId",
            "path": "Meta.versionId",
            "short": "Version specific identifier",
            "definition": "The version specific identifier, as it appears in the version portion of the URL. This value changes when the resource is created, updated, or deleted.",
            "comment": "The server assigns this value, and ignores what the client specifies, except in the case that the server is imposing version integrity on updates/deletes.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "id"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Meta.lastUpdated",
            "path": "Meta.lastUpdated",
            "short": "When the resource version last changed",
            "definition": "When the resource last changed - e.g. when the version changed.",
            "comment": "This value is always populated except when the resource is first being created. The server / resource manager sets this value; what a client provides is irrelevant. This is equivalent to the HTTP Last-Modified and SHOULD have the same value on a [read](http.html#read) interaction.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "instant"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Meta.source",
            "path": "Meta.source",
            "short": "Identifies where the resource comes from",
            "definition": "A uri that identifies the source system of the resource. This provides a minimal amount of [Provenance](provenance.html#) information that can be used to track or differentiate the source of information in the resource. The source may identify another FHIR server, document, message, database, etc.",
            "comment": "In the provenance resource, this corresponds to Provenance.entity.what[x]. The exact use of the source (and the implied Provenance.entity.role) is left to implementer discretion. Only one nominated source is allowed; for additional provenance details, a full Provenance resource should be used. \n\nThis element can be used to indicate where the current master source of a resource that has a canonical URL if the resource is no longer hosted at the canonical URL.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "uri"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Meta.profile",
            "path": "Meta.profile",
            "short": "Profiles this resource claims to conform to",
            "definition": "A list of profiles (references to [StructureDefinition](structuredefinition.html#) resources) that this resource claims to conform to. The URL is a reference to [StructureDefinition.url](structuredefinition-definitions.html#StructureDefinition.url).",
            "comment": "It is up to the server and/or other infrastructure of policy to determine whether/how these claims are verified and/or updated over time.  The list of profile URLs is a set.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/StructureDefinition"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Meta.security",
            "path": "Meta.security",
            "short": "Security Labels applied to this resource",
            "definition": "Security labels applied to this resource. These tags connect specific resources to the overall security policy and infrastructure.",
            "comment": "The security labels can be updated without changing the stated version of the resource. The list of security labels is a set. Uniqueness is based the system/code, and version and display are ignored.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Coding"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "SecurityLabels"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "extensible",
              "description": "Security Labels from the Healthcare Privacy and Security Classification System.",
              "valueSet": "http://hl7.org/fhir/ValueSet/security-labels"
            }
          },
          {
            "id": "Meta.tag",
            "path": "Meta.tag",
            "short": "Tags applied to this resource",
            "definition": "Tags applied to this resource. Tags are intended to be used to identify and relate resources to process and workflow, and applications are not required to consider the tags when interpreting the meaning of a resource.",
            "comment": "The tags can be updated without changing the stated version of the resource. The list of tags is a set. Uniqueness is based the system/code, and version and display are ignored.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Coding"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "Tags"
                }
              ],
              "strength": "example",
              "description": "Codes that represent various types of tags, commonly workflow-related; e.g. \"Needs review by Dr. Jones\".",
              "valueSet": "http://hl7.org/fhir/ValueSet/common-tags"
            }
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:494
    /// <summary>
    /// Fhir complex 'Meta'
    /// </summary>
    // 0. Meta
    public class Type_Meta : FhirKhit.Maker.Common.Complex.ComplexBase                                                                      // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        // 1. Meta.versionId
        public ElementDefinitionInfo Element_VersionId;                                                                                     // MakerGen.cs:212
        // 2. Meta.lastUpdated
        public ElementDefinitionInfo Element_LastUpdated;                                                                                   // MakerGen.cs:212
        // 3. Meta.source
        public ElementDefinitionInfo Element_Source;                                                                                        // MakerGen.cs:212
        // 4. Meta.profile
        public ElementDefinitionInfo Element_Profile;                                                                                       // MakerGen.cs:212
        // 5. Meta.security
        public ElementDefinitionInfo Element_Security;                                                                                      // MakerGen.cs:212
        // 6. Meta.tag
        public ElementDefinitionInfo Element_Tag;                                                                                           // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            base.Write(sDef);                                                                                                               // MakerGen.cs:385
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:386
            {                                                                                                                               // MakerGen.cs:387
                Path = "Meta",                                                                                                              // MakerGen.cs:388
                ElementId = "Meta"                                                                                                          // MakerGen.cs:389
            });                                                                                                                             // MakerGen.cs:390
            Element_VersionId.Write(sDef);                                                                                                  // MakerGen.cs:216
            Element_LastUpdated.Write(sDef);                                                                                                // MakerGen.cs:216
            Element_Source.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_Profile.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Security.Write(sDef);                                                                                                   // MakerGen.cs:216
            Element_Tag.Write(sDef);                                                                                                        // MakerGen.cs:216
        }                                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
        public Type_Meta()                                                                                                                  // MakerGen.cs:395
        {                                                                                                                                   // MakerGen.cs:396
            {                                                                                                                               // MakerGen.cs:227
                // 1. Meta.versionId
                this.Element_VersionId = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_VersionId",                                                                                             // MakerGen.cs:231
                    Path= "Meta.versionId",                                                                                                 // MakerGen.cs:232
                    Id = "Meta.versionId",                                                                                                  // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Id                                                                    // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 2. Meta.lastUpdated
                this.Element_LastUpdated = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_LastUpdated",                                                                                           // MakerGen.cs:231
                    Path= "Meta.lastUpdated",                                                                                               // MakerGen.cs:232
                    Id = "Meta.lastUpdated",                                                                                                // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Instant                                                               // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 3. Meta.source
                this.Element_Source = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Source",                                                                                                // MakerGen.cs:231
                    Path= "Meta.source",                                                                                                    // MakerGen.cs:232
                    Id = "Meta.source",                                                                                                     // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Uri                                                                   // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 4. Meta.profile
                this.Element_Profile = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Profile",                                                                                               // MakerGen.cs:231
                    Path= "Meta.profile",                                                                                                   // MakerGen.cs:232
                    Id = "Meta.profile",                                                                                                    // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Canonical                                                             // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:299
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/StructureDefinition"                                               // MakerGen.cs:299
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 5. Meta.security
                this.Element_Security = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Security",                                                                                              // MakerGen.cs:231
                    Path= "Meta.security",                                                                                                  // MakerGen.cs:232
                    Id = "Meta.security",                                                                                                   // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Coding                                                                       // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 6. Meta.tag
                this.Element_Tag = new ElementDefinitionInfo                                                                                // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Tag",                                                                                                   // MakerGen.cs:231
                    Path= "Meta.tag",                                                                                                       // MakerGen.cs:232
                    Id = "Meta.tag",                                                                                                        // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Coding                                                                       // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
        }                                                                                                                                   // MakerGen.cs:398
    }                                                                                                                                       // MakerGen.cs:400
}                                                                                                                                           // MakerGen.cs:499
