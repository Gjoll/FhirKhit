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
    #endregion                                                                                                                              // MakerGen.cs:440
    /// <summary>
    /// Fhir resource 'Endpoint'
    /// </summary>
    // 0. Endpoint
    public class Resource_Endpoint : FhirKhit.Maker.Common.Resource.ResourceBase                                                            // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        // 1. Endpoint.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:212
        // 2. Endpoint.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:212
        // 3. Endpoint.connectionType
        public ElementDefinitionInfo Element_ConnectionType;                                                                                // MakerGen.cs:212
        // 4. Endpoint.name
        public ElementDefinitionInfo Element_Name;                                                                                          // MakerGen.cs:212
        // 5. Endpoint.managingOrganization
        public ElementDefinitionInfo Element_ManagingOrganization;                                                                          // MakerGen.cs:212
        // 6. Endpoint.contact
        public ElementDefinitionInfo Element_Contact;                                                                                       // MakerGen.cs:212
        // 7. Endpoint.period
        public ElementDefinitionInfo Element_Period;                                                                                        // MakerGen.cs:212
        // 8. Endpoint.payloadType
        public ElementDefinitionInfo Element_PayloadType;                                                                                   // MakerGen.cs:212
        // 9. Endpoint.payloadMimeType
        public ElementDefinitionInfo Element_PayloadMimeType;                                                                               // MakerGen.cs:212
        // 10. Endpoint.address
        public ElementDefinitionInfo Element_Address;                                                                                       // MakerGen.cs:212
        // 11. Endpoint.header
        public ElementDefinitionInfo Element_Header;                                                                                        // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            base.Write(sDef);                                                                                                               // MakerGen.cs:385
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:386
            {                                                                                                                               // MakerGen.cs:387
                Path = "Endpoint",                                                                                                          // MakerGen.cs:388
                ElementId = "Endpoint"                                                                                                      // MakerGen.cs:389
            });                                                                                                                             // MakerGen.cs:390
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_ConnectionType.Write(sDef);                                                                                             // MakerGen.cs:216
            Element_Name.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_ManagingOrganization.Write(sDef);                                                                                       // MakerGen.cs:216
            Element_Contact.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Period.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_PayloadType.Write(sDef);                                                                                                // MakerGen.cs:216
            Element_PayloadMimeType.Write(sDef);                                                                                            // MakerGen.cs:216
            Element_Address.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Header.Write(sDef);                                                                                                     // MakerGen.cs:216
        }                                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
        public Resource_Endpoint()                                                                                                          // MakerGen.cs:395
        {                                                                                                                                   // MakerGen.cs:396
            {                                                                                                                               // MakerGen.cs:227
                // 1. Endpoint.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:231
                    Path= "Endpoint.identifier",                                                                                            // MakerGen.cs:232
                    Id = "Endpoint.identifier",                                                                                             // MakerGen.cs:233
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
                // 2. Endpoint.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Status",                                                                                                // MakerGen.cs:231
                    Path= "Endpoint.status",                                                                                                // MakerGen.cs:232
                    Id = "Endpoint.status",                                                                                                 // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 3. Endpoint.connectionType
                this.Element_ConnectionType = new ElementDefinitionInfo                                                                     // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_ConnectionType",                                                                                        // MakerGen.cs:231
                    Path= "Endpoint.connectionType",                                                                                        // MakerGen.cs:232
                    Id = "Endpoint.connectionType",                                                                                         // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Coding                                                                       // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 4. Endpoint.name
                this.Element_Name = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Name",                                                                                                  // MakerGen.cs:231
                    Path= "Endpoint.name",                                                                                                  // MakerGen.cs:232
                    Id = "Endpoint.name",                                                                                                   // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 5. Endpoint.managingOrganization
                this.Element_ManagingOrganization = new ElementDefinitionInfo                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_ManagingOrganization",                                                                                  // MakerGen.cs:231
                    Path= "Endpoint.managingOrganization",                                                                                  // MakerGen.cs:232
                    Id = "Endpoint.managingOrganization",                                                                                   // MakerGen.cs:233
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
                // 6. Endpoint.contact
                this.Element_Contact = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Contact",                                                                                               // MakerGen.cs:231
                    Path= "Endpoint.contact",                                                                                               // MakerGen.cs:232
                    Id = "Endpoint.contact",                                                                                                // MakerGen.cs:233
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
                // 7. Endpoint.period
                this.Element_Period = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Period",                                                                                                // MakerGen.cs:231
                    Path= "Endpoint.period",                                                                                                // MakerGen.cs:232
                    Id = "Endpoint.period",                                                                                                 // MakerGen.cs:233
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
                // 8. Endpoint.payloadType
                this.Element_PayloadType = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_PayloadType",                                                                                           // MakerGen.cs:231
                    Path= "Endpoint.payloadType",                                                                                           // MakerGen.cs:232
                    Id = "Endpoint.payloadType",                                                                                            // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
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
                // 9. Endpoint.payloadMimeType
                this.Element_PayloadMimeType = new ElementDefinitionInfo                                                                    // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_PayloadMimeType",                                                                                       // MakerGen.cs:231
                    Path= "Endpoint.payloadMimeType",                                                                                       // MakerGen.cs:232
                    Id = "Endpoint.payloadMimeType",                                                                                        // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 10. Endpoint.address
                this.Element_Address = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Address",                                                                                               // MakerGen.cs:231
                    Path= "Endpoint.address",                                                                                               // MakerGen.cs:232
                    Id = "Endpoint.address",                                                                                                // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Url                                                                   // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 11. Endpoint.header
                this.Element_Header = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Header",                                                                                                // MakerGen.cs:231
                    Path= "Endpoint.header",                                                                                                // MakerGen.cs:232
                    Id = "Endpoint.header",                                                                                                 // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            this.Name = "Endpoint";                                                                                                         // MakerGen.cs:458
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Endpoint";                                                                  // MakerGen.cs:459
        }                                                                                                                                   // MakerGen.cs:398
    }                                                                                                                                       // MakerGen.cs:400
}                                                                                                                                           // MakerGen.cs:445
