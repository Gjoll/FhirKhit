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
    #endregion                                                                                                                              // MakerGen.cs:461
    /// <summary>
    /// Fhir resource 'ImagingStudy'
    /// </summary>
    // 0. ImagingStudy
    public class ImagingStudy : FhirKhit.Maker.Common.Resource.ResourceBase                                                                 // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        public class ImagingStudy_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                    // MakerGen.cs:385
        {                                                                                                                                   // MakerGen.cs:386
            // 20. ImagingStudy.series
            public class Type_Series : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_Series_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                             // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 31. ImagingStudy.series.performer
                    public class Type_Performer : FhirKhit.Maker.Common.Complex.ComplexBase                                                 // MakerGen.cs:383
                    {                                                                                                                       // MakerGen.cs:384
                        public class Type_Performer_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                  // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:386
                            // 32. ImagingStudy.series.performer.function
                            public ElementDefinitionInfo Function;                                                                          // MakerGen.cs:216
                            // 33. ImagingStudy.series.performer.actor
                            public ElementDefinitionInfo Actor;                                                                             // MakerGen.cs:216
                            public Type_Performer_Elements()                                                                                // MakerGen.cs:407
                            {                                                                                                               // MakerGen.cs:408
                                {                                                                                                           // MakerGen.cs:231
                                    // 32. ImagingStudy.series.performer.function
                                    this.Function = new ElementDefinitionInfo                                                               // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Function",                                                                                  // MakerGen.cs:235
                                        Path= "ImagingStudy.series.performer.function",                                                     // MakerGen.cs:236
                                        Id = "ImagingStudy.series.performer.function",                                                      // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:315
                                            {                                                                                               // MakerGen.cs:316
                                            }                                                                                               // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 33. ImagingStudy.series.performer.actor
                                    this.Actor = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Actor",                                                                                     // MakerGen.cs:235
                                        Path= "ImagingStudy.series.performer.actor",                                                        // MakerGen.cs:236
                                        Id = "ImagingStudy.series.performer.actor",                                                         // MakerGen.cs:237
                                        Min = 1,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.Reference                                                     // MakerGen.cs:346
                                            {                                                                                               // MakerGen.cs:347
                                                TargetProfile = new String[]                                                                // MakerGen.cs:349
                                                {                                                                                           // CodeEditorExtensions.cs:28
                                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                 // MakerGen.cs:349
                                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                             // MakerGen.cs:349
                                                    "http://hl7.org/fhir/StructureDefinition/Organization",                                 // MakerGen.cs:349
                                                    "http://hl7.org/fhir/StructureDefinition/CareTeam",                                     // MakerGen.cs:349
                                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                      // MakerGen.cs:349
                                                    "http://hl7.org/fhir/StructureDefinition/Device",                                       // MakerGen.cs:349
                                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson"                                 // MakerGen.cs:349
                                                }                                                                                           // CodeEditorExtensions.cs:34
                                            }                                                                                               // MakerGen.cs:350
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                            }                                                                                                               // MakerGen.cs:427
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:412
                            {                                                                                                               // MakerGen.cs:413
                                base.Write(sDef);                                                                                           // MakerGen.cs:414
                                Function.Write(sDef);                                                                                       // MakerGen.cs:220
                                Actor.Write(sDef);                                                                                          // MakerGen.cs:220
                            }                                                                                                               // MakerGen.cs:431
                        }                                                                                                                   // MakerGen.cs:391
                        public Type_Performer_Elements Elements { get; }                                                                    // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                        public Type_Performer()                                                                                             // MakerGen.cs:394
                        {                                                                                                                   // MakerGen.cs:395
                            this.Elements = new Type_Performer_Elements();                                                                  // MakerGen.cs:396
                        }                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:399
                        {                                                                                                                   // MakerGen.cs:400
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:401
                        }                                                                                                                   // MakerGen.cs:402
                    }                                                                                                                       // MakerGen.cs:403
                    // 34. ImagingStudy.series.instance
                    public class Type_Instance : FhirKhit.Maker.Common.Complex.ComplexBase                                                  // MakerGen.cs:383
                    {                                                                                                                       // MakerGen.cs:384
                        public class Type_Instance_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                   // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:386
                            // 35. ImagingStudy.series.instance.uid
                            public ElementDefinitionInfo Uid;                                                                               // MakerGen.cs:216
                            // 36. ImagingStudy.series.instance.sopClass
                            public ElementDefinitionInfo SopClass;                                                                          // MakerGen.cs:216
                            // 37. ImagingStudy.series.instance.number
                            public ElementDefinitionInfo Number;                                                                            // MakerGen.cs:216
                            // 38. ImagingStudy.series.instance.title
                            public ElementDefinitionInfo Title;                                                                             // MakerGen.cs:216
                            public Type_Instance_Elements()                                                                                 // MakerGen.cs:407
                            {                                                                                                               // MakerGen.cs:408
                                {                                                                                                           // MakerGen.cs:231
                                    // 35. ImagingStudy.series.instance.uid
                                    this.Uid = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Uid",                                                                                       // MakerGen.cs:235
                                        Path= "ImagingStudy.series.instance.uid",                                                           // MakerGen.cs:236
                                        Id = "ImagingStudy.series.instance.uid",                                                            // MakerGen.cs:237
                                        Min = 1,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.Id                                                          // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 36. ImagingStudy.series.instance.sopClass
                                    this.SopClass = new ElementDefinitionInfo                                                               // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "SopClass",                                                                                  // MakerGen.cs:235
                                        Path= "ImagingStudy.series.instance.sopClass",                                                      // MakerGen.cs:236
                                        Id = "ImagingStudy.series.instance.sopClass",                                                       // MakerGen.cs:237
                                        Min = 1,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.Coding                                                        // MakerGen.cs:315
                                            {                                                                                               // MakerGen.cs:316
                                            }                                                                                               // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 37. ImagingStudy.series.instance.number
                                    this.Number = new ElementDefinitionInfo                                                                 // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Number",                                                                                    // MakerGen.cs:235
                                        Path= "ImagingStudy.series.instance.number",                                                        // MakerGen.cs:236
                                        Id = "ImagingStudy.series.instance.number",                                                         // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.UnsignedInt                                                 // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 38. ImagingStudy.series.instance.title
                                    this.Title = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Title",                                                                                     // MakerGen.cs:235
                                        Path= "ImagingStudy.series.instance.title",                                                         // MakerGen.cs:236
                                        Id = "ImagingStudy.series.instance.title",                                                          // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                            }                                                                                                               // MakerGen.cs:427
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:412
                            {                                                                                                               // MakerGen.cs:413
                                base.Write(sDef);                                                                                           // MakerGen.cs:414
                                Uid.Write(sDef);                                                                                            // MakerGen.cs:220
                                SopClass.Write(sDef);                                                                                       // MakerGen.cs:220
                                Number.Write(sDef);                                                                                         // MakerGen.cs:220
                                Title.Write(sDef);                                                                                          // MakerGen.cs:220
                            }                                                                                                               // MakerGen.cs:431
                        }                                                                                                                   // MakerGen.cs:391
                        public Type_Instance_Elements Elements { get; }                                                                     // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                        public Type_Instance()                                                                                              // MakerGen.cs:394
                        {                                                                                                                   // MakerGen.cs:395
                            this.Elements = new Type_Instance_Elements();                                                                   // MakerGen.cs:396
                        }                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:399
                        {                                                                                                                   // MakerGen.cs:400
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:401
                        }                                                                                                                   // MakerGen.cs:402
                    }                                                                                                                       // MakerGen.cs:403
                    // 21. ImagingStudy.series.uid
                    public ElementDefinitionInfo Uid;                                                                                       // MakerGen.cs:216
                    // 22. ImagingStudy.series.number
                    public ElementDefinitionInfo Number;                                                                                    // MakerGen.cs:216
                    // 23. ImagingStudy.series.modality
                    public ElementDefinitionInfo Modality;                                                                                  // MakerGen.cs:216
                    // 24. ImagingStudy.series.description
                    public ElementDefinitionInfo Description;                                                                               // MakerGen.cs:216
                    // 25. ImagingStudy.series.numberOfInstances
                    public ElementDefinitionInfo NumberOfInstances;                                                                         // MakerGen.cs:216
                    // 26. ImagingStudy.series.endpoint
                    public ElementDefinitionInfo Endpoint;                                                                                  // MakerGen.cs:216
                    // 27. ImagingStudy.series.bodySite
                    public ElementDefinitionInfo BodySite;                                                                                  // MakerGen.cs:216
                    // 28. ImagingStudy.series.laterality
                    public ElementDefinitionInfo Laterality;                                                                                // MakerGen.cs:216
                    // 29. ImagingStudy.series.specimen
                    public ElementDefinitionInfo Specimen;                                                                                  // MakerGen.cs:216
                    // 30. ImagingStudy.series.started
                    public ElementDefinitionInfo Started;                                                                                   // MakerGen.cs:216
                    // 31. ImagingStudy.series.performer
                    public ElementDefinitionInfo Performer;                                                                                 // MakerGen.cs:216
                    // 34. ImagingStudy.series.instance
                    public ElementDefinitionInfo Instance;                                                                                  // MakerGen.cs:216
                    public Type_Series_Elements()                                                                                           // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 21. ImagingStudy.series.uid
                            this.Uid = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Uid",                                                                                               // MakerGen.cs:235
                                Path= "ImagingStudy.series.uid",                                                                            // MakerGen.cs:236
                                Id = "ImagingStudy.series.uid",                                                                             // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Id                                                                  // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 22. ImagingStudy.series.number
                            this.Number = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Number",                                                                                            // MakerGen.cs:235
                                Path= "ImagingStudy.series.number",                                                                         // MakerGen.cs:236
                                Id = "ImagingStudy.series.number",                                                                          // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.UnsignedInt                                                         // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 23. ImagingStudy.series.modality
                            this.Modality = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Modality",                                                                                          // MakerGen.cs:235
                                Path= "ImagingStudy.series.modality",                                                                       // MakerGen.cs:236
                                Id = "ImagingStudy.series.modality",                                                                        // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Coding                                                                // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 24. ImagingStudy.series.description
                            this.Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Description",                                                                                       // MakerGen.cs:235
                                Path= "ImagingStudy.series.description",                                                                    // MakerGen.cs:236
                                Id = "ImagingStudy.series.description",                                                                     // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 25. ImagingStudy.series.numberOfInstances
                            this.NumberOfInstances = new ElementDefinitionInfo                                                              // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "NumberOfInstances",                                                                                 // MakerGen.cs:235
                                Path= "ImagingStudy.series.numberOfInstances",                                                              // MakerGen.cs:236
                                Id = "ImagingStudy.series.numberOfInstances",                                                               // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.UnsignedInt                                                         // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 26. ImagingStudy.series.endpoint
                            this.Endpoint = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Endpoint",                                                                                          // MakerGen.cs:235
                                Path= "ImagingStudy.series.endpoint",                                                                       // MakerGen.cs:236
                                Id = "ImagingStudy.series.endpoint",                                                                        // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Endpoint"                                              // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 27. ImagingStudy.series.bodySite
                            this.BodySite = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "BodySite",                                                                                          // MakerGen.cs:235
                                Path= "ImagingStudy.series.bodySite",                                                                       // MakerGen.cs:236
                                Id = "ImagingStudy.series.bodySite",                                                                        // MakerGen.cs:237
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
                        {                                                                                                                   // MakerGen.cs:231
                            // 28. ImagingStudy.series.laterality
                            this.Laterality = new ElementDefinitionInfo                                                                     // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Laterality",                                                                                        // MakerGen.cs:235
                                Path= "ImagingStudy.series.laterality",                                                                     // MakerGen.cs:236
                                Id = "ImagingStudy.series.laterality",                                                                      // MakerGen.cs:237
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
                        {                                                                                                                   // MakerGen.cs:231
                            // 29. ImagingStudy.series.specimen
                            this.Specimen = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Specimen",                                                                                          // MakerGen.cs:235
                                Path= "ImagingStudy.series.specimen",                                                                       // MakerGen.cs:236
                                Id = "ImagingStudy.series.specimen",                                                                        // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Specimen"                                              // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 30. ImagingStudy.series.started
                            this.Started = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Started",                                                                                           // MakerGen.cs:235
                                Path= "ImagingStudy.series.started",                                                                        // MakerGen.cs:236
                                Id = "ImagingStudy.series.started",                                                                         // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.DateTime                                                            // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 31. ImagingStudy.series.performer
                            this.Performer = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Performer",                                                                                         // MakerGen.cs:235
                                Path= "ImagingStudy.series.performer",                                                                      // MakerGen.cs:236
                                Id = "ImagingStudy.series.performer",                                                                       // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new Type_Performer                                                                                      // MakerGen.cs:259
                                    {                                                                                                       // MakerGen.cs:260
                                    }                                                                                                       // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 34. ImagingStudy.series.instance
                            this.Instance = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Instance",                                                                                          // MakerGen.cs:235
                                Path= "ImagingStudy.series.instance",                                                                       // MakerGen.cs:236
                                Id = "ImagingStudy.series.instance",                                                                        // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new Type_Instance                                                                                       // MakerGen.cs:259
                                    {                                                                                                       // MakerGen.cs:260
                                    }                                                                                                       // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        Uid.Write(sDef);                                                                                                    // MakerGen.cs:220
                        Number.Write(sDef);                                                                                                 // MakerGen.cs:220
                        Modality.Write(sDef);                                                                                               // MakerGen.cs:220
                        Description.Write(sDef);                                                                                            // MakerGen.cs:220
                        NumberOfInstances.Write(sDef);                                                                                      // MakerGen.cs:220
                        Endpoint.Write(sDef);                                                                                               // MakerGen.cs:220
                        BodySite.Write(sDef);                                                                                               // MakerGen.cs:220
                        Laterality.Write(sDef);                                                                                             // MakerGen.cs:220
                        Specimen.Write(sDef);                                                                                               // MakerGen.cs:220
                        Started.Write(sDef);                                                                                                // MakerGen.cs:220
                        Performer.Write(sDef);                                                                                              // MakerGen.cs:220
                        Instance.Write(sDef);                                                                                               // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_Series_Elements Elements { get; }                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_Series()                                                                                                        // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_Series_Elements();                                                                             // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 1. ImagingStudy.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:216
            // 2. ImagingStudy.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:216
            // 3. ImagingStudy.modality
            public ElementDefinitionInfo Modality;                                                                                          // MakerGen.cs:216
            // 4. ImagingStudy.subject
            public ElementDefinitionInfo Subject;                                                                                           // MakerGen.cs:216
            // 5. ImagingStudy.encounter
            public ElementDefinitionInfo Encounter;                                                                                         // MakerGen.cs:216
            // 6. ImagingStudy.started
            public ElementDefinitionInfo Started;                                                                                           // MakerGen.cs:216
            // 7. ImagingStudy.basedOn
            public ElementDefinitionInfo BasedOn;                                                                                           // MakerGen.cs:216
            // 8. ImagingStudy.referrer
            public ElementDefinitionInfo Referrer;                                                                                          // MakerGen.cs:216
            // 9. ImagingStudy.interpreter
            public ElementDefinitionInfo Interpreter;                                                                                       // MakerGen.cs:216
            // 10. ImagingStudy.endpoint
            public ElementDefinitionInfo Endpoint;                                                                                          // MakerGen.cs:216
            // 11. ImagingStudy.numberOfSeries
            public ElementDefinitionInfo NumberOfSeries;                                                                                    // MakerGen.cs:216
            // 12. ImagingStudy.numberOfInstances
            public ElementDefinitionInfo NumberOfInstances;                                                                                 // MakerGen.cs:216
            // 13. ImagingStudy.procedureReference
            public ElementDefinitionInfo ProcedureReference;                                                                                // MakerGen.cs:216
            // 14. ImagingStudy.procedureCode
            public ElementDefinitionInfo ProcedureCode;                                                                                     // MakerGen.cs:216
            // 15. ImagingStudy.location
            public ElementDefinitionInfo Location;                                                                                          // MakerGen.cs:216
            // 16. ImagingStudy.reasonCode
            public ElementDefinitionInfo ReasonCode;                                                                                        // MakerGen.cs:216
            // 17. ImagingStudy.reasonReference
            public ElementDefinitionInfo ReasonReference;                                                                                   // MakerGen.cs:216
            // 18. ImagingStudy.note
            public ElementDefinitionInfo Note;                                                                                              // MakerGen.cs:216
            // 19. ImagingStudy.description
            public ElementDefinitionInfo Description;                                                                                       // MakerGen.cs:216
            // 20. ImagingStudy.series
            public ElementDefinitionInfo Series;                                                                                            // MakerGen.cs:216
            public ImagingStudy_Elements()                                                                                                  // MakerGen.cs:407
            {                                                                                                                               // MakerGen.cs:408
                {                                                                                                                           // MakerGen.cs:231
                    // 1. ImagingStudy.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Identifier",                                                                                                // MakerGen.cs:235
                        Path= "ImagingStudy.identifier",                                                                                    // MakerGen.cs:236
                        Id = "ImagingStudy.identifier",                                                                                     // MakerGen.cs:237
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
                    // 2. ImagingStudy.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Status",                                                                                                    // MakerGen.cs:235
                        Path= "ImagingStudy.status",                                                                                        // MakerGen.cs:236
                        Id = "ImagingStudy.status",                                                                                         // MakerGen.cs:237
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
                    // 3. ImagingStudy.modality
                    this.Modality = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Modality",                                                                                                  // MakerGen.cs:235
                        Path= "ImagingStudy.modality",                                                                                      // MakerGen.cs:236
                        Id = "ImagingStudy.modality",                                                                                       // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Coding                                                                        // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 4. ImagingStudy.subject
                    this.Subject = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Subject",                                                                                                   // MakerGen.cs:235
                        Path= "ImagingStudy.subject",                                                                                       // MakerGen.cs:236
                        Id = "ImagingStudy.subject",                                                                                        // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Device",                                                       // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Group"                                                         // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 5. ImagingStudy.encounter
                    this.Encounter = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Encounter",                                                                                                 // MakerGen.cs:235
                        Path= "ImagingStudy.encounter",                                                                                     // MakerGen.cs:236
                        Id = "ImagingStudy.encounter",                                                                                      // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Encounter"                                                     // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 6. ImagingStudy.started
                    this.Started = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Started",                                                                                                   // MakerGen.cs:235
                        Path= "ImagingStudy.started",                                                                                       // MakerGen.cs:236
                        Id = "ImagingStudy.started",                                                                                        // MakerGen.cs:237
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
                    // 7. ImagingStudy.basedOn
                    this.BasedOn = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "BasedOn",                                                                                                   // MakerGen.cs:235
                        Path= "ImagingStudy.basedOn",                                                                                       // MakerGen.cs:236
                        Id = "ImagingStudy.basedOn",                                                                                        // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/CarePlan",                                                     // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/ServiceRequest",                                               // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Appointment",                                                  // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/AppointmentResponse",                                          // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Task"                                                          // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 8. ImagingStudy.referrer
                    this.Referrer = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Referrer",                                                                                                  // MakerGen.cs:235
                        Path= "ImagingStudy.referrer",                                                                                      // MakerGen.cs:236
                        Id = "ImagingStudy.referrer",                                                                                       // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                              // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 9. ImagingStudy.interpreter
                    this.Interpreter = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Interpreter",                                                                                               // MakerGen.cs:235
                        Path= "ImagingStudy.interpreter",                                                                                   // MakerGen.cs:236
                        Id = "ImagingStudy.interpreter",                                                                                    // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                              // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 10. ImagingStudy.endpoint
                    this.Endpoint = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Endpoint",                                                                                                  // MakerGen.cs:235
                        Path= "ImagingStudy.endpoint",                                                                                      // MakerGen.cs:236
                        Id = "ImagingStudy.endpoint",                                                                                       // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Endpoint"                                                      // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 11. ImagingStudy.numberOfSeries
                    this.NumberOfSeries = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "NumberOfSeries",                                                                                            // MakerGen.cs:235
                        Path= "ImagingStudy.numberOfSeries",                                                                                // MakerGen.cs:236
                        Id = "ImagingStudy.numberOfSeries",                                                                                 // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.UnsignedInt                                                                 // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 12. ImagingStudy.numberOfInstances
                    this.NumberOfInstances = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "NumberOfInstances",                                                                                         // MakerGen.cs:235
                        Path= "ImagingStudy.numberOfInstances",                                                                             // MakerGen.cs:236
                        Id = "ImagingStudy.numberOfInstances",                                                                              // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.UnsignedInt                                                                 // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 13. ImagingStudy.procedureReference
                    this.ProcedureReference = new ElementDefinitionInfo                                                                     // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ProcedureReference",                                                                                        // MakerGen.cs:235
                        Path= "ImagingStudy.procedureReference",                                                                            // MakerGen.cs:236
                        Id = "ImagingStudy.procedureReference",                                                                             // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Procedure"                                                     // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 14. ImagingStudy.procedureCode
                    this.ProcedureCode = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ProcedureCode",                                                                                             // MakerGen.cs:235
                        Path= "ImagingStudy.procedureCode",                                                                                 // MakerGen.cs:236
                        Id = "ImagingStudy.procedureCode",                                                                                  // MakerGen.cs:237
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
                    // 15. ImagingStudy.location
                    this.Location = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Location",                                                                                                  // MakerGen.cs:235
                        Path= "ImagingStudy.location",                                                                                      // MakerGen.cs:236
                        Id = "ImagingStudy.location",                                                                                       // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Location"                                                      // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 16. ImagingStudy.reasonCode
                    this.ReasonCode = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ReasonCode",                                                                                                // MakerGen.cs:235
                        Path= "ImagingStudy.reasonCode",                                                                                    // MakerGen.cs:236
                        Id = "ImagingStudy.reasonCode",                                                                                     // MakerGen.cs:237
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
                    // 17. ImagingStudy.reasonReference
                    this.ReasonReference = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ReasonReference",                                                                                           // MakerGen.cs:235
                        Path= "ImagingStudy.reasonReference",                                                                               // MakerGen.cs:236
                        Id = "ImagingStudy.reasonReference",                                                                                // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Condition",                                                    // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Observation",                                                  // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Media",                                                        // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",                                             // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/DocumentReference"                                             // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 18. ImagingStudy.note
                    this.Note = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Note",                                                                                                      // MakerGen.cs:235
                        Path= "ImagingStudy.note",                                                                                          // MakerGen.cs:236
                        Id = "ImagingStudy.note",                                                                                           // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Annotation                                                                    // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 19. ImagingStudy.description
                    this.Description = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Description",                                                                                               // MakerGen.cs:235
                        Path= "ImagingStudy.description",                                                                                   // MakerGen.cs:236
                        Id = "ImagingStudy.description",                                                                                    // MakerGen.cs:237
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
                    // 20. ImagingStudy.series
                    this.Series = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Series",                                                                                                    // MakerGen.cs:235
                        Path= "ImagingStudy.series",                                                                                        // MakerGen.cs:236
                        Id = "ImagingStudy.series",                                                                                         // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Series                                                                                                 // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:427
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:412
            {                                                                                                                               // MakerGen.cs:413
                base.Write(sDef);                                                                                                           // MakerGen.cs:414
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:220
                Status.Write(sDef);                                                                                                         // MakerGen.cs:220
                Modality.Write(sDef);                                                                                                       // MakerGen.cs:220
                Subject.Write(sDef);                                                                                                        // MakerGen.cs:220
                Encounter.Write(sDef);                                                                                                      // MakerGen.cs:220
                Started.Write(sDef);                                                                                                        // MakerGen.cs:220
                BasedOn.Write(sDef);                                                                                                        // MakerGen.cs:220
                Referrer.Write(sDef);                                                                                                       // MakerGen.cs:220
                Interpreter.Write(sDef);                                                                                                    // MakerGen.cs:220
                Endpoint.Write(sDef);                                                                                                       // MakerGen.cs:220
                NumberOfSeries.Write(sDef);                                                                                                 // MakerGen.cs:220
                NumberOfInstances.Write(sDef);                                                                                              // MakerGen.cs:220
                ProcedureReference.Write(sDef);                                                                                             // MakerGen.cs:220
                ProcedureCode.Write(sDef);                                                                                                  // MakerGen.cs:220
                Location.Write(sDef);                                                                                                       // MakerGen.cs:220
                ReasonCode.Write(sDef);                                                                                                     // MakerGen.cs:220
                ReasonReference.Write(sDef);                                                                                                // MakerGen.cs:220
                Note.Write(sDef);                                                                                                           // MakerGen.cs:220
                Description.Write(sDef);                                                                                                    // MakerGen.cs:220
                Series.Write(sDef);                                                                                                         // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:431
        }                                                                                                                                   // MakerGen.cs:391
        public ImagingStudy_Elements Elements { get; }                                                                                      // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
        public ImagingStudy()                                                                                                               // MakerGen.cs:394
        {                                                                                                                                   // MakerGen.cs:395
            this.Elements = new ImagingStudy_Elements();                                                                                    // MakerGen.cs:396
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:399
        {                                                                                                                                   // MakerGen.cs:400
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:401
        }                                                                                                                                   // MakerGen.cs:402
    }                                                                                                                                       // MakerGen.cs:403
}                                                                                                                                           // MakerGen.cs:466
