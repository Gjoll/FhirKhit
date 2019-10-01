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
      "id": "DiagnosticReport",
      "url": "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",
      "version": "4.0.0",
      "name": "DiagnosticReport",
      "status": "draft",
      "publisher": "Health Level Seven International (Orders and Observations)",
      "description": "The findings and interpretation of diagnostic  tests performed on patients, groups of patients, devices, and locations, and/or specimens derived from these. The report includes clinical context such as requesting and provider information, and some mix of atomic results, images, textual and coded interpretations, and formatted representation of diagnostic reports.",
      "purpose": "To support reporting for any diagnostic report into a clinical data repository.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "DiagnosticReport",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "DiagnosticReport",
            "path": "DiagnosticReport",
            "short": "A Diagnostic report - a combination of request information, atomic results, images, interpretation, as well as formatted reports",
            "definition": "The findings and interpretation of diagnostic  tests performed on patients, groups of patients, devices, and locations, and/or specimens derived from these. The report includes clinical context such as requesting and provider information, and some mix of atomic results, images, textual and coded interpretations, and formatted representation of diagnostic reports.",
            "comment": "This is intended to capture a single report and is not suitable for use in displaying summary information that covers multiple reports.  For example, this resource has not been designed for laboratory cumulative reporting formats nor detailed structured reports for sequencing.",
            "alias": [
              "Report",
              "Test",
              "Result",
              "Results",
              "Labs",
              "Laboratory"
            ],
            "min": 0,
            "max": "*"
          },
          {
            "id": "DiagnosticReport.identifier",
            "path": "DiagnosticReport.identifier",
            "short": "Business identifier for report",
            "definition": "Identifiers assigned to this report by the performer or other systems.",
            "comment": "Usually assigned by the Information System of the diagnostic service provider (filler id).",
            "requirements": "Need to know what identifier to use when making queries about this report from the source laboratory, and for linking to the report outside FHIR context.",
            "alias": [
              "ReportID",
              "Filler ID",
              "Placer ID"
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
            "id": "DiagnosticReport.basedOn",
            "path": "DiagnosticReport.basedOn",
            "short": "What was requested",
            "definition": "Details concerning a service requested.",
            "comment": "Note: Usually there is one test request for each result, however in some circumstances multiple test requests may be represented using a single test result resource. Note that there are also cases where one request leads to multiple reports.",
            "requirements": "This allows tracing of authorization for the report and tracking whether proposals/recommendations were acted upon.",
            "alias": [
              "Request"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/CarePlan",
                  "http://hl7.org/fhir/StructureDefinition/ImmunizationRecommendation",
                  "http://hl7.org/fhir/StructureDefinition/MedicationRequest",
                  "http://hl7.org/fhir/StructureDefinition/NutritionOrder",
                  "http://hl7.org/fhir/StructureDefinition/ServiceRequest"
                ]
              }
            ]
          },
          {
            "id": "DiagnosticReport.status",
            "path": "DiagnosticReport.status",
            "short": "registered | partial | preliminary | final +",
            "definition": "The status of the diagnostic report.",
            "requirements": "Diagnostic services routinely issue provisional/incomplete reports, and sometimes withdraw previously released reports.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isModifier": true,
            "isModifierReason": "This element is labeled as a modifier because it is a status element that contains status entered-in-error which means that the resource should not be treated as valid",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "DiagnosticReportStatus"
                }
              ],
              "strength": "required",
              "description": "The status of the diagnostic report.",
              "valueSet": "http://hl7.org/fhir/ValueSet/diagnostic-report-status|4.0.0"
            }
          },
          {
            "id": "DiagnosticReport.category",
            "path": "DiagnosticReport.category",
            "short": "Service category",
            "definition": "A code that classifies the clinical discipline, department or diagnostic service that created the report (e.g. cardiology, biochemistry, hematology, MRI). This is used for searching, sorting and display purposes.",
            "comment": "Multiple categories are allowed using various categorization schemes.   The level of granularity is defined by the category concepts in the value set. More fine-grained filtering can be performed using the metadata and/or terminology hierarchy in DiagnosticReport.code.",
            "alias": [
              "Department",
              "Sub-department",
              "Service",
              "Discipline"
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
                  "valueString": "DiagnosticServiceSection"
                }
              ],
              "strength": "example",
              "description": "Codes for diagnostic service sections.",
              "valueSet": "http://hl7.org/fhir/ValueSet/diagnostic-service-sections"
            }
          },
          {
            "id": "DiagnosticReport.code",
            "path": "DiagnosticReport.code",
            "short": "Name/Code for this diagnostic report",
            "definition": "A code or name that describes this diagnostic report.",
            "alias": [
              "Type"
            ],
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
                  "valueString": "DiagnosticReportCodes"
                }
              ],
              "strength": "preferred",
              "description": "Codes that describe Diagnostic Reports.",
              "valueSet": "http://hl7.org/fhir/ValueSet/report-codes"
            }
          },
          {
            "id": "DiagnosticReport.subject",
            "path": "DiagnosticReport.subject",
            "short": "The subject of the report - usually, but not always, the patient",
            "definition": "The subject of the report. Usually, but not always, this is a patient. However, diagnostic services also perform analyses on specimens collected from a variety of other sources.",
            "requirements": "SHALL know the subject context.",
            "alias": [
              "Patient"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Group",
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/Location"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "DiagnosticReport.encounter",
            "path": "DiagnosticReport.encounter",
            "short": "Health care event when test ordered",
            "definition": "The healthcare event  (e.g. a patient and healthcare provider interaction) which this DiagnosticReport is about.",
            "comment": "This will typically be the encounter the event occurred within, but some events may be initiated prior to or after the official completion of an encounter  but still be tied to the context of the encounter  (e.g. pre-admission laboratory tests).",
            "requirements": "Links the request to the Encounter context.",
            "alias": [
              "Context"
            ],
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
            "id": "DiagnosticReport.effective[x]",
            "path": "DiagnosticReport.effective[x]",
            "short": "Clinically relevant time/time-period for report",
            "definition": "The time or time-period the observed values are related to. When the subject of the report is a patient, this is usually either the time of the procedure or of specimen collection(s), but very often the source of the date/time is not known, only the date/time itself.",
            "comment": "If the diagnostic procedure was performed on the patient, this is the time it was performed. If there are specimens, the diagnostically relevant time can be derived from the specimen collection times, but the specimen information is not always available, and the exact relationship between the specimens and the diagnostically relevant time is not always automatic.",
            "requirements": "Need to know where in the patient history to file/present this report.",
            "alias": [
              "Observation time",
              "Effective Time",
              "Occurrence"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              },
              {
                "code": "Period"
              }
            ],
            "isSummary": true
          },
          {
            "id": "DiagnosticReport.issued",
            "path": "DiagnosticReport.issued",
            "short": "DateTime this version was made",
            "definition": "The date and time that this version of the report was made available to providers, typically after the report was reviewed and verified.",
            "comment": "May be different from the update time of the resource itself, because that is the status of the record (potentially a secondary copy), not the actual release time of the report.",
            "requirements": "Clinicians need to be able to check the date that the report was released.",
            "alias": [
              "Date published",
              "Date Issued",
              "Date Verified"
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
            "id": "DiagnosticReport.performer",
            "path": "DiagnosticReport.performer",
            "short": "Responsible Diagnostic Service",
            "definition": "The diagnostic service that is responsible for issuing the report.",
            "comment": "This is not necessarily the source of the atomic data items or the entity that interpreted the results. It is the entity that takes responsibility for the clinical report.",
            "requirements": "Need to know whom to contact if there are queries about the results. Also may need to track the source of reports for secondary data analysis.",
            "alias": [
              "Laboratory",
              "Service",
              "Practitioner",
              "Department",
              "Company",
              "Authorized by",
              "Director"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Organization",
                  "http://hl7.org/fhir/StructureDefinition/CareTeam"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "DiagnosticReport.resultsInterpreter",
            "path": "DiagnosticReport.resultsInterpreter",
            "short": "Primary result interpreter",
            "definition": "The practitioner or organization that is responsible for the report's conclusions and interpretations.",
            "comment": "Might not be the same entity that takes responsibility for the clinical report.",
            "requirements": "Need to know whom to contact if there are queries about the results. Also may need to track the source of reports for secondary data analysis.",
            "alias": [
              "Analyzed by",
              "Reported by"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Organization",
                  "http://hl7.org/fhir/StructureDefinition/CareTeam"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "DiagnosticReport.specimen",
            "path": "DiagnosticReport.specimen",
            "short": "Specimens this report is based on",
            "definition": "Details about the specimens on which this diagnostic report is based.",
            "comment": "If the specimen is sufficiently specified with a code in the test result name, then this additional data may be redundant. If there are multiple specimens, these may be represented per observation or group.",
            "requirements": "Need to be able to report information about the collected specimens on which the report is based.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Specimen"
                ]
              }
            ]
          },
          {
            "id": "DiagnosticReport.result",
            "path": "DiagnosticReport.result",
            "short": "Observations",
            "definition": "[Observations](observation.html)  that are part of this diagnostic report.",
            "comment": "Observations can contain observations.",
            "requirements": "Need to support individual results, or  groups of results, where the result grouping is arbitrary, but meaningful.",
            "alias": [
              "Data",
              "Atomic Value",
              "Result",
              "Atomic result",
              "Data",
              "Test",
              "Analyte",
              "Battery",
              "Organizer"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Observation"
                ]
              }
            ]
          },
          {
            "id": "DiagnosticReport.imagingStudy",
            "path": "DiagnosticReport.imagingStudy",
            "short": "Reference to full details of imaging associated with the diagnostic report",
            "definition": "One or more links to full details of any imaging performed during the diagnostic investigation. Typically, this is imaging performed by DICOM enabled modalities, but this is not required. A fully enabled PACS viewer can use this information to provide views of the source images.",
            "comment": "ImagingStudy and the image element are somewhat overlapping - typically, the list of image references in the image element will also be found in one of the imaging study resources. However, each caters to different types of displays for different types of purposes. Neither, either, or both may be provided.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/ImagingStudy"
                ]
              }
            ]
          },
          {
            "id": "DiagnosticReport.media",
            "path": "DiagnosticReport.media",
            "short": "Key images associated with this report",
            "definition": "A list of key images associated with this report. The images are generally created during the diagnostic process, and may be directly of the patient, or of treated specimens (i.e. slides of interest).",
            "requirements": "Many diagnostic services include images in the report as part of their service.",
            "alias": [
              "DICOM",
              "Slides",
              "Scans"
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
            "id": "DiagnosticReport.media.comment",
            "path": "DiagnosticReport.media.comment",
            "short": "Comment about the image (e.g. explanation)",
            "definition": "A comment about the image. Typically, this is used to provide an explanation for why the image is included, or to draw the viewer's attention to important features.",
            "comment": "The comment should be displayed with the image. It would be common for the report to include additional discussion of the image contents in other sections such as the conclusion.",
            "requirements": "The provider of the report should make a comment about each image included in the report.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "DiagnosticReport.media.link",
            "path": "DiagnosticReport.media.link",
            "short": "Reference to the image source",
            "definition": "Reference to the image source.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Media"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "DiagnosticReport.conclusion",
            "path": "DiagnosticReport.conclusion",
            "short": "Clinical conclusion (interpretation) of test results",
            "definition": "Concise and clinically contextualized summary conclusion (interpretation/impression) of the diagnostic report.",
            "requirements": "Need to be able to provide a conclusion that is not lost among the basic result data.",
            "alias": [
              "Report"
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
            "id": "DiagnosticReport.conclusionCode",
            "path": "DiagnosticReport.conclusionCode",
            "short": "Codes for the clinical conclusion of test results",
            "definition": "One or more codes that represent the summary conclusion (interpretation/impression) of the diagnostic report.",
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
                  "valueString": "AdjunctDiagnosis"
                }
              ],
              "strength": "example",
              "description": "Diagnosis codes provided as adjuncts to the report.",
              "valueSet": "http://hl7.org/fhir/ValueSet/clinical-findings"
            }
          },
          {
            "id": "DiagnosticReport.presentedForm",
            "path": "DiagnosticReport.presentedForm",
            "short": "Entire report as issued",
            "definition": "Rich text representation of the entire result as issued by the diagnostic service. Multiple formats are allowed but they SHALL be semantically equivalent.",
            "comment": "\"application/pdf\" is recommended as the most reliable and interoperable in this context.",
            "requirements": "Gives laboratory the ability to provide its own fully formatted report for clinical fidelity.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Attachment"
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:403
    /// <summary>
    /// Fhir resource 'DiagnosticReport'
    /// </summary>
    // 0. DiagnosticReport
    public class DiagnosticReport : FhirKhit.Maker.Common.Resource.ResourceBase                                                             // MakerGen.cs:352
    {                                                                                                                                       // MakerGen.cs:353
        // 15. DiagnosticReport.media
        public class Type_Media : FhirKhit.Maker.Common.Complex.ComplexBase                                                                 // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 16. DiagnosticReport.media.comment
            public MakerElementInstance Element_Comment;                                                                                    // MakerGen.cs:232
            // 17. DiagnosticReport.media.link
            public MakerElementInstance Element_Link;                                                                                       // MakerGen.cs:232
            public Type_Media()                                                                                                             // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 16. DiagnosticReport.media.comment
                    this.Element_Comment = new MakerElementInstance                                                                         // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Comment",                                                                                           // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String()                                                                    // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 17. DiagnosticReport.media.link
                    this.Element_Link = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Link",                                                                                              // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 1. DiagnosticReport.identifier
        public MakerElementInstance Element_Identifier;                                                                                     // MakerGen.cs:232
        // 2. DiagnosticReport.basedOn
        public MakerElementInstance Element_BasedOn;                                                                                        // MakerGen.cs:232
        // 3. DiagnosticReport.status
        public MakerElementInstance Element_Status;                                                                                         // MakerGen.cs:232
        // 4. DiagnosticReport.category
        public MakerElementInstance Element_Category;                                                                                       // MakerGen.cs:232
        // 5. DiagnosticReport.code
        public MakerElementInstance Element_Code;                                                                                           // MakerGen.cs:232
        // 6. DiagnosticReport.subject
        public MakerElementInstance Element_Subject;                                                                                        // MakerGen.cs:232
        // 7. DiagnosticReport.encounter
        public MakerElementInstance Element_Encounter;                                                                                      // MakerGen.cs:232
        // 8. DiagnosticReport.effective[x]
        public MakerElementInstance Element_Effective;                                                                                      // MakerGen.cs:232
        // 9. DiagnosticReport.issued
        public MakerElementInstance Element_Issued;                                                                                         // MakerGen.cs:232
        // 10. DiagnosticReport.performer
        public MakerElementInstance Element_Performer;                                                                                      // MakerGen.cs:232
        // 11. DiagnosticReport.resultsInterpreter
        public MakerElementInstance Element_ResultsInterpreter;                                                                             // MakerGen.cs:232
        // 12. DiagnosticReport.specimen
        public MakerElementInstance Element_Specimen;                                                                                       // MakerGen.cs:232
        // 13. DiagnosticReport.result
        public MakerElementInstance Element_Result;                                                                                         // MakerGen.cs:232
        // 14. DiagnosticReport.imagingStudy
        public MakerElementInstance Element_ImagingStudy;                                                                                   // MakerGen.cs:232
        // 18. DiagnosticReport.conclusion
        public MakerElementInstance Element_Conclusion;                                                                                     // MakerGen.cs:232
        // 19. DiagnosticReport.conclusionCode
        public MakerElementInstance Element_ConclusionCode;                                                                                 // MakerGen.cs:232
        // 20. DiagnosticReport.presentedForm
        public MakerElementInstance Element_PresentedForm;                                                                                  // MakerGen.cs:232
        public DiagnosticReport()                                                                                                           // MakerGen.cs:361
        {                                                                                                                                   // MakerGen.cs:362
            {                                                                                                                               // MakerGen.cs:243
                // 1. DiagnosticReport.identifier
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
                // 2. DiagnosticReport.basedOn
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
                // 3. DiagnosticReport.status
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
                // 4. DiagnosticReport.category
                this.Element_Category = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Category",                                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 5. DiagnosticReport.code
                this.Element_Code = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Code",                                                                                                  // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 6. DiagnosticReport.subject
                this.Element_Subject = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Subject",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 7. DiagnosticReport.encounter
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
                // 8. DiagnosticReport.effective[x]
                this.Element_Effective = new MakerElementInstance                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Effective",                                                                                             // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.DateTime(),                                                                     // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 9. DiagnosticReport.issued
                this.Element_Issued = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Issued",                                                                                                // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Instant()                                                                       // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 10. DiagnosticReport.performer
                this.Element_Performer = new MakerElementInstance                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Performer",                                                                                             // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 11. DiagnosticReport.resultsInterpreter
                this.Element_ResultsInterpreter = new MakerElementInstance                                                                  // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ResultsInterpreter",                                                                                    // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 12. DiagnosticReport.specimen
                this.Element_Specimen = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Specimen",                                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 13. DiagnosticReport.result
                this.Element_Result = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Result",                                                                                                // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 14. DiagnosticReport.imagingStudy
                this.Element_ImagingStudy = new MakerElementInstance                                                                        // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ImagingStudy",                                                                                          // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 18. DiagnosticReport.conclusion
                this.Element_Conclusion = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Conclusion",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String()                                                                        // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 19. DiagnosticReport.conclusionCode
                this.Element_ConclusionCode = new MakerElementInstance                                                                      // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ConclusionCode",                                                                                        // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 20. DiagnosticReport.presentedForm
                this.Element_PresentedForm = new MakerElementInstance                                                                       // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_PresentedForm",                                                                                         // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
        }                                                                                                                                   // MakerGen.cs:373
    }                                                                                                                                       // MakerGen.cs:357
}                                                                                                                                           // MakerGen.cs:408
