using System;                                                                                                                               // MakerGen.cs:449
using System.Diagnostics;                                                                                                                   // MakerGen.cs:450
using System.IO;                                                                                                                            // MakerGen.cs:451
using System.Linq;                                                                                                                          // MakerGen.cs:452
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:453
                                                                                                                                            // MakerGen.cs:454
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:455
{                                                                                                                                           // MakerGen.cs:456
    #region Json                                                                                                                            // MakerGen.cs:457
    #if NEVER                                                                                                                               // MakerGen.cs:458
    {
      "resourceType": "StructureDefinition",
      "id": "DocumentManifest",
      "url": "http://hl7.org/fhir/StructureDefinition/DocumentManifest",
      "version": "4.0.0",
      "name": "DocumentManifest",
      "status": "draft",
      "publisher": "Health Level Seven International (Structured Documents)",
      "description": "A collection of documents compiled for a purpose together with metadata that applies to the collection.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "DocumentManifest",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "DocumentManifest",
            "path": "DocumentManifest",
            "short": "A list that defines a set of documents",
            "definition": "A collection of documents compiled for a purpose together with metadata that applies to the collection.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "DocumentManifest.masterIdentifier",
            "path": "DocumentManifest.masterIdentifier",
            "short": "Unique Identifier for the set of documents",
            "definition": "A single identifier that uniquely identifies this manifest. Principally used to refer to the manifest in non-FHIR contexts.",
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
            "id": "DocumentManifest.identifier",
            "path": "DocumentManifest.identifier",
            "short": "Other identifiers for the manifest",
            "definition": "Other identifiers associated with the document manifest, including version independent  identifiers.",
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
            "id": "DocumentManifest.status",
            "path": "DocumentManifest.status",
            "short": "current | superseded | entered-in-error",
            "definition": "The status of this document manifest.",
            "comment": "This element is labeled as a modifier because the status contains the codes that mark the manifest as not currently valid.",
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
                  "valueString": "DocumentReferenceStatus"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "required",
              "description": "The status of the document reference.",
              "valueSet": "http://hl7.org/fhir/ValueSet/document-reference-status|4.0.0"
            }
          },
          {
            "id": "DocumentManifest.type",
            "path": "DocumentManifest.type",
            "short": "Kind of document set",
            "definition": "The code specifying the type of clinical activity that resulted in placing the associated content into the DocumentManifest.",
            "comment": "Specifies the kind of this set of documents (e.g. Patient Summary, Discharge Summary, Prescription, etc.). The type of a set of documents may be the same as one of the documents in it - especially if there is only one - but it may be wider.",
            "min": 0,
            "max": "1",
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
                  "valueString": "v3Act"
                }
              ],
              "strength": "example",
              "description": "The activity that caused the DocumentManifest to be created.",
              "valueSet": "http://terminology.hl7.org/ValueSet/v3-ActCode"
            }
          },
          {
            "id": "DocumentManifest.subject",
            "path": "DocumentManifest.subject",
            "short": "The subject of the set of documents",
            "definition": "Who or what the set of documents is about. The documents can be about a person, (patient or healthcare practitioner), a device (i.e. machine) or even a group of subjects (such as a document about a herd of farm animals, or a set of patients that share a common exposure). If the documents cross more than one subject, then more than one subject is allowed here (unusual use case).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/Group",
                  "http://hl7.org/fhir/StructureDefinition/Device"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "DocumentManifest.created",
            "path": "DocumentManifest.created",
            "short": "When this document manifest created",
            "definition": "When the document manifest was created for submission to the server (not necessarily the same thing as the actual resource last modified time, since it may be modified, replicated, etc.).",
            "comment": "Creation time is used for tracking, organizing versions and searching. This is the creation time of the document set, not the documents on which it is based.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ]
          },
          {
            "id": "DocumentManifest.author",
            "path": "DocumentManifest.author",
            "short": "Who and/or what authored the DocumentManifest",
            "definition": "Identifies who is the author of the manifest. Manifest author is not necessarly the author of the references included.",
            "comment": "Not necessarily who did the actual data entry (i.e. typist) or who was the source (informant).",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Organization",
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "DocumentManifest.recipient",
            "path": "DocumentManifest.recipient",
            "short": "Intended to get notified about this set of documents",
            "definition": "A patient, practitioner, or organization for which this set of documents is intended.",
            "comment": "How the recipient receives the document set or is notified of it is up to the implementation. This element is just a statement of intent. If the recipient is a person, and it is not known whether the person is a patient or a practitioner, RelatedPerson would be the default choice.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ]
          },
          {
            "id": "DocumentManifest.source",
            "path": "DocumentManifest.source",
            "short": "The source system/application/software",
            "definition": "Identifies the source system, application, or software that produced the document manifest.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "uri"
              }
            ]
          },
          {
            "id": "DocumentManifest.description",
            "path": "DocumentManifest.description",
            "short": "Human-readable description (title)",
            "definition": "Human-readable description of the source document. This is sometimes known as the \"title\".",
            "comment": "What the document is about, rather than a terse summary of the document. It is commonly the case that records do not have a title and are collectively referred to by the display name of Record code (e.g. a \"consultation\" or \"progress note\").",
            "requirements": "Helps humans to assess whether the document is of interest.",
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
            "id": "DocumentManifest.content",
            "path": "DocumentManifest.content",
            "short": "Items in manifest",
            "definition": "The list of Resources that consist of the parts of this manifest.",
            "comment": "When used for XDS the intended focus of the DocumentManifest is for the reference to target to be a set of DocumentReference Resources. The reference is to \"Any\" to support EN 13606 usage, where an extract is DocumentManifest that references  List and Composition resources.",
            "requirements": "Any Resources are allowed to be grouped in a Manifest. The manifest brings context to the group.",
            "min": 1,
            "max": "*",
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
            "id": "DocumentManifest.related",
            "path": "DocumentManifest.related",
            "short": "Related things",
            "definition": "Related identifiers or resources associated with the DocumentManifest.",
            "comment": "May be identifiers or resources that caused the DocumentManifest to be created.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "DocumentManifest.related.identifier",
            "path": "DocumentManifest.related.identifier",
            "short": "Identifiers of things that are related",
            "definition": "Related identifier to this DocumentManifest.  For example, Order numbers, accession numbers, XDW workflow numbers.",
            "comment": "If both identifier and ref elements are present they shall refer to the same thing.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Identifier"
              }
            ]
          },
          {
            "id": "DocumentManifest.related.ref",
            "path": "DocumentManifest.related.ref",
            "short": "Related Resource",
            "definition": "Related Resource to this DocumentManifest. For example, Order, ServiceRequest,  Procedure, EligibilityRequest, etc.",
            "comment": "If both identifier and ref elements are present they shall refer to the same thing.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Resource"
                ]
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:461
    /// <summary>
    /// Fhir resource 'DocumentManifest'
    /// </summary>
    // 0. DocumentManifest
    public class DocumentManifest : FhirKhit.Maker.Common.Resource.ResourceBase                                                             // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        public class DocumentManifest_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                // MakerGen.cs:385
        {                                                                                                                                   // MakerGen.cs:386
            // 12. DocumentManifest.related
            public class Type_Related : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_Related_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                            // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 13. DocumentManifest.related.identifier
                    public ElementDefinitionInfo Identifier;                                                                                // MakerGen.cs:216
                    // 14. DocumentManifest.related.ref
                    public ElementDefinitionInfo Ref;                                                                                       // MakerGen.cs:216
                    public Type_Related_Elements()                                                                                          // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 13. DocumentManifest.related.identifier
                            this.Identifier = new ElementDefinitionInfo                                                                     // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Identifier",                                                                                        // MakerGen.cs:235
                                Path= "DocumentManifest.related.identifier",                                                                // MakerGen.cs:236
                                Id = "DocumentManifest.related.identifier",                                                                 // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Identifier                                                            // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 14. DocumentManifest.related.ref
                            this.Ref = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Ref",                                                                                               // MakerGen.cs:235
                                Path= "DocumentManifest.related.ref",                                                                       // MakerGen.cs:236
                                Id = "DocumentManifest.related.ref",                                                                        // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Resource"                                              // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        Identifier.Write(sDef);                                                                                             // MakerGen.cs:220
                        Ref.Write(sDef);                                                                                                    // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_Related_Elements Elements { get; }                                                                              // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_Related()                                                                                                       // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_Related_Elements();                                                                            // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 1. DocumentManifest.masterIdentifier
            public ElementDefinitionInfo MasterIdentifier;                                                                                  // MakerGen.cs:216
            // 2. DocumentManifest.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:216
            // 3. DocumentManifest.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:216
            // 4. DocumentManifest.type
            public ElementDefinitionInfo Type;                                                                                              // MakerGen.cs:216
            // 5. DocumentManifest.subject
            public ElementDefinitionInfo Subject;                                                                                           // MakerGen.cs:216
            // 6. DocumentManifest.created
            public ElementDefinitionInfo Created;                                                                                           // MakerGen.cs:216
            // 7. DocumentManifest.author
            public ElementDefinitionInfo Author;                                                                                            // MakerGen.cs:216
            // 8. DocumentManifest.recipient
            public ElementDefinitionInfo Recipient;                                                                                         // MakerGen.cs:216
            // 9. DocumentManifest.source
            public ElementDefinitionInfo Source;                                                                                            // MakerGen.cs:216
            // 10. DocumentManifest.description
            public ElementDefinitionInfo Description;                                                                                       // MakerGen.cs:216
            // 11. DocumentManifest.content
            public ElementDefinitionInfo Content;                                                                                           // MakerGen.cs:216
            // 12. DocumentManifest.related
            public ElementDefinitionInfo Related;                                                                                           // MakerGen.cs:216
            public DocumentManifest_Elements()                                                                                              // MakerGen.cs:407
            {                                                                                                                               // MakerGen.cs:408
                {                                                                                                                           // MakerGen.cs:231
                    // 1. DocumentManifest.masterIdentifier
                    this.MasterIdentifier = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "MasterIdentifier",                                                                                          // MakerGen.cs:235
                        Path= "DocumentManifest.masterIdentifier",                                                                          // MakerGen.cs:236
                        Id = "DocumentManifest.masterIdentifier",                                                                           // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 2. DocumentManifest.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Identifier",                                                                                                // MakerGen.cs:235
                        Path= "DocumentManifest.identifier",                                                                                // MakerGen.cs:236
                        Id = "DocumentManifest.identifier",                                                                                 // MakerGen.cs:237
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
                    // 3. DocumentManifest.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Status",                                                                                                    // MakerGen.cs:235
                        Path= "DocumentManifest.status",                                                                                    // MakerGen.cs:236
                        Id = "DocumentManifest.status",                                                                                     // MakerGen.cs:237
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
                    // 4. DocumentManifest.type
                    this.Type = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Type",                                                                                                      // MakerGen.cs:235
                        Path= "DocumentManifest.type",                                                                                      // MakerGen.cs:236
                        Id = "DocumentManifest.type",                                                                                       // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 5. DocumentManifest.subject
                    this.Subject = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Subject",                                                                                                   // MakerGen.cs:235
                        Path= "DocumentManifest.subject",                                                                                   // MakerGen.cs:236
                        Id = "DocumentManifest.subject",                                                                                    // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Group",                                                        // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Device"                                                        // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 6. DocumentManifest.created
                    this.Created = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Created",                                                                                                   // MakerGen.cs:235
                        Path= "DocumentManifest.created",                                                                                   // MakerGen.cs:236
                        Id = "DocumentManifest.created",                                                                                    // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 7. DocumentManifest.author
                    this.Author = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Author",                                                                                                    // MakerGen.cs:235
                        Path= "DocumentManifest.author",                                                                                    // MakerGen.cs:236
                        Id = "DocumentManifest.author",                                                                                     // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Organization",                                                 // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Device",                                                       // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson"                                                 // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 8. DocumentManifest.recipient
                    this.Recipient = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Recipient",                                                                                                 // MakerGen.cs:235
                        Path= "DocumentManifest.recipient",                                                                                 // MakerGen.cs:236
                        Id = "DocumentManifest.recipient",                                                                                  // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson",                                                // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 9. DocumentManifest.source
                    this.Source = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Source",                                                                                                    // MakerGen.cs:235
                        Path= "DocumentManifest.source",                                                                                    // MakerGen.cs:236
                        Id = "DocumentManifest.source",                                                                                     // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Uri                                                                         // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 10. DocumentManifest.description
                    this.Description = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Description",                                                                                               // MakerGen.cs:235
                        Path= "DocumentManifest.description",                                                                               // MakerGen.cs:236
                        Id = "DocumentManifest.description",                                                                                // MakerGen.cs:237
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
                    // 11. DocumentManifest.content
                    this.Content = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Content",                                                                                                   // MakerGen.cs:235
                        Path= "DocumentManifest.content",                                                                                   // MakerGen.cs:236
                        Id = "DocumentManifest.content",                                                                                    // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Resource"                                                      // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 12. DocumentManifest.related
                    this.Related = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Related",                                                                                                   // MakerGen.cs:235
                        Path= "DocumentManifest.related",                                                                                   // MakerGen.cs:236
                        Id = "DocumentManifest.related",                                                                                    // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Related                                                                                                // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:427
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:412
            {                                                                                                                               // MakerGen.cs:413
                base.Write(sDef);                                                                                                           // MakerGen.cs:414
                MasterIdentifier.Write(sDef);                                                                                               // MakerGen.cs:220
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:220
                Status.Write(sDef);                                                                                                         // MakerGen.cs:220
                Type.Write(sDef);                                                                                                           // MakerGen.cs:220
                Subject.Write(sDef);                                                                                                        // MakerGen.cs:220
                Created.Write(sDef);                                                                                                        // MakerGen.cs:220
                Author.Write(sDef);                                                                                                         // MakerGen.cs:220
                Recipient.Write(sDef);                                                                                                      // MakerGen.cs:220
                Source.Write(sDef);                                                                                                         // MakerGen.cs:220
                Description.Write(sDef);                                                                                                    // MakerGen.cs:220
                Content.Write(sDef);                                                                                                        // MakerGen.cs:220
                Related.Write(sDef);                                                                                                        // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:431
        }                                                                                                                                   // MakerGen.cs:391
        public DocumentManifest_Elements Elements { get; }                                                                                  // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
        public DocumentManifest()                                                                                                           // MakerGen.cs:394
        {                                                                                                                                   // MakerGen.cs:395
            this.Elements = new DocumentManifest_Elements();                                                                                // MakerGen.cs:396
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:399
        {                                                                                                                                   // MakerGen.cs:400
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:401
        }                                                                                                                                   // MakerGen.cs:402
    }                                                                                                                                       // MakerGen.cs:403
}                                                                                                                                           // MakerGen.cs:466
