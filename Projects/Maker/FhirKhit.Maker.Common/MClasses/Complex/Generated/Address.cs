using System;                                                                                                                               // MakerGen.cs:499
using System.Diagnostics;                                                                                                                   // MakerGen.cs:500
using System.IO;                                                                                                                            // MakerGen.cs:501
using System.Linq;                                                                                                                          // MakerGen.cs:502
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:503
                                                                                                                                            // MakerGen.cs:504
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:505
{                                                                                                                                           // MakerGen.cs:506
    #region Json                                                                                                                            // MakerGen.cs:507
    #if NEVER
    {
      "resourceType": "StructureDefinition",
      "id": "Address",
      "url": "http://hl7.org/fhir/StructureDefinition/Address",
      "version": "4.0.0",
      "name": "Address",
      "status": "active",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for Address Type: An address expressed using postal conventions (as opposed to GPS or other location definition formats).  This data type may be used to convey addresses for use in delivering mail as well as for visiting locations which might not be valid for mail delivery.  There are a variety of postal address formats defined around the world.",
      "purpose": "Need to be able to record postal addresses, along with notes about their use.",
      "fhirVersion": "4.0.0",
      "kind": "complex-type",
      "abstract": false,
      "type": "Address",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Address",
            "path": "Address",
            "short": "An address expressed using postal conventions (as opposed to GPS or other location definition formats)",
            "definition": "An address expressed using postal conventions (as opposed to GPS or other location definition formats).  This data type may be used to convey addresses for use in delivering mail as well as for visiting locations which might not be valid for mail delivery.  There are a variety of postal address formats defined around the world.",
            "comment": "Note: address is intended to describe postal addresses for administrative purposes, not to describe absolute geographical coordinates.  Postal addresses are often used as proxies for physical locations (also see the [Location](location.html#) resource).",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Address.use",
            "path": "Address.use",
            "short": "home | work | temp | old | billing - purpose of this address",
            "definition": "The purpose of this address.",
            "comment": "Applications can assume that an address is current unless it explicitly says that it is temporary or old.",
            "requirements": "Allows an appropriate address to be chosen from a list of many.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "example": [
              {
                "label": "General",
                "valueCode": "home"
              }
            ],
            "isModifier": true,
            "isModifierReason": "This is labeled as \"Is Modifier\" because applications should not mistake a temporary or old address etc.for a current/permanent one",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "AddressUse"
                }
              ],
              "strength": "required",
              "description": "The use of an address.",
              "valueSet": "http://hl7.org/fhir/ValueSet/address-use|4.0.0"
            }
          },
          {
            "id": "Address.type",
            "path": "Address.type",
            "short": "postal | physical | both",
            "definition": "Distinguishes between physical addresses (those you can visit) and mailing addresses (e.g. PO Boxes and care-of addresses). Most addresses are both.",
            "comment": "The definition of Address states that \"address is intended to describe postal addresses, not physical locations\". However, many applications track whether an address has a dual purpose of being a location that can be visited as well as being a valid delivery destination, and Postal addresses are often used as proxies for physical locations (also see the [Location](location.html#) resource).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "example": [
              {
                "label": "General",
                "valueCode": "both"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "AddressType"
                }
              ],
              "strength": "required",
              "description": "The type of an address (physical / postal).",
              "valueSet": "http://hl7.org/fhir/ValueSet/address-type|4.0.0"
            }
          },
          {
            "id": "Address.text",
            "path": "Address.text",
            "short": "Text representation of the address",
            "definition": "Specifies the entire address as it should be displayed e.g. on a postal label. This may be provided instead of or as well as the specific parts.",
            "comment": "Can provide both a text representation and parts. Applications updating an address SHALL ensure that  when both text and parts are present,  no content is included in the text that isn't found in a part.",
            "requirements": "A renderable, unencoded form.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "example": [
              {
                "label": "General",
                "valueString": "137 Nowhere Street, Erewhon 9132"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Address.line",
            "path": "Address.line",
            "short": "Street name, number, direction & P.O. Box etc.",
            "definition": "This component contains the house number, apartment number, street name, street direction,  P.O. Box number, delivery hints, and similar address information.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "string"
              }
            ],
            "orderMeaning": "The order in which lines should appear in an address label",
            "example": [
              {
                "label": "General",
                "valueString": "137 Nowhere Street"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Address.city",
            "path": "Address.city",
            "short": "Name of city, town etc.",
            "definition": "The name of the city, town, suburb, village or other community or delivery center.",
            "alias": [
              "Municpality"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "example": [
              {
                "label": "General",
                "valueString": "Erewhon"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Address.district",
            "path": "Address.district",
            "short": "District name (aka county)",
            "definition": "The name of the administrative area (county).",
            "comment": "District is sometimes known as county, but in some regions 'county' is used in place of city (municipality), so county name should be conveyed in city instead.",
            "alias": [
              "County"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "example": [
              {
                "label": "General",
                "valueString": "Madison"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Address.state",
            "path": "Address.state",
            "short": "Sub-unit of country (abbreviations ok)",
            "definition": "Sub-unit of a country with limited sovereignty in a federally organized country. A code may be used if codes are in common use (e.g. US 2 letter state codes).",
            "alias": [
              "Province",
              "Territory"
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
            "id": "Address.postalCode",
            "path": "Address.postalCode",
            "short": "Postal code for area",
            "definition": "A postal code designating a region defined by the postal service.",
            "alias": [
              "Zip"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "example": [
              {
                "label": "General",
                "valueString": "9132"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Address.country",
            "path": "Address.country",
            "short": "Country (e.g. can be ISO 3166 2 or 3 letter code)",
            "definition": "Country - a nation as commonly understood or generally accepted.",
            "comment": "ISO 3166 3 letter codes can be used in place of a human readable country name.",
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
            "id": "Address.period",
            "path": "Address.period",
            "short": "Time period when address was/is in use",
            "definition": "Time period when address was/is in use.",
            "requirements": "Allows addresses to be placed in historical context.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Period"
              }
            ],
            "example": [
              {
                "label": "General",
                "valuePeriod": {
                  "start": "2010-03-23",
                  "end": "2010-07-01"
                }
              }
            ],
            "isSummary": true
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:511
    /// <summary>
    /// Fhir complex 'Address'
    /// </summary>
    // 0. Address
    public class Address : FhirKhit.Maker.Common.Complex.ComplexBase                                                                        // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class Address_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                         // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 1. Address.use
            public ElementDefinitionInfo Use;                                                                                               // MakerGen.cs:236
            // 2. Address.type
            public ElementDefinitionInfo Type;                                                                                              // MakerGen.cs:236
            // 3. Address.text
            public ElementDefinitionInfo Text;                                                                                              // MakerGen.cs:236
            // 4. Address.line
            public ElementDefinitionInfo Line;                                                                                              // MakerGen.cs:236
            // 5. Address.city
            public ElementDefinitionInfo City;                                                                                              // MakerGen.cs:236
            // 6. Address.district
            public ElementDefinitionInfo District;                                                                                          // MakerGen.cs:236
            // 7. Address.state
            public ElementDefinitionInfo State;                                                                                             // MakerGen.cs:236
            // 8. Address.postalCode
            public ElementDefinitionInfo PostalCode;                                                                                        // MakerGen.cs:236
            // 9. Address.country
            public ElementDefinitionInfo Country;                                                                                           // MakerGen.cs:236
            // 10. Address.period
            public ElementDefinitionInfo Period;                                                                                            // MakerGen.cs:236
            public Address_Elements()                                                                                                       // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:251
                    // 1. Address.use
                    this.Use = new ElementDefinitionInfo                                                                                    // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Use",                                                                                                       // MakerGen.cs:255
                        Path= "Address.use",                                                                                                // MakerGen.cs:256
                        Id = "Address.use",                                                                                                 // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 2. Address.type
                    this.Type = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Type",                                                                                                      // MakerGen.cs:255
                        Path= "Address.type",                                                                                               // MakerGen.cs:256
                        Id = "Address.type",                                                                                                // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 3. Address.text
                    this.Text = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Text",                                                                                                      // MakerGen.cs:255
                        Path= "Address.text",                                                                                               // MakerGen.cs:256
                        Id = "Address.text",                                                                                                // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 4. Address.line
                    this.Line = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Line",                                                                                                      // MakerGen.cs:255
                        Path= "Address.line",                                                                                               // MakerGen.cs:256
                        Id = "Address.line",                                                                                                // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 5. Address.city
                    this.City = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "City",                                                                                                      // MakerGen.cs:255
                        Path= "Address.city",                                                                                               // MakerGen.cs:256
                        Id = "Address.city",                                                                                                // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 6. Address.district
                    this.District = new ElementDefinitionInfo                                                                               // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "District",                                                                                                  // MakerGen.cs:255
                        Path= "Address.district",                                                                                           // MakerGen.cs:256
                        Id = "Address.district",                                                                                            // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 7. Address.state
                    this.State = new ElementDefinitionInfo                                                                                  // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "State",                                                                                                     // MakerGen.cs:255
                        Path= "Address.state",                                                                                              // MakerGen.cs:256
                        Id = "Address.state",                                                                                               // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 8. Address.postalCode
                    this.PostalCode = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "PostalCode",                                                                                                // MakerGen.cs:255
                        Path= "Address.postalCode",                                                                                         // MakerGen.cs:256
                        Id = "Address.postalCode",                                                                                          // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 9. Address.country
                    this.Country = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Country",                                                                                                   // MakerGen.cs:255
                        Path= "Address.country",                                                                                            // MakerGen.cs:256
                        Id = "Address.country",                                                                                             // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 10. Address.period
                    this.Period = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Period",                                                                                                    // MakerGen.cs:255
                        Path= "Address.period",                                                                                             // MakerGen.cs:256
                        Id = "Address.period",                                                                                              // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:429
            public void override Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:414
            {                                                                                                                               // MakerGen.cs:415
                base.Write(sDef);                                                                                                           // MakerGen.cs:416
                Use.Write(sDef);                                                                                                            // MakerGen.cs:240
                Type.Write(sDef);                                                                                                           // MakerGen.cs:240
                Text.Write(sDef);                                                                                                           // MakerGen.cs:240
                Line.Write(sDef);                                                                                                           // MakerGen.cs:240
                City.Write(sDef);                                                                                                           // MakerGen.cs:240
                District.Write(sDef);                                                                                                       // MakerGen.cs:240
                State.Write(sDef);                                                                                                          // MakerGen.cs:240
                PostalCode.Write(sDef);                                                                                                     // MakerGen.cs:240
                Country.Write(sDef);                                                                                                        // MakerGen.cs:240
                Period.Write(sDef);                                                                                                         // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public Address_Elements Elements { get; }                                                                                           // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public Address()                                                                                                                    // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new Address_Elements();                                                                                         // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:516
