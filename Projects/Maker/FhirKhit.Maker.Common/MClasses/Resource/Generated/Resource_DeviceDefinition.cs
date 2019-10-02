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
      "id": "DeviceDefinition",
      "url": "http://hl7.org/fhir/StructureDefinition/DeviceDefinition",
      "version": "4.0.0",
      "name": "DeviceDefinition",
      "status": "draft",
      "publisher": "Health Level Seven International (Orders and Observations)",
      "description": "The characteristics, operational status and capabilities of a medical-related component of a medical device.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "DeviceDefinition",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "DeviceDefinition",
            "path": "DeviceDefinition",
            "short": "An instance of a medical-related component of a medical device",
            "definition": "The characteristics, operational status and capabilities of a medical-related component of a medical device.",
            "comment": "For the initial scope, this DeviceDefinition resource is only applicable to describe a single node in the containment tree that is produced by the context scanner in any medical device that implements or derives from the ISO/IEEE 11073 standard and that does not represent a metric. Examples for such a node are MDS, VMD, or Channel.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "DeviceDefinition.identifier",
            "path": "DeviceDefinition.identifier",
            "short": "Instance identifier",
            "definition": "Unique instance identifiers assigned to a device by the software, manufacturers, other organizations or owners. For example: handle ID.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Identifier"
              }
            ]
          },
          {
            "id": "DeviceDefinition.udiDeviceIdentifier",
            "path": "DeviceDefinition.udiDeviceIdentifier",
            "short": "Unique Device Identifier (UDI) Barcode string",
            "definition": "Unique device identifier (UDI) assigned to device label or package.  Note that the Device may include multiple udiCarriers as it either may include just the udiCarrier for the jurisdiction it is sold, or for multiple jurisdictions it could have been sold.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "DeviceDefinition.udiDeviceIdentifier.deviceIdentifier",
            "path": "DeviceDefinition.udiDeviceIdentifier.deviceIdentifier",
            "short": "The identifier that is to be associated with every Device that references this DeviceDefintiion for the issuer and jurisdication porvided in the DeviceDefinition.udiDeviceIdentifier",
            "definition": "The identifier that is to be associated with every Device that references this DeviceDefintiion for the issuer and jurisdication porvided in the DeviceDefinition.udiDeviceIdentifier.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "DeviceDefinition.udiDeviceIdentifier.issuer",
            "path": "DeviceDefinition.udiDeviceIdentifier.issuer",
            "short": "The organization that assigns the identifier algorithm",
            "definition": "The organization that assigns the identifier algorithm.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "uri"
              }
            ]
          },
          {
            "id": "DeviceDefinition.udiDeviceIdentifier.jurisdiction",
            "path": "DeviceDefinition.udiDeviceIdentifier.jurisdiction",
            "short": "The jurisdiction to which the deviceIdentifier applies",
            "definition": "The jurisdiction to which the deviceIdentifier applies.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "uri"
              }
            ]
          },
          {
            "id": "DeviceDefinition.manufacturer[x]",
            "path": "DeviceDefinition.manufacturer[x]",
            "short": "Name of device manufacturer",
            "definition": "A name of the manufacturer.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              },
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ]
          },
          {
            "id": "DeviceDefinition.deviceName",
            "path": "DeviceDefinition.deviceName",
            "short": "A name given to the device to identify it",
            "definition": "A name given to the device to identify it.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "DeviceDefinition.deviceName.name",
            "path": "DeviceDefinition.deviceName.name",
            "short": "The name of the device",
            "definition": "The name of the device.",
            "alias": [
              "Σ"
            ],
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "DeviceDefinition.deviceName.type",
            "path": "DeviceDefinition.deviceName.type",
            "short": "udi-label-name | user-friendly-name | patient-reported-name | manufacturer-name | model-name | other",
            "definition": "The type of deviceName.\nUDILabelName | UserFriendlyName | PatientReportedName | ManufactureDeviceName | ModelName.",
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
                  "valueString": "DeviceNameType"
                }
              ],
              "strength": "required",
              "description": "The type of name the device is referred by.",
              "valueSet": "http://hl7.org/fhir/ValueSet/device-nametype|4.0.0"
            }
          },
          {
            "id": "DeviceDefinition.modelNumber",
            "path": "DeviceDefinition.modelNumber",
            "short": "The model number for the device",
            "definition": "The model number for the device.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "DeviceDefinition.type",
            "path": "DeviceDefinition.type",
            "short": "What kind of device or device system this is",
            "definition": "What kind of device or device system this is.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "DeviceKind"
                }
              ],
              "strength": "example",
              "description": "Type of device e.g. according to official classification.",
              "valueSet": "http://hl7.org/fhir/ValueSet/device-kind"
            }
          },
          {
            "id": "DeviceDefinition.specialization",
            "path": "DeviceDefinition.specialization",
            "short": "The capabilities supported on a  device, the standards to which the device conforms for a particular purpose, and used for the communication",
            "definition": "The capabilities supported on a  device, the standards to which the device conforms for a particular purpose, and used for the communication.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "DeviceDefinition.specialization.systemType",
            "path": "DeviceDefinition.specialization.systemType",
            "short": "The standard that is used to operate and communicate",
            "definition": "The standard that is used to operate and communicate.",
            "alias": [
              "Σ"
            ],
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "DeviceDefinition.specialization.version",
            "path": "DeviceDefinition.specialization.version",
            "short": "The version of the standard that is used to operate and communicate",
            "definition": "The version of the standard that is used to operate and communicate.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "DeviceDefinition.version",
            "path": "DeviceDefinition.version",
            "short": "Available versions",
            "definition": "The available versions of the device, e.g., software versions.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "DeviceDefinition.safety",
            "path": "DeviceDefinition.safety",
            "short": "Safety characteristics of the device",
            "definition": "Safety characteristics of the device.",
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
                  "valueString": "Safety"
                }
              ],
              "strength": "example",
              "valueSet": "http://hl7.org/fhir/ValueSet/device-safety"
            }
          },
          {
            "id": "DeviceDefinition.shelfLifeStorage",
            "path": "DeviceDefinition.shelfLifeStorage",
            "short": "Shelf Life and storage information",
            "definition": "Shelf Life and storage information.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "ProductShelfLife"
              }
            ]
          },
          {
            "id": "DeviceDefinition.physicalCharacteristics",
            "path": "DeviceDefinition.physicalCharacteristics",
            "short": "Dimensions, color etc.",
            "definition": "Dimensions, color etc.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "ProdCharacteristic"
              }
            ]
          },
          {
            "id": "DeviceDefinition.languageCode",
            "path": "DeviceDefinition.languageCode",
            "short": "Language code for the human-readable text strings produced by the device (all supported)",
            "definition": "Language code for the human-readable text strings produced by the device (all supported).",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "DeviceDefinition.capability",
            "path": "DeviceDefinition.capability",
            "short": "Device capabilities",
            "definition": "Device capabilities.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "DeviceDefinition.capability.type",
            "path": "DeviceDefinition.capability.type",
            "short": "Type of capability",
            "definition": "Type of capability.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "DeviceDefinition.capability.description",
            "path": "DeviceDefinition.capability.description",
            "short": "Description of capability",
            "definition": "Description of capability.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "DeviceDefinition.property",
            "path": "DeviceDefinition.property",
            "short": "The actual configuration settings of a device as it actually operates, e.g., regulation status, time properties",
            "definition": "The actual configuration settings of a device as it actually operates, e.g., regulation status, time properties.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "DeviceDefinition.property.type",
            "path": "DeviceDefinition.property.type",
            "short": "Code that specifies the property DeviceDefinitionPropetyCode (Extensible)",
            "definition": "Code that specifies the property DeviceDefinitionPropetyCode (Extensible).",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "DeviceDefinition.property.valueQuantity",
            "path": "DeviceDefinition.property.valueQuantity",
            "short": "Property value as a quantity",
            "definition": "Property value as a quantity.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Quantity"
              }
            ]
          },
          {
            "id": "DeviceDefinition.property.valueCode",
            "path": "DeviceDefinition.property.valueCode",
            "short": "Property value as a code, e.g., NTP4 (synced to NTP)",
            "definition": "Property value as a code, e.g., NTP4 (synced to NTP).",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "DeviceDefinition.owner",
            "path": "DeviceDefinition.owner",
            "short": "Organization responsible for device",
            "definition": "An organization that is responsible for the provision and ongoing maintenance of the device.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ]
          },
          {
            "id": "DeviceDefinition.contact",
            "path": "DeviceDefinition.contact",
            "short": "Details for human/organization for support",
            "definition": "Contact details for an organization or a particular human that is responsible for the device.",
            "comment": "used for troubleshooting etc.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "ContactPoint"
              }
            ]
          },
          {
            "id": "DeviceDefinition.url",
            "path": "DeviceDefinition.url",
            "short": "Network address to contact device",
            "definition": "A network address on which the device may be contacted directly.",
            "comment": "If the device is running a FHIR server, the network address should  be the Base URL from which a conformance statement may be retrieved.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "uri"
              }
            ]
          },
          {
            "id": "DeviceDefinition.onlineInformation",
            "path": "DeviceDefinition.onlineInformation",
            "short": "Access to on-line information",
            "definition": "Access to on-line information about the device.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "uri"
              }
            ]
          },
          {
            "id": "DeviceDefinition.note",
            "path": "DeviceDefinition.note",
            "short": "Device notes and comments",
            "definition": "Descriptive information, usage information or implantation information that is not captured in an existing element.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Annotation"
              }
            ]
          },
          {
            "id": "DeviceDefinition.quantity",
            "path": "DeviceDefinition.quantity",
            "short": "The quantity of the device present in the packaging (e.g. the number of devices present in a pack, or the number of devices in the same package of the medicinal product)",
            "definition": "The quantity of the device present in the packaging (e.g. the number of devices present in a pack, or the number of devices in the same package of the medicinal product).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity"
              }
            ]
          },
          {
            "id": "DeviceDefinition.parentDevice",
            "path": "DeviceDefinition.parentDevice",
            "short": "The parent device it can be part of",
            "definition": "The parent device it can be part of.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/DeviceDefinition"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "DeviceDefinition.material",
            "path": "DeviceDefinition.material",
            "short": "A substance used to create the material(s) of which the device is made",
            "definition": "A substance used to create the material(s) of which the device is made.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "DeviceDefinition.material.substance",
            "path": "DeviceDefinition.material.substance",
            "short": "The substance",
            "definition": "The substance.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "DeviceDefinition.material.alternate",
            "path": "DeviceDefinition.material.alternate",
            "short": "Indicates an alternative material of the device",
            "definition": "Indicates an alternative material of the device.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ]
          },
          {
            "id": "DeviceDefinition.material.allergenicIndicator",
            "path": "DeviceDefinition.material.allergenicIndicator",
            "short": "Whether the substance is a known or suspected allergen",
            "definition": "Whether the substance is a known or suspected allergen.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion
    /// <summary>
    /// Fhir resource 'DeviceDefinition'
    /// </summary>
    // 0. DeviceDefinition
    public partial class Resource_DeviceDefinition : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 2. DeviceDefinition.udiDeviceIdentifier
        public partial class Type_UdiDeviceIdentifier : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 3. DeviceDefinition.udiDeviceIdentifier.deviceIdentifier
            public ElementDefinitionInfo Element_DeviceIdentifier;
            // 4. DeviceDefinition.udiDeviceIdentifier.issuer
            public ElementDefinitionInfo Element_Issuer;
            // 5. DeviceDefinition.udiDeviceIdentifier.jurisdiction
            public ElementDefinitionInfo Element_Jurisdiction;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "DeviceDefinition.udiDeviceIdentifier",
                    ElementId = "DeviceDefinition.udiDeviceIdentifier"
                });
                Element_DeviceIdentifier.Write(sDef);
                Element_Issuer.Write(sDef);
                Element_Jurisdiction.Write(sDef);
            }
            
            public Type_UdiDeviceIdentifier()
            {
                {
                    // 3. DeviceDefinition.udiDeviceIdentifier.deviceIdentifier
                    this.Element_DeviceIdentifier = new ElementDefinitionInfo
                    {
                        Name = "Element_DeviceIdentifier",
                        Path= "DeviceDefinition.udiDeviceIdentifier.deviceIdentifier",
                        Id = "DeviceDefinition.udiDeviceIdentifier.deviceIdentifier",
                        Min = 1,
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
                    // 4. DeviceDefinition.udiDeviceIdentifier.issuer
                    this.Element_Issuer = new ElementDefinitionInfo
                    {
                        Name = "Element_Issuer",
                        Path= "DeviceDefinition.udiDeviceIdentifier.issuer",
                        Id = "DeviceDefinition.udiDeviceIdentifier.issuer",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Uri
                            {
                            }
                        }
                    };
                }
                {
                    // 5. DeviceDefinition.udiDeviceIdentifier.jurisdiction
                    this.Element_Jurisdiction = new ElementDefinitionInfo
                    {
                        Name = "Element_Jurisdiction",
                        Path= "DeviceDefinition.udiDeviceIdentifier.jurisdiction",
                        Id = "DeviceDefinition.udiDeviceIdentifier.jurisdiction",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Uri
                            {
                            }
                        }
                    };
                }
            }
        }
        // 7. DeviceDefinition.deviceName
        public partial class Type_DeviceName : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 8. DeviceDefinition.deviceName.name
            public ElementDefinitionInfo Element_Name;
            // 9. DeviceDefinition.deviceName.type
            public ElementDefinitionInfo Element_Type;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "DeviceDefinition.deviceName",
                    ElementId = "DeviceDefinition.deviceName"
                });
                Element_Name.Write(sDef);
                Element_Type.Write(sDef);
            }
            
            public Type_DeviceName()
            {
                {
                    // 8. DeviceDefinition.deviceName.name
                    this.Element_Name = new ElementDefinitionInfo
                    {
                        Name = "Element_Name",
                        Path= "DeviceDefinition.deviceName.name",
                        Id = "DeviceDefinition.deviceName.name",
                        Min = 1,
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
                    // 9. DeviceDefinition.deviceName.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "DeviceDefinition.deviceName.type",
                        Id = "DeviceDefinition.deviceName.type",
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
        // 12. DeviceDefinition.specialization
        public partial class Type_Specialization : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 13. DeviceDefinition.specialization.systemType
            public ElementDefinitionInfo Element_SystemType;
            // 14. DeviceDefinition.specialization.version
            public ElementDefinitionInfo Element_Version;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "DeviceDefinition.specialization",
                    ElementId = "DeviceDefinition.specialization"
                });
                Element_SystemType.Write(sDef);
                Element_Version.Write(sDef);
            }
            
            public Type_Specialization()
            {
                {
                    // 13. DeviceDefinition.specialization.systemType
                    this.Element_SystemType = new ElementDefinitionInfo
                    {
                        Name = "Element_SystemType",
                        Path= "DeviceDefinition.specialization.systemType",
                        Id = "DeviceDefinition.specialization.systemType",
                        Min = 1,
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
                    // 14. DeviceDefinition.specialization.version
                    this.Element_Version = new ElementDefinitionInfo
                    {
                        Name = "Element_Version",
                        Path= "DeviceDefinition.specialization.version",
                        Id = "DeviceDefinition.specialization.version",
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
            }
        }
        // 20. DeviceDefinition.capability
        public partial class Type_Capability : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 21. DeviceDefinition.capability.type
            public ElementDefinitionInfo Element_Type;
            // 22. DeviceDefinition.capability.description
            public ElementDefinitionInfo Element_Description;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "DeviceDefinition.capability",
                    ElementId = "DeviceDefinition.capability"
                });
                Element_Type.Write(sDef);
                Element_Description.Write(sDef);
            }
            
            public Type_Capability()
            {
                {
                    // 21. DeviceDefinition.capability.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "DeviceDefinition.capability.type",
                        Id = "DeviceDefinition.capability.type",
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
                    // 22. DeviceDefinition.capability.description
                    this.Element_Description = new ElementDefinitionInfo
                    {
                        Name = "Element_Description",
                        Path= "DeviceDefinition.capability.description",
                        Id = "DeviceDefinition.capability.description",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                            {
                            }
                        }
                    };
                }
            }
        }
        // 23. DeviceDefinition.property
        public partial class Type_Property : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 24. DeviceDefinition.property.type
            public ElementDefinitionInfo Element_Type;
            // 25. DeviceDefinition.property.valueQuantity
            public ElementDefinitionInfo Element_ValueQuantity;
            // 26. DeviceDefinition.property.valueCode
            public ElementDefinitionInfo Element_ValueCode;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "DeviceDefinition.property",
                    ElementId = "DeviceDefinition.property"
                });
                Element_Type.Write(sDef);
                Element_ValueQuantity.Write(sDef);
                Element_ValueCode.Write(sDef);
            }
            
            public Type_Property()
            {
                {
                    // 24. DeviceDefinition.property.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "DeviceDefinition.property.type",
                        Id = "DeviceDefinition.property.type",
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
                    // 25. DeviceDefinition.property.valueQuantity
                    this.Element_ValueQuantity = new ElementDefinitionInfo
                    {
                        Name = "Element_ValueQuantity",
                        Path= "DeviceDefinition.property.valueQuantity",
                        Id = "DeviceDefinition.property.valueQuantity",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Quantity
                            {
                            }
                        }
                    };
                }
                {
                    // 26. DeviceDefinition.property.valueCode
                    this.Element_ValueCode = new ElementDefinitionInfo
                    {
                        Name = "Element_ValueCode",
                        Path= "DeviceDefinition.property.valueCode",
                        Id = "DeviceDefinition.property.valueCode",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                            {
                            }
                        }
                    };
                }
            }
        }
        // 34. DeviceDefinition.material
        public partial class Type_Material : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 35. DeviceDefinition.material.substance
            public ElementDefinitionInfo Element_Substance;
            // 36. DeviceDefinition.material.alternate
            public ElementDefinitionInfo Element_Alternate;
            // 37. DeviceDefinition.material.allergenicIndicator
            public ElementDefinitionInfo Element_AllergenicIndicator;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "DeviceDefinition.material",
                    ElementId = "DeviceDefinition.material"
                });
                Element_Substance.Write(sDef);
                Element_Alternate.Write(sDef);
                Element_AllergenicIndicator.Write(sDef);
            }
            
            public Type_Material()
            {
                {
                    // 35. DeviceDefinition.material.substance
                    this.Element_Substance = new ElementDefinitionInfo
                    {
                        Name = "Element_Substance",
                        Path= "DeviceDefinition.material.substance",
                        Id = "DeviceDefinition.material.substance",
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
                    // 36. DeviceDefinition.material.alternate
                    this.Element_Alternate = new ElementDefinitionInfo
                    {
                        Name = "Element_Alternate",
                        Path= "DeviceDefinition.material.alternate",
                        Id = "DeviceDefinition.material.alternate",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Boolean
                            {
                            }
                        }
                    };
                }
                {
                    // 37. DeviceDefinition.material.allergenicIndicator
                    this.Element_AllergenicIndicator = new ElementDefinitionInfo
                    {
                        Name = "Element_AllergenicIndicator",
                        Path= "DeviceDefinition.material.allergenicIndicator",
                        Id = "DeviceDefinition.material.allergenicIndicator",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Boolean
                            {
                            }
                        }
                    };
                }
            }
        }
        // 1. DeviceDefinition.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. DeviceDefinition.udiDeviceIdentifier
        public ElementDefinitionInfo Element_UdiDeviceIdentifier;
        // 6. DeviceDefinition.manufacturer[x]
        public ElementDefinitionInfo Element_Manufacturer;
        // 7. DeviceDefinition.deviceName
        public ElementDefinitionInfo Element_DeviceName;
        // 10. DeviceDefinition.modelNumber
        public ElementDefinitionInfo Element_ModelNumber;
        // 11. DeviceDefinition.type
        public ElementDefinitionInfo Element_Type;
        // 12. DeviceDefinition.specialization
        public ElementDefinitionInfo Element_Specialization;
        // 15. DeviceDefinition.version
        public ElementDefinitionInfo Element_Version;
        // 16. DeviceDefinition.safety
        public ElementDefinitionInfo Element_Safety;
        // 17. DeviceDefinition.shelfLifeStorage
        public ElementDefinitionInfo Element_ShelfLifeStorage;
        // 18. DeviceDefinition.physicalCharacteristics
        public ElementDefinitionInfo Element_PhysicalCharacteristics;
        // 19. DeviceDefinition.languageCode
        public ElementDefinitionInfo Element_LanguageCode;
        // 20. DeviceDefinition.capability
        public ElementDefinitionInfo Element_Capability;
        // 23. DeviceDefinition.property
        public ElementDefinitionInfo Element_Property;
        // 27. DeviceDefinition.owner
        public ElementDefinitionInfo Element_Owner;
        // 28. DeviceDefinition.contact
        public ElementDefinitionInfo Element_Contact;
        // 29. DeviceDefinition.url
        public ElementDefinitionInfo Element_Url;
        // 30. DeviceDefinition.onlineInformation
        public ElementDefinitionInfo Element_OnlineInformation;
        // 31. DeviceDefinition.note
        public ElementDefinitionInfo Element_Note;
        // 32. DeviceDefinition.quantity
        public ElementDefinitionInfo Element_Quantity;
        // 33. DeviceDefinition.parentDevice
        public ElementDefinitionInfo Element_ParentDevice;
        // 34. DeviceDefinition.material
        public ElementDefinitionInfo Element_Material;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "DeviceDefinition",
                ElementId = "DeviceDefinition"
            });
            Element_Identifier.Write(sDef);
            Element_UdiDeviceIdentifier.Write(sDef);
            Element_Manufacturer.Write(sDef);
            Element_DeviceName.Write(sDef);
            Element_ModelNumber.Write(sDef);
            Element_Type.Write(sDef);
            Element_Specialization.Write(sDef);
            Element_Version.Write(sDef);
            Element_Safety.Write(sDef);
            Element_ShelfLifeStorage.Write(sDef);
            Element_PhysicalCharacteristics.Write(sDef);
            Element_LanguageCode.Write(sDef);
            Element_Capability.Write(sDef);
            Element_Property.Write(sDef);
            Element_Owner.Write(sDef);
            Element_Contact.Write(sDef);
            Element_Url.Write(sDef);
            Element_OnlineInformation.Write(sDef);
            Element_Note.Write(sDef);
            Element_Quantity.Write(sDef);
            Element_ParentDevice.Write(sDef);
            Element_Material.Write(sDef);
        }
        
        public Resource_DeviceDefinition()
        {
            {
                // 1. DeviceDefinition.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "DeviceDefinition.identifier",
                    Id = "DeviceDefinition.identifier",
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
                // 2. DeviceDefinition.udiDeviceIdentifier
                this.Element_UdiDeviceIdentifier = new ElementDefinitionInfo
                {
                    Name = "Element_UdiDeviceIdentifier",
                    Path= "DeviceDefinition.udiDeviceIdentifier",
                    Id = "DeviceDefinition.udiDeviceIdentifier",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_UdiDeviceIdentifier
                        {
                        }
                    }
                };
            }
            {
                // 6. DeviceDefinition.manufacturer[x]
                this.Element_Manufacturer = new ElementDefinitionInfo
                {
                    Name = "Element_Manufacturer",
                    Path= "DeviceDefinition.manufacturer[x]",
                    Id = "DeviceDefinition.manufacturer[x]",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_String
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Organization"
                            }
                        }
                    }
                };
            }
            {
                // 7. DeviceDefinition.deviceName
                this.Element_DeviceName = new ElementDefinitionInfo
                {
                    Name = "Element_DeviceName",
                    Path= "DeviceDefinition.deviceName",
                    Id = "DeviceDefinition.deviceName",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_DeviceName
                        {
                        }
                    }
                };
            }
            {
                // 10. DeviceDefinition.modelNumber
                this.Element_ModelNumber = new ElementDefinitionInfo
                {
                    Name = "Element_ModelNumber",
                    Path= "DeviceDefinition.modelNumber",
                    Id = "DeviceDefinition.modelNumber",
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
                // 11. DeviceDefinition.type
                this.Element_Type = new ElementDefinitionInfo
                {
                    Name = "Element_Type",
                    Path= "DeviceDefinition.type",
                    Id = "DeviceDefinition.type",
                    Min = 0,
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
                // 12. DeviceDefinition.specialization
                this.Element_Specialization = new ElementDefinitionInfo
                {
                    Name = "Element_Specialization",
                    Path= "DeviceDefinition.specialization",
                    Id = "DeviceDefinition.specialization",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Specialization
                        {
                        }
                    }
                };
            }
            {
                // 15. DeviceDefinition.version
                this.Element_Version = new ElementDefinitionInfo
                {
                    Name = "Element_Version",
                    Path= "DeviceDefinition.version",
                    Id = "DeviceDefinition.version",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_String
                        {
                        }
                    }
                };
            }
            {
                // 16. DeviceDefinition.safety
                this.Element_Safety = new ElementDefinitionInfo
                {
                    Name = "Element_Safety",
                    Path= "DeviceDefinition.safety",
                    Id = "DeviceDefinition.safety",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                        {
                        }
                    }
                };
            }
            {
                // 17. DeviceDefinition.shelfLifeStorage
                this.Element_ShelfLifeStorage = new ElementDefinitionInfo
                {
                    Name = "Element_ShelfLifeStorage",
                    Path= "DeviceDefinition.shelfLifeStorage",
                    Id = "DeviceDefinition.shelfLifeStorage",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_ProductShelfLife
                        {
                        }
                    }
                };
            }
            {
                // 18. DeviceDefinition.physicalCharacteristics
                this.Element_PhysicalCharacteristics = new ElementDefinitionInfo
                {
                    Name = "Element_PhysicalCharacteristics",
                    Path= "DeviceDefinition.physicalCharacteristics",
                    Id = "DeviceDefinition.physicalCharacteristics",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_ProdCharacteristic
                        {
                        }
                    }
                };
            }
            {
                // 19. DeviceDefinition.languageCode
                this.Element_LanguageCode = new ElementDefinitionInfo
                {
                    Name = "Element_LanguageCode",
                    Path= "DeviceDefinition.languageCode",
                    Id = "DeviceDefinition.languageCode",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                        {
                        }
                    }
                };
            }
            {
                // 20. DeviceDefinition.capability
                this.Element_Capability = new ElementDefinitionInfo
                {
                    Name = "Element_Capability",
                    Path= "DeviceDefinition.capability",
                    Id = "DeviceDefinition.capability",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Capability
                        {
                        }
                    }
                };
            }
            {
                // 23. DeviceDefinition.property
                this.Element_Property = new ElementDefinitionInfo
                {
                    Name = "Element_Property",
                    Path= "DeviceDefinition.property",
                    Id = "DeviceDefinition.property",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Property
                        {
                        }
                    }
                };
            }
            {
                // 27. DeviceDefinition.owner
                this.Element_Owner = new ElementDefinitionInfo
                {
                    Name = "Element_Owner",
                    Path= "DeviceDefinition.owner",
                    Id = "DeviceDefinition.owner",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Organization"
                            }
                        }
                    }
                };
            }
            {
                // 28. DeviceDefinition.contact
                this.Element_Contact = new ElementDefinitionInfo
                {
                    Name = "Element_Contact",
                    Path= "DeviceDefinition.contact",
                    Id = "DeviceDefinition.contact",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_ContactPoint
                        {
                        }
                    }
                };
            }
            {
                // 29. DeviceDefinition.url
                this.Element_Url = new ElementDefinitionInfo
                {
                    Name = "Element_Url",
                    Path= "DeviceDefinition.url",
                    Id = "DeviceDefinition.url",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Uri
                        {
                        }
                    }
                };
            }
            {
                // 30. DeviceDefinition.onlineInformation
                this.Element_OnlineInformation = new ElementDefinitionInfo
                {
                    Name = "Element_OnlineInformation",
                    Path= "DeviceDefinition.onlineInformation",
                    Id = "DeviceDefinition.onlineInformation",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Uri
                        {
                        }
                    }
                };
            }
            {
                // 31. DeviceDefinition.note
                this.Element_Note = new ElementDefinitionInfo
                {
                    Name = "Element_Note",
                    Path= "DeviceDefinition.note",
                    Id = "DeviceDefinition.note",
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
            {
                // 32. DeviceDefinition.quantity
                this.Element_Quantity = new ElementDefinitionInfo
                {
                    Name = "Element_Quantity",
                    Path= "DeviceDefinition.quantity",
                    Id = "DeviceDefinition.quantity",
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
                // 33. DeviceDefinition.parentDevice
                this.Element_ParentDevice = new ElementDefinitionInfo
                {
                    Name = "Element_ParentDevice",
                    Path= "DeviceDefinition.parentDevice",
                    Id = "DeviceDefinition.parentDevice",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/DeviceDefinition"
                            }
                        }
                    }
                };
            }
            {
                // 34. DeviceDefinition.material
                this.Element_Material = new ElementDefinitionInfo
                {
                    Name = "Element_Material",
                    Path= "DeviceDefinition.material",
                    Id = "DeviceDefinition.material",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Material
                        {
                        }
                    }
                };
            }
            this.Name = "DeviceDefinition";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/DeviceDefinition";
        }
    }
}
