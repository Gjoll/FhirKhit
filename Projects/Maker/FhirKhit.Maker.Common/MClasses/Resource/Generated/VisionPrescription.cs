using System;                                                                                                                               // MakerGen.cs:413
using System.Diagnostics;                                                                                                                   // MakerGen.cs:414
using System.IO;                                                                                                                            // MakerGen.cs:415
using System.Linq;                                                                                                                          // MakerGen.cs:416
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:417
                                                                                                                                            // MakerGen.cs:418
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:419
{                                                                                                                                           // MakerGen.cs:420
    #region Json                                                                                                                            // MakerGen.cs:421
    #if NEVER                                                                                                                               // MakerGen.cs:422
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
    #endregion                                                                                                                              // MakerGen.cs:425
    /// <summary>
    /// Fhir resource 'VisionPrescription'
    /// </summary>
    // 0. VisionPrescription
    public class VisionPrescription : FhirKhit.Maker.Common.Resource.ResourceBase                                                           // MakerGen.cs:374
    {                                                                                                                                       // MakerGen.cs:375
        // 8. VisionPrescription.lensSpecification
        public class Type_LensSpecification : FhirKhit.Maker.Common.Complex.ComplexBase                                                     // MakerGen.cs:374
        {                                                                                                                                   // MakerGen.cs:375
            // 14. VisionPrescription.lensSpecification.prism
            public class Type_Prism : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:374
            {                                                                                                                               // MakerGen.cs:375
                // 15. VisionPrescription.lensSpecification.prism.amount
                public MakerElementInstance Element_Amount;                                                                                 // MakerGen.cs:232
                // 16. VisionPrescription.lensSpecification.prism.base
                public MakerElementInstance Element_Base;                                                                                   // MakerGen.cs:232
                public Type_Prism()                                                                                                         // MakerGen.cs:383
                {                                                                                                                           // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:243
                        // 15. VisionPrescription.lensSpecification.prism.amount
                        this.Element_Amount = new MakerElementInstance                                                                      // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Amount",                                                                                        // MakerGen.cs:247
                            Min = 1,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Decimal                                                                 // MakerGen.cs:289
                                {                                                                                                           // MakerGen.cs:290
                                }                                                                                                           // MakerGen.cs:293
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:356
                    {                                                                                                                       // MakerGen.cs:243
                        // 16. VisionPrescription.lensSpecification.prism.base
                        this.Element_Base = new MakerElementInstance                                                                        // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Base",                                                                                          // MakerGen.cs:247
                            Min = 1,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Code                                                                    // MakerGen.cs:289
                                {                                                                                                           // MakerGen.cs:290
                                }                                                                                                           // MakerGen.cs:293
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:356
                }                                                                                                                           // MakerGen.cs:395
            }                                                                                                                               // MakerGen.cs:379
            // 9. VisionPrescription.lensSpecification.product
            public MakerElementInstance Element_Product;                                                                                    // MakerGen.cs:232
            // 10. VisionPrescription.lensSpecification.eye
            public MakerElementInstance Element_Eye;                                                                                        // MakerGen.cs:232
            // 11. VisionPrescription.lensSpecification.sphere
            public MakerElementInstance Element_Sphere;                                                                                     // MakerGen.cs:232
            // 12. VisionPrescription.lensSpecification.cylinder
            public MakerElementInstance Element_Cylinder;                                                                                   // MakerGen.cs:232
            // 13. VisionPrescription.lensSpecification.axis
            public MakerElementInstance Element_Axis;                                                                                       // MakerGen.cs:232
            // 17. VisionPrescription.lensSpecification.add
            public MakerElementInstance Element_Add;                                                                                        // MakerGen.cs:232
            // 18. VisionPrescription.lensSpecification.power
            public MakerElementInstance Element_Power;                                                                                      // MakerGen.cs:232
            // 19. VisionPrescription.lensSpecification.backCurve
            public MakerElementInstance Element_BackCurve;                                                                                  // MakerGen.cs:232
            // 20. VisionPrescription.lensSpecification.diameter
            public MakerElementInstance Element_Diameter;                                                                                   // MakerGen.cs:232
            // 21. VisionPrescription.lensSpecification.duration
            public MakerElementInstance Element_Duration;                                                                                   // MakerGen.cs:232
            // 22. VisionPrescription.lensSpecification.color
            public MakerElementInstance Element_Color;                                                                                      // MakerGen.cs:232
            // 23. VisionPrescription.lensSpecification.brand
            public MakerElementInstance Element_Brand;                                                                                      // MakerGen.cs:232
            // 24. VisionPrescription.lensSpecification.note
            public MakerElementInstance Element_Note;                                                                                       // MakerGen.cs:232
            public Type_LensSpecification()                                                                                                 // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                {                                                                                                                           // MakerGen.cs:243
                    // 9. VisionPrescription.lensSpecification.product
                    this.Element_Product = new MakerElementInstance                                                                         // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Product",                                                                                           // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:304
                            {                                                                                                               // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:308
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
                {                                                                                                                           // MakerGen.cs:243
                    // 10. VisionPrescription.lensSpecification.eye
                    this.Element_Eye = new MakerElementInstance                                                                             // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Eye",                                                                                               // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            }                                                                                                               // MakerGen.cs:293
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
                {                                                                                                                           // MakerGen.cs:243
                    // 11. VisionPrescription.lensSpecification.sphere
                    this.Element_Sphere = new MakerElementInstance                                                                          // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Sphere",                                                                                            // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Decimal                                                                     // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            }                                                                                                               // MakerGen.cs:293
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
                {                                                                                                                           // MakerGen.cs:243
                    // 12. VisionPrescription.lensSpecification.cylinder
                    this.Element_Cylinder = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Cylinder",                                                                                          // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Decimal                                                                     // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            }                                                                                                               // MakerGen.cs:293
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
                {                                                                                                                           // MakerGen.cs:243
                    // 13. VisionPrescription.lensSpecification.axis
                    this.Element_Axis = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Axis",                                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Integer                                                                     // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            }                                                                                                               // MakerGen.cs:293
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
                {                                                                                                                           // MakerGen.cs:243
                    // 17. VisionPrescription.lensSpecification.add
                    this.Element_Add = new MakerElementInstance                                                                             // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Add",                                                                                               // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Decimal                                                                     // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            }                                                                                                               // MakerGen.cs:293
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
                {                                                                                                                           // MakerGen.cs:243
                    // 18. VisionPrescription.lensSpecification.power
                    this.Element_Power = new MakerElementInstance                                                                           // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Power",                                                                                             // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Decimal                                                                     // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            }                                                                                                               // MakerGen.cs:293
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
                {                                                                                                                           // MakerGen.cs:243
                    // 19. VisionPrescription.lensSpecification.backCurve
                    this.Element_BackCurve = new MakerElementInstance                                                                       // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_BackCurve",                                                                                         // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Decimal                                                                     // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            }                                                                                                               // MakerGen.cs:293
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
                {                                                                                                                           // MakerGen.cs:243
                    // 20. VisionPrescription.lensSpecification.diameter
                    this.Element_Diameter = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Diameter",                                                                                          // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Decimal                                                                     // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            }                                                                                                               // MakerGen.cs:293
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
                {                                                                                                                           // MakerGen.cs:243
                    // 21. VisionPrescription.lensSpecification.duration
                    this.Element_Duration = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Duration",                                                                                          // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.Quantity                                                                      // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
                {                                                                                                                           // MakerGen.cs:243
                    // 22. VisionPrescription.lensSpecification.color
                    this.Element_Color = new MakerElementInstance                                                                           // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Color",                                                                                             // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            }                                                                                                               // MakerGen.cs:293
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
                {                                                                                                                           // MakerGen.cs:243
                    // 23. VisionPrescription.lensSpecification.brand
                    this.Element_Brand = new MakerElementInstance                                                                           // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Brand",                                                                                             // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            }                                                                                                               // MakerGen.cs:293
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
                {                                                                                                                           // MakerGen.cs:243
                    // 24. VisionPrescription.lensSpecification.note
                    this.Element_Note = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Note",                                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.Annotation                                                                    // MakerGen.cs:347
                            {                                                                                                               // MakerGen.cs:348
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
            }                                                                                                                               // MakerGen.cs:395
        }                                                                                                                                   // MakerGen.cs:379
        // 1. VisionPrescription.identifier
        public MakerElementInstance Element_Identifier;                                                                                     // MakerGen.cs:232
        // 2. VisionPrescription.status
        public MakerElementInstance Element_Status;                                                                                         // MakerGen.cs:232
        // 3. VisionPrescription.created
        public MakerElementInstance Element_Created;                                                                                        // MakerGen.cs:232
        // 4. VisionPrescription.patient
        public MakerElementInstance Element_Patient;                                                                                        // MakerGen.cs:232
        // 5. VisionPrescription.encounter
        public MakerElementInstance Element_Encounter;                                                                                      // MakerGen.cs:232
        // 6. VisionPrescription.dateWritten
        public MakerElementInstance Element_DateWritten;                                                                                    // MakerGen.cs:232
        // 7. VisionPrescription.prescriber
        public MakerElementInstance Element_Prescriber;                                                                                     // MakerGen.cs:232
        public VisionPrescription()                                                                                                         // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:243
                // 1. VisionPrescription.identifier
                this.Element_Identifier = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Identifier                                                                        // MakerGen.cs:347
                        {                                                                                                                   // MakerGen.cs:348
                        }                                                                                                                   // MakerGen.cs:349
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 2. VisionPrescription.status
                this.Element_Status = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Status",                                                                                                // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Code                                                                            // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 3. VisionPrescription.created
                this.Element_Created = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Created",                                                                                               // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.DateTime                                                                        // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 4. VisionPrescription.patient
                this.Element_Patient = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Patient",                                                                                               // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Reference                                                                         // MakerGen.cs:335
                        {                                                                                                                   // MakerGen.cs:336
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:338
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Patient"                                                           // MakerGen.cs:338
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:339
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 5. VisionPrescription.encounter
                this.Element_Encounter = new MakerElementInstance                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Encounter",                                                                                             // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Reference                                                                         // MakerGen.cs:335
                        {                                                                                                                   // MakerGen.cs:336
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:338
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Encounter"                                                         // MakerGen.cs:338
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:339
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 6. VisionPrescription.dateWritten
                this.Element_DateWritten = new MakerElementInstance                                                                         // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_DateWritten",                                                                                           // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.DateTime                                                                        // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 7. VisionPrescription.prescriber
                this.Element_Prescriber = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Prescriber",                                                                                            // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Reference                                                                         // MakerGen.cs:335
                        {                                                                                                                   // MakerGen.cs:336
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:338
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                     // MakerGen.cs:338
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                                  // MakerGen.cs:338
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:339
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
        }                                                                                                                                   // MakerGen.cs:395
    }                                                                                                                                       // MakerGen.cs:379
}                                                                                                                                           // MakerGen.cs:430
