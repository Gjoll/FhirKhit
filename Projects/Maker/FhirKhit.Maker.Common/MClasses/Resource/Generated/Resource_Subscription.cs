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
    #endregion
    /// <summary>
    /// Fhir resource 'Subscription'
    /// </summary>
    // 0. Subscription
    public partial class Resource_Subscription : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 7. Subscription.channel
        public partial class Type_Channel : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 8. Subscription.channel.type
            public ElementDefinitionInfo Element_Type;
            // 9. Subscription.channel.endpoint
            public ElementDefinitionInfo Element_Endpoint;
            // 10. Subscription.channel.payload
            public ElementDefinitionInfo Element_Payload;
            // 11. Subscription.channel.header
            public ElementDefinitionInfo Element_Header;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Subscription.channel",
                    ElementId = "Subscription.channel"
                });
                Element_Type.Write(sDef);
                Element_Endpoint.Write(sDef);
                Element_Payload.Write(sDef);
                Element_Header.Write(sDef);
            }
            
            public Type_Channel()
            {
                {
                    // 8. Subscription.channel.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "Subscription.channel.type",
                        Id = "Subscription.channel.type",
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
                    // 9. Subscription.channel.endpoint
                    this.Element_Endpoint = new ElementDefinitionInfo
                    {
                        Name = "Element_Endpoint",
                        Path= "Subscription.channel.endpoint",
                        Id = "Subscription.channel.endpoint",
                        Min = 0,
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
                    // 10. Subscription.channel.payload
                    this.Element_Payload = new ElementDefinitionInfo
                    {
                        Name = "Element_Payload",
                        Path= "Subscription.channel.payload",
                        Id = "Subscription.channel.payload",
                        Min = 0,
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
                    // 11. Subscription.channel.header
                    this.Element_Header = new ElementDefinitionInfo
                    {
                        Name = "Element_Header",
                        Path= "Subscription.channel.header",
                        Id = "Subscription.channel.header",
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
            }
        }
        // 1. Subscription.status
        public ElementDefinitionInfo Element_Status;
        // 2. Subscription.contact
        public ElementDefinitionInfo Element_Contact;
        // 3. Subscription.end
        public ElementDefinitionInfo Element_End;
        // 4. Subscription.reason
        public ElementDefinitionInfo Element_Reason;
        // 5. Subscription.criteria
        public ElementDefinitionInfo Element_Criteria;
        // 6. Subscription.error
        public ElementDefinitionInfo Element_Error;
        // 7. Subscription.channel
        public ElementDefinitionInfo Element_Channel;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "Subscription",
                ElementId = "Subscription"
            });
            Element_Status.Write(sDef);
            Element_Contact.Write(sDef);
            Element_End.Write(sDef);
            Element_Reason.Write(sDef);
            Element_Criteria.Write(sDef);
            Element_Error.Write(sDef);
            Element_Channel.Write(sDef);
        }
        
        public Resource_Subscription()
        {
            {
                // 1. Subscription.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "Subscription.status",
                    Id = "Subscription.status",
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
                // 2. Subscription.contact
                this.Element_Contact = new ElementDefinitionInfo
                {
                    Name = "Element_Contact",
                    Path= "Subscription.contact",
                    Id = "Subscription.contact",
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
                // 3. Subscription.end
                this.Element_End = new ElementDefinitionInfo
                {
                    Name = "Element_End",
                    Path= "Subscription.end",
                    Id = "Subscription.end",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Instant
                        {
                        }
                    }
                };
            }
            {
                // 4. Subscription.reason
                this.Element_Reason = new ElementDefinitionInfo
                {
                    Name = "Element_Reason",
                    Path= "Subscription.reason",
                    Id = "Subscription.reason",
                    Min = 1,
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
                // 5. Subscription.criteria
                this.Element_Criteria = new ElementDefinitionInfo
                {
                    Name = "Element_Criteria",
                    Path= "Subscription.criteria",
                    Id = "Subscription.criteria",
                    Min = 1,
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
                // 6. Subscription.error
                this.Element_Error = new ElementDefinitionInfo
                {
                    Name = "Element_Error",
                    Path= "Subscription.error",
                    Id = "Subscription.error",
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
                // 7. Subscription.channel
                this.Element_Channel = new ElementDefinitionInfo
                {
                    Name = "Element_Channel",
                    Path= "Subscription.channel",
                    Id = "Subscription.channel",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new Type_Channel
                        {
                        }
                    }
                };
            }
            this.Name = "Subscription";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Subscription";
        }
    }
}
