using System;                                                                                                                               // MakerGen.cs:454
using System.Diagnostics;                                                                                                                   // MakerGen.cs:455
using System.IO;                                                                                                                            // MakerGen.cs:456
using System.Linq;                                                                                                                          // MakerGen.cs:457
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:458
                                                                                                                                            // MakerGen.cs:459
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:460
{                                                                                                                                           // MakerGen.cs:461
    #region Json                                                                                                                            // MakerGen.cs:462
    #if NEVER                                                                                                                               // MakerGen.cs:463
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
    #endregion                                                                                                                              // MakerGen.cs:466
    /// <summary>
    /// Fhir resource 'DeviceUseStatement'
    /// </summary>
    // 0. DeviceUseStatement
    public class Resource_DeviceUseStatement : FhirKhit.Maker.Common.Resource.ResourceBase                                                  // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        public class Resource_DeviceUseStatement_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                     // MakerGen.cs:378
        {                                                                                                                                   // MakerGen.cs:379
            // 1. DeviceUseStatement.identifier
            public ElementDefinitionInfo Element_Identifier;                                                                                // MakerGen.cs:211
            // 2. DeviceUseStatement.basedOn
            public ElementDefinitionInfo Element_BasedOn;                                                                                   // MakerGen.cs:211
            // 3. DeviceUseStatement.status
            public ElementDefinitionInfo Element_Status;                                                                                    // MakerGen.cs:211
            // 4. DeviceUseStatement.subject
            public ElementDefinitionInfo Element_Subject;                                                                                   // MakerGen.cs:211
            // 5. DeviceUseStatement.derivedFrom
            public ElementDefinitionInfo Element_DerivedFrom;                                                                               // MakerGen.cs:211
            // 6. DeviceUseStatement.timing[x]
            public ElementDefinitionInfo Element_Timing;                                                                                    // MakerGen.cs:211
            // 7. DeviceUseStatement.recordedOn
            public ElementDefinitionInfo Element_RecordedOn;                                                                                // MakerGen.cs:211
            // 8. DeviceUseStatement.source
            public ElementDefinitionInfo Element_Source;                                                                                    // MakerGen.cs:211
            // 9. DeviceUseStatement.device
            public ElementDefinitionInfo Element_Device;                                                                                    // MakerGen.cs:211
            // 10. DeviceUseStatement.reasonCode
            public ElementDefinitionInfo Element_ReasonCode;                                                                                // MakerGen.cs:211
            // 11. DeviceUseStatement.reasonReference
            public ElementDefinitionInfo Element_ReasonReference;                                                                           // MakerGen.cs:211
            // 12. DeviceUseStatement.bodySite
            public ElementDefinitionInfo Element_BodySite;                                                                                  // MakerGen.cs:211
            // 13. DeviceUseStatement.note
            public ElementDefinitionInfo Element_Note;                                                                                      // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
            public Resource_DeviceUseStatement_Elements()                                                                                   // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:226
                    // 1. DeviceUseStatement.identifier
                    this.Element_Identifier = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Identifier",                                                                                        // MakerGen.cs:230
                        Path= "DeviceUseStatement.identifier",                                                                              // MakerGen.cs:231
                        Id = "DeviceUseStatement.identifier",                                                                               // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Identifier                                                               // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 2. DeviceUseStatement.basedOn
                    this.Element_BasedOn = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_BasedOn",                                                                                           // MakerGen.cs:230
                        Path= "DeviceUseStatement.basedOn",                                                                                 // MakerGen.cs:231
                        Id = "DeviceUseStatement.basedOn",                                                                                  // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/ServiceRequest"                                                // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 3. DeviceUseStatement.status
                    this.Element_Status = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Status",                                                                                            // MakerGen.cs:230
                        Path= "DeviceUseStatement.status",                                                                                  // MakerGen.cs:231
                        Id = "DeviceUseStatement.status",                                                                                   // MakerGen.cs:232
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
                    // 4. DeviceUseStatement.subject
                    this.Element_Subject = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Subject",                                                                                           // MakerGen.cs:230
                        Path= "DeviceUseStatement.subject",                                                                                 // MakerGen.cs:231
                        Id = "DeviceUseStatement.subject",                                                                                  // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/Group"                                                         // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 5. DeviceUseStatement.derivedFrom
                    this.Element_DerivedFrom = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_DerivedFrom",                                                                                       // MakerGen.cs:230
                        Path= "DeviceUseStatement.derivedFrom",                                                                             // MakerGen.cs:231
                        Id = "DeviceUseStatement.derivedFrom",                                                                              // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/ServiceRequest",                                               // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/Procedure",                                                    // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/Claim",                                                        // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/Observation",                                                  // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/QuestionnaireResponse",                                        // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/DocumentReference"                                             // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 6. DeviceUseStatement.timing[x]
                    this.Element_Timing = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Timing",                                                                                            // MakerGen.cs:230
                        Path= "DeviceUseStatement.timing[x]",                                                                               // MakerGen.cs:231
                        Id = "DeviceUseStatement.timing[x]",                                                                                // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Timing                                                                   // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            },                                                                                                              // MakerGen.cs:352
                            new FhirKhit.Maker.Common.Complex.Type_Period                                                                   // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            },                                                                                                              // MakerGen.cs:352
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 7. DeviceUseStatement.recordedOn
                    this.Element_RecordedOn = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_RecordedOn",                                                                                        // MakerGen.cs:230
                        Path= "DeviceUseStatement.recordedOn",                                                                              // MakerGen.cs:231
                        Id = "DeviceUseStatement.recordedOn",                                                                               // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
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
                    // 8. DeviceUseStatement.source
                    this.Element_Source = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Source",                                                                                            // MakerGen.cs:230
                        Path= "DeviceUseStatement.source",                                                                                  // MakerGen.cs:231
                        Id = "DeviceUseStatement.source",                                                                                   // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson"                                                 // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 9. DeviceUseStatement.device
                    this.Element_Device = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Device",                                                                                            // MakerGen.cs:230
                        Path= "DeviceUseStatement.device",                                                                                  // MakerGen.cs:231
                        Id = "DeviceUseStatement.device",                                                                                   // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Device"                                                        // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 10. DeviceUseStatement.reasonCode
                    this.Element_ReasonCode = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_ReasonCode",                                                                                        // MakerGen.cs:230
                        Path= "DeviceUseStatement.reasonCode",                                                                              // MakerGen.cs:231
                        Id = "DeviceUseStatement.reasonCode",                                                                               // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 11. DeviceUseStatement.reasonReference
                    this.Element_ReasonReference = new ElementDefinitionInfo                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_ReasonReference",                                                                                   // MakerGen.cs:230
                        Path= "DeviceUseStatement.reasonReference",                                                                         // MakerGen.cs:231
                        Id = "DeviceUseStatement.reasonReference",                                                                          // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Condition",                                                    // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/Observation",                                                  // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",                                             // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/DocumentReference",                                            // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/Media"                                                         // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 12. DeviceUseStatement.bodySite
                    this.Element_BodySite = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_BodySite",                                                                                          // MakerGen.cs:230
                        Path= "DeviceUseStatement.bodySite",                                                                                // MakerGen.cs:231
                        Id = "DeviceUseStatement.bodySite",                                                                                 // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 13. DeviceUseStatement.note
                    this.Element_Note = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Note",                                                                                              // MakerGen.cs:230
                        Path= "DeviceUseStatement.note",                                                                                    // MakerGen.cs:231
                        Id = "DeviceUseStatement.note",                                                                                     // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Annotation                                                               // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                Element_Identifier.Write(sDef);                                                                                             // MakerGen.cs:215
                Element_BasedOn.Write(sDef);                                                                                                // MakerGen.cs:215
                Element_Status.Write(sDef);                                                                                                 // MakerGen.cs:215
                Element_Subject.Write(sDef);                                                                                                // MakerGen.cs:215
                Element_DerivedFrom.Write(sDef);                                                                                            // MakerGen.cs:215
                Element_Timing.Write(sDef);                                                                                                 // MakerGen.cs:215
                Element_RecordedOn.Write(sDef);                                                                                             // MakerGen.cs:215
                Element_Source.Write(sDef);                                                                                                 // MakerGen.cs:215
                Element_Device.Write(sDef);                                                                                                 // MakerGen.cs:215
                Element_ReasonCode.Write(sDef);                                                                                             // MakerGen.cs:215
                Element_ReasonReference.Write(sDef);                                                                                        // MakerGen.cs:215
                Element_BodySite.Write(sDef);                                                                                               // MakerGen.cs:215
                Element_Note.Write(sDef);                                                                                                   // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:394
        }                                                                                                                                   // MakerGen.cs:396
        public Resource_DeviceUseStatement_Elements Elements                                                                                // MakerGen.cs:398
        {                                                                                                                                   // MakerGen.cs:399
            get                                                                                                                             // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                if (this.elements == null)                                                                                                  // MakerGen.cs:402
                    this.elements = new Resource_DeviceUseStatement_Elements();                                                             // MakerGen.cs:403
                return this.elements;                                                                                                       // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:406
        Resource_DeviceUseStatement_Elements elements;                                                                                      // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
        public Resource_DeviceUseStatement()                                                                                                // MakerGen.cs:410
        {                                                                                                                                   // MakerGen.cs:411
            this.Name = "DeviceUseStatement";                                                                                               // MakerGen.cs:484
            this.Uri = "http://hl7.org/fhir/StructureDefinition/DeviceUseStatement";                                                        // MakerGen.cs:485
        }                                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:416
        {                                                                                                                                   // MakerGen.cs:417
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:418
            {                                                                                                                               // MakerGen.cs:419
                Path = "DeviceUseStatement",                                                                                                // MakerGen.cs:420
                ElementId = "DeviceUseStatement"                                                                                            // MakerGen.cs:421
            });                                                                                                                             // MakerGen.cs:422
            if (this.elements != null)                                                                                                      // MakerGen.cs:423
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:424
        }                                                                                                                                   // MakerGen.cs:425
    }                                                                                                                                       // MakerGen.cs:426
}                                                                                                                                           // MakerGen.cs:471
