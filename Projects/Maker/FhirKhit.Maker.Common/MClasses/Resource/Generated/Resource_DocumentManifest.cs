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
    #endregion
    /// <summary>
    /// Fhir resource 'DocumentManifest'
    /// </summary>
    // 0. DocumentManifest
    public class Resource_DocumentManifest : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 12. DocumentManifest.related
        public class Type_Related : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 13. DocumentManifest.related.identifier
            public ElementDefinitionInfo Element_Identifier;
            // 14. DocumentManifest.related.ref
            public ElementDefinitionInfo Element_Ref;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "DocumentManifest.related",
                    ElementId = "DocumentManifest.related"
                });
                Element_Identifier.Write(sDef);
                Element_Ref.Write(sDef);
            }
            
            public Type_Related()
            {
                {
                    // 13. DocumentManifest.related.identifier
                    this.Element_Identifier = new ElementDefinitionInfo
                    {
                        Name = "Element_Identifier",
                        Path= "DocumentManifest.related.identifier",
                        Id = "DocumentManifest.related.identifier",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Identifier
                            {
                            }
                        }
                    };
                }
                {
                    // 14. DocumentManifest.related.ref
                    this.Element_Ref = new ElementDefinitionInfo
                    {
                        Name = "Element_Ref",
                        Path= "DocumentManifest.related.ref",
                        Id = "DocumentManifest.related.ref",
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
            }
        }
        // 1. DocumentManifest.masterIdentifier
        public ElementDefinitionInfo Element_MasterIdentifier;
        // 2. DocumentManifest.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 3. DocumentManifest.status
        public ElementDefinitionInfo Element_Status;
        // 4. DocumentManifest.type
        public ElementDefinitionInfo Element_Type;
        // 5. DocumentManifest.subject
        public ElementDefinitionInfo Element_Subject;
        // 6. DocumentManifest.created
        public ElementDefinitionInfo Element_Created;
        // 7. DocumentManifest.author
        public ElementDefinitionInfo Element_Author;
        // 8. DocumentManifest.recipient
        public ElementDefinitionInfo Element_Recipient;
        // 9. DocumentManifest.source
        public ElementDefinitionInfo Element_Source;
        // 10. DocumentManifest.description
        public ElementDefinitionInfo Element_Description;
        // 11. DocumentManifest.content
        public ElementDefinitionInfo Element_Content;
        // 12. DocumentManifest.related
        public ElementDefinitionInfo Element_Related;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "DocumentManifest",
                ElementId = "DocumentManifest"
            });
            Element_MasterIdentifier.Write(sDef);
            Element_Identifier.Write(sDef);
            Element_Status.Write(sDef);
            Element_Type.Write(sDef);
            Element_Subject.Write(sDef);
            Element_Created.Write(sDef);
            Element_Author.Write(sDef);
            Element_Recipient.Write(sDef);
            Element_Source.Write(sDef);
            Element_Description.Write(sDef);
            Element_Content.Write(sDef);
            Element_Related.Write(sDef);
        }
        
        public Resource_DocumentManifest()
        {
            {
                // 1. DocumentManifest.masterIdentifier
                this.Element_MasterIdentifier = new ElementDefinitionInfo
                {
                    Name = "Element_MasterIdentifier",
                    Path= "DocumentManifest.masterIdentifier",
                    Id = "DocumentManifest.masterIdentifier",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Identifier
                        {
                        }
                    }
                };
            }
            {
                // 2. DocumentManifest.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "DocumentManifest.identifier",
                    Id = "DocumentManifest.identifier",
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
                // 3. DocumentManifest.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "DocumentManifest.status",
                    Id = "DocumentManifest.status",
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
                // 4. DocumentManifest.type
                this.Element_Type = new ElementDefinitionInfo
                {
                    Name = "Element_Type",
                    Path= "DocumentManifest.type",
                    Id = "DocumentManifest.type",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                        {
                        }
                    }
                };
            }
            {
                // 5. DocumentManifest.subject
                this.Element_Subject = new ElementDefinitionInfo
                {
                    Name = "Element_Subject",
                    Path= "DocumentManifest.subject",
                    Id = "DocumentManifest.subject",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Patient",
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                "http://hl7.org/fhir/StructureDefinition/Group",
                                "http://hl7.org/fhir/StructureDefinition/Device"
                            }
                        }
                    }
                };
            }
            {
                // 6. DocumentManifest.created
                this.Element_Created = new ElementDefinitionInfo
                {
                    Name = "Element_Created",
                    Path= "DocumentManifest.created",
                    Id = "DocumentManifest.created",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                        {
                        }
                    }
                };
            }
            {
                // 7. DocumentManifest.author
                this.Element_Author = new ElementDefinitionInfo
                {
                    Name = "Element_Author",
                    Path= "DocumentManifest.author",
                    Id = "DocumentManifest.author",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                                "http://hl7.org/fhir/StructureDefinition/Organization",
                                "http://hl7.org/fhir/StructureDefinition/Device",
                                "http://hl7.org/fhir/StructureDefinition/Patient",
                                "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                            }
                        }
                    }
                };
            }
            {
                // 8. DocumentManifest.recipient
                this.Element_Recipient = new ElementDefinitionInfo
                {
                    Name = "Element_Recipient",
                    Path= "DocumentManifest.recipient",
                    Id = "DocumentManifest.recipient",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Patient",
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                                "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                                "http://hl7.org/fhir/StructureDefinition/Organization"
                            }
                        }
                    }
                };
            }
            {
                // 9. DocumentManifest.source
                this.Element_Source = new ElementDefinitionInfo
                {
                    Name = "Element_Source",
                    Path= "DocumentManifest.source",
                    Id = "DocumentManifest.source",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Uri
                        {
                        }
                    }
                };
            }
            {
                // 10. DocumentManifest.description
                this.Element_Description = new ElementDefinitionInfo
                {
                    Name = "Element_Description",
                    Path= "DocumentManifest.description",
                    Id = "DocumentManifest.description",
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
                // 11. DocumentManifest.content
                this.Element_Content = new ElementDefinitionInfo
                {
                    Name = "Element_Content",
                    Path= "DocumentManifest.content",
                    Id = "DocumentManifest.content",
                    Min = 1,
                    Max = -1,
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
                // 12. DocumentManifest.related
                this.Element_Related = new ElementDefinitionInfo
                {
                    Name = "Element_Related",
                    Path= "DocumentManifest.related",
                    Id = "DocumentManifest.related",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Related
                        {
                        }
                    }
                };
            }
            this.Name = "DocumentManifest";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/DocumentManifest";
        }
    }
}
