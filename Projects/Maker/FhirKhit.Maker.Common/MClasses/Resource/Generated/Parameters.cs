using System;                                                                                                                               // MakerGen.cs:423
using System.Diagnostics;                                                                                                                   // MakerGen.cs:424
using System.IO;                                                                                                                            // MakerGen.cs:425
using System.Linq;                                                                                                                          // MakerGen.cs:426
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:427
                                                                                                                                            // MakerGen.cs:428
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:429
{                                                                                                                                           // MakerGen.cs:430
    #region Json                                                                                                                            // MakerGen.cs:431
    #if NEVER                                                                                                                               // MakerGen.cs:432
    {
      "resourceType": "StructureDefinition",
      "id": "Parameters",
      "url": "http://hl7.org/fhir/StructureDefinition/Parameters",
      "version": "4.0.0",
      "name": "Parameters",
      "status": "active",
      "publisher": "Health Level Seven International (FHIR Infrastructure)",
      "description": "This resource is a non-persisted resource used to pass information into and back from an [operation](operations.html). It has no other use, and there is no RESTful endpoint associated with it.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "Parameters",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Resource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Parameters",
            "path": "Parameters",
            "short": "Operation Request or Response",
            "definition": "This resource is a non-persisted resource used to pass information into and back from an [operation](operations.html). It has no other use, and there is no RESTful endpoint associated with it.",
            "comment": "The parameters that may be used are defined by the OperationDefinition resource.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Parameters.parameter",
            "path": "Parameters.parameter",
            "short": "Operation Parameter",
            "definition": "A parameter passed to or received from the operation.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Parameters.parameter.name",
            "path": "Parameters.parameter.name",
            "short": "Name from the definition",
            "definition": "The name of the parameter (reference to the operation definition).",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Parameters.parameter.value[x]",
            "path": "Parameters.parameter.value[x]",
            "short": "If parameter is a data type",
            "definition": "If the parameter is a data type.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "base64Binary"
              },
              {
                "code": "boolean"
              },
              {
                "code": "canonical"
              },
              {
                "code": "code"
              },
              {
                "code": "date"
              },
              {
                "code": "dateTime"
              },
              {
                "code": "decimal"
              },
              {
                "code": "id"
              },
              {
                "code": "instant"
              },
              {
                "code": "integer"
              },
              {
                "code": "markdown"
              },
              {
                "code": "oid"
              },
              {
                "code": "positiveInt"
              },
              {
                "code": "string"
              },
              {
                "code": "time"
              },
              {
                "code": "unsignedInt"
              },
              {
                "code": "uri"
              },
              {
                "code": "url"
              },
              {
                "code": "uuid"
              },
              {
                "code": "Address"
              },
              {
                "code": "Age"
              },
              {
                "code": "Annotation"
              },
              {
                "code": "Attachment"
              },
              {
                "code": "CodeableConcept"
              },
              {
                "code": "Coding"
              },
              {
                "code": "ContactPoint"
              },
              {
                "code": "Count"
              },
              {
                "code": "Distance"
              },
              {
                "code": "Duration"
              },
              {
                "code": "HumanName"
              },
              {
                "code": "Identifier"
              },
              {
                "code": "Money"
              },
              {
                "code": "Period"
              },
              {
                "code": "Quantity"
              },
              {
                "code": "Range"
              },
              {
                "code": "Ratio"
              },
              {
                "code": "Reference"
              },
              {
                "code": "SampledData"
              },
              {
                "code": "Signature"
              },
              {
                "code": "Timing"
              },
              {
                "code": "ContactDetail"
              },
              {
                "code": "Contributor"
              },
              {
                "code": "DataRequirement"
              },
              {
                "code": "Expression"
              },
              {
                "code": "ParameterDefinition"
              },
              {
                "code": "RelatedArtifact"
              },
              {
                "code": "TriggerDefinition"
              },
              {
                "code": "UsageContext"
              },
              {
                "code": "Dosage"
              }
            ],
            "condition": [
              "inv-1"
            ],
            "isSummary": true
          },
          {
            "id": "Parameters.parameter.resource",
            "path": "Parameters.parameter.resource",
            "short": "If parameter is a whole resource",
            "definition": "If the parameter is a whole resource.",
            "comment": "When resolving references in resources, the operation definition may specify how references may be resolved between parameters. If a reference cannot be resolved between the parameters, the application should fall back to it's general resource resolution methods.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Resource"
              }
            ],
            "condition": [
              "inv-1"
            ],
            "isSummary": true
          },
          {
            "id": "Parameters.parameter.part",
            "path": "Parameters.parameter.part",
            "short": "Named part of a multi-part parameter",
            "definition": "A named part of a multi-part parameter.",
            "comment": "Only one level of nested parameters is allowed.",
            "min": 0,
            "max": "*",
            "contentReference": "#Parameters.parameter",
            "isSummary": true
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:435
    /// <summary>
    /// Fhir resource 'Parameters'
    /// </summary>
    // 0. Parameters
    public class Parameters : FhirKhit.Maker.Common.Resource.ResourceBase                                                                   // MakerGen.cs:384
    {                                                                                                                                       // MakerGen.cs:385
        // 1. Parameters.parameter
        public class Type_Parameter : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:384
        {                                                                                                                                   // MakerGen.cs:385
            // 2. Parameters.parameter.name
            public MakerElementInstance Element_Name;                                                                                       // MakerGen.cs:232
            // 3. Parameters.parameter.value[x]
            public MakerElementInstance Element_Value;                                                                                      // MakerGen.cs:232
            // 4. Parameters.parameter.resource
            public MakerElementInstance Element_Resource;                                                                                   // MakerGen.cs:232
            // 5. Parameters.parameter.part
            public MakerElementInstance Element_Part;                                                                                       // MakerGen.cs:232
            public Type_Parameter()                                                                                                         // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:243
                    // 2. Parameters.parameter.name
                    this.Element_Name = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Name",                                                                                              // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:243
                    // 3. Parameters.parameter.value[x]
                    this.Element_Value = new MakerElementInstance                                                                           // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Value",                                                                                             // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Base64Binary                                                                // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            },                                                                                                              // MakerGen.cs:289
                            new FhirKhit.Maker.Common.Primitive.Boolean                                                                     // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            },                                                                                                              // MakerGen.cs:289
                            new FhirKhit.Maker.Common.Primitive.Canonical                                                                   // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            },                                                                                                              // MakerGen.cs:289
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            },                                                                                                              // MakerGen.cs:289
                            new FhirKhit.Maker.Common.Primitive.Date                                                                        // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            },                                                                                                              // MakerGen.cs:289
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            },                                                                                                              // MakerGen.cs:289
                            new FhirKhit.Maker.Common.Primitive.Decimal                                                                     // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            },                                                                                                              // MakerGen.cs:289
                            new FhirKhit.Maker.Common.Primitive.Id                                                                          // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            },                                                                                                              // MakerGen.cs:289
                            new FhirKhit.Maker.Common.Primitive.Instant                                                                     // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            },                                                                                                              // MakerGen.cs:289
                            new FhirKhit.Maker.Common.Primitive.Integer                                                                     // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            },                                                                                                              // MakerGen.cs:289
                            new FhirKhit.Maker.Common.Primitive.Markdown                                                                    // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            },                                                                                                              // MakerGen.cs:289
                            new FhirKhit.Maker.Common.Primitive.Oid                                                                         // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            },                                                                                                              // MakerGen.cs:289
                            new FhirKhit.Maker.Common.Primitive.PositiveInt                                                                 // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            },                                                                                                              // MakerGen.cs:289
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            },                                                                                                              // MakerGen.cs:289
                            new FhirKhit.Maker.Common.Primitive.Time                                                                        // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            },                                                                                                              // MakerGen.cs:289
                            new FhirKhit.Maker.Common.Primitive.UnsignedInt                                                                 // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            },                                                                                                              // MakerGen.cs:289
                            new FhirKhit.Maker.Common.Primitive.Uri                                                                         // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            },                                                                                                              // MakerGen.cs:289
                            new FhirKhit.Maker.Common.Primitive.Url                                                                         // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            },                                                                                                              // MakerGen.cs:289
                            new FhirKhit.Maker.Common.Primitive.Uuid                                                                        // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            },                                                                                                              // MakerGen.cs:289
                            new FhirKhit.Maker.Common.Complex.Address                                                                       // MakerGen.cs:343
                            {                                                                                                               // MakerGen.cs:344
                            },                                                                                                              // MakerGen.cs:345
                            new FhirKhit.Maker.Common.Complex.Age                                                                           // MakerGen.cs:343
                            {                                                                                                               // MakerGen.cs:344
                            },                                                                                                              // MakerGen.cs:345
                            new FhirKhit.Maker.Common.Complex.Annotation                                                                    // MakerGen.cs:343
                            {                                                                                                               // MakerGen.cs:344
                            },                                                                                                              // MakerGen.cs:345
                            new FhirKhit.Maker.Common.Complex.Attachment                                                                    // MakerGen.cs:343
                            {                                                                                                               // MakerGen.cs:344
                            },                                                                                                              // MakerGen.cs:345
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:297
                            {                                                                                                               // MakerGen.cs:298
                            },                                                                                                              // MakerGen.cs:299
                            new FhirKhit.Maker.Common.Complex.Coding                                                                        // MakerGen.cs:297
                            {                                                                                                               // MakerGen.cs:298
                            },                                                                                                              // MakerGen.cs:299
                            new FhirKhit.Maker.Common.Complex.ContactPoint                                                                  // MakerGen.cs:343
                            {                                                                                                               // MakerGen.cs:344
                            },                                                                                                              // MakerGen.cs:345
                            new FhirKhit.Maker.Common.Complex.Count                                                                         // MakerGen.cs:343
                            {                                                                                                               // MakerGen.cs:344
                            },                                                                                                              // MakerGen.cs:345
                            new FhirKhit.Maker.Common.Complex.Distance                                                                      // MakerGen.cs:343
                            {                                                                                                               // MakerGen.cs:344
                            },                                                                                                              // MakerGen.cs:345
                            new FhirKhit.Maker.Common.Complex.Duration                                                                      // MakerGen.cs:343
                            {                                                                                                               // MakerGen.cs:344
                            },                                                                                                              // MakerGen.cs:345
                            new FhirKhit.Maker.Common.Complex.HumanName                                                                     // MakerGen.cs:343
                            {                                                                                                               // MakerGen.cs:344
                            },                                                                                                              // MakerGen.cs:345
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:343
                            {                                                                                                               // MakerGen.cs:344
                            },                                                                                                              // MakerGen.cs:345
                            new FhirKhit.Maker.Common.Complex.Money                                                                         // MakerGen.cs:343
                            {                                                                                                               // MakerGen.cs:344
                            },                                                                                                              // MakerGen.cs:345
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:343
                            {                                                                                                               // MakerGen.cs:344
                            },                                                                                                              // MakerGen.cs:345
                            new FhirKhit.Maker.Common.Complex.Quantity                                                                      // MakerGen.cs:343
                            {                                                                                                               // MakerGen.cs:344
                            },                                                                                                              // MakerGen.cs:345
                            new FhirKhit.Maker.Common.Complex.Range                                                                         // MakerGen.cs:343
                            {                                                                                                               // MakerGen.cs:344
                            },                                                                                                              // MakerGen.cs:345
                            new FhirKhit.Maker.Common.Complex.Ratio                                                                         // MakerGen.cs:343
                            {                                                                                                               // MakerGen.cs:344
                            },                                                                                                              // MakerGen.cs:345
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            },                                                                                                              // MakerGen.cs:320
                            new FhirKhit.Maker.Common.Complex.SampledData                                                                   // MakerGen.cs:343
                            {                                                                                                               // MakerGen.cs:344
                            },                                                                                                              // MakerGen.cs:345
                            new FhirKhit.Maker.Common.Complex.Signature                                                                     // MakerGen.cs:343
                            {                                                                                                               // MakerGen.cs:344
                            },                                                                                                              // MakerGen.cs:345
                            new FhirKhit.Maker.Common.Complex.Timing                                                                        // MakerGen.cs:343
                            {                                                                                                               // MakerGen.cs:344
                            },                                                                                                              // MakerGen.cs:345
                            new FhirKhit.Maker.Common.Complex.ContactDetail                                                                 // MakerGen.cs:343
                            {                                                                                                               // MakerGen.cs:344
                            },                                                                                                              // MakerGen.cs:345
                            new FhirKhit.Maker.Common.Complex.Contributor                                                                   // MakerGen.cs:343
                            {                                                                                                               // MakerGen.cs:344
                            },                                                                                                              // MakerGen.cs:345
                            new FhirKhit.Maker.Common.Complex.DataRequirement                                                               // MakerGen.cs:343
                            {                                                                                                               // MakerGen.cs:344
                            },                                                                                                              // MakerGen.cs:345
                            new FhirKhit.Maker.Common.Complex.Expression                                                                    // MakerGen.cs:343
                            {                                                                                                               // MakerGen.cs:344
                            },                                                                                                              // MakerGen.cs:345
                            new FhirKhit.Maker.Common.Complex.ParameterDefinition                                                           // MakerGen.cs:343
                            {                                                                                                               // MakerGen.cs:344
                            },                                                                                                              // MakerGen.cs:345
                            new FhirKhit.Maker.Common.Complex.RelatedArtifact                                                               // MakerGen.cs:343
                            {                                                                                                               // MakerGen.cs:344
                            },                                                                                                              // MakerGen.cs:345
                            new FhirKhit.Maker.Common.Complex.TriggerDefinition                                                             // MakerGen.cs:343
                            {                                                                                                               // MakerGen.cs:344
                            },                                                                                                              // MakerGen.cs:345
                            new FhirKhit.Maker.Common.Complex.UsageContext                                                                  // MakerGen.cs:343
                            {                                                                                                               // MakerGen.cs:344
                            },                                                                                                              // MakerGen.cs:345
                            new FhirKhit.Maker.Common.Complex.Dosage                                                                        // MakerGen.cs:343
                            {                                                                                                               // MakerGen.cs:344
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:243
                    // 4. Parameters.parameter.resource
                    this.Element_Resource = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Resource",                                                                                          // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Resource.Resource                                                                     // MakerGen.cs:309
                            {                                                                                                               // MakerGen.cs:310
                            }                                                                                                               // MakerGen.cs:311
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:243
                    // 5. Parameters.parameter.part
                    this.Element_Part = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Part",                                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:389
        public Parameters()                                                                                                                 // MakerGen.cs:393
        {                                                                                                                                   // MakerGen.cs:394
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:389
}                                                                                                                                           // MakerGen.cs:440