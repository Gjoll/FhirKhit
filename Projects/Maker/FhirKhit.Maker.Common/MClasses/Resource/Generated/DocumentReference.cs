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
    #endregion                                                                                                                              // MakerGen.cs:461
    /// <summary>
    /// Fhir resource 'DocumentReference'
    /// </summary>
    // 0. DocumentReference
    public class DocumentReference : FhirKhit.Maker.Common.Resource.ResourceBase                                                            // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        public class DocumentReference_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                               // MakerGen.cs:385
        {                                                                                                                                   // MakerGen.cs:386
            // 12. DocumentReference.relatesTo
            public class Type_RelatesTo : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_RelatesTo_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                          // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 13. DocumentReference.relatesTo.code
                    public ElementDefinitionInfo Code;                                                                                      // MakerGen.cs:216
                    // 14. DocumentReference.relatesTo.target
                    public ElementDefinitionInfo Target;                                                                                    // MakerGen.cs:216
                    public Type_RelatesTo_Elements()                                                                                        // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 13. DocumentReference.relatesTo.code
                            this.Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Code",                                                                                              // MakerGen.cs:235
                                Path= "DocumentReference.relatesTo.code",                                                                   // MakerGen.cs:236
                                Id = "DocumentReference.relatesTo.code",                                                                    // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 14. DocumentReference.relatesTo.target
                            this.Target = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Target",                                                                                            // MakerGen.cs:235
                                Path= "DocumentReference.relatesTo.target",                                                                 // MakerGen.cs:236
                                Id = "DocumentReference.relatesTo.target",                                                                  // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/DocumentReference"                                     // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        Code.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Target.Write(sDef);                                                                                                 // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_RelatesTo_Elements Elements { get; }                                                                            // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_RelatesTo()                                                                                                     // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_RelatesTo_Elements();                                                                          // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 17. DocumentReference.content
            public class Type_Content : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_Content_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                            // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 18. DocumentReference.content.attachment
                    public ElementDefinitionInfo Attachment;                                                                                // MakerGen.cs:216
                    // 19. DocumentReference.content.format
                    public ElementDefinitionInfo Format;                                                                                    // MakerGen.cs:216
                    public Type_Content_Elements()                                                                                          // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 18. DocumentReference.content.attachment
                            this.Attachment = new ElementDefinitionInfo                                                                     // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Attachment",                                                                                        // MakerGen.cs:235
                                Path= "DocumentReference.content.attachment",                                                               // MakerGen.cs:236
                                Id = "DocumentReference.content.attachment",                                                                // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Attachment                                                            // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 19. DocumentReference.content.format
                            this.Format = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Format",                                                                                            // MakerGen.cs:235
                                Path= "DocumentReference.content.format",                                                                   // MakerGen.cs:236
                                Id = "DocumentReference.content.format",                                                                    // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Coding                                                                // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        Attachment.Write(sDef);                                                                                             // MakerGen.cs:220
                        Format.Write(sDef);                                                                                                 // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_Content_Elements Elements { get; }                                                                              // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_Content()                                                                                                       // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_Content_Elements();                                                                            // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 20. DocumentReference.context
            public class Type_Context : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_Context_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                            // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 21. DocumentReference.context.encounter
                    public ElementDefinitionInfo Encounter;                                                                                 // MakerGen.cs:216
                    // 22. DocumentReference.context.event
                    public ElementDefinitionInfo Event;                                                                                     // MakerGen.cs:216
                    // 23. DocumentReference.context.period
                    public ElementDefinitionInfo Period;                                                                                    // MakerGen.cs:216
                    // 24. DocumentReference.context.facilityType
                    public ElementDefinitionInfo FacilityType;                                                                              // MakerGen.cs:216
                    // 25. DocumentReference.context.practiceSetting
                    public ElementDefinitionInfo PracticeSetting;                                                                           // MakerGen.cs:216
                    // 26. DocumentReference.context.sourcePatientInfo
                    public ElementDefinitionInfo SourcePatientInfo;                                                                         // MakerGen.cs:216
                    // 27. DocumentReference.context.related
                    public ElementDefinitionInfo Related;                                                                                   // MakerGen.cs:216
                    public Type_Context_Elements()                                                                                          // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 21. DocumentReference.context.encounter
                            this.Encounter = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Encounter",                                                                                         // MakerGen.cs:235
                                Path= "DocumentReference.context.encounter",                                                                // MakerGen.cs:236
                                Id = "DocumentReference.context.encounter",                                                                 // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Encounter",                                            // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/EpisodeOfCare"                                         // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 22. DocumentReference.context.event
                            this.Event = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Event",                                                                                             // MakerGen.cs:235
                                Path= "DocumentReference.context.event",                                                                    // MakerGen.cs:236
                                Id = "DocumentReference.context.event",                                                                     // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 23. DocumentReference.context.period
                            this.Period = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Period",                                                                                            // MakerGen.cs:235
                                Path= "DocumentReference.context.period",                                                                   // MakerGen.cs:236
                                Id = "DocumentReference.context.period",                                                                    // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Period                                                                // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 24. DocumentReference.context.facilityType
                            this.FacilityType = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "FacilityType",                                                                                      // MakerGen.cs:235
                                Path= "DocumentReference.context.facilityType",                                                             // MakerGen.cs:236
                                Id = "DocumentReference.context.facilityType",                                                              // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 25. DocumentReference.context.practiceSetting
                            this.PracticeSetting = new ElementDefinitionInfo                                                                // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "PracticeSetting",                                                                                   // MakerGen.cs:235
                                Path= "DocumentReference.context.practiceSetting",                                                          // MakerGen.cs:236
                                Id = "DocumentReference.context.practiceSetting",                                                           // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 26. DocumentReference.context.sourcePatientInfo
                            this.SourcePatientInfo = new ElementDefinitionInfo                                                              // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "SourcePatientInfo",                                                                                 // MakerGen.cs:235
                                Path= "DocumentReference.context.sourcePatientInfo",                                                        // MakerGen.cs:236
                                Id = "DocumentReference.context.sourcePatientInfo",                                                         // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Patient"                                               // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 27. DocumentReference.context.related
                            this.Related = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Related",                                                                                           // MakerGen.cs:235
                                Path= "DocumentReference.context.related",                                                                  // MakerGen.cs:236
                                Id = "DocumentReference.context.related",                                                                   // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
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
                        Encounter.Write(sDef);                                                                                              // MakerGen.cs:220
                        Event.Write(sDef);                                                                                                  // MakerGen.cs:220
                        Period.Write(sDef);                                                                                                 // MakerGen.cs:220
                        FacilityType.Write(sDef);                                                                                           // MakerGen.cs:220
                        PracticeSetting.Write(sDef);                                                                                        // MakerGen.cs:220
                        SourcePatientInfo.Write(sDef);                                                                                      // MakerGen.cs:220
                        Related.Write(sDef);                                                                                                // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_Context_Elements Elements { get; }                                                                              // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_Context()                                                                                                       // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_Context_Elements();                                                                            // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 1. DocumentReference.masterIdentifier
            public ElementDefinitionInfo MasterIdentifier;                                                                                  // MakerGen.cs:216
            // 2. DocumentReference.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:216
            // 3. DocumentReference.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:216
            // 4. DocumentReference.docStatus
            public ElementDefinitionInfo DocStatus;                                                                                         // MakerGen.cs:216
            // 5. DocumentReference.type
            public ElementDefinitionInfo Type;                                                                                              // MakerGen.cs:216
            // 6. DocumentReference.category
            public ElementDefinitionInfo Category;                                                                                          // MakerGen.cs:216
            // 7. DocumentReference.subject
            public ElementDefinitionInfo Subject;                                                                                           // MakerGen.cs:216
            // 8. DocumentReference.date
            public ElementDefinitionInfo Date;                                                                                              // MakerGen.cs:216
            // 9. DocumentReference.author
            public ElementDefinitionInfo Author;                                                                                            // MakerGen.cs:216
            // 10. DocumentReference.authenticator
            public ElementDefinitionInfo Authenticator;                                                                                     // MakerGen.cs:216
            // 11. DocumentReference.custodian
            public ElementDefinitionInfo Custodian;                                                                                         // MakerGen.cs:216
            // 12. DocumentReference.relatesTo
            public ElementDefinitionInfo RelatesTo;                                                                                         // MakerGen.cs:216
            // 15. DocumentReference.description
            public ElementDefinitionInfo Description;                                                                                       // MakerGen.cs:216
            // 16. DocumentReference.securityLabel
            public ElementDefinitionInfo SecurityLabel;                                                                                     // MakerGen.cs:216
            // 17. DocumentReference.content
            public ElementDefinitionInfo Content;                                                                                           // MakerGen.cs:216
            // 20. DocumentReference.context
            public ElementDefinitionInfo Context;                                                                                           // MakerGen.cs:216
            public DocumentReference_Elements()                                                                                             // MakerGen.cs:407
            {                                                                                                                               // MakerGen.cs:408
                {                                                                                                                           // MakerGen.cs:231
                    // 1. DocumentReference.masterIdentifier
                    this.MasterIdentifier = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "MasterIdentifier",                                                                                          // MakerGen.cs:235
                        Path= "DocumentReference.masterIdentifier",                                                                         // MakerGen.cs:236
                        Id = "DocumentReference.masterIdentifier",                                                                          // MakerGen.cs:237
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
                    // 2. DocumentReference.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Identifier",                                                                                                // MakerGen.cs:235
                        Path= "DocumentReference.identifier",                                                                               // MakerGen.cs:236
                        Id = "DocumentReference.identifier",                                                                                // MakerGen.cs:237
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
                    // 3. DocumentReference.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Status",                                                                                                    // MakerGen.cs:235
                        Path= "DocumentReference.status",                                                                                   // MakerGen.cs:236
                        Id = "DocumentReference.status",                                                                                    // MakerGen.cs:237
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
                    // 4. DocumentReference.docStatus
                    this.DocStatus = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "DocStatus",                                                                                                 // MakerGen.cs:235
                        Path= "DocumentReference.docStatus",                                                                                // MakerGen.cs:236
                        Id = "DocumentReference.docStatus",                                                                                 // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
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
                    // 5. DocumentReference.type
                    this.Type = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Type",                                                                                                      // MakerGen.cs:235
                        Path= "DocumentReference.type",                                                                                     // MakerGen.cs:236
                        Id = "DocumentReference.type",                                                                                      // MakerGen.cs:237
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
                    // 6. DocumentReference.category
                    this.Category = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Category",                                                                                                  // MakerGen.cs:235
                        Path= "DocumentReference.category",                                                                                 // MakerGen.cs:236
                        Id = "DocumentReference.category",                                                                                  // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
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
                    // 7. DocumentReference.subject
                    this.Subject = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Subject",                                                                                                   // MakerGen.cs:235
                        Path= "DocumentReference.subject",                                                                                  // MakerGen.cs:236
                        Id = "DocumentReference.subject",                                                                                   // MakerGen.cs:237
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
                    // 8. DocumentReference.date
                    this.Date = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Date",                                                                                                      // MakerGen.cs:235
                        Path= "DocumentReference.date",                                                                                     // MakerGen.cs:236
                        Id = "DocumentReference.date",                                                                                      // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Instant                                                                     // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 9. DocumentReference.author
                    this.Author = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Author",                                                                                                    // MakerGen.cs:235
                        Path= "DocumentReference.author",                                                                                   // MakerGen.cs:236
                        Id = "DocumentReference.author",                                                                                    // MakerGen.cs:237
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
                    // 10. DocumentReference.authenticator
                    this.Authenticator = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Authenticator",                                                                                             // MakerGen.cs:235
                        Path= "DocumentReference.authenticator",                                                                            // MakerGen.cs:236
                        Id = "DocumentReference.authenticator",                                                                             // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 11. DocumentReference.custodian
                    this.Custodian = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Custodian",                                                                                                 // MakerGen.cs:235
                        Path= "DocumentReference.custodian",                                                                                // MakerGen.cs:236
                        Id = "DocumentReference.custodian",                                                                                 // MakerGen.cs:237
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
                    // 12. DocumentReference.relatesTo
                    this.RelatesTo = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "RelatesTo",                                                                                                 // MakerGen.cs:235
                        Path= "DocumentReference.relatesTo",                                                                                // MakerGen.cs:236
                        Id = "DocumentReference.relatesTo",                                                                                 // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_RelatesTo                                                                                              // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 15. DocumentReference.description
                    this.Description = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Description",                                                                                               // MakerGen.cs:235
                        Path= "DocumentReference.description",                                                                              // MakerGen.cs:236
                        Id = "DocumentReference.description",                                                                               // MakerGen.cs:237
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
                    // 16. DocumentReference.securityLabel
                    this.SecurityLabel = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "SecurityLabel",                                                                                             // MakerGen.cs:235
                        Path= "DocumentReference.securityLabel",                                                                            // MakerGen.cs:236
                        Id = "DocumentReference.securityLabel",                                                                             // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
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
                    // 17. DocumentReference.content
                    this.Content = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Content",                                                                                                   // MakerGen.cs:235
                        Path= "DocumentReference.content",                                                                                  // MakerGen.cs:236
                        Id = "DocumentReference.content",                                                                                   // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Content                                                                                                // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 20. DocumentReference.context
                    this.Context = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Context",                                                                                                   // MakerGen.cs:235
                        Path= "DocumentReference.context",                                                                                  // MakerGen.cs:236
                        Id = "DocumentReference.context",                                                                                   // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Context                                                                                                // MakerGen.cs:259
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
                DocStatus.Write(sDef);                                                                                                      // MakerGen.cs:220
                Type.Write(sDef);                                                                                                           // MakerGen.cs:220
                Category.Write(sDef);                                                                                                       // MakerGen.cs:220
                Subject.Write(sDef);                                                                                                        // MakerGen.cs:220
                Date.Write(sDef);                                                                                                           // MakerGen.cs:220
                Author.Write(sDef);                                                                                                         // MakerGen.cs:220
                Authenticator.Write(sDef);                                                                                                  // MakerGen.cs:220
                Custodian.Write(sDef);                                                                                                      // MakerGen.cs:220
                RelatesTo.Write(sDef);                                                                                                      // MakerGen.cs:220
                Description.Write(sDef);                                                                                                    // MakerGen.cs:220
                SecurityLabel.Write(sDef);                                                                                                  // MakerGen.cs:220
                Content.Write(sDef);                                                                                                        // MakerGen.cs:220
                Context.Write(sDef);                                                                                                        // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:431
        }                                                                                                                                   // MakerGen.cs:391
        public DocumentReference_Elements Elements { get; }                                                                                 // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
        public DocumentReference()                                                                                                          // MakerGen.cs:394
        {                                                                                                                                   // MakerGen.cs:395
            this.Elements = new DocumentReference_Elements();                                                                               // MakerGen.cs:396
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:399
        {                                                                                                                                   // MakerGen.cs:400
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:401
        }                                                                                                                                   // MakerGen.cs:402
    }                                                                                                                                       // MakerGen.cs:403
}                                                                                                                                           // MakerGen.cs:466
