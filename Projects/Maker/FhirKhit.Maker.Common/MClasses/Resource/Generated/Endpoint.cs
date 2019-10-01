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
    #endregion                                                                                                                              // MakerGen.cs:474
    /// <summary>
    /// Fhir resource 'Endpoint'
    /// </summary>
    // 0. Endpoint
    public class Endpoint : FhirKhit.Maker.Common.Resource.ResourceBase                                                                     // MakerGen.cs:384
    {                                                                                                                                       // MakerGen.cs:385
        public class Endpoint_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                        // MakerGen.cs:386
        {                                                                                                                                   // MakerGen.cs:387
            // 1. Endpoint.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:216
            // 2. Endpoint.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:216
            // 3. Endpoint.connectionType
            public ElementDefinitionInfo ConnectionType;                                                                                    // MakerGen.cs:216
            // 4. Endpoint.name
            public ElementDefinitionInfo Name;                                                                                              // MakerGen.cs:216
            // 5. Endpoint.managingOrganization
            public ElementDefinitionInfo ManagingOrganization;                                                                              // MakerGen.cs:216
            // 6. Endpoint.contact
            public ElementDefinitionInfo Contact;                                                                                           // MakerGen.cs:216
            // 7. Endpoint.period
            public ElementDefinitionInfo Period;                                                                                            // MakerGen.cs:216
            // 8. Endpoint.payloadType
            public ElementDefinitionInfo PayloadType;                                                                                       // MakerGen.cs:216
            // 9. Endpoint.payloadMimeType
            public ElementDefinitionInfo PayloadMimeType;                                                                                   // MakerGen.cs:216
            // 10. Endpoint.address
            public ElementDefinitionInfo Address;                                                                                           // MakerGen.cs:216
            // 11. Endpoint.header
            public ElementDefinitionInfo Header;                                                                                            // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
            public Endpoint_Elements()                                                                                                      // MakerGen.cs:392
            {                                                                                                                               // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:231
                    // 1. Endpoint.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Identifier",                                                                                                // MakerGen.cs:235
                        Path= "Endpoint.identifier",                                                                                        // MakerGen.cs:236
                        Id = "Endpoint.identifier",                                                                                         // MakerGen.cs:237
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
                    // 2. Endpoint.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Status",                                                                                                    // MakerGen.cs:235
                        Path= "Endpoint.status",                                                                                            // MakerGen.cs:236
                        Id = "Endpoint.status",                                                                                             // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 3. Endpoint.connectionType
                    this.ConnectionType = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ConnectionType",                                                                                            // MakerGen.cs:235
                        Path= "Endpoint.connectionType",                                                                                    // MakerGen.cs:236
                        Id = "Endpoint.connectionType",                                                                                     // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Coding                                                                        // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 4. Endpoint.name
                    this.Name = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Name",                                                                                                      // MakerGen.cs:235
                        Path= "Endpoint.name",                                                                                              // MakerGen.cs:236
                        Id = "Endpoint.name",                                                                                               // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 5. Endpoint.managingOrganization
                    this.ManagingOrganization = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ManagingOrganization",                                                                                      // MakerGen.cs:235
                        Path= "Endpoint.managingOrganization",                                                                              // MakerGen.cs:236
                        Id = "Endpoint.managingOrganization",                                                                               // MakerGen.cs:237
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
                    // 6. Endpoint.contact
                    this.Contact = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Contact",                                                                                                   // MakerGen.cs:235
                        Path= "Endpoint.contact",                                                                                           // MakerGen.cs:236
                        Id = "Endpoint.contact",                                                                                            // MakerGen.cs:237
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
                    // 7. Endpoint.period
                    this.Period = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Period",                                                                                                    // MakerGen.cs:235
                        Path= "Endpoint.period",                                                                                            // MakerGen.cs:236
                        Id = "Endpoint.period",                                                                                             // MakerGen.cs:237
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
                    // 8. Endpoint.payloadType
                    this.PayloadType = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "PayloadType",                                                                                               // MakerGen.cs:235
                        Path= "Endpoint.payloadType",                                                                                       // MakerGen.cs:236
                        Id = "Endpoint.payloadType",                                                                                        // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
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
                    // 9. Endpoint.payloadMimeType
                    this.PayloadMimeType = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "PayloadMimeType",                                                                                           // MakerGen.cs:235
                        Path= "Endpoint.payloadMimeType",                                                                                   // MakerGen.cs:236
                        Id = "Endpoint.payloadMimeType",                                                                                    // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 10. Endpoint.address
                    this.Address = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Address",                                                                                                   // MakerGen.cs:235
                        Path= "Endpoint.address",                                                                                           // MakerGen.cs:236
                        Id = "Endpoint.address",                                                                                            // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Url                                                                         // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 11. Endpoint.header
                    this.Header = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Header",                                                                                                    // MakerGen.cs:235
                        Path= "Endpoint.header",                                                                                            // MakerGen.cs:236
                        Id = "Endpoint.header",                                                                                             // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:398
            {                                                                                                                               // MakerGen.cs:399
                base.Write(sDef);                                                                                                           // MakerGen.cs:400
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:220
                Status.Write(sDef);                                                                                                         // MakerGen.cs:220
                ConnectionType.Write(sDef);                                                                                                 // MakerGen.cs:220
                Name.Write(sDef);                                                                                                           // MakerGen.cs:220
                ManagingOrganization.Write(sDef);                                                                                           // MakerGen.cs:220
                Contact.Write(sDef);                                                                                                        // MakerGen.cs:220
                Period.Write(sDef);                                                                                                         // MakerGen.cs:220
                PayloadType.Write(sDef);                                                                                                    // MakerGen.cs:220
                PayloadMimeType.Write(sDef);                                                                                                // MakerGen.cs:220
                Address.Write(sDef);                                                                                                        // MakerGen.cs:220
                Header.Write(sDef);                                                                                                         // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:402
        }                                                                                                                                   // MakerGen.cs:404
        public Endpoint_Elements Elements                                                                                                   // MakerGen.cs:406
        {                                                                                                                                   // MakerGen.cs:407
            get                                                                                                                             // MakerGen.cs:408
            {                                                                                                                               // MakerGen.cs:409
                if (this.elements == null)                                                                                                  // MakerGen.cs:410
                    this.elements = new Endpoint_Elements();                                                                                // MakerGen.cs:411
                return this.elements;                                                                                                       // MakerGen.cs:412
            }                                                                                                                               // MakerGen.cs:413
        }                                                                                                                                   // MakerGen.cs:414
        Endpoint_Elements elements;                                                                                                         // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
        public Endpoint()                                                                                                                   // MakerGen.cs:418
        {                                                                                                                                   // MakerGen.cs:419
            this.Name = "Endpoint";                                                                                                         // MakerGen.cs:492
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Endpoint";                                                                  // MakerGen.cs:493
        }                                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:424
        {                                                                                                                                   // MakerGen.cs:425
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:426
            {                                                                                                                               // MakerGen.cs:427
                Path = "Endpoint",                                                                                                          // MakerGen.cs:428
                ElementId = "Endpoint"                                                                                                      // MakerGen.cs:429
            });                                                                                                                             // MakerGen.cs:430
            if (this.elements != null)                                                                                                      // MakerGen.cs:431
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:432
        }                                                                                                                                   // MakerGen.cs:433
    }                                                                                                                                       // MakerGen.cs:434
}                                                                                                                                           // MakerGen.cs:479
