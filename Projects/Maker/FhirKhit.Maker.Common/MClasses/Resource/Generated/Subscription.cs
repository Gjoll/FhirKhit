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
      "id": "Subscription",
      "url": "http://hl7.org/fhir/StructureDefinition/Subscription",
      "version": "4.0.0",
      "name": "Subscription",
      "status": "draft",
      "publisher": "Health Level Seven International (FHIR Infrastructure)",
      "description": "The subscription resource is used to define a push-based subscription from a server to another system. Once a subscription is registered with the server, the server checks every resource that is created or updated, and if the resource matches the given criteria, it sends a message on the defined \"channel\" so that another system can take an appropriate action.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "Subscription",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Subscription",
            "path": "Subscription",
            "short": "Server push subscription criteria",
            "definition": "The subscription resource is used to define a push-based subscription from a server to another system. Once a subscription is registered with the server, the server checks every resource that is created or updated, and if the resource matches the given criteria, it sends a message on the defined \"channel\" so that another system can take an appropriate action.",
            "alias": [
              "WebHook",
              "Hook",
              "Routing Rule"
            ],
            "min": 0,
            "max": "*"
          },
          {
            "id": "Subscription.status",
            "path": "Subscription.status",
            "short": "requested | active | error | off",
            "definition": "The status of the subscription, which marks the server state for managing the subscription.",
            "comment": "A client can only submit subscription resources in the requested or off state. Only the server can  move a subscription from requested to active, and then to error. Either the server or the client can turn a subscription off.\n\nThis element is labeled as a modifier because the status contains codes that mark the resource as not currently valid.",
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
                  "valueString": "SubscriptionStatus"
                }
              ],
              "strength": "required",
              "description": "The status of a subscription.",
              "valueSet": "http://hl7.org/fhir/ValueSet/subscription-status|4.0.0"
            }
          },
          {
            "id": "Subscription.contact",
            "path": "Subscription.contact",
            "short": "Contact details for source (e.g. troubleshooting)",
            "definition": "Contact details for a human to contact about the subscription. The primary use of this for system administrator troubleshooting.",
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
            "id": "Subscription.end",
            "path": "Subscription.end",
            "short": "When to automatically delete the subscription",
            "definition": "The time for the server to turn the subscription off.",
            "comment": "The server is permitted to deviate from this time but should observe it.",
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
            "id": "Subscription.reason",
            "path": "Subscription.reason",
            "short": "Description of why this subscription was created",
            "definition": "A description of why this subscription is defined.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Subscription.criteria",
            "path": "Subscription.criteria",
            "short": "Rule for server push",
            "definition": "The rules that the server should use to determine when to generate notifications for this subscription.",
            "comment": "The rules are search criteria (without the [base] part). Like Bundle.entry.request.url, it has no leading \"/\".",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Subscription.error",
            "path": "Subscription.error",
            "short": "Latest error note",
            "definition": "A record of the last error that occurred when the server processed a notification.",
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
            "id": "Subscription.channel",
            "path": "Subscription.channel",
            "short": "The channel on which to report matches to the criteria",
            "definition": "Details where to send notifications when resources are received that meet the criteria.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Subscription.channel.type",
            "path": "Subscription.channel.type",
            "short": "rest-hook | websocket | email | sms | message",
            "definition": "The type of channel to send notifications on.",
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
                  "valueString": "SubscriptionChannelType"
                }
              ],
              "strength": "required",
              "description": "The type of method used to execute a subscription.",
              "valueSet": "http://hl7.org/fhir/ValueSet/subscription-channel-type|4.0.0"
            }
          },
          {
            "id": "Subscription.channel.endpoint",
            "path": "Subscription.channel.endpoint",
            "short": "Where the channel points to",
            "definition": "The url that describes the actual end-point to send messages to.",
            "comment": "For rest-hook, and websocket, the end-point must be an http: or https: URL; for email, a mailto: url, for sms, a tel: url, and for message the endpoint can be in any form of url the server understands (usually, http: or mllp:). The URI is allowed to be relative; in which case, it is relative to the server end-point (since there may be more than one, clients should avoid using relative URIs).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "url"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Subscription.channel.payload",
            "path": "Subscription.channel.payload",
            "short": "MIME type to send, or omit for no payload",
            "definition": "The mime type to send the payload in - either application/fhir+xml, or application/fhir+json. If the payload is not present, then there is no payload in the notification, just a notification. The mime type \"text/plain\" may also be used for Email and SMS subscriptions.",
            "comment": "Sending the payload has obvious security implications. The server is responsible for ensuring that the content is appropriately secured.",
            "min": 0,
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
            "id": "Subscription.channel.header",
            "path": "Subscription.channel.header",
            "short": "Usage depends on the channel type",
            "definition": "Additional headers / information to send as part of the notification.",
            "comment": "Exactly what these mean depend on the channel type. They can convey additional information to the recipient and/or meet security requirements; for example, support of multiple headers in the outgoing notifications for rest-hook type subscriptions.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": true
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:463
    /// <summary>
    /// Fhir resource 'Subscription'
    /// </summary>
    // 0. Subscription
    public class Subscription : FhirKhit.Maker.Common.Resource.ResourceBase                                                                 // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class Subscription_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                    // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 7. Subscription.channel
            public class Type_Channel : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Channel_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                            // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 8. Subscription.channel.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:236
                    // 9. Subscription.channel.endpoint
                    public ElementDefinitionInfo Endpoint;                                                                                  // MakerGen.cs:236
                    // 10. Subscription.channel.payload
                    public ElementDefinitionInfo Payload;                                                                                   // MakerGen.cs:236
                    // 11. Subscription.channel.header
                    public ElementDefinitionInfo Header;                                                                                    // MakerGen.cs:236
                    public Type_Channel_Elements()                                                                                          // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 8. Subscription.channel.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Type",                                                                                              // MakerGen.cs:255
                                Path= "Subscription.channel.type",                                                                          // MakerGen.cs:256
                                Id = "Subscription.channel.type",                                                                           // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 9. Subscription.channel.endpoint
                            this.Endpoint = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Endpoint",                                                                                          // MakerGen.cs:255
                                Path= "Subscription.channel.endpoint",                                                                      // MakerGen.cs:256
                                Id = "Subscription.channel.endpoint",                                                                       // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Url                                                                 // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 10. Subscription.channel.payload
                            this.Payload = new ElementDefinitionInfo                                                                        // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Payload",                                                                                           // MakerGen.cs:255
                                Path= "Subscription.channel.payload",                                                                       // MakerGen.cs:256
                                Id = "Subscription.channel.payload",                                                                        // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 11. Subscription.channel.header
                            this.Header = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Header",                                                                                            // MakerGen.cs:255
                                Path= "Subscription.channel.header",                                                                        // MakerGen.cs:256
                                Id = "Subscription.channel.header",                                                                         // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:240
                        Endpoint.Write(sDef);                                                                                               // MakerGen.cs:240
                        Payload.Write(sDef);                                                                                                // MakerGen.cs:240
                        Header.Write(sDef);                                                                                                 // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Channel_Elements Elements { get; }                                                                              // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Channel()                                                                                                       // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Channel_Elements();                                                                            // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 1. Subscription.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:236
            // 2. Subscription.contact
            public ElementDefinitionInfo Contact;                                                                                           // MakerGen.cs:236
            // 3. Subscription.end
            public ElementDefinitionInfo End;                                                                                               // MakerGen.cs:236
            // 4. Subscription.reason
            public ElementDefinitionInfo Reason;                                                                                            // MakerGen.cs:236
            // 5. Subscription.criteria
            public ElementDefinitionInfo Criteria;                                                                                          // MakerGen.cs:236
            // 6. Subscription.error
            public ElementDefinitionInfo Error;                                                                                             // MakerGen.cs:236
            public Subscription_Elements()                                                                                                  // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:251
                    // 1. Subscription.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Status",                                                                                                    // MakerGen.cs:255
                        Path= "Subscription.status",                                                                                        // MakerGen.cs:256
                        Id = "Subscription.status",                                                                                         // MakerGen.cs:257
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
                    // 2. Subscription.contact
                    this.Contact = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Contact",                                                                                                   // MakerGen.cs:255
                        Path= "Subscription.contact",                                                                                       // MakerGen.cs:256
                        Id = "Subscription.contact",                                                                                        // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.ContactPoint                                                                  // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 3. Subscription.end
                    this.End = new ElementDefinitionInfo                                                                                    // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "End",                                                                                                       // MakerGen.cs:255
                        Path= "Subscription.end",                                                                                           // MakerGen.cs:256
                        Id = "Subscription.end",                                                                                            // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Instant                                                                     // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 4. Subscription.reason
                    this.Reason = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Reason",                                                                                                    // MakerGen.cs:255
                        Path= "Subscription.reason",                                                                                        // MakerGen.cs:256
                        Id = "Subscription.reason",                                                                                         // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 5. Subscription.criteria
                    this.Criteria = new ElementDefinitionInfo                                                                               // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Criteria",                                                                                                  // MakerGen.cs:255
                        Path= "Subscription.criteria",                                                                                      // MakerGen.cs:256
                        Id = "Subscription.criteria",                                                                                       // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 6. Subscription.error
                    this.Error = new ElementDefinitionInfo                                                                                  // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Error",                                                                                                     // MakerGen.cs:255
                        Path= "Subscription.error",                                                                                         // MakerGen.cs:256
                        Id = "Subscription.error",                                                                                          // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:429
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:414
            {                                                                                                                               // MakerGen.cs:415
                base.Write(sDef);                                                                                                           // MakerGen.cs:416
                Status.Write(sDef);                                                                                                         // MakerGen.cs:240
                Contact.Write(sDef);                                                                                                        // MakerGen.cs:240
                End.Write(sDef);                                                                                                            // MakerGen.cs:240
                Reason.Write(sDef);                                                                                                         // MakerGen.cs:240
                Criteria.Write(sDef);                                                                                                       // MakerGen.cs:240
                Error.Write(sDef);                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public Subscription_Elements Elements { get; }                                                                                      // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public Subscription()                                                                                                               // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new Subscription_Elements();                                                                                    // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:468
