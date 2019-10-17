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
    #endregion                                                                                                                              // MakerGen.cs:444
    /// <summary>
    /// Fhir resource 'DeviceDefinition'
    /// </summary>
    // 0. DeviceDefinition
    public partial class Resource_DeviceDefinition : FhirKhit.Maker.Common.Resource.Resource_DomainResource                                 // MakerGen.cs:381
    {                                                                                                                                       // MakerGen.cs:382
        // 2. DeviceDefinition.udiDeviceIdentifier
        public partial class Type_UdiDeviceIdentifier : FhirKhit.Maker.Common.Complex.ComplexBase                                           // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 3. DeviceDefinition.udiDeviceIdentifier.deviceIdentifier
            public ElementDefinitionInfo Element_DeviceIdentifier;                                                                          // MakerGen.cs:217
            // 4. DeviceDefinition.udiDeviceIdentifier.issuer
            public ElementDefinitionInfo Element_Issuer;                                                                                    // MakerGen.cs:217
            // 5. DeviceDefinition.udiDeviceIdentifier.jurisdiction
            public ElementDefinitionInfo Element_Jurisdiction;                                                                              // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:388
            {                                                                                                                               // MakerGen.cs:389
                base.Write(sDef);                                                                                                           // MakerGen.cs:390
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:391
                {                                                                                                                           // MakerGen.cs:392
                    Path = "DeviceDefinition.udiDeviceIdentifier",                                                                          // MakerGen.cs:393
                    ElementId = "DeviceDefinition.udiDeviceIdentifier"                                                                      // MakerGen.cs:394
                });                                                                                                                         // MakerGen.cs:395
                Element_DeviceIdentifier.Write(sDef);                                                                                       // MakerGen.cs:221
                Element_Issuer.Write(sDef);                                                                                                 // MakerGen.cs:221
                Element_Jurisdiction.Write(sDef);                                                                                           // MakerGen.cs:221
            }                                                                                                                               // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
            public Type_UdiDeviceIdentifier()                                                                                               // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:232
                    // 3. DeviceDefinition.udiDeviceIdentifier.deviceIdentifier
                    this.Element_DeviceIdentifier = new ElementDefinitionInfo                                                               // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_DeviceIdentifier",                                                                                  // MakerGen.cs:236
                        Path= "DeviceDefinition.udiDeviceIdentifier.deviceIdentifier",                                                      // MakerGen.cs:237
                        Id = "DeviceDefinition.udiDeviceIdentifier.deviceIdentifier",                                                       // MakerGen.cs:238
                        Min = 1,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 4. DeviceDefinition.udiDeviceIdentifier.issuer
                    this.Element_Issuer = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Issuer",                                                                                            // MakerGen.cs:236
                        Path= "DeviceDefinition.udiDeviceIdentifier.issuer",                                                                // MakerGen.cs:237
                        Id = "DeviceDefinition.udiDeviceIdentifier.issuer",                                                                 // MakerGen.cs:238
                        Min = 1,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_Uri                                                               // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 5. DeviceDefinition.udiDeviceIdentifier.jurisdiction
                    this.Element_Jurisdiction = new ElementDefinitionInfo                                                                   // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Jurisdiction",                                                                                      // MakerGen.cs:236
                        Path= "DeviceDefinition.udiDeviceIdentifier.jurisdiction",                                                          // MakerGen.cs:237
                        Id = "DeviceDefinition.udiDeviceIdentifier.jurisdiction",                                                           // MakerGen.cs:238
                        Min = 1,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_Uri                                                               // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
            }                                                                                                                               // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:405
        // 7. DeviceDefinition.deviceName
        public partial class Type_DeviceName : FhirKhit.Maker.Common.Complex.ComplexBase                                                    // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 8. DeviceDefinition.deviceName.name
            public ElementDefinitionInfo Element_Name;                                                                                      // MakerGen.cs:217
            // 9. DeviceDefinition.deviceName.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:388
            {                                                                                                                               // MakerGen.cs:389
                base.Write(sDef);                                                                                                           // MakerGen.cs:390
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:391
                {                                                                                                                           // MakerGen.cs:392
                    Path = "DeviceDefinition.deviceName",                                                                                   // MakerGen.cs:393
                    ElementId = "DeviceDefinition.deviceName"                                                                               // MakerGen.cs:394
                });                                                                                                                         // MakerGen.cs:395
                Element_Name.Write(sDef);                                                                                                   // MakerGen.cs:221
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:221
            }                                                                                                                               // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
            public Type_DeviceName()                                                                                                        // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:232
                    // 8. DeviceDefinition.deviceName.name
                    this.Element_Name = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Name",                                                                                              // MakerGen.cs:236
                        Path= "DeviceDefinition.deviceName.name",                                                                           // MakerGen.cs:237
                        Id = "DeviceDefinition.deviceName.name",                                                                            // MakerGen.cs:238
                        Min = 1,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 9. DeviceDefinition.deviceName.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Type",                                                                                              // MakerGen.cs:236
                        Path= "DeviceDefinition.deviceName.type",                                                                           // MakerGen.cs:237
                        Id = "DeviceDefinition.deviceName.type",                                                                            // MakerGen.cs:238
                        Min = 1,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                              // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
            }                                                                                                                               // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:405
        // 12. DeviceDefinition.specialization
        public partial class Type_Specialization : FhirKhit.Maker.Common.Complex.ComplexBase                                                // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 13. DeviceDefinition.specialization.systemType
            public ElementDefinitionInfo Element_SystemType;                                                                                // MakerGen.cs:217
            // 14. DeviceDefinition.specialization.version
            public ElementDefinitionInfo Element_Version;                                                                                   // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:388
            {                                                                                                                               // MakerGen.cs:389
                base.Write(sDef);                                                                                                           // MakerGen.cs:390
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:391
                {                                                                                                                           // MakerGen.cs:392
                    Path = "DeviceDefinition.specialization",                                                                               // MakerGen.cs:393
                    ElementId = "DeviceDefinition.specialization"                                                                           // MakerGen.cs:394
                });                                                                                                                         // MakerGen.cs:395
                Element_SystemType.Write(sDef);                                                                                             // MakerGen.cs:221
                Element_Version.Write(sDef);                                                                                                // MakerGen.cs:221
            }                                                                                                                               // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
            public Type_Specialization()                                                                                                    // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:232
                    // 13. DeviceDefinition.specialization.systemType
                    this.Element_SystemType = new ElementDefinitionInfo                                                                     // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_SystemType",                                                                                        // MakerGen.cs:236
                        Path= "DeviceDefinition.specialization.systemType",                                                                 // MakerGen.cs:237
                        Id = "DeviceDefinition.specialization.systemType",                                                                  // MakerGen.cs:238
                        Min = 1,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 14. DeviceDefinition.specialization.version
                    this.Element_Version = new ElementDefinitionInfo                                                                        // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Version",                                                                                           // MakerGen.cs:236
                        Path= "DeviceDefinition.specialization.version",                                                                    // MakerGen.cs:237
                        Id = "DeviceDefinition.specialization.version",                                                                     // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
            }                                                                                                                               // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:405
        // 20. DeviceDefinition.capability
        public partial class Type_Capability : FhirKhit.Maker.Common.Complex.ComplexBase                                                    // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 21. DeviceDefinition.capability.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:217
            // 22. DeviceDefinition.capability.description
            public ElementDefinitionInfo Element_Description;                                                                               // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:388
            {                                                                                                                               // MakerGen.cs:389
                base.Write(sDef);                                                                                                           // MakerGen.cs:390
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:391
                {                                                                                                                           // MakerGen.cs:392
                    Path = "DeviceDefinition.capability",                                                                                   // MakerGen.cs:393
                    ElementId = "DeviceDefinition.capability"                                                                               // MakerGen.cs:394
                });                                                                                                                         // MakerGen.cs:395
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:221
                Element_Description.Write(sDef);                                                                                            // MakerGen.cs:221
            }                                                                                                                               // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
            public Type_Capability()                                                                                                        // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:232
                    // 21. DeviceDefinition.capability.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Type",                                                                                              // MakerGen.cs:236
                        Path= "DeviceDefinition.capability.type",                                                                           // MakerGen.cs:237
                        Id = "DeviceDefinition.capability.type",                                                                            // MakerGen.cs:238
                        Min = 1,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:316
                            {                                                                                                               // MakerGen.cs:317
                            }                                                                                                               // MakerGen.cs:320
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 22. DeviceDefinition.capability.description
                    this.Element_Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Description",                                                                                       // MakerGen.cs:236
                        Path= "DeviceDefinition.capability.description",                                                                    // MakerGen.cs:237
                        Id = "DeviceDefinition.capability.description",                                                                     // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = -1,                                                                                                           // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:316
                            {                                                                                                               // MakerGen.cs:317
                            }                                                                                                               // MakerGen.cs:320
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
            }                                                                                                                               // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:405
        // 23. DeviceDefinition.property
        public partial class Type_Property : FhirKhit.Maker.Common.Complex.ComplexBase                                                      // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 24. DeviceDefinition.property.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:217
            // 25. DeviceDefinition.property.valueQuantity
            public ElementDefinitionInfo Element_ValueQuantity;                                                                             // MakerGen.cs:217
            // 26. DeviceDefinition.property.valueCode
            public ElementDefinitionInfo Element_ValueCode;                                                                                 // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:388
            {                                                                                                                               // MakerGen.cs:389
                base.Write(sDef);                                                                                                           // MakerGen.cs:390
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:391
                {                                                                                                                           // MakerGen.cs:392
                    Path = "DeviceDefinition.property",                                                                                     // MakerGen.cs:393
                    ElementId = "DeviceDefinition.property"                                                                                 // MakerGen.cs:394
                });                                                                                                                         // MakerGen.cs:395
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:221
                Element_ValueQuantity.Write(sDef);                                                                                          // MakerGen.cs:221
                Element_ValueCode.Write(sDef);                                                                                              // MakerGen.cs:221
            }                                                                                                                               // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
            public Type_Property()                                                                                                          // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:232
                    // 24. DeviceDefinition.property.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Type",                                                                                              // MakerGen.cs:236
                        Path= "DeviceDefinition.property.type",                                                                             // MakerGen.cs:237
                        Id = "DeviceDefinition.property.type",                                                                              // MakerGen.cs:238
                        Min = 1,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:316
                            {                                                                                                               // MakerGen.cs:317
                            }                                                                                                               // MakerGen.cs:320
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 25. DeviceDefinition.property.valueQuantity
                    this.Element_ValueQuantity = new ElementDefinitionInfo                                                                  // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_ValueQuantity",                                                                                     // MakerGen.cs:236
                        Path= "DeviceDefinition.property.valueQuantity",                                                                    // MakerGen.cs:237
                        Id = "DeviceDefinition.property.valueQuantity",                                                                     // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = -1,                                                                                                           // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                 // MakerGen.cs:356
                            {                                                                                                               // MakerGen.cs:357
                            }                                                                                                               // MakerGen.cs:358
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 26. DeviceDefinition.property.valueCode
                    this.Element_ValueCode = new ElementDefinitionInfo                                                                      // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_ValueCode",                                                                                         // MakerGen.cs:236
                        Path= "DeviceDefinition.property.valueCode",                                                                        // MakerGen.cs:237
                        Id = "DeviceDefinition.property.valueCode",                                                                         // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = -1,                                                                                                           // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:316
                            {                                                                                                               // MakerGen.cs:317
                            }                                                                                                               // MakerGen.cs:320
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
            }                                                                                                                               // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:405
        // 34. DeviceDefinition.material
        public partial class Type_Material : FhirKhit.Maker.Common.Complex.ComplexBase                                                      // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 35. DeviceDefinition.material.substance
            public ElementDefinitionInfo Element_Substance;                                                                                 // MakerGen.cs:217
            // 36. DeviceDefinition.material.alternate
            public ElementDefinitionInfo Element_Alternate;                                                                                 // MakerGen.cs:217
            // 37. DeviceDefinition.material.allergenicIndicator
            public ElementDefinitionInfo Element_AllergenicIndicator;                                                                       // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:388
            {                                                                                                                               // MakerGen.cs:389
                base.Write(sDef);                                                                                                           // MakerGen.cs:390
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:391
                {                                                                                                                           // MakerGen.cs:392
                    Path = "DeviceDefinition.material",                                                                                     // MakerGen.cs:393
                    ElementId = "DeviceDefinition.material"                                                                                 // MakerGen.cs:394
                });                                                                                                                         // MakerGen.cs:395
                Element_Substance.Write(sDef);                                                                                              // MakerGen.cs:221
                Element_Alternate.Write(sDef);                                                                                              // MakerGen.cs:221
                Element_AllergenicIndicator.Write(sDef);                                                                                    // MakerGen.cs:221
            }                                                                                                                               // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
            public Type_Material()                                                                                                          // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:232
                    // 35. DeviceDefinition.material.substance
                    this.Element_Substance = new ElementDefinitionInfo                                                                      // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Substance",                                                                                         // MakerGen.cs:236
                        Path= "DeviceDefinition.material.substance",                                                                        // MakerGen.cs:237
                        Id = "DeviceDefinition.material.substance",                                                                         // MakerGen.cs:238
                        Min = 1,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:316
                            {                                                                                                               // MakerGen.cs:317
                            }                                                                                                               // MakerGen.cs:320
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 36. DeviceDefinition.material.alternate
                    this.Element_Alternate = new ElementDefinitionInfo                                                                      // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Alternate",                                                                                         // MakerGen.cs:236
                        Path= "DeviceDefinition.material.alternate",                                                                        // MakerGen.cs:237
                        Id = "DeviceDefinition.material.alternate",                                                                         // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                           // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 37. DeviceDefinition.material.allergenicIndicator
                    this.Element_AllergenicIndicator = new ElementDefinitionInfo                                                            // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_AllergenicIndicator",                                                                               // MakerGen.cs:236
                        Path= "DeviceDefinition.material.allergenicIndicator",                                                              // MakerGen.cs:237
                        Id = "DeviceDefinition.material.allergenicIndicator",                                                               // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                           // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
            }                                                                                                                               // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:405
        // 1. DeviceDefinition.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:217
        // 2. DeviceDefinition.udiDeviceIdentifier
        public ElementDefinitionInfo Element_UdiDeviceIdentifier;                                                                           // MakerGen.cs:217
        // 6. DeviceDefinition.manufacturer[x]
        public ElementDefinitionInfo Element_Manufacturer;                                                                                  // MakerGen.cs:217
        // 7. DeviceDefinition.deviceName
        public ElementDefinitionInfo Element_DeviceName;                                                                                    // MakerGen.cs:217
        // 10. DeviceDefinition.modelNumber
        public ElementDefinitionInfo Element_ModelNumber;                                                                                   // MakerGen.cs:217
        // 11. DeviceDefinition.type
        public ElementDefinitionInfo Element_Type;                                                                                          // MakerGen.cs:217
        // 12. DeviceDefinition.specialization
        public ElementDefinitionInfo Element_Specialization;                                                                                // MakerGen.cs:217
        // 15. DeviceDefinition.version
        public ElementDefinitionInfo Element_Version;                                                                                       // MakerGen.cs:217
        // 16. DeviceDefinition.safety
        public ElementDefinitionInfo Element_Safety;                                                                                        // MakerGen.cs:217
        // 17. DeviceDefinition.shelfLifeStorage
        public ElementDefinitionInfo Element_ShelfLifeStorage;                                                                              // MakerGen.cs:217
        // 18. DeviceDefinition.physicalCharacteristics
        public ElementDefinitionInfo Element_PhysicalCharacteristics;                                                                       // MakerGen.cs:217
        // 19. DeviceDefinition.languageCode
        public ElementDefinitionInfo Element_LanguageCode;                                                                                  // MakerGen.cs:217
        // 20. DeviceDefinition.capability
        public ElementDefinitionInfo Element_Capability;                                                                                    // MakerGen.cs:217
        // 23. DeviceDefinition.property
        public ElementDefinitionInfo Element_Property;                                                                                      // MakerGen.cs:217
        // 27. DeviceDefinition.owner
        public ElementDefinitionInfo Element_Owner;                                                                                         // MakerGen.cs:217
        // 28. DeviceDefinition.contact
        public ElementDefinitionInfo Element_Contact;                                                                                       // MakerGen.cs:217
        // 29. DeviceDefinition.url
        public ElementDefinitionInfo Element_Url;                                                                                           // MakerGen.cs:217
        // 30. DeviceDefinition.onlineInformation
        public ElementDefinitionInfo Element_OnlineInformation;                                                                             // MakerGen.cs:217
        // 31. DeviceDefinition.note
        public ElementDefinitionInfo Element_Note;                                                                                          // MakerGen.cs:217
        // 32. DeviceDefinition.quantity
        public ElementDefinitionInfo Element_Quantity;                                                                                      // MakerGen.cs:217
        // 33. DeviceDefinition.parentDevice
        public ElementDefinitionInfo Element_ParentDevice;                                                                                  // MakerGen.cs:217
        // 34. DeviceDefinition.material
        public ElementDefinitionInfo Element_Material;                                                                                      // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:388
        {                                                                                                                                   // MakerGen.cs:389
            base.Write(sDef);                                                                                                               // MakerGen.cs:390
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:391
            {                                                                                                                               // MakerGen.cs:392
                Path = "DeviceDefinition",                                                                                                  // MakerGen.cs:393
                ElementId = "DeviceDefinition"                                                                                              // MakerGen.cs:394
            });                                                                                                                             // MakerGen.cs:395
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:221
            Element_UdiDeviceIdentifier.Write(sDef);                                                                                        // MakerGen.cs:221
            Element_Manufacturer.Write(sDef);                                                                                               // MakerGen.cs:221
            Element_DeviceName.Write(sDef);                                                                                                 // MakerGen.cs:221
            Element_ModelNumber.Write(sDef);                                                                                                // MakerGen.cs:221
            Element_Type.Write(sDef);                                                                                                       // MakerGen.cs:221
            Element_Specialization.Write(sDef);                                                                                             // MakerGen.cs:221
            Element_Version.Write(sDef);                                                                                                    // MakerGen.cs:221
            Element_Safety.Write(sDef);                                                                                                     // MakerGen.cs:221
            Element_ShelfLifeStorage.Write(sDef);                                                                                           // MakerGen.cs:221
            Element_PhysicalCharacteristics.Write(sDef);                                                                                    // MakerGen.cs:221
            Element_LanguageCode.Write(sDef);                                                                                               // MakerGen.cs:221
            Element_Capability.Write(sDef);                                                                                                 // MakerGen.cs:221
            Element_Property.Write(sDef);                                                                                                   // MakerGen.cs:221
            Element_Owner.Write(sDef);                                                                                                      // MakerGen.cs:221
            Element_Contact.Write(sDef);                                                                                                    // MakerGen.cs:221
            Element_Url.Write(sDef);                                                                                                        // MakerGen.cs:221
            Element_OnlineInformation.Write(sDef);                                                                                          // MakerGen.cs:221
            Element_Note.Write(sDef);                                                                                                       // MakerGen.cs:221
            Element_Quantity.Write(sDef);                                                                                                   // MakerGen.cs:221
            Element_ParentDevice.Write(sDef);                                                                                               // MakerGen.cs:221
            Element_Material.Write(sDef);                                                                                                   // MakerGen.cs:221
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
        public Resource_DeviceDefinition()                                                                                                  // MakerGen.cs:400
        {                                                                                                                                   // MakerGen.cs:401
            {                                                                                                                               // MakerGen.cs:232
                // 1. DeviceDefinition.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:236
                    Path= "DeviceDefinition.identifier",                                                                                    // MakerGen.cs:237
                    Id = "DeviceDefinition.identifier",                                                                                     // MakerGen.cs:238
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
                // 2. DeviceDefinition.udiDeviceIdentifier
                this.Element_UdiDeviceIdentifier = new ElementDefinitionInfo                                                                // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_UdiDeviceIdentifier",                                                                                   // MakerGen.cs:236
                    Path= "DeviceDefinition.udiDeviceIdentifier",                                                                           // MakerGen.cs:237
                    Id = "DeviceDefinition.udiDeviceIdentifier",                                                                            // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new Type_UdiDeviceIdentifier                                                                                        // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:262
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 6. DeviceDefinition.manufacturer[x]
                this.Element_Manufacturer = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Manufacturer",                                                                                          // MakerGen.cs:236
                    Path= "DeviceDefinition.manufacturer[x]",                                                                               // MakerGen.cs:237
                    Id = "DeviceDefinition.manufacturer[x]",                                                                                // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        },                                                                                                                  // MakerGen.cs:305
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Organization"                                                      // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 7. DeviceDefinition.deviceName
                this.Element_DeviceName = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_DeviceName",                                                                                            // MakerGen.cs:236
                    Path= "DeviceDefinition.deviceName",                                                                                    // MakerGen.cs:237
                    Id = "DeviceDefinition.deviceName",                                                                                     // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new Type_DeviceName                                                                                                 // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:262
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 10. DeviceDefinition.modelNumber
                this.Element_ModelNumber = new ElementDefinitionInfo                                                                        // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_ModelNumber",                                                                                           // MakerGen.cs:236
                    Path= "DeviceDefinition.modelNumber",                                                                                   // MakerGen.cs:237
                    Id = "DeviceDefinition.modelNumber",                                                                                    // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 11. DeviceDefinition.type
                this.Element_Type = new ElementDefinitionInfo                                                                               // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Type",                                                                                                  // MakerGen.cs:236
                    Path= "DeviceDefinition.type",                                                                                          // MakerGen.cs:237
                    Id = "DeviceDefinition.type",                                                                                           // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
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
                // 12. DeviceDefinition.specialization
                this.Element_Specialization = new ElementDefinitionInfo                                                                     // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Specialization",                                                                                        // MakerGen.cs:236
                    Path= "DeviceDefinition.specialization",                                                                                // MakerGen.cs:237
                    Id = "DeviceDefinition.specialization",                                                                                 // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new Type_Specialization                                                                                             // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:262
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 15. DeviceDefinition.version
                this.Element_Version = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Version",                                                                                               // MakerGen.cs:236
                    Path= "DeviceDefinition.version",                                                                                       // MakerGen.cs:237
                    Id = "DeviceDefinition.version",                                                                                        // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 16. DeviceDefinition.safety
                this.Element_Safety = new ElementDefinitionInfo                                                                             // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Safety",                                                                                                // MakerGen.cs:236
                    Path= "DeviceDefinition.safety",                                                                                        // MakerGen.cs:237
                    Id = "DeviceDefinition.safety",                                                                                         // MakerGen.cs:238
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
                // 17. DeviceDefinition.shelfLifeStorage
                this.Element_ShelfLifeStorage = new ElementDefinitionInfo                                                                   // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_ShelfLifeStorage",                                                                                      // MakerGen.cs:236
                    Path= "DeviceDefinition.shelfLifeStorage",                                                                              // MakerGen.cs:237
                    Id = "DeviceDefinition.shelfLifeStorage",                                                                               // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_ProductShelfLife                                                             // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 18. DeviceDefinition.physicalCharacteristics
                this.Element_PhysicalCharacteristics = new ElementDefinitionInfo                                                            // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_PhysicalCharacteristics",                                                                               // MakerGen.cs:236
                    Path= "DeviceDefinition.physicalCharacteristics",                                                                       // MakerGen.cs:237
                    Id = "DeviceDefinition.physicalCharacteristics",                                                                        // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_ProdCharacteristic                                                           // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 19. DeviceDefinition.languageCode
                this.Element_LanguageCode = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_LanguageCode",                                                                                          // MakerGen.cs:236
                    Path= "DeviceDefinition.languageCode",                                                                                  // MakerGen.cs:237
                    Id = "DeviceDefinition.languageCode",                                                                                   // MakerGen.cs:238
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
                // 20. DeviceDefinition.capability
                this.Element_Capability = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Capability",                                                                                            // MakerGen.cs:236
                    Path= "DeviceDefinition.capability",                                                                                    // MakerGen.cs:237
                    Id = "DeviceDefinition.capability",                                                                                     // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new Type_Capability                                                                                                 // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:262
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 23. DeviceDefinition.property
                this.Element_Property = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Property",                                                                                              // MakerGen.cs:236
                    Path= "DeviceDefinition.property",                                                                                      // MakerGen.cs:237
                    Id = "DeviceDefinition.property",                                                                                       // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new Type_Property                                                                                                   // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:262
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 27. DeviceDefinition.owner
                this.Element_Owner = new ElementDefinitionInfo                                                                              // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Owner",                                                                                                 // MakerGen.cs:236
                    Path= "DeviceDefinition.owner",                                                                                         // MakerGen.cs:237
                    Id = "DeviceDefinition.owner",                                                                                          // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Organization"                                                      // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 28. DeviceDefinition.contact
                this.Element_Contact = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Contact",                                                                                               // MakerGen.cs:236
                    Path= "DeviceDefinition.contact",                                                                                       // MakerGen.cs:237
                    Id = "DeviceDefinition.contact",                                                                                        // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_ContactPoint                                                                 // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 29. DeviceDefinition.url
                this.Element_Url = new ElementDefinitionInfo                                                                                // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Url",                                                                                                   // MakerGen.cs:236
                    Path= "DeviceDefinition.url",                                                                                           // MakerGen.cs:237
                    Id = "DeviceDefinition.url",                                                                                            // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Uri                                                                   // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 30. DeviceDefinition.onlineInformation
                this.Element_OnlineInformation = new ElementDefinitionInfo                                                                  // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_OnlineInformation",                                                                                     // MakerGen.cs:236
                    Path= "DeviceDefinition.onlineInformation",                                                                             // MakerGen.cs:237
                    Id = "DeviceDefinition.onlineInformation",                                                                              // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Uri                                                                   // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 31. DeviceDefinition.note
                this.Element_Note = new ElementDefinitionInfo                                                                               // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Note",                                                                                                  // MakerGen.cs:236
                    Path= "DeviceDefinition.note",                                                                                          // MakerGen.cs:237
                    Id = "DeviceDefinition.note",                                                                                           // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Annotation                                                                   // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 32. DeviceDefinition.quantity
                this.Element_Quantity = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Quantity",                                                                                              // MakerGen.cs:236
                    Path= "DeviceDefinition.quantity",                                                                                      // MakerGen.cs:237
                    Id = "DeviceDefinition.quantity",                                                                                       // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                     // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 33. DeviceDefinition.parentDevice
                this.Element_ParentDevice = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_ParentDevice",                                                                                          // MakerGen.cs:236
                    Path= "DeviceDefinition.parentDevice",                                                                                  // MakerGen.cs:237
                    Id = "DeviceDefinition.parentDevice",                                                                                   // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/DeviceDefinition"                                                  // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 34. DeviceDefinition.material
                this.Element_Material = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Material",                                                                                              // MakerGen.cs:236
                    Path= "DeviceDefinition.material",                                                                                      // MakerGen.cs:237
                    Id = "DeviceDefinition.material",                                                                                       // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new Type_Material                                                                                                   // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:262
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            this.Name = "DeviceDefinition";                                                                                                 // MakerGen.cs:468
            this.Uri = "http://hl7.org/fhir/StructureDefinition/DeviceDefinition";                                                          // MakerGen.cs:469
        }                                                                                                                                   // MakerGen.cs:403
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:449
