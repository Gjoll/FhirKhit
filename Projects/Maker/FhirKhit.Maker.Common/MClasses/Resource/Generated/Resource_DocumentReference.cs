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
      "id": "DocumentReference",
      "url": "http://hl7.org/fhir/StructureDefinition/DocumentReference",
      "version": "4.0.0",
      "name": "DocumentReference",
      "status": "draft",
      "publisher": "Health Level Seven International (Structured Documents)",
      "description": "A reference to a document of any kind for any purpose. Provides metadata about the document so that the document can be discovered and managed. The scope of a document is any seralized object with a mime-type, so includes formal patient centric documents (CDA), cliical notes, scanned paper, and non-patient specific documents like policy text.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "DocumentReference",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "DocumentReference",
            "path": "DocumentReference",
            "short": "A reference to a document",
            "definition": "A reference to a document of any kind for any purpose. Provides metadata about the document so that the document can be discovered and managed. The scope of a document is any seralized object with a mime-type, so includes formal patient centric documents (CDA), cliical notes, scanned paper, and non-patient specific documents like policy text.",
            "comment": "Usually, this is used for documents other than those defined by FHIR.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "DocumentReference.masterIdentifier",
            "path": "DocumentReference.masterIdentifier",
            "short": "Master Version Specific Identifier",
            "definition": "Document identifier as assigned by the source of the document. This identifier is specific to this version of the document. This unique identifier may be used elsewhere to identify this version of the document.",
            "comment": "CDA Document Id extension and root.",
            "requirements": "The structure and format of this Id shall be consistent with the specification corresponding to the formatCode attribute. (e.g. for a DICOM standard document a 64-character numeric UID, for an HL7 CDA format a serialization of the CDA Document Id extension and root in the form \"oid^extension\", where OID is a 64 digits max, and the Id is a 16 UTF-8 char max. If the OID is coded without the extension then the '^' character shall not be included.).",
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
            "id": "DocumentReference.identifier",
            "path": "DocumentReference.identifier",
            "short": "Other identifiers for the document",
            "definition": "Other identifiers associated with the document, including version independent identifiers.",
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
            "id": "DocumentReference.status",
            "path": "DocumentReference.status",
            "short": "current | superseded | entered-in-error",
            "definition": "The status of this document reference.",
            "comment": "This is the status of the DocumentReference object, which might be independent from the docStatus element.\n\nThis element is labeled as a modifier because the status contains the codes that mark the document or reference as not currently valid.",
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
            "id": "DocumentReference.docStatus",
            "path": "DocumentReference.docStatus",
            "short": "preliminary | final | appended | amended | entered-in-error",
            "definition": "The status of the underlying document.",
            "comment": "The document that is pointed to might be in various lifecycle states.",
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
                  "valueString": "ReferredDocumentStatus"
                }
              ],
              "strength": "required",
              "description": "Status of the underlying document.",
              "valueSet": "http://hl7.org/fhir/ValueSet/composition-status|4.0.0"
            }
          },
          {
            "id": "DocumentReference.type",
            "path": "DocumentReference.type",
            "short": "Kind of document (LOINC if possible)",
            "definition": "Specifies the particular kind of document referenced  (e.g. History and Physical, Discharge Summary, Progress Note). This usually equates to the purpose of making the document referenced.",
            "comment": "Key metadata element describing the document that describes he exact type of document. Helps humans to assess whether the document is of interest when viewing a list of documents.",
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
                  "valueString": "DocumentC80Type"
                }
              ],
              "strength": "preferred",
              "description": "Precise type of clinical document.",
              "valueSet": "http://hl7.org/fhir/ValueSet/c80-doc-typecodes"
            }
          },
          {
            "id": "DocumentReference.category",
            "path": "DocumentReference.category",
            "short": "Categorization of document",
            "definition": "A categorization for the type of document referenced - helps for indexing and searching. This may be implied by or derived from the code specified in the DocumentReference.type.",
            "comment": "Key metadata element describing the the category or classification of the document. This is a broader perspective that groups similar documents based on how they would be used. This is a primary key used in searching.",
            "alias": [
              "claxs"
            ],
            "min": 0,
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
                  "valueString": "DocumentC80Class"
                }
              ],
              "strength": "example",
              "description": "High-level kind of a clinical document at a macro level.",
              "valueSet": "http://hl7.org/fhir/ValueSet/document-classcodes"
            }
          },
          {
            "id": "DocumentReference.subject",
            "path": "DocumentReference.subject",
            "short": "Who/what is the subject of the document",
            "definition": "Who or what the document is about. The document can be about a person, (patient or healthcare practitioner), a device (e.g. a machine) or even a group of subjects (such as a document about a herd of farm animals, or a set of patients that share a common exposure).",
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
            "id": "DocumentReference.date",
            "path": "DocumentReference.date",
            "short": "When this document reference was created",
            "definition": "When the document reference was created.",
            "comment": "Referencing/indexing time is used for tracking, organizing versions and searching.",
            "alias": [
              "indexed"
            ],
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
            "id": "DocumentReference.author",
            "path": "DocumentReference.author",
            "short": "Who and/or what authored the document",
            "definition": "Identifies who is responsible for adding the information to the document.",
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
            "id": "DocumentReference.authenticator",
            "path": "DocumentReference.authenticator",
            "short": "Who/what authenticated the document",
            "definition": "Which person or organization authenticates that this document is valid.",
            "comment": "Represents a participant within the author institution who has legally authenticated or attested the document. Legal authentication implies that a document has been signed manually or electronically by the legal Authenticator.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ]
          },
          {
            "id": "DocumentReference.custodian",
            "path": "DocumentReference.custodian",
            "short": "Organization which maintains the document",
            "definition": "Identifies the organization or group who is responsible for ongoing maintenance of and access to the document.",
            "comment": "Identifies the logical organization (software system, vendor, or department) to go to find the current version, where to report issues, etc. This is different from the physical location (URL, disk drive, or server) of the document, which is the technical location of the document, which host may be delegated to the management of some other organization.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ]
          },
          {
            "id": "DocumentReference.relatesTo",
            "path": "DocumentReference.relatesTo",
            "short": "Relationships to other documents",
            "definition": "Relationships that this document has with other document references that already exist.",
            "comment": "This element is labeled as a modifier because documents that append to other documents are incomplete on their own.",
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
            "id": "DocumentReference.relatesTo.code",
            "path": "DocumentReference.relatesTo.code",
            "short": "replaces | transforms | signs | appends",
            "definition": "The type of relationship that this document has with anther document.",
            "comment": "If this document appends another document, then the document cannot be fully understood without also accessing the referenced document.",
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
                  "valueString": "DocumentRelationshipType"
                }
              ],
              "strength": "required",
              "description": "The type of relationship between documents.",
              "valueSet": "http://hl7.org/fhir/ValueSet/document-relationship-type|4.0.0"
            }
          },
          {
            "id": "DocumentReference.relatesTo.target",
            "path": "DocumentReference.relatesTo.target",
            "short": "Target of the relationship",
            "definition": "The target document of this relationship.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "DocumentReference.description",
            "path": "DocumentReference.description",
            "short": "Human-readable description",
            "definition": "Human-readable description of the source document.",
            "comment": "What the document is about,  a terse summary of the document.",
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
            "id": "DocumentReference.securityLabel",
            "path": "DocumentReference.securityLabel",
            "short": "Document security-tags",
            "definition": "A set of Security-Tag codes specifying the level of privacy/security of the Document. Note that DocumentReference.meta.security contains the security labels of the \"reference\" to the document, while DocumentReference.securityLabel contains a snapshot of the security labels on the document the reference refers to.",
            "comment": "The confidentiality codes can carry multiple vocabulary items. HL7 has developed an understanding of security and privacy tags that might be desirable in a Document Sharing environment, called HL7 Healthcare Privacy and Security Classification System (HCS). The following specification is recommended but not mandated, as the vocabulary bindings are an administrative domain responsibility. The use of this method is up to the policy domain such as the XDS Affinity Domain or other Trust Domain where all parties including sender and recipients are trusted to appropriately tag and enforce.   \n\nIn the HL7 Healthcare Privacy and Security Classification (HCS) there are code systems specific to Confidentiality, Sensitivity, Integrity, and Handling Caveats. Some values would come from a local vocabulary as they are related to workflow roles and special projects.",
            "requirements": "Use of the Health Care Privacy/Security Classification (HCS) system of security-tag use is recommended.",
            "min": 0,
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
                  "valueString": "SecurityLabels"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "extensible",
              "description": "Security Labels from the Healthcare Privacy and Security Classification System.",
              "valueSet": "http://hl7.org/fhir/ValueSet/security-labels"
            }
          },
          {
            "id": "DocumentReference.content",
            "path": "DocumentReference.content",
            "short": "Document referenced",
            "definition": "The document and format referenced. There may be multiple content element repetitions, each with a different format.",
            "min": 1,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "DocumentReference.content.attachment",
            "path": "DocumentReference.content.attachment",
            "short": "Where to access the document",
            "definition": "The document or URL of the document along with critical metadata to prove content has integrity.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Attachment"
              }
            ],
            "isSummary": true
          },
          {
            "id": "DocumentReference.content.format",
            "path": "DocumentReference.content.format",
            "short": "Format/content rules for the document",
            "definition": "An identifier of the document encoding, structure, and template that the document conforms to beyond the base format indicated in the mimeType.",
            "comment": "Note that while IHE mostly issues URNs for format types, not all documents can be identified by a URI.",
            "min": 0,
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
                  "valueString": "DocumentFormat"
                }
              ],
              "strength": "preferred",
              "description": "Document Format Codes.",
              "valueSet": "http://hl7.org/fhir/ValueSet/formatcodes"
            }
          },
          {
            "id": "DocumentReference.context",
            "path": "DocumentReference.context",
            "short": "Clinical context of document",
            "definition": "The clinical context in which the document was prepared.",
            "comment": "These values are primarily added to help with searching for interesting/relevant documents.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "DocumentReference.context.encounter",
            "path": "DocumentReference.context.encounter",
            "short": "Context of the document  content",
            "definition": "Describes the clinical encounter or type of care that the document content is associated with.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Encounter",
                  "http://hl7.org/fhir/StructureDefinition/EpisodeOfCare"
                ]
              }
            ]
          },
          {
            "id": "DocumentReference.context.event",
            "path": "DocumentReference.context.event",
            "short": "Main clinical acts documented",
            "definition": "This list of codes represents the main clinical acts, such as a colonoscopy or an appendectomy, being documented. In some cases, the event is inherent in the type Code, such as a \"History and Physical Report\" in which the procedure being documented is necessarily a \"History and Physical\" act.",
            "comment": "An event can further specialize the act inherent in the type, such as  where it is simply \"Procedure Report\" and the procedure was a \"colonoscopy\". If one or more event codes are included, they shall not conflict with the values inherent in the class or type elements as such a conflict would create an ambiguous situation.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "DocumentEventType"
                }
              ],
              "strength": "example",
              "description": "This list of codes represents the main clinical acts being documented.",
              "valueSet": "http://terminology.hl7.org/ValueSet/v3-ActCode"
            }
          },
          {
            "id": "DocumentReference.context.period",
            "path": "DocumentReference.context.period",
            "short": "Time of service that is being documented",
            "definition": "The time period over which the service that is described by the document was provided.",
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
            "id": "DocumentReference.context.facilityType",
            "path": "DocumentReference.context.facilityType",
            "short": "Kind of facility where patient was seen",
            "definition": "The kind of facility where the patient was seen.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "DocumentC80FacilityType"
                }
              ],
              "strength": "example",
              "description": "XDS Facility Type.",
              "valueSet": "http://hl7.org/fhir/ValueSet/c80-facilitycodes"
            }
          },
          {
            "id": "DocumentReference.context.practiceSetting",
            "path": "DocumentReference.context.practiceSetting",
            "short": "Additional details about where the content was created (e.g. clinical specialty)",
            "definition": "This property may convey specifics about the practice setting where the content was created, often reflecting the clinical specialty.",
            "comment": "This element should be based on a coarse classification system for the class of specialty practice. Recommend the use of the classification system for Practice Setting, such as that described by the Subject Matter Domain in LOINC.",
            "requirements": "This is an important piece of metadata that providers often rely upon to quickly sort and/or filter out to find specific content.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "DocumentC80PracticeSetting"
                }
              ],
              "strength": "example",
              "description": "Additional details about where the content was created (e.g. clinical specialty).",
              "valueSet": "http://hl7.org/fhir/ValueSet/c80-practice-codes"
            }
          },
          {
            "id": "DocumentReference.context.sourcePatientInfo",
            "path": "DocumentReference.context.sourcePatientInfo",
            "short": "Patient demographics from source",
            "definition": "The Patient Information as known when the document was published. May be a reference to a version specific, or contained.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient"
                ]
              }
            ]
          },
          {
            "id": "DocumentReference.context.related",
            "path": "DocumentReference.context.related",
            "short": "Related identifiers or resources",
            "definition": "Related identifiers or resources associated with the DocumentReference.",
            "comment": "May be identifiers or resources that caused the DocumentReference or referenced Document to be created.",
            "min": 0,
            "max": "*",
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
    /// Fhir resource 'DocumentReference'
    /// </summary>
    // 0. DocumentReference
    public partial class Resource_DocumentReference : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 12. DocumentReference.relatesTo
        public partial class Type_RelatesTo : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 13. DocumentReference.relatesTo.code
            public ElementDefinitionInfo Element_Code;
            // 14. DocumentReference.relatesTo.target
            public ElementDefinitionInfo Element_Target;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "DocumentReference.relatesTo",
                    ElementId = "DocumentReference.relatesTo"
                });
                Element_Code.Write(sDef);
                Element_Target.Write(sDef);
            }
            
            public Type_RelatesTo()
            {
                {
                    // 13. DocumentReference.relatesTo.code
                    this.Element_Code = new ElementDefinitionInfo
                    {
                        Name = "Element_Code",
                        Path= "DocumentReference.relatesTo.code",
                        Id = "DocumentReference.relatesTo.code",
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
                    // 14. DocumentReference.relatesTo.target
                    this.Element_Target = new ElementDefinitionInfo
                    {
                        Name = "Element_Target",
                        Path= "DocumentReference.relatesTo.target",
                        Id = "DocumentReference.relatesTo.target",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                                }
                            }
                        }
                    };
                }
            }
        }
        // 17. DocumentReference.content
        public partial class Type_Content : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 18. DocumentReference.content.attachment
            public ElementDefinitionInfo Element_Attachment;
            // 19. DocumentReference.content.format
            public ElementDefinitionInfo Element_Format;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "DocumentReference.content",
                    ElementId = "DocumentReference.content"
                });
                Element_Attachment.Write(sDef);
                Element_Format.Write(sDef);
            }
            
            public Type_Content()
            {
                {
                    // 18. DocumentReference.content.attachment
                    this.Element_Attachment = new ElementDefinitionInfo
                    {
                        Name = "Element_Attachment",
                        Path= "DocumentReference.content.attachment",
                        Id = "DocumentReference.content.attachment",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Attachment
                            {
                            }
                        }
                    };
                }
                {
                    // 19. DocumentReference.content.format
                    this.Element_Format = new ElementDefinitionInfo
                    {
                        Name = "Element_Format",
                        Path= "DocumentReference.content.format",
                        Id = "DocumentReference.content.format",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Coding
                            {
                            }
                        }
                    };
                }
            }
        }
        // 20. DocumentReference.context
        public partial class Type_Context : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 21. DocumentReference.context.encounter
            public ElementDefinitionInfo Element_Encounter;
            // 22. DocumentReference.context.event
            public ElementDefinitionInfo Element_Event;
            // 23. DocumentReference.context.period
            public ElementDefinitionInfo Element_Period;
            // 24. DocumentReference.context.facilityType
            public ElementDefinitionInfo Element_FacilityType;
            // 25. DocumentReference.context.practiceSetting
            public ElementDefinitionInfo Element_PracticeSetting;
            // 26. DocumentReference.context.sourcePatientInfo
            public ElementDefinitionInfo Element_SourcePatientInfo;
            // 27. DocumentReference.context.related
            public ElementDefinitionInfo Element_Related;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "DocumentReference.context",
                    ElementId = "DocumentReference.context"
                });
                Element_Encounter.Write(sDef);
                Element_Event.Write(sDef);
                Element_Period.Write(sDef);
                Element_FacilityType.Write(sDef);
                Element_PracticeSetting.Write(sDef);
                Element_SourcePatientInfo.Write(sDef);
                Element_Related.Write(sDef);
            }
            
            public Type_Context()
            {
                {
                    // 21. DocumentReference.context.encounter
                    this.Element_Encounter = new ElementDefinitionInfo
                    {
                        Name = "Element_Encounter",
                        Path= "DocumentReference.context.encounter",
                        Id = "DocumentReference.context.encounter",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Encounter",
                                    "http://hl7.org/fhir/StructureDefinition/EpisodeOfCare"
                                }
                            }
                        }
                    };
                }
                {
                    // 22. DocumentReference.context.event
                    this.Element_Event = new ElementDefinitionInfo
                    {
                        Name = "Element_Event",
                        Path= "DocumentReference.context.event",
                        Id = "DocumentReference.context.event",
                        Min = 0,
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
                    // 23. DocumentReference.context.period
                    this.Element_Period = new ElementDefinitionInfo
                    {
                        Name = "Element_Period",
                        Path= "DocumentReference.context.period",
                        Id = "DocumentReference.context.period",
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
                    // 24. DocumentReference.context.facilityType
                    this.Element_FacilityType = new ElementDefinitionInfo
                    {
                        Name = "Element_FacilityType",
                        Path= "DocumentReference.context.facilityType",
                        Id = "DocumentReference.context.facilityType",
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
                    // 25. DocumentReference.context.practiceSetting
                    this.Element_PracticeSetting = new ElementDefinitionInfo
                    {
                        Name = "Element_PracticeSetting",
                        Path= "DocumentReference.context.practiceSetting",
                        Id = "DocumentReference.context.practiceSetting",
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
                    // 26. DocumentReference.context.sourcePatientInfo
                    this.Element_SourcePatientInfo = new ElementDefinitionInfo
                    {
                        Name = "Element_SourcePatientInfo",
                        Path= "DocumentReference.context.sourcePatientInfo",
                        Id = "DocumentReference.context.sourcePatientInfo",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Patient"
                                }
                            }
                        }
                    };
                }
                {
                    // 27. DocumentReference.context.related
                    this.Element_Related = new ElementDefinitionInfo
                    {
                        Name = "Element_Related",
                        Path= "DocumentReference.context.related",
                        Id = "DocumentReference.context.related",
                        Min = 0,
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
            }
        }
        // 1. DocumentReference.masterIdentifier
        public ElementDefinitionInfo Element_MasterIdentifier;
        // 2. DocumentReference.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 3. DocumentReference.status
        public ElementDefinitionInfo Element_Status;
        // 4. DocumentReference.docStatus
        public ElementDefinitionInfo Element_DocStatus;
        // 5. DocumentReference.type
        public ElementDefinitionInfo Element_Type;
        // 6. DocumentReference.category
        public ElementDefinitionInfo Element_Category;
        // 7. DocumentReference.subject
        public ElementDefinitionInfo Element_Subject;
        // 8. DocumentReference.date
        public ElementDefinitionInfo Element_Date;
        // 9. DocumentReference.author
        public ElementDefinitionInfo Element_Author;
        // 10. DocumentReference.authenticator
        public ElementDefinitionInfo Element_Authenticator;
        // 11. DocumentReference.custodian
        public ElementDefinitionInfo Element_Custodian;
        // 12. DocumentReference.relatesTo
        public ElementDefinitionInfo Element_RelatesTo;
        // 15. DocumentReference.description
        public ElementDefinitionInfo Element_Description;
        // 16. DocumentReference.securityLabel
        public ElementDefinitionInfo Element_SecurityLabel;
        // 17. DocumentReference.content
        public ElementDefinitionInfo Element_Content;
        // 20. DocumentReference.context
        public ElementDefinitionInfo Element_Context;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "DocumentReference",
                ElementId = "DocumentReference"
            });
            Element_MasterIdentifier.Write(sDef);
            Element_Identifier.Write(sDef);
            Element_Status.Write(sDef);
            Element_DocStatus.Write(sDef);
            Element_Type.Write(sDef);
            Element_Category.Write(sDef);
            Element_Subject.Write(sDef);
            Element_Date.Write(sDef);
            Element_Author.Write(sDef);
            Element_Authenticator.Write(sDef);
            Element_Custodian.Write(sDef);
            Element_RelatesTo.Write(sDef);
            Element_Description.Write(sDef);
            Element_SecurityLabel.Write(sDef);
            Element_Content.Write(sDef);
            Element_Context.Write(sDef);
        }
        
        public Resource_DocumentReference()
        {
            {
                // 1. DocumentReference.masterIdentifier
                this.Element_MasterIdentifier = new ElementDefinitionInfo
                {
                    Name = "Element_MasterIdentifier",
                    Path= "DocumentReference.masterIdentifier",
                    Id = "DocumentReference.masterIdentifier",
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
                // 2. DocumentReference.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "DocumentReference.identifier",
                    Id = "DocumentReference.identifier",
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
                // 3. DocumentReference.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "DocumentReference.status",
                    Id = "DocumentReference.status",
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
                // 4. DocumentReference.docStatus
                this.Element_DocStatus = new ElementDefinitionInfo
                {
                    Name = "Element_DocStatus",
                    Path= "DocumentReference.docStatus",
                    Id = "DocumentReference.docStatus",
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
                // 5. DocumentReference.type
                this.Element_Type = new ElementDefinitionInfo
                {
                    Name = "Element_Type",
                    Path= "DocumentReference.type",
                    Id = "DocumentReference.type",
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
                // 6. DocumentReference.category
                this.Element_Category = new ElementDefinitionInfo
                {
                    Name = "Element_Category",
                    Path= "DocumentReference.category",
                    Id = "DocumentReference.category",
                    Min = 0,
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
                // 7. DocumentReference.subject
                this.Element_Subject = new ElementDefinitionInfo
                {
                    Name = "Element_Subject",
                    Path= "DocumentReference.subject",
                    Id = "DocumentReference.subject",
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
                // 8. DocumentReference.date
                this.Element_Date = new ElementDefinitionInfo
                {
                    Name = "Element_Date",
                    Path= "DocumentReference.date",
                    Id = "DocumentReference.date",
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
                // 9. DocumentReference.author
                this.Element_Author = new ElementDefinitionInfo
                {
                    Name = "Element_Author",
                    Path= "DocumentReference.author",
                    Id = "DocumentReference.author",
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
                // 10. DocumentReference.authenticator
                this.Element_Authenticator = new ElementDefinitionInfo
                {
                    Name = "Element_Authenticator",
                    Path= "DocumentReference.authenticator",
                    Id = "DocumentReference.authenticator",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                                "http://hl7.org/fhir/StructureDefinition/Organization"
                            }
                        }
                    }
                };
            }
            {
                // 11. DocumentReference.custodian
                this.Element_Custodian = new ElementDefinitionInfo
                {
                    Name = "Element_Custodian",
                    Path= "DocumentReference.custodian",
                    Id = "DocumentReference.custodian",
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
                // 12. DocumentReference.relatesTo
                this.Element_RelatesTo = new ElementDefinitionInfo
                {
                    Name = "Element_RelatesTo",
                    Path= "DocumentReference.relatesTo",
                    Id = "DocumentReference.relatesTo",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_RelatesTo
                        {
                        }
                    }
                };
            }
            {
                // 15. DocumentReference.description
                this.Element_Description = new ElementDefinitionInfo
                {
                    Name = "Element_Description",
                    Path= "DocumentReference.description",
                    Id = "DocumentReference.description",
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
                // 16. DocumentReference.securityLabel
                this.Element_SecurityLabel = new ElementDefinitionInfo
                {
                    Name = "Element_SecurityLabel",
                    Path= "DocumentReference.securityLabel",
                    Id = "DocumentReference.securityLabel",
                    Min = 0,
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
                // 17. DocumentReference.content
                this.Element_Content = new ElementDefinitionInfo
                {
                    Name = "Element_Content",
                    Path= "DocumentReference.content",
                    Id = "DocumentReference.content",
                    Min = 1,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Content
                        {
                        }
                    }
                };
            }
            {
                // 20. DocumentReference.context
                this.Element_Context = new ElementDefinitionInfo
                {
                    Name = "Element_Context",
                    Path= "DocumentReference.context",
                    Id = "DocumentReference.context",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new Type_Context
                        {
                        }
                    }
                };
            }
            this.Name = "DocumentReference";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/DocumentReference";
        }
    }
}
