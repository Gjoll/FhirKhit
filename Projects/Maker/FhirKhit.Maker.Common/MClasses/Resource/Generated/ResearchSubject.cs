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
      "id": "ResearchSubject",
      "url": "http://hl7.org/fhir/StructureDefinition/ResearchSubject",
      "version": "4.0.0",
      "name": "ResearchSubject",
      "status": "draft",
      "publisher": "Health Level Seven International (Biomedical Research and Regulation)",
      "description": "A physical entity which is the primary unit of operational and/or administrative interest in a study.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "ResearchSubject",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "ResearchSubject",
            "path": "ResearchSubject",
            "short": "Physical entity which is the primary unit of interest in the study",
            "definition": "A physical entity which is the primary unit of operational and/or administrative interest in a study.",
            "comment": "Need to make sure we encompass public health studies.",
            "alias": [
              "Study Subject"
            ],
            "min": 0,
            "max": "*"
          },
          {
            "id": "ResearchSubject.identifier",
            "path": "ResearchSubject.identifier",
            "short": "Business Identifier for research subject in a study",
            "definition": "Identifiers assigned to this research subject for a study.",
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
            "id": "ResearchSubject.status",
            "path": "ResearchSubject.status",
            "short": "candidate | eligible | follow-up | ineligible | not-registered | off-study | on-study | on-study-intervention | on-study-observation | pending-on-study | potential-candidate | screening | withdrawn",
            "definition": "The current state of the subject.",
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
                  "valueString": "ResearchSubjectStatus"
                }
              ],
              "strength": "required",
              "description": "Indicates the progression of a study subject through a study.",
              "valueSet": "http://hl7.org/fhir/ValueSet/research-subject-status|4.0.0"
            }
          },
          {
            "id": "ResearchSubject.period",
            "path": "ResearchSubject.period",
            "short": "Start and end of participation",
            "definition": "The dates the subject began and ended their participation in the study.",
            "alias": [
              "timing"
            ],
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
            "id": "ResearchSubject.study",
            "path": "ResearchSubject.study",
            "short": "Study subject is part of",
            "definition": "Reference to the study the subject is participating in.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/ResearchStudy"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "ResearchSubject.individual",
            "path": "ResearchSubject.individual",
            "short": "Who is part of study",
            "definition": "The record of the person or animal who is involved in the study.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "ResearchSubject.assignedArm",
            "path": "ResearchSubject.assignedArm",
            "short": "What path should be followed",
            "definition": "The name of the arm in the study the subject is expected to follow as part of this study.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ResearchSubject.actualArm",
            "path": "ResearchSubject.actualArm",
            "short": "What path was followed",
            "definition": "The name of the arm in the study the subject actually followed as part of this study.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ResearchSubject.consent",
            "path": "ResearchSubject.consent",
            "short": "Agreement to participate in study",
            "definition": "A record of the patient's informed agreement to participate in the study.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Consent"
                ]
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:469
    /// <summary>
    /// Fhir resource 'ResearchSubject'
    /// </summary>
    // 0. ResearchSubject
    public class ResearchSubject : FhirKhit.Maker.Common.Resource.ResourceBase                                                              // MakerGen.cs:379
    {                                                                                                                                       // MakerGen.cs:380
        public class ResearchSubject_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                 // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 1. ResearchSubject.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:211
            // 2. ResearchSubject.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:211
            // 3. ResearchSubject.period
            public ElementDefinitionInfo Period;                                                                                            // MakerGen.cs:211
            // 4. ResearchSubject.study
            public ElementDefinitionInfo Study;                                                                                             // MakerGen.cs:211
            // 5. ResearchSubject.individual
            public ElementDefinitionInfo Individual;                                                                                        // MakerGen.cs:211
            // 6. ResearchSubject.assignedArm
            public ElementDefinitionInfo AssignedArm;                                                                                       // MakerGen.cs:211
            // 7. ResearchSubject.actualArm
            public ElementDefinitionInfo ActualArm;                                                                                         // MakerGen.cs:211
            // 8. ResearchSubject.consent
            public ElementDefinitionInfo Consent;                                                                                           // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
            public ResearchSubject_Elements()                                                                                               // MakerGen.cs:387
            {                                                                                                                               // MakerGen.cs:388
                {                                                                                                                           // MakerGen.cs:226
                    // 1. ResearchSubject.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Identifier",                                                                                                // MakerGen.cs:230
                        Path= "ResearchSubject.identifier",                                                                                 // MakerGen.cs:231
                        Id = "ResearchSubject.identifier",                                                                                  // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 2. ResearchSubject.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Status",                                                                                                    // MakerGen.cs:230
                        Path= "ResearchSubject.status",                                                                                     // MakerGen.cs:231
                        Id = "ResearchSubject.status",                                                                                      // MakerGen.cs:232
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
                    // 3. ResearchSubject.period
                    this.Period = new ElementDefinitionInfo                                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Period",                                                                                                    // MakerGen.cs:230
                        Path= "ResearchSubject.period",                                                                                     // MakerGen.cs:231
                        Id = "ResearchSubject.period",                                                                                      // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 4. ResearchSubject.study
                    this.Study = new ElementDefinitionInfo                                                                                  // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Study",                                                                                                     // MakerGen.cs:230
                        Path= "ResearchSubject.study",                                                                                      // MakerGen.cs:231
                        Id = "ResearchSubject.study",                                                                                       // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/ResearchStudy"                                                 // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 5. ResearchSubject.individual
                    this.Individual = new ElementDefinitionInfo                                                                             // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Individual",                                                                                                // MakerGen.cs:230
                        Path= "ResearchSubject.individual",                                                                                 // MakerGen.cs:231
                        Id = "ResearchSubject.individual",                                                                                  // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient"                                                       // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 6. ResearchSubject.assignedArm
                    this.AssignedArm = new ElementDefinitionInfo                                                                            // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "AssignedArm",                                                                                               // MakerGen.cs:230
                        Path= "ResearchSubject.assignedArm",                                                                                // MakerGen.cs:231
                        Id = "ResearchSubject.assignedArm",                                                                                 // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
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
                    // 7. ResearchSubject.actualArm
                    this.ActualArm = new ElementDefinitionInfo                                                                              // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "ActualArm",                                                                                                 // MakerGen.cs:230
                        Path= "ResearchSubject.actualArm",                                                                                  // MakerGen.cs:231
                        Id = "ResearchSubject.actualArm",                                                                                   // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
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
                    // 8. ResearchSubject.consent
                    this.Consent = new ElementDefinitionInfo                                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Consent",                                                                                                   // MakerGen.cs:230
                        Path= "ResearchSubject.consent",                                                                                    // MakerGen.cs:231
                        Id = "ResearchSubject.consent",                                                                                     // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Consent"                                                       // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
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
                Period.Write(sDef);                                                                                                         // MakerGen.cs:215
                Study.Write(sDef);                                                                                                          // MakerGen.cs:215
                Individual.Write(sDef);                                                                                                     // MakerGen.cs:215
                AssignedArm.Write(sDef);                                                                                                    // MakerGen.cs:215
                ActualArm.Write(sDef);                                                                                                      // MakerGen.cs:215
                Consent.Write(sDef);                                                                                                        // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:397
        }                                                                                                                                   // MakerGen.cs:399
        public ResearchSubject_Elements Elements                                                                                            // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            get                                                                                                                             // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:404
                if (this.elements == null)                                                                                                  // MakerGen.cs:405
                    this.elements = new ResearchSubject_Elements();                                                                         // MakerGen.cs:406
                return this.elements;                                                                                                       // MakerGen.cs:407
            }                                                                                                                               // MakerGen.cs:408
        }                                                                                                                                   // MakerGen.cs:409
        ResearchSubject_Elements elements;                                                                                                  // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
        public ResearchSubject()                                                                                                            // MakerGen.cs:413
        {                                                                                                                                   // MakerGen.cs:414
            this.Name = "ResearchSubject";                                                                                                  // MakerGen.cs:487
            this.Uri = "http://hl7.org/fhir/StructureDefinition/ResearchSubject";                                                           // MakerGen.cs:488
        }                                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:419
        {                                                                                                                                   // MakerGen.cs:420
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:421
            {                                                                                                                               // MakerGen.cs:422
                Path = "ResearchSubject",                                                                                                   // MakerGen.cs:423
                ElementId = "ResearchSubject"                                                                                               // MakerGen.cs:424
            });                                                                                                                             // MakerGen.cs:425
            if (this.elements != null)                                                                                                      // MakerGen.cs:426
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:427
        }                                                                                                                                   // MakerGen.cs:428
    }                                                                                                                                       // MakerGen.cs:429
}                                                                                                                                           // MakerGen.cs:474
