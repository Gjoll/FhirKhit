using System;                                                                                                                               // MakerGen.cs:498
using System.Diagnostics;                                                                                                                   // MakerGen.cs:499
using System.IO;                                                                                                                            // MakerGen.cs:500
using System.Linq;                                                                                                                          // MakerGen.cs:501
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:502
                                                                                                                                            // MakerGen.cs:503
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:504
{                                                                                                                                           // MakerGen.cs:505
    #region Json                                                                                                                            // MakerGen.cs:506
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
    #endregion                                                                                                                              // MakerGen.cs:510
    /// <summary>
    /// Fhir complex 'Address'
    /// </summary>
    // 0. Address
    public class Type_Address : FhirKhit.Maker.Common.Complex.ComplexBase                                                                   // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        // 1. Address.use
        public ElementDefinitionInfo Element_Use;                                                                                           // MakerGen.cs:219
        // 2. Address.type
        public ElementDefinitionInfo Element_Type;                                                                                          // MakerGen.cs:219
        // 3. Address.text
        public ElementDefinitionInfo Element_Text;                                                                                          // MakerGen.cs:219
        // 4. Address.line
        public ElementDefinitionInfo Element_Line;                                                                                          // MakerGen.cs:219
        // 5. Address.city
        public ElementDefinitionInfo Element_City;                                                                                          // MakerGen.cs:219
        // 6. Address.district
        public ElementDefinitionInfo Element_District;                                                                                      // MakerGen.cs:219
        // 7. Address.state
        public ElementDefinitionInfo Element_State;                                                                                         // MakerGen.cs:219
        // 8. Address.postalCode
        public ElementDefinitionInfo Element_PostalCode;                                                                                    // MakerGen.cs:219
        // 9. Address.country
        public ElementDefinitionInfo Element_Country;                                                                                       // MakerGen.cs:219
        // 10. Address.period
        public ElementDefinitionInfo Element_Period;                                                                                        // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:390
        {                                                                                                                                   // MakerGen.cs:391
            base.Write(sDef);                                                                                                               // MakerGen.cs:392
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                Path = "Address",                                                                                                           // MakerGen.cs:395
                ElementId = "Address"                                                                                                       // MakerGen.cs:396
            });                                                                                                                             // MakerGen.cs:397
            Element_Use.Write(sDef);                                                                                                        // MakerGen.cs:223
            Element_Type.Write(sDef);                                                                                                       // MakerGen.cs:223
            Element_Text.Write(sDef);                                                                                                       // MakerGen.cs:223
            Element_Line.Write(sDef);                                                                                                       // MakerGen.cs:223
            Element_City.Write(sDef);                                                                                                       // MakerGen.cs:223
            Element_District.Write(sDef);                                                                                                   // MakerGen.cs:223
            Element_State.Write(sDef);                                                                                                      // MakerGen.cs:223
            Element_PostalCode.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_Country.Write(sDef);                                                                                                    // MakerGen.cs:223
            Element_Period.Write(sDef);                                                                                                     // MakerGen.cs:223
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
        public Type_Address()                                                                                                               // MakerGen.cs:402
        {                                                                                                                                   // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:234
                // 1. Address.use
                this.Element_Use = new ElementDefinitionInfo                                                                                // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Use",                                                                                                   // MakerGen.cs:238
                    Path= "Address.use",                                                                                                    // MakerGen.cs:239
                    Id = "Address.use",                                                                                                     // MakerGen.cs:240
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
                // 2. Address.type
                this.Element_Type = new ElementDefinitionInfo                                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Type",                                                                                                  // MakerGen.cs:238
                    Path= "Address.type",                                                                                                   // MakerGen.cs:239
                    Id = "Address.type",                                                                                                    // MakerGen.cs:240
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
                // 3. Address.text
                this.Element_Text = new ElementDefinitionInfo                                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Text",                                                                                                  // MakerGen.cs:238
                    Path= "Address.text",                                                                                                   // MakerGen.cs:239
                    Id = "Address.text",                                                                                                    // MakerGen.cs:240
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
                // 4. Address.line
                this.Element_Line = new ElementDefinitionInfo                                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Line",                                                                                                  // MakerGen.cs:238
                    Path= "Address.line",                                                                                                   // MakerGen.cs:239
                    Id = "Address.line",                                                                                                    // MakerGen.cs:240
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
                // 5. Address.city
                this.Element_City = new ElementDefinitionInfo                                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_City",                                                                                                  // MakerGen.cs:238
                    Path= "Address.city",                                                                                                   // MakerGen.cs:239
                    Id = "Address.city",                                                                                                    // MakerGen.cs:240
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
                // 6. Address.district
                this.Element_District = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_District",                                                                                              // MakerGen.cs:238
                    Path= "Address.district",                                                                                               // MakerGen.cs:239
                    Id = "Address.district",                                                                                                // MakerGen.cs:240
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
                // 7. Address.state
                this.Element_State = new ElementDefinitionInfo                                                                              // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_State",                                                                                                 // MakerGen.cs:238
                    Path= "Address.state",                                                                                                  // MakerGen.cs:239
                    Id = "Address.state",                                                                                                   // MakerGen.cs:240
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
                // 8. Address.postalCode
                this.Element_PostalCode = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_PostalCode",                                                                                            // MakerGen.cs:238
                    Path= "Address.postalCode",                                                                                             // MakerGen.cs:239
                    Id = "Address.postalCode",                                                                                              // MakerGen.cs:240
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
                // 9. Address.country
                this.Element_Country = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Country",                                                                                               // MakerGen.cs:238
                    Path= "Address.country",                                                                                                // MakerGen.cs:239
                    Id = "Address.country",                                                                                                 // MakerGen.cs:240
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
                // 10. Address.period
                this.Element_Period = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Period",                                                                                                // MakerGen.cs:238
                    Path= "Address.period",                                                                                                 // MakerGen.cs:239
                    Id = "Address.period",                                                                                                  // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Period                                                                       // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:407
}                                                                                                                                           // MakerGen.cs:515
