using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:381
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:382
{                                                                                                                                           // MakerGen.cs:383
    /// <summary>
    /// Fhir primitive 'Annotation'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "Annotation",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/Annotation",
    ///   "version": "4.0.0",
    ///   "name": "Annotation",
    ///   "status": "active",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for Annotation Type: A  text note which also  contains information about who made the statement and when.",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": false,
    ///   "type": "Annotation",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "Annotation",
    ///         "path": "Annotation",
    ///         "short": "Text node with attribution",
    ///         "definition": "A  text note which also  contains information about who made the statement and when.",
    ///         "comment": "For systems that do not have structured annotations, they can simply communicate a single annotation with no author or time.  This element may need to be included in narrative because of the potential for modifying information.  *Annotations SHOULD NOT* be used to communicate \"modifying\" information that could be computable. (This is a SHOULD because enforcing user behavior is nearly impossible).",
    ///         "min": 0,
    ///         "max": "*"
    ///       },
    ///       {
    ///         "id": "Annotation.author[x]",
    ///         "path": "Annotation.author[x]",
    ///         "short": "Individual responsible for the annotation",
    ///         "definition": "The individual responsible for making the annotation.",
    ///         "comment": "Organization is used when there's no need for specific attribution as to who made the comment.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "Reference",
    ///             "targetProfile": [
    ///               "http://hl7.org/fhir/StructureDefinition/Practitioner",
    ///               "http://hl7.org/fhir/StructureDefinition/Patient",
    ///               "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
    ///               "http://hl7.org/fhir/StructureDefinition/Organization"
    ///             ]
    ///           },
    ///           {
    ///             "code": "string"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Annotation.time",
    ///         "path": "Annotation.time",
    ///         "short": "When the annotation was made",
    ///         "definition": "Indicates when this particular annotation was made.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "dateTime"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "Annotation.text",
    ///         "path": "Annotation.text",
    ///         "short": "The annotation  - text content (as markdown)",
    ///         "definition": "The text of the annotation in markdown format.",
    ///         "min": 1,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "markdown"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    // 0. Annotation
    public class Annotation_Type : MakerComplex_Type                                                                                        // MakerGen.cs:337
    {                                                                                                                                       // MakerGen.cs:338
        // 1. Annotation.author[x]
        public MakerElementInstance Author;                                                                                                 // MakerGen.cs:217
        // 2. Annotation.time
        public MakerElementInstance Time;                                                                                                   // MakerGen.cs:217
        // 3. Annotation.text
        public MakerElementInstance Text;                                                                                                   // MakerGen.cs:217
        public Annotation_Type()                                                                                                            // MakerGen.cs:346
        {                                                                                                                                   // MakerGen.cs:347
            {                                                                                                                               // MakerGen.cs:228
                // 1. Annotation.author[x]
                this.Author = new MakerElementInstance                                                                                      // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Author",                                                                                                        // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new String_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 2. Annotation.time
                this.Time = new MakerElementInstance                                                                                        // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Time",                                                                                                          // MakerGen.cs:232
                    Min = 0,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new DateTime_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
            {                                                                                                                               // MakerGen.cs:228
                // 3. Annotation.text
                this.Text = new MakerElementInstance                                                                                        // MakerGen.cs:230
                {                                                                                                                           // MakerGen.cs:231
                    Name = "Text",                                                                                                          // MakerGen.cs:232
                    Min = 1,                                                                                                                // MakerGen.cs:233
                    Max = 1,                                                                                                                // MakerGen.cs:234
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:235
                    {                                                                                                                       // MakerGen.cs:236
                        new Markdown_Type()
                    }                                                                                                                       // MakerGen.cs:238
                };                                                                                                                          // MakerGen.cs:239
            }                                                                                                                               // MakerGen.cs:320
        }                                                                                                                                   // MakerGen.cs:358
    }                                                                                                                                       // MakerGen.cs:342
}                                                                                                                                           // MakerGen.cs:389
