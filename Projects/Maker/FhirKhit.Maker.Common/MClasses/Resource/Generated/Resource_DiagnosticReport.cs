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
    #endregion
    /// <summary>
    /// Fhir resource 'DiagnosticReport'
    /// </summary>
    // 0. DiagnosticReport
    public partial class Resource_DiagnosticReport : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 15. DiagnosticReport.media
        public partial class Type_Media : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 16. DiagnosticReport.media.comment
            public ElementDefinitionInfo Element_Comment;
            // 17. DiagnosticReport.media.link
            public ElementDefinitionInfo Element_Link;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "DiagnosticReport.media",
                    ElementId = "DiagnosticReport.media"
                });
                Element_Comment.Write(sDef);
                Element_Link.Write(sDef);
            }
            
            public Type_Media()
            {
                {
                    // 16. DiagnosticReport.media.comment
                    this.Element_Comment = new ElementDefinitionInfo
                    {
                        Name = "Element_Comment",
                        Path= "DiagnosticReport.media.comment",
                        Id = "DiagnosticReport.media.comment",
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
                    // 17. DiagnosticReport.media.link
                    this.Element_Link = new ElementDefinitionInfo
                    {
                        Name = "Element_Link",
                        Path= "DiagnosticReport.media.link",
                        Id = "DiagnosticReport.media.link",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Media"
                                }
                            }
                        }
                    };
                }
            }
        }
        // 1. DiagnosticReport.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. DiagnosticReport.basedOn
        public ElementDefinitionInfo Element_BasedOn;
        // 3. DiagnosticReport.status
        public ElementDefinitionInfo Element_Status;
        // 4. DiagnosticReport.category
        public ElementDefinitionInfo Element_Category;
        // 5. DiagnosticReport.code
        public ElementDefinitionInfo Element_Code;
        // 6. DiagnosticReport.subject
        public ElementDefinitionInfo Element_Subject;
        // 7. DiagnosticReport.encounter
        public ElementDefinitionInfo Element_Encounter;
        // 8. DiagnosticReport.effective[x]
        public ElementDefinitionInfo Element_Effective;
        // 9. DiagnosticReport.issued
        public ElementDefinitionInfo Element_Issued;
        // 10. DiagnosticReport.performer
        public ElementDefinitionInfo Element_Performer;
        // 11. DiagnosticReport.resultsInterpreter
        public ElementDefinitionInfo Element_ResultsInterpreter;
        // 12. DiagnosticReport.specimen
        public ElementDefinitionInfo Element_Specimen;
        // 13. DiagnosticReport.result
        public ElementDefinitionInfo Element_Result;
        // 14. DiagnosticReport.imagingStudy
        public ElementDefinitionInfo Element_ImagingStudy;
        // 15. DiagnosticReport.media
        public ElementDefinitionInfo Element_Media;
        // 18. DiagnosticReport.conclusion
        public ElementDefinitionInfo Element_Conclusion;
        // 19. DiagnosticReport.conclusionCode
        public ElementDefinitionInfo Element_ConclusionCode;
        // 20. DiagnosticReport.presentedForm
        public ElementDefinitionInfo Element_PresentedForm;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "DiagnosticReport",
                ElementId = "DiagnosticReport"
            });
            Element_Identifier.Write(sDef);
            Element_BasedOn.Write(sDef);
            Element_Status.Write(sDef);
            Element_Category.Write(sDef);
            Element_Code.Write(sDef);
            Element_Subject.Write(sDef);
            Element_Encounter.Write(sDef);
            Element_Effective.Write(sDef);
            Element_Issued.Write(sDef);
            Element_Performer.Write(sDef);
            Element_ResultsInterpreter.Write(sDef);
            Element_Specimen.Write(sDef);
            Element_Result.Write(sDef);
            Element_ImagingStudy.Write(sDef);
            Element_Media.Write(sDef);
            Element_Conclusion.Write(sDef);
            Element_ConclusionCode.Write(sDef);
            Element_PresentedForm.Write(sDef);
        }
        
        public Resource_DiagnosticReport()
        {
            {
                // 1. DiagnosticReport.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "DiagnosticReport.identifier",
                    Id = "DiagnosticReport.identifier",
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
                // 2. DiagnosticReport.basedOn
                this.Element_BasedOn = new ElementDefinitionInfo
                {
                    Name = "Element_BasedOn",
                    Path= "DiagnosticReport.basedOn",
                    Id = "DiagnosticReport.basedOn",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/CarePlan",
                                "http://hl7.org/fhir/StructureDefinition/ImmunizationRecommendation",
                                "http://hl7.org/fhir/StructureDefinition/MedicationRequest",
                                "http://hl7.org/fhir/StructureDefinition/NutritionOrder",
                                "http://hl7.org/fhir/StructureDefinition/ServiceRequest"
                            }
                        }
                    }
                };
            }
            {
                // 3. DiagnosticReport.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "DiagnosticReport.status",
                    Id = "DiagnosticReport.status",
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
                // 4. DiagnosticReport.category
                this.Element_Category = new ElementDefinitionInfo
                {
                    Name = "Element_Category",
                    Path= "DiagnosticReport.category",
                    Id = "DiagnosticReport.category",
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
                // 5. DiagnosticReport.code
                this.Element_Code = new ElementDefinitionInfo
                {
                    Name = "Element_Code",
                    Path= "DiagnosticReport.code",
                    Id = "DiagnosticReport.code",
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
                // 6. DiagnosticReport.subject
                this.Element_Subject = new ElementDefinitionInfo
                {
                    Name = "Element_Subject",
                    Path= "DiagnosticReport.subject",
                    Id = "DiagnosticReport.subject",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Patient",
                                "http://hl7.org/fhir/StructureDefinition/Group",
                                "http://hl7.org/fhir/StructureDefinition/Device",
                                "http://hl7.org/fhir/StructureDefinition/Location"
                            }
                        }
                    }
                };
            }
            {
                // 7. DiagnosticReport.encounter
                this.Element_Encounter = new ElementDefinitionInfo
                {
                    Name = "Element_Encounter",
                    Path= "DiagnosticReport.encounter",
                    Id = "DiagnosticReport.encounter",
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
                // 8. DiagnosticReport.effective[x]
                this.Element_Effective = new ElementDefinitionInfo
                {
                    Name = "Element_Effective",
                    Path= "DiagnosticReport.effective[x]",
                    Id = "DiagnosticReport.effective[x]",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Period
                        {
                        }
                    }
                };
            }
            {
                // 9. DiagnosticReport.issued
                this.Element_Issued = new ElementDefinitionInfo
                {
                    Name = "Element_Issued",
                    Path= "DiagnosticReport.issued",
                    Id = "DiagnosticReport.issued",
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
                // 10. DiagnosticReport.performer
                this.Element_Performer = new ElementDefinitionInfo
                {
                    Name = "Element_Performer",
                    Path= "DiagnosticReport.performer",
                    Id = "DiagnosticReport.performer",
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
                                "http://hl7.org/fhir/StructureDefinition/CareTeam"
                            }
                        }
                    }
                };
            }
            {
                // 11. DiagnosticReport.resultsInterpreter
                this.Element_ResultsInterpreter = new ElementDefinitionInfo
                {
                    Name = "Element_ResultsInterpreter",
                    Path= "DiagnosticReport.resultsInterpreter",
                    Id = "DiagnosticReport.resultsInterpreter",
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
                                "http://hl7.org/fhir/StructureDefinition/CareTeam"
                            }
                        }
                    }
                };
            }
            {
                // 12. DiagnosticReport.specimen
                this.Element_Specimen = new ElementDefinitionInfo
                {
                    Name = "Element_Specimen",
                    Path= "DiagnosticReport.specimen",
                    Id = "DiagnosticReport.specimen",
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
                // 13. DiagnosticReport.result
                this.Element_Result = new ElementDefinitionInfo
                {
                    Name = "Element_Result",
                    Path= "DiagnosticReport.result",
                    Id = "DiagnosticReport.result",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Observation"
                            }
                        }
                    }
                };
            }
            {
                // 14. DiagnosticReport.imagingStudy
                this.Element_ImagingStudy = new ElementDefinitionInfo
                {
                    Name = "Element_ImagingStudy",
                    Path= "DiagnosticReport.imagingStudy",
                    Id = "DiagnosticReport.imagingStudy",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/ImagingStudy"
                            }
                        }
                    }
                };
            }
            {
                // 15. DiagnosticReport.media
                this.Element_Media = new ElementDefinitionInfo
                {
                    Name = "Element_Media",
                    Path= "DiagnosticReport.media",
                    Id = "DiagnosticReport.media",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Media
                        {
                        }
                    }
                };
            }
            {
                // 18. DiagnosticReport.conclusion
                this.Element_Conclusion = new ElementDefinitionInfo
                {
                    Name = "Element_Conclusion",
                    Path= "DiagnosticReport.conclusion",
                    Id = "DiagnosticReport.conclusion",
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
                // 19. DiagnosticReport.conclusionCode
                this.Element_ConclusionCode = new ElementDefinitionInfo
                {
                    Name = "Element_ConclusionCode",
                    Path= "DiagnosticReport.conclusionCode",
                    Id = "DiagnosticReport.conclusionCode",
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
                // 20. DiagnosticReport.presentedForm
                this.Element_PresentedForm = new ElementDefinitionInfo
                {
                    Name = "Element_PresentedForm",
                    Path= "DiagnosticReport.presentedForm",
                    Id = "DiagnosticReport.presentedForm",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Attachment
                        {
                        }
                    }
                };
            }
            this.Name = "DiagnosticReport";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/DiagnosticReport";
        }
    }
}
