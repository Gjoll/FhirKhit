using System;                                                                                                                               // MakerGen.cs:449
using System.Diagnostics;                                                                                                                   // MakerGen.cs:450
using System.IO;                                                                                                                            // MakerGen.cs:451
using System.Linq;                                                                                                                          // MakerGen.cs:452
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:453
                                                                                                                                            // MakerGen.cs:454
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:455
{                                                                                                                                           // MakerGen.cs:456
    #region Json                                                                                                                            // MakerGen.cs:457
    #if NEVER                                                                                                                               // MakerGen.cs:458
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
    #endregion                                                                                                                              // MakerGen.cs:461
    /// <summary>
    /// Fhir resource 'DeviceDefinition'
    /// </summary>
    // 0. DeviceDefinition
    public class DeviceDefinition : FhirKhit.Maker.Common.Resource.ResourceBase                                                             // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        public class DeviceDefinition_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                // MakerGen.cs:385
        {                                                                                                                                   // MakerGen.cs:386
            // 2. DeviceDefinition.udiDeviceIdentifier
            public class Type_UdiDeviceIdentifier : FhirKhit.Maker.Common.Complex.ComplexBase                                               // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_UdiDeviceIdentifier_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 3. DeviceDefinition.udiDeviceIdentifier.deviceIdentifier
                    public ElementDefinitionInfo DeviceIdentifier;                                                                          // MakerGen.cs:216
                    // 4. DeviceDefinition.udiDeviceIdentifier.issuer
                    public ElementDefinitionInfo Issuer;                                                                                    // MakerGen.cs:216
                    // 5. DeviceDefinition.udiDeviceIdentifier.jurisdiction
                    public ElementDefinitionInfo Jurisdiction;                                                                              // MakerGen.cs:216
                    public Type_UdiDeviceIdentifier_Elements()                                                                              // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 3. DeviceDefinition.udiDeviceIdentifier.deviceIdentifier
                            this.DeviceIdentifier = new ElementDefinitionInfo                                                               // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "DeviceIdentifier",                                                                                  // MakerGen.cs:235
                                Path= "DeviceDefinition.udiDeviceIdentifier.deviceIdentifier",                                              // MakerGen.cs:236
                                Id = "DeviceDefinition.udiDeviceIdentifier.deviceIdentifier",                                               // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 4. DeviceDefinition.udiDeviceIdentifier.issuer
                            this.Issuer = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Issuer",                                                                                            // MakerGen.cs:235
                                Path= "DeviceDefinition.udiDeviceIdentifier.issuer",                                                        // MakerGen.cs:236
                                Id = "DeviceDefinition.udiDeviceIdentifier.issuer",                                                         // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Uri                                                                 // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 5. DeviceDefinition.udiDeviceIdentifier.jurisdiction
                            this.Jurisdiction = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Jurisdiction",                                                                                      // MakerGen.cs:235
                                Path= "DeviceDefinition.udiDeviceIdentifier.jurisdiction",                                                  // MakerGen.cs:236
                                Id = "DeviceDefinition.udiDeviceIdentifier.jurisdiction",                                                   // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Uri                                                                 // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        DeviceIdentifier.Write(sDef);                                                                                       // MakerGen.cs:220
                        Issuer.Write(sDef);                                                                                                 // MakerGen.cs:220
                        Jurisdiction.Write(sDef);                                                                                           // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_UdiDeviceIdentifier_Elements Elements { get; }                                                                  // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_UdiDeviceIdentifier()                                                                                           // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_UdiDeviceIdentifier_Elements();                                                                // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 7. DeviceDefinition.deviceName
            public class Type_DeviceName : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_DeviceName_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                         // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 8. DeviceDefinition.deviceName.name
                    public ElementDefinitionInfo Name;                                                                                      // MakerGen.cs:216
                    // 9. DeviceDefinition.deviceName.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:216
                    public Type_DeviceName_Elements()                                                                                       // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 8. DeviceDefinition.deviceName.name
                            this.Name = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Name",                                                                                              // MakerGen.cs:235
                                Path= "DeviceDefinition.deviceName.name",                                                                   // MakerGen.cs:236
                                Id = "DeviceDefinition.deviceName.name",                                                                    // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 9. DeviceDefinition.deviceName.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Type",                                                                                              // MakerGen.cs:235
                                Path= "DeviceDefinition.deviceName.type",                                                                   // MakerGen.cs:236
                                Id = "DeviceDefinition.deviceName.type",                                                                    // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        Name.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_DeviceName_Elements Elements { get; }                                                                           // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_DeviceName()                                                                                                    // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_DeviceName_Elements();                                                                         // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 12. DeviceDefinition.specialization
            public class Type_Specialization : FhirKhit.Maker.Common.Complex.ComplexBase                                                    // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_Specialization_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                     // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 13. DeviceDefinition.specialization.systemType
                    public ElementDefinitionInfo SystemType;                                                                                // MakerGen.cs:216
                    // 14. DeviceDefinition.specialization.version
                    public ElementDefinitionInfo Version;                                                                                   // MakerGen.cs:216
                    public Type_Specialization_Elements()                                                                                   // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 13. DeviceDefinition.specialization.systemType
                            this.SystemType = new ElementDefinitionInfo                                                                     // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "SystemType",                                                                                        // MakerGen.cs:235
                                Path= "DeviceDefinition.specialization.systemType",                                                         // MakerGen.cs:236
                                Id = "DeviceDefinition.specialization.systemType",                                                          // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 14. DeviceDefinition.specialization.version
                            this.Version = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Version",                                                                                           // MakerGen.cs:235
                                Path= "DeviceDefinition.specialization.version",                                                            // MakerGen.cs:236
                                Id = "DeviceDefinition.specialization.version",                                                             // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        SystemType.Write(sDef);                                                                                             // MakerGen.cs:220
                        Version.Write(sDef);                                                                                                // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_Specialization_Elements Elements { get; }                                                                       // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_Specialization()                                                                                                // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_Specialization_Elements();                                                                     // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 20. DeviceDefinition.capability
            public class Type_Capability : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_Capability_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                         // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 21. DeviceDefinition.capability.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:216
                    // 22. DeviceDefinition.capability.description
                    public ElementDefinitionInfo Description;                                                                               // MakerGen.cs:216
                    public Type_Capability_Elements()                                                                                       // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 21. DeviceDefinition.capability.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Type",                                                                                              // MakerGen.cs:235
                                Path= "DeviceDefinition.capability.type",                                                                   // MakerGen.cs:236
                                Id = "DeviceDefinition.capability.type",                                                                    // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 22. DeviceDefinition.capability.description
                            this.Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Description",                                                                                       // MakerGen.cs:235
                                Path= "DeviceDefinition.capability.description",                                                            // MakerGen.cs:236
                                Id = "DeviceDefinition.capability.description",                                                             // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Description.Write(sDef);                                                                                            // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_Capability_Elements Elements { get; }                                                                           // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_Capability()                                                                                                    // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_Capability_Elements();                                                                         // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 23. DeviceDefinition.property
            public class Type_Property : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_Property_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                           // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 24. DeviceDefinition.property.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:216
                    // 25. DeviceDefinition.property.valueQuantity
                    public ElementDefinitionInfo ValueQuantity;                                                                             // MakerGen.cs:216
                    // 26. DeviceDefinition.property.valueCode
                    public ElementDefinitionInfo ValueCode;                                                                                 // MakerGen.cs:216
                    public Type_Property_Elements()                                                                                         // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 24. DeviceDefinition.property.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Type",                                                                                              // MakerGen.cs:235
                                Path= "DeviceDefinition.property.type",                                                                     // MakerGen.cs:236
                                Id = "DeviceDefinition.property.type",                                                                      // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 25. DeviceDefinition.property.valueQuantity
                            this.ValueQuantity = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "ValueQuantity",                                                                                     // MakerGen.cs:235
                                Path= "DeviceDefinition.property.valueQuantity",                                                            // MakerGen.cs:236
                                Id = "DeviceDefinition.property.valueQuantity",                                                             // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Quantity                                                              // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 26. DeviceDefinition.property.valueCode
                            this.ValueCode = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "ValueCode",                                                                                         // MakerGen.cs:235
                                Path= "DeviceDefinition.property.valueCode",                                                                // MakerGen.cs:236
                                Id = "DeviceDefinition.property.valueCode",                                                                 // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:220
                        ValueQuantity.Write(sDef);                                                                                          // MakerGen.cs:220
                        ValueCode.Write(sDef);                                                                                              // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_Property_Elements Elements { get; }                                                                             // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_Property()                                                                                                      // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_Property_Elements();                                                                           // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 34. DeviceDefinition.material
            public class Type_Material : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_Material_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                           // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 35. DeviceDefinition.material.substance
                    public ElementDefinitionInfo Substance;                                                                                 // MakerGen.cs:216
                    // 36. DeviceDefinition.material.alternate
                    public ElementDefinitionInfo Alternate;                                                                                 // MakerGen.cs:216
                    // 37. DeviceDefinition.material.allergenicIndicator
                    public ElementDefinitionInfo AllergenicIndicator;                                                                       // MakerGen.cs:216
                    public Type_Material_Elements()                                                                                         // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 35. DeviceDefinition.material.substance
                            this.Substance = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Substance",                                                                                         // MakerGen.cs:235
                                Path= "DeviceDefinition.material.substance",                                                                // MakerGen.cs:236
                                Id = "DeviceDefinition.material.substance",                                                                 // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 36. DeviceDefinition.material.alternate
                            this.Alternate = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Alternate",                                                                                         // MakerGen.cs:235
                                Path= "DeviceDefinition.material.alternate",                                                                // MakerGen.cs:236
                                Id = "DeviceDefinition.material.alternate",                                                                 // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Boolean                                                             // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 37. DeviceDefinition.material.allergenicIndicator
                            this.AllergenicIndicator = new ElementDefinitionInfo                                                            // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "AllergenicIndicator",                                                                               // MakerGen.cs:235
                                Path= "DeviceDefinition.material.allergenicIndicator",                                                      // MakerGen.cs:236
                                Id = "DeviceDefinition.material.allergenicIndicator",                                                       // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Boolean                                                             // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        Substance.Write(sDef);                                                                                              // MakerGen.cs:220
                        Alternate.Write(sDef);                                                                                              // MakerGen.cs:220
                        AllergenicIndicator.Write(sDef);                                                                                    // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_Material_Elements Elements { get; }                                                                             // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_Material()                                                                                                      // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_Material_Elements();                                                                           // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 1. DeviceDefinition.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:216
            // 2. DeviceDefinition.udiDeviceIdentifier
            public ElementDefinitionInfo UdiDeviceIdentifier;                                                                               // MakerGen.cs:216
            // 6. DeviceDefinition.manufacturer[x]
            public ElementDefinitionInfo Manufacturer;                                                                                      // MakerGen.cs:216
            // 7. DeviceDefinition.deviceName
            public ElementDefinitionInfo DeviceName;                                                                                        // MakerGen.cs:216
            // 10. DeviceDefinition.modelNumber
            public ElementDefinitionInfo ModelNumber;                                                                                       // MakerGen.cs:216
            // 11. DeviceDefinition.type
            public ElementDefinitionInfo Type;                                                                                              // MakerGen.cs:216
            // 12. DeviceDefinition.specialization
            public ElementDefinitionInfo Specialization;                                                                                    // MakerGen.cs:216
            // 15. DeviceDefinition.version
            public ElementDefinitionInfo Version;                                                                                           // MakerGen.cs:216
            // 16. DeviceDefinition.safety
            public ElementDefinitionInfo Safety;                                                                                            // MakerGen.cs:216
            // 17. DeviceDefinition.shelfLifeStorage
            public ElementDefinitionInfo ShelfLifeStorage;                                                                                  // MakerGen.cs:216
            // 18. DeviceDefinition.physicalCharacteristics
            public ElementDefinitionInfo PhysicalCharacteristics;                                                                           // MakerGen.cs:216
            // 19. DeviceDefinition.languageCode
            public ElementDefinitionInfo LanguageCode;                                                                                      // MakerGen.cs:216
            // 20. DeviceDefinition.capability
            public ElementDefinitionInfo Capability;                                                                                        // MakerGen.cs:216
            // 23. DeviceDefinition.property
            public ElementDefinitionInfo Property;                                                                                          // MakerGen.cs:216
            // 27. DeviceDefinition.owner
            public ElementDefinitionInfo Owner;                                                                                             // MakerGen.cs:216
            // 28. DeviceDefinition.contact
            public ElementDefinitionInfo Contact;                                                                                           // MakerGen.cs:216
            // 29. DeviceDefinition.url
            public ElementDefinitionInfo Url;                                                                                               // MakerGen.cs:216
            // 30. DeviceDefinition.onlineInformation
            public ElementDefinitionInfo OnlineInformation;                                                                                 // MakerGen.cs:216
            // 31. DeviceDefinition.note
            public ElementDefinitionInfo Note;                                                                                              // MakerGen.cs:216
            // 32. DeviceDefinition.quantity
            public ElementDefinitionInfo Quantity;                                                                                          // MakerGen.cs:216
            // 33. DeviceDefinition.parentDevice
            public ElementDefinitionInfo ParentDevice;                                                                                      // MakerGen.cs:216
            // 34. DeviceDefinition.material
            public ElementDefinitionInfo Material;                                                                                          // MakerGen.cs:216
            public DeviceDefinition_Elements()                                                                                              // MakerGen.cs:407
            {                                                                                                                               // MakerGen.cs:408
                {                                                                                                                           // MakerGen.cs:231
                    // 1. DeviceDefinition.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Identifier",                                                                                                // MakerGen.cs:235
                        Path= "DeviceDefinition.identifier",                                                                                // MakerGen.cs:236
                        Id = "DeviceDefinition.identifier",                                                                                 // MakerGen.cs:237
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
                    // 2. DeviceDefinition.udiDeviceIdentifier
                    this.UdiDeviceIdentifier = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "UdiDeviceIdentifier",                                                                                       // MakerGen.cs:235
                        Path= "DeviceDefinition.udiDeviceIdentifier",                                                                       // MakerGen.cs:236
                        Id = "DeviceDefinition.udiDeviceIdentifier",                                                                        // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_UdiDeviceIdentifier                                                                                    // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 6. DeviceDefinition.manufacturer[x]
                    this.Manufacturer = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Manufacturer",                                                                                              // MakerGen.cs:235
                        Path= "DeviceDefinition.manufacturer[x]",                                                                           // MakerGen.cs:236
                        Id = "DeviceDefinition.manufacturer[x]",                                                                            // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            },                                                                                                              // MakerGen.cs:304
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 7. DeviceDefinition.deviceName
                    this.DeviceName = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "DeviceName",                                                                                                // MakerGen.cs:235
                        Path= "DeviceDefinition.deviceName",                                                                                // MakerGen.cs:236
                        Id = "DeviceDefinition.deviceName",                                                                                 // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_DeviceName                                                                                             // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 10. DeviceDefinition.modelNumber
                    this.ModelNumber = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ModelNumber",                                                                                               // MakerGen.cs:235
                        Path= "DeviceDefinition.modelNumber",                                                                               // MakerGen.cs:236
                        Id = "DeviceDefinition.modelNumber",                                                                                // MakerGen.cs:237
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
                    // 11. DeviceDefinition.type
                    this.Type = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Type",                                                                                                      // MakerGen.cs:235
                        Path= "DeviceDefinition.type",                                                                                      // MakerGen.cs:236
                        Id = "DeviceDefinition.type",                                                                                       // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 12. DeviceDefinition.specialization
                    this.Specialization = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Specialization",                                                                                            // MakerGen.cs:235
                        Path= "DeviceDefinition.specialization",                                                                            // MakerGen.cs:236
                        Id = "DeviceDefinition.specialization",                                                                             // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Specialization                                                                                         // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 15. DeviceDefinition.version
                    this.Version = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Version",                                                                                                   // MakerGen.cs:235
                        Path= "DeviceDefinition.version",                                                                                   // MakerGen.cs:236
                        Id = "DeviceDefinition.version",                                                                                    // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 16. DeviceDefinition.safety
                    this.Safety = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Safety",                                                                                                    // MakerGen.cs:235
                        Path= "DeviceDefinition.safety",                                                                                    // MakerGen.cs:236
                        Id = "DeviceDefinition.safety",                                                                                     // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 17. DeviceDefinition.shelfLifeStorage
                    this.ShelfLifeStorage = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ShelfLifeStorage",                                                                                          // MakerGen.cs:235
                        Path= "DeviceDefinition.shelfLifeStorage",                                                                          // MakerGen.cs:236
                        Id = "DeviceDefinition.shelfLifeStorage",                                                                           // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.ProductShelfLife                                                              // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 18. DeviceDefinition.physicalCharacteristics
                    this.PhysicalCharacteristics = new ElementDefinitionInfo                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "PhysicalCharacteristics",                                                                                   // MakerGen.cs:235
                        Path= "DeviceDefinition.physicalCharacteristics",                                                                   // MakerGen.cs:236
                        Id = "DeviceDefinition.physicalCharacteristics",                                                                    // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.ProdCharacteristic                                                            // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 19. DeviceDefinition.languageCode
                    this.LanguageCode = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "LanguageCode",                                                                                              // MakerGen.cs:235
                        Path= "DeviceDefinition.languageCode",                                                                              // MakerGen.cs:236
                        Id = "DeviceDefinition.languageCode",                                                                               // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 20. DeviceDefinition.capability
                    this.Capability = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Capability",                                                                                                // MakerGen.cs:235
                        Path= "DeviceDefinition.capability",                                                                                // MakerGen.cs:236
                        Id = "DeviceDefinition.capability",                                                                                 // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Capability                                                                                             // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 23. DeviceDefinition.property
                    this.Property = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Property",                                                                                                  // MakerGen.cs:235
                        Path= "DeviceDefinition.property",                                                                                  // MakerGen.cs:236
                        Id = "DeviceDefinition.property",                                                                                   // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Property                                                                                               // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 27. DeviceDefinition.owner
                    this.Owner = new ElementDefinitionInfo                                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Owner",                                                                                                     // MakerGen.cs:235
                        Path= "DeviceDefinition.owner",                                                                                     // MakerGen.cs:236
                        Id = "DeviceDefinition.owner",                                                                                      // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 28. DeviceDefinition.contact
                    this.Contact = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Contact",                                                                                                   // MakerGen.cs:235
                        Path= "DeviceDefinition.contact",                                                                                   // MakerGen.cs:236
                        Id = "DeviceDefinition.contact",                                                                                    // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.ContactPoint                                                                  // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 29. DeviceDefinition.url
                    this.Url = new ElementDefinitionInfo                                                                                    // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Url",                                                                                                       // MakerGen.cs:235
                        Path= "DeviceDefinition.url",                                                                                       // MakerGen.cs:236
                        Id = "DeviceDefinition.url",                                                                                        // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Uri                                                                         // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 30. DeviceDefinition.onlineInformation
                    this.OnlineInformation = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "OnlineInformation",                                                                                         // MakerGen.cs:235
                        Path= "DeviceDefinition.onlineInformation",                                                                         // MakerGen.cs:236
                        Id = "DeviceDefinition.onlineInformation",                                                                          // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Uri                                                                         // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 31. DeviceDefinition.note
                    this.Note = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Note",                                                                                                      // MakerGen.cs:235
                        Path= "DeviceDefinition.note",                                                                                      // MakerGen.cs:236
                        Id = "DeviceDefinition.note",                                                                                       // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Annotation                                                                    // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 32. DeviceDefinition.quantity
                    this.Quantity = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Quantity",                                                                                                  // MakerGen.cs:235
                        Path= "DeviceDefinition.quantity",                                                                                  // MakerGen.cs:236
                        Id = "DeviceDefinition.quantity",                                                                                   // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Quantity                                                                      // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 33. DeviceDefinition.parentDevice
                    this.ParentDevice = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ParentDevice",                                                                                              // MakerGen.cs:235
                        Path= "DeviceDefinition.parentDevice",                                                                              // MakerGen.cs:236
                        Id = "DeviceDefinition.parentDevice",                                                                               // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/DeviceDefinition"                                              // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 34. DeviceDefinition.material
                    this.Material = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Material",                                                                                                  // MakerGen.cs:235
                        Path= "DeviceDefinition.material",                                                                                  // MakerGen.cs:236
                        Id = "DeviceDefinition.material",                                                                                   // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Material                                                                                               // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:427
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:412
            {                                                                                                                               // MakerGen.cs:413
                base.Write(sDef);                                                                                                           // MakerGen.cs:414
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:220
                UdiDeviceIdentifier.Write(sDef);                                                                                            // MakerGen.cs:220
                Manufacturer.Write(sDef);                                                                                                   // MakerGen.cs:220
                DeviceName.Write(sDef);                                                                                                     // MakerGen.cs:220
                ModelNumber.Write(sDef);                                                                                                    // MakerGen.cs:220
                Type.Write(sDef);                                                                                                           // MakerGen.cs:220
                Specialization.Write(sDef);                                                                                                 // MakerGen.cs:220
                Version.Write(sDef);                                                                                                        // MakerGen.cs:220
                Safety.Write(sDef);                                                                                                         // MakerGen.cs:220
                ShelfLifeStorage.Write(sDef);                                                                                               // MakerGen.cs:220
                PhysicalCharacteristics.Write(sDef);                                                                                        // MakerGen.cs:220
                LanguageCode.Write(sDef);                                                                                                   // MakerGen.cs:220
                Capability.Write(sDef);                                                                                                     // MakerGen.cs:220
                Property.Write(sDef);                                                                                                       // MakerGen.cs:220
                Owner.Write(sDef);                                                                                                          // MakerGen.cs:220
                Contact.Write(sDef);                                                                                                        // MakerGen.cs:220
                Url.Write(sDef);                                                                                                            // MakerGen.cs:220
                OnlineInformation.Write(sDef);                                                                                              // MakerGen.cs:220
                Note.Write(sDef);                                                                                                           // MakerGen.cs:220
                Quantity.Write(sDef);                                                                                                       // MakerGen.cs:220
                ParentDevice.Write(sDef);                                                                                                   // MakerGen.cs:220
                Material.Write(sDef);                                                                                                       // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:431
        }                                                                                                                                   // MakerGen.cs:391
        public DeviceDefinition_Elements Elements { get; }                                                                                  // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
        public DeviceDefinition()                                                                                                           // MakerGen.cs:394
        {                                                                                                                                   // MakerGen.cs:395
            this.Elements = new DeviceDefinition_Elements();                                                                                // MakerGen.cs:396
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:399
        {                                                                                                                                   // MakerGen.cs:400
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:401
        }                                                                                                                                   // MakerGen.cs:402
    }                                                                                                                                       // MakerGen.cs:403
}                                                                                                                                           // MakerGen.cs:466
