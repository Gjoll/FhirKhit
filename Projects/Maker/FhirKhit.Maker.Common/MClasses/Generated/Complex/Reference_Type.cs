using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:381
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:382
{                                                                                                                                           // MakerGen.cs:383
    /// <summary>
    /// Fhir primitive 'Reference'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "Reference",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/Reference",
    ///   "version": "4.0.0",
    ///   "name": "Reference",
    ///   "status": "active",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for Reference Type: A reference from one resource to another.",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": false,
    ///   "type": "Reference",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "Reference",
    ///         "path": "Reference",
    ///         "short": "A reference from one resource to another",
    ///         "definition": "A reference from one resource to another.",
    ///         "comment": "References SHALL be a reference to an actual FHIR resource, and SHALL be resolveable (allowing for access control, temporary unavailability, etc.). Resolution can be either by retrieval from the URL, or, where applicable by resource type, by treating an absolute reference as a canonical URL and looking it up in a local registry/repository.",
    ///         "min": 0,
    ///         "max": "*"
    ///       },
    ///       {
    ///         "id": "Reference.reference",
    ///         "path": "Reference.reference",
    ///         "short": "Literal reference, Relative, internal or absolute URL",
    ///         "definition": "A reference to a location at which the other resource is found. The reference may be a relative reference, in which case it is relative to the service base URL, or an absolute URL that resolves to the location where the resource is found. The reference may be version specific or not. If the reference is not to a FHIR RESTful server, then it should be assumed to be version specific. Internal fragment references (start with '#') refer to contained resources.",
    ///         "comment": "Using absolute URLs provides a stable scalable approach suitable for a cloud/web context, while using relative/logical references provides a flexible approach suitable for use when trading across closed eco-system boundaries.   Absolute URLs do not need to point to a FHIR RESTful server, though this is the preferred approach. If the URL conforms to the structure \"/[type]/[id]\" then it should be assumed that the reference is to a FHIR RESTful server.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "string"
    ///           }
    ///         ],
    ///         "condition": [
    ///           "ref-1"
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Reference.type",
    ///         "path": "Reference.type",
    ///         "short": "Type the reference refers to (e.g. \"Patient\")",
    ///         "definition": "The expected type of the target of the reference. If both Reference.type and Reference.reference are populated and Reference.reference is a FHIR URL, both SHALL be consistent.\n\nThe type is the Canonical URL of Resource Definition that is the type this reference refers to. References are URLs that are relative to http://hl7.org/fhir/StructureDefinition/ e.g. \"Patient\" is a reference to http://hl7.org/fhir/StructureDefinition/Patient. Absolute URLs are only allowed for logical models (and can only be used in references in logical models, not resources).",
    ///         "comment": "This element is used to indicate the type of  the target of the reference. This may be used which ever of the other elements are populated (or not). In some cases, the type of the target may be determined by inspection of the reference (e.g. a RESTful URL) or by resolving the target of the reference; if both the type and a reference is provided, the reference SHALL resolve to a resource of the same type as that specified.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "uri"
    ///           }
    ///         ],
    ///         "isSummary": true,
    ///         "binding": {
    ///           "extension": [
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
    ///               "valueString": "FHIRResourceTypeExt"
    ///             }
    ///           ],
    ///           "strength": "extensible",
    ///           "description": "Aa resource (or, for logical models, the URI of the logical model).",
    ///           "valueSet": "http://hl7.org/fhir/ValueSet/resource-types"
    ///         }
    ///       },
    ///       {
    ///         "id": "Reference.identifier",
    ///         "path": "Reference.identifier",
    ///         "short": "Logical reference, when literal reference is not known",
    ///         "definition": "An identifier for the target resource. This is used when there is no way to reference the other resource directly, either because the entity it represents is not available through a FHIR server, or because there is no way for the author of the resource to convert a known identifier to an actual location. There is no requirement that a Reference.identifier point to something that is actually exposed as a FHIR instance, but it SHALL point to a business concept that would be expected to be exposed as a FHIR instance, and that instance would need to be of a FHIR resource type allowed by the reference.",
    ///         "comment": "When an identifier is provided in place of a reference, any system processing the reference will only be able to resolve the identifier to a reference if it understands the business context in which the identifier is used. Sometimes this is global (e.g. a national identifier) but often it is not. For this reason, none of the useful mechanisms described for working with references (e.g. chaining, includes) are possible, nor should servers be expected to be able resolve the reference. Servers may accept an identifier based reference untouched, resolve it, and/or reject it - see CapabilityStatement.rest.resource.referencePolicy. \n\nWhen both an identifier and a literal reference are provided, the literal reference is preferred. Applications processing the resource are allowed - but not required - to check that the identifier matches the literal reference\n\nApplications converting a logical reference to a literal reference may choose to leave the logical reference present, or remove it.\n\nReference is intended to point to a structure that can potentially be expressed as a FHIR resource, though there is no need for it to exist as an actual FHIR resource instance - except in as much as an application wishes to actual find the target of the reference. The content referred to be the identifier must meet the logical constraints implied by any limitations on what resource types are permitted for the reference.  For example, it would not be legitimate to send the identifier for a drug prescription if the type were Reference(Observation|DiagnosticReport).  One of the use-cases for Reference.identifier is the situation where no FHIR representation exists (where the type is Reference (Any).",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "Identifier"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Reference.display",
    ///         "path": "Reference.display",
    ///         "short": "Text alternative for the resource",
    ///         "definition": "Plain text narrative that identifies the resource in addition to the resource reference.",
    ///         "comment": "This is generally not the same as the Resource.text of the referenced resource.  The purpose is to identify what's being referenced, not to fully describe it.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "string"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    // 0. Reference
    public class Reference_Type : MakerComplex_Type                                                                                         // MakerGen.cs:337
    {                                                                                                                                       // MakerGen.cs:338
        // 1. Reference.reference
        public MakerElementInstance Reference;                                                                                              // MakerGen.cs:217
        // 2. Reference.type
        public MakerElementInstance Type;                                                                                                   // MakerGen.cs:217
        // 3. Reference.identifier
        public MakerElementInstance Identifier;                                                                                             // MakerGen.cs:217
        // 4. Reference.display
        public MakerElementInstance Display;                                                                                                // MakerGen.cs:217
        public Reference_Type()                                                                                                             // MakerGen.cs:346
        {                                                                                                                                   // MakerGen.cs:347
            {                                                                                                                               // MakerGen.cs:228
                // 1. Reference.reference
                this.Reference = new MakerElementInstance                                                                                   // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Reference",                                                                                                     // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new String_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 2. Reference.type
                this.Type = new MakerElementInstance                                                                                        // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Type",                                                                                                          // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new Uri_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 3. Reference.identifier
                this.Identifier = new MakerElementInstance                                                                                  // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Identifier",                                                                                                    // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 4. Reference.display
                this.Display = new MakerElementInstance                                                                                     // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Display",                                                                                                       // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new String_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
        }                                                                                                                                   // MakerGen.cs:358
    }                                                                                                                                       // MakerGen.cs:342
}                                                                                                                                           // MakerGen.cs:389
