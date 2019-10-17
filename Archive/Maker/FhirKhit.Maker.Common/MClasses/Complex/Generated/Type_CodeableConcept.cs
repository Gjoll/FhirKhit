using System;                                                                                                                               // MakerGen.cs:490
using System.Diagnostics;                                                                                                                   // MakerGen.cs:491
using System.IO;                                                                                                                            // MakerGen.cs:492
using System.Linq;                                                                                                                          // MakerGen.cs:493
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:494
                                                                                                                                            // MakerGen.cs:495
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:496
{                                                                                                                                           // MakerGen.cs:497
    #region Json                                                                                                                            // MakerGen.cs:498
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
    #endregion                                                                                                                              // MakerGen.cs:502
    /// <summary>
    /// Fhir complex 'CodeableConcept'
    /// </summary>
    // 0. CodeableConcept
    public partial class Type_CodeableConcept : FhirKhit.Maker.Common.Complex.ComplexBase                                                   // MakerGen.cs:381
    {                                                                                                                                       // MakerGen.cs:382
        // 1. CodeableConcept.coding
        public ElementDefinitionInfo Element_Coding;                                                                                        // MakerGen.cs:217
        // 2. CodeableConcept.text
        public ElementDefinitionInfo Element_Text;                                                                                          // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:388
        {                                                                                                                                   // MakerGen.cs:389
            base.Write(sDef);                                                                                                               // MakerGen.cs:390
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:391
            {                                                                                                                               // MakerGen.cs:392
                Path = "CodeableConcept",                                                                                                   // MakerGen.cs:393
                ElementId = "CodeableConcept"                                                                                               // MakerGen.cs:394
            });                                                                                                                             // MakerGen.cs:395
            Element_Coding.Write(sDef);                                                                                                     // MakerGen.cs:221
            Element_Text.Write(sDef);                                                                                                       // MakerGen.cs:221
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
        public Type_CodeableConcept()                                                                                                       // MakerGen.cs:400
        {                                                                                                                                   // MakerGen.cs:401
            {                                                                                                                               // MakerGen.cs:232
                // 1. CodeableConcept.coding
                this.Element_Coding = new ElementDefinitionInfo                                                                             // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Coding",                                                                                                // MakerGen.cs:236
                    Path= "CodeableConcept.coding",                                                                                         // MakerGen.cs:237
                    Id = "CodeableConcept.coding",                                                                                          // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Coding                                                                       // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 2. CodeableConcept.text
                this.Element_Text = new ElementDefinitionInfo                                                                               // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Text",                                                                                                  // MakerGen.cs:236
                    Path= "CodeableConcept.text",                                                                                           // MakerGen.cs:237
                    Id = "CodeableConcept.text",                                                                                            // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
        }                                                                                                                                   // MakerGen.cs:403
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:507
