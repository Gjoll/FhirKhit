using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:381
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:382
{                                                                                                                                           // MakerGen.cs:383
    /// <summary>
    /// Fhir primitive 'HumanName'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "HumanName",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/HumanName",
    ///   "version": "4.0.0",
    ///   "name": "HumanName",
    ///   "status": "active",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for HumanName Type: A human's name with the ability to identify parts and usage.",
    ///   "purpose": "Need to be able to record names, along with notes about their use.",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": false,
    ///   "type": "HumanName",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "HumanName",
    ///         "path": "HumanName",
    ///         "short": "Name of a human - parts and usage",
    ///         "definition": "A human's name with the ability to identify parts and usage.",
    ///         "comment": "Names may be changed, or repudiated, or people may have different names in different contexts. Names may be divided into parts of different type that have variable significance depending on context, though the division into parts does not always matter. With personal names, the different parts might or might not be imbued with some implicit meaning; various cultures associate different importance with the name parts and the degree to which systems must care about name parts around the world varies widely.",
    ///         "min": 0,
    ///         "max": "*"
    ///       },
    ///       {
    ///         "id": "HumanName.use",
    ///         "path": "HumanName.use",
    ///         "short": "usual | official | temp | nickname | anonymous | old | maiden",
    ///         "definition": "Identifies the purpose for this name.",
    ///         "comment": "Applications can assume that a name is current unless it explicitly says that it is temporary or old.",
    ///         "requirements": "Allows the appropriate name for a particular context of use to be selected from among a set of names.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "code"
    ///           }
    ///         ],
    ///         "isModifier": true,
    ///         "isModifierReason": "This is labeled as \"Is Modifier\" because applications should not mistake a temporary or old name etc.for a current/permanent one",
    ///         "isSummary": true,
    ///         "binding": {
    ///           "extension": [
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
    ///               "valueString": "NameUse"
    ///             }
    ///           ],
    ///           "strength": "required",
    ///           "description": "The use of a human name.",
    ///           "valueSet": "http://hl7.org/fhir/ValueSet/name-use|4.0.0"
    ///         }
    ///       },
    ///       {
    ///         "id": "HumanName.text",
    ///         "path": "HumanName.text",
    ///         "short": "Text representation of the full name",
    ///         "definition": "Specifies the entire name as it should be displayed e.g. on an application UI. This may be provided instead of or as well as the specific parts.",
    ///         "comment": "Can provide both a text representation and parts. Applications updating a name SHALL ensure that when both text and parts are present,  no content is included in the text that isn't found in a part.",
    ///         "requirements": "A renderable, unencoded form.",
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
    ///         "id": "HumanName.family",
    ///         "path": "HumanName.family",
    ///         "short": "Family name (often called 'Surname')",
    ///         "definition": "The part of a name that links to the genealogy. In some cultures (e.g. Eritrea) the family name of a son is the first name of his father.",
    ///         "comment": "Family Name may be decomposed into specific parts using extensions (de, nl, es related cultures).",
    ///         "alias": [
    ///           "surname"
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
    ///         "id": "HumanName.given",
    ///         "path": "HumanName.given",
    ///         "short": "Given names (not always 'first'). Includes middle names",
    ///         "definition": "Given name.",
    ///         "comment": "If only initials are recorded, they may be used in place of the full name parts. Initials may be separated into multiple given names but often aren't due to paractical limitations.  This element is not called \"first name\" since given names do not always come first.",
    ///         "alias": [
    ///           "first name",
    ///           "middle name"
    ///         ],
    ///         "min": 0,
    ///         "max": "*",
    ///         "type": [
    ///           {
    ///             "code": "string"
    ///           }
    ///         ],
    ///         "orderMeaning": "Given Names appear in the correct order for presenting the name",
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "HumanName.prefix",
    ///         "path": "HumanName.prefix",
    ///         "short": "Parts that come before the name",
    ///         "definition": "Part of the name that is acquired as a title due to academic, legal, employment or nobility status, etc. and that appears at the start of the name.",
    ///         "min": 0,
    ///         "max": "*",
    ///         "type": [
    ///           {
    ///             "code": "string"
    ///           }
    ///         ],
    ///         "orderMeaning": "Prefixes appear in the correct order for presenting the name",
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "HumanName.suffix",
    ///         "path": "HumanName.suffix",
    ///         "short": "Parts that come after the name",
    ///         "definition": "Part of the name that is acquired as a title due to academic, legal, employment or nobility status, etc. and that appears at the end of the name.",
    ///         "min": 0,
    ///         "max": "*",
    ///         "type": [
    ///           {
    ///             "code": "string"
    ///           }
    ///         ],
    ///         "orderMeaning": "Suffixes appear in the correct order for presenting the name",
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "HumanName.period",
    ///         "path": "HumanName.period",
    ///         "short": "Time period when name was/is in use",
    ///         "definition": "Indicates the period of time when this name was valid for the named person.",
    ///         "requirements": "Allows names to be placed in historical context.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "Period"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    // 0. HumanName
    public class HumanName_Type : MakerComplex_Type                                                                                         // MakerGen.cs:337
    {                                                                                                                                       // MakerGen.cs:338
        // 1. HumanName.use
        public MakerElementInstance Use;                                                                                                    // MakerGen.cs:217
        // 2. HumanName.text
        public MakerElementInstance Text;                                                                                                   // MakerGen.cs:217
        // 3. HumanName.family
        public MakerElementInstance Family;                                                                                                 // MakerGen.cs:217
        // 4. HumanName.given
        public MakerElementInstance Given;                                                                                                  // MakerGen.cs:217
        // 5. HumanName.prefix
        public MakerElementInstance Prefix;                                                                                                 // MakerGen.cs:217
        // 6. HumanName.suffix
        public MakerElementInstance Suffix;                                                                                                 // MakerGen.cs:217
        // 7. HumanName.period
        public MakerElementInstance Period;                                                                                                 // MakerGen.cs:217
        public HumanName_Type()                                                                                                             // MakerGen.cs:346
        {                                                                                                                                   // MakerGen.cs:347
            {                                                                                                                               // MakerGen.cs:228
                // 1. HumanName.use
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
                // 2. HumanName.text
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
                // 3. HumanName.family
                this.Family = new MakerElementInstance                                                                                      // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Family",                                                                                                        // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new String_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 4. HumanName.given
                this.Given = new MakerElementInstance                                                                                       // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Given",                                                                                                         // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = -1,                                                                                                               // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new String_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 5. HumanName.prefix
                this.Prefix = new MakerElementInstance                                                                                      // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Prefix",                                                                                                        // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = -1,                                                                                                               // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new String_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 6. HumanName.suffix
                this.Suffix = new MakerElementInstance                                                                                      // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Suffix",                                                                                                        // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = -1,                                                                                                               // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new String_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 7. HumanName.period
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
