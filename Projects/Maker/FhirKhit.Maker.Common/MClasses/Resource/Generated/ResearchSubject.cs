using System;                                                                                                                               // MakerGen.cs:462
using System.Diagnostics;                                                                                                                   // MakerGen.cs:463
using System.IO;                                                                                                                            // MakerGen.cs:464
using System.Linq;                                                                                                                          // MakerGen.cs:465
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:466
                                                                                                                                            // MakerGen.cs:467
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:468
{                                                                                                                                           // MakerGen.cs:469
    #region Json                                                                                                                            // MakerGen.cs:470
    #if NEVER                                                                                                                               // MakerGen.cs:471
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
    #endregion                                                                                                                              // MakerGen.cs:474
    /// <summary>
    /// Fhir resource 'ResearchSubject'
    /// </summary>
    // 0. ResearchSubject
    public class ResearchSubject : FhirKhit.Maker.Common.Resource.ResourceBase                                                              // MakerGen.cs:384
    {                                                                                                                                       // MakerGen.cs:385
        public class ResearchSubject_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                 // MakerGen.cs:386
        {                                                                                                                                   // MakerGen.cs:387
            // 1. ResearchSubject.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:216
            // 2. ResearchSubject.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:216
            // 3. ResearchSubject.period
            public ElementDefinitionInfo Period;                                                                                            // MakerGen.cs:216
            // 4. ResearchSubject.study
            public ElementDefinitionInfo Study;                                                                                             // MakerGen.cs:216
            // 5. ResearchSubject.individual
            public ElementDefinitionInfo Individual;                                                                                        // MakerGen.cs:216
            // 6. ResearchSubject.assignedArm
            public ElementDefinitionInfo AssignedArm;                                                                                       // MakerGen.cs:216
            // 7. ResearchSubject.actualArm
            public ElementDefinitionInfo ActualArm;                                                                                         // MakerGen.cs:216
            // 8. ResearchSubject.consent
            public ElementDefinitionInfo Consent;                                                                                           // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
            public ResearchSubject_Elements()                                                                                               // MakerGen.cs:392
            {                                                                                                                               // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:231
                    // 1. ResearchSubject.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Identifier",                                                                                                // MakerGen.cs:235
                        Path= "ResearchSubject.identifier",                                                                                 // MakerGen.cs:236
                        Id = "ResearchSubject.identifier",                                                                                  // MakerGen.cs:237
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
                    // 2. ResearchSubject.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Status",                                                                                                    // MakerGen.cs:235
                        Path= "ResearchSubject.status",                                                                                     // MakerGen.cs:236
                        Id = "ResearchSubject.status",                                                                                      // MakerGen.cs:237
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
                    // 3. ResearchSubject.period
                    this.Period = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Period",                                                                                                    // MakerGen.cs:235
                        Path= "ResearchSubject.period",                                                                                     // MakerGen.cs:236
                        Id = "ResearchSubject.period",                                                                                      // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 4. ResearchSubject.study
                    this.Study = new ElementDefinitionInfo                                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Study",                                                                                                     // MakerGen.cs:235
                        Path= "ResearchSubject.study",                                                                                      // MakerGen.cs:236
                        Id = "ResearchSubject.study",                                                                                       // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/ResearchStudy"                                                 // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 5. ResearchSubject.individual
                    this.Individual = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Individual",                                                                                                // MakerGen.cs:235
                        Path= "ResearchSubject.individual",                                                                                 // MakerGen.cs:236
                        Id = "ResearchSubject.individual",                                                                                  // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient"                                                       // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 6. ResearchSubject.assignedArm
                    this.AssignedArm = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "AssignedArm",                                                                                               // MakerGen.cs:235
                        Path= "ResearchSubject.assignedArm",                                                                                // MakerGen.cs:236
                        Id = "ResearchSubject.assignedArm",                                                                                 // MakerGen.cs:237
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
                    // 7. ResearchSubject.actualArm
                    this.ActualArm = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ActualArm",                                                                                                 // MakerGen.cs:235
                        Path= "ResearchSubject.actualArm",                                                                                  // MakerGen.cs:236
                        Id = "ResearchSubject.actualArm",                                                                                   // MakerGen.cs:237
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
                    // 8. ResearchSubject.consent
                    this.Consent = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Consent",                                                                                                   // MakerGen.cs:235
                        Path= "ResearchSubject.consent",                                                                                    // MakerGen.cs:236
                        Id = "ResearchSubject.consent",                                                                                     // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Consent"                                                       // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:398
            {                                                                                                                               // MakerGen.cs:399
                base.Write(sDef);                                                                                                           // MakerGen.cs:400
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:220
                Status.Write(sDef);                                                                                                         // MakerGen.cs:220
                Period.Write(sDef);                                                                                                         // MakerGen.cs:220
                Study.Write(sDef);                                                                                                          // MakerGen.cs:220
                Individual.Write(sDef);                                                                                                     // MakerGen.cs:220
                AssignedArm.Write(sDef);                                                                                                    // MakerGen.cs:220
                ActualArm.Write(sDef);                                                                                                      // MakerGen.cs:220
                Consent.Write(sDef);                                                                                                        // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:402
        }                                                                                                                                   // MakerGen.cs:404
        public ResearchSubject_Elements Elements                                                                                            // MakerGen.cs:406
        {                                                                                                                                   // MakerGen.cs:407
            get                                                                                                                             // MakerGen.cs:408
            {                                                                                                                               // MakerGen.cs:409
                if (this.elements == null)                                                                                                  // MakerGen.cs:410
                    this.elements = new ResearchSubject_Elements();                                                                         // MakerGen.cs:411
                return this.elements;                                                                                                       // MakerGen.cs:412
            }                                                                                                                               // MakerGen.cs:413
        }                                                                                                                                   // MakerGen.cs:414
        ResearchSubject_Elements elements;                                                                                                  // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
        public ResearchSubject()                                                                                                            // MakerGen.cs:418
        {                                                                                                                                   // MakerGen.cs:419
            this.Name = "ResearchSubject";                                                                                                  // MakerGen.cs:492
            this.Uri = "http://hl7.org/fhir/StructureDefinition/ResearchSubject";                                                           // MakerGen.cs:493
        }                                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:424
        {                                                                                                                                   // MakerGen.cs:425
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:426
            {                                                                                                                               // MakerGen.cs:427
                Path = "ResearchSubject",                                                                                                   // MakerGen.cs:428
                ElementId = "ResearchSubject"                                                                                               // MakerGen.cs:429
            });                                                                                                                             // MakerGen.cs:430
            if (this.elements != null)                                                                                                      // MakerGen.cs:431
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:432
        }                                                                                                                                   // MakerGen.cs:433
    }                                                                                                                                       // MakerGen.cs:434
}                                                                                                                                           // MakerGen.cs:479
