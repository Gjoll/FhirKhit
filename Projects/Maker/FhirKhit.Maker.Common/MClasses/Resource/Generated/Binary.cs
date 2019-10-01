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
      "id": "Binary",
      "url": "http://hl7.org/fhir/StructureDefinition/Binary",
      "version": "4.0.0",
      "name": "Binary",
      "status": "active",
      "publisher": "Health Level Seven International (FHIR Infrastructure)",
      "description": "A resource that represents the data of a single raw artifact as digital content accessible in its native format.  A Binary resource can contain any content, whether text, image, pdf, zip archive, etc.",
      "purpose": "There are situations where it is useful or required to handle pure binary content using the same framework as other resources.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "Binary",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Resource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Binary",
            "path": "Binary",
            "short": "Pure binary content defined by a format other than FHIR",
            "definition": "A resource that represents the data of a single raw artifact as digital content accessible in its native format.  A Binary resource can contain any content, whether text, image, pdf, zip archive, etc.",
            "comment": "Typically, Binary resources are used for handling content such as:  \n\n* CDA Documents (i.e. with XDS) \n* PDF Documents \n* Images (the Media resource is preferred for handling images, but not possible when the content is already binary - e.g. XDS).",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Binary.contentType",
            "path": "Binary.contentType",
            "short": "MimeType of the binary content",
            "definition": "MimeType of the binary content represented as a standard MimeType (BCP 13).",
            "min": 1,
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
                  "valueString": "MimeType"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "required",
              "description": "The mime type of an attachment. Any valid mime type is allowed.",
              "valueSet": "http://hl7.org/fhir/ValueSet/mimetypes|4.0.0"
            }
          },
          {
            "id": "Binary.securityContext",
            "path": "Binary.securityContext",
            "short": "Identifies another resource to use as proxy when enforcing access control",
            "definition": "This element identifies another resource that can be used as a proxy of the security sensitivity to use when deciding and enforcing access control rules for the Binary resource. Given that the Binary resource contains very few elements that can be used to determine the sensitivity of the data and relationships to individuals, the referenced resource stands in as a proxy equivalent for this purpose. This referenced resource may be related to the Binary (e.g. Media, DocumentReference), or may be some non-related Resource purely as a security proxy. E.g. to identify that the binary resource relates to a patient, and access should only be granted to applications that have access to the patient.",
            "comment": "Very often, a server will also know of a resource that references the binary, and can automatically apply the appropriate access rules based on that reference. However, there are some circumstances where this is not appropriate, e.g. the binary is uploaded directly to the server without any linking resource, the binary is referred to from multiple different resources, and/or the binary is content such as an application logo that has less protection than any of the resources that reference it.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Resource"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Binary.data",
            "path": "Binary.data",
            "short": "The actual content",
            "definition": "The actual content, base64 encoded.",
            "comment": "If the content type is itself base64 encoding, then this will be base64 encoded twice - what is created by un-base64ing the content must be the specified content type.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "base64Binary"
              }
            ],
            "isSummary": false
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:463
    /// <summary>
    /// Fhir resource 'Binary'
    /// </summary>
    // 0. Binary
    public class Binary : FhirKhit.Maker.Common.Resource.ResourceBase                                                                       // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class Binary_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                          // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 1. Binary.contentType
            public ElementDefinitionInfo ContentType;                                                                                       // MakerGen.cs:236
            // 2. Binary.securityContext
            public ElementDefinitionInfo SecurityContext;                                                                                   // MakerGen.cs:236
            // 3. Binary.data
            public ElementDefinitionInfo Data;                                                                                              // MakerGen.cs:236
            public Binary_Elements()                                                                                                        // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:251
                    // 1. Binary.contentType
                    this.ContentType = new ElementDefinitionInfo                                                                            // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "ContentType",                                                                                               // MakerGen.cs:255
                        Path= "Binary.contentType",                                                                                         // MakerGen.cs:256
                        Id = "Binary.contentType",                                                                                          // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
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
                    // 2. Binary.securityContext
                    this.SecurityContext = new ElementDefinitionInfo                                                                        // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "SecurityContext",                                                                                           // MakerGen.cs:255
                        Path= "Binary.securityContext",                                                                                     // MakerGen.cs:256
                        Id = "Binary.securityContext",                                                                                      // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Resource"                                                      // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 3. Binary.data
                    this.Data = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Data",                                                                                                      // MakerGen.cs:255
                        Path= "Binary.data",                                                                                                // MakerGen.cs:256
                        Id = "Binary.data",                                                                                                 // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Base64Binary                                                                // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:429
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:414
            {                                                                                                                               // MakerGen.cs:415
                base.Write(sDef);                                                                                                           // MakerGen.cs:416
                ContentType.Write(sDef);                                                                                                    // MakerGen.cs:240
                SecurityContext.Write(sDef);                                                                                                // MakerGen.cs:240
                Data.Write(sDef);                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public Binary_Elements Elements { get; }                                                                                            // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public Binary()                                                                                                                     // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new Binary_Elements();                                                                                          // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:468
