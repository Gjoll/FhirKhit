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
      "id": "DeviceUseStatement",
      "url": "http://hl7.org/fhir/StructureDefinition/DeviceUseStatement",
      "version": "4.0.0",
      "name": "DeviceUseStatement",
      "status": "draft",
      "publisher": "Health Level Seven International (Orders and Observations)",
      "description": "A record of a device being used by a patient where the record is the result of a report from the patient or another clinician.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "DeviceUseStatement",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "DeviceUseStatement",
            "path": "DeviceUseStatement",
            "short": "Record of use of a device",
            "definition": "A record of a device being used by a patient where the record is the result of a report from the patient or another clinician.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "DeviceUseStatement.identifier",
            "path": "DeviceUseStatement.identifier",
            "short": "External identifier for this record",
            "definition": "An external identifier for this statement such as an IRI.",
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
            "id": "DeviceUseStatement.basedOn",
            "path": "DeviceUseStatement.basedOn",
            "short": "Fulfills plan, proposal or order",
            "definition": "A plan, proposal or order that is fulfilled in whole or in part by this DeviceUseStatement.",
            "requirements": "Allows tracing of authorization for the DeviceUseStatement and tracking whether proposals/recommendations were acted upon.",
            "alias": [
              "fulfills"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/ServiceRequest"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "DeviceUseStatement.status",
            "path": "DeviceUseStatement.status",
            "short": "active | completed | entered-in-error +",
            "definition": "A code representing the patient or other source's judgment about the state of the device used that this statement is about.  Generally this will be active or completed.",
            "comment": "DeviceUseStatment is a statement at a point in time.  The status is only representative at the point when it was asserted.  The value set for contains codes that assert the status of the use  by the patient (for example, stopped or on hold) as well as codes that assert the status of the resource itself (for example, entered in error).\r\rThis element is labeled as a modifier because the status contains the codes that mark the statement as not currently valid.",
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
                  "valueString": "DeviceUseStatementStatus"
                }
              ],
              "strength": "required",
              "description": "A coded concept indicating the current status of the Device Usage.",
              "valueSet": "http://hl7.org/fhir/ValueSet/device-statement-status|4.0.0"
            }
          },
          {
            "id": "DeviceUseStatement.subject",
            "path": "DeviceUseStatement.subject",
            "short": "Patient using device",
            "definition": "The patient who used the device.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Group"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "DeviceUseStatement.derivedFrom",
            "path": "DeviceUseStatement.derivedFrom",
            "short": "Supporting information",
            "definition": "Allows linking the DeviceUseStatement to the underlying Request, or to other information that supports or is used to derive the DeviceUseStatement.",
            "comment": "The most common use cases for deriving a DeviceUseStatement comes from creating it from a request or from an observation or a claim. it should be noted that the amount of information that is available varies from the type resource that you derive the DeviceUseStatement from.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/ServiceRequest",
                  "http://hl7.org/fhir/StructureDefinition/Procedure",
                  "http://hl7.org/fhir/StructureDefinition/Claim",
                  "http://hl7.org/fhir/StructureDefinition/Observation",
                  "http://hl7.org/fhir/StructureDefinition/QuestionnaireResponse",
                  "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "DeviceUseStatement.timing[x]",
            "path": "DeviceUseStatement.timing[x]",
            "short": "How often  the device was used",
            "definition": "How often the device was used.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Timing"
              },
              {
                "code": "Period"
              },
              {
                "code": "dateTime"
              }
            ],
            "isSummary": true
          },
          {
            "id": "DeviceUseStatement.recordedOn",
            "path": "DeviceUseStatement.recordedOn",
            "short": "When statement was recorded",
            "definition": "The time at which the statement was made/recorded.",
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
            "id": "DeviceUseStatement.source",
            "path": "DeviceUseStatement.source",
            "short": "Who made the statement",
            "definition": "Who reported the device was being used by the patient.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "DeviceUseStatement.device",
            "path": "DeviceUseStatement.device",
            "short": "Reference to device used",
            "definition": "The details of the device used.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Device"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "DeviceUseStatement.reasonCode",
            "path": "DeviceUseStatement.reasonCode",
            "short": "Why device was used",
            "definition": "Reason or justification for the use of the device.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "DeviceUseStatement.reasonReference",
            "path": "DeviceUseStatement.reasonReference",
            "short": "Why was DeviceUseStatement performed?",
            "definition": "Indicates another resource whose existence justifies this DeviceUseStatement.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Condition",
                  "http://hl7.org/fhir/StructureDefinition/Observation",
                  "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",
                  "http://hl7.org/fhir/StructureDefinition/DocumentReference",
                  "http://hl7.org/fhir/StructureDefinition/Media"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "DeviceUseStatement.bodySite",
            "path": "DeviceUseStatement.bodySite",
            "short": "Target body site",
            "definition": "Indicates the anotomic location on the subject's body where the device was used ( i.e. the target).",
            "requirements": "Knowing where the device is targeted is important for tracking if multiple sites are possible. If more information than just a code is required, use the extension [http://hl7.org/fhir/StructureDefinition/bodySite](null.html).",
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
                  "valueString": "BodySite"
                }
              ],
              "strength": "example",
              "description": "Codes describing anatomical locations. May include laterality.",
              "valueSet": "http://hl7.org/fhir/ValueSet/body-site"
            }
          },
          {
            "id": "DeviceUseStatement.note",
            "path": "DeviceUseStatement.note",
            "short": "Addition details (comments, instructions)",
            "definition": "Details about the device statement that were not represented at all or sufficiently in one of the attributes provided in a class. These may include for example a comment, an instruction, or a note associated with the statement.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Annotation"
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion
    /// <summary>
    /// Fhir resource 'DeviceUseStatement'
    /// </summary>
    // 0. DeviceUseStatement
    public partial class Resource_DeviceUseStatement : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 1. DeviceUseStatement.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. DeviceUseStatement.basedOn
        public ElementDefinitionInfo Element_BasedOn;
        // 3. DeviceUseStatement.status
        public ElementDefinitionInfo Element_Status;
        // 4. DeviceUseStatement.subject
        public ElementDefinitionInfo Element_Subject;
        // 5. DeviceUseStatement.derivedFrom
        public ElementDefinitionInfo Element_DerivedFrom;
        // 6. DeviceUseStatement.timing[x]
        public ElementDefinitionInfo Element_Timing;
        // 7. DeviceUseStatement.recordedOn
        public ElementDefinitionInfo Element_RecordedOn;
        // 8. DeviceUseStatement.source
        public ElementDefinitionInfo Element_Source;
        // 9. DeviceUseStatement.device
        public ElementDefinitionInfo Element_Device;
        // 10. DeviceUseStatement.reasonCode
        public ElementDefinitionInfo Element_ReasonCode;
        // 11. DeviceUseStatement.reasonReference
        public ElementDefinitionInfo Element_ReasonReference;
        // 12. DeviceUseStatement.bodySite
        public ElementDefinitionInfo Element_BodySite;
        // 13. DeviceUseStatement.note
        public ElementDefinitionInfo Element_Note;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "DeviceUseStatement",
                ElementId = "DeviceUseStatement"
            });
            Element_Identifier.Write(sDef);
            Element_BasedOn.Write(sDef);
            Element_Status.Write(sDef);
            Element_Subject.Write(sDef);
            Element_DerivedFrom.Write(sDef);
            Element_Timing.Write(sDef);
            Element_RecordedOn.Write(sDef);
            Element_Source.Write(sDef);
            Element_Device.Write(sDef);
            Element_ReasonCode.Write(sDef);
            Element_ReasonReference.Write(sDef);
            Element_BodySite.Write(sDef);
            Element_Note.Write(sDef);
        }
        
        public Resource_DeviceUseStatement()
        {
            {
                // 1. DeviceUseStatement.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "DeviceUseStatement.identifier",
                    Id = "DeviceUseStatement.identifier",
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
                // 2. DeviceUseStatement.basedOn
                this.Element_BasedOn = new ElementDefinitionInfo
                {
                    Name = "Element_BasedOn",
                    Path= "DeviceUseStatement.basedOn",
                    Id = "DeviceUseStatement.basedOn",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/ServiceRequest"
                            }
                        }
                    }
                };
            }
            {
                // 3. DeviceUseStatement.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "DeviceUseStatement.status",
                    Id = "DeviceUseStatement.status",
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
                // 4. DeviceUseStatement.subject
                this.Element_Subject = new ElementDefinitionInfo
                {
                    Name = "Element_Subject",
                    Path= "DeviceUseStatement.subject",
                    Id = "DeviceUseStatement.subject",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Patient",
                                "http://hl7.org/fhir/StructureDefinition/Group"
                            }
                        }
                    }
                };
            }
            {
                // 5. DeviceUseStatement.derivedFrom
                this.Element_DerivedFrom = new ElementDefinitionInfo
                {
                    Name = "Element_DerivedFrom",
                    Path= "DeviceUseStatement.derivedFrom",
                    Id = "DeviceUseStatement.derivedFrom",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/ServiceRequest",
                                "http://hl7.org/fhir/StructureDefinition/Procedure",
                                "http://hl7.org/fhir/StructureDefinition/Claim",
                                "http://hl7.org/fhir/StructureDefinition/Observation",
                                "http://hl7.org/fhir/StructureDefinition/QuestionnaireResponse",
                                "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                            }
                        }
                    }
                };
            }
            {
                // 6. DeviceUseStatement.timing[x]
                this.Element_Timing = new ElementDefinitionInfo
                {
                    Name = "Element_Timing",
                    Path= "DeviceUseStatement.timing[x]",
                    Id = "DeviceUseStatement.timing[x]",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Timing
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Period
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                        {
                        }
                    }
                };
            }
            {
                // 7. DeviceUseStatement.recordedOn
                this.Element_RecordedOn = new ElementDefinitionInfo
                {
                    Name = "Element_RecordedOn",
                    Path= "DeviceUseStatement.recordedOn",
                    Id = "DeviceUseStatement.recordedOn",
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
                // 8. DeviceUseStatement.source
                this.Element_Source = new ElementDefinitionInfo
                {
                    Name = "Element_Source",
                    Path= "DeviceUseStatement.source",
                    Id = "DeviceUseStatement.source",
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
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                                "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                            }
                        }
                    }
                };
            }
            {
                // 9. DeviceUseStatement.device
                this.Element_Device = new ElementDefinitionInfo
                {
                    Name = "Element_Device",
                    Path= "DeviceUseStatement.device",
                    Id = "DeviceUseStatement.device",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Device"
                            }
                        }
                    }
                };
            }
            {
                // 10. DeviceUseStatement.reasonCode
                this.Element_ReasonCode = new ElementDefinitionInfo
                {
                    Name = "Element_ReasonCode",
                    Path= "DeviceUseStatement.reasonCode",
                    Id = "DeviceUseStatement.reasonCode",
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
                // 11. DeviceUseStatement.reasonReference
                this.Element_ReasonReference = new ElementDefinitionInfo
                {
                    Name = "Element_ReasonReference",
                    Path= "DeviceUseStatement.reasonReference",
                    Id = "DeviceUseStatement.reasonReference",
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
                                "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",
                                "http://hl7.org/fhir/StructureDefinition/DocumentReference",
                                "http://hl7.org/fhir/StructureDefinition/Media"
                            }
                        }
                    }
                };
            }
            {
                // 12. DeviceUseStatement.bodySite
                this.Element_BodySite = new ElementDefinitionInfo
                {
                    Name = "Element_BodySite",
                    Path= "DeviceUseStatement.bodySite",
                    Id = "DeviceUseStatement.bodySite",
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
                // 13. DeviceUseStatement.note
                this.Element_Note = new ElementDefinitionInfo
                {
                    Name = "Element_Note",
                    Path= "DeviceUseStatement.note",
                    Id = "DeviceUseStatement.note",
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
            this.Name = "DeviceUseStatement";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/DeviceUseStatement";
        }
    }
}
