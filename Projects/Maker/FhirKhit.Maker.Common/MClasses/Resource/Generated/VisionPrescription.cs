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
      "id": "VisionPrescription",
      "url": "http://hl7.org/fhir/StructureDefinition/VisionPrescription",
      "version": "4.0.0",
      "name": "VisionPrescription",
      "status": "draft",
      "publisher": "Health Level Seven International (Financial Management)",
      "description": "An authorization for the provision of glasses and/or contact lenses to a patient.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "VisionPrescription",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "VisionPrescription",
            "path": "VisionPrescription",
            "short": "Prescription for vision correction products for a patient",
            "definition": "An authorization for the provision of glasses and/or contact lenses to a patient.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "VisionPrescription.identifier",
            "path": "VisionPrescription.identifier",
            "short": "Business Identifier for vision prescription",
            "definition": "A unique identifier assigned to this vision prescription.",
            "requirements": "Allows vision prescriptions to be distinguished and referenced.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Identifier"
              }
            ]
          },
          {
            "id": "VisionPrescription.status",
            "path": "VisionPrescription.status",
            "short": "active | cancelled | draft | entered-in-error",
            "definition": "The status of the resource instance.",
            "comment": "This element is labeled as a modifier because the status contains codes that mark the resource as not currently valid.",
            "requirements": "Need to track the status of the resource as 'draft' resources may undergo further edits while 'active' resources are immutable and may only have their status changed to 'cancelled'.",
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
                  "valueString": "VisionStatus"
                }
              ],
              "strength": "required",
              "description": "A code specifying the state of the resource instance.",
              "valueSet": "http://hl7.org/fhir/ValueSet/fm-status|4.0.0"
            }
          },
          {
            "id": "VisionPrescription.created",
            "path": "VisionPrescription.created",
            "short": "Response creation date",
            "definition": "The date this resource was created.",
            "requirements": "Need to record a timestamp for use by both the recipient and the issuer.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ],
            "isSummary": true
          },
          {
            "id": "VisionPrescription.patient",
            "path": "VisionPrescription.patient",
            "short": "Who prescription is for",
            "definition": "A resource reference to the person to whom the vision prescription applies.",
            "requirements": "Needed to identify the patient for whom the vision prescription has been issued.",
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
            "id": "VisionPrescription.encounter",
            "path": "VisionPrescription.encounter",
            "short": "Created during encounter / admission / stay",
            "definition": "A reference to a resource that identifies the particular occurrence of contact between patient and health care provider during which the prescription was issued.",
            "requirements": "Used in some jurisdictions to link clinical events to claim items.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Encounter"
                ]
              }
            ]
          },
          {
            "id": "VisionPrescription.dateWritten",
            "path": "VisionPrescription.dateWritten",
            "short": "When prescription was authorized",
            "definition": "The date (and perhaps time) when the prescription was written.",
            "comment": "Jurisdictions determine the valid lifetime of a prescription. Typically vision prescriptions are valid for two years from the date written.",
            "requirements": "Need to record a timestamp for use by both the recipient and the issuer.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ],
            "isSummary": true
          },
          {
            "id": "VisionPrescription.prescriber",
            "path": "VisionPrescription.prescriber",
            "short": "Who authorized the vision prescription",
            "definition": "The healthcare professional responsible for authorizing the prescription.",
            "requirements": "Need to record the authorizing practitioner.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "VisionPrescription.lensSpecification",
            "path": "VisionPrescription.lensSpecification",
            "short": "Vision lens authorization",
            "definition": "Contain the details of  the individual lens specifications and serves as the authorization for the fullfillment by certified professionals.",
            "min": 1,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "VisionPrescription.lensSpecification.product",
            "path": "VisionPrescription.lensSpecification.product",
            "short": "Product to be supplied",
            "definition": "Identifies the type of vision correction product which is required for the patient.",
            "requirements": "Need to identify whether glasses or contacts.",
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
                  "valueString": "VisionProduct"
                }
              ],
              "strength": "example",
              "description": "A coded concept describing the vision products.",
              "valueSet": "http://hl7.org/fhir/ValueSet/vision-product"
            }
          },
          {
            "id": "VisionPrescription.lensSpecification.eye",
            "path": "VisionPrescription.lensSpecification.eye",
            "short": "right | left",
            "definition": "The eye for which the lens specification applies.",
            "comment": "May also appear as OD (oculus dexter) for the right eye and OS (oculus siniter) for the left eye.",
            "requirements": "Needed to identify which eye the lens specification applies to.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "VisionEyes"
                }
              ],
              "strength": "required",
              "description": "A coded concept listing the eye codes.",
              "valueSet": "http://hl7.org/fhir/ValueSet/vision-eye-codes|4.0.0"
            }
          },
          {
            "id": "VisionPrescription.lensSpecification.sphere",
            "path": "VisionPrescription.lensSpecification.sphere",
            "short": "Power of the lens",
            "definition": "Lens power measured in dioptres (0.25 units).",
            "comment": "The value is negative for near-sighted and positive for far sighted.\nOften insurance will not cover a lens with power between +75 and -75.",
            "requirements": "Standard lens prescription measures.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              }
            ]
          },
          {
            "id": "VisionPrescription.lensSpecification.cylinder",
            "path": "VisionPrescription.lensSpecification.cylinder",
            "short": "Lens power for astigmatism",
            "definition": "Power adjustment for astigmatism measured in dioptres (0.25 units).",
            "requirements": "Standard lens prescription measures.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              }
            ]
          },
          {
            "id": "VisionPrescription.lensSpecification.axis",
            "path": "VisionPrescription.lensSpecification.axis",
            "short": "Lens meridian which contain no power for astigmatism",
            "definition": "Adjustment for astigmatism measured in integer degrees.",
            "comment": "The limits are +180 and -180 degrees.",
            "requirements": "Standard lens prescription measures.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "integer"
              }
            ]
          },
          {
            "id": "VisionPrescription.lensSpecification.prism",
            "path": "VisionPrescription.lensSpecification.prism",
            "short": "Eye alignment compensation",
            "definition": "Allows for adjustment on two axis.",
            "requirements": "Standard lens prescription measures.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "VisionPrescription.lensSpecification.prism.amount",
            "path": "VisionPrescription.lensSpecification.prism.amount",
            "short": "Amount of adjustment",
            "definition": "Amount of prism to compensate for eye alignment in fractional units.",
            "requirements": "Standard lens prescription measures.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              }
            ]
          },
          {
            "id": "VisionPrescription.lensSpecification.prism.base",
            "path": "VisionPrescription.lensSpecification.prism.base",
            "short": "up | down | in | out",
            "definition": "The relative base, or reference lens edge, for the prism.",
            "requirements": "Standard lens prescription measures.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "VisionBase"
                }
              ],
              "strength": "required",
              "description": "A coded concept listing the base codes.",
              "valueSet": "http://hl7.org/fhir/ValueSet/vision-base-codes|4.0.0"
            }
          },
          {
            "id": "VisionPrescription.lensSpecification.add",
            "path": "VisionPrescription.lensSpecification.add",
            "short": "Added power for multifocal levels",
            "definition": "Power adjustment for multifocal lenses measured in dioptres (0.25 units).",
            "requirements": "Standard lens prescription measures.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              }
            ]
          },
          {
            "id": "VisionPrescription.lensSpecification.power",
            "path": "VisionPrescription.lensSpecification.power",
            "short": "Contact lens power",
            "definition": "Contact lens power measured in dioptres (0.25 units).",
            "requirements": "Standard contact lens prescription measures.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              }
            ]
          },
          {
            "id": "VisionPrescription.lensSpecification.backCurve",
            "path": "VisionPrescription.lensSpecification.backCurve",
            "short": "Contact lens back curvature",
            "definition": "Back curvature measured in millimetres.",
            "requirements": "Standard contact lens prescription measures.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              }
            ]
          },
          {
            "id": "VisionPrescription.lensSpecification.diameter",
            "path": "VisionPrescription.lensSpecification.diameter",
            "short": "Contact lens diameter",
            "definition": "Contact lens diameter measured in millimetres.",
            "requirements": "Standard contact lens prescription measures.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              }
            ]
          },
          {
            "id": "VisionPrescription.lensSpecification.duration",
            "path": "VisionPrescription.lensSpecification.duration",
            "short": "Lens wear duration",
            "definition": "The recommended maximum wear period for the lens.",
            "requirements": "Standard contact lens prescription measures.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity",
                "profile": [
                  "http://hl7.org/fhir/StructureDefinition/SimpleQuantity"
                ]
              }
            ]
          },
          {
            "id": "VisionPrescription.lensSpecification.color",
            "path": "VisionPrescription.lensSpecification.color",
            "short": "Color required",
            "definition": "Special color or pattern.",
            "requirements": "Standard contact lens prescription measures.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "VisionPrescription.lensSpecification.brand",
            "path": "VisionPrescription.lensSpecification.brand",
            "short": "Brand required",
            "definition": "Brand recommendations or restrictions.",
            "requirements": "Standard lens prescription measures.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "VisionPrescription.lensSpecification.note",
            "path": "VisionPrescription.lensSpecification.note",
            "short": "Notes for coatings",
            "definition": "Notes for special requirements such as coatings and lens materials.",
            "requirements": "Standard lens prescription measures.",
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
    #endregion                                                                                                                              // MakerGen.cs:463
    /// <summary>
    /// Fhir resource 'VisionPrescription'
    /// </summary>
    // 0. VisionPrescription
    public class VisionPrescription : FhirKhit.Maker.Common.Resource.ResourceBase                                                           // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class VisionPrescription_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                              // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 8. VisionPrescription.lensSpecification
            public class Type_LensSpecification : FhirKhit.Maker.Common.Complex.ComplexBase                                                 // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_LensSpecification_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                  // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 14. VisionPrescription.lensSpecification.prism
                    public class Type_Prism : FhirKhit.Maker.Common.Complex.ComplexBase                                                     // MakerGen.cs:385
                    {                                                                                                                       // MakerGen.cs:386
                        public class Type_Prism_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                      // MakerGen.cs:387
                        {                                                                                                                   // MakerGen.cs:388
                            // 15. VisionPrescription.lensSpecification.prism.amount
                            public ElementDefinitionInfo Amount;                                                                            // MakerGen.cs:236
                            // 16. VisionPrescription.lensSpecification.prism.base
                            public ElementDefinitionInfo Base;                                                                              // MakerGen.cs:236
                            public Type_Prism_Elements()                                                                                    // MakerGen.cs:409
                            {                                                                                                               // MakerGen.cs:410
                                {                                                                                                           // MakerGen.cs:251
                                    // 15. VisionPrescription.lensSpecification.prism.amount
                                    this.Amount = new ElementDefinitionInfo                                                                 // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Amount",                                                                                    // MakerGen.cs:255
                                        Path= "VisionPrescription.lensSpecification.prism.amount",                                          // MakerGen.cs:256
                                        Id = "VisionPrescription.lensSpecification.prism.amount",                                           // MakerGen.cs:257
                                        Min = 1,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Primitive.Decimal                                                     // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            }                                                                                               // MakerGen.cs:303
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 16. VisionPrescription.lensSpecification.prism.base
                                    this.Base = new ElementDefinitionInfo                                                                   // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Base",                                                                                      // MakerGen.cs:255
                                        Path= "VisionPrescription.lensSpecification.prism.base",                                            // MakerGen.cs:256
                                        Id = "VisionPrescription.lensSpecification.prism.base",                                             // MakerGen.cs:257
                                        Min = 1,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Primitive.Code                                                        // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            }                                                                                               // MakerGen.cs:303
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                            }                                                                                                               // MakerGen.cs:429
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:414
                            {                                                                                                               // MakerGen.cs:415
                                base.Write(sDef);                                                                                           // MakerGen.cs:416
                                Amount.Write(sDef);                                                                                         // MakerGen.cs:240
                                Base.Write(sDef);                                                                                           // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:433
                        }                                                                                                                   // MakerGen.cs:393
                        public Type_Prism_Elements Elements { get; }                                                                        // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                        public Type_Prism()                                                                                                 // MakerGen.cs:396
                        {                                                                                                                   // MakerGen.cs:397
                            this.Elements = new Type_Prism_Elements();                                                                      // MakerGen.cs:398
                        }                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:403
                        }                                                                                                                   // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                    // 9. VisionPrescription.lensSpecification.product
                    public ElementDefinitionInfo Product;                                                                                   // MakerGen.cs:236
                    // 10. VisionPrescription.lensSpecification.eye
                    public ElementDefinitionInfo Eye;                                                                                       // MakerGen.cs:236
                    // 11. VisionPrescription.lensSpecification.sphere
                    public ElementDefinitionInfo Sphere;                                                                                    // MakerGen.cs:236
                    // 12. VisionPrescription.lensSpecification.cylinder
                    public ElementDefinitionInfo Cylinder;                                                                                  // MakerGen.cs:236
                    // 13. VisionPrescription.lensSpecification.axis
                    public ElementDefinitionInfo Axis;                                                                                      // MakerGen.cs:236
                    // 17. VisionPrescription.lensSpecification.add
                    public ElementDefinitionInfo Add;                                                                                       // MakerGen.cs:236
                    // 18. VisionPrescription.lensSpecification.power
                    public ElementDefinitionInfo Power;                                                                                     // MakerGen.cs:236
                    // 19. VisionPrescription.lensSpecification.backCurve
                    public ElementDefinitionInfo BackCurve;                                                                                 // MakerGen.cs:236
                    // 20. VisionPrescription.lensSpecification.diameter
                    public ElementDefinitionInfo Diameter;                                                                                  // MakerGen.cs:236
                    // 21. VisionPrescription.lensSpecification.duration
                    public ElementDefinitionInfo Duration;                                                                                  // MakerGen.cs:236
                    // 22. VisionPrescription.lensSpecification.color
                    public ElementDefinitionInfo Color;                                                                                     // MakerGen.cs:236
                    // 23. VisionPrescription.lensSpecification.brand
                    public ElementDefinitionInfo Brand;                                                                                     // MakerGen.cs:236
                    // 24. VisionPrescription.lensSpecification.note
                    public ElementDefinitionInfo Note;                                                                                      // MakerGen.cs:236
                    public Type_LensSpecification_Elements()                                                                                // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 9. VisionPrescription.lensSpecification.product
                            this.Product = new ElementDefinitionInfo                                                                        // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Product",                                                                                           // MakerGen.cs:255
                                Path= "VisionPrescription.lensSpecification.product",                                                       // MakerGen.cs:256
                                Id = "VisionPrescription.lensSpecification.product",                                                        // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 10. VisionPrescription.lensSpecification.eye
                            this.Eye = new ElementDefinitionInfo                                                                            // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Eye",                                                                                               // MakerGen.cs:255
                                Path= "VisionPrescription.lensSpecification.eye",                                                           // MakerGen.cs:256
                                Id = "VisionPrescription.lensSpecification.eye",                                                            // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 11. VisionPrescription.lensSpecification.sphere
                            this.Sphere = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Sphere",                                                                                            // MakerGen.cs:255
                                Path= "VisionPrescription.lensSpecification.sphere",                                                        // MakerGen.cs:256
                                Id = "VisionPrescription.lensSpecification.sphere",                                                         // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Decimal                                                             // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 12. VisionPrescription.lensSpecification.cylinder
                            this.Cylinder = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Cylinder",                                                                                          // MakerGen.cs:255
                                Path= "VisionPrescription.lensSpecification.cylinder",                                                      // MakerGen.cs:256
                                Id = "VisionPrescription.lensSpecification.cylinder",                                                       // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Decimal                                                             // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 13. VisionPrescription.lensSpecification.axis
                            this.Axis = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Axis",                                                                                              // MakerGen.cs:255
                                Path= "VisionPrescription.lensSpecification.axis",                                                          // MakerGen.cs:256
                                Id = "VisionPrescription.lensSpecification.axis",                                                           // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Integer                                                             // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 17. VisionPrescription.lensSpecification.add
                            this.Add = new ElementDefinitionInfo                                                                            // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Add",                                                                                               // MakerGen.cs:255
                                Path= "VisionPrescription.lensSpecification.add",                                                           // MakerGen.cs:256
                                Id = "VisionPrescription.lensSpecification.add",                                                            // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Decimal                                                             // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 18. VisionPrescription.lensSpecification.power
                            this.Power = new ElementDefinitionInfo                                                                          // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Power",                                                                                             // MakerGen.cs:255
                                Path= "VisionPrescription.lensSpecification.power",                                                         // MakerGen.cs:256
                                Id = "VisionPrescription.lensSpecification.power",                                                          // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Decimal                                                             // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 19. VisionPrescription.lensSpecification.backCurve
                            this.BackCurve = new ElementDefinitionInfo                                                                      // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "BackCurve",                                                                                         // MakerGen.cs:255
                                Path= "VisionPrescription.lensSpecification.backCurve",                                                     // MakerGen.cs:256
                                Id = "VisionPrescription.lensSpecification.backCurve",                                                      // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Decimal                                                             // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 20. VisionPrescription.lensSpecification.diameter
                            this.Diameter = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Diameter",                                                                                          // MakerGen.cs:255
                                Path= "VisionPrescription.lensSpecification.diameter",                                                      // MakerGen.cs:256
                                Id = "VisionPrescription.lensSpecification.diameter",                                                       // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Decimal                                                             // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 21. VisionPrescription.lensSpecification.duration
                            this.Duration = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Duration",                                                                                          // MakerGen.cs:255
                                Path= "VisionPrescription.lensSpecification.duration",                                                      // MakerGen.cs:256
                                Id = "VisionPrescription.lensSpecification.duration",                                                       // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Quantity                                                              // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 22. VisionPrescription.lensSpecification.color
                            this.Color = new ElementDefinitionInfo                                                                          // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Color",                                                                                             // MakerGen.cs:255
                                Path= "VisionPrescription.lensSpecification.color",                                                         // MakerGen.cs:256
                                Id = "VisionPrescription.lensSpecification.color",                                                          // MakerGen.cs:257
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
                            // 23. VisionPrescription.lensSpecification.brand
                            this.Brand = new ElementDefinitionInfo                                                                          // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Brand",                                                                                             // MakerGen.cs:255
                                Path= "VisionPrescription.lensSpecification.brand",                                                         // MakerGen.cs:256
                                Id = "VisionPrescription.lensSpecification.brand",                                                          // MakerGen.cs:257
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
                            // 24. VisionPrescription.lensSpecification.note
                            this.Note = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Note",                                                                                              // MakerGen.cs:255
                                Path= "VisionPrescription.lensSpecification.note",                                                          // MakerGen.cs:256
                                Id = "VisionPrescription.lensSpecification.note",                                                           // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Annotation                                                            // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Product.Write(sDef);                                                                                                // MakerGen.cs:240
                        Eye.Write(sDef);                                                                                                    // MakerGen.cs:240
                        Sphere.Write(sDef);                                                                                                 // MakerGen.cs:240
                        Cylinder.Write(sDef);                                                                                               // MakerGen.cs:240
                        Axis.Write(sDef);                                                                                                   // MakerGen.cs:240
                        Add.Write(sDef);                                                                                                    // MakerGen.cs:240
                        Power.Write(sDef);                                                                                                  // MakerGen.cs:240
                        BackCurve.Write(sDef);                                                                                              // MakerGen.cs:240
                        Diameter.Write(sDef);                                                                                               // MakerGen.cs:240
                        Duration.Write(sDef);                                                                                               // MakerGen.cs:240
                        Color.Write(sDef);                                                                                                  // MakerGen.cs:240
                        Brand.Write(sDef);                                                                                                  // MakerGen.cs:240
                        Note.Write(sDef);                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_LensSpecification_Elements Elements { get; }                                                                    // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_LensSpecification()                                                                                             // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_LensSpecification_Elements();                                                                  // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 1. VisionPrescription.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:236
            // 2. VisionPrescription.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:236
            // 3. VisionPrescription.created
            public ElementDefinitionInfo Created;                                                                                           // MakerGen.cs:236
            // 4. VisionPrescription.patient
            public ElementDefinitionInfo Patient;                                                                                           // MakerGen.cs:236
            // 5. VisionPrescription.encounter
            public ElementDefinitionInfo Encounter;                                                                                         // MakerGen.cs:236
            // 6. VisionPrescription.dateWritten
            public ElementDefinitionInfo DateWritten;                                                                                       // MakerGen.cs:236
            // 7. VisionPrescription.prescriber
            public ElementDefinitionInfo Prescriber;                                                                                        // MakerGen.cs:236
            public VisionPrescription_Elements()                                                                                            // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:251
                    // 1. VisionPrescription.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Identifier",                                                                                                // MakerGen.cs:255
                        Path= "VisionPrescription.identifier",                                                                              // MakerGen.cs:256
                        Id = "VisionPrescription.identifier",                                                                               // MakerGen.cs:257
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
                    // 2. VisionPrescription.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Status",                                                                                                    // MakerGen.cs:255
                        Path= "VisionPrescription.status",                                                                                  // MakerGen.cs:256
                        Id = "VisionPrescription.status",                                                                                   // MakerGen.cs:257
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
                    // 3. VisionPrescription.created
                    this.Created = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Created",                                                                                                   // MakerGen.cs:255
                        Path= "VisionPrescription.created",                                                                                 // MakerGen.cs:256
                        Id = "VisionPrescription.created",                                                                                  // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 4. VisionPrescription.patient
                    this.Patient = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Patient",                                                                                                   // MakerGen.cs:255
                        Path= "VisionPrescription.patient",                                                                                 // MakerGen.cs:256
                        Id = "VisionPrescription.patient",                                                                                  // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient"                                                       // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 5. VisionPrescription.encounter
                    this.Encounter = new ElementDefinitionInfo                                                                              // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Encounter",                                                                                                 // MakerGen.cs:255
                        Path= "VisionPrescription.encounter",                                                                               // MakerGen.cs:256
                        Id = "VisionPrescription.encounter",                                                                                // MakerGen.cs:257
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
                    // 6. VisionPrescription.dateWritten
                    this.DateWritten = new ElementDefinitionInfo                                                                            // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "DateWritten",                                                                                               // MakerGen.cs:255
                        Path= "VisionPrescription.dateWritten",                                                                             // MakerGen.cs:256
                        Id = "VisionPrescription.dateWritten",                                                                              // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 7. VisionPrescription.prescriber
                    this.Prescriber = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Prescriber",                                                                                                // MakerGen.cs:255
                        Path= "VisionPrescription.prescriber",                                                                              // MakerGen.cs:256
                        Id = "VisionPrescription.prescriber",                                                                               // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
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
                Created.Write(sDef);                                                                                                        // MakerGen.cs:240
                Patient.Write(sDef);                                                                                                        // MakerGen.cs:240
                Encounter.Write(sDef);                                                                                                      // MakerGen.cs:240
                DateWritten.Write(sDef);                                                                                                    // MakerGen.cs:240
                Prescriber.Write(sDef);                                                                                                     // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public VisionPrescription_Elements Elements { get; }                                                                                // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public VisionPrescription()                                                                                                         // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new VisionPrescription_Elements();                                                                              // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:468
