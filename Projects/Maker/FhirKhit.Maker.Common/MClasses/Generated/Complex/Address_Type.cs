using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:381
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:382
{                                                                                                                                           // MakerGen.cs:383
    /// <summary>
    /// Fhir primitive 'Address'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "Address",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/Address",
    ///   "version": "4.0.0",
    ///   "name": "Address",
    ///   "status": "active",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for Address Type: An address expressed using postal conventions (as opposed to GPS or other location definition formats).  This data type may be used to convey addresses for use in delivering mail as well as for visiting locations which might not be valid for mail delivery.  There are a variety of postal address formats defined around the world.",
    ///   "purpose": "Need to be able to record postal addresses, along with notes about their use.",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": false,
    ///   "type": "Address",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "Address",
    ///         "path": "Address",
    ///         "short": "An address expressed using postal conventions (as opposed to GPS or other location definition formats)",
    ///         "definition": "An address expressed using postal conventions (as opposed to GPS or other location definition formats).  This data type may be used to convey addresses for use in delivering mail as well as for visiting locations which might not be valid for mail delivery.  There are a variety of postal address formats defined around the world.",
    ///         "comment": "Note: address is intended to describe postal addresses for administrative purposes, not to describe absolute geographical coordinates.  Postal addresses are often used as proxies for physical locations (also see the [Location](location.html#) resource).",
    ///         "min": 0,
    ///         "max": "*"
    ///       },
    ///       {
    ///         "id": "Address.use",
    ///         "path": "Address.use",
    ///         "short": "home | work | temp | old | billing - purpose of this address",
    ///         "definition": "The purpose of this address.",
    ///         "comment": "Applications can assume that an address is current unless it explicitly says that it is temporary or old.",
    ///         "requirements": "Allows an appropriate address to be chosen from a list of many.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "code"
    ///           }
    ///         ],
    ///         "example": [
    ///           {
    ///             "label": "General",
    ///             "valueCode": "home"
    ///           }
    ///         ],
    ///         "isModifier": true,
    ///         "isModifierReason": "This is labeled as \"Is Modifier\" because applications should not mistake a temporary or old address etc.for a current/permanent one",
    ///         "isSummary": true,
    ///         "binding": {
    ///           "extension": [
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
    ///               "valueString": "AddressUse"
    ///             }
    ///           ],
    ///           "strength": "required",
    ///           "description": "The use of an address.",
    ///           "valueSet": "http://hl7.org/fhir/ValueSet/address-use|4.0.0"
    ///         }
    ///       },
    ///       {
    ///         "id": "Address.type",
    ///         "path": "Address.type",
    ///         "short": "postal | physical | both",
    ///         "definition": "Distinguishes between physical addresses (those you can visit) and mailing addresses (e.g. PO Boxes and care-of addresses). Most addresses are both.",
    ///         "comment": "The definition of Address states that \"address is intended to describe postal addresses, not physical locations\". However, many applications track whether an address has a dual purpose of being a location that can be visited as well as being a valid delivery destination, and Postal addresses are often used as proxies for physical locations (also see the [Location](location.html#) resource).",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "code"
    ///           }
    ///         ],
    ///         "example": [
    ///           {
    ///             "label": "General",
    ///             "valueCode": "both"
    ///           }
    ///         ],
    ///         "isSummary": true,
    ///         "binding": {
    ///           "extension": [
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
    ///               "valueString": "AddressType"
    ///             }
    ///           ],
    ///           "strength": "required",
    ///           "description": "The type of an address (physical / postal).",
    ///           "valueSet": "http://hl7.org/fhir/ValueSet/address-type|4.0.0"
    ///         }
    ///       },
    ///       {
    ///         "id": "Address.text",
    ///         "path": "Address.text",
    ///         "short": "Text representation of the address",
    ///         "definition": "Specifies the entire address as it should be displayed e.g. on a postal label. This may be provided instead of or as well as the specific parts.",
    ///         "comment": "Can provide both a text representation and parts. Applications updating an address SHALL ensure that  when both text and parts are present,  no content is included in the text that isn't found in a part.",
    ///         "requirements": "A renderable, unencoded form.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "string"
    ///           }
    ///         ],
    ///         "example": [
    ///           {
    ///             "label": "General",
    ///             "valueString": "137 Nowhere Street, Erewhon 9132"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Address.line",
    ///         "path": "Address.line",
    ///         "short": "Street name, number, direction & P.O. Box etc.",
    ///         "definition": "This component contains the house number, apartment number, street name, street direction,  P.O. Box number, delivery hints, and similar address information.",
    ///         "min": 0,
    ///         "max": "*",
    ///         "type": [
    ///           {
    ///             "code": "string"
    ///           }
    ///         ],
    ///         "orderMeaning": "The order in which lines should appear in an address label",
    ///         "example": [
    ///           {
    ///             "label": "General",
    ///             "valueString": "137 Nowhere Street"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Address.city",
    ///         "path": "Address.city",
    ///         "short": "Name of city, town etc.",
    ///         "definition": "The name of the city, town, suburb, village or other community or delivery center.",
    ///         "alias": [
    ///           "Municpality"
    ///         ],
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "string"
    ///           }
    ///         ],
    ///         "example": [
    ///           {
    ///             "label": "General",
    ///             "valueString": "Erewhon"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Address.district",
    ///         "path": "Address.district",
    ///         "short": "District name (aka county)",
    ///         "definition": "The name of the administrative area (county).",
    ///         "comment": "District is sometimes known as county, but in some regions 'county' is used in place of city (municipality), so county name should be conveyed in city instead.",
    ///         "alias": [
    ///           "County"
    ///         ],
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "string"
    ///           }
    ///         ],
    ///         "example": [
    ///           {
    ///             "label": "General",
    ///             "valueString": "Madison"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Address.state",
    ///         "path": "Address.state",
    ///         "short": "Sub-unit of country (abbreviations ok)",
    ///         "definition": "Sub-unit of a country with limited sovereignty in a federally organized country. A code may be used if codes are in common use (e.g. US 2 letter state codes).",
    ///         "alias": [
    ///           "Province",
    ///           "Territory"
    ///         ],
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "string"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Address.postalCode",
    ///         "path": "Address.postalCode",
    ///         "short": "Postal code for area",
    ///         "definition": "A postal code designating a region defined by the postal service.",
    ///         "alias": [
    ///           "Zip"
    ///         ],
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "string"
    ///           }
    ///         ],
    ///         "example": [
    ///           {
    ///             "label": "General",
    ///             "valueString": "9132"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Address.country",
    ///         "path": "Address.country",
    ///         "short": "Country (e.g. can be ISO 3166 2 or 3 letter code)",
    ///         "definition": "Country - a nation as commonly understood or generally accepted.",
    ///         "comment": "ISO 3166 3 letter codes can be used in place of a human readable country name.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "string"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Address.period",
    ///         "path": "Address.period",
    ///         "short": "Time period when address was/is in use",
    ///         "definition": "Time period when address was/is in use.",
    ///         "requirements": "Allows addresses to be placed in historical context.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "Period"
    ///           }
    ///         ],
    ///         "example": [
    ///           {
    ///             "label": "General",
    ///             "valuePeriod": {
    ///               "start": "2010-03-23",
    ///               "end": "2010-07-01"
    ///             }
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    // 0. Address
    public class Address_Type : MakerComplex_Type                                                                                           // MakerGen.cs:337
    {                                                                                                                                       // MakerGen.cs:338
        // 1. Address.use
        public MakerElementInstance Use;                                                                                                    // MakerGen.cs:217
        // 2. Address.type
        public MakerElementInstance Type;                                                                                                   // MakerGen.cs:217
        // 3. Address.text
        public MakerElementInstance Text;                                                                                                   // MakerGen.cs:217
        // 4. Address.line
        public MakerElementInstance Line;                                                                                                   // MakerGen.cs:217
        // 5. Address.city
        public MakerElementInstance City;                                                                                                   // MakerGen.cs:217
        // 6. Address.district
        public MakerElementInstance District;                                                                                               // MakerGen.cs:217
        // 7. Address.state
        public MakerElementInstance State;                                                                                                  // MakerGen.cs:217
        // 8. Address.postalCode
        public MakerElementInstance PostalCode;                                                                                             // MakerGen.cs:217
        // 9. Address.country
        public MakerElementInstance Country;                                                                                                // MakerGen.cs:217
        // 10. Address.period
        public MakerElementInstance Period;                                                                                                 // MakerGen.cs:217
        public Address_Type()                                                                                                               // MakerGen.cs:346
        {                                                                                                                                   // MakerGen.cs:347
            {                                                                                                                               // MakerGen.cs:228
                // 1. Address.use
                this.Use = new MakerElementInstance                                                                                         // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Use",                                                                                                           // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new Code_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 2. Address.type
                this.Type = new MakerElementInstance                                                                                        // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Type",                                                                                                          // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new Code_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 3. Address.text
                this.Text = new MakerElementInstance                                                                                        // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Text",                                                                                                          // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new String_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 4. Address.line
                this.Line = new MakerElementInstance                                                                                        // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Line",                                                                                                          // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = -1,                                                                                                               // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new String_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 5. Address.city
                this.City = new MakerElementInstance                                                                                        // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "City",                                                                                                          // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new String_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 6. Address.district
                this.District = new MakerElementInstance                                                                                    // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "District",                                                                                                      // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new String_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 7. Address.state
                this.State = new MakerElementInstance                                                                                       // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "State",                                                                                                         // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new String_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 8. Address.postalCode
                this.PostalCode = new MakerElementInstance                                                                                  // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "PostalCode",                                                                                                    // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new String_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 9. Address.country
                this.Country = new MakerElementInstance                                                                                     // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Country",                                                                                                       // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new String_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 10. Address.period
                this.Period = new MakerElementInstance                                                                                      // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Period",                                                                                                        // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
        }                                                                                                                                   // MakerGen.cs:358
    }                                                                                                                                       // MakerGen.cs:342
}                                                                                                                                           // MakerGen.cs:389
