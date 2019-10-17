using System;                                                                                                                               // MakerGen.cs:432
using System.Diagnostics;                                                                                                                   // MakerGen.cs:433
using System.IO;                                                                                                                            // MakerGen.cs:434
using System.Linq;                                                                                                                          // MakerGen.cs:435
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:436
                                                                                                                                            // MakerGen.cs:437
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:438
{                                                                                                                                           // MakerGen.cs:439
    #region Json                                                                                                                            // MakerGen.cs:440
    #if NEVER                                                                                                                               // MakerGen.cs:441
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
    #endregion                                                                                                                              // MakerGen.cs:444
    /// <summary>
    /// Fhir resource 'Flag'
    /// </summary>
    // 0. Flag
    public partial class Resource_Flag : FhirKhit.Maker.Common.Resource.Resource_DomainResource                                             // MakerGen.cs:381
    {                                                                                                                                       // MakerGen.cs:382
        // 1. Flag.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:217
        // 2. Flag.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:217
        // 3. Flag.category
        public ElementDefinitionInfo Element_Category;                                                                                      // MakerGen.cs:217
        // 4. Flag.code
        public ElementDefinitionInfo Element_Code;                                                                                          // MakerGen.cs:217
        // 5. Flag.subject
        public ElementDefinitionInfo Element_Subject;                                                                                       // MakerGen.cs:217
        // 6. Flag.period
        public ElementDefinitionInfo Element_Period;                                                                                        // MakerGen.cs:217
        // 7. Flag.encounter
        public ElementDefinitionInfo Element_Encounter;                                                                                     // MakerGen.cs:217
        // 8. Flag.author
        public ElementDefinitionInfo Element_Author;                                                                                        // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:388
        {                                                                                                                                   // MakerGen.cs:389
            base.Write(sDef);                                                                                                               // MakerGen.cs:390
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:391
            {                                                                                                                               // MakerGen.cs:392
                Path = "Flag",                                                                                                              // MakerGen.cs:393
                ElementId = "Flag"                                                                                                          // MakerGen.cs:394
            });                                                                                                                             // MakerGen.cs:395
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:221
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:221
            Element_Category.Write(sDef);                                                                                                   // MakerGen.cs:221
            Element_Code.Write(sDef);                                                                                                       // MakerGen.cs:221
            Element_Subject.Write(sDef);                                                                                                    // MakerGen.cs:221
            Element_Period.Write(sDef);                                                                                                     // MakerGen.cs:221
            Element_Encounter.Write(sDef);                                                                                                  // MakerGen.cs:221
            Element_Author.Write(sDef);                                                                                                     // MakerGen.cs:221
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
        public Resource_Flag()                                                                                                              // MakerGen.cs:400
        {                                                                                                                                   // MakerGen.cs:401
            {                                                                                                                               // MakerGen.cs:232
                // 1. Flag.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:236
                    Path= "Flag.identifier",                                                                                                // MakerGen.cs:237
                    Id = "Flag.identifier",                                                                                                 // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 2. Flag.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Status",                                                                                                // MakerGen.cs:236
                    Path= "Flag.status",                                                                                                    // MakerGen.cs:237
                    Id = "Flag.status",                                                                                                     // MakerGen.cs:238
                    Min = 1,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 3. Flag.category
                this.Element_Category = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Category",                                                                                              // MakerGen.cs:236
                    Path= "Flag.category",                                                                                                  // MakerGen.cs:237
                    Id = "Flag.category",                                                                                                   // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 4. Flag.code
                this.Element_Code = new ElementDefinitionInfo                                                                               // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Code",                                                                                                  // MakerGen.cs:236
                    Path= "Flag.code",                                                                                                      // MakerGen.cs:237
                    Id = "Flag.code",                                                                                                       // MakerGen.cs:238
                    Min = 1,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 5. Flag.subject
                this.Element_Subject = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Subject",                                                                                               // MakerGen.cs:236
                    Path= "Flag.subject",                                                                                                   // MakerGen.cs:237
                    Id = "Flag.subject",                                                                                                    // MakerGen.cs:238
                    Min = 1,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Patient",                                                          // MakerGen.cs:347
                                "http://hl7.org/fhir/StructureDefinition/Location",                                                         // MakerGen.cs:347
                                "http://hl7.org/fhir/StructureDefinition/Group",                                                            // MakerGen.cs:347
                                "http://hl7.org/fhir/StructureDefinition/Organization",                                                     // MakerGen.cs:347
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                     // MakerGen.cs:347
                                "http://hl7.org/fhir/StructureDefinition/PlanDefinition",                                                   // MakerGen.cs:347
                                "http://hl7.org/fhir/StructureDefinition/Medication",                                                       // MakerGen.cs:347
                                "http://hl7.org/fhir/StructureDefinition/Procedure"                                                         // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 6. Flag.period
                this.Element_Period = new ElementDefinitionInfo                                                                             // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Period",                                                                                                // MakerGen.cs:236
                    Path= "Flag.period",                                                                                                    // MakerGen.cs:237
                    Id = "Flag.period",                                                                                                     // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Period                                                                       // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 7. Flag.encounter
                this.Element_Encounter = new ElementDefinitionInfo                                                                          // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Encounter",                                                                                             // MakerGen.cs:236
                    Path= "Flag.encounter",                                                                                                 // MakerGen.cs:237
                    Id = "Flag.encounter",                                                                                                  // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Encounter"                                                         // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 8. Flag.author
                this.Element_Author = new ElementDefinitionInfo                                                                             // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Author",                                                                                                // MakerGen.cs:236
                    Path= "Flag.author",                                                                                                    // MakerGen.cs:237
                    Id = "Flag.author",                                                                                                     // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Device",                                                           // MakerGen.cs:347
                                "http://hl7.org/fhir/StructureDefinition/Organization",                                                     // MakerGen.cs:347
                                "http://hl7.org/fhir/StructureDefinition/Patient",                                                          // MakerGen.cs:347
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                     // MakerGen.cs:347
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                                  // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            this.Name = "Flag";                                                                                                             // MakerGen.cs:468
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Flag";                                                                      // MakerGen.cs:469
        }                                                                                                                                   // MakerGen.cs:403
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:449
