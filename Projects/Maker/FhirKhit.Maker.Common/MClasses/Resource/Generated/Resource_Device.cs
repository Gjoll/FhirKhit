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
      "id": "Device",
      "url": "http://hl7.org/fhir/StructureDefinition/Device",
      "version": "4.0.0",
      "name": "Device",
      "status": "draft",
      "publisher": "Health Level Seven International (Orders and Observations)",
      "description": "A type of a manufactured item that is used in the provision of healthcare without being substantially changed through that activity. The device may be a medical or non-medical device.",
      "purpose": "Allows institutions to track their devices.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "Device",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Device",
            "path": "Device",
            "short": "Item used in healthcare",
            "definition": "A type of a manufactured item that is used in the provision of healthcare without being substantially changed through that activity. The device may be a medical or non-medical device.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Device.identifier",
            "path": "Device.identifier",
            "short": "Instance identifier",
            "definition": "Unique instance identifiers assigned to a device by manufacturers other organizations or owners.",
            "comment": "The barcode string from a barcode present on a device label or package may identify the instance, include names given to the device in local usage, or may identify the type of device. If the identifier identifies the type of device, Device.type element should be used.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Identifier"
              }
            ]
          },
          {
            "id": "Device.definition",
            "path": "Device.definition",
            "short": "The reference to the definition for the device",
            "definition": "The reference to the definition for the device.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/DeviceDefinition"
                ]
              }
            ]
          },
          {
            "id": "Device.udiCarrier",
            "path": "Device.udiCarrier",
            "short": "Unique Device Identifier (UDI) Barcode string",
            "definition": "Unique device identifier (UDI) assigned to device label or package.  Note that the Device may include multiple udiCarriers as it either may include just the udiCarrier for the jurisdiction it is sold, or for multiple jurisdictions it could have been sold.",
            "comment": "UDI may identify an unique instance of a device, or it may only identify the type of the device.  See [UDI mappings](device-mappings.html#udi) for a complete mapping of UDI parts to Device.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Device.udiCarrier.deviceIdentifier",
            "path": "Device.udiCarrier.deviceIdentifier",
            "short": "Mandatory fixed portion of UDI",
            "definition": "The device identifier (DI) is a mandatory, fixed portion of a UDI that identifies the labeler and the specific version or model of a device.",
            "alias": [
              "DI"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Device.udiCarrier.issuer",
            "path": "Device.udiCarrier.issuer",
            "short": "UDI Issuing Organization",
            "definition": "Organization that is charged with issuing UDIs for devices.  For example, the US FDA issuers include :\n1) GS1: \nhttp://hl7.org/fhir/NamingSystem/gs1-di, \n2) HIBCC:\nhttp://hl7.org/fhir/NamingSystem/hibcc-dI, \n3) ICCBBA for blood containers:\nhttp://hl7.org/fhir/NamingSystem/iccbba-blood-di, \n4) ICCBA for other devices:\nhttp://hl7.org/fhir/NamingSystem/iccbba-other-di.",
            "alias": [
              "Barcode System"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "uri"
              }
            ]
          },
          {
            "id": "Device.udiCarrier.jurisdiction",
            "path": "Device.udiCarrier.jurisdiction",
            "short": "Regional UDI authority",
            "definition": "The identity of the authoritative source for UDI generation within a  jurisdiction.  All UDIs are globally unique within a single namespace with the appropriate repository uri as the system.  For example,  UDIs of devices managed in the U.S. by the FDA, the value is  http://hl7.org/fhir/NamingSystem/fda-udi.",
            "requirements": "Allows a recipient of a UDI to know which database will contain the UDI-associated metadata.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "uri"
              }
            ]
          },
          {
            "id": "Device.udiCarrier.carrierAIDC",
            "path": "Device.udiCarrier.carrierAIDC",
            "short": "UDI Machine Readable Barcode String",
            "definition": "The full UDI carrier of the Automatic Identification and Data Capture (AIDC) technology representation of the barcode string as printed on the packaging of the device - e.g., a barcode or RFID.   Because of limitations on character sets in XML and the need to round-trip JSON data through XML, AIDC Formats *SHALL* be base64 encoded.",
            "comment": "The AIDC form of UDIs should be scanned or otherwise used for the identification of the device whenever possible to minimize errors in records resulting from manual transcriptions. If separate barcodes for DI and PI are present, concatenate the string with DI first and in order of human readable expression on label.",
            "alias": [
              "Automatic Identification and Data Capture"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "base64Binary"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Device.udiCarrier.carrierHRF",
            "path": "Device.udiCarrier.carrierHRF",
            "short": "UDI Human Readable Barcode String",
            "definition": "The full UDI carrier as the human readable form (HRF) representation of the barcode string as printed on the packaging of the device.",
            "comment": "If separate barcodes for DI and PI are present, concatenate the string with DI first and in order of human readable expression on label.",
            "alias": [
              "Human Readable Form"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Device.udiCarrier.entryType",
            "path": "Device.udiCarrier.entryType",
            "short": "barcode | rfid | manual +",
            "definition": "A coded entry to indicate how the data was entered.",
            "requirements": "Supports a way to distinguish hand entered from machine read data.",
            "min": 0,
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
                  "valueString": "UDIEntryType"
                }
              ],
              "strength": "required",
              "description": "Codes to identify how UDI data was entered.",
              "valueSet": "http://hl7.org/fhir/ValueSet/udi-entry-type|4.0.0"
            }
          },
          {
            "id": "Device.status",
            "path": "Device.status",
            "short": "active | inactive | entered-in-error | unknown",
            "definition": "Status of the Device availability.",
            "comment": "This element is labeled as a modifier because the status contains the codes inactive and entered-in-error that mark the device (record)as not currently valid.",
            "min": 0,
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
                  "valueString": "FHIRDeviceStatus"
                }
              ],
              "strength": "required",
              "description": "The availability status of the device.",
              "valueSet": "http://hl7.org/fhir/ValueSet/device-status|4.0.0"
            }
          },
          {
            "id": "Device.statusReason",
            "path": "Device.statusReason",
            "short": "online | paused | standby | offline | not-ready | transduc-discon | hw-discon | off",
            "definition": "Reason for the dtatus of the Device availability.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "FHIRDeviceStatusReason"
                }
              ],
              "strength": "extensible",
              "description": "The availability status reason of the device.",
              "valueSet": "http://hl7.org/fhir/ValueSet/device-status-reason"
            }
          },
          {
            "id": "Device.distinctIdentifier",
            "path": "Device.distinctIdentifier",
            "short": "The distinct identification string",
            "definition": "The distinct identification string as required by regulation for a human cell, tissue, or cellular and tissue-based product.",
            "comment": "For example, this applies to devices in the United States regulated under *Code of Federal Regulation 21CFR§1271.290(c)*.",
            "alias": [
              "Distinct Identification Code (DIC)"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "Device.manufacturer",
            "path": "Device.manufacturer",
            "short": "Name of device manufacturer",
            "definition": "A name of the manufacturer.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "Device.manufactureDate",
            "path": "Device.manufactureDate",
            "short": "Date when the device was made",
            "definition": "The date and time when the device was manufactured.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ]
          },
          {
            "id": "Device.expirationDate",
            "path": "Device.expirationDate",
            "short": "Date and time of expiry of this device (if applicable)",
            "definition": "The date and time beyond which this device is no longer valid or should not be used (if applicable).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ]
          },
          {
            "id": "Device.lotNumber",
            "path": "Device.lotNumber",
            "short": "Lot number of manufacture",
            "definition": "Lot number assigned by the manufacturer.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "Device.serialNumber",
            "path": "Device.serialNumber",
            "short": "Serial number assigned by the manufacturer",
            "definition": "The serial number assigned by the organization when the device was manufactured.",
            "comment": "Alphanumeric Maximum 20.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "Device.deviceName",
            "path": "Device.deviceName",
            "short": "The name of the device as given by the manufacturer",
            "definition": "This represents the manufacturer's name of the device as provided by the device, from a UDI label, or by a person describing the Device.  This typically would be used when a person provides the name(s) or when the device represents one of the names available from DeviceDefinition.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Device.deviceName.name",
            "path": "Device.deviceName.name",
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
            "id": "Device.deviceName.type",
            "path": "Device.deviceName.type",
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
            "id": "Device.modelNumber",
            "path": "Device.modelNumber",
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
            "id": "Device.partNumber",
            "path": "Device.partNumber",
            "short": "The part number of the device",
            "definition": "The part number of the device.",
            "comment": "Alphanumeric Maximum 20.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "Device.type",
            "path": "Device.type",
            "short": "The kind or type of device",
            "definition": "The kind or type of device.",
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
                  "valueString": "DeviceType"
                }
              ],
              "strength": "example",
              "description": "Codes to identify medical devices.",
              "valueSet": "http://hl7.org/fhir/ValueSet/device-type"
            }
          },
          {
            "id": "Device.specialization",
            "path": "Device.specialization",
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
            "id": "Device.specialization.systemType",
            "path": "Device.specialization.systemType",
            "short": "The standard that is used to operate and communicate",
            "definition": "The standard that is used to operate and communicate.",
            "alias": [
              "Σ"
            ],
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "Device.specialization.version",
            "path": "Device.specialization.version",
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
            "id": "Device.version",
            "path": "Device.version",
            "short": "The actual design of the device or software version running on the device",
            "definition": "The actual design of the device or software version running on the device.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Device.version.type",
            "path": "Device.version.type",
            "short": "The type of the device version",
            "definition": "The type of the device version.",
            "alias": [
              "Σ"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "Device.version.component",
            "path": "Device.version.component",
            "short": "A single component of the device version",
            "definition": "A single component of the device version.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Identifier"
              }
            ]
          },
          {
            "id": "Device.version.value",
            "path": "Device.version.value",
            "short": "The version text",
            "definition": "The version text.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "Device.property",
            "path": "Device.property",
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
            "id": "Device.property.type",
            "path": "Device.property.type",
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
            "id": "Device.property.valueQuantity",
            "path": "Device.property.valueQuantity",
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
            "id": "Device.property.valueCode",
            "path": "Device.property.valueCode",
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
            "id": "Device.patient",
            "path": "Device.patient",
            "short": "Patient to whom Device is affixed",
            "definition": "Patient information, If the device is affixed to a person.",
            "requirements": "If the device is implanted in a patient, then need to associate the device to the patient.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient"
                ]
              }
            ]
          },
          {
            "id": "Device.owner",
            "path": "Device.owner",
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
            "id": "Device.contact",
            "path": "Device.contact",
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
            "id": "Device.location",
            "path": "Device.location",
            "short": "Where the device is found",
            "definition": "The place where the device can be found.",
            "requirements": "Device.location can be used to track device location.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Location"
                ]
              }
            ]
          },
          {
            "id": "Device.url",
            "path": "Device.url",
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
            "id": "Device.note",
            "path": "Device.note",
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
            "id": "Device.safety",
            "path": "Device.safety",
            "short": "Safety Characteristics of Device",
            "definition": "Provides additional safety characteristics about a medical device.  For example devices containing latex.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Device.parent",
            "path": "Device.parent",
            "short": "The parent device",
            "definition": "The parent device.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Device"
                ]
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion
    /// <summary>
    /// Fhir resource 'Device'
    /// </summary>
    // 0. Device
    public class Resource_Device : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 3. Device.udiCarrier
        public class Type_UdiCarrier : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 4. Device.udiCarrier.deviceIdentifier
            public ElementDefinitionInfo Element_DeviceIdentifier;
            // 5. Device.udiCarrier.issuer
            public ElementDefinitionInfo Element_Issuer;
            // 6. Device.udiCarrier.jurisdiction
            public ElementDefinitionInfo Element_Jurisdiction;
            // 7. Device.udiCarrier.carrierAIDC
            public ElementDefinitionInfo Element_CarrierAIDC;
            // 8. Device.udiCarrier.carrierHRF
            public ElementDefinitionInfo Element_CarrierHRF;
            // 9. Device.udiCarrier.entryType
            public ElementDefinitionInfo Element_EntryType;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Device.udiCarrier",
                    ElementId = "Device.udiCarrier"
                });
                Element_DeviceIdentifier.Write(sDef);
                Element_Issuer.Write(sDef);
                Element_Jurisdiction.Write(sDef);
                Element_CarrierAIDC.Write(sDef);
                Element_CarrierHRF.Write(sDef);
                Element_EntryType.Write(sDef);
            }
            
            public Type_UdiCarrier()
            {
                {
                    // 4. Device.udiCarrier.deviceIdentifier
                    this.Element_DeviceIdentifier = new ElementDefinitionInfo
                    {
                        Name = "Element_DeviceIdentifier",
                        Path= "Device.udiCarrier.deviceIdentifier",
                        Id = "Device.udiCarrier.deviceIdentifier",
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
                    // 5. Device.udiCarrier.issuer
                    this.Element_Issuer = new ElementDefinitionInfo
                    {
                        Name = "Element_Issuer",
                        Path= "Device.udiCarrier.issuer",
                        Id = "Device.udiCarrier.issuer",
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
                    // 6. Device.udiCarrier.jurisdiction
                    this.Element_Jurisdiction = new ElementDefinitionInfo
                    {
                        Name = "Element_Jurisdiction",
                        Path= "Device.udiCarrier.jurisdiction",
                        Id = "Device.udiCarrier.jurisdiction",
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
                    // 7. Device.udiCarrier.carrierAIDC
                    this.Element_CarrierAIDC = new ElementDefinitionInfo
                    {
                        Name = "Element_CarrierAIDC",
                        Path= "Device.udiCarrier.carrierAIDC",
                        Id = "Device.udiCarrier.carrierAIDC",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Base64Binary
                            {
                            }
                        }
                    };
                }
                {
                    // 8. Device.udiCarrier.carrierHRF
                    this.Element_CarrierHRF = new ElementDefinitionInfo
                    {
                        Name = "Element_CarrierHRF",
                        Path= "Device.udiCarrier.carrierHRF",
                        Id = "Device.udiCarrier.carrierHRF",
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
                    // 9. Device.udiCarrier.entryType
                    this.Element_EntryType = new ElementDefinitionInfo
                    {
                        Name = "Element_EntryType",
                        Path= "Device.udiCarrier.entryType",
                        Id = "Device.udiCarrier.entryType",
                        Min = 0,
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
        // 18. Device.deviceName
        public class Type_DeviceName : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 19. Device.deviceName.name
            public ElementDefinitionInfo Element_Name;
            // 20. Device.deviceName.type
            public ElementDefinitionInfo Element_Type;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Device.deviceName",
                    ElementId = "Device.deviceName"
                });
                Element_Name.Write(sDef);
                Element_Type.Write(sDef);
            }
            
            public Type_DeviceName()
            {
                {
                    // 19. Device.deviceName.name
                    this.Element_Name = new ElementDefinitionInfo
                    {
                        Name = "Element_Name",
                        Path= "Device.deviceName.name",
                        Id = "Device.deviceName.name",
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
                    // 20. Device.deviceName.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "Device.deviceName.type",
                        Id = "Device.deviceName.type",
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
        // 24. Device.specialization
        public class Type_Specialization : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 25. Device.specialization.systemType
            public ElementDefinitionInfo Element_SystemType;
            // 26. Device.specialization.version
            public ElementDefinitionInfo Element_Version;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Device.specialization",
                    ElementId = "Device.specialization"
                });
                Element_SystemType.Write(sDef);
                Element_Version.Write(sDef);
            }
            
            public Type_Specialization()
            {
                {
                    // 25. Device.specialization.systemType
                    this.Element_SystemType = new ElementDefinitionInfo
                    {
                        Name = "Element_SystemType",
                        Path= "Device.specialization.systemType",
                        Id = "Device.specialization.systemType",
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
                    // 26. Device.specialization.version
                    this.Element_Version = new ElementDefinitionInfo
                    {
                        Name = "Element_Version",
                        Path= "Device.specialization.version",
                        Id = "Device.specialization.version",
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
        // 27. Device.version
        public class Type_Version : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 28. Device.version.type
            public ElementDefinitionInfo Element_Type;
            // 29. Device.version.component
            public ElementDefinitionInfo Element_Component;
            // 30. Device.version.value
            public ElementDefinitionInfo Element_Value;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Device.version",
                    ElementId = "Device.version"
                });
                Element_Type.Write(sDef);
                Element_Component.Write(sDef);
                Element_Value.Write(sDef);
            }
            
            public Type_Version()
            {
                {
                    // 28. Device.version.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "Device.version.type",
                        Id = "Device.version.type",
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
                    // 29. Device.version.component
                    this.Element_Component = new ElementDefinitionInfo
                    {
                        Name = "Element_Component",
                        Path= "Device.version.component",
                        Id = "Device.version.component",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Identifier
                            {
                            }
                        }
                    };
                }
                {
                    // 30. Device.version.value
                    this.Element_Value = new ElementDefinitionInfo
                    {
                        Name = "Element_Value",
                        Path= "Device.version.value",
                        Id = "Device.version.value",
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
            }
        }
        // 31. Device.property
        public class Type_Property : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 32. Device.property.type
            public ElementDefinitionInfo Element_Type;
            // 33. Device.property.valueQuantity
            public ElementDefinitionInfo Element_ValueQuantity;
            // 34. Device.property.valueCode
            public ElementDefinitionInfo Element_ValueCode;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Device.property",
                    ElementId = "Device.property"
                });
                Element_Type.Write(sDef);
                Element_ValueQuantity.Write(sDef);
                Element_ValueCode.Write(sDef);
            }
            
            public Type_Property()
            {
                {
                    // 32. Device.property.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "Device.property.type",
                        Id = "Device.property.type",
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
                    // 33. Device.property.valueQuantity
                    this.Element_ValueQuantity = new ElementDefinitionInfo
                    {
                        Name = "Element_ValueQuantity",
                        Path= "Device.property.valueQuantity",
                        Id = "Device.property.valueQuantity",
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
                    // 34. Device.property.valueCode
                    this.Element_ValueCode = new ElementDefinitionInfo
                    {
                        Name = "Element_ValueCode",
                        Path= "Device.property.valueCode",
                        Id = "Device.property.valueCode",
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
        // 1. Device.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. Device.definition
        public ElementDefinitionInfo Element_Definition;
        // 3. Device.udiCarrier
        public ElementDefinitionInfo Element_UdiCarrier;
        // 10. Device.status
        public ElementDefinitionInfo Element_Status;
        // 11. Device.statusReason
        public ElementDefinitionInfo Element_StatusReason;
        // 12. Device.distinctIdentifier
        public ElementDefinitionInfo Element_DistinctIdentifier;
        // 13. Device.manufacturer
        public ElementDefinitionInfo Element_Manufacturer;
        // 14. Device.manufactureDate
        public ElementDefinitionInfo Element_ManufactureDate;
        // 15. Device.expirationDate
        public ElementDefinitionInfo Element_ExpirationDate;
        // 16. Device.lotNumber
        public ElementDefinitionInfo Element_LotNumber;
        // 17. Device.serialNumber
        public ElementDefinitionInfo Element_SerialNumber;
        // 18. Device.deviceName
        public ElementDefinitionInfo Element_DeviceName;
        // 21. Device.modelNumber
        public ElementDefinitionInfo Element_ModelNumber;
        // 22. Device.partNumber
        public ElementDefinitionInfo Element_PartNumber;
        // 23. Device.type
        public ElementDefinitionInfo Element_Type;
        // 24. Device.specialization
        public ElementDefinitionInfo Element_Specialization;
        // 27. Device.version
        public ElementDefinitionInfo Element_Version;
        // 31. Device.property
        public ElementDefinitionInfo Element_Property;
        // 35. Device.patient
        public ElementDefinitionInfo Element_Patient;
        // 36. Device.owner
        public ElementDefinitionInfo Element_Owner;
        // 37. Device.contact
        public ElementDefinitionInfo Element_Contact;
        // 38. Device.location
        public ElementDefinitionInfo Element_Location;
        // 39. Device.url
        public ElementDefinitionInfo Element_Url;
        // 40. Device.note
        public ElementDefinitionInfo Element_Note;
        // 41. Device.safety
        public ElementDefinitionInfo Element_Safety;
        // 42. Device.parent
        public ElementDefinitionInfo Element_Parent;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "Device",
                ElementId = "Device"
            });
            Element_Identifier.Write(sDef);
            Element_Definition.Write(sDef);
            Element_UdiCarrier.Write(sDef);
            Element_Status.Write(sDef);
            Element_StatusReason.Write(sDef);
            Element_DistinctIdentifier.Write(sDef);
            Element_Manufacturer.Write(sDef);
            Element_ManufactureDate.Write(sDef);
            Element_ExpirationDate.Write(sDef);
            Element_LotNumber.Write(sDef);
            Element_SerialNumber.Write(sDef);
            Element_DeviceName.Write(sDef);
            Element_ModelNumber.Write(sDef);
            Element_PartNumber.Write(sDef);
            Element_Type.Write(sDef);
            Element_Specialization.Write(sDef);
            Element_Version.Write(sDef);
            Element_Property.Write(sDef);
            Element_Patient.Write(sDef);
            Element_Owner.Write(sDef);
            Element_Contact.Write(sDef);
            Element_Location.Write(sDef);
            Element_Url.Write(sDef);
            Element_Note.Write(sDef);
            Element_Safety.Write(sDef);
            Element_Parent.Write(sDef);
        }
        
        public Resource_Device()
        {
            {
                // 1. Device.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "Device.identifier",
                    Id = "Device.identifier",
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
                // 2. Device.definition
                this.Element_Definition = new ElementDefinitionInfo
                {
                    Name = "Element_Definition",
                    Path= "Device.definition",
                    Id = "Device.definition",
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
                // 3. Device.udiCarrier
                this.Element_UdiCarrier = new ElementDefinitionInfo
                {
                    Name = "Element_UdiCarrier",
                    Path= "Device.udiCarrier",
                    Id = "Device.udiCarrier",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_UdiCarrier
                        {
                        }
                    }
                };
            }
            {
                // 10. Device.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "Device.status",
                    Id = "Device.status",
                    Min = 0,
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
                // 11. Device.statusReason
                this.Element_StatusReason = new ElementDefinitionInfo
                {
                    Name = "Element_StatusReason",
                    Path= "Device.statusReason",
                    Id = "Device.statusReason",
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
                // 12. Device.distinctIdentifier
                this.Element_DistinctIdentifier = new ElementDefinitionInfo
                {
                    Name = "Element_DistinctIdentifier",
                    Path= "Device.distinctIdentifier",
                    Id = "Device.distinctIdentifier",
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
                // 13. Device.manufacturer
                this.Element_Manufacturer = new ElementDefinitionInfo
                {
                    Name = "Element_Manufacturer",
                    Path= "Device.manufacturer",
                    Id = "Device.manufacturer",
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
                // 14. Device.manufactureDate
                this.Element_ManufactureDate = new ElementDefinitionInfo
                {
                    Name = "Element_ManufactureDate",
                    Path= "Device.manufactureDate",
                    Id = "Device.manufactureDate",
                    Min = 0,
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
                // 15. Device.expirationDate
                this.Element_ExpirationDate = new ElementDefinitionInfo
                {
                    Name = "Element_ExpirationDate",
                    Path= "Device.expirationDate",
                    Id = "Device.expirationDate",
                    Min = 0,
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
                // 16. Device.lotNumber
                this.Element_LotNumber = new ElementDefinitionInfo
                {
                    Name = "Element_LotNumber",
                    Path= "Device.lotNumber",
                    Id = "Device.lotNumber",
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
                // 17. Device.serialNumber
                this.Element_SerialNumber = new ElementDefinitionInfo
                {
                    Name = "Element_SerialNumber",
                    Path= "Device.serialNumber",
                    Id = "Device.serialNumber",
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
                // 18. Device.deviceName
                this.Element_DeviceName = new ElementDefinitionInfo
                {
                    Name = "Element_DeviceName",
                    Path= "Device.deviceName",
                    Id = "Device.deviceName",
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
                // 21. Device.modelNumber
                this.Element_ModelNumber = new ElementDefinitionInfo
                {
                    Name = "Element_ModelNumber",
                    Path= "Device.modelNumber",
                    Id = "Device.modelNumber",
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
                // 22. Device.partNumber
                this.Element_PartNumber = new ElementDefinitionInfo
                {
                    Name = "Element_PartNumber",
                    Path= "Device.partNumber",
                    Id = "Device.partNumber",
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
                // 23. Device.type
                this.Element_Type = new ElementDefinitionInfo
                {
                    Name = "Element_Type",
                    Path= "Device.type",
                    Id = "Device.type",
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
                // 24. Device.specialization
                this.Element_Specialization = new ElementDefinitionInfo
                {
                    Name = "Element_Specialization",
                    Path= "Device.specialization",
                    Id = "Device.specialization",
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
                // 27. Device.version
                this.Element_Version = new ElementDefinitionInfo
                {
                    Name = "Element_Version",
                    Path= "Device.version",
                    Id = "Device.version",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Version
                        {
                        }
                    }
                };
            }
            {
                // 31. Device.property
                this.Element_Property = new ElementDefinitionInfo
                {
                    Name = "Element_Property",
                    Path= "Device.property",
                    Id = "Device.property",
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
                // 35. Device.patient
                this.Element_Patient = new ElementDefinitionInfo
                {
                    Name = "Element_Patient",
                    Path= "Device.patient",
                    Id = "Device.patient",
                    Min = 0,
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
                // 36. Device.owner
                this.Element_Owner = new ElementDefinitionInfo
                {
                    Name = "Element_Owner",
                    Path= "Device.owner",
                    Id = "Device.owner",
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
                // 37. Device.contact
                this.Element_Contact = new ElementDefinitionInfo
                {
                    Name = "Element_Contact",
                    Path= "Device.contact",
                    Id = "Device.contact",
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
                // 38. Device.location
                this.Element_Location = new ElementDefinitionInfo
                {
                    Name = "Element_Location",
                    Path= "Device.location",
                    Id = "Device.location",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Location"
                            }
                        }
                    }
                };
            }
            {
                // 39. Device.url
                this.Element_Url = new ElementDefinitionInfo
                {
                    Name = "Element_Url",
                    Path= "Device.url",
                    Id = "Device.url",
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
                // 40. Device.note
                this.Element_Note = new ElementDefinitionInfo
                {
                    Name = "Element_Note",
                    Path= "Device.note",
                    Id = "Device.note",
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
                // 41. Device.safety
                this.Element_Safety = new ElementDefinitionInfo
                {
                    Name = "Element_Safety",
                    Path= "Device.safety",
                    Id = "Device.safety",
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
                // 42. Device.parent
                this.Element_Parent = new ElementDefinitionInfo
                {
                    Name = "Element_Parent",
                    Path= "Device.parent",
                    Id = "Device.parent",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Device"
                            }
                        }
                    }
                };
            }
            this.Name = "Device";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Device";
        }
    }
}
