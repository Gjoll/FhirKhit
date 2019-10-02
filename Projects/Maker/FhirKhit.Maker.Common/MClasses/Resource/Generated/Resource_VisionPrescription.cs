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
    #endregion
    /// <summary>
    /// Fhir resource 'VisionPrescription'
    /// </summary>
    // 0. VisionPrescription
    public partial class Resource_VisionPrescription : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 8. VisionPrescription.lensSpecification
        public partial class Type_LensSpecification : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 14. VisionPrescription.lensSpecification.prism
            public partial class Type_Prism : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 15. VisionPrescription.lensSpecification.prism.amount
                public ElementDefinitionInfo Element_Amount;
                // 16. VisionPrescription.lensSpecification.prism.base
                public ElementDefinitionInfo Element_Base;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "VisionPrescription.lensSpecification.prism",
                        ElementId = "VisionPrescription.lensSpecification.prism"
                    });
                    Element_Amount.Write(sDef);
                    Element_Base.Write(sDef);
                }
                
                public Type_Prism()
                {
                    {
                        // 15. VisionPrescription.lensSpecification.prism.amount
                        this.Element_Amount = new ElementDefinitionInfo
                        {
                            Name = "Element_Amount",
                            Path= "VisionPrescription.lensSpecification.prism.amount",
                            Id = "VisionPrescription.lensSpecification.prism.amount",
                            Min = 1,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_Decimal
                                {
                                }
                            }
                        };
                    }
                    {
                        // 16. VisionPrescription.lensSpecification.prism.base
                        this.Element_Base = new ElementDefinitionInfo
                        {
                            Name = "Element_Base",
                            Path= "VisionPrescription.lensSpecification.prism.base",
                            Id = "VisionPrescription.lensSpecification.prism.base",
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
                }
            }
            // 9. VisionPrescription.lensSpecification.product
            public ElementDefinitionInfo Element_Product;
            // 10. VisionPrescription.lensSpecification.eye
            public ElementDefinitionInfo Element_Eye;
            // 11. VisionPrescription.lensSpecification.sphere
            public ElementDefinitionInfo Element_Sphere;
            // 12. VisionPrescription.lensSpecification.cylinder
            public ElementDefinitionInfo Element_Cylinder;
            // 13. VisionPrescription.lensSpecification.axis
            public ElementDefinitionInfo Element_Axis;
            // 14. VisionPrescription.lensSpecification.prism
            public ElementDefinitionInfo Element_Prism;
            // 17. VisionPrescription.lensSpecification.add
            public ElementDefinitionInfo Element_Add;
            // 18. VisionPrescription.lensSpecification.power
            public ElementDefinitionInfo Element_Power;
            // 19. VisionPrescription.lensSpecification.backCurve
            public ElementDefinitionInfo Element_BackCurve;
            // 20. VisionPrescription.lensSpecification.diameter
            public ElementDefinitionInfo Element_Diameter;
            // 21. VisionPrescription.lensSpecification.duration
            public ElementDefinitionInfo Element_Duration;
            // 22. VisionPrescription.lensSpecification.color
            public ElementDefinitionInfo Element_Color;
            // 23. VisionPrescription.lensSpecification.brand
            public ElementDefinitionInfo Element_Brand;
            // 24. VisionPrescription.lensSpecification.note
            public ElementDefinitionInfo Element_Note;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "VisionPrescription.lensSpecification",
                    ElementId = "VisionPrescription.lensSpecification"
                });
                Element_Product.Write(sDef);
                Element_Eye.Write(sDef);
                Element_Sphere.Write(sDef);
                Element_Cylinder.Write(sDef);
                Element_Axis.Write(sDef);
                Element_Prism.Write(sDef);
                Element_Add.Write(sDef);
                Element_Power.Write(sDef);
                Element_BackCurve.Write(sDef);
                Element_Diameter.Write(sDef);
                Element_Duration.Write(sDef);
                Element_Color.Write(sDef);
                Element_Brand.Write(sDef);
                Element_Note.Write(sDef);
            }
            
            public Type_LensSpecification()
            {
                {
                    // 9. VisionPrescription.lensSpecification.product
                    this.Element_Product = new ElementDefinitionInfo
                    {
                        Name = "Element_Product",
                        Path= "VisionPrescription.lensSpecification.product",
                        Id = "VisionPrescription.lensSpecification.product",
                        Min = 1,
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
                    // 10. VisionPrescription.lensSpecification.eye
                    this.Element_Eye = new ElementDefinitionInfo
                    {
                        Name = "Element_Eye",
                        Path= "VisionPrescription.lensSpecification.eye",
                        Id = "VisionPrescription.lensSpecification.eye",
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
                    // 11. VisionPrescription.lensSpecification.sphere
                    this.Element_Sphere = new ElementDefinitionInfo
                    {
                        Name = "Element_Sphere",
                        Path= "VisionPrescription.lensSpecification.sphere",
                        Id = "VisionPrescription.lensSpecification.sphere",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Decimal
                            {
                            }
                        }
                    };
                }
                {
                    // 12. VisionPrescription.lensSpecification.cylinder
                    this.Element_Cylinder = new ElementDefinitionInfo
                    {
                        Name = "Element_Cylinder",
                        Path= "VisionPrescription.lensSpecification.cylinder",
                        Id = "VisionPrescription.lensSpecification.cylinder",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Decimal
                            {
                            }
                        }
                    };
                }
                {
                    // 13. VisionPrescription.lensSpecification.axis
                    this.Element_Axis = new ElementDefinitionInfo
                    {
                        Name = "Element_Axis",
                        Path= "VisionPrescription.lensSpecification.axis",
                        Id = "VisionPrescription.lensSpecification.axis",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Integer
                            {
                            }
                        }
                    };
                }
                {
                    // 14. VisionPrescription.lensSpecification.prism
                    this.Element_Prism = new ElementDefinitionInfo
                    {
                        Name = "Element_Prism",
                        Path= "VisionPrescription.lensSpecification.prism",
                        Id = "VisionPrescription.lensSpecification.prism",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Prism
                            {
                            }
                        }
                    };
                }
                {
                    // 17. VisionPrescription.lensSpecification.add
                    this.Element_Add = new ElementDefinitionInfo
                    {
                        Name = "Element_Add",
                        Path= "VisionPrescription.lensSpecification.add",
                        Id = "VisionPrescription.lensSpecification.add",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Decimal
                            {
                            }
                        }
                    };
                }
                {
                    // 18. VisionPrescription.lensSpecification.power
                    this.Element_Power = new ElementDefinitionInfo
                    {
                        Name = "Element_Power",
                        Path= "VisionPrescription.lensSpecification.power",
                        Id = "VisionPrescription.lensSpecification.power",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Decimal
                            {
                            }
                        }
                    };
                }
                {
                    // 19. VisionPrescription.lensSpecification.backCurve
                    this.Element_BackCurve = new ElementDefinitionInfo
                    {
                        Name = "Element_BackCurve",
                        Path= "VisionPrescription.lensSpecification.backCurve",
                        Id = "VisionPrescription.lensSpecification.backCurve",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Decimal
                            {
                            }
                        }
                    };
                }
                {
                    // 20. VisionPrescription.lensSpecification.diameter
                    this.Element_Diameter = new ElementDefinitionInfo
                    {
                        Name = "Element_Diameter",
                        Path= "VisionPrescription.lensSpecification.diameter",
                        Id = "VisionPrescription.lensSpecification.diameter",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Decimal
                            {
                            }
                        }
                    };
                }
                {
                    // 21. VisionPrescription.lensSpecification.duration
                    this.Element_Duration = new ElementDefinitionInfo
                    {
                        Name = "Element_Duration",
                        Path= "VisionPrescription.lensSpecification.duration",
                        Id = "VisionPrescription.lensSpecification.duration",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Quantity
                            {
                            }
                        }
                    };
                }
                {
                    // 22. VisionPrescription.lensSpecification.color
                    this.Element_Color = new ElementDefinitionInfo
                    {
                        Name = "Element_Color",
                        Path= "VisionPrescription.lensSpecification.color",
                        Id = "VisionPrescription.lensSpecification.color",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_String
                            {
                            }
                        }
                    };
                }
                {
                    // 23. VisionPrescription.lensSpecification.brand
                    this.Element_Brand = new ElementDefinitionInfo
                    {
                        Name = "Element_Brand",
                        Path= "VisionPrescription.lensSpecification.brand",
                        Id = "VisionPrescription.lensSpecification.brand",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_String
                            {
                            }
                        }
                    };
                }
                {
                    // 24. VisionPrescription.lensSpecification.note
                    this.Element_Note = new ElementDefinitionInfo
                    {
                        Name = "Element_Note",
                        Path= "VisionPrescription.lensSpecification.note",
                        Id = "VisionPrescription.lensSpecification.note",
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
            }
        }
        // 1. VisionPrescription.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. VisionPrescription.status
        public ElementDefinitionInfo Element_Status;
        // 3. VisionPrescription.created
        public ElementDefinitionInfo Element_Created;
        // 4. VisionPrescription.patient
        public ElementDefinitionInfo Element_Patient;
        // 5. VisionPrescription.encounter
        public ElementDefinitionInfo Element_Encounter;
        // 6. VisionPrescription.dateWritten
        public ElementDefinitionInfo Element_DateWritten;
        // 7. VisionPrescription.prescriber
        public ElementDefinitionInfo Element_Prescriber;
        // 8. VisionPrescription.lensSpecification
        public ElementDefinitionInfo Element_LensSpecification;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "VisionPrescription",
                ElementId = "VisionPrescription"
            });
            Element_Identifier.Write(sDef);
            Element_Status.Write(sDef);
            Element_Created.Write(sDef);
            Element_Patient.Write(sDef);
            Element_Encounter.Write(sDef);
            Element_DateWritten.Write(sDef);
            Element_Prescriber.Write(sDef);
            Element_LensSpecification.Write(sDef);
        }
        
        public Resource_VisionPrescription()
        {
            {
                // 1. VisionPrescription.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "VisionPrescription.identifier",
                    Id = "VisionPrescription.identifier",
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
                // 2. VisionPrescription.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "VisionPrescription.status",
                    Id = "VisionPrescription.status",
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
                // 3. VisionPrescription.created
                this.Element_Created = new ElementDefinitionInfo
                {
                    Name = "Element_Created",
                    Path= "VisionPrescription.created",
                    Id = "VisionPrescription.created",
                    Min = 1,
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
                // 4. VisionPrescription.patient
                this.Element_Patient = new ElementDefinitionInfo
                {
                    Name = "Element_Patient",
                    Path= "VisionPrescription.patient",
                    Id = "VisionPrescription.patient",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Patient"
                            }
                        }
                    }
                };
            }
            {
                // 5. VisionPrescription.encounter
                this.Element_Encounter = new ElementDefinitionInfo
                {
                    Name = "Element_Encounter",
                    Path= "VisionPrescription.encounter",
                    Id = "VisionPrescription.encounter",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Encounter"
                            }
                        }
                    }
                };
            }
            {
                // 6. VisionPrescription.dateWritten
                this.Element_DateWritten = new ElementDefinitionInfo
                {
                    Name = "Element_DateWritten",
                    Path= "VisionPrescription.dateWritten",
                    Id = "VisionPrescription.dateWritten",
                    Min = 1,
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
                // 7. VisionPrescription.prescriber
                this.Element_Prescriber = new ElementDefinitionInfo
                {
                    Name = "Element_Prescriber",
                    Path= "VisionPrescription.prescriber",
                    Id = "VisionPrescription.prescriber",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole"
                            }
                        }
                    }
                };
            }
            {
                // 8. VisionPrescription.lensSpecification
                this.Element_LensSpecification = new ElementDefinitionInfo
                {
                    Name = "Element_LensSpecification",
                    Path= "VisionPrescription.lensSpecification",
                    Id = "VisionPrescription.lensSpecification",
                    Min = 1,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_LensSpecification
                        {
                        }
                    }
                };
            }
            this.Name = "VisionPrescription";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/VisionPrescription";
        }
    }
}
