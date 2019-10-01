using System;                                                                                                                               // MakerGen.cs:428
using System.Diagnostics;                                                                                                                   // MakerGen.cs:429
using System.IO;                                                                                                                            // MakerGen.cs:430
using System.Linq;                                                                                                                          // MakerGen.cs:431
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:432
                                                                                                                                            // MakerGen.cs:433
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:434
{                                                                                                                                           // MakerGen.cs:435
    #region Json                                                                                                                            // MakerGen.cs:436
    #if NEVER                                                                                                                               // MakerGen.cs:437
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
    #endregion                                                                                                                              // MakerGen.cs:440
    /// <summary>
    /// Fhir resource 'VisionPrescription'
    /// </summary>
    // 0. VisionPrescription
    public class Resource_VisionPrescription : FhirKhit.Maker.Common.Resource.ResourceBase                                                  // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        // 8. VisionPrescription.lensSpecification
        public class Type_LensSpecification : FhirKhit.Maker.Common.Complex.ComplexBase                                                     // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 14. VisionPrescription.lensSpecification.prism
            public class Type_Prism : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                // 15. VisionPrescription.lensSpecification.prism.amount
                public ElementDefinitionInfo Element_Amount;                                                                                // MakerGen.cs:212
                // 16. VisionPrescription.lensSpecification.prism.base
                public ElementDefinitionInfo Element_Base;                                                                                  // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:383
                {                                                                                                                           // MakerGen.cs:384
                    base.Write(sDef);                                                                                                       // MakerGen.cs:385
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:386
                    {                                                                                                                       // MakerGen.cs:387
                        Path = "VisionPrescription.lensSpecification.prism",                                                                // MakerGen.cs:388
                        ElementId = "VisionPrescription.lensSpecification.prism"                                                            // MakerGen.cs:389
                    });                                                                                                                     // MakerGen.cs:390
                    Element_Amount.Write(sDef);                                                                                             // MakerGen.cs:216
                    Element_Base.Write(sDef);                                                                                               // MakerGen.cs:216
                }                                                                                                                           // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
                public Type_Prism()                                                                                                         // MakerGen.cs:395
                {                                                                                                                           // MakerGen.cs:396
                    {                                                                                                                       // MakerGen.cs:227
                        // 15. VisionPrescription.lensSpecification.prism.amount
                        this.Element_Amount = new ElementDefinitionInfo                                                                     // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Amount",                                                                                        // MakerGen.cs:231
                            Path= "VisionPrescription.lensSpecification.prism.amount",                                                      // MakerGen.cs:232
                            Id = "VisionPrescription.lensSpecification.prism.amount",                                                       // MakerGen.cs:233
                            Min = 1,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Primitive.Primitive_Decimal                                                       // MakerGen.cs:296
                                {                                                                                                           // MakerGen.cs:297
                                }                                                                                                           // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 16. VisionPrescription.lensSpecification.prism.base
                        this.Element_Base = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Base",                                                                                          // MakerGen.cs:231
                            Path= "VisionPrescription.lensSpecification.prism.base",                                                        // MakerGen.cs:232
                            Id = "VisionPrescription.lensSpecification.prism.base",                                                         // MakerGen.cs:233
                            Min = 1,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                          // MakerGen.cs:296
                                {                                                                                                           // MakerGen.cs:297
                                }                                                                                                           // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                }                                                                                                                           // MakerGen.cs:398
            }                                                                                                                               // MakerGen.cs:400
            // 9. VisionPrescription.lensSpecification.product
            public ElementDefinitionInfo Element_Product;                                                                                   // MakerGen.cs:212
            // 10. VisionPrescription.lensSpecification.eye
            public ElementDefinitionInfo Element_Eye;                                                                                       // MakerGen.cs:212
            // 11. VisionPrescription.lensSpecification.sphere
            public ElementDefinitionInfo Element_Sphere;                                                                                    // MakerGen.cs:212
            // 12. VisionPrescription.lensSpecification.cylinder
            public ElementDefinitionInfo Element_Cylinder;                                                                                  // MakerGen.cs:212
            // 13. VisionPrescription.lensSpecification.axis
            public ElementDefinitionInfo Element_Axis;                                                                                      // MakerGen.cs:212
            // 14. VisionPrescription.lensSpecification.prism
            public ElementDefinitionInfo Element_Prism;                                                                                     // MakerGen.cs:212
            // 17. VisionPrescription.lensSpecification.add
            public ElementDefinitionInfo Element_Add;                                                                                       // MakerGen.cs:212
            // 18. VisionPrescription.lensSpecification.power
            public ElementDefinitionInfo Element_Power;                                                                                     // MakerGen.cs:212
            // 19. VisionPrescription.lensSpecification.backCurve
            public ElementDefinitionInfo Element_BackCurve;                                                                                 // MakerGen.cs:212
            // 20. VisionPrescription.lensSpecification.diameter
            public ElementDefinitionInfo Element_Diameter;                                                                                  // MakerGen.cs:212
            // 21. VisionPrescription.lensSpecification.duration
            public ElementDefinitionInfo Element_Duration;                                                                                  // MakerGen.cs:212
            // 22. VisionPrescription.lensSpecification.color
            public ElementDefinitionInfo Element_Color;                                                                                     // MakerGen.cs:212
            // 23. VisionPrescription.lensSpecification.brand
            public ElementDefinitionInfo Element_Brand;                                                                                     // MakerGen.cs:212
            // 24. VisionPrescription.lensSpecification.note
            public ElementDefinitionInfo Element_Note;                                                                                      // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "VisionPrescription.lensSpecification",                                                                          // MakerGen.cs:388
                    ElementId = "VisionPrescription.lensSpecification"                                                                      // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Product.Write(sDef);                                                                                                // MakerGen.cs:216
                Element_Eye.Write(sDef);                                                                                                    // MakerGen.cs:216
                Element_Sphere.Write(sDef);                                                                                                 // MakerGen.cs:216
                Element_Cylinder.Write(sDef);                                                                                               // MakerGen.cs:216
                Element_Axis.Write(sDef);                                                                                                   // MakerGen.cs:216
                Element_Prism.Write(sDef);                                                                                                  // MakerGen.cs:216
                Element_Add.Write(sDef);                                                                                                    // MakerGen.cs:216
                Element_Power.Write(sDef);                                                                                                  // MakerGen.cs:216
                Element_BackCurve.Write(sDef);                                                                                              // MakerGen.cs:216
                Element_Diameter.Write(sDef);                                                                                               // MakerGen.cs:216
                Element_Duration.Write(sDef);                                                                                               // MakerGen.cs:216
                Element_Color.Write(sDef);                                                                                                  // MakerGen.cs:216
                Element_Brand.Write(sDef);                                                                                                  // MakerGen.cs:216
                Element_Note.Write(sDef);                                                                                                   // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_LensSpecification()                                                                                                 // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 9. VisionPrescription.lensSpecification.product
                    this.Element_Product = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Product",                                                                                           // MakerGen.cs:231
                        Path= "VisionPrescription.lensSpecification.product",                                                               // MakerGen.cs:232
                        Id = "VisionPrescription.lensSpecification.product",                                                                // MakerGen.cs:233
                        Min = 1,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 10. VisionPrescription.lensSpecification.eye
                    this.Element_Eye = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Eye",                                                                                               // MakerGen.cs:231
                        Path= "VisionPrescription.lensSpecification.eye",                                                                   // MakerGen.cs:232
                        Id = "VisionPrescription.lensSpecification.eye",                                                                    // MakerGen.cs:233
                        Min = 1,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                              // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 11. VisionPrescription.lensSpecification.sphere
                    this.Element_Sphere = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Sphere",                                                                                            // MakerGen.cs:231
                        Path= "VisionPrescription.lensSpecification.sphere",                                                                // MakerGen.cs:232
                        Id = "VisionPrescription.lensSpecification.sphere",                                                                 // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_Decimal                                                           // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 12. VisionPrescription.lensSpecification.cylinder
                    this.Element_Cylinder = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Cylinder",                                                                                          // MakerGen.cs:231
                        Path= "VisionPrescription.lensSpecification.cylinder",                                                              // MakerGen.cs:232
                        Id = "VisionPrescription.lensSpecification.cylinder",                                                               // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_Decimal                                                           // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 13. VisionPrescription.lensSpecification.axis
                    this.Element_Axis = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Axis",                                                                                              // MakerGen.cs:231
                        Path= "VisionPrescription.lensSpecification.axis",                                                                  // MakerGen.cs:232
                        Id = "VisionPrescription.lensSpecification.axis",                                                                   // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_Integer                                                           // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 14. VisionPrescription.lensSpecification.prism
                    this.Element_Prism = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Prism",                                                                                             // MakerGen.cs:231
                        Path= "VisionPrescription.lensSpecification.prism",                                                                 // MakerGen.cs:232
                        Id = "VisionPrescription.lensSpecification.prism",                                                                  // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new Type_Prism                                                                                                  // MakerGen.cs:255
                            {                                                                                                               // MakerGen.cs:256
                            }                                                                                                               // MakerGen.cs:257
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 17. VisionPrescription.lensSpecification.add
                    this.Element_Add = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Add",                                                                                               // MakerGen.cs:231
                        Path= "VisionPrescription.lensSpecification.add",                                                                   // MakerGen.cs:232
                        Id = "VisionPrescription.lensSpecification.add",                                                                    // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_Decimal                                                           // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 18. VisionPrescription.lensSpecification.power
                    this.Element_Power = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Power",                                                                                             // MakerGen.cs:231
                        Path= "VisionPrescription.lensSpecification.power",                                                                 // MakerGen.cs:232
                        Id = "VisionPrescription.lensSpecification.power",                                                                  // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_Decimal                                                           // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 19. VisionPrescription.lensSpecification.backCurve
                    this.Element_BackCurve = new ElementDefinitionInfo                                                                      // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_BackCurve",                                                                                         // MakerGen.cs:231
                        Path= "VisionPrescription.lensSpecification.backCurve",                                                             // MakerGen.cs:232
                        Id = "VisionPrescription.lensSpecification.backCurve",                                                              // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_Decimal                                                           // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 20. VisionPrescription.lensSpecification.diameter
                    this.Element_Diameter = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Diameter",                                                                                          // MakerGen.cs:231
                        Path= "VisionPrescription.lensSpecification.diameter",                                                              // MakerGen.cs:232
                        Id = "VisionPrescription.lensSpecification.diameter",                                                               // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_Decimal                                                           // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 21. VisionPrescription.lensSpecification.duration
                    this.Element_Duration = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Duration",                                                                                          // MakerGen.cs:231
                        Path= "VisionPrescription.lensSpecification.duration",                                                              // MakerGen.cs:232
                        Id = "VisionPrescription.lensSpecification.duration",                                                               // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                 // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            }                                                                                                               // MakerGen.cs:353
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 22. VisionPrescription.lensSpecification.color
                    this.Element_Color = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Color",                                                                                             // MakerGen.cs:231
                        Path= "VisionPrescription.lensSpecification.color",                                                                 // MakerGen.cs:232
                        Id = "VisionPrescription.lensSpecification.color",                                                                  // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 23. VisionPrescription.lensSpecification.brand
                    this.Element_Brand = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Brand",                                                                                             // MakerGen.cs:231
                        Path= "VisionPrescription.lensSpecification.brand",                                                                 // MakerGen.cs:232
                        Id = "VisionPrescription.lensSpecification.brand",                                                                  // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 24. VisionPrescription.lensSpecification.note
                    this.Element_Note = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Note",                                                                                              // MakerGen.cs:231
                        Path= "VisionPrescription.lensSpecification.note",                                                                  // MakerGen.cs:232
                        Id = "VisionPrescription.lensSpecification.note",                                                                   // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Annotation                                                               // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            }                                                                                                               // MakerGen.cs:353
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 1. VisionPrescription.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:212
        // 2. VisionPrescription.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:212
        // 3. VisionPrescription.created
        public ElementDefinitionInfo Element_Created;                                                                                       // MakerGen.cs:212
        // 4. VisionPrescription.patient
        public ElementDefinitionInfo Element_Patient;                                                                                       // MakerGen.cs:212
        // 5. VisionPrescription.encounter
        public ElementDefinitionInfo Element_Encounter;                                                                                     // MakerGen.cs:212
        // 6. VisionPrescription.dateWritten
        public ElementDefinitionInfo Element_DateWritten;                                                                                   // MakerGen.cs:212
        // 7. VisionPrescription.prescriber
        public ElementDefinitionInfo Element_Prescriber;                                                                                    // MakerGen.cs:212
        // 8. VisionPrescription.lensSpecification
        public ElementDefinitionInfo Element_LensSpecification;                                                                             // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            base.Write(sDef);                                                                                                               // MakerGen.cs:385
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:386
            {                                                                                                                               // MakerGen.cs:387
                Path = "VisionPrescription",                                                                                                // MakerGen.cs:388
                ElementId = "VisionPrescription"                                                                                            // MakerGen.cs:389
            });                                                                                                                             // MakerGen.cs:390
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_Created.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Patient.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Encounter.Write(sDef);                                                                                                  // MakerGen.cs:216
            Element_DateWritten.Write(sDef);                                                                                                // MakerGen.cs:216
            Element_Prescriber.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_LensSpecification.Write(sDef);                                                                                          // MakerGen.cs:216
        }                                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
        public Resource_VisionPrescription()                                                                                                // MakerGen.cs:395
        {                                                                                                                                   // MakerGen.cs:396
            {                                                                                                                               // MakerGen.cs:227
                // 1. VisionPrescription.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:231
                    Path= "VisionPrescription.identifier",                                                                                  // MakerGen.cs:232
                    Id = "VisionPrescription.identifier",                                                                                   // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 2. VisionPrescription.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Status",                                                                                                // MakerGen.cs:231
                    Path= "VisionPrescription.status",                                                                                      // MakerGen.cs:232
                    Id = "VisionPrescription.status",                                                                                       // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 3. VisionPrescription.created
                this.Element_Created = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Created",                                                                                               // MakerGen.cs:231
                    Path= "VisionPrescription.created",                                                                                     // MakerGen.cs:232
                    Id = "VisionPrescription.created",                                                                                      // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 4. VisionPrescription.patient
                this.Element_Patient = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Patient",                                                                                               // MakerGen.cs:231
                    Path= "VisionPrescription.patient",                                                                                     // MakerGen.cs:232
                    Id = "VisionPrescription.patient",                                                                                      // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Patient"                                                           // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 5. VisionPrescription.encounter
                this.Element_Encounter = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Encounter",                                                                                             // MakerGen.cs:231
                    Path= "VisionPrescription.encounter",                                                                                   // MakerGen.cs:232
                    Id = "VisionPrescription.encounter",                                                                                    // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Encounter"                                                         // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 6. VisionPrescription.dateWritten
                this.Element_DateWritten = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_DateWritten",                                                                                           // MakerGen.cs:231
                    Path= "VisionPrescription.dateWritten",                                                                                 // MakerGen.cs:232
                    Id = "VisionPrescription.dateWritten",                                                                                  // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 7. VisionPrescription.prescriber
                this.Element_Prescriber = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Prescriber",                                                                                            // MakerGen.cs:231
                    Path= "VisionPrescription.prescriber",                                                                                  // MakerGen.cs:232
                    Id = "VisionPrescription.prescriber",                                                                                   // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                     // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                                  // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 8. VisionPrescription.lensSpecification
                this.Element_LensSpecification = new ElementDefinitionInfo                                                                  // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_LensSpecification",                                                                                     // MakerGen.cs:231
                    Path= "VisionPrescription.lensSpecification",                                                                           // MakerGen.cs:232
                    Id = "VisionPrescription.lensSpecification",                                                                            // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_LensSpecification                                                                                          // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            this.Name = "VisionPrescription";                                                                                               // MakerGen.cs:458
            this.Uri = "http://hl7.org/fhir/StructureDefinition/VisionPrescription";                                                        // MakerGen.cs:459
        }                                                                                                                                   // MakerGen.cs:398
    }                                                                                                                                       // MakerGen.cs:400
}                                                                                                                                           // MakerGen.cs:445
