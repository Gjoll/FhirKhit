using System;                                                                                                                               // MakerGen.cs:457
using System.Diagnostics;                                                                                                                   // MakerGen.cs:458
using System.IO;                                                                                                                            // MakerGen.cs:459
using System.Linq;                                                                                                                          // MakerGen.cs:460
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:461
                                                                                                                                            // MakerGen.cs:462
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:463
{                                                                                                                                           // MakerGen.cs:464
    #region Json                                                                                                                            // MakerGen.cs:465
    #if NEVER                                                                                                                               // MakerGen.cs:466
    {
      "resourceType": "StructureDefinition",
      "id": "Composition",
      "url": "http://hl7.org/fhir/StructureDefinition/Composition",
      "version": "4.0.0",
      "name": "Composition",
      "status": "draft",
      "publisher": "Health Level Seven International (Structured Documents)",
      "description": "A set of healthcare-related information that is assembled together into a single logical package that provides a single coherent statement of meaning, establishes its own context and that has clinical attestation with regard to who is making the statement. A Composition defines the structure and narrative content necessary for a document. However, a Composition alone does not constitute a document. Rather, the Composition must be the first entry in a Bundle where Bundle.type=document, and any other resources referenced from Composition must be included as subsequent entries in the Bundle (for example Patient, Practitioner, Encounter, etc.).",
      "purpose": "To support documents, and also to capture the EN13606 notion of an attested commit to the patient EHR, and to allow a set of disparate resources at the information/engineering level to be gathered into a clinical statement.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "Composition",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Composition",
            "path": "Composition",
            "short": "A set of resources composed into a single coherent clinical statement with clinical attestation",
            "definition": "A set of healthcare-related information that is assembled together into a single logical package that provides a single coherent statement of meaning, establishes its own context and that has clinical attestation with regard to who is making the statement. A Composition defines the structure and narrative content necessary for a document. However, a Composition alone does not constitute a document. Rather, the Composition must be the first entry in a Bundle where Bundle.type=document, and any other resources referenced from Composition must be included as subsequent entries in the Bundle (for example Patient, Practitioner, Encounter, etc.).",
            "comment": "While the focus of this specification is on patient-specific clinical statements, this resource can also apply to other healthcare-related statements such as study protocol designs, healthcare invoices and other activities that are not necessarily patient-specific or clinical.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Composition.identifier",
            "path": "Composition.identifier",
            "short": "Version-independent identifier for the Composition",
            "definition": "A version-independent identifier for the Composition. This identifier stays constant as the composition is changed over time.",
            "comment": "Similar to ClinicalDocument/setId in CDA. See discussion in resource definition for how these relate.",
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
            "id": "Composition.status",
            "path": "Composition.status",
            "short": "preliminary | final | amended | entered-in-error",
            "definition": "The workflow/clinical status of this composition. The status is a marker for the clinical standing of the document.",
            "comment": "If a composition is marked as withdrawn, the compositions/documents in the series, or data from the composition or document series, should never be displayed to a user without being clearly marked as untrustworthy. The flag \"entered-in-error\" is why this element is labeled as a modifier of other elements.   \n\nSome reporting work flows require that the original narrative of a final document never be altered; instead, only new narrative can be added. The composition resource has no explicit status for explicitly noting whether this business rule is in effect. This would be handled by an extension if required.",
            "requirements": "Need to be able to mark interim, amended, or withdrawn compositions or documents.",
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
                  "valueString": "CompositionStatus"
                }
              ],
              "strength": "required",
              "description": "The workflow/clinical status of the composition.",
              "valueSet": "http://hl7.org/fhir/ValueSet/composition-status|4.0.0"
            }
          },
          {
            "id": "Composition.type",
            "path": "Composition.type",
            "short": "Kind of composition (LOINC if possible)",
            "definition": "Specifies the particular kind of composition (e.g. History and Physical, Discharge Summary, Progress Note). This usually equates to the purpose of making the composition.",
            "comment": "For Composition type, LOINC is ubiquitous and strongly endorsed by HL7. Most implementation guides will require a specific LOINC code, or use LOINC as an extensible binding.",
            "requirements": "Key metadata element describing the composition, used in searching/filtering.",
            "min": 1,
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
                  "valueString": "DocumentType"
                }
              ],
              "strength": "preferred",
              "description": "Type of a composition.",
              "valueSet": "http://hl7.org/fhir/ValueSet/doc-typecodes"
            }
          },
          {
            "id": "Composition.category",
            "path": "Composition.category",
            "short": "Categorization of Composition",
            "definition": "A categorization for the type of the composition - helps for indexing and searching. This may be implied by or derived from the code specified in the Composition Type.",
            "comment": "This is a metadata field from [XDS/MHD](http://wiki.ihe.net/index.php?title=Mobile_access_to_Health_Documents_(MHD)).",
            "requirements": "Helps humans to assess whether the composition is of interest when viewing an index of compositions or documents.",
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
                  "valueString": "DocumentCategory"
                }
              ],
              "strength": "example",
              "description": "High-level kind of a clinical document at a macro level.",
              "valueSet": "http://hl7.org/fhir/ValueSet/document-classcodes"
            }
          },
          {
            "id": "Composition.subject",
            "path": "Composition.subject",
            "short": "Who and/or what the composition is about",
            "definition": "Who or what the composition is about. The composition can be about a person, (patient or healthcare practitioner), a device (e.g. a machine) or even a group of subjects (such as a document about a herd of livestock, or a set of patients that share a common exposure).",
            "comment": "For clinical documents, this is usually the patient.",
            "requirements": "Essential metadata for searching for the composition. Identifies who and/or what the composition/document is about.",
            "min": 0,
            "max": "1",
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
            "id": "Composition.encounter",
            "path": "Composition.encounter",
            "short": "Context of the Composition",
            "definition": "Describes the clinical encounter or type of care this documentation is associated with.",
            "requirements": "Provides context for the composition and supports searching.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Encounter"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Composition.date",
            "path": "Composition.date",
            "short": "Composition editing time",
            "definition": "The composition editing time, when the composition was last logically changed by the author.",
            "comment": "The Last Modified Date on the composition may be after the date of the document was attested without being changed.",
            "requirements": "dateTime is used for tracking, organizing versions and searching. Note that this is the time of *authoring*. When packaged in a document, [Bundle.timestamp](bundle-definitions.html#Bundle.timestamp) is the date of packaging.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Composition.author",
            "path": "Composition.author",
            "short": "Who and/or what authored the composition",
            "definition": "Identifies who is responsible for the information in the composition, not necessarily who typed it in.",
            "requirements": "Identifies who is responsible for the content.",
            "min": 1,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Composition.title",
            "path": "Composition.title",
            "short": "Human Readable name/title",
            "definition": "Official human-readable label for the composition.",
            "comment": "For many compositions, the title is the same as the text or a display name of Composition.type (e.g. a \"consultation\" or \"progress note\"). Note that CDA does not make title mandatory, but there are no known cases where it is useful for title to be omitted, so it is mandatory here. Feedback on this requirement is welcome during the trial use period.",
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
            "id": "Composition.confidentiality",
            "path": "Composition.confidentiality",
            "short": "As defined by affinity domain",
            "definition": "The code specifying the level of confidentiality of the Composition.",
            "comment": "The exact use of this element, and enforcement and issues related to highly sensitive documents are out of scope for the base specification, and delegated to implementation profiles (see security section).  This element is labeled as a modifier because highly confidential documents must not be treated as if they are not.",
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
                  "valueString": "DocumentConfidentiality"
                }
              ],
              "strength": "required",
              "description": "Codes specifying the level of confidentiality of the composition.",
              "valueSet": "http://terminology.hl7.org/ValueSet/v3-ConfidentialityClassification|4.0.0"
            }
          },
          {
            "id": "Composition.attester",
            "path": "Composition.attester",
            "short": "Attests to accuracy of composition",
            "definition": "A participant who has attested to the accuracy of the composition/document.",
            "comment": "Only list each attester once.",
            "requirements": "Identifies responsibility for the accuracy of the composition content.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Composition.attester.mode",
            "path": "Composition.attester.mode",
            "short": "personal | professional | legal | official",
            "definition": "The type of attestation the authenticator offers.",
            "requirements": "Indicates the level of authority of the attestation.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "CompositionAttestationMode"
                }
              ],
              "strength": "required",
              "description": "The way in which a person authenticated a composition.",
              "valueSet": "http://hl7.org/fhir/ValueSet/composition-attestation-mode|4.0.0"
            }
          },
          {
            "id": "Composition.attester.time",
            "path": "Composition.attester.time",
            "short": "When the composition was attested",
            "definition": "When the composition was attested by the party.",
            "requirements": "Identifies when the information in the composition was deemed accurate.  (Things may have changed since then.).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ]
          },
          {
            "id": "Composition.attester.party",
            "path": "Composition.attester.party",
            "short": "Who attested the composition",
            "definition": "Who attested the composition in the specified way.",
            "requirements": "Identifies who has taken on the responsibility for accuracy of the composition content.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ]
          },
          {
            "id": "Composition.custodian",
            "path": "Composition.custodian",
            "short": "Organization which maintains the composition",
            "definition": "Identifies the organization or group who is responsible for ongoing maintenance of and access to the composition/document information.",
            "comment": "This is useful when documents are derived from a composition - provides guidance for how to get the latest version of the document. This is optional because this is sometimes not known by the authoring system, and can be inferred by context. However, it is important that this information be known when working with a derived document, so providing a custodian is encouraged.",
            "requirements": "Identifies where to go to find the current version, where to report issues, etc.",
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
            "id": "Composition.relatesTo",
            "path": "Composition.relatesTo",
            "short": "Relationships to other compositions/documents",
            "definition": "Relationships that this composition has with other compositions or documents that already exist.",
            "comment": "A document is a version specific composition.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Composition.relatesTo.code",
            "path": "Composition.relatesTo.code",
            "short": "replaces | transforms | signs | appends",
            "definition": "The type of relationship that this composition has with anther composition or document.",
            "comment": "If this document appends another document, then the document cannot be fully understood without also accessing the referenced document.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
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
            "id": "Composition.relatesTo.target[x]",
            "path": "Composition.relatesTo.target[x]",
            "short": "Target of the relationship",
            "definition": "The target composition/document of this relationship.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Identifier"
              },
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Composition"
                ]
              }
            ]
          },
          {
            "id": "Composition.event",
            "path": "Composition.event",
            "short": "The clinical service(s) being documented",
            "definition": "The clinical service, such as a colonoscopy or an appendectomy, being documented.",
            "comment": "The event needs to be consistent with the type element, though can provide further information if desired.",
            "requirements": "Provides context for the composition and creates a linkage between a resource describing an event and the composition created describing the event.",
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
            "id": "Composition.event.code",
            "path": "Composition.event.code",
            "short": "Code(s) that apply to the event being documented",
            "definition": "This list of codes represents the main clinical acts, such as a colonoscopy or an appendectomy, being documented. In some cases, the event is inherent in the typeCode, such as a \"History and Physical Report\" in which the procedure being documented is necessarily a \"History and Physical\" act.",
            "comment": "An event can further specialize the act inherent in the typeCode, such as where it is simply \"Procedure Report\" and the procedure was a \"colonoscopy\". If one or more eventCodes are included, they SHALL NOT conflict with the values inherent in the classCode, practiceSettingCode or typeCode, as such a conflict would create an ambiguous situation. This short list of codes is provided to be used as key words for certain types of queries.",
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
                  "valueString": "DocumentEventType"
                }
              ],
              "strength": "example",
              "description": "This list of codes represents the main clinical acts being documented.",
              "valueSet": "http://terminology.hl7.org/ValueSet/v3-ActCode"
            }
          },
          {
            "id": "Composition.event.period",
            "path": "Composition.event.period",
            "short": "The period covered by the documentation",
            "definition": "The period of time covered by the documentation. There is no assertion that the documentation is a complete representation for this period, only that it documents events during this time.",
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
            "id": "Composition.event.detail",
            "path": "Composition.event.detail",
            "short": "The event(s) being documented",
            "definition": "The description and/or reference of the event(s) being documented. For example, this could be used to document such a colonoscopy or an appendectomy.",
            "min": 0,
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
            "id": "Composition.section",
            "path": "Composition.section",
            "short": "Composition is broken into sections",
            "definition": "The root of the sections that make up the composition.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Composition.section.title",
            "path": "Composition.section.title",
            "short": "Label for section (e.g. for ToC)",
            "definition": "The label for this particular section.  This will be part of the rendered content for the document, and is often used to build a table of contents.",
            "comment": "The title identifies the section for a human reader. The title must be consistent with the narrative of the resource that is the target of the section.content reference. Generally, sections SHOULD have titles, but in some documents, it is unnecessary or inappropriate. Typically, this is where a section has subsections that have their own adequately distinguishing title,  or documents that only have a single section. Most Implementation Guides will make section title to be a required element.",
            "requirements": "Section headings are often standardized for different types of documents.  They give guidance to humans on how the document is organized.",
            "alias": [
              "header",
              "label",
              "caption"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "Composition.section.code",
            "path": "Composition.section.code",
            "short": "Classification of section (recommended)",
            "definition": "A code identifying the kind of content contained within the section. This must be consistent with the section title.",
            "comment": "The code identifies the section for an automated processor of the document. This is particularly relevant when using profiles to control the structure of the document.   \n\nIf the section has content (instead of sub-sections), the section.code does not change the meaning or interpretation of the resource that is the content of the section in the comments for the section.code.",
            "requirements": "Provides computable standardized labels to topics within the document.",
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
                  "valueString": "CompositionSectionType"
                }
              ],
              "strength": "example",
              "description": "Classification of a section of a composition/document.",
              "valueSet": "http://hl7.org/fhir/ValueSet/doc-section-codes"
            }
          },
          {
            "id": "Composition.section.author",
            "path": "Composition.section.author",
            "short": "Who and/or what authored the section",
            "definition": "Identifies who is responsible for the information in this section, not necessarily who typed it in.",
            "requirements": "Identifies who is responsible for the content.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ]
          },
          {
            "id": "Composition.section.focus",
            "path": "Composition.section.focus",
            "short": "Who/what the section is about, when it is not about the subject of composition",
            "definition": "The actual focus of the section when it is not the subject of the composition, but instead represents something or someone associated with the subject such as (for a patient subject) a spouse, parent, fetus, or donor. If not focus is specified, the focus is assumed to be focus of the parent section, or, for a section in the Composition itself, the subject of the composition. Sections with a focus SHALL only include resources where the logical subject (patient, subject, focus, etc.) matches the section focus, or the resources have no logical subject (few resources).",
            "comment": "Typically, sections in a doument are about the subject of the document, whether that is a  patient, or group of patients, location, or device, or whatever. For some kind of documents, some sections actually contain data about related entities. Typical examples are  a section in a newborn discharge summary concerning the mother, or family history documents, with a section about each family member, though there are many other examples.",
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
          },
          {
            "id": "Composition.section.text",
            "path": "Composition.section.text",
            "short": "Text summary of the section, for human interpretation",
            "definition": "A human-readable narrative that contains the attested content of the section, used to represent the content of the resource to a human. The narrative need not encode all the structured data, but is required to contain sufficient detail to make it \"clinically safe\" for a human to just read the narrative.",
            "comment": "Document profiles may define what content should be represented in the narrative to ensure clinical safety.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Narrative"
              }
            ],
            "condition": [
              "cmp-1"
            ]
          },
          {
            "id": "Composition.section.mode",
            "path": "Composition.section.mode",
            "short": "working | snapshot | changes",
            "definition": "How the entry list was prepared - whether it is a working list that is suitable for being maintained on an ongoing basis, or if it represents a snapshot of a list of items from another source, or whether it is a prepared list where items may be marked as added, modified or deleted.",
            "comment": "This element is labeled as a modifier because a change list must not be misunderstood as a complete list.",
            "requirements": "Sections are used in various ways, and it must be known in what way it is safe to use the entries in them.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "SectionMode"
                }
              ],
              "strength": "required",
              "description": "The processing mode that applies to this section.",
              "valueSet": "http://hl7.org/fhir/ValueSet/list-mode|4.0.0"
            }
          },
          {
            "id": "Composition.section.orderedBy",
            "path": "Composition.section.orderedBy",
            "short": "Order of section entries",
            "definition": "Specifies the order applied to the items in the section entries.",
            "comment": "Applications SHOULD render ordered lists in the order provided, but MAY allow users to re-order based on their own preferences as well. If there is no order specified, the order is unknown, though there may still be some order.",
            "requirements": "Important for presentation and rendering.  Lists may be sorted to place more important information first or to group related entries.",
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
                  "valueString": "SectionEntryOrder"
                }
              ],
              "strength": "preferred",
              "description": "What order applies to the items in the entry.",
              "valueSet": "http://hl7.org/fhir/ValueSet/list-order"
            }
          },
          {
            "id": "Composition.section.entry",
            "path": "Composition.section.entry",
            "short": "A reference to data that supports this section",
            "definition": "A reference to the actual resource from which the narrative in the section is derived.",
            "comment": "If there are no entries in the list, an emptyReason SHOULD be provided.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Resource"
                ]
              }
            ],
            "condition": [
              "cmp-2"
            ]
          },
          {
            "id": "Composition.section.emptyReason",
            "path": "Composition.section.emptyReason",
            "short": "Why the section is empty",
            "definition": "If the section is empty, why the list is empty. An empty section typically has some text explaining the empty reason.",
            "comment": "The various reasons for an empty section make a significant interpretation to its interpretation. Note that this code is for use when the entire section content has been suppressed, and not for when individual items are omitted - implementers may consider using a text note or a flag on an entry in these cases.",
            "requirements": "Allows capturing things like \"none exist\" or \"not asked\" which can be important for most lists.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "condition": [
              "cmp-2"
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "SectionEmptyReason"
                }
              ],
              "strength": "preferred",
              "description": "If a section is empty, why it is empty.",
              "valueSet": "http://hl7.org/fhir/ValueSet/list-empty-reason"
            }
          },
          {
            "id": "Composition.section.section",
            "path": "Composition.section.section",
            "short": "Nested Section",
            "definition": "A nested sub-section within this section.",
            "comment": "Nested sections are primarily used to help human readers navigate to particular portions of the document.",
            "min": 0,
            "max": "*",
            "contentReference": "#Composition.section",
            "condition": [
              "cmp-1"
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:469
    /// <summary>
    /// Fhir resource 'Composition'
    /// </summary>
    // 0. Composition
    public class Composition : FhirKhit.Maker.Common.Resource.ResourceBase                                                                  // MakerGen.cs:379
    {                                                                                                                                       // MakerGen.cs:380
        public class Composition_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                     // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 11. Composition.attester
            public class Type_Attester : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:379
            {                                                                                                                               // MakerGen.cs:380
                public class Type_Attester_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                           // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 12. Composition.attester.mode
                    public ElementDefinitionInfo Mode;                                                                                      // MakerGen.cs:211
                    // 13. Composition.attester.time
                    public ElementDefinitionInfo Time;                                                                                      // MakerGen.cs:211
                    // 14. Composition.attester.party
                    public ElementDefinitionInfo Party;                                                                                     // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                    public Type_Attester_Elements()                                                                                         // MakerGen.cs:387
                    {                                                                                                                       // MakerGen.cs:388
                        {                                                                                                                   // MakerGen.cs:226
                            // 12. Composition.attester.mode
                            this.Mode = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Mode",                                                                                              // MakerGen.cs:230
                                Path= "Composition.attester.mode",                                                                          // MakerGen.cs:231
                                Id = "Composition.attester.mode",                                                                           // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 13. Composition.attester.time
                            this.Time = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Time",                                                                                              // MakerGen.cs:230
                                Path= "Composition.attester.time",                                                                          // MakerGen.cs:231
                                Id = "Composition.attester.time",                                                                           // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.DateTime                                                            // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 14. Composition.attester.party
                            this.Party = new ElementDefinitionInfo                                                                          // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Party",                                                                                             // MakerGen.cs:230
                                Path= "Composition.attester.party",                                                                         // MakerGen.cs:231
                                Id = "Composition.attester.party",                                                                          // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:341
                                    {                                                                                                       // MakerGen.cs:342
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:344
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Patient",                                              // MakerGen.cs:344
                                            "http://hl7.org/fhir/StructureDefinition/RelatedPerson",                                        // MakerGen.cs:344
                                            "http://hl7.org/fhir/StructureDefinition/Practitioner",                                         // MakerGen.cs:344
                                            "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                     // MakerGen.cs:344
                                            "http://hl7.org/fhir/StructureDefinition/Organization"                                          // MakerGen.cs:344
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:345
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        base.Write(sDef);                                                                                                   // MakerGen.cs:395
                        Mode.Write(sDef);                                                                                                   // MakerGen.cs:215
                        Time.Write(sDef);                                                                                                   // MakerGen.cs:215
                        Party.Write(sDef);                                                                                                  // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:397
                }                                                                                                                           // MakerGen.cs:399
                public Type_Attester_Elements Elements                                                                                      // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    get                                                                                                                     // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:404
                        if (this.elements == null)                                                                                          // MakerGen.cs:405
                            this.elements = new Type_Attester_Elements();                                                                   // MakerGen.cs:406
                        return this.elements;                                                                                               // MakerGen.cs:407
                    }                                                                                                                       // MakerGen.cs:408
                }                                                                                                                           // MakerGen.cs:409
                Type_Attester_Elements elements;                                                                                            // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                public Type_Attester()                                                                                                      // MakerGen.cs:413
                {                                                                                                                           // MakerGen.cs:414
                }                                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:419
                {                                                                                                                           // MakerGen.cs:420
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:421
                    {                                                                                                                       // MakerGen.cs:422
                        Path = "Composition.attester",                                                                                      // MakerGen.cs:423
                        ElementId = "Composition.attester"                                                                                  // MakerGen.cs:424
                    });                                                                                                                     // MakerGen.cs:425
                    if (this.elements != null)                                                                                              // MakerGen.cs:426
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:427
                }                                                                                                                           // MakerGen.cs:428
            }                                                                                                                               // MakerGen.cs:429
            // 16. Composition.relatesTo
            public class Type_RelatesTo : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:379
            {                                                                                                                               // MakerGen.cs:380
                public class Type_RelatesTo_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                          // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 17. Composition.relatesTo.code
                    public ElementDefinitionInfo Code;                                                                                      // MakerGen.cs:211
                    // 18. Composition.relatesTo.target[x]
                    public ElementDefinitionInfo Target;                                                                                    // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                    public Type_RelatesTo_Elements()                                                                                        // MakerGen.cs:387
                    {                                                                                                                       // MakerGen.cs:388
                        {                                                                                                                   // MakerGen.cs:226
                            // 17. Composition.relatesTo.code
                            this.Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Code",                                                                                              // MakerGen.cs:230
                                Path= "Composition.relatesTo.code",                                                                         // MakerGen.cs:231
                                Id = "Composition.relatesTo.code",                                                                          // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 18. Composition.relatesTo.target[x]
                            this.Target = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Target",                                                                                            // MakerGen.cs:230
                                Path= "Composition.relatesTo.target[x]",                                                                    // MakerGen.cs:231
                                Id = "Composition.relatesTo.target[x]",                                                                     // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Identifier                                                            // MakerGen.cs:353
                                    {                                                                                                       // MakerGen.cs:354
                                    },                                                                                                      // MakerGen.cs:355
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:341
                                    {                                                                                                       // MakerGen.cs:342
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:344
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Composition"                                           // MakerGen.cs:344
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:345
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        base.Write(sDef);                                                                                                   // MakerGen.cs:395
                        Code.Write(sDef);                                                                                                   // MakerGen.cs:215
                        Target.Write(sDef);                                                                                                 // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:397
                }                                                                                                                           // MakerGen.cs:399
                public Type_RelatesTo_Elements Elements                                                                                     // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    get                                                                                                                     // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:404
                        if (this.elements == null)                                                                                          // MakerGen.cs:405
                            this.elements = new Type_RelatesTo_Elements();                                                                  // MakerGen.cs:406
                        return this.elements;                                                                                               // MakerGen.cs:407
                    }                                                                                                                       // MakerGen.cs:408
                }                                                                                                                           // MakerGen.cs:409
                Type_RelatesTo_Elements elements;                                                                                           // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                public Type_RelatesTo()                                                                                                     // MakerGen.cs:413
                {                                                                                                                           // MakerGen.cs:414
                }                                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:419
                {                                                                                                                           // MakerGen.cs:420
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:421
                    {                                                                                                                       // MakerGen.cs:422
                        Path = "Composition.relatesTo",                                                                                     // MakerGen.cs:423
                        ElementId = "Composition.relatesTo"                                                                                 // MakerGen.cs:424
                    });                                                                                                                     // MakerGen.cs:425
                    if (this.elements != null)                                                                                              // MakerGen.cs:426
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:427
                }                                                                                                                           // MakerGen.cs:428
            }                                                                                                                               // MakerGen.cs:429
            // 19. Composition.event
            public class Type_Event : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:379
            {                                                                                                                               // MakerGen.cs:380
                public class Type_Event_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                              // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 20. Composition.event.code
                    public ElementDefinitionInfo Code;                                                                                      // MakerGen.cs:211
                    // 21. Composition.event.period
                    public ElementDefinitionInfo Period;                                                                                    // MakerGen.cs:211
                    // 22. Composition.event.detail
                    public ElementDefinitionInfo Detail;                                                                                    // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                    public Type_Event_Elements()                                                                                            // MakerGen.cs:387
                    {                                                                                                                       // MakerGen.cs:388
                        {                                                                                                                   // MakerGen.cs:226
                            // 20. Composition.event.code
                            this.Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Code",                                                                                              // MakerGen.cs:230
                                Path= "Composition.event.code",                                                                             // MakerGen.cs:231
                                Id = "Composition.event.code",                                                                              // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 21. Composition.event.period
                            this.Period = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Period",                                                                                            // MakerGen.cs:230
                                Path= "Composition.event.period",                                                                           // MakerGen.cs:231
                                Id = "Composition.event.period",                                                                            // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Period                                                                // MakerGen.cs:353
                                    {                                                                                                       // MakerGen.cs:354
                                    }                                                                                                       // MakerGen.cs:355
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 22. Composition.event.detail
                            this.Detail = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Detail",                                                                                            // MakerGen.cs:230
                                Path= "Composition.event.detail",                                                                           // MakerGen.cs:231
                                Id = "Composition.event.detail",                                                                            // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:341
                                    {                                                                                                       // MakerGen.cs:342
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:344
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Resource"                                              // MakerGen.cs:344
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:345
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        base.Write(sDef);                                                                                                   // MakerGen.cs:395
                        Code.Write(sDef);                                                                                                   // MakerGen.cs:215
                        Period.Write(sDef);                                                                                                 // MakerGen.cs:215
                        Detail.Write(sDef);                                                                                                 // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:397
                }                                                                                                                           // MakerGen.cs:399
                public Type_Event_Elements Elements                                                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    get                                                                                                                     // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:404
                        if (this.elements == null)                                                                                          // MakerGen.cs:405
                            this.elements = new Type_Event_Elements();                                                                      // MakerGen.cs:406
                        return this.elements;                                                                                               // MakerGen.cs:407
                    }                                                                                                                       // MakerGen.cs:408
                }                                                                                                                           // MakerGen.cs:409
                Type_Event_Elements elements;                                                                                               // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                public Type_Event()                                                                                                         // MakerGen.cs:413
                {                                                                                                                           // MakerGen.cs:414
                }                                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:419
                {                                                                                                                           // MakerGen.cs:420
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:421
                    {                                                                                                                       // MakerGen.cs:422
                        Path = "Composition.event",                                                                                         // MakerGen.cs:423
                        ElementId = "Composition.event"                                                                                     // MakerGen.cs:424
                    });                                                                                                                     // MakerGen.cs:425
                    if (this.elements != null)                                                                                              // MakerGen.cs:426
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:427
                }                                                                                                                           // MakerGen.cs:428
            }                                                                                                                               // MakerGen.cs:429
            // 23. Composition.section
            public class Type_Section : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:379
            {                                                                                                                               // MakerGen.cs:380
                public class Type_Section_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                            // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 24. Composition.section.title
                    public ElementDefinitionInfo Title;                                                                                     // MakerGen.cs:211
                    // 25. Composition.section.code
                    public ElementDefinitionInfo Code;                                                                                      // MakerGen.cs:211
                    // 26. Composition.section.author
                    public ElementDefinitionInfo Author;                                                                                    // MakerGen.cs:211
                    // 27. Composition.section.focus
                    public ElementDefinitionInfo Focus;                                                                                     // MakerGen.cs:211
                    // 28. Composition.section.text
                    public ElementDefinitionInfo Text;                                                                                      // MakerGen.cs:211
                    // 29. Composition.section.mode
                    public ElementDefinitionInfo Mode;                                                                                      // MakerGen.cs:211
                    // 30. Composition.section.orderedBy
                    public ElementDefinitionInfo OrderedBy;                                                                                 // MakerGen.cs:211
                    // 31. Composition.section.entry
                    public ElementDefinitionInfo Entry;                                                                                     // MakerGen.cs:211
                    // 32. Composition.section.emptyReason
                    public ElementDefinitionInfo EmptyReason;                                                                               // MakerGen.cs:211
                    // 33. Composition.section.section
                    public ElementDefinitionInfo Section;                                                                                   // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                    public Type_Section_Elements()                                                                                          // MakerGen.cs:387
                    {                                                                                                                       // MakerGen.cs:388
                        {                                                                                                                   // MakerGen.cs:226
                            // 24. Composition.section.title
                            this.Title = new ElementDefinitionInfo                                                                          // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Title",                                                                                             // MakerGen.cs:230
                                Path= "Composition.section.title",                                                                          // MakerGen.cs:231
                                Id = "Composition.section.title",                                                                           // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 25. Composition.section.code
                            this.Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Code",                                                                                              // MakerGen.cs:230
                                Path= "Composition.section.code",                                                                           // MakerGen.cs:231
                                Id = "Composition.section.code",                                                                            // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 26. Composition.section.author
                            this.Author = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Author",                                                                                            // MakerGen.cs:230
                                Path= "Composition.section.author",                                                                         // MakerGen.cs:231
                                Id = "Composition.section.author",                                                                          // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:341
                                    {                                                                                                       // MakerGen.cs:342
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:344
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Practitioner",                                         // MakerGen.cs:344
                                            "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                     // MakerGen.cs:344
                                            "http://hl7.org/fhir/StructureDefinition/Device",                                               // MakerGen.cs:344
                                            "http://hl7.org/fhir/StructureDefinition/Patient",                                              // MakerGen.cs:344
                                            "http://hl7.org/fhir/StructureDefinition/RelatedPerson",                                        // MakerGen.cs:344
                                            "http://hl7.org/fhir/StructureDefinition/Organization"                                          // MakerGen.cs:344
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:345
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 27. Composition.section.focus
                            this.Focus = new ElementDefinitionInfo                                                                          // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Focus",                                                                                             // MakerGen.cs:230
                                Path= "Composition.section.focus",                                                                          // MakerGen.cs:231
                                Id = "Composition.section.focus",                                                                           // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:341
                                    {                                                                                                       // MakerGen.cs:342
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:344
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Resource"                                              // MakerGen.cs:344
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:345
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 28. Composition.section.text
                            this.Text = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Text",                                                                                              // MakerGen.cs:230
                                Path= "Composition.section.text",                                                                           // MakerGen.cs:231
                                Id = "Composition.section.text",                                                                            // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Narrative                                                             // MakerGen.cs:353
                                    {                                                                                                       // MakerGen.cs:354
                                    }                                                                                                       // MakerGen.cs:355
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 29. Composition.section.mode
                            this.Mode = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Mode",                                                                                              // MakerGen.cs:230
                                Path= "Composition.section.mode",                                                                           // MakerGen.cs:231
                                Id = "Composition.section.mode",                                                                            // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 30. Composition.section.orderedBy
                            this.OrderedBy = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "OrderedBy",                                                                                         // MakerGen.cs:230
                                Path= "Composition.section.orderedBy",                                                                      // MakerGen.cs:231
                                Id = "Composition.section.orderedBy",                                                                       // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 31. Composition.section.entry
                            this.Entry = new ElementDefinitionInfo                                                                          // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Entry",                                                                                             // MakerGen.cs:230
                                Path= "Composition.section.entry",                                                                          // MakerGen.cs:231
                                Id = "Composition.section.entry",                                                                           // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:341
                                    {                                                                                                       // MakerGen.cs:342
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:344
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Resource"                                              // MakerGen.cs:344
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:345
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 32. Composition.section.emptyReason
                            this.EmptyReason = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "EmptyReason",                                                                                       // MakerGen.cs:230
                                Path= "Composition.section.emptyReason",                                                                    // MakerGen.cs:231
                                Id = "Composition.section.emptyReason",                                                                     // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 33. Composition.section.section
                            this.Section = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Section",                                                                                           // MakerGen.cs:230
                                Path= "Composition.section.section",                                                                        // MakerGen.cs:231
                                Id = "Composition.section.section",                                                                         // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        base.Write(sDef);                                                                                                   // MakerGen.cs:395
                        Title.Write(sDef);                                                                                                  // MakerGen.cs:215
                        Code.Write(sDef);                                                                                                   // MakerGen.cs:215
                        Author.Write(sDef);                                                                                                 // MakerGen.cs:215
                        Focus.Write(sDef);                                                                                                  // MakerGen.cs:215
                        Text.Write(sDef);                                                                                                   // MakerGen.cs:215
                        Mode.Write(sDef);                                                                                                   // MakerGen.cs:215
                        OrderedBy.Write(sDef);                                                                                              // MakerGen.cs:215
                        Entry.Write(sDef);                                                                                                  // MakerGen.cs:215
                        EmptyReason.Write(sDef);                                                                                            // MakerGen.cs:215
                        Section.Write(sDef);                                                                                                // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:397
                }                                                                                                                           // MakerGen.cs:399
                public Type_Section_Elements Elements                                                                                       // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    get                                                                                                                     // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:404
                        if (this.elements == null)                                                                                          // MakerGen.cs:405
                            this.elements = new Type_Section_Elements();                                                                    // MakerGen.cs:406
                        return this.elements;                                                                                               // MakerGen.cs:407
                    }                                                                                                                       // MakerGen.cs:408
                }                                                                                                                           // MakerGen.cs:409
                Type_Section_Elements elements;                                                                                             // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                public Type_Section()                                                                                                       // MakerGen.cs:413
                {                                                                                                                           // MakerGen.cs:414
                }                                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:419
                {                                                                                                                           // MakerGen.cs:420
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:421
                    {                                                                                                                       // MakerGen.cs:422
                        Path = "Composition.section",                                                                                       // MakerGen.cs:423
                        ElementId = "Composition.section"                                                                                   // MakerGen.cs:424
                    });                                                                                                                     // MakerGen.cs:425
                    if (this.elements != null)                                                                                              // MakerGen.cs:426
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:427
                }                                                                                                                           // MakerGen.cs:428
            }                                                                                                                               // MakerGen.cs:429
            // 1. Composition.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:211
            // 2. Composition.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:211
            // 3. Composition.type
            public ElementDefinitionInfo Type;                                                                                              // MakerGen.cs:211
            // 4. Composition.category
            public ElementDefinitionInfo Category;                                                                                          // MakerGen.cs:211
            // 5. Composition.subject
            public ElementDefinitionInfo Subject;                                                                                           // MakerGen.cs:211
            // 6. Composition.encounter
            public ElementDefinitionInfo Encounter;                                                                                         // MakerGen.cs:211
            // 7. Composition.date
            public ElementDefinitionInfo Date;                                                                                              // MakerGen.cs:211
            // 8. Composition.author
            public ElementDefinitionInfo Author;                                                                                            // MakerGen.cs:211
            // 9. Composition.title
            public ElementDefinitionInfo Title;                                                                                             // MakerGen.cs:211
            // 10. Composition.confidentiality
            public ElementDefinitionInfo Confidentiality;                                                                                   // MakerGen.cs:211
            // 11. Composition.attester
            public ElementDefinitionInfo Attester;                                                                                          // MakerGen.cs:211
            // 15. Composition.custodian
            public ElementDefinitionInfo Custodian;                                                                                         // MakerGen.cs:211
            // 16. Composition.relatesTo
            public ElementDefinitionInfo RelatesTo;                                                                                         // MakerGen.cs:211
            // 19. Composition.event
            public ElementDefinitionInfo Event;                                                                                             // MakerGen.cs:211
            // 23. Composition.section
            public ElementDefinitionInfo Section;                                                                                           // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
            public Composition_Elements()                                                                                                   // MakerGen.cs:387
            {                                                                                                                               // MakerGen.cs:388
                {                                                                                                                           // MakerGen.cs:226
                    // 1. Composition.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Identifier",                                                                                                // MakerGen.cs:230
                        Path= "Composition.identifier",                                                                                     // MakerGen.cs:231
                        Id = "Composition.identifier",                                                                                      // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 2. Composition.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Status",                                                                                                    // MakerGen.cs:230
                        Path= "Composition.status",                                                                                         // MakerGen.cs:231
                        Id = "Composition.status",                                                                                          // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 3. Composition.type
                    this.Type = new ElementDefinitionInfo                                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Type",                                                                                                      // MakerGen.cs:230
                        Path= "Composition.type",                                                                                           // MakerGen.cs:231
                        Id = "Composition.type",                                                                                            // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 4. Composition.category
                    this.Category = new ElementDefinitionInfo                                                                               // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Category",                                                                                                  // MakerGen.cs:230
                        Path= "Composition.category",                                                                                       // MakerGen.cs:231
                        Id = "Composition.category",                                                                                        // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 5. Composition.subject
                    this.Subject = new ElementDefinitionInfo                                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Subject",                                                                                                   // MakerGen.cs:230
                        Path= "Composition.subject",                                                                                        // MakerGen.cs:231
                        Id = "Composition.subject",                                                                                         // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Resource"                                                      // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 6. Composition.encounter
                    this.Encounter = new ElementDefinitionInfo                                                                              // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Encounter",                                                                                                 // MakerGen.cs:230
                        Path= "Composition.encounter",                                                                                      // MakerGen.cs:231
                        Id = "Composition.encounter",                                                                                       // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Encounter"                                                     // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 7. Composition.date
                    this.Date = new ElementDefinitionInfo                                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Date",                                                                                                      // MakerGen.cs:230
                        Path= "Composition.date",                                                                                           // MakerGen.cs:231
                        Id = "Composition.date",                                                                                            // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 8. Composition.author
                    this.Author = new ElementDefinitionInfo                                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Author",                                                                                                    // MakerGen.cs:230
                        Path= "Composition.author",                                                                                         // MakerGen.cs:231
                        Id = "Composition.author",                                                                                          // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:344
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:344
                                    "http://hl7.org/fhir/StructureDefinition/Device",                                                       // MakerGen.cs:344
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:344
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson",                                                // MakerGen.cs:344
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 9. Composition.title
                    this.Title = new ElementDefinitionInfo                                                                                  // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Title",                                                                                                     // MakerGen.cs:230
                        Path= "Composition.title",                                                                                          // MakerGen.cs:231
                        Id = "Composition.title",                                                                                           // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 10. Composition.confidentiality
                    this.Confidentiality = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Confidentiality",                                                                                           // MakerGen.cs:230
                        Path= "Composition.confidentiality",                                                                                // MakerGen.cs:231
                        Id = "Composition.confidentiality",                                                                                 // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 11. Composition.attester
                    this.Attester = new ElementDefinitionInfo                                                                               // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Attester",                                                                                                  // MakerGen.cs:230
                        Path= "Composition.attester",                                                                                       // MakerGen.cs:231
                        Id = "Composition.attester",                                                                                        // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Attester                                                                                               // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 15. Composition.custodian
                    this.Custodian = new ElementDefinitionInfo                                                                              // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Custodian",                                                                                                 // MakerGen.cs:230
                        Path= "Composition.custodian",                                                                                      // MakerGen.cs:231
                        Id = "Composition.custodian",                                                                                       // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 16. Composition.relatesTo
                    this.RelatesTo = new ElementDefinitionInfo                                                                              // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "RelatesTo",                                                                                                 // MakerGen.cs:230
                        Path= "Composition.relatesTo",                                                                                      // MakerGen.cs:231
                        Id = "Composition.relatesTo",                                                                                       // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_RelatesTo                                                                                              // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 19. Composition.event
                    this.Event = new ElementDefinitionInfo                                                                                  // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Event",                                                                                                     // MakerGen.cs:230
                        Path= "Composition.event",                                                                                          // MakerGen.cs:231
                        Id = "Composition.event",                                                                                           // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Event                                                                                                  // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 23. Composition.section
                    this.Section = new ElementDefinitionInfo                                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Section",                                                                                                   // MakerGen.cs:230
                        Path= "Composition.section",                                                                                        // MakerGen.cs:231
                        Id = "Composition.section",                                                                                         // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Section                                                                                                // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                base.Write(sDef);                                                                                                           // MakerGen.cs:395
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:215
                Status.Write(sDef);                                                                                                         // MakerGen.cs:215
                Type.Write(sDef);                                                                                                           // MakerGen.cs:215
                Category.Write(sDef);                                                                                                       // MakerGen.cs:215
                Subject.Write(sDef);                                                                                                        // MakerGen.cs:215
                Encounter.Write(sDef);                                                                                                      // MakerGen.cs:215
                Date.Write(sDef);                                                                                                           // MakerGen.cs:215
                Author.Write(sDef);                                                                                                         // MakerGen.cs:215
                Title.Write(sDef);                                                                                                          // MakerGen.cs:215
                Confidentiality.Write(sDef);                                                                                                // MakerGen.cs:215
                Attester.Write(sDef);                                                                                                       // MakerGen.cs:215
                Custodian.Write(sDef);                                                                                                      // MakerGen.cs:215
                RelatesTo.Write(sDef);                                                                                                      // MakerGen.cs:215
                Event.Write(sDef);                                                                                                          // MakerGen.cs:215
                Section.Write(sDef);                                                                                                        // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:397
        }                                                                                                                                   // MakerGen.cs:399
        public Composition_Elements Elements                                                                                                // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            get                                                                                                                             // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:404
                if (this.elements == null)                                                                                                  // MakerGen.cs:405
                    this.elements = new Composition_Elements();                                                                             // MakerGen.cs:406
                return this.elements;                                                                                                       // MakerGen.cs:407
            }                                                                                                                               // MakerGen.cs:408
        }                                                                                                                                   // MakerGen.cs:409
        Composition_Elements elements;                                                                                                      // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
        public Composition()                                                                                                                // MakerGen.cs:413
        {                                                                                                                                   // MakerGen.cs:414
            this.Name = "Composition";                                                                                                      // MakerGen.cs:487
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Composition";                                                               // MakerGen.cs:488
        }                                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:419
        {                                                                                                                                   // MakerGen.cs:420
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:421
            {                                                                                                                               // MakerGen.cs:422
                Path = "Composition",                                                                                                       // MakerGen.cs:423
                ElementId = "Composition"                                                                                                   // MakerGen.cs:424
            });                                                                                                                             // MakerGen.cs:425
            if (this.elements != null)                                                                                                      // MakerGen.cs:426
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:427
        }                                                                                                                                   // MakerGen.cs:428
    }                                                                                                                                       // MakerGen.cs:429
}                                                                                                                                           // MakerGen.cs:474
