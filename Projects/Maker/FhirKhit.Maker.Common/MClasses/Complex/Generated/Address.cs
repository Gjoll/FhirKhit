using System;                                                                                                                               // MakerGen.cs:497
using System.Diagnostics;                                                                                                                   // MakerGen.cs:498
using System.IO;                                                                                                                            // MakerGen.cs:499
using System.Linq;                                                                                                                          // MakerGen.cs:500
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:501
                                                                                                                                            // MakerGen.cs:502
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:503
{                                                                                                                                           // MakerGen.cs:504
    #region Json                                                                                                                            // MakerGen.cs:505
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
    #endregion                                                                                                                              // MakerGen.cs:509
    /// <summary>
    /// Fhir complex 'Address'
    /// </summary>
    // 0. Address
    public class Address : FhirKhit.Maker.Common.Complex.ComplexBase                                                                        // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        public class Address_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                         // MakerGen.cs:385
        {                                                                                                                                   // MakerGen.cs:386
            // 1. Address.use
            public ElementDefinitionInfo Use;                                                                                               // MakerGen.cs:216
            // 2. Address.type
            public ElementDefinitionInfo Type;                                                                                              // MakerGen.cs:216
            // 3. Address.text
            public ElementDefinitionInfo Text;                                                                                              // MakerGen.cs:216
            // 4. Address.line
            public ElementDefinitionInfo Line;                                                                                              // MakerGen.cs:216
            // 5. Address.city
            public ElementDefinitionInfo City;                                                                                              // MakerGen.cs:216
            // 6. Address.district
            public ElementDefinitionInfo District;                                                                                          // MakerGen.cs:216
            // 7. Address.state
            public ElementDefinitionInfo State;                                                                                             // MakerGen.cs:216
            // 8. Address.postalCode
            public ElementDefinitionInfo PostalCode;                                                                                        // MakerGen.cs:216
            // 9. Address.country
            public ElementDefinitionInfo Country;                                                                                           // MakerGen.cs:216
            // 10. Address.period
            public ElementDefinitionInfo Period;                                                                                            // MakerGen.cs:216
            public Address_Elements()                                                                                                       // MakerGen.cs:407
            {                                                                                                                               // MakerGen.cs:408
                {                                                                                                                           // MakerGen.cs:231
                    // 1. Address.use
                    this.Use = new ElementDefinitionInfo                                                                                    // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Use",                                                                                                       // MakerGen.cs:235
                        Path= "Address.use",                                                                                                // MakerGen.cs:236
                        Id = "Address.use",                                                                                                 // MakerGen.cs:237
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
                    // 2. Address.type
                    this.Type = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Type",                                                                                                      // MakerGen.cs:235
                        Path= "Address.type",                                                                                               // MakerGen.cs:236
                        Id = "Address.type",                                                                                                // MakerGen.cs:237
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
                    // 3. Address.text
                    this.Text = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Text",                                                                                                      // MakerGen.cs:235
                        Path= "Address.text",                                                                                               // MakerGen.cs:236
                        Id = "Address.text",                                                                                                // MakerGen.cs:237
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
                    // 4. Address.line
                    this.Line = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Line",                                                                                                      // MakerGen.cs:235
                        Path= "Address.line",                                                                                               // MakerGen.cs:236
                        Id = "Address.line",                                                                                                // MakerGen.cs:237
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
                    // 5. Address.city
                    this.City = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "City",                                                                                                      // MakerGen.cs:235
                        Path= "Address.city",                                                                                               // MakerGen.cs:236
                        Id = "Address.city",                                                                                                // MakerGen.cs:237
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
                    // 6. Address.district
                    this.District = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "District",                                                                                                  // MakerGen.cs:235
                        Path= "Address.district",                                                                                           // MakerGen.cs:236
                        Id = "Address.district",                                                                                            // MakerGen.cs:237
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
                    // 7. Address.state
                    this.State = new ElementDefinitionInfo                                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "State",                                                                                                     // MakerGen.cs:235
                        Path= "Address.state",                                                                                              // MakerGen.cs:236
                        Id = "Address.state",                                                                                               // MakerGen.cs:237
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
                    // 8. Address.postalCode
                    this.PostalCode = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "PostalCode",                                                                                                // MakerGen.cs:235
                        Path= "Address.postalCode",                                                                                         // MakerGen.cs:236
                        Id = "Address.postalCode",                                                                                          // MakerGen.cs:237
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
                    // 9. Address.country
                    this.Country = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Country",                                                                                                   // MakerGen.cs:235
                        Path= "Address.country",                                                                                            // MakerGen.cs:236
                        Id = "Address.country",                                                                                             // MakerGen.cs:237
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
                    // 10. Address.period
                    this.Period = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Period",                                                                                                    // MakerGen.cs:235
                        Path= "Address.period",                                                                                             // MakerGen.cs:236
                        Id = "Address.period",                                                                                              // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:427
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:412
            {                                                                                                                               // MakerGen.cs:413
                base.Write(sDef);                                                                                                           // MakerGen.cs:414
                Use.Write(sDef);                                                                                                            // MakerGen.cs:220
                Type.Write(sDef);                                                                                                           // MakerGen.cs:220
                Text.Write(sDef);                                                                                                           // MakerGen.cs:220
                Line.Write(sDef);                                                                                                           // MakerGen.cs:220
                City.Write(sDef);                                                                                                           // MakerGen.cs:220
                District.Write(sDef);                                                                                                       // MakerGen.cs:220
                State.Write(sDef);                                                                                                          // MakerGen.cs:220
                PostalCode.Write(sDef);                                                                                                     // MakerGen.cs:220
                Country.Write(sDef);                                                                                                        // MakerGen.cs:220
                Period.Write(sDef);                                                                                                         // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:431
        }                                                                                                                                   // MakerGen.cs:391
        public Address_Elements Elements { get; }                                                                                           // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
        public Address()                                                                                                                    // MakerGen.cs:394
        {                                                                                                                                   // MakerGen.cs:395
            this.Elements = new Address_Elements();                                                                                         // MakerGen.cs:396
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:399
        {                                                                                                                                   // MakerGen.cs:400
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:401
        }                                                                                                                                   // MakerGen.cs:402
    }                                                                                                                                       // MakerGen.cs:403
}                                                                                                                                           // MakerGen.cs:514
