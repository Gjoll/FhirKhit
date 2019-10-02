using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;

namespace FhirKhit.Maker.Common.Resource
{
    #region Json
    #if NEVER
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
    #endregion
    /// <summary>
    /// Fhir resource 'Binary'
    /// </summary>
    // 0. Binary
    public partial class Resource_Binary : FhirKhit.Maker.Common.Resource.Resource_Resource
    {
        // 1. Binary.contentType
        public ElementDefinitionInfo Element_ContentType;
        // 2. Binary.securityContext
        public ElementDefinitionInfo Element_SecurityContext;
        // 3. Binary.data
        public ElementDefinitionInfo Element_Data;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "Binary",
                ElementId = "Binary"
            });
            Element_ContentType.Write(sDef);
            Element_SecurityContext.Write(sDef);
            Element_Data.Write(sDef);
        }
        
        public Resource_Binary()
        {
            {
                // 1. Binary.contentType
                this.Element_ContentType = new ElementDefinitionInfo
                {
                    Name = "Element_ContentType",
                    Path= "Binary.contentType",
                    Id = "Binary.contentType",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code
                        {
                        }
                    }
                };
            }
            {
                // 2. Binary.securityContext
                this.Element_SecurityContext = new ElementDefinitionInfo
                {
                    Name = "Element_SecurityContext",
                    Path= "Binary.securityContext",
                    Id = "Binary.securityContext",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Resource"
                            }
                        }
                    }
                };
            }
            {
                // 3. Binary.data
                this.Element_Data = new ElementDefinitionInfo
                {
                    Name = "Element_Data",
                    Path= "Binary.data",
                    Id = "Binary.data",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Base64Binary
                        {
                        }
                    }
                };
            }
            this.Name = "Binary";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Binary";
        }
    }
}
