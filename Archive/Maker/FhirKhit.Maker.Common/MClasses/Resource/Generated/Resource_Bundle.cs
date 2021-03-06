using System;                                                                                                                               // MakerGen.cs:432
using System.Diagnostics;                                                                                                                   // MakerGen.cs:433
using System.IO;                                                                                                                            // MakerGen.cs:434
using System.Linq;                                                                                                                          // MakerGen.cs:435
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:436
                                                                                                                                            // MakerGen.cs:437
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:438
{                                                                                                                                           // MakerGen.cs:439
    #region Json                                                                                                                            // MakerGen.cs:440
    #if NEVER                                                                                                                               // MakerGen.cs:441
    {
      "resourceType": "StructureDefinition",
      "id": "Bundle",
      "url": "http://hl7.org/fhir/StructureDefinition/Bundle",
      "version": "4.0.0",
      "name": "Bundle",
      "status": "active",
      "publisher": "Health Level Seven International (FHIR Infrastructure)",
      "description": "A container for a collection of resources.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "Bundle",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Resource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Bundle",
            "path": "Bundle",
            "short": "Contains a collection of resources",
            "definition": "A container for a collection of resources.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Bundle.identifier",
            "path": "Bundle.identifier",
            "short": "Persistent identifier for the bundle",
            "definition": "A persistent identifier for the bundle that won't change as a bundle is copied from server to server.",
            "comment": "Persistent identity generally only matters for batches of type Document, Message, and Collection. It would not normally be populated for search and history results and servers ignore Bundle.identifier when processing batches and transactions. For Documents  the .identifier SHALL be populated such that the .identifier is globally unique.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Identifier"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Bundle.type",
            "path": "Bundle.type",
            "short": "document | message | transaction | transaction-response | batch | batch-response | history | searchset | collection",
            "definition": "Indicates the purpose of this bundle - how it is intended to be used.",
            "comment": "It's possible to use a bundle for other purposes (e.g. a document can be accepted as a transaction). This is primarily defined so that there can be specific rules for some of the bundle types.",
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
                  "valueString": "BundleType"
                }
              ],
              "strength": "required",
              "description": "Indicates the purpose of a bundle - how it is intended to be used.",
              "valueSet": "http://hl7.org/fhir/ValueSet/bundle-type|4.0.0"
            }
          },
          {
            "id": "Bundle.timestamp",
            "path": "Bundle.timestamp",
            "short": "When the bundle was assembled",
            "definition": "The date/time that the bundle was assembled - i.e. when the resources were placed in the bundle.",
            "comment": "For many bundles, the timestamp is equal to .meta.lastUpdated, because they are not stored (e.g. search results). When a bundle is placed in a persistent store, .meta.lastUpdated will be usually be changed by the server. When the bundle is a message, a middleware agent altering the message (even if not stored) SHOULD update .meta.lastUpdated. .timestamp is used to track the original time of the Bundle, and SHOULD be populated.  \n\nUsage:\n\n* document : the date the document was created. Note: the composition may predate the document, or be associated with multiple documents. The date of the composition - the authoring time - may be earlier than the document assembly time\n* message : the date that the content of the message was assembled. This date is not changed by middleware engines unless they add additional data that changes the meaning of the time of the message\n* history : the date that the history was assembled. This time would be used as the _since time to ask for subsequent updates\n* searchset : the time that the search set was assembled. Note that different pages MAY have different timestamps but need not. Having different timestamps does not imply that subsequent pages will represent or include changes made since the initial query\n* transaction | transaction-response | batch | batch-response | collection : no particular assigned meaning\n\nThe timestamp value should be greater than the lastUpdated and other timestamps in the resources in the bundle, and it should be equal or earlier than the .meta.lastUpdated on the Bundle itself.",
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
            "id": "Bundle.total",
            "path": "Bundle.total",
            "short": "If search, the total number of matches",
            "definition": "If a set of search matches, this is the total number of entries of type 'match' across all pages in the search.  It does not include search.mode = 'include' or 'outcome' entries and it does not provide a count of the number of entries in the Bundle.",
            "comment": "Only used if the bundle is a search result set. The total does not include resources such as OperationOutcome and included resources, only the total number of matching resources.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "unsignedInt"
              }
            ],
            "condition": [
              "bdl-1"
            ],
            "isSummary": true
          },
          {
            "id": "Bundle.link",
            "path": "Bundle.link",
            "short": "Links related to this Bundle",
            "definition": "A series of links that provide context to this bundle.",
            "comment": "Both Bundle.link and Bundle.entry.link are defined to support providing additional context when Bundles are used (e.g. [HATEOAS](http://en.wikipedia.org/wiki/HATEOAS)). \n\nBundle.entry.link corresponds to links found in the HTTP header if the resource in the entry was [read](http.html#read) directly.\n\nThis specification defines some specific uses of Bundle.link for [searching](search.html#conformance) and [paging](http.html#paging), but no specific uses for Bundle.entry.link, and no defined function in a transaction - the meaning is implementation specific.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Bundle.link.relation",
            "path": "Bundle.link.relation",
            "short": "See http://www.iana.org/assignments/link-relations/link-relations.xhtml#link-relations-1",
            "definition": "A name which details the functional use for this link - see [http://www.iana.org/assignments/link-relations/link-relations.xhtml#link-relations-1](http://www.iana.org/assignments/link-relations/link-relations.xhtml#link-relations-1).",
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
            "id": "Bundle.link.url",
            "path": "Bundle.link.url",
            "short": "Reference details for the link",
            "definition": "The reference details for the link.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "uri"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Bundle.entry",
            "path": "Bundle.entry",
            "short": "Entry in the bundle - will have a resource or information",
            "definition": "An entry in a bundle resource - will either contain a resource or information about a resource (transactions and history only).",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "orderMeaning": "For bundles of type 'document' and 'message', the first resource is special (must be Composition or MessageHeader respectively). For all bundles, the meaning of the order of entries depends on the bundle type",
            "isSummary": true
          },
          {
            "id": "Bundle.entry.link",
            "path": "Bundle.entry.link",
            "short": "Links related to this entry",
            "definition": "A series of links that provide context to this entry.",
            "min": 0,
            "max": "*",
            "contentReference": "#Bundle.link",
            "isSummary": true
          },
          {
            "id": "Bundle.entry.fullUrl",
            "path": "Bundle.entry.fullUrl",
            "short": "URI for resource (Absolute URL server address or URI for UUID/OID)",
            "definition": "The Absolute URL for the resource.  The fullUrl SHALL NOT disagree with the id in the resource - i.e. if the fullUrl is not a urn:uuid, the URL shall be version-independent URL consistent with the Resource.id. The fullUrl is a version independent reference to the resource. The fullUrl element SHALL have a value except that: \n* fullUrl can be empty on a POST (although it does not need to when specifying a temporary id for reference in the bundle)\n* Results from operations might involve resources that are not identified.",
            "comment": "fullUrl might not be [unique in the context of a resource](bundle.html#bundle-unique). Note that since [FHIR resources do not need to be served through the FHIR API](references.html), the fullURL might be a URN or an absolute URL that does not end with the logical id of the resource (Resource.id). However, but if the fullUrl does look like a RESTful server URL (e.g. meets the [regex](references.html#regex), then the 'id' portion of the fullUrl SHALL end with the Resource.id.\n\nNote that the fullUrl is not the same as the canonical URL - it's an absolute url for an endpoint serving the resource (these will happen to have the same value on the canonical server for the resource with the canonical URL).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "uri"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Bundle.entry.resource",
            "path": "Bundle.entry.resource",
            "short": "A resource in the bundle",
            "definition": "The Resource for the entry. The purpose/meaning of the resource is determined by the Bundle.type.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Resource"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Bundle.entry.search",
            "path": "Bundle.entry.search",
            "short": "Search related information",
            "definition": "Information about the search process that lead to the creation of this entry.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "condition": [
              "bdl-2"
            ],
            "isSummary": true
          },
          {
            "id": "Bundle.entry.search.mode",
            "path": "Bundle.entry.search.mode",
            "short": "match | include | outcome - why this is in the result set",
            "definition": "Why this entry is in the result set - whether it's included as a match or because of an _include requirement, or to convey information or warning information about the search process.",
            "comment": "There is only one mode. In some corner cases, a resource may be included because it is both a match and an include. In these circumstances, 'match' takes precedence.",
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
                  "valueString": "SearchEntryMode"
                }
              ],
              "strength": "required",
              "description": "Why an entry is in the result set - whether it's included as a match or because of an _include requirement, or to convey information or warning information about the search process.",
              "valueSet": "http://hl7.org/fhir/ValueSet/search-entry-mode|4.0.0"
            }
          },
          {
            "id": "Bundle.entry.search.score",
            "path": "Bundle.entry.search.score",
            "short": "Search ranking (between 0 and 1)",
            "definition": "When searching, the server's search ranking score for the entry.",
            "comment": "Servers are not required to return a ranking score. 1 is most relevant, and 0 is least relevant. Often, search results are sorted by score, but the client may specify a different sort order.\n\nSee [Patient Match](patient-operation-match.html) for the EMPI search which relates to this element.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Bundle.entry.request",
            "path": "Bundle.entry.request",
            "short": "Additional execution information (transaction/batch/history)",
            "definition": "Additional information about how this entry should be processed as part of a transaction or batch.  For history, it shows how the entry was processed to create the version contained in the entry.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "condition": [
              "bdl-3"
            ],
            "isSummary": true
          },
          {
            "id": "Bundle.entry.request.method",
            "path": "Bundle.entry.request.method",
            "short": "GET | HEAD | POST | PUT | DELETE | PATCH",
            "definition": "In a transaction or batch, this is the HTTP action to be executed for this entry. In a history bundle, this indicates the HTTP action that occurred.",
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
                  "valueString": "HTTPVerb"
                }
              ],
              "strength": "required",
              "description": "HTTP verbs (in the HTTP command line). See [HTTP rfc](https://tools.ietf.org/html/rfc7231) for details.",
              "valueSet": "http://hl7.org/fhir/ValueSet/http-verb|4.0.0"
            }
          },
          {
            "id": "Bundle.entry.request.url",
            "path": "Bundle.entry.request.url",
            "short": "URL for HTTP equivalent of this entry",
            "definition": "The URL for this entry, relative to the root (the address to which the request is posted).",
            "comment": "E.g. for a Patient Create, the method would be \"POST\" and the URL would be \"Patient\". For a Patient Update, the method would be PUT and the URL would be \"Patient/[id]\".",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "uri"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Bundle.entry.request.ifNoneMatch",
            "path": "Bundle.entry.request.ifNoneMatch",
            "short": "For managing cache currency",
            "definition": "If the ETag values match, return a 304 Not Modified status. See the API documentation for [\"Conditional Read\"](http.html#cread).",
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
            "id": "Bundle.entry.request.ifModifiedSince",
            "path": "Bundle.entry.request.ifModifiedSince",
            "short": "For managing cache currency",
            "definition": "Only perform the operation if the last updated date matches. See the API documentation for [\"Conditional Read\"](http.html#cread).",
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
            "id": "Bundle.entry.request.ifMatch",
            "path": "Bundle.entry.request.ifMatch",
            "short": "For managing update contention",
            "definition": "Only perform the operation if the Etag value matches. For more information, see the API section [\"Managing Resource Contention\"](http.html#concurrency).",
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
            "id": "Bundle.entry.request.ifNoneExist",
            "path": "Bundle.entry.request.ifNoneExist",
            "short": "For conditional creates",
            "definition": "Instruct the server not to perform the create if a specified resource already exists. For further information, see the API documentation for [\"Conditional Create\"](http.html#ccreate). This is just the query portion of the URL - what follows the \"?\" (not including the \"?\").",
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
            "id": "Bundle.entry.response",
            "path": "Bundle.entry.response",
            "short": "Results of execution (transaction/batch/history)",
            "definition": "Indicates the results of processing the corresponding 'request' entry in the batch or transaction being responded to or what the results of an operation where when returning history.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "condition": [
              "bdl-4"
            ],
            "isSummary": true
          },
          {
            "id": "Bundle.entry.response.status",
            "path": "Bundle.entry.response.status",
            "short": "Status response code (text optional)",
            "definition": "The status code returned by processing this entry. The status SHALL start with a 3 digit HTTP code (e.g. 404) and may contain the standard HTTP description associated with the status code.",
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
            "id": "Bundle.entry.response.location",
            "path": "Bundle.entry.response.location",
            "short": "The location (if the operation returns a location)",
            "definition": "The location header created by processing this operation, populated if the operation returns a location.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "uri"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Bundle.entry.response.etag",
            "path": "Bundle.entry.response.etag",
            "short": "The Etag for the resource (if relevant)",
            "definition": "The Etag for the resource, if the operation for the entry produced a versioned resource (see [Resource Metadata and Versioning](http.html#versioning) and [Managing Resource Contention](http.html#concurrency)).",
            "comment": "Etags match the Resource.meta.versionId. The ETag has to match the version id in the header if a resource is included.",
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
            "id": "Bundle.entry.response.lastModified",
            "path": "Bundle.entry.response.lastModified",
            "short": "Server's date time modified",
            "definition": "The date/time that the resource was modified on the server.",
            "comment": "This has to match the same time in the meta header (meta.lastUpdated) if a resource is included.",
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
            "id": "Bundle.entry.response.outcome",
            "path": "Bundle.entry.response.outcome",
            "short": "OperationOutcome with hints and warnings (for batch/transaction)",
            "definition": "An OperationOutcome containing hints and warnings produced as part of processing this entry in a batch or transaction.",
            "comment": "For a POST/PUT operation, this is the equivalent outcome that would be returned for prefer = operationoutcome - except that the resource is always returned whether or not the outcome is returned.\n\nThis outcome is not used for error responses in batch/transaction, only for hints and warnings. In a batch operation, the error will be in Bundle.entry.response, and for transaction, there will be a single OperationOutcome instead of a bundle in the case of an error.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Resource"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Bundle.signature",
            "path": "Bundle.signature",
            "short": "Digital Signature",
            "definition": "Digital Signature - base64 encoded. XML-DSig or a JWT.",
            "comment": "The signature could be created by the \"author\" of the bundle or by the originating device.   Requirements around inclusion of a signature, verification of signatures and treatment of signed/non-signed bundles is implementation-environment specific.",
            "requirements": "A Signature holds an electronic representation of a signature and its supporting context in a FHIR accessible form. The signature may either be a cryptographic type (XML DigSig or a JWS), which is able to provide non-repudiation proof, or it may be a graphical image that represents a signature or a signature process. This element allows capturing signatures on documents, messages, transactions or even search responses, to support content-authentication, non-repudiation or other business cases. This is primarily relevant where the bundle may travel through multiple hops or via other mechanisms where HTTPS non-repudiation is insufficient.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Signature"
              }
            ],
            "isSummary": true
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:444
    /// <summary>
    /// Fhir resource 'Bundle'
    /// </summary>
    // 0. Bundle
    public partial class Resource_Bundle : FhirKhit.Maker.Common.Resource.Resource_Resource                                                 // MakerGen.cs:381
    {                                                                                                                                       // MakerGen.cs:382
        // 5. Bundle.link
        public partial class Type_Link : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 6. Bundle.link.relation
            public ElementDefinitionInfo Element_Relation;                                                                                  // MakerGen.cs:217
            // 7. Bundle.link.url
            public ElementDefinitionInfo Element_Url;                                                                                       // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:388
            {                                                                                                                               // MakerGen.cs:389
                base.Write(sDef);                                                                                                           // MakerGen.cs:390
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:391
                {                                                                                                                           // MakerGen.cs:392
                    Path = "Bundle.link",                                                                                                   // MakerGen.cs:393
                    ElementId = "Bundle.link"                                                                                               // MakerGen.cs:394
                });                                                                                                                         // MakerGen.cs:395
                Element_Relation.Write(sDef);                                                                                               // MakerGen.cs:221
                Element_Url.Write(sDef);                                                                                                    // MakerGen.cs:221
            }                                                                                                                               // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
            public Type_Link()                                                                                                              // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:232
                    // 6. Bundle.link.relation
                    this.Element_Relation = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Relation",                                                                                          // MakerGen.cs:236
                        Path= "Bundle.link.relation",                                                                                       // MakerGen.cs:237
                        Id = "Bundle.link.relation",                                                                                        // MakerGen.cs:238
                        Min = 1,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 7. Bundle.link.url
                    this.Element_Url = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Url",                                                                                               // MakerGen.cs:236
                        Path= "Bundle.link.url",                                                                                            // MakerGen.cs:237
                        Id = "Bundle.link.url",                                                                                             // MakerGen.cs:238
                        Min = 1,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_Uri                                                               // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
            }                                                                                                                               // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:405
        // 8. Bundle.entry
        public partial class Type_Entry : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 12. Bundle.entry.search
            public partial class Type_Search : FhirKhit.Maker.Common.Complex.ComplexBase                                                    // MakerGen.cs:381
            {                                                                                                                               // MakerGen.cs:382
                // 13. Bundle.entry.search.mode
                public ElementDefinitionInfo Element_Mode;                                                                                  // MakerGen.cs:217
                // 14. Bundle.entry.search.score
                public ElementDefinitionInfo Element_Score;                                                                                 // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:388
                {                                                                                                                           // MakerGen.cs:389
                    base.Write(sDef);                                                                                                       // MakerGen.cs:390
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:391
                    {                                                                                                                       // MakerGen.cs:392
                        Path = "Bundle.entry.search",                                                                                       // MakerGen.cs:393
                        ElementId = "Bundle.entry.search"                                                                                   // MakerGen.cs:394
                    });                                                                                                                     // MakerGen.cs:395
                    Element_Mode.Write(sDef);                                                                                               // MakerGen.cs:221
                    Element_Score.Write(sDef);                                                                                              // MakerGen.cs:221
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
                public Type_Search()                                                                                                        // MakerGen.cs:400
                {                                                                                                                           // MakerGen.cs:401
                    {                                                                                                                       // MakerGen.cs:232
                        // 13. Bundle.entry.search.mode
                        this.Element_Mode = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Mode",                                                                                          // MakerGen.cs:236
                            Path= "Bundle.entry.search.mode",                                                                               // MakerGen.cs:237
                            Id = "Bundle.entry.search.mode",                                                                                // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                          // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 14. Bundle.entry.search.score
                        this.Element_Score = new ElementDefinitionInfo                                                                      // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Score",                                                                                         // MakerGen.cs:236
                            Path= "Bundle.entry.search.score",                                                                              // MakerGen.cs:237
                            Id = "Bundle.entry.search.score",                                                                               // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_Decimal                                                       // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                }                                                                                                                           // MakerGen.cs:403
            }                                                                                                                               // MakerGen.cs:405
            // 15. Bundle.entry.request
            public partial class Type_Request : FhirKhit.Maker.Common.Complex.ComplexBase                                                   // MakerGen.cs:381
            {                                                                                                                               // MakerGen.cs:382
                // 16. Bundle.entry.request.method
                public ElementDefinitionInfo Element_Method;                                                                                // MakerGen.cs:217
                // 17. Bundle.entry.request.url
                public ElementDefinitionInfo Element_Url;                                                                                   // MakerGen.cs:217
                // 18. Bundle.entry.request.ifNoneMatch
                public ElementDefinitionInfo Element_IfNoneMatch;                                                                           // MakerGen.cs:217
                // 19. Bundle.entry.request.ifModifiedSince
                public ElementDefinitionInfo Element_IfModifiedSince;                                                                       // MakerGen.cs:217
                // 20. Bundle.entry.request.ifMatch
                public ElementDefinitionInfo Element_IfMatch;                                                                               // MakerGen.cs:217
                // 21. Bundle.entry.request.ifNoneExist
                public ElementDefinitionInfo Element_IfNoneExist;                                                                           // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:388
                {                                                                                                                           // MakerGen.cs:389
                    base.Write(sDef);                                                                                                       // MakerGen.cs:390
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:391
                    {                                                                                                                       // MakerGen.cs:392
                        Path = "Bundle.entry.request",                                                                                      // MakerGen.cs:393
                        ElementId = "Bundle.entry.request"                                                                                  // MakerGen.cs:394
                    });                                                                                                                     // MakerGen.cs:395
                    Element_Method.Write(sDef);                                                                                             // MakerGen.cs:221
                    Element_Url.Write(sDef);                                                                                                // MakerGen.cs:221
                    Element_IfNoneMatch.Write(sDef);                                                                                        // MakerGen.cs:221
                    Element_IfModifiedSince.Write(sDef);                                                                                    // MakerGen.cs:221
                    Element_IfMatch.Write(sDef);                                                                                            // MakerGen.cs:221
                    Element_IfNoneExist.Write(sDef);                                                                                        // MakerGen.cs:221
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
                public Type_Request()                                                                                                       // MakerGen.cs:400
                {                                                                                                                           // MakerGen.cs:401
                    {                                                                                                                       // MakerGen.cs:232
                        // 16. Bundle.entry.request.method
                        this.Element_Method = new ElementDefinitionInfo                                                                     // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Method",                                                                                        // MakerGen.cs:236
                            Path= "Bundle.entry.request.method",                                                                            // MakerGen.cs:237
                            Id = "Bundle.entry.request.method",                                                                             // MakerGen.cs:238
                            Min = 1,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                          // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 17. Bundle.entry.request.url
                        this.Element_Url = new ElementDefinitionInfo                                                                        // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Url",                                                                                           // MakerGen.cs:236
                            Path= "Bundle.entry.request.url",                                                                               // MakerGen.cs:237
                            Id = "Bundle.entry.request.url",                                                                                // MakerGen.cs:238
                            Min = 1,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_Uri                                                           // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 18. Bundle.entry.request.ifNoneMatch
                        this.Element_IfNoneMatch = new ElementDefinitionInfo                                                                // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_IfNoneMatch",                                                                                   // MakerGen.cs:236
                            Path= "Bundle.entry.request.ifNoneMatch",                                                                       // MakerGen.cs:237
                            Id = "Bundle.entry.request.ifNoneMatch",                                                                        // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_String                                                        // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 19. Bundle.entry.request.ifModifiedSince
                        this.Element_IfModifiedSince = new ElementDefinitionInfo                                                            // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_IfModifiedSince",                                                                               // MakerGen.cs:236
                            Path= "Bundle.entry.request.ifModifiedSince",                                                                   // MakerGen.cs:237
                            Id = "Bundle.entry.request.ifModifiedSince",                                                                    // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_Instant                                                       // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 20. Bundle.entry.request.ifMatch
                        this.Element_IfMatch = new ElementDefinitionInfo                                                                    // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_IfMatch",                                                                                       // MakerGen.cs:236
                            Path= "Bundle.entry.request.ifMatch",                                                                           // MakerGen.cs:237
                            Id = "Bundle.entry.request.ifMatch",                                                                            // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_String                                                        // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 21. Bundle.entry.request.ifNoneExist
                        this.Element_IfNoneExist = new ElementDefinitionInfo                                                                // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_IfNoneExist",                                                                                   // MakerGen.cs:236
                            Path= "Bundle.entry.request.ifNoneExist",                                                                       // MakerGen.cs:237
                            Id = "Bundle.entry.request.ifNoneExist",                                                                        // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_String                                                        // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                }                                                                                                                           // MakerGen.cs:403
            }                                                                                                                               // MakerGen.cs:405
            // 22. Bundle.entry.response
            public partial class Type_Response : FhirKhit.Maker.Common.Complex.ComplexBase                                                  // MakerGen.cs:381
            {                                                                                                                               // MakerGen.cs:382
                // 23. Bundle.entry.response.status
                public ElementDefinitionInfo Element_Status;                                                                                // MakerGen.cs:217
                // 24. Bundle.entry.response.location
                public ElementDefinitionInfo Element_Location;                                                                              // MakerGen.cs:217
                // 25. Bundle.entry.response.etag
                public ElementDefinitionInfo Element_Etag;                                                                                  // MakerGen.cs:217
                // 26. Bundle.entry.response.lastModified
                public ElementDefinitionInfo Element_LastModified;                                                                          // MakerGen.cs:217
                // 27. Bundle.entry.response.outcome
                public ElementDefinitionInfo Element_Outcome;                                                                               // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:388
                {                                                                                                                           // MakerGen.cs:389
                    base.Write(sDef);                                                                                                       // MakerGen.cs:390
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:391
                    {                                                                                                                       // MakerGen.cs:392
                        Path = "Bundle.entry.response",                                                                                     // MakerGen.cs:393
                        ElementId = "Bundle.entry.response"                                                                                 // MakerGen.cs:394
                    });                                                                                                                     // MakerGen.cs:395
                    Element_Status.Write(sDef);                                                                                             // MakerGen.cs:221
                    Element_Location.Write(sDef);                                                                                           // MakerGen.cs:221
                    Element_Etag.Write(sDef);                                                                                               // MakerGen.cs:221
                    Element_LastModified.Write(sDef);                                                                                       // MakerGen.cs:221
                    Element_Outcome.Write(sDef);                                                                                            // MakerGen.cs:221
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
                public Type_Response()                                                                                                      // MakerGen.cs:400
                {                                                                                                                           // MakerGen.cs:401
                    {                                                                                                                       // MakerGen.cs:232
                        // 23. Bundle.entry.response.status
                        this.Element_Status = new ElementDefinitionInfo                                                                     // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Status",                                                                                        // MakerGen.cs:236
                            Path= "Bundle.entry.response.status",                                                                           // MakerGen.cs:237
                            Id = "Bundle.entry.response.status",                                                                            // MakerGen.cs:238
                            Min = 1,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_String                                                        // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 24. Bundle.entry.response.location
                        this.Element_Location = new ElementDefinitionInfo                                                                   // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Location",                                                                                      // MakerGen.cs:236
                            Path= "Bundle.entry.response.location",                                                                         // MakerGen.cs:237
                            Id = "Bundle.entry.response.location",                                                                          // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_Uri                                                           // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 25. Bundle.entry.response.etag
                        this.Element_Etag = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Etag",                                                                                          // MakerGen.cs:236
                            Path= "Bundle.entry.response.etag",                                                                             // MakerGen.cs:237
                            Id = "Bundle.entry.response.etag",                                                                              // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_String                                                        // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 26. Bundle.entry.response.lastModified
                        this.Element_LastModified = new ElementDefinitionInfo                                                               // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_LastModified",                                                                                  // MakerGen.cs:236
                            Path= "Bundle.entry.response.lastModified",                                                                     // MakerGen.cs:237
                            Id = "Bundle.entry.response.lastModified",                                                                      // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_Instant                                                       // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 27. Bundle.entry.response.outcome
                        this.Element_Outcome = new ElementDefinitionInfo                                                                    // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Outcome",                                                                                       // MakerGen.cs:236
                            Path= "Bundle.entry.response.outcome",                                                                          // MakerGen.cs:237
                            Id = "Bundle.entry.response.outcome",                                                                           // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Resource.Resource_Resource                                                        // MakerGen.cs:330
                                {                                                                                                           // MakerGen.cs:331
                                }                                                                                                           // MakerGen.cs:334
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                }                                                                                                                           // MakerGen.cs:403
            }                                                                                                                               // MakerGen.cs:405
            // 9. Bundle.entry.link
            public ElementDefinitionInfo Element_Link;                                                                                      // MakerGen.cs:217
            // 10. Bundle.entry.fullUrl
            public ElementDefinitionInfo Element_FullUrl;                                                                                   // MakerGen.cs:217
            // 11. Bundle.entry.resource
            public ElementDefinitionInfo Element_Resource;                                                                                  // MakerGen.cs:217
            // 12. Bundle.entry.search
            public ElementDefinitionInfo Element_Search;                                                                                    // MakerGen.cs:217
            // 15. Bundle.entry.request
            public ElementDefinitionInfo Element_Request;                                                                                   // MakerGen.cs:217
            // 22. Bundle.entry.response
            public ElementDefinitionInfo Element_Response;                                                                                  // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:388
            {                                                                                                                               // MakerGen.cs:389
                base.Write(sDef);                                                                                                           // MakerGen.cs:390
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:391
                {                                                                                                                           // MakerGen.cs:392
                    Path = "Bundle.entry",                                                                                                  // MakerGen.cs:393
                    ElementId = "Bundle.entry"                                                                                              // MakerGen.cs:394
                });                                                                                                                         // MakerGen.cs:395
                Element_Link.Write(sDef);                                                                                                   // MakerGen.cs:221
                Element_FullUrl.Write(sDef);                                                                                                // MakerGen.cs:221
                Element_Resource.Write(sDef);                                                                                               // MakerGen.cs:221
                Element_Search.Write(sDef);                                                                                                 // MakerGen.cs:221
                Element_Request.Write(sDef);                                                                                                // MakerGen.cs:221
                Element_Response.Write(sDef);                                                                                               // MakerGen.cs:221
            }                                                                                                                               // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
            public Type_Entry()                                                                                                             // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:232
                    // 9. Bundle.entry.link
                    this.Element_Link = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Link",                                                                                              // MakerGen.cs:236
                        Path= "Bundle.entry.link",                                                                                          // MakerGen.cs:237
                        Id = "Bundle.entry.link",                                                                                           // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = -1,                                                                                                           // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 10. Bundle.entry.fullUrl
                    this.Element_FullUrl = new ElementDefinitionInfo                                                                        // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_FullUrl",                                                                                           // MakerGen.cs:236
                        Path= "Bundle.entry.fullUrl",                                                                                       // MakerGen.cs:237
                        Id = "Bundle.entry.fullUrl",                                                                                        // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_Uri                                                               // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 11. Bundle.entry.resource
                    this.Element_Resource = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Resource",                                                                                          // MakerGen.cs:236
                        Path= "Bundle.entry.resource",                                                                                      // MakerGen.cs:237
                        Id = "Bundle.entry.resource",                                                                                       // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Resource.Resource_Resource                                                            // MakerGen.cs:330
                            {                                                                                                               // MakerGen.cs:331
                            }                                                                                                               // MakerGen.cs:334
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 12. Bundle.entry.search
                    this.Element_Search = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Search",                                                                                            // MakerGen.cs:236
                        Path= "Bundle.entry.search",                                                                                        // MakerGen.cs:237
                        Id = "Bundle.entry.search",                                                                                         // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new Type_Search                                                                                                 // MakerGen.cs:260
                            {                                                                                                               // MakerGen.cs:261
                            }                                                                                                               // MakerGen.cs:262
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 15. Bundle.entry.request
                    this.Element_Request = new ElementDefinitionInfo                                                                        // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Request",                                                                                           // MakerGen.cs:236
                        Path= "Bundle.entry.request",                                                                                       // MakerGen.cs:237
                        Id = "Bundle.entry.request",                                                                                        // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new Type_Request                                                                                                // MakerGen.cs:260
                            {                                                                                                               // MakerGen.cs:261
                            }                                                                                                               // MakerGen.cs:262
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 22. Bundle.entry.response
                    this.Element_Response = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Response",                                                                                          // MakerGen.cs:236
                        Path= "Bundle.entry.response",                                                                                      // MakerGen.cs:237
                        Id = "Bundle.entry.response",                                                                                       // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new Type_Response                                                                                               // MakerGen.cs:260
                            {                                                                                                               // MakerGen.cs:261
                            }                                                                                                               // MakerGen.cs:262
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
            }                                                                                                                               // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:405
        // 1. Bundle.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:217
        // 2. Bundle.type
        public ElementDefinitionInfo Element_Type;                                                                                          // MakerGen.cs:217
        // 3. Bundle.timestamp
        public ElementDefinitionInfo Element_Timestamp;                                                                                     // MakerGen.cs:217
        // 4. Bundle.total
        public ElementDefinitionInfo Element_Total;                                                                                         // MakerGen.cs:217
        // 5. Bundle.link
        public ElementDefinitionInfo Element_Link;                                                                                          // MakerGen.cs:217
        // 8. Bundle.entry
        public ElementDefinitionInfo Element_Entry;                                                                                         // MakerGen.cs:217
        // 28. Bundle.signature
        public ElementDefinitionInfo Element_Signature;                                                                                     // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:388
        {                                                                                                                                   // MakerGen.cs:389
            base.Write(sDef);                                                                                                               // MakerGen.cs:390
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:391
            {                                                                                                                               // MakerGen.cs:392
                Path = "Bundle",                                                                                                            // MakerGen.cs:393
                ElementId = "Bundle"                                                                                                        // MakerGen.cs:394
            });                                                                                                                             // MakerGen.cs:395
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:221
            Element_Type.Write(sDef);                                                                                                       // MakerGen.cs:221
            Element_Timestamp.Write(sDef);                                                                                                  // MakerGen.cs:221
            Element_Total.Write(sDef);                                                                                                      // MakerGen.cs:221
            Element_Link.Write(sDef);                                                                                                       // MakerGen.cs:221
            Element_Entry.Write(sDef);                                                                                                      // MakerGen.cs:221
            Element_Signature.Write(sDef);                                                                                                  // MakerGen.cs:221
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
        public Resource_Bundle()                                                                                                            // MakerGen.cs:400
        {                                                                                                                                   // MakerGen.cs:401
            {                                                                                                                               // MakerGen.cs:232
                // 1. Bundle.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:236
                    Path= "Bundle.identifier",                                                                                              // MakerGen.cs:237
                    Id = "Bundle.identifier",                                                                                               // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 2. Bundle.type
                this.Element_Type = new ElementDefinitionInfo                                                                               // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Type",                                                                                                  // MakerGen.cs:236
                    Path= "Bundle.type",                                                                                                    // MakerGen.cs:237
                    Id = "Bundle.type",                                                                                                     // MakerGen.cs:238
                    Min = 1,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 3. Bundle.timestamp
                this.Element_Timestamp = new ElementDefinitionInfo                                                                          // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Timestamp",                                                                                             // MakerGen.cs:236
                    Path= "Bundle.timestamp",                                                                                               // MakerGen.cs:237
                    Id = "Bundle.timestamp",                                                                                                // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Instant                                                               // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 4. Bundle.total
                this.Element_Total = new ElementDefinitionInfo                                                                              // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Total",                                                                                                 // MakerGen.cs:236
                    Path= "Bundle.total",                                                                                                   // MakerGen.cs:237
                    Id = "Bundle.total",                                                                                                    // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_UnsignedInt                                                           // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 5. Bundle.link
                this.Element_Link = new ElementDefinitionInfo                                                                               // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Link",                                                                                                  // MakerGen.cs:236
                    Path= "Bundle.link",                                                                                                    // MakerGen.cs:237
                    Id = "Bundle.link",                                                                                                     // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new Type_Link                                                                                                       // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:262
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 8. Bundle.entry
                this.Element_Entry = new ElementDefinitionInfo                                                                              // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Entry",                                                                                                 // MakerGen.cs:236
                    Path= "Bundle.entry",                                                                                                   // MakerGen.cs:237
                    Id = "Bundle.entry",                                                                                                    // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new Type_Entry                                                                                                      // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:262
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 28. Bundle.signature
                this.Element_Signature = new ElementDefinitionInfo                                                                          // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Signature",                                                                                             // MakerGen.cs:236
                    Path= "Bundle.signature",                                                                                               // MakerGen.cs:237
                    Id = "Bundle.signature",                                                                                                // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Signature                                                                    // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            this.Name = "Bundle";                                                                                                           // MakerGen.cs:468
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Bundle";                                                                    // MakerGen.cs:469
        }                                                                                                                                   // MakerGen.cs:403
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:449
