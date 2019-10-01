using System;                                                                                                                               // MakerGen.cs:462
using System.Diagnostics;                                                                                                                   // MakerGen.cs:463
using System.IO;                                                                                                                            // MakerGen.cs:464
using System.Linq;                                                                                                                          // MakerGen.cs:465
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:466
                                                                                                                                            // MakerGen.cs:467
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:468
{                                                                                                                                           // MakerGen.cs:469
    #region Json                                                                                                                            // MakerGen.cs:470
    #if NEVER                                                                                                                               // MakerGen.cs:471
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
    #endregion                                                                                                                              // MakerGen.cs:474
    /// <summary>
    /// Fhir resource 'Location'
    /// </summary>
    // 0. Location
    public class Location : FhirKhit.Maker.Common.Resource.ResourceBase                                                                     // MakerGen.cs:384
    {                                                                                                                                       // MakerGen.cs:385
        public class Location_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                        // MakerGen.cs:386
        {                                                                                                                                   // MakerGen.cs:387
            // 12. Location.position
            public class Type_Position : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_Position_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                           // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 13. Location.position.longitude
                    public ElementDefinitionInfo Longitude;                                                                                 // MakerGen.cs:216
                    // 14. Location.position.latitude
                    public ElementDefinitionInfo Latitude;                                                                                  // MakerGen.cs:216
                    // 15. Location.position.altitude
                    public ElementDefinitionInfo Altitude;                                                                                  // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_Position_Elements()                                                                                         // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 13. Location.position.longitude
                            this.Longitude = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Longitude",                                                                                         // MakerGen.cs:235
                                Path= "Location.position.longitude",                                                                        // MakerGen.cs:236
                                Id = "Location.position.longitude",                                                                         // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Decimal                                                             // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 14. Location.position.latitude
                            this.Latitude = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Latitude",                                                                                          // MakerGen.cs:235
                                Path= "Location.position.latitude",                                                                         // MakerGen.cs:236
                                Id = "Location.position.latitude",                                                                          // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Decimal                                                             // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 15. Location.position.altitude
                            this.Altitude = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Altitude",                                                                                          // MakerGen.cs:235
                                Path= "Location.position.altitude",                                                                         // MakerGen.cs:236
                                Id = "Location.position.altitude",                                                                          // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Decimal                                                             // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:398
                    {                                                                                                                       // MakerGen.cs:399
                        base.Write(sDef);                                                                                                   // MakerGen.cs:400
                        Longitude.Write(sDef);                                                                                              // MakerGen.cs:220
                        Latitude.Write(sDef);                                                                                               // MakerGen.cs:220
                        Altitude.Write(sDef);                                                                                               // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_Position_Elements Elements                                                                                      // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_Position_Elements();                                                                   // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_Position_Elements elements;                                                                                            // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_Position()                                                                                                      // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "Location.position",                                                                                         // MakerGen.cs:428
                        ElementId = "Location.position"                                                                                     // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 18. Location.hoursOfOperation
            public class Type_HoursOfOperation : FhirKhit.Maker.Common.Complex.ComplexBase                                                  // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_HoursOfOperation_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                   // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 19. Location.hoursOfOperation.daysOfWeek
                    public ElementDefinitionInfo DaysOfWeek;                                                                                // MakerGen.cs:216
                    // 20. Location.hoursOfOperation.allDay
                    public ElementDefinitionInfo AllDay;                                                                                    // MakerGen.cs:216
                    // 21. Location.hoursOfOperation.openingTime
                    public ElementDefinitionInfo OpeningTime;                                                                               // MakerGen.cs:216
                    // 22. Location.hoursOfOperation.closingTime
                    public ElementDefinitionInfo ClosingTime;                                                                               // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_HoursOfOperation_Elements()                                                                                 // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 19. Location.hoursOfOperation.daysOfWeek
                            this.DaysOfWeek = new ElementDefinitionInfo                                                                     // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "DaysOfWeek",                                                                                        // MakerGen.cs:235
                                Path= "Location.hoursOfOperation.daysOfWeek",                                                               // MakerGen.cs:236
                                Id = "Location.hoursOfOperation.daysOfWeek",                                                                // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 20. Location.hoursOfOperation.allDay
                            this.AllDay = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "AllDay",                                                                                            // MakerGen.cs:235
                                Path= "Location.hoursOfOperation.allDay",                                                                   // MakerGen.cs:236
                                Id = "Location.hoursOfOperation.allDay",                                                                    // MakerGen.cs:237
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
                            // 21. Location.hoursOfOperation.openingTime
                            this.OpeningTime = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "OpeningTime",                                                                                       // MakerGen.cs:235
                                Path= "Location.hoursOfOperation.openingTime",                                                              // MakerGen.cs:236
                                Id = "Location.hoursOfOperation.openingTime",                                                               // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Time                                                                // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 22. Location.hoursOfOperation.closingTime
                            this.ClosingTime = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "ClosingTime",                                                                                       // MakerGen.cs:235
                                Path= "Location.hoursOfOperation.closingTime",                                                              // MakerGen.cs:236
                                Id = "Location.hoursOfOperation.closingTime",                                                               // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Time                                                                // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:398
                    {                                                                                                                       // MakerGen.cs:399
                        base.Write(sDef);                                                                                                   // MakerGen.cs:400
                        DaysOfWeek.Write(sDef);                                                                                             // MakerGen.cs:220
                        AllDay.Write(sDef);                                                                                                 // MakerGen.cs:220
                        OpeningTime.Write(sDef);                                                                                            // MakerGen.cs:220
                        ClosingTime.Write(sDef);                                                                                            // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_HoursOfOperation_Elements Elements                                                                              // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_HoursOfOperation_Elements();                                                           // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_HoursOfOperation_Elements elements;                                                                                    // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_HoursOfOperation()                                                                                              // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "Location.hoursOfOperation",                                                                                 // MakerGen.cs:428
                        ElementId = "Location.hoursOfOperation"                                                                             // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 1. Location.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:216
            // 2. Location.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:216
            // 3. Location.operationalStatus
            public ElementDefinitionInfo OperationalStatus;                                                                                 // MakerGen.cs:216
            // 4. Location.name
            public ElementDefinitionInfo Name;                                                                                              // MakerGen.cs:216
            // 5. Location.alias
            public ElementDefinitionInfo Alias;                                                                                             // MakerGen.cs:216
            // 6. Location.description
            public ElementDefinitionInfo Description;                                                                                       // MakerGen.cs:216
            // 7. Location.mode
            public ElementDefinitionInfo Mode;                                                                                              // MakerGen.cs:216
            // 8. Location.type
            public ElementDefinitionInfo Type;                                                                                              // MakerGen.cs:216
            // 9. Location.telecom
            public ElementDefinitionInfo Telecom;                                                                                           // MakerGen.cs:216
            // 10. Location.address
            public ElementDefinitionInfo Address;                                                                                           // MakerGen.cs:216
            // 11. Location.physicalType
            public ElementDefinitionInfo PhysicalType;                                                                                      // MakerGen.cs:216
            // 12. Location.position
            public ElementDefinitionInfo Position;                                                                                          // MakerGen.cs:216
            // 16. Location.managingOrganization
            public ElementDefinitionInfo ManagingOrganization;                                                                              // MakerGen.cs:216
            // 17. Location.partOf
            public ElementDefinitionInfo PartOf;                                                                                            // MakerGen.cs:216
            // 18. Location.hoursOfOperation
            public ElementDefinitionInfo HoursOfOperation;                                                                                  // MakerGen.cs:216
            // 23. Location.availabilityExceptions
            public ElementDefinitionInfo AvailabilityExceptions;                                                                            // MakerGen.cs:216
            // 24. Location.endpoint
            public ElementDefinitionInfo Endpoint;                                                                                          // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
            public Location_Elements()                                                                                                      // MakerGen.cs:392
            {                                                                                                                               // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:231
                    // 1. Location.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Identifier",                                                                                                // MakerGen.cs:235
                        Path= "Location.identifier",                                                                                        // MakerGen.cs:236
                        Id = "Location.identifier",                                                                                         // MakerGen.cs:237
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
                    // 2. Location.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Status",                                                                                                    // MakerGen.cs:235
                        Path= "Location.status",                                                                                            // MakerGen.cs:236
                        Id = "Location.status",                                                                                             // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 3. Location.operationalStatus
                    this.OperationalStatus = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "OperationalStatus",                                                                                         // MakerGen.cs:235
                        Path= "Location.operationalStatus",                                                                                 // MakerGen.cs:236
                        Id = "Location.operationalStatus",                                                                                  // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Coding                                                                        // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 4. Location.name
                    this.Name = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Name",                                                                                                      // MakerGen.cs:235
                        Path= "Location.name",                                                                                              // MakerGen.cs:236
                        Id = "Location.name",                                                                                               // MakerGen.cs:237
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
                    // 5. Location.alias
                    this.Alias = new ElementDefinitionInfo                                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Alias",                                                                                                     // MakerGen.cs:235
                        Path= "Location.alias",                                                                                             // MakerGen.cs:236
                        Id = "Location.alias",                                                                                              // MakerGen.cs:237
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
                    // 6. Location.description
                    this.Description = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Description",                                                                                               // MakerGen.cs:235
                        Path= "Location.description",                                                                                       // MakerGen.cs:236
                        Id = "Location.description",                                                                                        // MakerGen.cs:237
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
                    // 7. Location.mode
                    this.Mode = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Mode",                                                                                                      // MakerGen.cs:235
                        Path= "Location.mode",                                                                                              // MakerGen.cs:236
                        Id = "Location.mode",                                                                                               // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 8. Location.type
                    this.Type = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Type",                                                                                                      // MakerGen.cs:235
                        Path= "Location.type",                                                                                              // MakerGen.cs:236
                        Id = "Location.type",                                                                                               // MakerGen.cs:237
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
                    // 9. Location.telecom
                    this.Telecom = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Telecom",                                                                                                   // MakerGen.cs:235
                        Path= "Location.telecom",                                                                                           // MakerGen.cs:236
                        Id = "Location.telecom",                                                                                            // MakerGen.cs:237
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
                    // 10. Location.address
                    this.Address = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Address",                                                                                                   // MakerGen.cs:235
                        Path= "Location.address",                                                                                           // MakerGen.cs:236
                        Id = "Location.address",                                                                                            // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Address                                                                       // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 11. Location.physicalType
                    this.PhysicalType = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "PhysicalType",                                                                                              // MakerGen.cs:235
                        Path= "Location.physicalType",                                                                                      // MakerGen.cs:236
                        Id = "Location.physicalType",                                                                                       // MakerGen.cs:237
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
                    // 12. Location.position
                    this.Position = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Position",                                                                                                  // MakerGen.cs:235
                        Path= "Location.position",                                                                                          // MakerGen.cs:236
                        Id = "Location.position",                                                                                           // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Position                                                                                               // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 16. Location.managingOrganization
                    this.ManagingOrganization = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ManagingOrganization",                                                                                      // MakerGen.cs:235
                        Path= "Location.managingOrganization",                                                                              // MakerGen.cs:236
                        Id = "Location.managingOrganization",                                                                               // MakerGen.cs:237
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
                    // 17. Location.partOf
                    this.PartOf = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "PartOf",                                                                                                    // MakerGen.cs:235
                        Path= "Location.partOf",                                                                                            // MakerGen.cs:236
                        Id = "Location.partOf",                                                                                             // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Location"                                                      // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 18. Location.hoursOfOperation
                    this.HoursOfOperation = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "HoursOfOperation",                                                                                          // MakerGen.cs:235
                        Path= "Location.hoursOfOperation",                                                                                  // MakerGen.cs:236
                        Id = "Location.hoursOfOperation",                                                                                   // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_HoursOfOperation                                                                                       // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 23. Location.availabilityExceptions
                    this.AvailabilityExceptions = new ElementDefinitionInfo                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "AvailabilityExceptions",                                                                                    // MakerGen.cs:235
                        Path= "Location.availabilityExceptions",                                                                            // MakerGen.cs:236
                        Id = "Location.availabilityExceptions",                                                                             // MakerGen.cs:237
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
                    // 24. Location.endpoint
                    this.Endpoint = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Endpoint",                                                                                                  // MakerGen.cs:235
                        Path= "Location.endpoint",                                                                                          // MakerGen.cs:236
                        Id = "Location.endpoint",                                                                                           // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Endpoint"                                                      // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:398
            {                                                                                                                               // MakerGen.cs:399
                base.Write(sDef);                                                                                                           // MakerGen.cs:400
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:220
                Status.Write(sDef);                                                                                                         // MakerGen.cs:220
                OperationalStatus.Write(sDef);                                                                                              // MakerGen.cs:220
                Name.Write(sDef);                                                                                                           // MakerGen.cs:220
                Alias.Write(sDef);                                                                                                          // MakerGen.cs:220
                Description.Write(sDef);                                                                                                    // MakerGen.cs:220
                Mode.Write(sDef);                                                                                                           // MakerGen.cs:220
                Type.Write(sDef);                                                                                                           // MakerGen.cs:220
                Telecom.Write(sDef);                                                                                                        // MakerGen.cs:220
                Address.Write(sDef);                                                                                                        // MakerGen.cs:220
                PhysicalType.Write(sDef);                                                                                                   // MakerGen.cs:220
                Position.Write(sDef);                                                                                                       // MakerGen.cs:220
                ManagingOrganization.Write(sDef);                                                                                           // MakerGen.cs:220
                PartOf.Write(sDef);                                                                                                         // MakerGen.cs:220
                HoursOfOperation.Write(sDef);                                                                                               // MakerGen.cs:220
                AvailabilityExceptions.Write(sDef);                                                                                         // MakerGen.cs:220
                Endpoint.Write(sDef);                                                                                                       // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:402
        }                                                                                                                                   // MakerGen.cs:404
        public Location_Elements Elements                                                                                                   // MakerGen.cs:406
        {                                                                                                                                   // MakerGen.cs:407
            get                                                                                                                             // MakerGen.cs:408
            {                                                                                                                               // MakerGen.cs:409
                if (this.elements == null)                                                                                                  // MakerGen.cs:410
                    this.elements = new Location_Elements();                                                                                // MakerGen.cs:411
                return this.elements;                                                                                                       // MakerGen.cs:412
            }                                                                                                                               // MakerGen.cs:413
        }                                                                                                                                   // MakerGen.cs:414
        Location_Elements elements;                                                                                                         // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
        public Location()                                                                                                                   // MakerGen.cs:418
        {                                                                                                                                   // MakerGen.cs:419
            this.Name = "Location";                                                                                                         // MakerGen.cs:492
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Location";                                                                  // MakerGen.cs:493
        }                                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:424
        {                                                                                                                                   // MakerGen.cs:425
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:426
            {                                                                                                                               // MakerGen.cs:427
                Path = "Location",                                                                                                          // MakerGen.cs:428
                ElementId = "Location"                                                                                                      // MakerGen.cs:429
            });                                                                                                                             // MakerGen.cs:430
            if (this.elements != null)                                                                                                      // MakerGen.cs:431
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:432
        }                                                                                                                                   // MakerGen.cs:433
    }                                                                                                                                       // MakerGen.cs:434
}                                                                                                                                           // MakerGen.cs:479
