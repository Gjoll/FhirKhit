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
    #endregion
    /// <summary>
    /// Fhir resource 'Location'
    /// </summary>
    // 0. Location
    public class Resource_Location : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 12. Location.position
        public class Type_Position : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 13. Location.position.longitude
            public ElementDefinitionInfo Element_Longitude;
            // 14. Location.position.latitude
            public ElementDefinitionInfo Element_Latitude;
            // 15. Location.position.altitude
            public ElementDefinitionInfo Element_Altitude;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Location.position",
                    ElementId = "Location.position"
                });
                Element_Longitude.Write(sDef);
                Element_Latitude.Write(sDef);
                Element_Altitude.Write(sDef);
            }
            
            public Type_Position()
            {
                {
                    // 13. Location.position.longitude
                    this.Element_Longitude = new ElementDefinitionInfo
                    {
                        Name = "Element_Longitude",
                        Path= "Location.position.longitude",
                        Id = "Location.position.longitude",
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
                    // 14. Location.position.latitude
                    this.Element_Latitude = new ElementDefinitionInfo
                    {
                        Name = "Element_Latitude",
                        Path= "Location.position.latitude",
                        Id = "Location.position.latitude",
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
                    // 15. Location.position.altitude
                    this.Element_Altitude = new ElementDefinitionInfo
                    {
                        Name = "Element_Altitude",
                        Path= "Location.position.altitude",
                        Id = "Location.position.altitude",
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
            }
        }
        // 18. Location.hoursOfOperation
        public class Type_HoursOfOperation : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 19. Location.hoursOfOperation.daysOfWeek
            public ElementDefinitionInfo Element_DaysOfWeek;
            // 20. Location.hoursOfOperation.allDay
            public ElementDefinitionInfo Element_AllDay;
            // 21. Location.hoursOfOperation.openingTime
            public ElementDefinitionInfo Element_OpeningTime;
            // 22. Location.hoursOfOperation.closingTime
            public ElementDefinitionInfo Element_ClosingTime;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Location.hoursOfOperation",
                    ElementId = "Location.hoursOfOperation"
                });
                Element_DaysOfWeek.Write(sDef);
                Element_AllDay.Write(sDef);
                Element_OpeningTime.Write(sDef);
                Element_ClosingTime.Write(sDef);
            }
            
            public Type_HoursOfOperation()
            {
                {
                    // 19. Location.hoursOfOperation.daysOfWeek
                    this.Element_DaysOfWeek = new ElementDefinitionInfo
                    {
                        Name = "Element_DaysOfWeek",
                        Path= "Location.hoursOfOperation.daysOfWeek",
                        Id = "Location.hoursOfOperation.daysOfWeek",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Code
                            {
                            }
                        }
                    };
                }
                {
                    // 20. Location.hoursOfOperation.allDay
                    this.Element_AllDay = new ElementDefinitionInfo
                    {
                        Name = "Element_AllDay",
                        Path= "Location.hoursOfOperation.allDay",
                        Id = "Location.hoursOfOperation.allDay",
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
                    // 21. Location.hoursOfOperation.openingTime
                    this.Element_OpeningTime = new ElementDefinitionInfo
                    {
                        Name = "Element_OpeningTime",
                        Path= "Location.hoursOfOperation.openingTime",
                        Id = "Location.hoursOfOperation.openingTime",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Time
                            {
                            }
                        }
                    };
                }
                {
                    // 22. Location.hoursOfOperation.closingTime
                    this.Element_ClosingTime = new ElementDefinitionInfo
                    {
                        Name = "Element_ClosingTime",
                        Path= "Location.hoursOfOperation.closingTime",
                        Id = "Location.hoursOfOperation.closingTime",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Time
                            {
                            }
                        }
                    };
                }
            }
        }
        // 1. Location.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. Location.status
        public ElementDefinitionInfo Element_Status;
        // 3. Location.operationalStatus
        public ElementDefinitionInfo Element_OperationalStatus;
        // 4. Location.name
        public ElementDefinitionInfo Element_Name;
        // 5. Location.alias
        public ElementDefinitionInfo Element_Alias;
        // 6. Location.description
        public ElementDefinitionInfo Element_Description;
        // 7. Location.mode
        public ElementDefinitionInfo Element_Mode;
        // 8. Location.type
        public ElementDefinitionInfo Element_Type;
        // 9. Location.telecom
        public ElementDefinitionInfo Element_Telecom;
        // 10. Location.address
        public ElementDefinitionInfo Element_Address;
        // 11. Location.physicalType
        public ElementDefinitionInfo Element_PhysicalType;
        // 12. Location.position
        public ElementDefinitionInfo Element_Position;
        // 16. Location.managingOrganization
        public ElementDefinitionInfo Element_ManagingOrganization;
        // 17. Location.partOf
        public ElementDefinitionInfo Element_PartOf;
        // 18. Location.hoursOfOperation
        public ElementDefinitionInfo Element_HoursOfOperation;
        // 23. Location.availabilityExceptions
        public ElementDefinitionInfo Element_AvailabilityExceptions;
        // 24. Location.endpoint
        public ElementDefinitionInfo Element_Endpoint;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "Location",
                ElementId = "Location"
            });
            Element_Identifier.Write(sDef);
            Element_Status.Write(sDef);
            Element_OperationalStatus.Write(sDef);
            Element_Name.Write(sDef);
            Element_Alias.Write(sDef);
            Element_Description.Write(sDef);
            Element_Mode.Write(sDef);
            Element_Type.Write(sDef);
            Element_Telecom.Write(sDef);
            Element_Address.Write(sDef);
            Element_PhysicalType.Write(sDef);
            Element_Position.Write(sDef);
            Element_ManagingOrganization.Write(sDef);
            Element_PartOf.Write(sDef);
            Element_HoursOfOperation.Write(sDef);
            Element_AvailabilityExceptions.Write(sDef);
            Element_Endpoint.Write(sDef);
        }
        
        public Resource_Location()
        {
            {
                // 1. Location.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "Location.identifier",
                    Id = "Location.identifier",
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
                // 2. Location.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "Location.status",
                    Id = "Location.status",
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
                // 3. Location.operationalStatus
                this.Element_OperationalStatus = new ElementDefinitionInfo
                {
                    Name = "Element_OperationalStatus",
                    Path= "Location.operationalStatus",
                    Id = "Location.operationalStatus",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Coding
                        {
                        }
                    }
                };
            }
            {
                // 4. Location.name
                this.Element_Name = new ElementDefinitionInfo
                {
                    Name = "Element_Name",
                    Path= "Location.name",
                    Id = "Location.name",
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
                // 5. Location.alias
                this.Element_Alias = new ElementDefinitionInfo
                {
                    Name = "Element_Alias",
                    Path= "Location.alias",
                    Id = "Location.alias",
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
                // 6. Location.description
                this.Element_Description = new ElementDefinitionInfo
                {
                    Name = "Element_Description",
                    Path= "Location.description",
                    Id = "Location.description",
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
                // 7. Location.mode
                this.Element_Mode = new ElementDefinitionInfo
                {
                    Name = "Element_Mode",
                    Path= "Location.mode",
                    Id = "Location.mode",
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
                // 8. Location.type
                this.Element_Type = new ElementDefinitionInfo
                {
                    Name = "Element_Type",
                    Path= "Location.type",
                    Id = "Location.type",
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
                // 9. Location.telecom
                this.Element_Telecom = new ElementDefinitionInfo
                {
                    Name = "Element_Telecom",
                    Path= "Location.telecom",
                    Id = "Location.telecom",
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
                // 10. Location.address
                this.Element_Address = new ElementDefinitionInfo
                {
                    Name = "Element_Address",
                    Path= "Location.address",
                    Id = "Location.address",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Address
                        {
                        }
                    }
                };
            }
            {
                // 11. Location.physicalType
                this.Element_PhysicalType = new ElementDefinitionInfo
                {
                    Name = "Element_PhysicalType",
                    Path= "Location.physicalType",
                    Id = "Location.physicalType",
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
                // 12. Location.position
                this.Element_Position = new ElementDefinitionInfo
                {
                    Name = "Element_Position",
                    Path= "Location.position",
                    Id = "Location.position",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new Type_Position
                        {
                        }
                    }
                };
            }
            {
                // 16. Location.managingOrganization
                this.Element_ManagingOrganization = new ElementDefinitionInfo
                {
                    Name = "Element_ManagingOrganization",
                    Path= "Location.managingOrganization",
                    Id = "Location.managingOrganization",
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
                // 17. Location.partOf
                this.Element_PartOf = new ElementDefinitionInfo
                {
                    Name = "Element_PartOf",
                    Path= "Location.partOf",
                    Id = "Location.partOf",
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
                // 18. Location.hoursOfOperation
                this.Element_HoursOfOperation = new ElementDefinitionInfo
                {
                    Name = "Element_HoursOfOperation",
                    Path= "Location.hoursOfOperation",
                    Id = "Location.hoursOfOperation",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_HoursOfOperation
                        {
                        }
                    }
                };
            }
            {
                // 23. Location.availabilityExceptions
                this.Element_AvailabilityExceptions = new ElementDefinitionInfo
                {
                    Name = "Element_AvailabilityExceptions",
                    Path= "Location.availabilityExceptions",
                    Id = "Location.availabilityExceptions",
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
                // 24. Location.endpoint
                this.Element_Endpoint = new ElementDefinitionInfo
                {
                    Name = "Element_Endpoint",
                    Path= "Location.endpoint",
                    Id = "Location.endpoint",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Endpoint"
                            }
                        }
                    }
                };
            }
            this.Name = "Location";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Location";
        }
    }
}
