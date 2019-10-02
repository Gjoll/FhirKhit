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
      "id": "Endpoint",
      "url": "http://hl7.org/fhir/StructureDefinition/Endpoint",
      "version": "4.0.0",
      "name": "Endpoint",
      "status": "draft",
      "publisher": "Health Level Seven International (Patient Administration)",
      "description": "The technical details of an endpoint that can be used for electronic services, such as for web services providing XDS.b or a REST endpoint for another FHIR server. This may include any security context information.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "Endpoint",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Endpoint",
            "path": "Endpoint",
            "short": "The technical details of an endpoint that can be used for electronic services",
            "definition": "The technical details of an endpoint that can be used for electronic services, such as for web services providing XDS.b or a REST endpoint for another FHIR server. This may include any security context information.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Endpoint.identifier",
            "path": "Endpoint.identifier",
            "short": "Identifies this endpoint across multiple systems",
            "definition": "Identifier for the organization that is used to identify the endpoint across multiple disparate systems.",
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
            "id": "Endpoint.status",
            "path": "Endpoint.status",
            "short": "active | suspended | error | off | entered-in-error | test",
            "definition": "active | suspended | error | off | test.",
            "comment": "This element is labeled as a modifier because the status contains codes that mark the endpoint as not currently valid.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isModifier": true,
            "isModifierReason": "This element is labelled as a modifier because it is a status element that contains status entered-in-error which means that the resource should not be treated as valid",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "EndpointStatus"
                }
              ],
              "strength": "required",
              "description": "The status of the endpoint.",
              "valueSet": "http://hl7.org/fhir/ValueSet/endpoint-status|4.0.0"
            }
          },
          {
            "id": "Endpoint.connectionType",
            "path": "Endpoint.connectionType",
            "short": "Protocol/Profile/Standard to be used with this endpoint connection",
            "definition": "A coded value that represents the technical details of the usage of this endpoint, such as what WSDLs should be used in what way. (e.g. XDS.b/DICOM/cds-hook).",
            "comment": "For additional connectivity details for the protocol, extensions will be used at this point, as in the XDS example.",
            "min": 1,
            "max": "1",
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
                  "valueString": "endpoint-contype"
                }
              ],
              "strength": "extensible",
              "valueSet": "http://hl7.org/fhir/ValueSet/endpoint-connection-type"
            }
          },
          {
            "id": "Endpoint.name",
            "path": "Endpoint.name",
            "short": "A name that this endpoint can be identified by",
            "definition": "A friendly name that this endpoint can be referred to with.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Endpoint.managingOrganization",
            "path": "Endpoint.managingOrganization",
            "short": "Organization that manages this endpoint (might not be the organization that exposes the endpoint)",
            "definition": "The organization that manages this endpoint (even if technically another organization is hosting this in the cloud, it is the organization associated with the data).",
            "comment": "This property is not typically used when searching for Endpoint resources for usage. The typical usage is via the reference from an applicable Organization/Location/Practitioner resource, which is where the context is provided. Multiple Locations may reference a single endpoint, and don't have to be within the same organization resource, but most likely within the same organizational hierarchy.",
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
            "id": "Endpoint.contact",
            "path": "Endpoint.contact",
            "short": "Contact details for source (e.g. troubleshooting)",
            "definition": "Contact details for a human to contact about the subscription. The primary use of this for system administrator troubleshooting.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "ContactPoint"
              }
            ]
          },
          {
            "id": "Endpoint.period",
            "path": "Endpoint.period",
            "short": "Interval the endpoint is expected to be operational",
            "definition": "The interval during which the endpoint is expected to be operational.",
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
            "id": "Endpoint.payloadType",
            "path": "Endpoint.payloadType",
            "short": "The type of content that may be used at this endpoint (e.g. XDS Discharge summaries)",
            "definition": "The payload type describes the acceptable content that can be communicated on the endpoint.",
            "comment": "The payloadFormat describes the serialization format of the data, where the payloadType indicates the specific document/schema that is being transferred; e.g. DischargeSummary or CarePlan.",
            "min": 1,
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
                  "valueString": "PayloadType"
                }
              ],
              "strength": "example",
              "valueSet": "http://hl7.org/fhir/ValueSet/endpoint-payload-type"
            }
          },
          {
            "id": "Endpoint.payloadMimeType",
            "path": "Endpoint.payloadMimeType",
            "short": "Mimetype to send. If not specified, the content could be anything (including no payload, if the connectionType defined this)",
            "definition": "The mime type to send the payload in - e.g. application/fhir+xml, application/fhir+json. If the mime type is not specified, then the sender could send any content (including no content depending on the connectionType).",
            "comment": "Sending the payload has obvious security consequences. The server is responsible for ensuring that the content is appropriately secured.",
            "min": 0,
            "max": "*",
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
            "id": "Endpoint.address",
            "path": "Endpoint.address",
            "short": "The technical base address for connecting to this endpoint",
            "definition": "The uri that describes the actual end-point to connect to.",
            "comment": "For rest-hook, and websocket, the end-point must be an http: or https: URL; for email, a mailto: url, for sms, a tel: url, and for message the endpoint can be in any form of url the server understands (usually, http: or mllp:). The URI is allowed to be relative; in which case, it is relative to the server end-point (since there may be more than one, clients should avoid using relative URIs)\n\nThis address will be to the service base, without any parameters, or sub-services or resources tacked on.\n\nE.g. for a WADO-RS endpoint, the url should be \"https://pacs.hospital.org/wado-rs\"\n\nand not \"https://pacs.hospital.org/wado-rs/studies/1.2.250.1.59.40211.12345678.678910/series/1.2.250.1.59.40211.789001276.14556172.67789/instances/...\".",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "url"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Endpoint.header",
            "path": "Endpoint.header",
            "short": "Usage depends on the channel type",
            "definition": "Additional headers / information to send as part of the notification.",
            "comment": "Exactly what these mean depends on the channel type. The can convey additional information to the recipient and/or meet security requirements.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "string"
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
    /// Fhir resource 'Endpoint'
    /// </summary>
    // 0. Endpoint
    public class Resource_Endpoint : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 1. Endpoint.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. Endpoint.status
        public ElementDefinitionInfo Element_Status;
        // 3. Endpoint.connectionType
        public ElementDefinitionInfo Element_ConnectionType;
        // 4. Endpoint.name
        public ElementDefinitionInfo Element_Name;
        // 5. Endpoint.managingOrganization
        public ElementDefinitionInfo Element_ManagingOrganization;
        // 6. Endpoint.contact
        public ElementDefinitionInfo Element_Contact;
        // 7. Endpoint.period
        public ElementDefinitionInfo Element_Period;
        // 8. Endpoint.payloadType
        public ElementDefinitionInfo Element_PayloadType;
        // 9. Endpoint.payloadMimeType
        public ElementDefinitionInfo Element_PayloadMimeType;
        // 10. Endpoint.address
        public ElementDefinitionInfo Element_Address;
        // 11. Endpoint.header
        public ElementDefinitionInfo Element_Header;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "Endpoint",
                ElementId = "Endpoint"
            });
            Element_Identifier.Write(sDef);
            Element_Status.Write(sDef);
            Element_ConnectionType.Write(sDef);
            Element_Name.Write(sDef);
            Element_ManagingOrganization.Write(sDef);
            Element_Contact.Write(sDef);
            Element_Period.Write(sDef);
            Element_PayloadType.Write(sDef);
            Element_PayloadMimeType.Write(sDef);
            Element_Address.Write(sDef);
            Element_Header.Write(sDef);
        }
        
        public Resource_Endpoint()
        {
            {
                // 1. Endpoint.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "Endpoint.identifier",
                    Id = "Endpoint.identifier",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Identifier
                        {
                        }
                    }
                };
            }
            {
                // 2. Endpoint.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "Endpoint.status",
                    Id = "Endpoint.status",
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
                // 3. Endpoint.connectionType
                this.Element_ConnectionType = new ElementDefinitionInfo
                {
                    Name = "Element_ConnectionType",
                    Path= "Endpoint.connectionType",
                    Id = "Endpoint.connectionType",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Coding
                        {
                        }
                    }
                };
            }
            {
                // 4. Endpoint.name
                this.Element_Name = new ElementDefinitionInfo
                {
                    Name = "Element_Name",
                    Path= "Endpoint.name",
                    Id = "Endpoint.name",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_String
                        {
                        }
                    }
                };
            }
            {
                // 5. Endpoint.managingOrganization
                this.Element_ManagingOrganization = new ElementDefinitionInfo
                {
                    Name = "Element_ManagingOrganization",
                    Path= "Endpoint.managingOrganization",
                    Id = "Endpoint.managingOrganization",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Organization"
                            }
                        }
                    }
                };
            }
            {
                // 6. Endpoint.contact
                this.Element_Contact = new ElementDefinitionInfo
                {
                    Name = "Element_Contact",
                    Path= "Endpoint.contact",
                    Id = "Endpoint.contact",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_ContactPoint
                        {
                        }
                    }
                };
            }
            {
                // 7. Endpoint.period
                this.Element_Period = new ElementDefinitionInfo
                {
                    Name = "Element_Period",
                    Path= "Endpoint.period",
                    Id = "Endpoint.period",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Period
                        {
                        }
                    }
                };
            }
            {
                // 8. Endpoint.payloadType
                this.Element_PayloadType = new ElementDefinitionInfo
                {
                    Name = "Element_PayloadType",
                    Path= "Endpoint.payloadType",
                    Id = "Endpoint.payloadType",
                    Min = 1,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                        {
                        }
                    }
                };
            }
            {
                // 9. Endpoint.payloadMimeType
                this.Element_PayloadMimeType = new ElementDefinitionInfo
                {
                    Name = "Element_PayloadMimeType",
                    Path= "Endpoint.payloadMimeType",
                    Id = "Endpoint.payloadMimeType",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code
                        {
                        }
                    }
                };
            }
            {
                // 10. Endpoint.address
                this.Element_Address = new ElementDefinitionInfo
                {
                    Name = "Element_Address",
                    Path= "Endpoint.address",
                    Id = "Endpoint.address",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Url
                        {
                        }
                    }
                };
            }
            {
                // 11. Endpoint.header
                this.Element_Header = new ElementDefinitionInfo
                {
                    Name = "Element_Header",
                    Path= "Endpoint.header",
                    Id = "Endpoint.header",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_String
                        {
                        }
                    }
                };
            }
            this.Name = "Endpoint";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Endpoint";
        }
    }
}
