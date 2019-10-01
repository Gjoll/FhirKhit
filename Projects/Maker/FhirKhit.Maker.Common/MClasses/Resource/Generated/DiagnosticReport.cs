using System;                                                                                                                               // MakerGen.cs:451
using System.Diagnostics;                                                                                                                   // MakerGen.cs:452
using System.IO;                                                                                                                            // MakerGen.cs:453
using System.Linq;                                                                                                                          // MakerGen.cs:454
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:455
                                                                                                                                            // MakerGen.cs:456
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:457
{                                                                                                                                           // MakerGen.cs:458
    #region Json                                                                                                                            // MakerGen.cs:459
    #if NEVER                                                                                                                               // MakerGen.cs:460
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
    #endregion                                                                                                                              // MakerGen.cs:463
    /// <summary>
    /// Fhir resource 'DiagnosticReport'
    /// </summary>
    // 0. DiagnosticReport
    public class DiagnosticReport : FhirKhit.Maker.Common.Resource.ResourceBase                                                             // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class DiagnosticReport_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 15. DiagnosticReport.media
            public class Type_Media : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Media_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                              // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 16. DiagnosticReport.media.comment
                    public ElementDefinitionInfo Comment;                                                                                   // MakerGen.cs:236
                    // 17. DiagnosticReport.media.link
                    public ElementDefinitionInfo Link;                                                                                      // MakerGen.cs:236
                    public Type_Media_Elements()                                                                                            // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 16. DiagnosticReport.media.comment
                            this.Comment = new ElementDefinitionInfo                                                                        // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Comment",                                                                                           // MakerGen.cs:255
                                Path= "DiagnosticReport.media.comment",                                                                     // MakerGen.cs:256
                                Id = "DiagnosticReport.media.comment",                                                                      // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 17. DiagnosticReport.media.link
                            this.Link = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Link",                                                                                              // MakerGen.cs:255
                                Path= "DiagnosticReport.media.link",                                                                        // MakerGen.cs:256
                                Id = "DiagnosticReport.media.link",                                                                         // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Media"                                                 // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Comment.Write(sDef);                                                                                                // MakerGen.cs:240
                        Link.Write(sDef);                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Media_Elements Elements { get; }                                                                                // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Media()                                                                                                         // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Media_Elements();                                                                              // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 1. DiagnosticReport.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:236
            // 2. DiagnosticReport.basedOn
            public ElementDefinitionInfo BasedOn;                                                                                           // MakerGen.cs:236
            // 3. DiagnosticReport.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:236
            // 4. DiagnosticReport.category
            public ElementDefinitionInfo Category;                                                                                          // MakerGen.cs:236
            // 5. DiagnosticReport.code
            public ElementDefinitionInfo Code;                                                                                              // MakerGen.cs:236
            // 6. DiagnosticReport.subject
            public ElementDefinitionInfo Subject;                                                                                           // MakerGen.cs:236
            // 7. DiagnosticReport.encounter
            public ElementDefinitionInfo Encounter;                                                                                         // MakerGen.cs:236
            // 8. DiagnosticReport.effective[x]
            public ElementDefinitionInfo Effective;                                                                                         // MakerGen.cs:236
            // 9. DiagnosticReport.issued
            public ElementDefinitionInfo Issued;                                                                                            // MakerGen.cs:236
            // 10. DiagnosticReport.performer
            public ElementDefinitionInfo Performer;                                                                                         // MakerGen.cs:236
            // 11. DiagnosticReport.resultsInterpreter
            public ElementDefinitionInfo ResultsInterpreter;                                                                                // MakerGen.cs:236
            // 12. DiagnosticReport.specimen
            public ElementDefinitionInfo Specimen;                                                                                          // MakerGen.cs:236
            // 13. DiagnosticReport.result
            public ElementDefinitionInfo Result;                                                                                            // MakerGen.cs:236
            // 14. DiagnosticReport.imagingStudy
            public ElementDefinitionInfo ImagingStudy;                                                                                      // MakerGen.cs:236
            // 18. DiagnosticReport.conclusion
            public ElementDefinitionInfo Conclusion;                                                                                        // MakerGen.cs:236
            // 19. DiagnosticReport.conclusionCode
            public ElementDefinitionInfo ConclusionCode;                                                                                    // MakerGen.cs:236
            // 20. DiagnosticReport.presentedForm
            public ElementDefinitionInfo PresentedForm;                                                                                     // MakerGen.cs:236
            public DiagnosticReport_Elements()                                                                                              // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:251
                    // 1. DiagnosticReport.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Identifier",                                                                                                // MakerGen.cs:255
                        Path= "DiagnosticReport.identifier",                                                                                // MakerGen.cs:256
                        Id = "DiagnosticReport.identifier",                                                                                 // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 2. DiagnosticReport.basedOn
                    this.BasedOn = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "BasedOn",                                                                                                   // MakerGen.cs:255
                        Path= "DiagnosticReport.basedOn",                                                                                   // MakerGen.cs:256
                        Id = "DiagnosticReport.basedOn",                                                                                    // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/CarePlan",                                                     // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/ImmunizationRecommendation",                                   // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/MedicationRequest",                                            // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/NutritionOrder",                                               // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/ServiceRequest"                                                // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 3. DiagnosticReport.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Status",                                                                                                    // MakerGen.cs:255
                        Path= "DiagnosticReport.status",                                                                                    // MakerGen.cs:256
                        Id = "DiagnosticReport.status",                                                                                     // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 4. DiagnosticReport.category
                    this.Category = new ElementDefinitionInfo                                                                               // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Category",                                                                                                  // MakerGen.cs:255
                        Path= "DiagnosticReport.category",                                                                                  // MakerGen.cs:256
                        Id = "DiagnosticReport.category",                                                                                   // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:314
                            {                                                                                                               // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:318
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 5. DiagnosticReport.code
                    this.Code = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Code",                                                                                                      // MakerGen.cs:255
                        Path= "DiagnosticReport.code",                                                                                      // MakerGen.cs:256
                        Id = "DiagnosticReport.code",                                                                                       // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:314
                            {                                                                                                               // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:318
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 6. DiagnosticReport.subject
                    this.Subject = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Subject",                                                                                                   // MakerGen.cs:255
                        Path= "DiagnosticReport.subject",                                                                                   // MakerGen.cs:256
                        Id = "DiagnosticReport.subject",                                                                                    // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Group",                                                        // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Device",                                                       // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Location"                                                      // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 7. DiagnosticReport.encounter
                    this.Encounter = new ElementDefinitionInfo                                                                              // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Encounter",                                                                                                 // MakerGen.cs:255
                        Path= "DiagnosticReport.encounter",                                                                                 // MakerGen.cs:256
                        Id = "DiagnosticReport.encounter",                                                                                  // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Encounter"                                                     // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 8. DiagnosticReport.effective[x]
                    this.Effective = new ElementDefinitionInfo                                                                              // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Effective",                                                                                                 // MakerGen.cs:255
                        Path= "DiagnosticReport.effective[x]",                                                                              // MakerGen.cs:256
                        Id = "DiagnosticReport.effective[x]",                                                                               // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            },                                                                                                              // MakerGen.cs:303
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 9. DiagnosticReport.issued
                    this.Issued = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Issued",                                                                                                    // MakerGen.cs:255
                        Path= "DiagnosticReport.issued",                                                                                    // MakerGen.cs:256
                        Id = "DiagnosticReport.issued",                                                                                     // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Instant                                                                     // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 10. DiagnosticReport.performer
                    this.Performer = new ElementDefinitionInfo                                                                              // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Performer",                                                                                                 // MakerGen.cs:255
                        Path= "DiagnosticReport.performer",                                                                                 // MakerGen.cs:256
                        Id = "DiagnosticReport.performer",                                                                                  // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Organization",                                                 // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/CareTeam"                                                      // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 11. DiagnosticReport.resultsInterpreter
                    this.ResultsInterpreter = new ElementDefinitionInfo                                                                     // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "ResultsInterpreter",                                                                                        // MakerGen.cs:255
                        Path= "DiagnosticReport.resultsInterpreter",                                                                        // MakerGen.cs:256
                        Id = "DiagnosticReport.resultsInterpreter",                                                                         // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Organization",                                                 // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/CareTeam"                                                      // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 12. DiagnosticReport.specimen
                    this.Specimen = new ElementDefinitionInfo                                                                               // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Specimen",                                                                                                  // MakerGen.cs:255
                        Path= "DiagnosticReport.specimen",                                                                                  // MakerGen.cs:256
                        Id = "DiagnosticReport.specimen",                                                                                   // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Specimen"                                                      // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 13. DiagnosticReport.result
                    this.Result = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Result",                                                                                                    // MakerGen.cs:255
                        Path= "DiagnosticReport.result",                                                                                    // MakerGen.cs:256
                        Id = "DiagnosticReport.result",                                                                                     // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Observation"                                                   // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 14. DiagnosticReport.imagingStudy
                    this.ImagingStudy = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "ImagingStudy",                                                                                              // MakerGen.cs:255
                        Path= "DiagnosticReport.imagingStudy",                                                                              // MakerGen.cs:256
                        Id = "DiagnosticReport.imagingStudy",                                                                               // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/ImagingStudy"                                                  // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 18. DiagnosticReport.conclusion
                    this.Conclusion = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Conclusion",                                                                                                // MakerGen.cs:255
                        Path= "DiagnosticReport.conclusion",                                                                                // MakerGen.cs:256
                        Id = "DiagnosticReport.conclusion",                                                                                 // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 19. DiagnosticReport.conclusionCode
                    this.ConclusionCode = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "ConclusionCode",                                                                                            // MakerGen.cs:255
                        Path= "DiagnosticReport.conclusionCode",                                                                            // MakerGen.cs:256
                        Id = "DiagnosticReport.conclusionCode",                                                                             // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:314
                            {                                                                                                               // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:318
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 20. DiagnosticReport.presentedForm
                    this.PresentedForm = new ElementDefinitionInfo                                                                          // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "PresentedForm",                                                                                             // MakerGen.cs:255
                        Path= "DiagnosticReport.presentedForm",                                                                             // MakerGen.cs:256
                        Id = "DiagnosticReport.presentedForm",                                                                              // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Attachment                                                                    // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:429
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:414
            {                                                                                                                               // MakerGen.cs:415
                base.Write(sDef);                                                                                                           // MakerGen.cs:416
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:240
                BasedOn.Write(sDef);                                                                                                        // MakerGen.cs:240
                Status.Write(sDef);                                                                                                         // MakerGen.cs:240
                Category.Write(sDef);                                                                                                       // MakerGen.cs:240
                Code.Write(sDef);                                                                                                           // MakerGen.cs:240
                Subject.Write(sDef);                                                                                                        // MakerGen.cs:240
                Encounter.Write(sDef);                                                                                                      // MakerGen.cs:240
                Effective.Write(sDef);                                                                                                      // MakerGen.cs:240
                Issued.Write(sDef);                                                                                                         // MakerGen.cs:240
                Performer.Write(sDef);                                                                                                      // MakerGen.cs:240
                ResultsInterpreter.Write(sDef);                                                                                             // MakerGen.cs:240
                Specimen.Write(sDef);                                                                                                       // MakerGen.cs:240
                Result.Write(sDef);                                                                                                         // MakerGen.cs:240
                ImagingStudy.Write(sDef);                                                                                                   // MakerGen.cs:240
                Conclusion.Write(sDef);                                                                                                     // MakerGen.cs:240
                ConclusionCode.Write(sDef);                                                                                                 // MakerGen.cs:240
                PresentedForm.Write(sDef);                                                                                                  // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public DiagnosticReport_Elements Elements { get; }                                                                                  // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public DiagnosticReport()                                                                                                           // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new DiagnosticReport_Elements();                                                                                // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:468
