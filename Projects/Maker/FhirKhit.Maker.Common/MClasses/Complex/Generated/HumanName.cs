using System;                                                                                                                               // MakerGen.cs:516
using System.Diagnostics;                                                                                                                   // MakerGen.cs:517
using System.IO;                                                                                                                            // MakerGen.cs:518
using System.Linq;                                                                                                                          // MakerGen.cs:519
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:520
                                                                                                                                            // MakerGen.cs:521
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:522
{                                                                                                                                           // MakerGen.cs:523
    #region Json                                                                                                                            // MakerGen.cs:524
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
    #endregion                                                                                                                              // MakerGen.cs:528
    /// <summary>
    /// Fhir complex 'HumanName'
    /// </summary>
    // 0. HumanName
    public class HumanName : FhirKhit.Maker.Common.Complex.ComplexBase                                                                      // MakerGen.cs:384
    {                                                                                                                                       // MakerGen.cs:385
        public class HumanName_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                       // MakerGen.cs:386
        {                                                                                                                                   // MakerGen.cs:387
            // 1. HumanName.use
            public ElementDefinitionInfo Use;                                                                                               // MakerGen.cs:216
            // 2. HumanName.text
            public ElementDefinitionInfo Text;                                                                                              // MakerGen.cs:216
            // 3. HumanName.family
            public ElementDefinitionInfo Family;                                                                                            // MakerGen.cs:216
            // 4. HumanName.given
            public ElementDefinitionInfo Given;                                                                                             // MakerGen.cs:216
            // 5. HumanName.prefix
            public ElementDefinitionInfo Prefix;                                                                                            // MakerGen.cs:216
            // 6. HumanName.suffix
            public ElementDefinitionInfo Suffix;                                                                                            // MakerGen.cs:216
            // 7. HumanName.period
            public ElementDefinitionInfo Period;                                                                                            // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
            public HumanName_Elements()                                                                                                     // MakerGen.cs:392
            {                                                                                                                               // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:231
                    // 1. HumanName.use
                    this.Use = new ElementDefinitionInfo                                                                                    // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Use",                                                                                                       // MakerGen.cs:235
                        Path= "HumanName.use",                                                                                              // MakerGen.cs:236
                        Id = "HumanName.use",                                                                                               // MakerGen.cs:237
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
                    // 2. HumanName.text
                    this.Text = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Text",                                                                                                      // MakerGen.cs:235
                        Path= "HumanName.text",                                                                                             // MakerGen.cs:236
                        Id = "HumanName.text",                                                                                              // MakerGen.cs:237
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
                    // 3. HumanName.family
                    this.Family = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Family",                                                                                                    // MakerGen.cs:235
                        Path= "HumanName.family",                                                                                           // MakerGen.cs:236
                        Id = "HumanName.family",                                                                                            // MakerGen.cs:237
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
                    // 4. HumanName.given
                    this.Given = new ElementDefinitionInfo                                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Given",                                                                                                     // MakerGen.cs:235
                        Path= "HumanName.given",                                                                                            // MakerGen.cs:236
                        Id = "HumanName.given",                                                                                             // MakerGen.cs:237
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
                    // 5. HumanName.prefix
                    this.Prefix = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Prefix",                                                                                                    // MakerGen.cs:235
                        Path= "HumanName.prefix",                                                                                           // MakerGen.cs:236
                        Id = "HumanName.prefix",                                                                                            // MakerGen.cs:237
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
                    // 6. HumanName.suffix
                    this.Suffix = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Suffix",                                                                                                    // MakerGen.cs:235
                        Path= "HumanName.suffix",                                                                                           // MakerGen.cs:236
                        Id = "HumanName.suffix",                                                                                            // MakerGen.cs:237
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
                    // 7. HumanName.period
                    this.Period = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Period",                                                                                                    // MakerGen.cs:235
                        Path= "HumanName.period",                                                                                           // MakerGen.cs:236
                        Id = "HumanName.period",                                                                                            // MakerGen.cs:237
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
            }                                                                                                                               // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:398
            {                                                                                                                               // MakerGen.cs:399
                base.Write(sDef);                                                                                                           // MakerGen.cs:400
                Use.Write(sDef);                                                                                                            // MakerGen.cs:220
                Text.Write(sDef);                                                                                                           // MakerGen.cs:220
                Family.Write(sDef);                                                                                                         // MakerGen.cs:220
                Given.Write(sDef);                                                                                                          // MakerGen.cs:220
                Prefix.Write(sDef);                                                                                                         // MakerGen.cs:220
                Suffix.Write(sDef);                                                                                                         // MakerGen.cs:220
                Period.Write(sDef);                                                                                                         // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:402
        }                                                                                                                                   // MakerGen.cs:404
        public HumanName_Elements Elements                                                                                                  // MakerGen.cs:406
        {                                                                                                                                   // MakerGen.cs:407
            get                                                                                                                             // MakerGen.cs:408
            {                                                                                                                               // MakerGen.cs:409
                if (this.elements == null)                                                                                                  // MakerGen.cs:410
                    this.elements = new HumanName_Elements();                                                                               // MakerGen.cs:411
                return this.elements;                                                                                                       // MakerGen.cs:412
            }                                                                                                                               // MakerGen.cs:413
        }                                                                                                                                   // MakerGen.cs:414
        HumanName_Elements elements;                                                                                                        // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
        public HumanName()                                                                                                                  // MakerGen.cs:418
        {                                                                                                                                   // MakerGen.cs:419
        }                                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:424
        {                                                                                                                                   // MakerGen.cs:425
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:426
            {                                                                                                                               // MakerGen.cs:427
                Path = "HumanName",                                                                                                         // MakerGen.cs:428
                ElementId = "HumanName"                                                                                                     // MakerGen.cs:429
            });                                                                                                                             // MakerGen.cs:430
            if (this.elements != null)                                                                                                      // MakerGen.cs:431
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:432
        }                                                                                                                                   // MakerGen.cs:433
    }                                                                                                                                       // MakerGen.cs:434
}                                                                                                                                           // MakerGen.cs:533
