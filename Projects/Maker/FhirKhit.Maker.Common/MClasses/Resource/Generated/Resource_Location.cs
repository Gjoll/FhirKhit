using System;                                                                                                                               // MakerGen.cs:435
using System.Diagnostics;                                                                                                                   // MakerGen.cs:436
using System.IO;                                                                                                                            // MakerGen.cs:437
using System.Linq;                                                                                                                          // MakerGen.cs:438
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:439
                                                                                                                                            // MakerGen.cs:440
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:441
{                                                                                                                                           // MakerGen.cs:442
    #region Json                                                                                                                            // MakerGen.cs:443
    #if NEVER                                                                                                                               // MakerGen.cs:444
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
    #endregion                                                                                                                              // MakerGen.cs:447
    /// <summary>
    /// Fhir resource 'Location'
    /// </summary>
    // 0. Location
    public class Resource_Location : FhirKhit.Maker.Common.Resource.Resource_DomainResource                                                 // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        // 12. Location.position
        public class Type_Position : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 13. Location.position.longitude
            public ElementDefinitionInfo Element_Longitude;                                                                                 // MakerGen.cs:219
            // 14. Location.position.latitude
            public ElementDefinitionInfo Element_Latitude;                                                                                  // MakerGen.cs:219
            // 15. Location.position.altitude
            public ElementDefinitionInfo Element_Altitude;                                                                                  // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "Location.position",                                                                                             // MakerGen.cs:395
                    ElementId = "Location.position"                                                                                         // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Longitude.Write(sDef);                                                                                              // MakerGen.cs:223
                Element_Latitude.Write(sDef);                                                                                               // MakerGen.cs:223
                Element_Altitude.Write(sDef);                                                                                               // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_Position()                                                                                                          // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 13. Location.position.longitude
                    this.Element_Longitude = new ElementDefinitionInfo                                                                      // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Longitude",                                                                                         // MakerGen.cs:238
                        Path= "Location.position.longitude",                                                                                // MakerGen.cs:239
                        Id = "Location.position.longitude",                                                                                 // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Decimal                                                           // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 14. Location.position.latitude
                    this.Element_Latitude = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Latitude",                                                                                          // MakerGen.cs:238
                        Path= "Location.position.latitude",                                                                                 // MakerGen.cs:239
                        Id = "Location.position.latitude",                                                                                  // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Decimal                                                           // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 15. Location.position.altitude
                    this.Element_Altitude = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Altitude",                                                                                          // MakerGen.cs:238
                        Path= "Location.position.altitude",                                                                                 // MakerGen.cs:239
                        Id = "Location.position.altitude",                                                                                  // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Decimal                                                           // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 18. Location.hoursOfOperation
        public class Type_HoursOfOperation : FhirKhit.Maker.Common.Complex.ComplexBase                                                      // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 19. Location.hoursOfOperation.daysOfWeek
            public ElementDefinitionInfo Element_DaysOfWeek;                                                                                // MakerGen.cs:219
            // 20. Location.hoursOfOperation.allDay
            public ElementDefinitionInfo Element_AllDay;                                                                                    // MakerGen.cs:219
            // 21. Location.hoursOfOperation.openingTime
            public ElementDefinitionInfo Element_OpeningTime;                                                                               // MakerGen.cs:219
            // 22. Location.hoursOfOperation.closingTime
            public ElementDefinitionInfo Element_ClosingTime;                                                                               // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "Location.hoursOfOperation",                                                                                     // MakerGen.cs:395
                    ElementId = "Location.hoursOfOperation"                                                                                 // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_DaysOfWeek.Write(sDef);                                                                                             // MakerGen.cs:223
                Element_AllDay.Write(sDef);                                                                                                 // MakerGen.cs:223
                Element_OpeningTime.Write(sDef);                                                                                            // MakerGen.cs:223
                Element_ClosingTime.Write(sDef);                                                                                            // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_HoursOfOperation()                                                                                                  // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 19. Location.hoursOfOperation.daysOfWeek
                    this.Element_DaysOfWeek = new ElementDefinitionInfo                                                                     // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_DaysOfWeek",                                                                                        // MakerGen.cs:238
                        Path= "Location.hoursOfOperation.daysOfWeek",                                                                       // MakerGen.cs:239
                        Id = "Location.hoursOfOperation.daysOfWeek",                                                                        // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                              // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 20. Location.hoursOfOperation.allDay
                    this.Element_AllDay = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_AllDay",                                                                                            // MakerGen.cs:238
                        Path= "Location.hoursOfOperation.allDay",                                                                           // MakerGen.cs:239
                        Id = "Location.hoursOfOperation.allDay",                                                                            // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                           // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 21. Location.hoursOfOperation.openingTime
                    this.Element_OpeningTime = new ElementDefinitionInfo                                                                    // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_OpeningTime",                                                                                       // MakerGen.cs:238
                        Path= "Location.hoursOfOperation.openingTime",                                                                      // MakerGen.cs:239
                        Id = "Location.hoursOfOperation.openingTime",                                                                       // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Time                                                              // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 22. Location.hoursOfOperation.closingTime
                    this.Element_ClosingTime = new ElementDefinitionInfo                                                                    // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_ClosingTime",                                                                                       // MakerGen.cs:238
                        Path= "Location.hoursOfOperation.closingTime",                                                                      // MakerGen.cs:239
                        Id = "Location.hoursOfOperation.closingTime",                                                                       // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Time                                                              // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 1. Location.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:219
        // 2. Location.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:219
        // 3. Location.operationalStatus
        public ElementDefinitionInfo Element_OperationalStatus;                                                                             // MakerGen.cs:219
        // 4. Location.name
        public ElementDefinitionInfo Element_Name;                                                                                          // MakerGen.cs:219
        // 5. Location.alias
        public ElementDefinitionInfo Element_Alias;                                                                                         // MakerGen.cs:219
        // 6. Location.description
        public ElementDefinitionInfo Element_Description;                                                                                   // MakerGen.cs:219
        // 7. Location.mode
        public ElementDefinitionInfo Element_Mode;                                                                                          // MakerGen.cs:219
        // 8. Location.type
        public ElementDefinitionInfo Element_Type;                                                                                          // MakerGen.cs:219
        // 9. Location.telecom
        public ElementDefinitionInfo Element_Telecom;                                                                                       // MakerGen.cs:219
        // 10. Location.address
        public ElementDefinitionInfo Element_Address;                                                                                       // MakerGen.cs:219
        // 11. Location.physicalType
        public ElementDefinitionInfo Element_PhysicalType;                                                                                  // MakerGen.cs:219
        // 12. Location.position
        public ElementDefinitionInfo Element_Position;                                                                                      // MakerGen.cs:219
        // 16. Location.managingOrganization
        public ElementDefinitionInfo Element_ManagingOrganization;                                                                          // MakerGen.cs:219
        // 17. Location.partOf
        public ElementDefinitionInfo Element_PartOf;                                                                                        // MakerGen.cs:219
        // 18. Location.hoursOfOperation
        public ElementDefinitionInfo Element_HoursOfOperation;                                                                              // MakerGen.cs:219
        // 23. Location.availabilityExceptions
        public ElementDefinitionInfo Element_AvailabilityExceptions;                                                                        // MakerGen.cs:219
        // 24. Location.endpoint
        public ElementDefinitionInfo Element_Endpoint;                                                                                      // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:390
        {                                                                                                                                   // MakerGen.cs:391
            base.Write(sDef);                                                                                                               // MakerGen.cs:392
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                Path = "Location",                                                                                                          // MakerGen.cs:395
                ElementId = "Location"                                                                                                      // MakerGen.cs:396
            });                                                                                                                             // MakerGen.cs:397
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:223
            Element_OperationalStatus.Write(sDef);                                                                                          // MakerGen.cs:223
            Element_Name.Write(sDef);                                                                                                       // MakerGen.cs:223
            Element_Alias.Write(sDef);                                                                                                      // MakerGen.cs:223
            Element_Description.Write(sDef);                                                                                                // MakerGen.cs:223
            Element_Mode.Write(sDef);                                                                                                       // MakerGen.cs:223
            Element_Type.Write(sDef);                                                                                                       // MakerGen.cs:223
            Element_Telecom.Write(sDef);                                                                                                    // MakerGen.cs:223
            Element_Address.Write(sDef);                                                                                                    // MakerGen.cs:223
            Element_PhysicalType.Write(sDef);                                                                                               // MakerGen.cs:223
            Element_Position.Write(sDef);                                                                                                   // MakerGen.cs:223
            Element_ManagingOrganization.Write(sDef);                                                                                       // MakerGen.cs:223
            Element_PartOf.Write(sDef);                                                                                                     // MakerGen.cs:223
            Element_HoursOfOperation.Write(sDef);                                                                                           // MakerGen.cs:223
            Element_AvailabilityExceptions.Write(sDef);                                                                                     // MakerGen.cs:223
            Element_Endpoint.Write(sDef);                                                                                                   // MakerGen.cs:223
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
        public Resource_Location()                                                                                                          // MakerGen.cs:402
        {                                                                                                                                   // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:234
                // 1. Location.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:238
                    Path= "Location.identifier",                                                                                            // MakerGen.cs:239
                    Id = "Location.identifier",                                                                                             // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 2. Location.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Status",                                                                                                // MakerGen.cs:238
                    Path= "Location.status",                                                                                                // MakerGen.cs:239
                    Id = "Location.status",                                                                                                 // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 3. Location.operationalStatus
                this.Element_OperationalStatus = new ElementDefinitionInfo                                                                  // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_OperationalStatus",                                                                                     // MakerGen.cs:238
                    Path= "Location.operationalStatus",                                                                                     // MakerGen.cs:239
                    Id = "Location.operationalStatus",                                                                                      // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Coding                                                                       // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 4. Location.name
                this.Element_Name = new ElementDefinitionInfo                                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Name",                                                                                                  // MakerGen.cs:238
                    Path= "Location.name",                                                                                                  // MakerGen.cs:239
                    Id = "Location.name",                                                                                                   // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 5. Location.alias
                this.Element_Alias = new ElementDefinitionInfo                                                                              // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Alias",                                                                                                 // MakerGen.cs:238
                    Path= "Location.alias",                                                                                                 // MakerGen.cs:239
                    Id = "Location.alias",                                                                                                  // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 6. Location.description
                this.Element_Description = new ElementDefinitionInfo                                                                        // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Description",                                                                                           // MakerGen.cs:238
                    Path= "Location.description",                                                                                           // MakerGen.cs:239
                    Id = "Location.description",                                                                                            // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 7. Location.mode
                this.Element_Mode = new ElementDefinitionInfo                                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Mode",                                                                                                  // MakerGen.cs:238
                    Path= "Location.mode",                                                                                                  // MakerGen.cs:239
                    Id = "Location.mode",                                                                                                   // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 8. Location.type
                this.Element_Type = new ElementDefinitionInfo                                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Type",                                                                                                  // MakerGen.cs:238
                    Path= "Location.type",                                                                                                  // MakerGen.cs:239
                    Id = "Location.type",                                                                                                   // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 9. Location.telecom
                this.Element_Telecom = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Telecom",                                                                                               // MakerGen.cs:238
                    Path= "Location.telecom",                                                                                               // MakerGen.cs:239
                    Id = "Location.telecom",                                                                                                // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_ContactPoint                                                                 // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 10. Location.address
                this.Element_Address = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Address",                                                                                               // MakerGen.cs:238
                    Path= "Location.address",                                                                                               // MakerGen.cs:239
                    Id = "Location.address",                                                                                                // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Address                                                                      // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 11. Location.physicalType
                this.Element_PhysicalType = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_PhysicalType",                                                                                          // MakerGen.cs:238
                    Path= "Location.physicalType",                                                                                          // MakerGen.cs:239
                    Id = "Location.physicalType",                                                                                           // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 12. Location.position
                this.Element_Position = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Position",                                                                                              // MakerGen.cs:238
                    Path= "Location.position",                                                                                              // MakerGen.cs:239
                    Id = "Location.position",                                                                                               // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_Position                                                                                                   // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 16. Location.managingOrganization
                this.Element_ManagingOrganization = new ElementDefinitionInfo                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_ManagingOrganization",                                                                                  // MakerGen.cs:238
                    Path= "Location.managingOrganization",                                                                                  // MakerGen.cs:239
                    Id = "Location.managingOrganization",                                                                                   // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Organization"                                                      // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 17. Location.partOf
                this.Element_PartOf = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_PartOf",                                                                                                // MakerGen.cs:238
                    Path= "Location.partOf",                                                                                                // MakerGen.cs:239
                    Id = "Location.partOf",                                                                                                 // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Location"                                                          // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 18. Location.hoursOfOperation
                this.Element_HoursOfOperation = new ElementDefinitionInfo                                                                   // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_HoursOfOperation",                                                                                      // MakerGen.cs:238
                    Path= "Location.hoursOfOperation",                                                                                      // MakerGen.cs:239
                    Id = "Location.hoursOfOperation",                                                                                       // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_HoursOfOperation                                                                                           // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 23. Location.availabilityExceptions
                this.Element_AvailabilityExceptions = new ElementDefinitionInfo                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_AvailabilityExceptions",                                                                                // MakerGen.cs:238
                    Path= "Location.availabilityExceptions",                                                                                // MakerGen.cs:239
                    Id = "Location.availabilityExceptions",                                                                                 // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 24. Location.endpoint
                this.Element_Endpoint = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Endpoint",                                                                                              // MakerGen.cs:238
                    Path= "Location.endpoint",                                                                                              // MakerGen.cs:239
                    Id = "Location.endpoint",                                                                                               // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Endpoint"                                                          // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            this.Name = "Location";                                                                                                         // MakerGen.cs:471
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Location";                                                                  // MakerGen.cs:472
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:407
}                                                                                                                                           // MakerGen.cs:452
