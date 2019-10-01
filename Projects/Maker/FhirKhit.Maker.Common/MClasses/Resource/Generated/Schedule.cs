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
      "id": "Schedule",
      "url": "http://hl7.org/fhir/StructureDefinition/Schedule",
      "version": "4.0.0",
      "name": "Schedule",
      "status": "draft",
      "publisher": "Health Level Seven International (Patient Administration)",
      "description": "A container for slots of time that may be available for booking appointments.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "Schedule",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Schedule",
            "path": "Schedule",
            "short": "A container for slots of time that may be available for booking appointments",
            "definition": "A container for slots of time that may be available for booking appointments.",
            "alias": [
              "Availability"
            ],
            "min": 0,
            "max": "*"
          },
          {
            "id": "Schedule.identifier",
            "path": "Schedule.identifier",
            "short": "External Ids for this item",
            "definition": "External Ids for this item.",
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
            "id": "Schedule.active",
            "path": "Schedule.active",
            "short": "Whether this schedule is in active use",
            "definition": "Whether this schedule record is in active use or should not be used (such as was entered in error).",
            "comment": "This element is labeled as a modifier because it may be used to mark that the resource was created in error.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "meaningWhenMissing": "This resource is generally assumed to be active if no value is provided for the active element",
            "isModifier": true,
            "isModifierReason": "This element is labelled as a modifier because it is a status element that can indicate that a record should not be treated as valid",
            "isSummary": true
          },
          {
            "id": "Schedule.serviceCategory",
            "path": "Schedule.serviceCategory",
            "short": "High-level category",
            "definition": "A broad categorization of the service that is to be performed during this appointment.",
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
                  "valueString": "service-category"
                }
              ],
              "strength": "example",
              "valueSet": "http://hl7.org/fhir/ValueSet/service-category"
            }
          },
          {
            "id": "Schedule.serviceType",
            "path": "Schedule.serviceType",
            "short": "Specific service",
            "definition": "The specific service that is to be performed during this appointment.",
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
                  "valueString": "service-type"
                }
              ],
              "strength": "example",
              "valueSet": "http://hl7.org/fhir/ValueSet/service-type"
            }
          },
          {
            "id": "Schedule.specialty",
            "path": "Schedule.specialty",
            "short": "Type of specialty needed",
            "definition": "The specialty of a practitioner that would be required to perform the service requested in this appointment.",
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
                  "valueString": "specialty"
                }
              ],
              "strength": "preferred",
              "description": "Additional details about where the content was created (e.g. clinical specialty).",
              "valueSet": "http://hl7.org/fhir/ValueSet/c80-practice-codes"
            }
          },
          {
            "id": "Schedule.actor",
            "path": "Schedule.actor",
            "short": "Resource(s) that availability information is being provided for",
            "definition": "Slots that reference this schedule resource provide the availability details to these referenced resource(s).",
            "comment": "The capacity to support multiple referenced resource types should be used in cases where the specific resources themselves cannot be scheduled without the other, and thus only make sense to the system exposing them as a group. Common examples of this are where the combination of a practitioner and a room (Location) are always required by a system.",
            "min": 1,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/HealthcareService",
                  "http://hl7.org/fhir/StructureDefinition/Location"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Schedule.planningHorizon",
            "path": "Schedule.planningHorizon",
            "short": "Period of time covered by schedule",
            "definition": "The period of time that the slots that reference this Schedule resource cover (even if none exist). These  cover the amount of time that an organization's planning horizon; the interval for which they are currently accepting appointments. This does not define a \"template\" for planning outside these dates.",
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
            "id": "Schedule.comment",
            "path": "Schedule.comment",
            "short": "Comments on availability",
            "definition": "Comments on the availability to describe any extended information. Such as custom constraints on the slots that may be associated.",
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
    /// Fhir resource 'Schedule'
    /// </summary>
    // 0. Schedule
    public class Schedule : FhirKhit.Maker.Common.Resource.ResourceBase                                                                     // MakerGen.cs:352
    {                                                                                                                                       // MakerGen.cs:353
        // 1. Schedule.identifier
        public MakerElementInstance Element_Identifier;                                                                                     // MakerGen.cs:232
        // 2. Schedule.active
        public MakerElementInstance Element_Active;                                                                                         // MakerGen.cs:232
        // 3. Schedule.serviceCategory
        public MakerElementInstance Element_ServiceCategory;                                                                                // MakerGen.cs:232
        // 4. Schedule.serviceType
        public MakerElementInstance Element_ServiceType;                                                                                    // MakerGen.cs:232
        // 5. Schedule.specialty
        public MakerElementInstance Element_Specialty;                                                                                      // MakerGen.cs:232
        // 6. Schedule.actor
        public MakerElementInstance Element_Actor;                                                                                          // MakerGen.cs:232
        // 7. Schedule.planningHorizon
        public MakerElementInstance Element_PlanningHorizon;                                                                                // MakerGen.cs:232
        // 8. Schedule.comment
        public MakerElementInstance Element_Comment;                                                                                        // MakerGen.cs:232
        public Schedule()                                                                                                                   // MakerGen.cs:361
        {                                                                                                                                   // MakerGen.cs:362
            {                                                                                                                               // MakerGen.cs:243
                // 1. Schedule.identifier
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
                // 2. Schedule.active
                this.Element_Active = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Active",                                                                                                // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Boolean()                                                                       // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 3. Schedule.serviceCategory
                this.Element_ServiceCategory = new MakerElementInstance                                                                     // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ServiceCategory",                                                                                       // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 4. Schedule.serviceType
                this.Element_ServiceType = new MakerElementInstance                                                                         // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ServiceType",                                                                                           // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 5. Schedule.specialty
                this.Element_Specialty = new MakerElementInstance                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Specialty",                                                                                             // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 6. Schedule.actor
                this.Element_Actor = new MakerElementInstance                                                                               // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Actor",                                                                                                 // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 7. Schedule.planningHorizon
                this.Element_PlanningHorizon = new MakerElementInstance                                                                     // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_PlanningHorizon",                                                                                       // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 8. Schedule.comment
                this.Element_Comment = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Comment",                                                                                               // MakerGen.cs:247
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
