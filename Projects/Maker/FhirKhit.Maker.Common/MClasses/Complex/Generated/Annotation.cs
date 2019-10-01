using System;                                                                                                                               // MakerGen.cs:461
using System.Diagnostics;                                                                                                                   // MakerGen.cs:462
using System.IO;                                                                                                                            // MakerGen.cs:463
using System.Linq;                                                                                                                          // MakerGen.cs:464
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:465
                                                                                                                                            // MakerGen.cs:466
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:467
{                                                                                                                                           // MakerGen.cs:468
    #region Json                                                                                                                            // MakerGen.cs:469
    #if NEVER
    {
      "resourceType": "StructureDefinition",
      "id": "Annotation",
      "url": "http://hl7.org/fhir/StructureDefinition/Annotation",
      "version": "4.0.0",
      "name": "Annotation",
      "status": "active",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for Annotation Type: A  text note which also  contains information about who made the statement and when.",
      "fhirVersion": "4.0.0",
      "kind": "complex-type",
      "abstract": false,
      "type": "Annotation",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Annotation",
            "path": "Annotation",
            "short": "Text node with attribution",
            "definition": "A  text note which also  contains information about who made the statement and when.",
            "comment": "For systems that do not have structured annotations, they can simply communicate a single annotation with no author or time.  This element may need to be included in narrative because of the potential for modifying information.  *Annotations SHOULD NOT* be used to communicate \"modifying\" information that could be computable. (This is a SHOULD because enforcing user behavior is nearly impossible).",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Annotation.author[x]",
            "path": "Annotation.author[x]",
            "short": "Individual responsible for the annotation",
            "definition": "The individual responsible for making the annotation.",
            "comment": "Organization is used when there's no need for specific attribution as to who made the comment.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              },
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Annotation.time",
            "path": "Annotation.time",
            "short": "When the annotation was made",
            "definition": "Indicates when this particular annotation was made.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Annotation.text",
            "path": "Annotation.text",
            "short": "The annotation  - text content (as markdown)",
            "definition": "The text of the annotation in markdown format.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ],
            "isSummary": true
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:473
    /// <summary>
    /// Fhir complex 'Annotation'
    /// </summary>
    // 0. Annotation
    public class Annotation : FhirKhit.Maker.Common.Complex.ComplexBase                                                                     // MakerGen.cs:374
    {                                                                                                                                       // MakerGen.cs:375
        // 1. Annotation.author[x]
        public MakerElementInstance Element_Author;                                                                                         // MakerGen.cs:232
        // 2. Annotation.time
        public MakerElementInstance Element_Time;                                                                                           // MakerGen.cs:232
        // 3. Annotation.text
        public MakerElementInstance Element_Text;                                                                                           // MakerGen.cs:232
        public Annotation()                                                                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:243
                // 1. Annotation.author[x]
                this.Element_Author = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Author",                                                                                                // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Reference                                                                         // MakerGen.cs:335
                        {                                                                                                                   // MakerGen.cs:336
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:338
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                     // MakerGen.cs:338
                                "http://hl7.org/fhir/StructureDefinition/Patient",                                                          // MakerGen.cs:338
                                "http://hl7.org/fhir/StructureDefinition/RelatedPerson",                                                    // MakerGen.cs:338
                                "http://hl7.org/fhir/StructureDefinition/Organization"                                                      // MakerGen.cs:338
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        },                                                                                                                  // MakerGen.cs:339
                        new FhirKhit.Maker.Common.Primitive.String                                                                          // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 2. Annotation.time
                this.Element_Time = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Time",                                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.DateTime                                                                        // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 3. Annotation.text
                this.Element_Text = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Text",                                                                                                  // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Markdown                                                                        // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
        }                                                                                                                                   // MakerGen.cs:395
    }                                                                                                                                       // MakerGen.cs:379
}                                                                                                                                           // MakerGen.cs:478
