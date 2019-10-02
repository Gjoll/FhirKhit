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
    #endregion
    /// <summary>
    /// Fhir resource 'Composition'
    /// </summary>
    // 0. Composition
    public class Resource_Composition : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 11. Composition.attester
        public class Type_Attester : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 12. Composition.attester.mode
            public ElementDefinitionInfo Element_Mode;
            // 13. Composition.attester.time
            public ElementDefinitionInfo Element_Time;
            // 14. Composition.attester.party
            public ElementDefinitionInfo Element_Party;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Composition.attester",
                    ElementId = "Composition.attester"
                });
                Element_Mode.Write(sDef);
                Element_Time.Write(sDef);
                Element_Party.Write(sDef);
            }
            
            public Type_Attester()
            {
                {
                    // 12. Composition.attester.mode
                    this.Element_Mode = new ElementDefinitionInfo
                    {
                        Name = "Element_Mode",
                        Path= "Composition.attester.mode",
                        Id = "Composition.attester.mode",
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
                    // 13. Composition.attester.time
                    this.Element_Time = new ElementDefinitionInfo
                    {
                        Name = "Element_Time",
                        Path= "Composition.attester.time",
                        Id = "Composition.attester.time",
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
                    // 14. Composition.attester.party
                    this.Element_Party = new ElementDefinitionInfo
                    {
                        Name = "Element_Party",
                        Path= "Composition.attester.party",
                        Id = "Composition.attester.party",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Patient",
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                                    "http://hl7.org/fhir/StructureDefinition/Organization"
                                }
                            }
                        }
                    };
                }
            }
        }
        // 16. Composition.relatesTo
        public class Type_RelatesTo : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 17. Composition.relatesTo.code
            public ElementDefinitionInfo Element_Code;
            // 18. Composition.relatesTo.target[x]
            public ElementDefinitionInfo Element_Target;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Composition.relatesTo",
                    ElementId = "Composition.relatesTo"
                });
                Element_Code.Write(sDef);
                Element_Target.Write(sDef);
            }
            
            public Type_RelatesTo()
            {
                {
                    // 17. Composition.relatesTo.code
                    this.Element_Code = new ElementDefinitionInfo
                    {
                        Name = "Element_Code",
                        Path= "Composition.relatesTo.code",
                        Id = "Composition.relatesTo.code",
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
                    // 18. Composition.relatesTo.target[x]
                    this.Element_Target = new ElementDefinitionInfo
                    {
                        Name = "Element_Target",
                        Path= "Composition.relatesTo.target[x]",
                        Id = "Composition.relatesTo.target[x]",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Identifier
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Composition"
                                }
                            }
                        }
                    };
                }
            }
        }
        // 19. Composition.event
        public class Type_Event : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 20. Composition.event.code
            public ElementDefinitionInfo Element_Code;
            // 21. Composition.event.period
            public ElementDefinitionInfo Element_Period;
            // 22. Composition.event.detail
            public ElementDefinitionInfo Element_Detail;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Composition.event",
                    ElementId = "Composition.event"
                });
                Element_Code.Write(sDef);
                Element_Period.Write(sDef);
                Element_Detail.Write(sDef);
            }
            
            public Type_Event()
            {
                {
                    // 20. Composition.event.code
                    this.Element_Code = new ElementDefinitionInfo
                    {
                        Name = "Element_Code",
                        Path= "Composition.event.code",
                        Id = "Composition.event.code",
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
                    // 21. Composition.event.period
                    this.Element_Period = new ElementDefinitionInfo
                    {
                        Name = "Element_Period",
                        Path= "Composition.event.period",
                        Id = "Composition.event.period",
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
                    // 22. Composition.event.detail
                    this.Element_Detail = new ElementDefinitionInfo
                    {
                        Name = "Element_Detail",
                        Path= "Composition.event.detail",
                        Id = "Composition.event.detail",
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
        // 23. Composition.section
        public class Type_Section : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 24. Composition.section.title
            public ElementDefinitionInfo Element_Title;
            // 25. Composition.section.code
            public ElementDefinitionInfo Element_Code;
            // 26. Composition.section.author
            public ElementDefinitionInfo Element_Author;
            // 27. Composition.section.focus
            public ElementDefinitionInfo Element_Focus;
            // 28. Composition.section.text
            public ElementDefinitionInfo Element_Text;
            // 29. Composition.section.mode
            public ElementDefinitionInfo Element_Mode;
            // 30. Composition.section.orderedBy
            public ElementDefinitionInfo Element_OrderedBy;
            // 31. Composition.section.entry
            public ElementDefinitionInfo Element_Entry;
            // 32. Composition.section.emptyReason
            public ElementDefinitionInfo Element_EmptyReason;
            // 33. Composition.section.section
            public ElementDefinitionInfo Element_Section;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Composition.section",
                    ElementId = "Composition.section"
                });
                Element_Title.Write(sDef);
                Element_Code.Write(sDef);
                Element_Author.Write(sDef);
                Element_Focus.Write(sDef);
                Element_Text.Write(sDef);
                Element_Mode.Write(sDef);
                Element_OrderedBy.Write(sDef);
                Element_Entry.Write(sDef);
                Element_EmptyReason.Write(sDef);
                Element_Section.Write(sDef);
            }
            
            public Type_Section()
            {
                {
                    // 24. Composition.section.title
                    this.Element_Title = new ElementDefinitionInfo
                    {
                        Name = "Element_Title",
                        Path= "Composition.section.title",
                        Id = "Composition.section.title",
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
                    // 25. Composition.section.code
                    this.Element_Code = new ElementDefinitionInfo
                    {
                        Name = "Element_Code",
                        Path= "Composition.section.code",
                        Id = "Composition.section.code",
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
                    // 26. Composition.section.author
                    this.Element_Author = new ElementDefinitionInfo
                    {
                        Name = "Element_Author",
                        Path= "Composition.section.author",
                        Id = "Composition.section.author",
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
                                    "http://hl7.org/fhir/StructureDefinition/Device",
                                    "http://hl7.org/fhir/StructureDefinition/Patient",
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                                    "http://hl7.org/fhir/StructureDefinition/Organization"
                                }
                            }
                        }
                    };
                }
                {
                    // 27. Composition.section.focus
                    this.Element_Focus = new ElementDefinitionInfo
                    {
                        Name = "Element_Focus",
                        Path= "Composition.section.focus",
                        Id = "Composition.section.focus",
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
                {
                    // 28. Composition.section.text
                    this.Element_Text = new ElementDefinitionInfo
                    {
                        Name = "Element_Text",
                        Path= "Composition.section.text",
                        Id = "Composition.section.text",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Narrative
                            {
                            }
                        }
                    };
                }
                {
                    // 29. Composition.section.mode
                    this.Element_Mode = new ElementDefinitionInfo
                    {
                        Name = "Element_Mode",
                        Path= "Composition.section.mode",
                        Id = "Composition.section.mode",
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
                    // 30. Composition.section.orderedBy
                    this.Element_OrderedBy = new ElementDefinitionInfo
                    {
                        Name = "Element_OrderedBy",
                        Path= "Composition.section.orderedBy",
                        Id = "Composition.section.orderedBy",
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
                    // 31. Composition.section.entry
                    this.Element_Entry = new ElementDefinitionInfo
                    {
                        Name = "Element_Entry",
                        Path= "Composition.section.entry",
                        Id = "Composition.section.entry",
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
                {
                    // 32. Composition.section.emptyReason
                    this.Element_EmptyReason = new ElementDefinitionInfo
                    {
                        Name = "Element_EmptyReason",
                        Path= "Composition.section.emptyReason",
                        Id = "Composition.section.emptyReason",
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
                    // 33. Composition.section.section
                    this.Element_Section = new ElementDefinitionInfo
                    {
                        Name = "Element_Section",
                        Path= "Composition.section.section",
                        Id = "Composition.section.section",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                        }
                    };
                }
            }
        }
        // 1. Composition.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. Composition.status
        public ElementDefinitionInfo Element_Status;
        // 3. Composition.type
        public ElementDefinitionInfo Element_Type;
        // 4. Composition.category
        public ElementDefinitionInfo Element_Category;
        // 5. Composition.subject
        public ElementDefinitionInfo Element_Subject;
        // 6. Composition.encounter
        public ElementDefinitionInfo Element_Encounter;
        // 7. Composition.date
        public ElementDefinitionInfo Element_Date;
        // 8. Composition.author
        public ElementDefinitionInfo Element_Author;
        // 9. Composition.title
        public ElementDefinitionInfo Element_Title;
        // 10. Composition.confidentiality
        public ElementDefinitionInfo Element_Confidentiality;
        // 11. Composition.attester
        public ElementDefinitionInfo Element_Attester;
        // 15. Composition.custodian
        public ElementDefinitionInfo Element_Custodian;
        // 16. Composition.relatesTo
        public ElementDefinitionInfo Element_RelatesTo;
        // 19. Composition.event
        public ElementDefinitionInfo Element_Event;
        // 23. Composition.section
        public ElementDefinitionInfo Element_Section;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "Composition",
                ElementId = "Composition"
            });
            Element_Identifier.Write(sDef);
            Element_Status.Write(sDef);
            Element_Type.Write(sDef);
            Element_Category.Write(sDef);
            Element_Subject.Write(sDef);
            Element_Encounter.Write(sDef);
            Element_Date.Write(sDef);
            Element_Author.Write(sDef);
            Element_Title.Write(sDef);
            Element_Confidentiality.Write(sDef);
            Element_Attester.Write(sDef);
            Element_Custodian.Write(sDef);
            Element_RelatesTo.Write(sDef);
            Element_Event.Write(sDef);
            Element_Section.Write(sDef);
        }
        
        public Resource_Composition()
        {
            {
                // 1. Composition.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "Composition.identifier",
                    Id = "Composition.identifier",
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
                // 2. Composition.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "Composition.status",
                    Id = "Composition.status",
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
                // 3. Composition.type
                this.Element_Type = new ElementDefinitionInfo
                {
                    Name = "Element_Type",
                    Path= "Composition.type",
                    Id = "Composition.type",
                    Min = 1,
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
                // 4. Composition.category
                this.Element_Category = new ElementDefinitionInfo
                {
                    Name = "Element_Category",
                    Path= "Composition.category",
                    Id = "Composition.category",
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
                // 5. Composition.subject
                this.Element_Subject = new ElementDefinitionInfo
                {
                    Name = "Element_Subject",
                    Path= "Composition.subject",
                    Id = "Composition.subject",
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
            {
                // 6. Composition.encounter
                this.Element_Encounter = new ElementDefinitionInfo
                {
                    Name = "Element_Encounter",
                    Path= "Composition.encounter",
                    Id = "Composition.encounter",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Encounter"
                            }
                        }
                    }
                };
            }
            {
                // 7. Composition.date
                this.Element_Date = new ElementDefinitionInfo
                {
                    Name = "Element_Date",
                    Path= "Composition.date",
                    Id = "Composition.date",
                    Min = 1,
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
                // 8. Composition.author
                this.Element_Author = new ElementDefinitionInfo
                {
                    Name = "Element_Author",
                    Path= "Composition.author",
                    Id = "Composition.author",
                    Min = 1,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                                "http://hl7.org/fhir/StructureDefinition/Device",
                                "http://hl7.org/fhir/StructureDefinition/Patient",
                                "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                                "http://hl7.org/fhir/StructureDefinition/Organization"
                            }
                        }
                    }
                };
            }
            {
                // 9. Composition.title
                this.Element_Title = new ElementDefinitionInfo
                {
                    Name = "Element_Title",
                    Path= "Composition.title",
                    Id = "Composition.title",
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
                // 10. Composition.confidentiality
                this.Element_Confidentiality = new ElementDefinitionInfo
                {
                    Name = "Element_Confidentiality",
                    Path= "Composition.confidentiality",
                    Id = "Composition.confidentiality",
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
                // 11. Composition.attester
                this.Element_Attester = new ElementDefinitionInfo
                {
                    Name = "Element_Attester",
                    Path= "Composition.attester",
                    Id = "Composition.attester",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Attester
                        {
                        }
                    }
                };
            }
            {
                // 15. Composition.custodian
                this.Element_Custodian = new ElementDefinitionInfo
                {
                    Name = "Element_Custodian",
                    Path= "Composition.custodian",
                    Id = "Composition.custodian",
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
                // 16. Composition.relatesTo
                this.Element_RelatesTo = new ElementDefinitionInfo
                {
                    Name = "Element_RelatesTo",
                    Path= "Composition.relatesTo",
                    Id = "Composition.relatesTo",
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
                // 19. Composition.event
                this.Element_Event = new ElementDefinitionInfo
                {
                    Name = "Element_Event",
                    Path= "Composition.event",
                    Id = "Composition.event",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Event
                        {
                        }
                    }
                };
            }
            {
                // 23. Composition.section
                this.Element_Section = new ElementDefinitionInfo
                {
                    Name = "Element_Section",
                    Path= "Composition.section",
                    Id = "Composition.section",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Section
                        {
                        }
                    }
                };
            }
            this.Name = "Composition";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Composition";
        }
    }
}
