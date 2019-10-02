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
      "id": "ImagingStudy",
      "url": "http://hl7.org/fhir/StructureDefinition/ImagingStudy",
      "version": "4.0.0",
      "name": "ImagingStudy",
      "status": "draft",
      "publisher": "Health Level Seven International (Imaging Integration)",
      "description": "Representation of the content produced in a DICOM imaging study. A study comprises a set of series, each of which includes a set of Service-Object Pair Instances (SOP Instances - images or other data) acquired or produced in a common context.  A series is of only one modality (e.g. X-ray, CT, MR, ultrasound), but a study may have multiple series of different modalities.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "ImagingStudy",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "ImagingStudy",
            "path": "ImagingStudy",
            "short": "A set of images produced in single study (one or more series of references images)",
            "definition": "Representation of the content produced in a DICOM imaging study. A study comprises a set of series, each of which includes a set of Service-Object Pair Instances (SOP Instances - images or other data) acquired or produced in a common context.  A series is of only one modality (e.g. X-ray, CT, MR, ultrasound), but a study may have multiple series of different modalities.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "ImagingStudy.identifier",
            "path": "ImagingStudy.identifier",
            "short": "Identifiers for the whole study",
            "definition": "Identifiers for the ImagingStudy such as DICOM Study Instance UID, and Accession Number.",
            "comment": "See discussion under [Imaging Study Implementation Notes](imagingstudy.html#notes) for encoding of DICOM Study Instance UID. Accession Number should use ACSN Identifier type.",
            "requirements": "If one or more series elements are present in the ImagingStudy, then there shall be one DICOM Study UID identifier (see [DICOM PS 3.3 C.7.2](http://dicom.nema.org/medical/dicom/current/output/chtml/part03/sect_C.7.2.html).",
            "alias": [
              "StudyInstanceUID",
              "AccessionNumber"
            ],
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
            "id": "ImagingStudy.status",
            "path": "ImagingStudy.status",
            "short": "registered | available | cancelled | entered-in-error | unknown",
            "definition": "The current state of the ImagingStudy.",
            "comment": "Unknown does not represent \"other\" - one of the defined statuses must apply.  Unknown is used when the authoring system is not sure what the current status is.",
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
                  "valueString": "ImagingStudyStatus"
                }
              ],
              "strength": "required",
              "description": "The status of the ImagingStudy.",
              "valueSet": "http://hl7.org/fhir/ValueSet/imagingstudy-status|4.0.0"
            }
          },
          {
            "id": "ImagingStudy.modality",
            "path": "ImagingStudy.modality",
            "short": "All series modality if actual acquisition modalities",
            "definition": "A list of all the series.modality values that are actual acquisition modalities, i.e. those in the DICOM Context Group 29 (value set OID 1.2.840.10008.6.1.19).",
            "alias": [
              "ModalitiesInStudy"
            ],
            "min": 0,
            "max": "*",
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
                  "valueString": "ImagingModality"
                }
              ],
              "strength": "extensible",
              "description": "Type of acquired data in the instance.",
              "valueSet": "http://dicom.nema.org/medical/dicom/current/output/chtml/part16/sect_CID_29.html"
            }
          },
          {
            "id": "ImagingStudy.subject",
            "path": "ImagingStudy.subject",
            "short": "Who or what is the subject of the study",
            "definition": "The subject, typically a patient, of the imaging study.",
            "comment": "QA phantoms can be recorded with a Device; multiple subjects (such as mice) can be recorded with a Group.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/Group"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "ImagingStudy.encounter",
            "path": "ImagingStudy.encounter",
            "short": "Encounter with which this imaging study is associated",
            "definition": "The healthcare event (e.g. a patient and healthcare provider interaction) during which this ImagingStudy is made.",
            "comment": "This will typically be the encounter the event occurred within, but some events may be initiated prior to or after the official completion of an encounter but still be tied to the context of the encounter (e.g. pre-admission test).",
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
            "id": "ImagingStudy.started",
            "path": "ImagingStudy.started",
            "short": "When the study was started",
            "definition": "Date and time the study started.",
            "alias": [
              "StudyDate",
              "StudyTime"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ],
            "example": [
              {
                "label": "General",
                "valueDateTime": "2011-01-01T11:01:20+03:00"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ImagingStudy.basedOn",
            "path": "ImagingStudy.basedOn",
            "short": "Request fulfilled",
            "definition": "A list of the diagnostic requests that resulted in this imaging study being performed.",
            "requirements": "To support grouped procedures (one imaging study supporting multiple ordered procedures, e.g. chest/abdomen/pelvis CT).",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/CarePlan",
                  "http://hl7.org/fhir/StructureDefinition/ServiceRequest",
                  "http://hl7.org/fhir/StructureDefinition/Appointment",
                  "http://hl7.org/fhir/StructureDefinition/AppointmentResponse",
                  "http://hl7.org/fhir/StructureDefinition/Task"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "ImagingStudy.referrer",
            "path": "ImagingStudy.referrer",
            "short": "Referring physician",
            "definition": "The requesting/referring physician.",
            "alias": [
              "ReferringPhysiciansName"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "ImagingStudy.interpreter",
            "path": "ImagingStudy.interpreter",
            "short": "Who interpreted images",
            "definition": "Who read the study and interpreted the images or other content.",
            "alias": [
              "Name of Physician(s) Reading Study"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "ImagingStudy.endpoint",
            "path": "ImagingStudy.endpoint",
            "short": "Study access endpoint",
            "definition": "The network service providing access (e.g., query, view, or retrieval) for the study. See implementation notes for information about using DICOM endpoints. A study-level endpoint applies to each series in the study, unless overridden by a series-level endpoint with the same Endpoint.connectionType.",
            "comment": "Typical endpoint types include DICOM WADO-RS, which is used to retrieve DICOM instances in native or rendered (e.g., JPG, PNG), formats using a RESTful API; DICOM WADO-URI, which can similarly retrieve native or rendered instances, except using an HTTP query-based approach; DICOM QIDO-RS, which allows RESTful query for DICOM information without retrieving the actual instances; or IHE Invoke Image Display (IID), which provides standard invocation of an imaging web viewer.",
            "requirements": "Access methods for viewing (e.g., IHE’s IID profile) or retrieving (e.g., DICOM’s WADO-URI and WADO-RS) the study or the study’s series or instances. The study-level baseLocation applies to each series in the study, unless overridden in series by a series-level baseLocation of the same type.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Endpoint"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "ImagingStudy.numberOfSeries",
            "path": "ImagingStudy.numberOfSeries",
            "short": "Number of Study Related Series",
            "definition": "Number of Series in the Study. This value given may be larger than the number of series elements this Resource contains due to resource availability, security, or other factors. This element should be present if any series elements are present.",
            "alias": [
              "NumberOfStudyRelatedSeries"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "unsignedInt"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ImagingStudy.numberOfInstances",
            "path": "ImagingStudy.numberOfInstances",
            "short": "Number of Study Related Instances",
            "definition": "Number of SOP Instances in Study. This value given may be larger than the number of instance elements this resource contains due to resource availability, security, or other factors. This element should be present if any instance elements are present.",
            "alias": [
              "NumberOfStudyRelatedInstances"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "unsignedInt"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ImagingStudy.procedureReference",
            "path": "ImagingStudy.procedureReference",
            "short": "The performed Procedure reference",
            "definition": "The procedure which this ImagingStudy was part of.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Procedure"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "ImagingStudy.procedureCode",
            "path": "ImagingStudy.procedureCode",
            "short": "The performed procedure code",
            "definition": "The code for the performed procedure type.",
            "alias": [
              "ProcedureCodeSequence"
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
                  "valueString": "ImagingProcedureCode"
                }
              ],
              "strength": "extensible",
              "description": "The performed procedure type.",
              "valueSet": "http://www.rsna.org/RadLex_Playbook.aspx"
            }
          },
          {
            "id": "ImagingStudy.location",
            "path": "ImagingStudy.location",
            "short": "Where ImagingStudy occurred",
            "definition": "The principal physical location where the ImagingStudy was performed.",
            "requirements": "Ties the event to where the records are likely kept and provides context around the event occurrence (e.g. if it occurred inside or outside a dedicated healthcare setting).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Location"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "ImagingStudy.reasonCode",
            "path": "ImagingStudy.reasonCode",
            "short": "Why the study was requested",
            "definition": "Description of clinical condition indicating why the ImagingStudy was requested.",
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
                  "valueString": "ImagingReason"
                }
              ],
              "strength": "example",
              "description": "The reason for the study.",
              "valueSet": "http://hl7.org/fhir/ValueSet/procedure-reason"
            }
          },
          {
            "id": "ImagingStudy.reasonReference",
            "path": "ImagingStudy.reasonReference",
            "short": "Why was study performed",
            "definition": "Indicates another resource whose existence justifies this Study.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Condition",
                  "http://hl7.org/fhir/StructureDefinition/Observation",
                  "http://hl7.org/fhir/StructureDefinition/Media",
                  "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",
                  "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "ImagingStudy.note",
            "path": "ImagingStudy.note",
            "short": "User-defined comments",
            "definition": "Per the recommended DICOM mapping, this element is derived from the Study Description attribute (0008,1030). Observations or findings about the imaging study should be recorded in another resource, e.g. Observation, and not in this element.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Annotation"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ImagingStudy.description",
            "path": "ImagingStudy.description",
            "short": "Institution-generated description",
            "definition": "The Imaging Manager description of the study. Institution-generated description or classification of the Study (component) performed.",
            "alias": [
              "StudyDescription"
            ],
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
            "id": "ImagingStudy.series",
            "path": "ImagingStudy.series",
            "short": "Each study has one or more series of instances",
            "definition": "Each study has one or more series of images or other content.",
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
            "id": "ImagingStudy.series.uid",
            "path": "ImagingStudy.series.uid",
            "short": "DICOM Series Instance UID for the series",
            "definition": "The DICOM Series Instance UID for the series.",
            "comment": "See [DICOM PS3.3 C.7.3](http://dicom.nema.org/medical/dicom/current/output/chtml/part03/sect_C.7.3.html).",
            "requirements": "DICOM Series Instance UID.",
            "alias": [
              "SeriesInstanceUID"
            ],
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "id"
              }
            ],
            "example": [
              {
                "label": "General",
                "valueId": "2.16.124.113543.6003.2588828330.45298.17418.2723805630"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ImagingStudy.series.number",
            "path": "ImagingStudy.series.number",
            "short": "Numeric identifier of this series",
            "definition": "The numeric identifier of this series in the study.",
            "alias": [
              "SeriesNumber"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "unsignedInt"
              }
            ],
            "example": [
              {
                "label": "General",
                "valueUnsignedInt": 3
              }
            ],
            "isSummary": true
          },
          {
            "id": "ImagingStudy.series.modality",
            "path": "ImagingStudy.series.modality",
            "short": "The modality of the instances in the series",
            "definition": "The modality of this series sequence.",
            "alias": [
              "Modality"
            ],
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
                  "valueString": "ImagingModality"
                }
              ],
              "strength": "extensible",
              "description": "Type of acquired data in the instance.",
              "valueSet": "http://dicom.nema.org/medical/dicom/current/output/chtml/part16/sect_CID_29.html"
            }
          },
          {
            "id": "ImagingStudy.series.description",
            "path": "ImagingStudy.series.description",
            "short": "A short human readable summary of the series",
            "definition": "A description of the series.",
            "alias": [
              "SeriesDescription"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "example": [
              {
                "label": "General",
                "valueString": "CT Surview 180"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ImagingStudy.series.numberOfInstances",
            "path": "ImagingStudy.series.numberOfInstances",
            "short": "Number of Series Related Instances",
            "definition": "Number of SOP Instances in the Study. The value given may be larger than the number of instance elements this resource contains due to resource availability, security, or other factors. This element should be present if any instance elements are present.",
            "alias": [
              "NumberOfSeriesRelatedInstances"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "unsignedInt"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ImagingStudy.series.endpoint",
            "path": "ImagingStudy.series.endpoint",
            "short": "Series access endpoint",
            "definition": "The network service providing access (e.g., query, view, or retrieval) for this series. See implementation notes for information about using DICOM endpoints. A series-level endpoint, if present, has precedence over a study-level endpoint with the same Endpoint.connectionType.",
            "comment": "Typical endpoint types include DICOM WADO-RS, which is used to retrieve DICOM instances in native or rendered (e.g., JPG, PNG) formats using a RESTful API; DICOM WADO-URI, which can similarly retrieve native or rendered instances, except using an HTTP query-based approach; and DICOM QIDO-RS, which allows RESTful query for DICOM information without retrieving the actual instances.",
            "requirements": "Access methods for retrieving (e.g., DICOM’s WADO-URI and WADO-RS) the series or the series’ instances. A baseLocation specified at the series level has precedence over a baseLocation of the same type specified at the study level.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Endpoint"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "ImagingStudy.series.bodySite",
            "path": "ImagingStudy.series.bodySite",
            "short": "Body part examined",
            "definition": "The anatomic structures examined. See DICOM Part 16 Annex L (http://dicom.nema.org/medical/dicom/current/output/chtml/part16/chapter_L.html) for DICOM to SNOMED-CT mappings. The bodySite may indicate the laterality of body part imaged; if so, it shall be consistent with any content of ImagingStudy.series.laterality.",
            "alias": [
              "BodyPartExamined"
            ],
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
                  "valueString": "BodySite"
                }
              ],
              "strength": "example",
              "description": "Codes describing anatomical locations. May include laterality.",
              "valueSet": "http://hl7.org/fhir/ValueSet/body-site"
            }
          },
          {
            "id": "ImagingStudy.series.laterality",
            "path": "ImagingStudy.series.laterality",
            "short": "Body part laterality",
            "definition": "The laterality of the (possibly paired) anatomic structures examined. E.g., the left knee, both lungs, or unpaired abdomen. If present, shall be consistent with any laterality information indicated in ImagingStudy.series.bodySite.",
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
                  "valueString": "Laterality"
                }
              ],
              "strength": "example",
              "description": "Codes describing body site laterality (left, right, etc.).",
              "valueSet": "http://hl7.org/fhir/ValueSet/bodysite-laterality"
            }
          },
          {
            "id": "ImagingStudy.series.specimen",
            "path": "ImagingStudy.series.specimen",
            "short": "Specimen imaged",
            "definition": "The specimen imaged, e.g., for whole slide imaging of a biopsy.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Specimen"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "ImagingStudy.series.started",
            "path": "ImagingStudy.series.started",
            "short": "When the series started",
            "definition": "The date and time the series was started.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ImagingStudy.series.performer",
            "path": "ImagingStudy.series.performer",
            "short": "Who performed the series",
            "definition": "Indicates who or what performed the series and how they were involved.",
            "comment": "If the person who performed the series is not known, their Organization may be recorded. A patient, or related person, may be the performer, e.g. for patient-captured images.",
            "requirements": "The performer is recorded at the series level, since each series in a study may be performed by a different performer, at different times, and using different devices. A series may be performed by multiple performers.",
            "alias": [
              "PerformingPhysicianName",
              "OperatorName"
            ],
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
            "id": "ImagingStudy.series.performer.function",
            "path": "ImagingStudy.series.performer.function",
            "short": "Type of performance",
            "definition": "Distinguishes the type of involvement of the performer in the series.",
            "requirements": "Allows disambiguation of the types of involvement of different performers.",
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
                  "valueString": "EventPerformerFunction"
                }
              ],
              "strength": "extensible",
              "description": "The type of involvement of the performer.",
              "valueSet": "http://hl7.org/fhir/ValueSet/series-performer-function"
            }
          },
          {
            "id": "ImagingStudy.series.performer.actor",
            "path": "ImagingStudy.series.performer.actor",
            "short": "Who performed the series",
            "definition": "Indicates who or what performed the series.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Organization",
                  "http://hl7.org/fhir/StructureDefinition/CareTeam",
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "ImagingStudy.series.instance",
            "path": "ImagingStudy.series.instance",
            "short": "A single SOP instance from the series",
            "definition": "A single SOP instance within the series, e.g. an image, or presentation state.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ImagingStudy.series.instance.uid",
            "path": "ImagingStudy.series.instance.uid",
            "short": "DICOM SOP Instance UID",
            "definition": "The DICOM SOP Instance UID for this image or other DICOM content.",
            "comment": "See  [DICOM PS3.3 C.12.1](http://dicom.nema.org/medical/dicom/current/output/chtml/part03/sect_C.12.html#sect_C.12.1).",
            "requirements": "DICOM SOP Instance UID.",
            "alias": [
              "SOPInstanceUID"
            ],
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "id"
              }
            ],
            "example": [
              {
                "label": "General",
                "valueId": "2.16.124.113543.6003.189642796.63084.16748.2599092903"
              }
            ]
          },
          {
            "id": "ImagingStudy.series.instance.sopClass",
            "path": "ImagingStudy.series.instance.sopClass",
            "short": "DICOM class type",
            "definition": "DICOM instance  type.",
            "alias": [
              "SOPClassUID"
            ],
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Coding"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "sopClass"
                }
              ],
              "strength": "extensible",
              "description": "The sopClass for the instance.",
              "valueSet": "http://dicom.nema.org/medical/dicom/current/output/chtml/part04/sect_B.5.html#table_B.5-1"
            }
          },
          {
            "id": "ImagingStudy.series.instance.number",
            "path": "ImagingStudy.series.instance.number",
            "short": "The number of this instance in the series",
            "definition": "The number of instance in the series.",
            "alias": [
              "InstanceNumber"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "unsignedInt"
              }
            ],
            "example": [
              {
                "label": "General",
                "valueUnsignedInt": 1
              }
            ]
          },
          {
            "id": "ImagingStudy.series.instance.title",
            "path": "ImagingStudy.series.instance.title",
            "short": "Description of instance",
            "definition": "The description of the instance.",
            "comment": "Particularly for post-acquisition analytic objects, such as SR, presentation states, value mapping, etc.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion
    /// <summary>
    /// Fhir resource 'ImagingStudy'
    /// </summary>
    // 0. ImagingStudy
    public class Resource_ImagingStudy : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 20. ImagingStudy.series
        public class Type_Series : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 31. ImagingStudy.series.performer
            public class Type_Performer : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 32. ImagingStudy.series.performer.function
                public ElementDefinitionInfo Element_Function;
                // 33. ImagingStudy.series.performer.actor
                public ElementDefinitionInfo Element_Actor;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "ImagingStudy.series.performer",
                        ElementId = "ImagingStudy.series.performer"
                    });
                    Element_Function.Write(sDef);
                    Element_Actor.Write(sDef);
                }
                
                public Type_Performer()
                {
                    {
                        // 32. ImagingStudy.series.performer.function
                        this.Element_Function = new ElementDefinitionInfo
                        {
                            Name = "Element_Function",
                            Path= "ImagingStudy.series.performer.function",
                            Id = "ImagingStudy.series.performer.function",
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
                        // 33. ImagingStudy.series.performer.actor
                        this.Element_Actor = new ElementDefinitionInfo
                        {
                            Name = "Element_Actor",
                            Path= "ImagingStudy.series.performer.actor",
                            Id = "ImagingStudy.series.performer.actor",
                            Min = 1,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Complex.Type_Reference
                                {
                                    TargetProfile = new String[]
                                    {
                                        "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                        "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                                        "http://hl7.org/fhir/StructureDefinition/Organization",
                                        "http://hl7.org/fhir/StructureDefinition/CareTeam",
                                        "http://hl7.org/fhir/StructureDefinition/Patient",
                                        "http://hl7.org/fhir/StructureDefinition/Device",
                                        "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                                    }
                                }
                            }
                        };
                    }
                }
            }
            // 34. ImagingStudy.series.instance
            public class Type_Instance : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 35. ImagingStudy.series.instance.uid
                public ElementDefinitionInfo Element_Uid;
                // 36. ImagingStudy.series.instance.sopClass
                public ElementDefinitionInfo Element_SopClass;
                // 37. ImagingStudy.series.instance.number
                public ElementDefinitionInfo Element_Number;
                // 38. ImagingStudy.series.instance.title
                public ElementDefinitionInfo Element_Title;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "ImagingStudy.series.instance",
                        ElementId = "ImagingStudy.series.instance"
                    });
                    Element_Uid.Write(sDef);
                    Element_SopClass.Write(sDef);
                    Element_Number.Write(sDef);
                    Element_Title.Write(sDef);
                }
                
                public Type_Instance()
                {
                    {
                        // 35. ImagingStudy.series.instance.uid
                        this.Element_Uid = new ElementDefinitionInfo
                        {
                            Name = "Element_Uid",
                            Path= "ImagingStudy.series.instance.uid",
                            Id = "ImagingStudy.series.instance.uid",
                            Min = 1,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_Id
                                {
                                }
                            }
                        };
                    }
                    {
                        // 36. ImagingStudy.series.instance.sopClass
                        this.Element_SopClass = new ElementDefinitionInfo
                        {
                            Name = "Element_SopClass",
                            Path= "ImagingStudy.series.instance.sopClass",
                            Id = "ImagingStudy.series.instance.sopClass",
                            Min = 1,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Complex.Type_Coding
                                {
                                }
                            }
                        };
                    }
                    {
                        // 37. ImagingStudy.series.instance.number
                        this.Element_Number = new ElementDefinitionInfo
                        {
                            Name = "Element_Number",
                            Path= "ImagingStudy.series.instance.number",
                            Id = "ImagingStudy.series.instance.number",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_UnsignedInt
                                {
                                }
                            }
                        };
                    }
                    {
                        // 38. ImagingStudy.series.instance.title
                        this.Element_Title = new ElementDefinitionInfo
                        {
                            Name = "Element_Title",
                            Path= "ImagingStudy.series.instance.title",
                            Id = "ImagingStudy.series.instance.title",
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
                }
            }
            // 21. ImagingStudy.series.uid
            public ElementDefinitionInfo Element_Uid;
            // 22. ImagingStudy.series.number
            public ElementDefinitionInfo Element_Number;
            // 23. ImagingStudy.series.modality
            public ElementDefinitionInfo Element_Modality;
            // 24. ImagingStudy.series.description
            public ElementDefinitionInfo Element_Description;
            // 25. ImagingStudy.series.numberOfInstances
            public ElementDefinitionInfo Element_NumberOfInstances;
            // 26. ImagingStudy.series.endpoint
            public ElementDefinitionInfo Element_Endpoint;
            // 27. ImagingStudy.series.bodySite
            public ElementDefinitionInfo Element_BodySite;
            // 28. ImagingStudy.series.laterality
            public ElementDefinitionInfo Element_Laterality;
            // 29. ImagingStudy.series.specimen
            public ElementDefinitionInfo Element_Specimen;
            // 30. ImagingStudy.series.started
            public ElementDefinitionInfo Element_Started;
            // 31. ImagingStudy.series.performer
            public ElementDefinitionInfo Element_Performer;
            // 34. ImagingStudy.series.instance
            public ElementDefinitionInfo Element_Instance;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ImagingStudy.series",
                    ElementId = "ImagingStudy.series"
                });
                Element_Uid.Write(sDef);
                Element_Number.Write(sDef);
                Element_Modality.Write(sDef);
                Element_Description.Write(sDef);
                Element_NumberOfInstances.Write(sDef);
                Element_Endpoint.Write(sDef);
                Element_BodySite.Write(sDef);
                Element_Laterality.Write(sDef);
                Element_Specimen.Write(sDef);
                Element_Started.Write(sDef);
                Element_Performer.Write(sDef);
                Element_Instance.Write(sDef);
            }
            
            public Type_Series()
            {
                {
                    // 21. ImagingStudy.series.uid
                    this.Element_Uid = new ElementDefinitionInfo
                    {
                        Name = "Element_Uid",
                        Path= "ImagingStudy.series.uid",
                        Id = "ImagingStudy.series.uid",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Id
                            {
                            }
                        }
                    };
                }
                {
                    // 22. ImagingStudy.series.number
                    this.Element_Number = new ElementDefinitionInfo
                    {
                        Name = "Element_Number",
                        Path= "ImagingStudy.series.number",
                        Id = "ImagingStudy.series.number",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_UnsignedInt
                            {
                            }
                        }
                    };
                }
                {
                    // 23. ImagingStudy.series.modality
                    this.Element_Modality = new ElementDefinitionInfo
                    {
                        Name = "Element_Modality",
                        Path= "ImagingStudy.series.modality",
                        Id = "ImagingStudy.series.modality",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Coding
                            {
                            }
                        }
                    };
                }
                {
                    // 24. ImagingStudy.series.description
                    this.Element_Description = new ElementDefinitionInfo
                    {
                        Name = "Element_Description",
                        Path= "ImagingStudy.series.description",
                        Id = "ImagingStudy.series.description",
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
                    // 25. ImagingStudy.series.numberOfInstances
                    this.Element_NumberOfInstances = new ElementDefinitionInfo
                    {
                        Name = "Element_NumberOfInstances",
                        Path= "ImagingStudy.series.numberOfInstances",
                        Id = "ImagingStudy.series.numberOfInstances",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_UnsignedInt
                            {
                            }
                        }
                    };
                }
                {
                    // 26. ImagingStudy.series.endpoint
                    this.Element_Endpoint = new ElementDefinitionInfo
                    {
                        Name = "Element_Endpoint",
                        Path= "ImagingStudy.series.endpoint",
                        Id = "ImagingStudy.series.endpoint",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Endpoint"
                                }
                            }
                        }
                    };
                }
                {
                    // 27. ImagingStudy.series.bodySite
                    this.Element_BodySite = new ElementDefinitionInfo
                    {
                        Name = "Element_BodySite",
                        Path= "ImagingStudy.series.bodySite",
                        Id = "ImagingStudy.series.bodySite",
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
                {
                    // 28. ImagingStudy.series.laterality
                    this.Element_Laterality = new ElementDefinitionInfo
                    {
                        Name = "Element_Laterality",
                        Path= "ImagingStudy.series.laterality",
                        Id = "ImagingStudy.series.laterality",
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
                {
                    // 29. ImagingStudy.series.specimen
                    this.Element_Specimen = new ElementDefinitionInfo
                    {
                        Name = "Element_Specimen",
                        Path= "ImagingStudy.series.specimen",
                        Id = "ImagingStudy.series.specimen",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Specimen"
                                }
                            }
                        }
                    };
                }
                {
                    // 30. ImagingStudy.series.started
                    this.Element_Started = new ElementDefinitionInfo
                    {
                        Name = "Element_Started",
                        Path= "ImagingStudy.series.started",
                        Id = "ImagingStudy.series.started",
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
                    // 31. ImagingStudy.series.performer
                    this.Element_Performer = new ElementDefinitionInfo
                    {
                        Name = "Element_Performer",
                        Path= "ImagingStudy.series.performer",
                        Id = "ImagingStudy.series.performer",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Performer
                            {
                            }
                        }
                    };
                }
                {
                    // 34. ImagingStudy.series.instance
                    this.Element_Instance = new ElementDefinitionInfo
                    {
                        Name = "Element_Instance",
                        Path= "ImagingStudy.series.instance",
                        Id = "ImagingStudy.series.instance",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Instance
                            {
                            }
                        }
                    };
                }
            }
        }
        // 1. ImagingStudy.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. ImagingStudy.status
        public ElementDefinitionInfo Element_Status;
        // 3. ImagingStudy.modality
        public ElementDefinitionInfo Element_Modality;
        // 4. ImagingStudy.subject
        public ElementDefinitionInfo Element_Subject;
        // 5. ImagingStudy.encounter
        public ElementDefinitionInfo Element_Encounter;
        // 6. ImagingStudy.started
        public ElementDefinitionInfo Element_Started;
        // 7. ImagingStudy.basedOn
        public ElementDefinitionInfo Element_BasedOn;
        // 8. ImagingStudy.referrer
        public ElementDefinitionInfo Element_Referrer;
        // 9. ImagingStudy.interpreter
        public ElementDefinitionInfo Element_Interpreter;
        // 10. ImagingStudy.endpoint
        public ElementDefinitionInfo Element_Endpoint;
        // 11. ImagingStudy.numberOfSeries
        public ElementDefinitionInfo Element_NumberOfSeries;
        // 12. ImagingStudy.numberOfInstances
        public ElementDefinitionInfo Element_NumberOfInstances;
        // 13. ImagingStudy.procedureReference
        public ElementDefinitionInfo Element_ProcedureReference;
        // 14. ImagingStudy.procedureCode
        public ElementDefinitionInfo Element_ProcedureCode;
        // 15. ImagingStudy.location
        public ElementDefinitionInfo Element_Location;
        // 16. ImagingStudy.reasonCode
        public ElementDefinitionInfo Element_ReasonCode;
        // 17. ImagingStudy.reasonReference
        public ElementDefinitionInfo Element_ReasonReference;
        // 18. ImagingStudy.note
        public ElementDefinitionInfo Element_Note;
        // 19. ImagingStudy.description
        public ElementDefinitionInfo Element_Description;
        // 20. ImagingStudy.series
        public ElementDefinitionInfo Element_Series;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "ImagingStudy",
                ElementId = "ImagingStudy"
            });
            Element_Identifier.Write(sDef);
            Element_Status.Write(sDef);
            Element_Modality.Write(sDef);
            Element_Subject.Write(sDef);
            Element_Encounter.Write(sDef);
            Element_Started.Write(sDef);
            Element_BasedOn.Write(sDef);
            Element_Referrer.Write(sDef);
            Element_Interpreter.Write(sDef);
            Element_Endpoint.Write(sDef);
            Element_NumberOfSeries.Write(sDef);
            Element_NumberOfInstances.Write(sDef);
            Element_ProcedureReference.Write(sDef);
            Element_ProcedureCode.Write(sDef);
            Element_Location.Write(sDef);
            Element_ReasonCode.Write(sDef);
            Element_ReasonReference.Write(sDef);
            Element_Note.Write(sDef);
            Element_Description.Write(sDef);
            Element_Series.Write(sDef);
        }
        
        public Resource_ImagingStudy()
        {
            {
                // 1. ImagingStudy.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "ImagingStudy.identifier",
                    Id = "ImagingStudy.identifier",
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
                // 2. ImagingStudy.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "ImagingStudy.status",
                    Id = "ImagingStudy.status",
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
                // 3. ImagingStudy.modality
                this.Element_Modality = new ElementDefinitionInfo
                {
                    Name = "Element_Modality",
                    Path= "ImagingStudy.modality",
                    Id = "ImagingStudy.modality",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Coding
                        {
                        }
                    }
                };
            }
            {
                // 4. ImagingStudy.subject
                this.Element_Subject = new ElementDefinitionInfo
                {
                    Name = "Element_Subject",
                    Path= "ImagingStudy.subject",
                    Id = "ImagingStudy.subject",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Patient",
                                "http://hl7.org/fhir/StructureDefinition/Device",
                                "http://hl7.org/fhir/StructureDefinition/Group"
                            }
                        }
                    }
                };
            }
            {
                // 5. ImagingStudy.encounter
                this.Element_Encounter = new ElementDefinitionInfo
                {
                    Name = "Element_Encounter",
                    Path= "ImagingStudy.encounter",
                    Id = "ImagingStudy.encounter",
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
                // 6. ImagingStudy.started
                this.Element_Started = new ElementDefinitionInfo
                {
                    Name = "Element_Started",
                    Path= "ImagingStudy.started",
                    Id = "ImagingStudy.started",
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
                // 7. ImagingStudy.basedOn
                this.Element_BasedOn = new ElementDefinitionInfo
                {
                    Name = "Element_BasedOn",
                    Path= "ImagingStudy.basedOn",
                    Id = "ImagingStudy.basedOn",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/CarePlan",
                                "http://hl7.org/fhir/StructureDefinition/ServiceRequest",
                                "http://hl7.org/fhir/StructureDefinition/Appointment",
                                "http://hl7.org/fhir/StructureDefinition/AppointmentResponse",
                                "http://hl7.org/fhir/StructureDefinition/Task"
                            }
                        }
                    }
                };
            }
            {
                // 8. ImagingStudy.referrer
                this.Element_Referrer = new ElementDefinitionInfo
                {
                    Name = "Element_Referrer",
                    Path= "ImagingStudy.referrer",
                    Id = "ImagingStudy.referrer",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole"
                            }
                        }
                    }
                };
            }
            {
                // 9. ImagingStudy.interpreter
                this.Element_Interpreter = new ElementDefinitionInfo
                {
                    Name = "Element_Interpreter",
                    Path= "ImagingStudy.interpreter",
                    Id = "ImagingStudy.interpreter",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole"
                            }
                        }
                    }
                };
            }
            {
                // 10. ImagingStudy.endpoint
                this.Element_Endpoint = new ElementDefinitionInfo
                {
                    Name = "Element_Endpoint",
                    Path= "ImagingStudy.endpoint",
                    Id = "ImagingStudy.endpoint",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Endpoint"
                            }
                        }
                    }
                };
            }
            {
                // 11. ImagingStudy.numberOfSeries
                this.Element_NumberOfSeries = new ElementDefinitionInfo
                {
                    Name = "Element_NumberOfSeries",
                    Path= "ImagingStudy.numberOfSeries",
                    Id = "ImagingStudy.numberOfSeries",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_UnsignedInt
                        {
                        }
                    }
                };
            }
            {
                // 12. ImagingStudy.numberOfInstances
                this.Element_NumberOfInstances = new ElementDefinitionInfo
                {
                    Name = "Element_NumberOfInstances",
                    Path= "ImagingStudy.numberOfInstances",
                    Id = "ImagingStudy.numberOfInstances",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_UnsignedInt
                        {
                        }
                    }
                };
            }
            {
                // 13. ImagingStudy.procedureReference
                this.Element_ProcedureReference = new ElementDefinitionInfo
                {
                    Name = "Element_ProcedureReference",
                    Path= "ImagingStudy.procedureReference",
                    Id = "ImagingStudy.procedureReference",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Procedure"
                            }
                        }
                    }
                };
            }
            {
                // 14. ImagingStudy.procedureCode
                this.Element_ProcedureCode = new ElementDefinitionInfo
                {
                    Name = "Element_ProcedureCode",
                    Path= "ImagingStudy.procedureCode",
                    Id = "ImagingStudy.procedureCode",
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
                // 15. ImagingStudy.location
                this.Element_Location = new ElementDefinitionInfo
                {
                    Name = "Element_Location",
                    Path= "ImagingStudy.location",
                    Id = "ImagingStudy.location",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Location"
                            }
                        }
                    }
                };
            }
            {
                // 16. ImagingStudy.reasonCode
                this.Element_ReasonCode = new ElementDefinitionInfo
                {
                    Name = "Element_ReasonCode",
                    Path= "ImagingStudy.reasonCode",
                    Id = "ImagingStudy.reasonCode",
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
                // 17. ImagingStudy.reasonReference
                this.Element_ReasonReference = new ElementDefinitionInfo
                {
                    Name = "Element_ReasonReference",
                    Path= "ImagingStudy.reasonReference",
                    Id = "ImagingStudy.reasonReference",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Condition",
                                "http://hl7.org/fhir/StructureDefinition/Observation",
                                "http://hl7.org/fhir/StructureDefinition/Media",
                                "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",
                                "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                            }
                        }
                    }
                };
            }
            {
                // 18. ImagingStudy.note
                this.Element_Note = new ElementDefinitionInfo
                {
                    Name = "Element_Note",
                    Path= "ImagingStudy.note",
                    Id = "ImagingStudy.note",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Annotation
                        {
                        }
                    }
                };
            }
            {
                // 19. ImagingStudy.description
                this.Element_Description = new ElementDefinitionInfo
                {
                    Name = "Element_Description",
                    Path= "ImagingStudy.description",
                    Id = "ImagingStudy.description",
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
                // 20. ImagingStudy.series
                this.Element_Series = new ElementDefinitionInfo
                {
                    Name = "Element_Series",
                    Path= "ImagingStudy.series",
                    Id = "ImagingStudy.series",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Series
                        {
                        }
                    }
                };
            }
            this.Name = "ImagingStudy";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/ImagingStudy";
        }
    }
}
