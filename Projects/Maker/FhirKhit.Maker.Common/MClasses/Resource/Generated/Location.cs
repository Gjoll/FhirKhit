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
      "id": "Location",
      "url": "http://hl7.org/fhir/StructureDefinition/Location",
      "version": "4.0.0",
      "name": "Location",
      "status": "draft",
      "publisher": "Health Level Seven International (Patient Administration)",
      "description": "Details and position information for a physical place where services are provided and resources and participants may be stored, found, contained, or accommodated.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "Location",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Location",
            "path": "Location",
            "short": "Details and position information for a physical place",
            "definition": "Details and position information for a physical place where services are provided and resources and participants may be stored, found, contained, or accommodated.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Location.identifier",
            "path": "Location.identifier",
            "short": "Unique code or number identifying the location to its users",
            "definition": "Unique code or number identifying the location to its users.",
            "requirements": "Organization label locations in registries, need to keep track of those.",
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
            "id": "Location.status",
            "path": "Location.status",
            "short": "active | suspended | inactive",
            "definition": "The status property covers the general availability of the resource, not the current value which may be covered by the operationStatus, or by a schedule/slots if they are configured for the location.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isModifier": true,
            "isModifierReason": "This element is labeled as a modifier because the status contains codes that mark the resource as not currently valid",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "LocationStatus"
                }
              ],
              "strength": "required",
              "description": "Indicates whether the location is still in use.",
              "valueSet": "http://hl7.org/fhir/ValueSet/location-status|4.0.0"
            }
          },
          {
            "id": "Location.operationalStatus",
            "path": "Location.operationalStatus",
            "short": "The operational status of the location (typically only for a bed/room)",
            "definition": "The operational status covers operation values most relevant to beds (but can also apply to rooms/units/chairs/etc. such as an isolation unit/dialysis chair). This typically covers concepts such as contamination, housekeeping, and other activities like maintenance.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Coding"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "OperationalStatus"
                }
              ],
              "strength": "preferred",
              "description": "The operational status if the location (where typically a bed/room).",
              "valueSet": "http://terminology.hl7.org/ValueSet/v2-0116"
            }
          },
          {
            "id": "Location.name",
            "path": "Location.name",
            "short": "Name of the location as used by humans",
            "definition": "Name of the location as used by humans. Does not need to be unique.",
            "comment": "If the name of a location changes, consider putting the old name in the alias column so that it can still be located through searches.",
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
            "id": "Location.alias",
            "path": "Location.alias",
            "short": "A list of alternate names that the location is known as, or was known as, in the past",
            "definition": "A list of alternate names that the location is known as, or was known as, in the past.",
            "comment": "There are no dates associated with the alias/historic names, as this is not intended to track when names were used, but to assist in searching so that older names can still result in identifying the location.",
            "requirements": "Over time locations and organizations go through many changes and can be known by different names.\n\nFor searching knowing previous names that the location was known by can be very useful.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "Location.description",
            "path": "Location.description",
            "short": "Additional details about the location that could be displayed as further information to identify the location beyond its name",
            "definition": "Description of the Location, which helps in finding or referencing the place.",
            "requirements": "Humans need additional information to verify a correct location has been identified.",
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
            "id": "Location.mode",
            "path": "Location.mode",
            "short": "instance | kind",
            "definition": "Indicates whether a resource instance represents a specific location or a class of locations.",
            "comment": "This is labeled as a modifier because whether or not the location is a class of locations changes how it can be used and understood.",
            "requirements": "When using a Location resource for scheduling or orders, we need to be able to refer to a class of Locations instead of a specific Location.",
            "min": 0,
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
                  "valueString": "LocationMode"
                }
              ],
              "strength": "required",
              "description": "Indicates whether a resource instance represents a specific location or a class of locations.",
              "valueSet": "http://hl7.org/fhir/ValueSet/location-mode|4.0.0"
            }
          },
          {
            "id": "Location.type",
            "path": "Location.type",
            "short": "Type of function performed",
            "definition": "Indicates the type of function performed at the location.",
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
                  "valueString": "LocationType"
                }
              ],
              "strength": "extensible",
              "description": "Indicates the type of function performed at the location.",
              "valueSet": "http://terminology.hl7.org/ValueSet/v3-ServiceDeliveryLocationRoleType"
            }
          },
          {
            "id": "Location.telecom",
            "path": "Location.telecom",
            "short": "Contact details of the location",
            "definition": "The contact details of communication devices available at the location. This can include phone numbers, fax numbers, mobile numbers, email addresses and web sites.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "ContactPoint"
              }
            ]
          },
          {
            "id": "Location.address",
            "path": "Location.address",
            "short": "Physical location",
            "definition": "Physical location.",
            "comment": "Additional addresses should be recorded using another instance of the Location resource, or via the Organization.",
            "requirements": "If locations can be visited, we need to keep track of their address.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Address"
              }
            ]
          },
          {
            "id": "Location.physicalType",
            "path": "Location.physicalType",
            "short": "Physical form of the location",
            "definition": "Physical form of the location, e.g. building, room, vehicle, road.",
            "requirements": "For purposes of showing relevant locations in queries, we need to categorize locations.",
            "min": 0,
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
                  "valueString": "PhysicalType"
                }
              ],
              "strength": "example",
              "description": "Physical form of the location.",
              "valueSet": "http://hl7.org/fhir/ValueSet/location-physical-type"
            }
          },
          {
            "id": "Location.position",
            "path": "Location.position",
            "short": "The absolute geographic location",
            "definition": "The absolute geographic location of the Location, expressed using the WGS84 datum (This is the same co-ordinate system used in KML).",
            "requirements": "For mobile applications and automated route-finding knowing the exact location of the Location is required.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Location.position.longitude",
            "path": "Location.position.longitude",
            "short": "Longitude with WGS84 datum",
            "definition": "Longitude. The value domain and the interpretation are the same as for the text of the longitude element in KML (see notes below).",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              }
            ]
          },
          {
            "id": "Location.position.latitude",
            "path": "Location.position.latitude",
            "short": "Latitude with WGS84 datum",
            "definition": "Latitude. The value domain and the interpretation are the same as for the text of the latitude element in KML (see notes below).",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              }
            ]
          },
          {
            "id": "Location.position.altitude",
            "path": "Location.position.altitude",
            "short": "Altitude with WGS84 datum",
            "definition": "Altitude. The value domain and the interpretation are the same as for the text of the altitude element in KML (see notes below).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              }
            ]
          },
          {
            "id": "Location.managingOrganization",
            "path": "Location.managingOrganization",
            "short": "Organization responsible for provisioning and upkeep",
            "definition": "The organization responsible for the provisioning and upkeep of the location.",
            "comment": "This can also be used as the part of the organization hierarchy where this location provides services. These services can be defined through the HealthcareService resource.",
            "requirements": "Need to know who manages the location.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Location.partOf",
            "path": "Location.partOf",
            "short": "Another Location this one is physically a part of",
            "definition": "Another Location of which this Location is physically a part of.",
            "requirements": "For purposes of location, display and identification, knowing which locations are located within other locations is important.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "extension": [
                  {
                    "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-hierarchy",
                    "valueBoolean": true
                  }
                ],
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Location"
                ]
              }
            ]
          },
          {
            "id": "Location.hoursOfOperation",
            "path": "Location.hoursOfOperation",
            "short": "What days/times during a week is this location usually open",
            "definition": "What days/times during a week is this location usually open.",
            "comment": "This type of information is commonly found published in directories and on websites informing customers when the facility is available.\n\nSpecific services within the location may have their own hours which could be shorter (or longer) than the locations hours.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Location.hoursOfOperation.daysOfWeek",
            "path": "Location.hoursOfOperation.daysOfWeek",
            "short": "mon | tue | wed | thu | fri | sat | sun",
            "definition": "Indicates which days of the week are available between the start and end Times.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "code"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "DaysOfWeek"
                }
              ],
              "strength": "required",
              "description": "The days of the week.",
              "valueSet": "http://hl7.org/fhir/ValueSet/days-of-week|4.0.0"
            }
          },
          {
            "id": "Location.hoursOfOperation.allDay",
            "path": "Location.hoursOfOperation.allDay",
            "short": "The Location is open all day",
            "definition": "The Location is open all day.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ]
          },
          {
            "id": "Location.hoursOfOperation.openingTime",
            "path": "Location.hoursOfOperation.openingTime",
            "short": "Time that the Location opens",
            "definition": "Time that the Location opens.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "time"
              }
            ]
          },
          {
            "id": "Location.hoursOfOperation.closingTime",
            "path": "Location.hoursOfOperation.closingTime",
            "short": "Time that the Location closes",
            "definition": "Time that the Location closes.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "time"
              }
            ]
          },
          {
            "id": "Location.availabilityExceptions",
            "path": "Location.availabilityExceptions",
            "short": "Description of availability exceptions",
            "definition": "A description of when the locations opening ours are different to normal, e.g. public holiday availability. Succinctly describing all possible exceptions to normal site availability as detailed in the opening hours Times.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "Location.endpoint",
            "path": "Location.endpoint",
            "short": "Technical endpoints providing access to services operated for the location",
            "definition": "Technical endpoints providing access to services operated for the location.",
            "requirements": "Organizations may have different systems at different locations that provide various services and need to be able to define the technical connection details for how to connect to them, and for what purpose.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Endpoint"
                ]
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:403
    /// <summary>
    /// Fhir resource 'Location'
    /// </summary>
    // 0. Location
    public class Location : FhirKhit.Maker.Common.Resource.ResourceBase                                                                     // MakerGen.cs:352
    {                                                                                                                                       // MakerGen.cs:353
        // 12. Location.position
        public class Type_Position : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 13. Location.position.longitude
            public MakerElementInstance Element_Longitude;                                                                                  // MakerGen.cs:232
            // 14. Location.position.latitude
            public MakerElementInstance Element_Latitude;                                                                                   // MakerGen.cs:232
            // 15. Location.position.altitude
            public MakerElementInstance Element_Altitude;                                                                                   // MakerGen.cs:232
            public Type_Position()                                                                                                          // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 13. Location.position.longitude
                    this.Element_Longitude = new MakerElementInstance                                                                       // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Longitude",                                                                                         // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Decimal()                                                                   // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 14. Location.position.latitude
                    this.Element_Latitude = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Latitude",                                                                                          // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Decimal()                                                                   // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 15. Location.position.altitude
                    this.Element_Altitude = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Altitude",                                                                                          // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Decimal()                                                                   // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 18. Location.hoursOfOperation
        public class Type_HoursOfOperation : FhirKhit.Maker.Common.Complex.ComplexBase                                                      // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 19. Location.hoursOfOperation.daysOfWeek
            public MakerElementInstance Element_DaysOfWeek;                                                                                 // MakerGen.cs:232
            // 20. Location.hoursOfOperation.allDay
            public MakerElementInstance Element_AllDay;                                                                                     // MakerGen.cs:232
            // 21. Location.hoursOfOperation.openingTime
            public MakerElementInstance Element_OpeningTime;                                                                                // MakerGen.cs:232
            // 22. Location.hoursOfOperation.closingTime
            public MakerElementInstance Element_ClosingTime;                                                                                // MakerGen.cs:232
            public Type_HoursOfOperation()                                                                                                  // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 19. Location.hoursOfOperation.daysOfWeek
                    this.Element_DaysOfWeek = new MakerElementInstance                                                                      // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_DaysOfWeek",                                                                                        // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Code()                                                                      // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 20. Location.hoursOfOperation.allDay
                    this.Element_AllDay = new MakerElementInstance                                                                          // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_AllDay",                                                                                            // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Boolean()                                                                   // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 21. Location.hoursOfOperation.openingTime
                    this.Element_OpeningTime = new MakerElementInstance                                                                     // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_OpeningTime",                                                                                       // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Time()                                                                      // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 22. Location.hoursOfOperation.closingTime
                    this.Element_ClosingTime = new MakerElementInstance                                                                     // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_ClosingTime",                                                                                       // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Time()                                                                      // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 1. Location.identifier
        public MakerElementInstance Element_Identifier;                                                                                     // MakerGen.cs:232
        // 2. Location.status
        public MakerElementInstance Element_Status;                                                                                         // MakerGen.cs:232
        // 3. Location.operationalStatus
        public MakerElementInstance Element_OperationalStatus;                                                                              // MakerGen.cs:232
        // 4. Location.name
        public MakerElementInstance Element_Name;                                                                                           // MakerGen.cs:232
        // 5. Location.alias
        public MakerElementInstance Element_Alias;                                                                                          // MakerGen.cs:232
        // 6. Location.description
        public MakerElementInstance Element_Description;                                                                                    // MakerGen.cs:232
        // 7. Location.mode
        public MakerElementInstance Element_Mode;                                                                                           // MakerGen.cs:232
        // 8. Location.type
        public MakerElementInstance Element_Type;                                                                                           // MakerGen.cs:232
        // 9. Location.telecom
        public MakerElementInstance Element_Telecom;                                                                                        // MakerGen.cs:232
        // 10. Location.address
        public MakerElementInstance Element_Address;                                                                                        // MakerGen.cs:232
        // 11. Location.physicalType
        public MakerElementInstance Element_PhysicalType;                                                                                   // MakerGen.cs:232
        // 16. Location.managingOrganization
        public MakerElementInstance Element_ManagingOrganization;                                                                           // MakerGen.cs:232
        // 17. Location.partOf
        public MakerElementInstance Element_PartOf;                                                                                         // MakerGen.cs:232
        // 23. Location.availabilityExceptions
        public MakerElementInstance Element_AvailabilityExceptions;                                                                         // MakerGen.cs:232
        // 24. Location.endpoint
        public MakerElementInstance Element_Endpoint;                                                                                       // MakerGen.cs:232
        public Location()                                                                                                                   // MakerGen.cs:361
        {                                                                                                                                   // MakerGen.cs:362
            {                                                                                                                               // MakerGen.cs:243
                // 1. Location.identifier
                this.Element_Identifier = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 2. Location.status
                this.Element_Status = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Status",                                                                                                // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Code()                                                                          // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 3. Location.operationalStatus
                this.Element_OperationalStatus = new MakerElementInstance                                                                   // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_OperationalStatus",                                                                                     // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Coding()                                                                          // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 4. Location.name
                this.Element_Name = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Name",                                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String()                                                                        // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 5. Location.alias
                this.Element_Alias = new MakerElementInstance                                                                               // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Alias",                                                                                                 // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String()                                                                        // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 6. Location.description
                this.Element_Description = new MakerElementInstance                                                                         // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Description",                                                                                           // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String()                                                                        // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 7. Location.mode
                this.Element_Mode = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Mode",                                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Code()                                                                          // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 8. Location.type
                this.Element_Type = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Type",                                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 9. Location.telecom
                this.Element_Telecom = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Telecom",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 10. Location.address
                this.Element_Address = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Address",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 11. Location.physicalType
                this.Element_PhysicalType = new MakerElementInstance                                                                        // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_PhysicalType",                                                                                          // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 16. Location.managingOrganization
                this.Element_ManagingOrganization = new MakerElementInstance                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ManagingOrganization",                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 17. Location.partOf
                this.Element_PartOf = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_PartOf",                                                                                                // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 23. Location.availabilityExceptions
                this.Element_AvailabilityExceptions = new MakerElementInstance                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_AvailabilityExceptions",                                                                                // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String()                                                                        // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 24. Location.endpoint
                this.Element_Endpoint = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Endpoint",                                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
        }                                                                                                                                   // MakerGen.cs:373
    }                                                                                                                                       // MakerGen.cs:357
}                                                                                                                                           // MakerGen.cs:408
