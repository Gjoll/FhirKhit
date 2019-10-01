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
      "id": "CodeableConcept",
      "url": "http://hl7.org/fhir/StructureDefinition/CodeableConcept",
      "version": "4.0.0",
      "name": "CodeableConcept",
      "status": "active",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for CodeableConcept Type: A concept that may be defined by a formal reference to a terminology or ontology or may be provided by text.",
      "purpose": "This is a common pattern in healthcare - a concept that may be defined by one or more codes from formal definitions including LOINC and SNOMED CT, and/or defined by the provision of text that captures a human sense of the concept.",
      "fhirVersion": "4.0.0",
      "kind": "complex-type",
      "abstract": false,
      "type": "CodeableConcept",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "CodeableConcept",
            "path": "CodeableConcept",
            "short": "Concept - reference to a terminology or just  text",
            "definition": "A concept that may be defined by a formal reference to a terminology or ontology or may be provided by text.",
            "comment": "Not all terminology uses fit this general pattern. In some cases, models should not use CodeableConcept and use Coding directly and provide their own structure for managing text, codings, translations and the relationship between elements and pre- and post-coordination.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "CodeableConcept.coding",
            "path": "CodeableConcept.coding",
            "short": "Code defined by a terminology system",
            "definition": "A reference to a code defined by a terminology system.",
            "comment": "Codes may be defined very casually in enumerations, or code lists, up to very formal definitions such as SNOMED CT - see the HL7 v3 Core Principles for more information.  Ordering of codings is undefined and SHALL NOT be used to infer meaning. Generally, at most only one of the coding values will be labeled as UserSelected = true.",
            "requirements": "Allows for alternative encodings within a code system, and translations to other code systems.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Coding"
              }
            ],
            "isSummary": true
          },
          {
            "id": "CodeableConcept.text",
            "path": "CodeableConcept.text",
            "short": "Plain text representation of the concept",
            "definition": "A human language representation of the concept as seen/selected/uttered by the user who entered the data and/or which represents the intended meaning of the user.",
            "comment": "Very often the text is the same as a displayName of one of the codings.",
            "requirements": "The codes from the terminologies do not always capture the correct meaning with all the nuances of the human using them, or sometimes there is no appropriate code at all. In these cases, the text is used to capture the full meaning of the source.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
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
    /// Fhir complex 'CodeableConcept'
    /// </summary>
    // 0. CodeableConcept
    public class Type_CodeableConcept : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        public class Type_CodeableConcept_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                            // MakerGen.cs:378
        {                                                                                                                                   // MakerGen.cs:379
            // 1. CodeableConcept.coding
            public ElementDefinitionInfo Element_Coding;                                                                                    // MakerGen.cs:211
            // 2. CodeableConcept.text
            public ElementDefinitionInfo Element_Text;                                                                                      // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
            public Type_CodeableConcept_Elements()                                                                                          // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:226
                    // 1. CodeableConcept.coding
                    this.Element_Coding = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Coding",                                                                                            // MakerGen.cs:230
                        Path= "CodeableConcept.coding",                                                                                     // MakerGen.cs:231
                        Id = "CodeableConcept.coding",                                                                                      // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Coding                                                                   // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 2. CodeableConcept.text
                    this.Element_Text = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Text",                                                                                              // MakerGen.cs:230
                        Path= "CodeableConcept.text",                                                                                       // MakerGen.cs:231
                        Id = "CodeableConcept.text",                                                                                        // MakerGen.cs:232
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
            }                                                                                                                               // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                Element_Coding.Write(sDef);                                                                                                 // MakerGen.cs:215
                Element_Text.Write(sDef);                                                                                                   // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:394
        }                                                                                                                                   // MakerGen.cs:396
        public Type_CodeableConcept_Elements Elements                                                                                       // MakerGen.cs:398
        {                                                                                                                                   // MakerGen.cs:399
            get                                                                                                                             // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                if (this.elements == null)                                                                                                  // MakerGen.cs:402
                    this.elements = new Type_CodeableConcept_Elements();                                                                    // MakerGen.cs:403
                return this.elements;                                                                                                       // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:406
        Type_CodeableConcept_Elements elements;                                                                                             // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
        public Type_CodeableConcept()                                                                                                       // MakerGen.cs:410
        {                                                                                                                                   // MakerGen.cs:411
        }                                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:416
        {                                                                                                                                   // MakerGen.cs:417
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:418
            {                                                                                                                               // MakerGen.cs:419
                Path = "CodeableConcept",                                                                                                   // MakerGen.cs:420
                ElementId = "CodeableConcept"                                                                                               // MakerGen.cs:421
            });                                                                                                                             // MakerGen.cs:422
            if (this.elements != null)                                                                                                      // MakerGen.cs:423
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:424
        }                                                                                                                                   // MakerGen.cs:425
    }                                                                                                                                       // MakerGen.cs:426
}                                                                                                                                           // MakerGen.cs:525
