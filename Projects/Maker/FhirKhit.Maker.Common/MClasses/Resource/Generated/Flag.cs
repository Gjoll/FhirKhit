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
      "id": "Flag",
      "url": "http://hl7.org/fhir/StructureDefinition/Flag",
      "version": "4.0.0",
      "name": "Flag",
      "status": "draft",
      "publisher": "Health Level Seven International (Patient Care)",
      "description": "Prospective warnings of potential issues when providing care to the patient.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "Flag",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Flag",
            "path": "Flag",
            "short": "Key information to flag to healthcare providers",
            "definition": "Prospective warnings of potential issues when providing care to the patient.",
            "alias": [
              "Barriers to Care",
              "Alert",
              "Warning"
            ],
            "min": 0,
            "max": "*"
          },
          {
            "id": "Flag.identifier",
            "path": "Flag.identifier",
            "short": "Business identifier",
            "definition": "Business identifiers assigned to this flag by the performer or other systems which remain constant as the resource is updated and propagates from server to server.",
            "comment": "This is a business identifier, not a resource identifier (see [discussion](resource.html#identifiers)).  It is best practice for the identifier to only appear on a single resource instance, however business practices may occasionally dictate that multiple resource instances with the same identifier can exist - possibly even with different resource types.  For example, multiple Patient and a Person resource instance might share the same social insurance number.",
            "requirements": "Allows identification of the flag as it is known by various participating systems and in a way that remains consistent across servers.",
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
            "id": "Flag.status",
            "path": "Flag.status",
            "short": "active | inactive | entered-in-error",
            "definition": "Supports basic workflow.",
            "comment": "This element is labeled as a modifier because the status contains codes that mark the resource as not currently valid.",
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
                  "valueString": "FlagStatus"
                }
              ],
              "strength": "required",
              "description": "Indicates whether this flag is active and needs to be displayed to a user, or whether it is no longer needed or was entered in error.",
              "valueSet": "http://hl7.org/fhir/ValueSet/flag-status|4.0.0"
            }
          },
          {
            "id": "Flag.category",
            "path": "Flag.category",
            "short": "Clinical, administrative, etc.",
            "definition": "Allows a flag to be divided into different categories like clinical, administrative etc. Intended to be used as a means of filtering which flags are displayed to particular user or in a given context.",
            "comment": "The value set will often need to be adjusted based on local business rules and usage context.",
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
                  "valueString": "FlagCategory"
                }
              ],
              "strength": "example",
              "description": "A general category for flags for filtering/display purposes.",
              "valueSet": "http://hl7.org/fhir/ValueSet/flag-category"
            }
          },
          {
            "id": "Flag.code",
            "path": "Flag.code",
            "short": "Coded or textual message to display to user",
            "definition": "The coded value or textual component of the flag to display to the user.",
            "comment": "If non-coded, use CodeableConcept.text.  This element should always be included in the narrative.",
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
                  "valueString": "FlagCode"
                }
              ],
              "strength": "example",
              "description": "Detail codes identifying specific flagged issues.",
              "valueSet": "http://hl7.org/fhir/ValueSet/flag-code"
            }
          },
          {
            "id": "Flag.subject",
            "path": "Flag.subject",
            "short": "Who/What is flag about?",
            "definition": "The patient, location, group, organization, or practitioner etc. this is about record this flag is associated with.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Location",
                  "http://hl7.org/fhir/StructureDefinition/Group",
                  "http://hl7.org/fhir/StructureDefinition/Organization",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PlanDefinition",
                  "http://hl7.org/fhir/StructureDefinition/Medication",
                  "http://hl7.org/fhir/StructureDefinition/Procedure"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Flag.period",
            "path": "Flag.period",
            "short": "Time period when flag is active",
            "definition": "The period of time from the activation of the flag to inactivation of the flag. If the flag is active, the end of the period should be unspecified.",
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
            "id": "Flag.encounter",
            "path": "Flag.encounter",
            "short": "Alert relevant during encounter",
            "definition": "This alert is only relevant during the encounter.",
            "comment": "If both Flag.encounter and Flag.period are valued, then Flag.period.start shall not be before Encounter.period.start and Flag.period.end shall not be after Encounter.period.end.",
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
            "id": "Flag.author",
            "path": "Flag.author",
            "short": "Flag creator",
            "definition": "The person, organization or device that created the flag.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/Organization",
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole"
                ]
              }
            ],
            "isSummary": true
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:463
    /// <summary>
    /// Fhir resource 'Flag'
    /// </summary>
    // 0. Flag
    public class Flag : FhirKhit.Maker.Common.Resource.ResourceBase                                                                         // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class Flag_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                            // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 1. Flag.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:236
            // 2. Flag.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:236
            // 3. Flag.category
            public ElementDefinitionInfo Category;                                                                                          // MakerGen.cs:236
            // 4. Flag.code
            public ElementDefinitionInfo Code;                                                                                              // MakerGen.cs:236
            // 5. Flag.subject
            public ElementDefinitionInfo Subject;                                                                                           // MakerGen.cs:236
            // 6. Flag.period
            public ElementDefinitionInfo Period;                                                                                            // MakerGen.cs:236
            // 7. Flag.encounter
            public ElementDefinitionInfo Encounter;                                                                                         // MakerGen.cs:236
            // 8. Flag.author
            public ElementDefinitionInfo Author;                                                                                            // MakerGen.cs:236
            public Flag_Elements()                                                                                                          // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:251
                    // 1. Flag.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Identifier",                                                                                                // MakerGen.cs:255
                        Path= "Flag.identifier",                                                                                            // MakerGen.cs:256
                        Id = "Flag.identifier",                                                                                             // MakerGen.cs:257
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
                    // 2. Flag.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Status",                                                                                                    // MakerGen.cs:255
                        Path= "Flag.status",                                                                                                // MakerGen.cs:256
                        Id = "Flag.status",                                                                                                 // MakerGen.cs:257
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
                    // 3. Flag.category
                    this.Category = new ElementDefinitionInfo                                                                               // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Category",                                                                                                  // MakerGen.cs:255
                        Path= "Flag.category",                                                                                              // MakerGen.cs:256
                        Id = "Flag.category",                                                                                               // MakerGen.cs:257
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
                    // 4. Flag.code
                    this.Code = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Code",                                                                                                      // MakerGen.cs:255
                        Path= "Flag.code",                                                                                                  // MakerGen.cs:256
                        Id = "Flag.code",                                                                                                   // MakerGen.cs:257
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
                    // 5. Flag.subject
                    this.Subject = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Subject",                                                                                                   // MakerGen.cs:255
                        Path= "Flag.subject",                                                                                               // MakerGen.cs:256
                        Id = "Flag.subject",                                                                                                // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Location",                                                     // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Group",                                                        // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Organization",                                                 // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/PlanDefinition",                                               // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Medication",                                                   // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Procedure"                                                     // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 6. Flag.period
                    this.Period = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Period",                                                                                                    // MakerGen.cs:255
                        Path= "Flag.period",                                                                                                // MakerGen.cs:256
                        Id = "Flag.period",                                                                                                 // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 7. Flag.encounter
                    this.Encounter = new ElementDefinitionInfo                                                                              // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Encounter",                                                                                                 // MakerGen.cs:255
                        Path= "Flag.encounter",                                                                                             // MakerGen.cs:256
                        Id = "Flag.encounter",                                                                                              // MakerGen.cs:257
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
                    // 8. Flag.author
                    this.Author = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Author",                                                                                                    // MakerGen.cs:255
                        Path= "Flag.author",                                                                                                // MakerGen.cs:256
                        Id = "Flag.author",                                                                                                 // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Device",                                                       // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Organization",                                                 // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                              // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:429
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:414
            {                                                                                                                               // MakerGen.cs:415
                base.Write(sDef);                                                                                                           // MakerGen.cs:416
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:240
                Status.Write(sDef);                                                                                                         // MakerGen.cs:240
                Category.Write(sDef);                                                                                                       // MakerGen.cs:240
                Code.Write(sDef);                                                                                                           // MakerGen.cs:240
                Subject.Write(sDef);                                                                                                        // MakerGen.cs:240
                Period.Write(sDef);                                                                                                         // MakerGen.cs:240
                Encounter.Write(sDef);                                                                                                      // MakerGen.cs:240
                Author.Write(sDef);                                                                                                         // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public Flag_Elements Elements { get; }                                                                                              // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public Flag()                                                                                                                       // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new Flag_Elements();                                                                                            // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:468
