using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:269
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:270
{                                                                                                                                           // MakerGen.cs:271
    /// <summary>
    /// Fhir primitive 'Meta'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "Meta",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/Meta",
    ///   "version": "4.0.0",
    ///   "name": "Meta",
    ///   "status": "active",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for Meta Type: The metadata about a resource. This is content in the resource that is maintained by the infrastructure. Changes to the content might not always be associated with version changes to the resource.",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": false,
    ///   "type": "Meta",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "Meta",
    ///         "path": "Meta",
    ///         "short": "Metadata about a resource",
    ///         "definition": "The metadata about a resource. This is content in the resource that is maintained by the infrastructure. Changes to the content might not always be associated with version changes to the resource.",
    ///         "min": 0,
    ///         "max": "*"
    ///       },
    ///       {
    ///         "id": "Meta.versionId",
    ///         "path": "Meta.versionId",
    ///         "short": "Version specific identifier",
    ///         "definition": "The version specific identifier, as it appears in the version portion of the URL. This value changes when the resource is created, updated, or deleted.",
    ///         "comment": "The server assigns this value, and ignores what the client specifies, except in the case that the server is imposing version integrity on updates/deletes.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "id"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Meta.lastUpdated",
    ///         "path": "Meta.lastUpdated",
    ///         "short": "When the resource version last changed",
    ///         "definition": "When the resource last changed - e.g. when the version changed.",
    ///         "comment": "This value is always populated except when the resource is first being created. The server / resource manager sets this value; what a client provides is irrelevant. This is equivalent to the HTTP Last-Modified and SHOULD have the same value on a [read](http.html#read) interaction.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "instant"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Meta.source",
    ///         "path": "Meta.source",
    ///         "short": "Identifies where the resource comes from",
    ///         "definition": "A uri that identifies the source system of the resource. This provides a minimal amount of [Provenance](provenance.html#) information that can be used to track or differentiate the source of information in the resource. The source may identify another FHIR server, document, message, database, etc.",
    ///         "comment": "In the provenance resource, this corresponds to Provenance.entity.what[x]. The exact use of the source (and the implied Provenance.entity.role) is left to implementer discretion. Only one nominated source is allowed; for additional provenance details, a full Provenance resource should be used. \n\nThis element can be used to indicate where the current master source of a resource that has a canonical URL if the resource is no longer hosted at the canonical URL.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "uri"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Meta.profile",
    ///         "path": "Meta.profile",
    ///         "short": "Profiles this resource claims to conform to",
    ///         "definition": "A list of profiles (references to [StructureDefinition](structuredefinition.html#) resources) that this resource claims to conform to. The URL is a reference to [StructureDefinition.url](structuredefinition-definitions.html#StructureDefinition.url).",
    ///         "comment": "It is up to the server and/or other infrastructure of policy to determine whether/how these claims are verified and/or updated over time.  The list of profile URLs is a set.",
    ///         "min": 0,
    ///         "max": "*",
    ///         "type": [
    ///           {
    ///             "code": "canonical",
    ///             "targetProfile": [
    ///               "http://hl7.org/fhir/StructureDefinition/StructureDefinition"
    ///             ]
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Meta.security",
    ///         "path": "Meta.security",
    ///         "short": "Security Labels applied to this resource",
    ///         "definition": "Security labels applied to this resource. These tags connect specific resources to the overall security policy and infrastructure.",
    ///         "comment": "The security labels can be updated without changing the stated version of the resource. The list of security labels is a set. Uniqueness is based the system/code, and version and display are ignored.",
    ///         "min": 0,
    ///         "max": "*",
    ///         "type": [
    ///           {
    ///             "code": "Coding"
    ///           }
    ///         ],
    ///         "isSummary": true,
    ///         "binding": {
    ///           "extension": [
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
    ///               "valueString": "SecurityLabels"
    ///             },
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
    ///               "valueBoolean": true
    ///             }
    ///           ],
    ///           "strength": "extensible",
    ///           "description": "Security Labels from the Healthcare Privacy and Security Classification System.",
    ///           "valueSet": "http://hl7.org/fhir/ValueSet/security-labels"
    ///         }
    ///       },
    ///       {
    ///         "id": "Meta.tag",
    ///         "path": "Meta.tag",
    ///         "short": "Tags applied to this resource",
    ///         "definition": "Tags applied to this resource. Tags are intended to be used to identify and relate resources to process and workflow, and applications are not required to consider the tags when interpreting the meaning of a resource.",
    ///         "comment": "The tags can be updated without changing the stated version of the resource. The list of tags is a set. Uniqueness is based the system/code, and version and display are ignored.",
    ///         "min": 0,
    ///         "max": "*",
    ///         "type": [
    ///           {
    ///             "code": "Coding"
    ///           }
    ///         ],
    ///         "isSummary": true,
    ///         "binding": {
    ///           "extension": [
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
    ///               "valueString": "Tags"
    ///             }
    ///           ],
    ///           "strength": "example",
    ///           "description": "Codes that represent various types of tags, commonly workflow-related; e.g. \"Needs review by Dr. Jones\".",
    ///           "valueSet": "http://hl7.org/fhir/ValueSet/common-tags"
    ///         }
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    // 0. Meta
    public class Meta_Type : Complex_Type                                                                                                   // MakerGen.cs:225
    {                                                                                                                                       // MakerGen.cs:226
        // 1. Meta.versionId
        public ElementInstance VersionId;                                                                                                   // MakerGen.cs:208
        // 2. Meta.lastUpdated
        public ElementInstance LastUpdated;                                                                                                 // MakerGen.cs:208
        // 3. Meta.source
        public ElementInstance Source;                                                                                                      // MakerGen.cs:208
        // 4. Meta.profile
        public ElementInstance Profile;                                                                                                     // MakerGen.cs:208
        // 5. Meta.security
        public ElementInstance Security;                                                                                                    // MakerGen.cs:208
        // 6. Meta.tag
        public ElementInstance Tag;                                                                                                         // MakerGen.cs:208
        public Meta_Type()                                                                                                                  // MakerGen.cs:234
        {                                                                                                                                   // MakerGen.cs:235
        }                                                                                                                                   // MakerGen.cs:246
    }                                                                                                                                       // MakerGen.cs:230
}                                                                                                                                           // MakerGen.cs:277
