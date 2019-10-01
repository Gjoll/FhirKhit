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
      "id": "HumanName",
      "url": "http://hl7.org/fhir/StructureDefinition/HumanName",
      "version": "4.0.0",
      "name": "HumanName",
      "status": "active",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for HumanName Type: A human's name with the ability to identify parts and usage.",
      "purpose": "Need to be able to record names, along with notes about their use.",
      "fhirVersion": "4.0.0",
      "kind": "complex-type",
      "abstract": false,
      "type": "HumanName",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "HumanName",
            "path": "HumanName",
            "short": "Name of a human - parts and usage",
            "definition": "A human's name with the ability to identify parts and usage.",
            "comment": "Names may be changed, or repudiated, or people may have different names in different contexts. Names may be divided into parts of different type that have variable significance depending on context, though the division into parts does not always matter. With personal names, the different parts might or might not be imbued with some implicit meaning; various cultures associate different importance with the name parts and the degree to which systems must care about name parts around the world varies widely.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "HumanName.use",
            "path": "HumanName.use",
            "short": "usual | official | temp | nickname | anonymous | old | maiden",
            "definition": "Identifies the purpose for this name.",
            "comment": "Applications can assume that a name is current unless it explicitly says that it is temporary or old.",
            "requirements": "Allows the appropriate name for a particular context of use to be selected from among a set of names.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isModifier": true,
            "isModifierReason": "This is labeled as \"Is Modifier\" because applications should not mistake a temporary or old name etc.for a current/permanent one",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "NameUse"
                }
              ],
              "strength": "required",
              "description": "The use of a human name.",
              "valueSet": "http://hl7.org/fhir/ValueSet/name-use|4.0.0"
            }
          },
          {
            "id": "HumanName.text",
            "path": "HumanName.text",
            "short": "Text representation of the full name",
            "definition": "Specifies the entire name as it should be displayed e.g. on an application UI. This may be provided instead of or as well as the specific parts.",
            "comment": "Can provide both a text representation and parts. Applications updating a name SHALL ensure that when both text and parts are present,  no content is included in the text that isn't found in a part.",
            "requirements": "A renderable, unencoded form.",
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
            "id": "HumanName.family",
            "path": "HumanName.family",
            "short": "Family name (often called 'Surname')",
            "definition": "The part of a name that links to the genealogy. In some cultures (e.g. Eritrea) the family name of a son is the first name of his father.",
            "comment": "Family Name may be decomposed into specific parts using extensions (de, nl, es related cultures).",
            "alias": [
              "surname"
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
            "id": "HumanName.given",
            "path": "HumanName.given",
            "short": "Given names (not always 'first'). Includes middle names",
            "definition": "Given name.",
            "comment": "If only initials are recorded, they may be used in place of the full name parts. Initials may be separated into multiple given names but often aren't due to paractical limitations.  This element is not called \"first name\" since given names do not always come first.",
            "alias": [
              "first name",
              "middle name"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "string"
              }
            ],
            "orderMeaning": "Given Names appear in the correct order for presenting the name",
            "isSummary": true
          },
          {
            "id": "HumanName.prefix",
            "path": "HumanName.prefix",
            "short": "Parts that come before the name",
            "definition": "Part of the name that is acquired as a title due to academic, legal, employment or nobility status, etc. and that appears at the start of the name.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "string"
              }
            ],
            "orderMeaning": "Prefixes appear in the correct order for presenting the name",
            "isSummary": true
          },
          {
            "id": "HumanName.suffix",
            "path": "HumanName.suffix",
            "short": "Parts that come after the name",
            "definition": "Part of the name that is acquired as a title due to academic, legal, employment or nobility status, etc. and that appears at the end of the name.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "string"
              }
            ],
            "orderMeaning": "Suffixes appear in the correct order for presenting the name",
            "isSummary": true
          },
          {
            "id": "HumanName.period",
            "path": "HumanName.period",
            "short": "Time period when name was/is in use",
            "definition": "Indicates the period of time when this name was valid for the named person.",
            "requirements": "Allows names to be placed in historical context.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Period"
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
    /// Fhir complex 'HumanName'
    /// </summary>
    // 0. HumanName
    public class Type_HumanName : FhirKhit.Maker.Common.Complex.ComplexBase                                                                 // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        public class Type_HumanName_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                  // MakerGen.cs:378
        {                                                                                                                                   // MakerGen.cs:379
            // 1. HumanName.use
            public ElementDefinitionInfo Element_Use;                                                                                       // MakerGen.cs:211
            // 2. HumanName.text
            public ElementDefinitionInfo Element_Text;                                                                                      // MakerGen.cs:211
            // 3. HumanName.family
            public ElementDefinitionInfo Element_Family;                                                                                    // MakerGen.cs:211
            // 4. HumanName.given
            public ElementDefinitionInfo Element_Given;                                                                                     // MakerGen.cs:211
            // 5. HumanName.prefix
            public ElementDefinitionInfo Element_Prefix;                                                                                    // MakerGen.cs:211
            // 6. HumanName.suffix
            public ElementDefinitionInfo Element_Suffix;                                                                                    // MakerGen.cs:211
            // 7. HumanName.period
            public ElementDefinitionInfo Element_Period;                                                                                    // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
            public Type_HumanName_Elements()                                                                                                // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:226
                    // 1. HumanName.use
                    this.Element_Use = new ElementDefinitionInfo                                                                            // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Use",                                                                                               // MakerGen.cs:230
                        Path= "HumanName.use",                                                                                              // MakerGen.cs:231
                        Id = "HumanName.use",                                                                                               // MakerGen.cs:232
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
                    // 2. HumanName.text
                    this.Element_Text = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Text",                                                                                              // MakerGen.cs:230
                        Path= "HumanName.text",                                                                                             // MakerGen.cs:231
                        Id = "HumanName.text",                                                                                              // MakerGen.cs:232
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
                    // 3. HumanName.family
                    this.Element_Family = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Family",                                                                                            // MakerGen.cs:230
                        Path= "HumanName.family",                                                                                           // MakerGen.cs:231
                        Id = "HumanName.family",                                                                                            // MakerGen.cs:232
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
                    // 4. HumanName.given
                    this.Element_Given = new ElementDefinitionInfo                                                                          // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Given",                                                                                             // MakerGen.cs:230
                        Path= "HumanName.given",                                                                                            // MakerGen.cs:231
                        Id = "HumanName.given",                                                                                             // MakerGen.cs:232
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
                    // 5. HumanName.prefix
                    this.Element_Prefix = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Prefix",                                                                                            // MakerGen.cs:230
                        Path= "HumanName.prefix",                                                                                           // MakerGen.cs:231
                        Id = "HumanName.prefix",                                                                                            // MakerGen.cs:232
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
                    // 6. HumanName.suffix
                    this.Element_Suffix = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Suffix",                                                                                            // MakerGen.cs:230
                        Path= "HumanName.suffix",                                                                                           // MakerGen.cs:231
                        Id = "HumanName.suffix",                                                                                            // MakerGen.cs:232
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
                    // 7. HumanName.period
                    this.Element_Period = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Period",                                                                                            // MakerGen.cs:230
                        Path= "HumanName.period",                                                                                           // MakerGen.cs:231
                        Id = "HumanName.period",                                                                                            // MakerGen.cs:232
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
                Element_Text.Write(sDef);                                                                                                   // MakerGen.cs:215
                Element_Family.Write(sDef);                                                                                                 // MakerGen.cs:215
                Element_Given.Write(sDef);                                                                                                  // MakerGen.cs:215
                Element_Prefix.Write(sDef);                                                                                                 // MakerGen.cs:215
                Element_Suffix.Write(sDef);                                                                                                 // MakerGen.cs:215
                Element_Period.Write(sDef);                                                                                                 // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:394
        }                                                                                                                                   // MakerGen.cs:396
        public Type_HumanName_Elements Elements                                                                                             // MakerGen.cs:398
        {                                                                                                                                   // MakerGen.cs:399
            get                                                                                                                             // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                if (this.elements == null)                                                                                                  // MakerGen.cs:402
                    this.elements = new Type_HumanName_Elements();                                                                          // MakerGen.cs:403
                return this.elements;                                                                                                       // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:406
        Type_HumanName_Elements elements;                                                                                                   // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
        public Type_HumanName()                                                                                                             // MakerGen.cs:410
        {                                                                                                                                   // MakerGen.cs:411
        }                                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:416
        {                                                                                                                                   // MakerGen.cs:417
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:418
            {                                                                                                                               // MakerGen.cs:419
                Path = "HumanName",                                                                                                         // MakerGen.cs:420
                ElementId = "HumanName"                                                                                                     // MakerGen.cs:421
            });                                                                                                                             // MakerGen.cs:422
            if (this.elements != null)                                                                                                      // MakerGen.cs:423
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:424
        }                                                                                                                                   // MakerGen.cs:425
    }                                                                                                                                       // MakerGen.cs:426
}                                                                                                                                           // MakerGen.cs:525
