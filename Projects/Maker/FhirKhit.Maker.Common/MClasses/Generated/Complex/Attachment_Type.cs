using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:267
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:268
{                                                                                                                                           // MakerGen.cs:269
    /// <summary>
    /// Fhir primitive 'Attachment'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "Attachment",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/Attachment",
    ///   "version": "4.0.0",
    ///   "name": "Attachment",
    ///   "status": "active",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for Attachment Type: For referring to data content defined in other formats.",
    ///   "purpose": "Many models need to include data defined in other specifications that is complex and opaque to the healthcare model. This includes documents, media recordings, structured data, etc.",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": false,
    ///   "type": "Attachment",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "Attachment",
    ///         "path": "Attachment",
    ///         "short": "Content in a format defined elsewhere",
    ///         "definition": "For referring to data content defined in other formats.",
    ///         "comment": "When providing a summary view (for example with Observation.value[x]) Attachment should be represented with a brief display text such as \"Signed Procedure Consent\".",
    ///         "min": 0,
    ///         "max": "*"
    ///       },
    ///       {
    ///         "id": "Attachment.contentType",
    ///         "path": "Attachment.contentType",
    ///         "short": "Mime type of the content, with charset etc.",
    ///         "definition": "Identifies the type of the data in the attachment and allows a method to be chosen to interpret or render the data. Includes mime type parameters such as charset where appropriate.",
    ///         "requirements": "Processors of the data need to be able to know how to interpret the data.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "code"
    ///           }
    ///         ],
    ///         "example": [
    ///           {
    ///             "label": "General",
    ///             "valueCode": "text/plain; charset=UTF-8, image/png"
    ///           }
    ///         ],
    ///         "isSummary": true,
    ///         "binding": {
    ///           "extension": [
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
    ///               "valueString": "MimeType"
    ///             },
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
    ///               "valueBoolean": true
    ///             }
    ///           ],
    ///           "strength": "required",
    ///           "description": "The mime type of an attachment. Any valid mime type is allowed.",
    ///           "valueSet": "http://hl7.org/fhir/ValueSet/mimetypes|4.0.0"
    ///         }
    ///       },
    ///       {
    ///         "id": "Attachment.language",
    ///         "path": "Attachment.language",
    ///         "short": "Human language of the content (BCP-47)",
    ///         "definition": "The human language of the content. The value can be any valid value according to BCP 47.",
    ///         "requirements": "Users need to be able to choose between the languages in a set of attachments.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "code"
    ///           }
    ///         ],
    ///         "example": [
    ///           {
    ///             "label": "General",
    ///             "valueCode": "en-AU"
    ///           }
    ///         ],
    ///         "isSummary": true,
    ///         "binding": {
    ///           "extension": [
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-maxValueSet",
    ///               "valueCanonical": "http://hl7.org/fhir/ValueSet/all-languages"
    ///             },
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
    ///               "valueString": "Language"
    ///             },
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
    ///               "valueBoolean": true
    ///             }
    ///           ],
    ///           "strength": "preferred",
    ///           "description": "A human language.",
    ///           "valueSet": "http://hl7.org/fhir/ValueSet/languages"
    ///         }
    ///       },
    ///       {
    ///         "id": "Attachment.data",
    ///         "path": "Attachment.data",
    ///         "short": "Data inline, base64ed",
    ///         "definition": "The actual data of the attachment - a sequence of bytes, base64 encoded.",
    ///         "comment": "The base64-encoded data SHALL be expressed in the same character set as the base resource XML or JSON.",
    ///         "requirements": "The data needs to able to be transmitted inline.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "base64Binary"
    ///           }
    ///         ]
    ///       },
    ///       {
    ///         "id": "Attachment.url",
    ///         "path": "Attachment.url",
    ///         "short": "Uri where the data can be found",
    ///         "definition": "A location where the data can be accessed.",
    ///         "comment": "If both data and url are provided, the url SHALL point to the same content as the data contains. Urls may be relative references or may reference transient locations such as a wrapping envelope using cid: though this has ramifications for using signatures. Relative URLs are interpreted relative to the service url, like a resource reference, rather than relative to the resource itself. If a URL is provided, it SHALL resolve to actual data.",
    ///         "requirements": "The data needs to be transmitted by reference.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "url"
    ///           }
    ///         ],
    ///         "example": [
    ///           {
    ///             "label": "General",
    ///             "valueUrl": "http://www.acme.com/logo-small.png"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Attachment.size",
    ///         "path": "Attachment.size",
    ///         "short": "Number of bytes of content (if url provided)",
    ///         "definition": "The number of bytes of data that make up this attachment (before base64 encoding, if that is done).",
    ///         "comment": "The number of bytes is redundant if the data is provided as a base64binary, but is useful if the data is provided as a url reference.",
    ///         "requirements": "Representing the size allows applications to determine whether they should fetch the content automatically in advance, or refuse to fetch it at all.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "unsignedInt"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Attachment.hash",
    ///         "path": "Attachment.hash",
    ///         "short": "Hash of the data (sha-1, base64ed)",
    ///         "definition": "The calculated hash of the data using SHA-1. Represented using base64.",
    ///         "comment": "The hash is calculated on the data prior to base64 encoding, if the data is based64 encoded. The hash is not intended to support digital signatures. Where protection against malicious threats a digital signature should be considered, see [Provenance.signature](provenance-definitions.html#Provenance.signature) for mechanism to protect a resource with a digital signature.",
    ///         "requirements": "Included so that applications can verify that the contents of a location have not changed due to technical failures (e.g., storage rot, transport glitch, incorrect version).",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "base64Binary"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Attachment.title",
    ///         "path": "Attachment.title",
    ///         "short": "Label to display in place of the data",
    ///         "definition": "A label or set of text to display in place of the data.",
    ///         "requirements": "Applications need a label to display to a human user in place of the actual data if the data cannot be rendered or perceived by the viewer.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "string"
    ///           }
    ///         ],
    ///         "example": [
    ///           {
    ///             "label": "General",
    ///             "valueString": "Official Corporate Logo"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Attachment.creation",
    ///         "path": "Attachment.creation",
    ///         "short": "Date attachment was first created",
    ///         "definition": "The date that the attachment was first created.",
    ///         "requirements": "This is often tracked as an integrity issue for use of the attachment.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "dateTime"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    // 0. Attachment
    public class Attachment_Type : Complex_Type                                                                                             // MakerGen.cs:220
    {                                                                                                                                       // MakerGen.cs:221
        // 1. Attachment.contentType
        public ElementInstance ContentType;                                                                                                 // MakerGen.cs:203
        // 2. Attachment.language
        public ElementInstance Language;                                                                                                    // MakerGen.cs:203
        // 3. Attachment.data
        public ElementInstance Data;                                                                                                        // MakerGen.cs:203
        // 4. Attachment.url
        public ElementInstance Url;                                                                                                         // MakerGen.cs:203
        // 5. Attachment.size
        public ElementInstance Size;                                                                                                        // MakerGen.cs:203
        // 6. Attachment.hash
        public ElementInstance Hash;                                                                                                        // MakerGen.cs:203
        // 7. Attachment.title
        public ElementInstance Title;                                                                                                       // MakerGen.cs:203
        // 8. Attachment.creation
        public ElementInstance Creation;                                                                                                    // MakerGen.cs:203
        public Attachment_Type()                                                                                                            // MakerGen.cs:229
        {                                                                                                                                   // MakerGen.cs:230
        }                                                                                                                                   // MakerGen.cs:244
    }                                                                                                                                       // MakerGen.cs:225
}                                                                                                                                           // MakerGen.cs:275