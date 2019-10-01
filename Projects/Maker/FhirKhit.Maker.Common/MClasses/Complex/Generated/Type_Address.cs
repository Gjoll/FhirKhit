using System;                                                                                                                               // MakerGen.cs:508
using System.Diagnostics;                                                                                                                   // MakerGen.cs:509
using System.IO;                                                                                                                            // MakerGen.cs:510
using System.Linq;                                                                                                                          // MakerGen.cs:511
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:512
                                                                                                                                            // MakerGen.cs:513
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:514
{                                                                                                                                           // MakerGen.cs:515
    #region Json                                                                                                                            // MakerGen.cs:516
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
    #endregion                                                                                                                              // MakerGen.cs:520
    /// <summary>
    /// Fhir complex 'Address'
    /// </summary>
    // 0. Address
    public class Type_Address : FhirKhit.Maker.Common.Complex.ComplexBase                                                                   // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        public class Type_Address_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                    // MakerGen.cs:378
        {                                                                                                                                   // MakerGen.cs:379
            // 1. Address.use
            public ElementDefinitionInfo Element_Use;                                                                                       // MakerGen.cs:211
            // 2. Address.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:211
            // 3. Address.text
            public ElementDefinitionInfo Element_Text;                                                                                      // MakerGen.cs:211
            // 4. Address.line
            public ElementDefinitionInfo Element_Line;                                                                                      // MakerGen.cs:211
            // 5. Address.city
            public ElementDefinitionInfo Element_City;                                                                                      // MakerGen.cs:211
            // 6. Address.district
            public ElementDefinitionInfo Element_District;                                                                                  // MakerGen.cs:211
            // 7. Address.state
            public ElementDefinitionInfo Element_State;                                                                                     // MakerGen.cs:211
            // 8. Address.postalCode
            public ElementDefinitionInfo Element_PostalCode;                                                                                // MakerGen.cs:211
            // 9. Address.country
            public ElementDefinitionInfo Element_Country;                                                                                   // MakerGen.cs:211
            // 10. Address.period
            public ElementDefinitionInfo Element_Period;                                                                                    // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
            public Type_Address_Elements()                                                                                                  // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:226
                    // 1. Address.use
                    this.Element_Use = new ElementDefinitionInfo                                                                            // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Use",                                                                                               // MakerGen.cs:230
                        Path= "Address.use",                                                                                                // MakerGen.cs:231
                        Id = "Address.use",                                                                                                 // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 2. Address.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Type",                                                                                              // MakerGen.cs:230
                        Path= "Address.type",                                                                                               // MakerGen.cs:231
                        Id = "Address.type",                                                                                                // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 3. Address.text
                    this.Element_Text = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Text",                                                                                              // MakerGen.cs:230
                        Path= "Address.text",                                                                                               // MakerGen.cs:231
                        Id = "Address.text",                                                                                                // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 4. Address.line
                    this.Element_Line = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Line",                                                                                              // MakerGen.cs:230
                        Path= "Address.line",                                                                                               // MakerGen.cs:231
                        Id = "Address.line",                                                                                                // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 5. Address.city
                    this.Element_City = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_City",                                                                                              // MakerGen.cs:230
                        Path= "Address.city",                                                                                               // MakerGen.cs:231
                        Id = "Address.city",                                                                                                // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 6. Address.district
                    this.Element_District = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_District",                                                                                          // MakerGen.cs:230
                        Path= "Address.district",                                                                                           // MakerGen.cs:231
                        Id = "Address.district",                                                                                            // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 7. Address.state
                    this.Element_State = new ElementDefinitionInfo                                                                          // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_State",                                                                                             // MakerGen.cs:230
                        Path= "Address.state",                                                                                              // MakerGen.cs:231
                        Id = "Address.state",                                                                                               // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 8. Address.postalCode
                    this.Element_PostalCode = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_PostalCode",                                                                                        // MakerGen.cs:230
                        Path= "Address.postalCode",                                                                                         // MakerGen.cs:231
                        Id = "Address.postalCode",                                                                                          // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 9. Address.country
                    this.Element_Country = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Country",                                                                                           // MakerGen.cs:230
                        Path= "Address.country",                                                                                            // MakerGen.cs:231
                        Id = "Address.country",                                                                                             // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 10. Address.period
                    this.Element_Period = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Period",                                                                                            // MakerGen.cs:230
                        Path= "Address.period",                                                                                             // MakerGen.cs:231
                        Id = "Address.period",                                                                                              // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Period                                                                   // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                Element_Use.Write(sDef);                                                                                                    // MakerGen.cs:215
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:215
                Element_Text.Write(sDef);                                                                                                   // MakerGen.cs:215
                Element_Line.Write(sDef);                                                                                                   // MakerGen.cs:215
                Element_City.Write(sDef);                                                                                                   // MakerGen.cs:215
                Element_District.Write(sDef);                                                                                               // MakerGen.cs:215
                Element_State.Write(sDef);                                                                                                  // MakerGen.cs:215
                Element_PostalCode.Write(sDef);                                                                                             // MakerGen.cs:215
                Element_Country.Write(sDef);                                                                                                // MakerGen.cs:215
                Element_Period.Write(sDef);                                                                                                 // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:394
        }                                                                                                                                   // MakerGen.cs:396
        public Type_Address_Elements Elements                                                                                               // MakerGen.cs:398
        {                                                                                                                                   // MakerGen.cs:399
            get                                                                                                                             // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                if (this.elements == null)                                                                                                  // MakerGen.cs:402
                    this.elements = new Type_Address_Elements();                                                                            // MakerGen.cs:403
                return this.elements;                                                                                                       // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:406
        Type_Address_Elements elements;                                                                                                     // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
        public Type_Address()                                                                                                               // MakerGen.cs:410
        {                                                                                                                                   // MakerGen.cs:411
        }                                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:416
        {                                                                                                                                   // MakerGen.cs:417
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:418
            {                                                                                                                               // MakerGen.cs:419
                Path = "Address",                                                                                                           // MakerGen.cs:420
                ElementId = "Address"                                                                                                       // MakerGen.cs:421
            });                                                                                                                             // MakerGen.cs:422
            if (this.elements != null)                                                                                                      // MakerGen.cs:423
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:424
        }                                                                                                                                   // MakerGen.cs:425
    }                                                                                                                                       // MakerGen.cs:426
}                                                                                                                                           // MakerGen.cs:525
