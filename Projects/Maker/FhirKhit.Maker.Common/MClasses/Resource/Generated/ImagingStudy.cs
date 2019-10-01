using System;                                                                                                                               // MakerGen.cs:391
using System.Diagnostics;                                                                                                                   // MakerGen.cs:392
using System.IO;                                                                                                                            // MakerGen.cs:393
using System.Linq;                                                                                                                          // MakerGen.cs:394
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:396
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:397
{                                                                                                                                           // MakerGen.cs:398
    #region Json                                                                                                                            // MakerGen.cs:399
    #if NEVER                                                                                                                               // MakerGen.cs:400
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
    #endregion                                                                                                                              // MakerGen.cs:403
    /// <summary>
    /// Fhir resource 'ImagingStudy'
    /// </summary>
    // 0. ImagingStudy
    public class ImagingStudy : FhirKhit.Maker.Common.Resource.ResourceBase                                                                 // MakerGen.cs:352
    {                                                                                                                                       // MakerGen.cs:353
        // 20. ImagingStudy.series
        public class Type_Series : FhirKhit.Maker.Common.Complex.ComplexBase                                                                // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 31. ImagingStudy.series.performer
            public class Type_Performer : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:352
            {                                                                                                                               // MakerGen.cs:353
                // 32. ImagingStudy.series.performer.function
                public MakerElementInstance Element_Function;                                                                               // MakerGen.cs:232
                // 33. ImagingStudy.series.performer.actor
                public MakerElementInstance Element_Actor;                                                                                  // MakerGen.cs:232
                public Type_Performer()                                                                                                     // MakerGen.cs:361
                {                                                                                                                           // MakerGen.cs:362
                    {                                                                                                                       // MakerGen.cs:243
                        // 32. ImagingStudy.series.performer.function
                        this.Element_Function = new MakerElementInstance                                                                    // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Function",                                                                                      // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                         // MakerGen.cs:292
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 33. ImagingStudy.series.performer.actor
                        this.Element_Actor = new MakerElementInstance                                                                       // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Actor",                                                                                         // MakerGen.cs:247
                            Min = 1,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                }                                                                                                                           // MakerGen.cs:373
            }                                                                                                                               // MakerGen.cs:357
            // 34. ImagingStudy.series.instance
            public class Type_Instance : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:352
            {                                                                                                                               // MakerGen.cs:353
                // 35. ImagingStudy.series.instance.uid
                public MakerElementInstance Element_Uid;                                                                                    // MakerGen.cs:232
                // 36. ImagingStudy.series.instance.sopClass
                public MakerElementInstance Element_SopClass;                                                                               // MakerGen.cs:232
                // 37. ImagingStudy.series.instance.number
                public MakerElementInstance Element_Number;                                                                                 // MakerGen.cs:232
                // 38. ImagingStudy.series.instance.title
                public MakerElementInstance Element_Title;                                                                                  // MakerGen.cs:232
                public Type_Instance()                                                                                                      // MakerGen.cs:361
                {                                                                                                                           // MakerGen.cs:362
                    {                                                                                                                       // MakerGen.cs:243
                        // 35. ImagingStudy.series.instance.uid
                        this.Element_Uid = new MakerElementInstance                                                                         // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Uid",                                                                                           // MakerGen.cs:247
                            Min = 1,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Id()                                                                    // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 36. ImagingStudy.series.instance.sopClass
                        this.Element_SopClass = new MakerElementInstance                                                                    // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_SopClass",                                                                                      // MakerGen.cs:247
                            Min = 1,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.Coding()                                                                  // MakerGen.cs:292
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 37. ImagingStudy.series.instance.number
                        this.Element_Number = new MakerElementInstance                                                                      // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Number",                                                                                        // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.UnsignedInt()                                                           // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 38. ImagingStudy.series.instance.title
                        this.Element_Title = new MakerElementInstance                                                                       // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Title",                                                                                         // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.String()                                                                // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                }                                                                                                                           // MakerGen.cs:373
            }                                                                                                                               // MakerGen.cs:357
            // 21. ImagingStudy.series.uid
            public MakerElementInstance Element_Uid;                                                                                        // MakerGen.cs:232
            // 22. ImagingStudy.series.number
            public MakerElementInstance Element_Number;                                                                                     // MakerGen.cs:232
            // 23. ImagingStudy.series.modality
            public MakerElementInstance Element_Modality;                                                                                   // MakerGen.cs:232
            // 24. ImagingStudy.series.description
            public MakerElementInstance Element_Description;                                                                                // MakerGen.cs:232
            // 25. ImagingStudy.series.numberOfInstances
            public MakerElementInstance Element_NumberOfInstances;                                                                          // MakerGen.cs:232
            // 26. ImagingStudy.series.endpoint
            public MakerElementInstance Element_Endpoint;                                                                                   // MakerGen.cs:232
            // 27. ImagingStudy.series.bodySite
            public MakerElementInstance Element_BodySite;                                                                                   // MakerGen.cs:232
            // 28. ImagingStudy.series.laterality
            public MakerElementInstance Element_Laterality;                                                                                 // MakerGen.cs:232
            // 29. ImagingStudy.series.specimen
            public MakerElementInstance Element_Specimen;                                                                                   // MakerGen.cs:232
            // 30. ImagingStudy.series.started
            public MakerElementInstance Element_Started;                                                                                    // MakerGen.cs:232
            public Type_Series()                                                                                                            // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 21. ImagingStudy.series.uid
                    this.Element_Uid = new MakerElementInstance                                                                             // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Uid",                                                                                               // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Id()                                                                        // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 22. ImagingStudy.series.number
                    this.Element_Number = new MakerElementInstance                                                                          // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Number",                                                                                            // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.UnsignedInt()                                                               // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 23. ImagingStudy.series.modality
                    this.Element_Modality = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Modality",                                                                                          // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.Coding()                                                                      // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 24. ImagingStudy.series.description
                    this.Element_Description = new MakerElementInstance                                                                     // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Description",                                                                                       // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String()                                                                    // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 25. ImagingStudy.series.numberOfInstances
                    this.Element_NumberOfInstances = new MakerElementInstance                                                               // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_NumberOfInstances",                                                                                 // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.UnsignedInt()                                                               // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 26. ImagingStudy.series.endpoint
                    this.Element_Endpoint = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Endpoint",                                                                                          // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 27. ImagingStudy.series.bodySite
                    this.Element_BodySite = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_BodySite",                                                                                          // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.Coding()                                                                      // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 28. ImagingStudy.series.laterality
                    this.Element_Laterality = new MakerElementInstance                                                                      // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Laterality",                                                                                        // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.Coding()                                                                      // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 29. ImagingStudy.series.specimen
                    this.Element_Specimen = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Specimen",                                                                                          // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 30. ImagingStudy.series.started
                    this.Element_Started = new MakerElementInstance                                                                         // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Started",                                                                                           // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.DateTime()                                                                  // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 1. ImagingStudy.identifier
        public MakerElementInstance Element_Identifier;                                                                                     // MakerGen.cs:232
        // 2. ImagingStudy.status
        public MakerElementInstance Element_Status;                                                                                         // MakerGen.cs:232
        // 3. ImagingStudy.modality
        public MakerElementInstance Element_Modality;                                                                                       // MakerGen.cs:232
        // 4. ImagingStudy.subject
        public MakerElementInstance Element_Subject;                                                                                        // MakerGen.cs:232
        // 5. ImagingStudy.encounter
        public MakerElementInstance Element_Encounter;                                                                                      // MakerGen.cs:232
        // 6. ImagingStudy.started
        public MakerElementInstance Element_Started;                                                                                        // MakerGen.cs:232
        // 7. ImagingStudy.basedOn
        public MakerElementInstance Element_BasedOn;                                                                                        // MakerGen.cs:232
        // 8. ImagingStudy.referrer
        public MakerElementInstance Element_Referrer;                                                                                       // MakerGen.cs:232
        // 9. ImagingStudy.interpreter
        public MakerElementInstance Element_Interpreter;                                                                                    // MakerGen.cs:232
        // 10. ImagingStudy.endpoint
        public MakerElementInstance Element_Endpoint;                                                                                       // MakerGen.cs:232
        // 11. ImagingStudy.numberOfSeries
        public MakerElementInstance Element_NumberOfSeries;                                                                                 // MakerGen.cs:232
        // 12. ImagingStudy.numberOfInstances
        public MakerElementInstance Element_NumberOfInstances;                                                                              // MakerGen.cs:232
        // 13. ImagingStudy.procedureReference
        public MakerElementInstance Element_ProcedureReference;                                                                             // MakerGen.cs:232
        // 14. ImagingStudy.procedureCode
        public MakerElementInstance Element_ProcedureCode;                                                                                  // MakerGen.cs:232
        // 15. ImagingStudy.location
        public MakerElementInstance Element_Location;                                                                                       // MakerGen.cs:232
        // 16. ImagingStudy.reasonCode
        public MakerElementInstance Element_ReasonCode;                                                                                     // MakerGen.cs:232
        // 17. ImagingStudy.reasonReference
        public MakerElementInstance Element_ReasonReference;                                                                                // MakerGen.cs:232
        // 18. ImagingStudy.note
        public MakerElementInstance Element_Note;                                                                                           // MakerGen.cs:232
        // 19. ImagingStudy.description
        public MakerElementInstance Element_Description;                                                                                    // MakerGen.cs:232
        public ImagingStudy()                                                                                                               // MakerGen.cs:361
        {                                                                                                                                   // MakerGen.cs:362
            {                                                                                                                               // MakerGen.cs:243
                // 1. ImagingStudy.identifier
                this.Element_Identifier = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 2. ImagingStudy.status
                this.Element_Status = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Status",                                                                                                // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Code()                                                                          // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 3. ImagingStudy.modality
                this.Element_Modality = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Modality",                                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Coding()                                                                          // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 4. ImagingStudy.subject
                this.Element_Subject = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Subject",                                                                                               // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 5. ImagingStudy.encounter
                this.Element_Encounter = new MakerElementInstance                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Encounter",                                                                                             // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 6. ImagingStudy.started
                this.Element_Started = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Started",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.DateTime()                                                                      // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 7. ImagingStudy.basedOn
                this.Element_BasedOn = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_BasedOn",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 8. ImagingStudy.referrer
                this.Element_Referrer = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Referrer",                                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 9. ImagingStudy.interpreter
                this.Element_Interpreter = new MakerElementInstance                                                                         // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Interpreter",                                                                                           // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 10. ImagingStudy.endpoint
                this.Element_Endpoint = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Endpoint",                                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 11. ImagingStudy.numberOfSeries
                this.Element_NumberOfSeries = new MakerElementInstance                                                                      // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_NumberOfSeries",                                                                                        // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.UnsignedInt()                                                                   // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 12. ImagingStudy.numberOfInstances
                this.Element_NumberOfInstances = new MakerElementInstance                                                                   // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_NumberOfInstances",                                                                                     // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.UnsignedInt()                                                                   // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 13. ImagingStudy.procedureReference
                this.Element_ProcedureReference = new MakerElementInstance                                                                  // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ProcedureReference",                                                                                    // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 14. ImagingStudy.procedureCode
                this.Element_ProcedureCode = new MakerElementInstance                                                                       // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ProcedureCode",                                                                                         // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 15. ImagingStudy.location
                this.Element_Location = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Location",                                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 16. ImagingStudy.reasonCode
                this.Element_ReasonCode = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ReasonCode",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 17. ImagingStudy.reasonReference
                this.Element_ReasonReference = new MakerElementInstance                                                                     // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ReasonReference",                                                                                       // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 18. ImagingStudy.note
                this.Element_Note = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Note",                                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 19. ImagingStudy.description
                this.Element_Description = new MakerElementInstance                                                                         // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Description",                                                                                           // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String()                                                                        // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
        }                                                                                                                                   // MakerGen.cs:373
    }                                                                                                                                       // MakerGen.cs:357
}                                                                                                                                           // MakerGen.cs:408
