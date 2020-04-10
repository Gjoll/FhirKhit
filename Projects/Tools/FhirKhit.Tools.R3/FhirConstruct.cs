using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using FhirKhit.Tools;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Model;
using System.Diagnostics;
using Hl7.FhirPath;
using Range = Hl7.Fhir.Model.Range;
using Eir.DevTools;
// FhirConstructGeneration.cs:370
namespace FhirKhit.Tools.R3
{                                                                                                                                           // FhirConstructGeneration.cs:376
    public static class FhirConstruct                                                                                                       // FhirConstructGeneration.cs:377
    {                                                                                                                                       // FhirConstructGeneration.cs:378
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,
            Element fix,                                                                                                                    // FhirConstructGeneration.cs:393
            String methodName,                                                                                                              // FhirConstructGeneration.cs:394
            out String propertyType,                                                                                                        // FhirConstructGeneration.cs:395
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:396
        {                                                                                                                                   // FhirConstructGeneration.cs:397
                                                                                                                                            // FhirConstructGeneration.cs:399
            propertyType = null;                                                                                                            // FhirConstructGeneration.cs:400
            switch (fix.TypeName)                                                                                                           // FhirConstructGeneration.cs:401
            {                                                                                                                               // FhirConstructGeneration.cs:402
                case "Address": // Address  - DataType                                                                                      // FhirConstructGeneration.cs:305
                {                                                                                                                           // FhirConstructGeneration.cs:306
                    propertyType = "Address";                                                                                               // FhirConstructGeneration.cs:307
                    return Construct(block, (Address)fix, methodName);                                                                      // FhirConstructGeneration.cs:308
                }                                                                                                                           // FhirConstructGeneration.cs:309
                                                                                                                                            // FhirConstructGeneration.cs:310
                case "Age": // Age  - DataType                                                                                              // FhirConstructGeneration.cs:305
                {                                                                                                                           // FhirConstructGeneration.cs:306
                    propertyType = "Age";                                                                                                   // FhirConstructGeneration.cs:307
                    return Construct(block, (Age)fix, methodName);                                                                          // FhirConstructGeneration.cs:308
                }                                                                                                                           // FhirConstructGeneration.cs:309
                                                                                                                                            // FhirConstructGeneration.cs:310
                case "Annotation": // Annotation  - DataType                                                                                // FhirConstructGeneration.cs:305
                {                                                                                                                           // FhirConstructGeneration.cs:306
                    propertyType = "Annotation";                                                                                            // FhirConstructGeneration.cs:307
                    return Construct(block, (Annotation)fix, methodName);                                                                   // FhirConstructGeneration.cs:308
                }                                                                                                                           // FhirConstructGeneration.cs:309
                                                                                                                                            // FhirConstructGeneration.cs:310
                case "Attachment": // Attachment  - DataType                                                                                // FhirConstructGeneration.cs:305
                {                                                                                                                           // FhirConstructGeneration.cs:306
                    propertyType = "Attachment";                                                                                            // FhirConstructGeneration.cs:307
                    return Construct(block, (Attachment)fix, methodName);                                                                   // FhirConstructGeneration.cs:308
                }                                                                                                                           // FhirConstructGeneration.cs:309
                                                                                                                                            // FhirConstructGeneration.cs:310
                case "CodeableConcept": // CodeableConcept  - DataType                                                                      // FhirConstructGeneration.cs:305
                {                                                                                                                           // FhirConstructGeneration.cs:306
                    propertyType = "CodeableConcept";                                                                                       // FhirConstructGeneration.cs:307
                    return Construct(block, (CodeableConcept)fix, methodName);                                                              // FhirConstructGeneration.cs:308
                }                                                                                                                           // FhirConstructGeneration.cs:309
                                                                                                                                            // FhirConstructGeneration.cs:310
                case "Coding": // Coding  - DataType                                                                                        // FhirConstructGeneration.cs:305
                {                                                                                                                           // FhirConstructGeneration.cs:306
                    propertyType = "Coding";                                                                                                // FhirConstructGeneration.cs:307
                    return Construct(block, (Coding)fix, methodName);                                                                       // FhirConstructGeneration.cs:308
                }                                                                                                                           // FhirConstructGeneration.cs:309
                                                                                                                                            // FhirConstructGeneration.cs:310
                case "ContactDetail": // ContactDetail  - DataType                                                                          // FhirConstructGeneration.cs:305
                {                                                                                                                           // FhirConstructGeneration.cs:306
                    propertyType = "ContactDetail";                                                                                         // FhirConstructGeneration.cs:307
                    return Construct(block, (ContactDetail)fix, methodName);                                                                // FhirConstructGeneration.cs:308
                }                                                                                                                           // FhirConstructGeneration.cs:309
                                                                                                                                            // FhirConstructGeneration.cs:310
                case "ContactPoint": // ContactPoint  - DataType                                                                            // FhirConstructGeneration.cs:305
                {                                                                                                                           // FhirConstructGeneration.cs:306
                    propertyType = "ContactPoint";                                                                                          // FhirConstructGeneration.cs:307
                    return Construct(block, (ContactPoint)fix, methodName);                                                                 // FhirConstructGeneration.cs:308
                }                                                                                                                           // FhirConstructGeneration.cs:309
                                                                                                                                            // FhirConstructGeneration.cs:310
                case "Contributor": // Contributor  - DataType                                                                              // FhirConstructGeneration.cs:305
                {                                                                                                                           // FhirConstructGeneration.cs:306
                    propertyType = "Contributor";                                                                                           // FhirConstructGeneration.cs:307
                    return Construct(block, (Contributor)fix, methodName);                                                                  // FhirConstructGeneration.cs:308
                }                                                                                                                           // FhirConstructGeneration.cs:309
                                                                                                                                            // FhirConstructGeneration.cs:310
                case "Count": // Count  - DataType                                                                                          // FhirConstructGeneration.cs:305
                {                                                                                                                           // FhirConstructGeneration.cs:306
                    propertyType = "Count";                                                                                                 // FhirConstructGeneration.cs:307
                    return Construct(block, (Count)fix, methodName);                                                                        // FhirConstructGeneration.cs:308
                }                                                                                                                           // FhirConstructGeneration.cs:309
                                                                                                                                            // FhirConstructGeneration.cs:310
                case "DataRequirement": // DataRequirement  - DataType                                                                      // FhirConstructGeneration.cs:305
                {                                                                                                                           // FhirConstructGeneration.cs:306
                    propertyType = "DataRequirement";                                                                                       // FhirConstructGeneration.cs:307
                    return Construct(block, (DataRequirement)fix, methodName);                                                              // FhirConstructGeneration.cs:308
                }                                                                                                                           // FhirConstructGeneration.cs:309
                                                                                                                                            // FhirConstructGeneration.cs:310
                case "Distance": // Distance  - DataType                                                                                    // FhirConstructGeneration.cs:305
                {                                                                                                                           // FhirConstructGeneration.cs:306
                    propertyType = "Distance";                                                                                              // FhirConstructGeneration.cs:307
                    return Construct(block, (Distance)fix, methodName);                                                                     // FhirConstructGeneration.cs:308
                }                                                                                                                           // FhirConstructGeneration.cs:309
                                                                                                                                            // FhirConstructGeneration.cs:310
                case "Dosage": // Dosage  - DataType                                                                                        // FhirConstructGeneration.cs:305
                {                                                                                                                           // FhirConstructGeneration.cs:306
                    propertyType = "Dosage";                                                                                                // FhirConstructGeneration.cs:307
                    return Construct(block, (Dosage)fix, methodName);                                                                       // FhirConstructGeneration.cs:308
                }                                                                                                                           // FhirConstructGeneration.cs:309
                                                                                                                                            // FhirConstructGeneration.cs:310
                case "Duration": // Duration  - DataType                                                                                    // FhirConstructGeneration.cs:305
                {                                                                                                                           // FhirConstructGeneration.cs:306
                    propertyType = "Duration";                                                                                              // FhirConstructGeneration.cs:307
                    return Construct(block, (Duration)fix, methodName);                                                                     // FhirConstructGeneration.cs:308
                }                                                                                                                           // FhirConstructGeneration.cs:309
                                                                                                                                            // FhirConstructGeneration.cs:310
                case "ElementDefinition": // ElementDefinition  - DataType                                                                  // FhirConstructGeneration.cs:305
                {                                                                                                                           // FhirConstructGeneration.cs:306
                    propertyType = "ElementDefinition";                                                                                     // FhirConstructGeneration.cs:307
                    return Construct(block, (ElementDefinition)fix, methodName);                                                            // FhirConstructGeneration.cs:308
                }                                                                                                                           // FhirConstructGeneration.cs:309
                                                                                                                                            // FhirConstructGeneration.cs:310
                case "Extension": // Extension  - DataType                                                                                  // FhirConstructGeneration.cs:305
                {                                                                                                                           // FhirConstructGeneration.cs:306
                    propertyType = "Extension";                                                                                             // FhirConstructGeneration.cs:307
                    return Construct(block, (Extension)fix, methodName);                                                                    // FhirConstructGeneration.cs:308
                }                                                                                                                           // FhirConstructGeneration.cs:309
                                                                                                                                            // FhirConstructGeneration.cs:310
                case "HumanName": // HumanName  - DataType                                                                                  // FhirConstructGeneration.cs:305
                {                                                                                                                           // FhirConstructGeneration.cs:306
                    propertyType = "HumanName";                                                                                             // FhirConstructGeneration.cs:307
                    return Construct(block, (HumanName)fix, methodName);                                                                    // FhirConstructGeneration.cs:308
                }                                                                                                                           // FhirConstructGeneration.cs:309
                                                                                                                                            // FhirConstructGeneration.cs:310
                case "Identifier": // Identifier  - DataType                                                                                // FhirConstructGeneration.cs:305
                {                                                                                                                           // FhirConstructGeneration.cs:306
                    propertyType = "Identifier";                                                                                            // FhirConstructGeneration.cs:307
                    return Construct(block, (Identifier)fix, methodName);                                                                   // FhirConstructGeneration.cs:308
                }                                                                                                                           // FhirConstructGeneration.cs:309
                                                                                                                                            // FhirConstructGeneration.cs:310
                case "Meta": // Meta  - DataType                                                                                            // FhirConstructGeneration.cs:305
                {                                                                                                                           // FhirConstructGeneration.cs:306
                    propertyType = "Meta";                                                                                                  // FhirConstructGeneration.cs:307
                    return Construct(block, (Meta)fix, methodName);                                                                         // FhirConstructGeneration.cs:308
                }                                                                                                                           // FhirConstructGeneration.cs:309
                                                                                                                                            // FhirConstructGeneration.cs:310
                case "Money": // Money  - DataType                                                                                          // FhirConstructGeneration.cs:305
                {                                                                                                                           // FhirConstructGeneration.cs:306
                    propertyType = "Money";                                                                                                 // FhirConstructGeneration.cs:307
                    return Construct(block, (Money)fix, methodName);                                                                        // FhirConstructGeneration.cs:308
                }                                                                                                                           // FhirConstructGeneration.cs:309
                                                                                                                                            // FhirConstructGeneration.cs:310
                case "Narrative": // Narrative  - DataType                                                                                  // FhirConstructGeneration.cs:305
                {                                                                                                                           // FhirConstructGeneration.cs:306
                    propertyType = "Narrative";                                                                                             // FhirConstructGeneration.cs:307
                    return Construct(block, (Narrative)fix, methodName);                                                                    // FhirConstructGeneration.cs:308
                }                                                                                                                           // FhirConstructGeneration.cs:309
                                                                                                                                            // FhirConstructGeneration.cs:310
                case "ParameterDefinition": // ParameterDefinition  - DataType                                                              // FhirConstructGeneration.cs:305
                {                                                                                                                           // FhirConstructGeneration.cs:306
                    propertyType = "ParameterDefinition";                                                                                   // FhirConstructGeneration.cs:307
                    return Construct(block, (ParameterDefinition)fix, methodName);                                                          // FhirConstructGeneration.cs:308
                }                                                                                                                           // FhirConstructGeneration.cs:309
                                                                                                                                            // FhirConstructGeneration.cs:310
                case "Period": // Period  - DataType                                                                                        // FhirConstructGeneration.cs:305
                {                                                                                                                           // FhirConstructGeneration.cs:306
                    propertyType = "Period";                                                                                                // FhirConstructGeneration.cs:307
                    return Construct(block, (Period)fix, methodName);                                                                       // FhirConstructGeneration.cs:308
                }                                                                                                                           // FhirConstructGeneration.cs:309
                                                                                                                                            // FhirConstructGeneration.cs:310
                case "Quantity": // Quantity  - DataType                                                                                    // FhirConstructGeneration.cs:305
                {                                                                                                                           // FhirConstructGeneration.cs:306
                    propertyType = "Quantity";                                                                                              // FhirConstructGeneration.cs:307
                    return Construct(block, (Quantity)fix, methodName);                                                                     // FhirConstructGeneration.cs:308
                }                                                                                                                           // FhirConstructGeneration.cs:309
                                                                                                                                            // FhirConstructGeneration.cs:310
                case "Range": // Range  - DataType                                                                                          // FhirConstructGeneration.cs:305
                {                                                                                                                           // FhirConstructGeneration.cs:306
                    propertyType = "Range";                                                                                                 // FhirConstructGeneration.cs:307
                    return Construct(block, (Range)fix, methodName);                                                                        // FhirConstructGeneration.cs:308
                }                                                                                                                           // FhirConstructGeneration.cs:309
                                                                                                                                            // FhirConstructGeneration.cs:310
                case "Ratio": // Ratio  - DataType                                                                                          // FhirConstructGeneration.cs:305
                {                                                                                                                           // FhirConstructGeneration.cs:306
                    propertyType = "Ratio";                                                                                                 // FhirConstructGeneration.cs:307
                    return Construct(block, (Ratio)fix, methodName);                                                                        // FhirConstructGeneration.cs:308
                }                                                                                                                           // FhirConstructGeneration.cs:309
                                                                                                                                            // FhirConstructGeneration.cs:310
                case "Reference": // Reference  - DataType                                                                                  // FhirConstructGeneration.cs:305
                {                                                                                                                           // FhirConstructGeneration.cs:306
                    propertyType = "Reference";                                                                                             // FhirConstructGeneration.cs:307
                    return Construct(block, (ResourceReference)fix, methodName);                                                            // FhirConstructGeneration.cs:308
                }                                                                                                                           // FhirConstructGeneration.cs:309
                                                                                                                                            // FhirConstructGeneration.cs:310
                case "RelatedArtifact": // RelatedArtifact  - DataType                                                                      // FhirConstructGeneration.cs:305
                {                                                                                                                           // FhirConstructGeneration.cs:306
                    propertyType = "RelatedArtifact";                                                                                       // FhirConstructGeneration.cs:307
                    return Construct(block, (RelatedArtifact)fix, methodName);                                                              // FhirConstructGeneration.cs:308
                }                                                                                                                           // FhirConstructGeneration.cs:309
                                                                                                                                            // FhirConstructGeneration.cs:310
                case "SampledData": // SampledData  - DataType                                                                              // FhirConstructGeneration.cs:305
                {                                                                                                                           // FhirConstructGeneration.cs:306
                    propertyType = "SampledData";                                                                                           // FhirConstructGeneration.cs:307
                    return Construct(block, (SampledData)fix, methodName);                                                                  // FhirConstructGeneration.cs:308
                }                                                                                                                           // FhirConstructGeneration.cs:309
                                                                                                                                            // FhirConstructGeneration.cs:310
                case "Signature": // Signature  - DataType                                                                                  // FhirConstructGeneration.cs:305
                {                                                                                                                           // FhirConstructGeneration.cs:306
                    propertyType = "Signature";                                                                                             // FhirConstructGeneration.cs:307
                    return Construct(block, (Signature)fix, methodName);                                                                    // FhirConstructGeneration.cs:308
                }                                                                                                                           // FhirConstructGeneration.cs:309
                                                                                                                                            // FhirConstructGeneration.cs:310
                case "SimpleQuantity": // SimpleQuantity  - DataType                                                                        // FhirConstructGeneration.cs:305
                {                                                                                                                           // FhirConstructGeneration.cs:306
                    propertyType = "SimpleQuantity";                                                                                        // FhirConstructGeneration.cs:307
                    return Construct(block, (SimpleQuantity)fix, methodName);                                                               // FhirConstructGeneration.cs:308
                }                                                                                                                           // FhirConstructGeneration.cs:309
                                                                                                                                            // FhirConstructGeneration.cs:310
                case "Timing": // Timing  - DataType                                                                                        // FhirConstructGeneration.cs:305
                {                                                                                                                           // FhirConstructGeneration.cs:306
                    propertyType = "Timing";                                                                                                // FhirConstructGeneration.cs:307
                    return Construct(block, (Timing)fix, methodName);                                                                       // FhirConstructGeneration.cs:308
                }                                                                                                                           // FhirConstructGeneration.cs:309
                                                                                                                                            // FhirConstructGeneration.cs:310
                case "TriggerDefinition": // TriggerDefinition  - DataType                                                                  // FhirConstructGeneration.cs:305
                {                                                                                                                           // FhirConstructGeneration.cs:306
                    propertyType = "TriggerDefinition";                                                                                     // FhirConstructGeneration.cs:307
                    return Construct(block, (TriggerDefinition)fix, methodName);                                                            // FhirConstructGeneration.cs:308
                }                                                                                                                           // FhirConstructGeneration.cs:309
                                                                                                                                            // FhirConstructGeneration.cs:310
                case "UsageContext": // UsageContext  - DataType                                                                            // FhirConstructGeneration.cs:305
                {                                                                                                                           // FhirConstructGeneration.cs:306
                    propertyType = "UsageContext";                                                                                          // FhirConstructGeneration.cs:307
                    return Construct(block, (UsageContext)fix, methodName);                                                                 // FhirConstructGeneration.cs:308
                }                                                                                                                           // FhirConstructGeneration.cs:309
                                                                                                                                            // FhirConstructGeneration.cs:310
                case "base64Binary": // Base64Binary  - primitive                                                                           // FhirConstructGeneration.cs:237
                {                                                                                                                           // FhirConstructGeneration.cs:238
                    propertyType = "base64Binary";                                                                                          // FhirConstructGeneration.cs:239
                    return Construct(block, (Base64Binary)fix, methodName, methodAccess);                                                   // FhirConstructGeneration.cs:240
                }                                                                                                                           // FhirConstructGeneration.cs:241
                                                                                                                                            // FhirConstructGeneration.cs:242
                case "boolean": // Boolean  - primitive                                                                                     // FhirConstructGeneration.cs:237
                {                                                                                                                           // FhirConstructGeneration.cs:238
                    propertyType = "boolean";                                                                                               // FhirConstructGeneration.cs:239
                    return Construct(block, (FhirBoolean)fix, methodName, methodAccess);                                                    // FhirConstructGeneration.cs:240
                }                                                                                                                           // FhirConstructGeneration.cs:241
                                                                                                                                            // FhirConstructGeneration.cs:242
                case "code": // Code  - primitive                                                                                           // FhirConstructGeneration.cs:237
                {                                                                                                                           // FhirConstructGeneration.cs:238
                    propertyType = "code";                                                                                                  // FhirConstructGeneration.cs:239
                    return Construct(block, (Code)fix, methodName, methodAccess);                                                           // FhirConstructGeneration.cs:240
                }                                                                                                                           // FhirConstructGeneration.cs:241
                                                                                                                                            // FhirConstructGeneration.cs:242
                case "date": // Date  - primitive                                                                                           // FhirConstructGeneration.cs:237
                {                                                                                                                           // FhirConstructGeneration.cs:238
                    propertyType = "date";                                                                                                  // FhirConstructGeneration.cs:239
                    return Construct(block, (Date)fix, methodName, methodAccess);                                                           // FhirConstructGeneration.cs:240
                }                                                                                                                           // FhirConstructGeneration.cs:241
                                                                                                                                            // FhirConstructGeneration.cs:242
                case "dateTime": // DateTime  - primitive                                                                                   // FhirConstructGeneration.cs:237
                {                                                                                                                           // FhirConstructGeneration.cs:238
                    propertyType = "dateTime";                                                                                              // FhirConstructGeneration.cs:239
                    return Construct(block, (FhirDateTime)fix, methodName, methodAccess);                                                   // FhirConstructGeneration.cs:240
                }                                                                                                                           // FhirConstructGeneration.cs:241
                                                                                                                                            // FhirConstructGeneration.cs:242
                case "decimal": // Decimal  - primitive                                                                                     // FhirConstructGeneration.cs:237
                {                                                                                                                           // FhirConstructGeneration.cs:238
                    propertyType = "decimal";                                                                                               // FhirConstructGeneration.cs:239
                    return Construct(block, (FhirDecimal)fix, methodName, methodAccess);                                                    // FhirConstructGeneration.cs:240
                }                                                                                                                           // FhirConstructGeneration.cs:241
                                                                                                                                            // FhirConstructGeneration.cs:242
                case "id": // Id  - primitive                                                                                               // FhirConstructGeneration.cs:237
                {                                                                                                                           // FhirConstructGeneration.cs:238
                    propertyType = "id";                                                                                                    // FhirConstructGeneration.cs:239
                    return Construct(block, (Id)fix, methodName, methodAccess);                                                             // FhirConstructGeneration.cs:240
                }                                                                                                                           // FhirConstructGeneration.cs:241
                                                                                                                                            // FhirConstructGeneration.cs:242
                case "instant": // Instant  - primitive                                                                                     // FhirConstructGeneration.cs:237
                {                                                                                                                           // FhirConstructGeneration.cs:238
                    propertyType = "instant";                                                                                               // FhirConstructGeneration.cs:239
                    return Construct(block, (Instant)fix, methodName, methodAccess);                                                        // FhirConstructGeneration.cs:240
                }                                                                                                                           // FhirConstructGeneration.cs:241
                                                                                                                                            // FhirConstructGeneration.cs:242
                case "integer": // Integer  - primitive                                                                                     // FhirConstructGeneration.cs:237
                {                                                                                                                           // FhirConstructGeneration.cs:238
                    propertyType = "integer";                                                                                               // FhirConstructGeneration.cs:239
                    return Construct(block, (Integer)fix, methodName, methodAccess);                                                        // FhirConstructGeneration.cs:240
                }                                                                                                                           // FhirConstructGeneration.cs:241
                                                                                                                                            // FhirConstructGeneration.cs:242
                case "markdown": // Markdown  - primitive                                                                                   // FhirConstructGeneration.cs:237
                {                                                                                                                           // FhirConstructGeneration.cs:238
                    propertyType = "markdown";                                                                                              // FhirConstructGeneration.cs:239
                    return Construct(block, (Markdown)fix, methodName, methodAccess);                                                       // FhirConstructGeneration.cs:240
                }                                                                                                                           // FhirConstructGeneration.cs:241
                                                                                                                                            // FhirConstructGeneration.cs:242
                case "oid": // Oid  - primitive                                                                                             // FhirConstructGeneration.cs:237
                {                                                                                                                           // FhirConstructGeneration.cs:238
                    propertyType = "oid";                                                                                                   // FhirConstructGeneration.cs:239
                    return Construct(block, (Oid)fix, methodName, methodAccess);                                                            // FhirConstructGeneration.cs:240
                }                                                                                                                           // FhirConstructGeneration.cs:241
                                                                                                                                            // FhirConstructGeneration.cs:242
                case "positiveInt": // PositiveInt  - primitive                                                                             // FhirConstructGeneration.cs:237
                {                                                                                                                           // FhirConstructGeneration.cs:238
                    propertyType = "positiveInt";                                                                                           // FhirConstructGeneration.cs:239
                    return Construct(block, (PositiveInt)fix, methodName, methodAccess);                                                    // FhirConstructGeneration.cs:240
                }                                                                                                                           // FhirConstructGeneration.cs:241
                                                                                                                                            // FhirConstructGeneration.cs:242
                case "string": // String  - primitive                                                                                       // FhirConstructGeneration.cs:237
                {                                                                                                                           // FhirConstructGeneration.cs:238
                    propertyType = "string";                                                                                                // FhirConstructGeneration.cs:239
                    return Construct(block, (FhirString)fix, methodName, methodAccess);                                                     // FhirConstructGeneration.cs:240
                }                                                                                                                           // FhirConstructGeneration.cs:241
                                                                                                                                            // FhirConstructGeneration.cs:242
                case "time": // Time  - primitive                                                                                           // FhirConstructGeneration.cs:237
                {                                                                                                                           // FhirConstructGeneration.cs:238
                    propertyType = "time";                                                                                                  // FhirConstructGeneration.cs:239
                    return Construct(block, (Time)fix, methodName, methodAccess);                                                           // FhirConstructGeneration.cs:240
                }                                                                                                                           // FhirConstructGeneration.cs:241
                                                                                                                                            // FhirConstructGeneration.cs:242
                case "unsignedInt": // UnsignedInt  - primitive                                                                             // FhirConstructGeneration.cs:237
                {                                                                                                                           // FhirConstructGeneration.cs:238
                    propertyType = "unsignedInt";                                                                                           // FhirConstructGeneration.cs:239
                    return Construct(block, (UnsignedInt)fix, methodName, methodAccess);                                                    // FhirConstructGeneration.cs:240
                }                                                                                                                           // FhirConstructGeneration.cs:241
                                                                                                                                            // FhirConstructGeneration.cs:242
                case "uri": // Uri  - primitive                                                                                             // FhirConstructGeneration.cs:237
                {                                                                                                                           // FhirConstructGeneration.cs:238
                    propertyType = "uri";                                                                                                   // FhirConstructGeneration.cs:239
                    return Construct(block, (FhirUri)fix, methodName, methodAccess);                                                        // FhirConstructGeneration.cs:240
                }                                                                                                                           // FhirConstructGeneration.cs:241
                                                                                                                                            // FhirConstructGeneration.cs:242
                case "uuid": // Uuid  - primitive                                                                                           // FhirConstructGeneration.cs:237
                {                                                                                                                           // FhirConstructGeneration.cs:238
                    propertyType = "uuid";                                                                                                  // FhirConstructGeneration.cs:239
                    return Construct(block, (Uuid)fix, methodName, methodAccess);                                                           // FhirConstructGeneration.cs:240
                }                                                                                                                           // FhirConstructGeneration.cs:241
                                                                                                                                            // FhirConstructGeneration.cs:242
                case "xhtml": // Xhtml  - primitive                                                                                         // FhirConstructGeneration.cs:237
                {                                                                                                                           // FhirConstructGeneration.cs:238
                    propertyType = "xhtml";                                                                                                 // FhirConstructGeneration.cs:239
                    return Construct(block, (XHtml)fix, methodName, methodAccess);                                                          // FhirConstructGeneration.cs:240
                }                                                                                                                           // FhirConstructGeneration.cs:241
                                                                                                                                            // FhirConstructGeneration.cs:242
            }                                                                                                                               // FhirConstructGeneration.cs:416
            return false;                                                                                                                   // FhirConstructGeneration.cs:417
        }                                                                                                                                   // FhirConstructGeneration.cs:418
                                                                                                                                            // FhirConstructGeneration.cs:315
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:319
            Address fix,                                                                                                                    // FhirConstructGeneration.cs:320
            String methodName,                                                                                                              // FhirConstructGeneration.cs:321
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:322
        {                                                                                                                                   // FhirConstructGeneration.cs:323
                                                                                                                                            // FhirConstructGeneration.cs:325
            block                                                                                                                           // FhirConstructGeneration.cs:326
                .AppendCode($"{methodAccess} Address {methodName}()")                                                                       // FhirConstructGeneration.cs:327
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:328
                .AppendCode("Address retVal = new Address();")                                                                              // FhirConstructGeneration.cs:329
                ;                                                                                                                           // FhirConstructGeneration.cs:330
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:331
            {                                                                                                                               // FhirConstructGeneration.cs:332
                if (fix.UseElement != null)                                                                                                 // FhirConstructGeneration.cs:147
                    block.AppendCode($"retVal.UseElement = new Code<Address.AddressUse>(Address.AddressUse.{fix.UseElement.Value});");      // FhirConstructGeneration.cs:148
                if (fix.TypeElement != null)                                                                                                // FhirConstructGeneration.cs:147
                    block.AppendCode($"retVal.TypeElement = new Code<Address.AddressType>(Address.AddressType.{fix.TypeElement.Value});");  // FhirConstructGeneration.cs:148
                if (fix.TextElement != null)                                                                                                // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.TextElement = new FhirString();");                                                        // FhirConstructGeneration.cs:209
                    if (fix.TextElement.Value != null)                                                                                      // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.TextElement.Value = \"{fix.TextElement.Value}\";");                                       // FhirConstructGeneration.cs:138
                    if (fix.TextElement.ElementId != null)                                                                                  // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.TextElement.ElementId = \"{fix.TextElement.ElementId}\";");                               // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.LineElement != null)                                                                                                // FhirConstructGeneration.cs:159
                {                                                                                                                           // FhirConstructGeneration.cs:160
                    block.AppendCode($"retVal.LineElement = new List<FhirString>();");                                                      // FhirConstructGeneration.cs:161
                    foreach (var temp1 in fix.LineElement)                                                                                  // FhirConstructGeneration.cs:162
                    {                                                                                                                       // FhirConstructGeneration.cs:163
                        block.OpenBrace();                                                                                                  // FhirConstructGeneration.cs:164
                        block.AppendCode("var temp2 = new FhirString();");                                                                  // FhirConstructGeneration.cs:165
                        if (temp1.Value != null)                                                                                            // FhirConstructGeneration.cs:137
                            block.AppendCode($"temp2.Value = \"{temp1.Value}\";");                                                          // FhirConstructGeneration.cs:138
                        if (temp1.ElementId != null)                                                                                        // FhirConstructGeneration.cs:137
                            block.AppendCode($"temp2.ElementId = \"{temp1.ElementId}\";");                                                  // FhirConstructGeneration.cs:138
                        block.AppendCode($"retVal.LineElement.Add(temp2);");                                                                // FhirConstructGeneration.cs:171
                        block.CloseBrace();                                                                                                 // FhirConstructGeneration.cs:172
                    }                                                                                                                       // FhirConstructGeneration.cs:173
                }                                                                                                                           // FhirConstructGeneration.cs:174
                if (fix.CityElement != null)                                                                                                // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.CityElement = new FhirString();");                                                        // FhirConstructGeneration.cs:209
                    if (fix.CityElement.Value != null)                                                                                      // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.CityElement.Value = \"{fix.CityElement.Value}\";");                                       // FhirConstructGeneration.cs:138
                    if (fix.CityElement.ElementId != null)                                                                                  // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.CityElement.ElementId = \"{fix.CityElement.ElementId}\";");                               // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.DistrictElement != null)                                                                                            // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.DistrictElement = new FhirString();");                                                    // FhirConstructGeneration.cs:209
                    if (fix.DistrictElement.Value != null)                                                                                  // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.DistrictElement.Value = \"{fix.DistrictElement.Value}\";");                               // FhirConstructGeneration.cs:138
                    if (fix.DistrictElement.ElementId != null)                                                                              // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.DistrictElement.ElementId = \"{fix.DistrictElement.ElementId}\";");                       // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.StateElement != null)                                                                                               // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.StateElement = new FhirString();");                                                       // FhirConstructGeneration.cs:209
                    if (fix.StateElement.Value != null)                                                                                     // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.StateElement.Value = \"{fix.StateElement.Value}\";");                                     // FhirConstructGeneration.cs:138
                    if (fix.StateElement.ElementId != null)                                                                                 // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.StateElement.ElementId = \"{fix.StateElement.ElementId}\";");                             // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.PostalCodeElement != null)                                                                                          // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.PostalCodeElement = new FhirString();");                                                  // FhirConstructGeneration.cs:209
                    if (fix.PostalCodeElement.Value != null)                                                                                // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.PostalCodeElement.Value = \"{fix.PostalCodeElement.Value}\";");                           // FhirConstructGeneration.cs:138
                    if (fix.PostalCodeElement.ElementId != null)                                                                            // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.PostalCodeElement.ElementId = \"{fix.PostalCodeElement.ElementId}\";");                   // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.CountryElement != null)                                                                                             // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.CountryElement = new FhirString();");                                                     // FhirConstructGeneration.cs:209
                    if (fix.CountryElement.Value != null)                                                                                   // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.CountryElement.Value = \"{fix.CountryElement.Value}\";");                                 // FhirConstructGeneration.cs:138
                    if (fix.CountryElement.ElementId != null)                                                                               // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.CountryElement.ElementId = \"{fix.CountryElement.ElementId}\";");                         // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.Period != null)                                                                                                     // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.Period = new Period();");                                                                 // FhirConstructGeneration.cs:209
                    if (fix.Period.StartElement != null)                                                                                    // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Period.StartElement = new FhirDateTime();");                                          // FhirConstructGeneration.cs:209
                        if (fix.Period.StartElement.Value != null)                                                                          // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Period.StartElement.Value = \"{fix.Period.StartElement.Value}\";");                   // FhirConstructGeneration.cs:138
                        if (fix.Period.StartElement.ElementId != null)                                                                      // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Period.StartElement.ElementId = \"{fix.Period.StartElement.ElementId}\";");           // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Period.EndElement != null)                                                                                      // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Period.EndElement = new FhirDateTime();");                                            // FhirConstructGeneration.cs:209
                        if (fix.Period.EndElement.Value != null)                                                                            // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Period.EndElement.Value = \"{fix.Period.EndElement.Value}\";");                       // FhirConstructGeneration.cs:138
                        if (fix.Period.EndElement.ElementId != null)                                                                        // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Period.EndElement.ElementId = \"{fix.Period.EndElement.ElementId}\";");               // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Period.ElementId != null)                                                                                       // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.Period.ElementId = \"{fix.Period.ElementId}\";");                                         // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:338
            block                                                                                                                           // FhirConstructGeneration.cs:339
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:340
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:341
                ;                                                                                                                           // FhirConstructGeneration.cs:342
            return  true;                                                                                                                   // FhirConstructGeneration.cs:343
        }                                                                                                                                   // FhirConstructGeneration.cs:344
                                                                                                                                            // FhirConstructGeneration.cs:315
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:319
            Age fix,                                                                                                                        // FhirConstructGeneration.cs:320
            String methodName,                                                                                                              // FhirConstructGeneration.cs:321
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:322
        {                                                                                                                                   // FhirConstructGeneration.cs:323
                                                                                                                                            // FhirConstructGeneration.cs:325
            block                                                                                                                           // FhirConstructGeneration.cs:326
                .AppendCode($"{methodAccess} Age {methodName}()")                                                                           // FhirConstructGeneration.cs:327
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:328
                .AppendCode("Age retVal = new Age();")                                                                                      // FhirConstructGeneration.cs:329
                ;                                                                                                                           // FhirConstructGeneration.cs:330
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:331
            {                                                                                                                               // FhirConstructGeneration.cs:332
                if (fix.ValueElement != null)                                                                                               // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.ValueElement = new FhirDecimal();");                                                      // FhirConstructGeneration.cs:209
                    if (fix.ValueElement.Value.HasValue == true)                                                                            // FhirConstructGeneration.cs:123
                        block.AppendCode($"retVal.ValueElement.Value = new Nullable<decimal>((decimal) {fix.ValueElement.Value.Value});");  // FhirConstructGeneration.cs:124
                    if (fix.ValueElement.ElementId != null)                                                                                 // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.ValueElement.ElementId = \"{fix.ValueElement.ElementId}\";");                             // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.ComparatorElement != null)                                                                                          // FhirConstructGeneration.cs:147
                    block.AppendCode($"retVal.ComparatorElement = new Code<Quantity.QuantityComparator>(Quantity.QuantityComparator.{fix.ComparatorElement.Value});");// FhirConstructGeneration.cs:148
                if (fix.UnitElement != null)                                                                                                // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.UnitElement = new FhirString();");                                                        // FhirConstructGeneration.cs:209
                    if (fix.UnitElement.Value != null)                                                                                      // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.UnitElement.Value = \"{fix.UnitElement.Value}\";");                                       // FhirConstructGeneration.cs:138
                    if (fix.UnitElement.ElementId != null)                                                                                  // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.UnitElement.ElementId = \"{fix.UnitElement.ElementId}\";");                               // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.SystemElement != null)                                                                                              // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.SystemElement = new FhirUri();");                                                         // FhirConstructGeneration.cs:209
                    if (fix.SystemElement.Value != null)                                                                                    // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.SystemElement.Value = \"{fix.SystemElement.Value}\";");                                   // FhirConstructGeneration.cs:138
                    if (fix.SystemElement.ElementId != null)                                                                                // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.SystemElement.ElementId = \"{fix.SystemElement.ElementId}\";");                           // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.CodeElement != null)                                                                                                // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.CodeElement = new Code();");                                                              // FhirConstructGeneration.cs:209
                    if (fix.CodeElement.Value != null)                                                                                      // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.CodeElement.Value = \"{fix.CodeElement.Value}\";");                                       // FhirConstructGeneration.cs:138
                    if (fix.CodeElement.ElementId != null)                                                                                  // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.CodeElement.ElementId = \"{fix.CodeElement.ElementId}\";");                               // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:338
            block                                                                                                                           // FhirConstructGeneration.cs:339
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:340
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:341
                ;                                                                                                                           // FhirConstructGeneration.cs:342
            return  true;                                                                                                                   // FhirConstructGeneration.cs:343
        }                                                                                                                                   // FhirConstructGeneration.cs:344
                                                                                                                                            // FhirConstructGeneration.cs:315
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:319
            Annotation fix,                                                                                                                 // FhirConstructGeneration.cs:320
            String methodName,                                                                                                              // FhirConstructGeneration.cs:321
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:322
        {                                                                                                                                   // FhirConstructGeneration.cs:323
                                                                                                                                            // FhirConstructGeneration.cs:325
            block                                                                                                                           // FhirConstructGeneration.cs:326
                .AppendCode($"{methodAccess} Annotation {methodName}()")                                                                    // FhirConstructGeneration.cs:327
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:328
                .AppendCode("Annotation retVal = new Annotation();")                                                                        // FhirConstructGeneration.cs:329
                ;                                                                                                                           // FhirConstructGeneration.cs:330
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:331
            {                                                                                                                               // FhirConstructGeneration.cs:332
                if (fix.TimeElement != null)                                                                                                // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.TimeElement = new FhirDateTime();");                                                      // FhirConstructGeneration.cs:209
                    if (fix.TimeElement.Value != null)                                                                                      // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.TimeElement.Value = \"{fix.TimeElement.Value}\";");                                       // FhirConstructGeneration.cs:138
                    if (fix.TimeElement.ElementId != null)                                                                                  // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.TimeElement.ElementId = \"{fix.TimeElement.ElementId}\";");                               // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.TextElement != null)                                                                                                // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.TextElement = new FhirString();");                                                        // FhirConstructGeneration.cs:209
                    if (fix.TextElement.Value != null)                                                                                      // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.TextElement.Value = \"{fix.TextElement.Value}\";");                                       // FhirConstructGeneration.cs:138
                    if (fix.TextElement.ElementId != null)                                                                                  // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.TextElement.ElementId = \"{fix.TextElement.ElementId}\";");                               // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:338
            block                                                                                                                           // FhirConstructGeneration.cs:339
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:340
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:341
                ;                                                                                                                           // FhirConstructGeneration.cs:342
            return  true;                                                                                                                   // FhirConstructGeneration.cs:343
        }                                                                                                                                   // FhirConstructGeneration.cs:344
                                                                                                                                            // FhirConstructGeneration.cs:315
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:319
            Attachment fix,                                                                                                                 // FhirConstructGeneration.cs:320
            String methodName,                                                                                                              // FhirConstructGeneration.cs:321
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:322
        {                                                                                                                                   // FhirConstructGeneration.cs:323
                                                                                                                                            // FhirConstructGeneration.cs:325
            block                                                                                                                           // FhirConstructGeneration.cs:326
                .AppendCode($"{methodAccess} Attachment {methodName}()")                                                                    // FhirConstructGeneration.cs:327
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:328
                .AppendCode("Attachment retVal = new Attachment();")                                                                        // FhirConstructGeneration.cs:329
                ;                                                                                                                           // FhirConstructGeneration.cs:330
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:331
            {                                                                                                                               // FhirConstructGeneration.cs:332
                if (fix.ContentTypeElement != null)                                                                                         // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.ContentTypeElement = new Code();");                                                       // FhirConstructGeneration.cs:209
                    if (fix.ContentTypeElement.Value != null)                                                                               // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.ContentTypeElement.Value = \"{fix.ContentTypeElement.Value}\";");                         // FhirConstructGeneration.cs:138
                    if (fix.ContentTypeElement.ElementId != null)                                                                           // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.ContentTypeElement.ElementId = \"{fix.ContentTypeElement.ElementId}\";");                 // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.LanguageElement != null)                                                                                            // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.LanguageElement = new Code();");                                                          // FhirConstructGeneration.cs:209
                    if (fix.LanguageElement.Value != null)                                                                                  // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.LanguageElement.Value = \"{fix.LanguageElement.Value}\";");                               // FhirConstructGeneration.cs:138
                    if (fix.LanguageElement.ElementId != null)                                                                              // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.LanguageElement.ElementId = \"{fix.LanguageElement.ElementId}\";");                       // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.DataElement != null)                                                                                                // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.DataElement = new Base64Binary();");                                                      // FhirConstructGeneration.cs:209
                    if (fix.DataElement.Value != null)                                                                                      // FhirConstructGeneration.cs:81
                    {                                                                                                                       // FhirConstructGeneration.cs:82
                        block.OpenBrace();                                                                                                  // FhirConstructGeneration.cs:83
                        block.AppendCode($"byte[] data = new byte[]");                                                                      // FhirConstructGeneration.cs:84
                        block.OpenBrace();                                                                                                  // FhirConstructGeneration.cs:85
                        Int32 i = 0;                                                                                                        // FhirConstructGeneration.cs:86
                        while (i < fix.DataElement.Value.Length)                                                                            // FhirConstructGeneration.cs:87
                        {                                                                                                                   // FhirConstructGeneration.cs:88
                            Int32 j = 0;                                                                                                    // FhirConstructGeneration.cs:89
                            StringBuilder sb = new StringBuilder();                                                                         // FhirConstructGeneration.cs:90
                            while ((i < fix.DataElement.Value.Length) && (j < 32))                                                          // FhirConstructGeneration.cs:91
                            {                                                                                                               // FhirConstructGeneration.cs:92
                                sb.Append($"{fix.DataElement.Value[i]}");                                                                   // FhirConstructGeneration.cs:93
                                if (i < fix.DataElement.Value.Length - 1) sb.Append(",");                                                   // FhirConstructGeneration.cs:94
                                j += 1;                                                                                                     // FhirConstructGeneration.cs:95
                                i += 1;                                                                                                     // FhirConstructGeneration.cs:96
                            }                                                                                                               // FhirConstructGeneration.cs:97
                            block.AppendCode($"{sb.ToString()}");                                                                           // FhirConstructGeneration.cs:98
                        }                                                                                                                   // FhirConstructGeneration.cs:99
                        block.CloseBrace(";");                                                                                              // FhirConstructGeneration.cs:100
                        block.AppendCode($"retVal.DataElement.Value = data;");                                                              // FhirConstructGeneration.cs:101
                        block.CloseBrace(";");                                                                                              // FhirConstructGeneration.cs:102
                    }                                                                                                                       // FhirConstructGeneration.cs:103
                    if (fix.DataElement.ElementId != null)                                                                                  // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.DataElement.ElementId = \"{fix.DataElement.ElementId}\";");                               // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.UrlElement != null)                                                                                                 // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.UrlElement = new FhirUri();");                                                            // FhirConstructGeneration.cs:209
                    if (fix.UrlElement.Value != null)                                                                                       // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.UrlElement.Value = \"{fix.UrlElement.Value}\";");                                         // FhirConstructGeneration.cs:138
                    if (fix.UrlElement.ElementId != null)                                                                                   // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.UrlElement.ElementId = \"{fix.UrlElement.ElementId}\";");                                 // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.SizeElement != null)                                                                                                // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.SizeElement = new UnsignedInt();");                                                       // FhirConstructGeneration.cs:209
                    if (fix.SizeElement.Value.HasValue == true)                                                                             // FhirConstructGeneration.cs:130
                        block.AppendCode($"retVal.SizeElement.Value = new Nullable<int>((int) {fix.SizeElement.Value.Value});");            // FhirConstructGeneration.cs:131
                    if (fix.SizeElement.ElementId != null)                                                                                  // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.SizeElement.ElementId = \"{fix.SizeElement.ElementId}\";");                               // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.HashElement != null)                                                                                                // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.HashElement = new Base64Binary();");                                                      // FhirConstructGeneration.cs:209
                    if (fix.HashElement.Value != null)                                                                                      // FhirConstructGeneration.cs:81
                    {                                                                                                                       // FhirConstructGeneration.cs:82
                        block.OpenBrace();                                                                                                  // FhirConstructGeneration.cs:83
                        block.AppendCode($"byte[] data = new byte[]");                                                                      // FhirConstructGeneration.cs:84
                        block.OpenBrace();                                                                                                  // FhirConstructGeneration.cs:85
                        Int32 i = 0;                                                                                                        // FhirConstructGeneration.cs:86
                        while (i < fix.HashElement.Value.Length)                                                                            // FhirConstructGeneration.cs:87
                        {                                                                                                                   // FhirConstructGeneration.cs:88
                            Int32 j = 0;                                                                                                    // FhirConstructGeneration.cs:89
                            StringBuilder sb = new StringBuilder();                                                                         // FhirConstructGeneration.cs:90
                            while ((i < fix.HashElement.Value.Length) && (j < 32))                                                          // FhirConstructGeneration.cs:91
                            {                                                                                                               // FhirConstructGeneration.cs:92
                                sb.Append($"{fix.HashElement.Value[i]}");                                                                   // FhirConstructGeneration.cs:93
                                if (i < fix.HashElement.Value.Length - 1) sb.Append(",");                                                   // FhirConstructGeneration.cs:94
                                j += 1;                                                                                                     // FhirConstructGeneration.cs:95
                                i += 1;                                                                                                     // FhirConstructGeneration.cs:96
                            }                                                                                                               // FhirConstructGeneration.cs:97
                            block.AppendCode($"{sb.ToString()}");                                                                           // FhirConstructGeneration.cs:98
                        }                                                                                                                   // FhirConstructGeneration.cs:99
                        block.CloseBrace(";");                                                                                              // FhirConstructGeneration.cs:100
                        block.AppendCode($"retVal.HashElement.Value = data;");                                                              // FhirConstructGeneration.cs:101
                        block.CloseBrace(";");                                                                                              // FhirConstructGeneration.cs:102
                    }                                                                                                                       // FhirConstructGeneration.cs:103
                    if (fix.HashElement.ElementId != null)                                                                                  // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.HashElement.ElementId = \"{fix.HashElement.ElementId}\";");                               // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.TitleElement != null)                                                                                               // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.TitleElement = new FhirString();");                                                       // FhirConstructGeneration.cs:209
                    if (fix.TitleElement.Value != null)                                                                                     // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.TitleElement.Value = \"{fix.TitleElement.Value}\";");                                     // FhirConstructGeneration.cs:138
                    if (fix.TitleElement.ElementId != null)                                                                                 // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.TitleElement.ElementId = \"{fix.TitleElement.ElementId}\";");                             // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.CreationElement != null)                                                                                            // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.CreationElement = new FhirDateTime();");                                                  // FhirConstructGeneration.cs:209
                    if (fix.CreationElement.Value != null)                                                                                  // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.CreationElement.Value = \"{fix.CreationElement.Value}\";");                               // FhirConstructGeneration.cs:138
                    if (fix.CreationElement.ElementId != null)                                                                              // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.CreationElement.ElementId = \"{fix.CreationElement.ElementId}\";");                       // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:338
            block                                                                                                                           // FhirConstructGeneration.cs:339
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:340
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:341
                ;                                                                                                                           // FhirConstructGeneration.cs:342
            return  true;                                                                                                                   // FhirConstructGeneration.cs:343
        }                                                                                                                                   // FhirConstructGeneration.cs:344
                                                                                                                                            // FhirConstructGeneration.cs:315
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:319
            CodeableConcept fix,                                                                                                            // FhirConstructGeneration.cs:320
            String methodName,                                                                                                              // FhirConstructGeneration.cs:321
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:322
        {                                                                                                                                   // FhirConstructGeneration.cs:323
                                                                                                                                            // FhirConstructGeneration.cs:325
            block                                                                                                                           // FhirConstructGeneration.cs:326
                .AppendCode($"{methodAccess} CodeableConcept {methodName}()")                                                               // FhirConstructGeneration.cs:327
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:328
                .AppendCode("CodeableConcept retVal = new CodeableConcept();")                                                              // FhirConstructGeneration.cs:329
                ;                                                                                                                           // FhirConstructGeneration.cs:330
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:331
            {                                                                                                                               // FhirConstructGeneration.cs:332
                if (fix.Coding != null)                                                                                                     // FhirConstructGeneration.cs:159
                {                                                                                                                           // FhirConstructGeneration.cs:160
                    block.AppendCode($"retVal.Coding = new List<Coding>();");                                                               // FhirConstructGeneration.cs:161
                    foreach (var temp3 in fix.Coding)                                                                                       // FhirConstructGeneration.cs:162
                    {                                                                                                                       // FhirConstructGeneration.cs:163
                        block.OpenBrace();                                                                                                  // FhirConstructGeneration.cs:164
                        block.AppendCode("var temp4 = new Coding();");                                                                      // FhirConstructGeneration.cs:165
                        if (temp3.SystemElement != null)                                                                                    // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"temp4.SystemElement = new FhirUri();");                                                  // FhirConstructGeneration.cs:209
                            if (temp3.SystemElement.Value != null)                                                                          // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp4.SystemElement.Value = \"{temp3.SystemElement.Value}\";");                          // FhirConstructGeneration.cs:138
                            if (temp3.SystemElement.ElementId != null)                                                                      // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp4.SystemElement.ElementId = \"{temp3.SystemElement.ElementId}\";");                  // FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (temp3.VersionElement != null)                                                                                   // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"temp4.VersionElement = new FhirString();");                                              // FhirConstructGeneration.cs:209
                            if (temp3.VersionElement.Value != null)                                                                         // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp4.VersionElement.Value = \"{temp3.VersionElement.Value}\";");                        // FhirConstructGeneration.cs:138
                            if (temp3.VersionElement.ElementId != null)                                                                     // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp4.VersionElement.ElementId = \"{temp3.VersionElement.ElementId}\";");                // FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (temp3.CodeElement != null)                                                                                      // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"temp4.CodeElement = new Code();");                                                       // FhirConstructGeneration.cs:209
                            if (temp3.CodeElement.Value != null)                                                                            // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp4.CodeElement.Value = \"{temp3.CodeElement.Value}\";");                              // FhirConstructGeneration.cs:138
                            if (temp3.CodeElement.ElementId != null)                                                                        // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp4.CodeElement.ElementId = \"{temp3.CodeElement.ElementId}\";");                      // FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (temp3.DisplayElement != null)                                                                                   // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"temp4.DisplayElement = new FhirString();");                                              // FhirConstructGeneration.cs:209
                            if (temp3.DisplayElement.Value != null)                                                                         // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp4.DisplayElement.Value = \"{temp3.DisplayElement.Value}\";");                        // FhirConstructGeneration.cs:138
                            if (temp3.DisplayElement.ElementId != null)                                                                     // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp4.DisplayElement.ElementId = \"{temp3.DisplayElement.ElementId}\";");                // FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (temp3.UserSelectedElement != null)                                                                              // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"temp4.UserSelectedElement = new FhirBoolean();");                                        // FhirConstructGeneration.cs:209
                            if (temp3.UserSelectedElement.Value.HasValue == true)                                                           // FhirConstructGeneration.cs:69
                            {                                                                                                               // FhirConstructGeneration.cs:70
                                if (temp3.UserSelectedElement.Value.Value == true)                                                          // FhirConstructGeneration.cs:71
                                    block.AppendCode($"temp4.UserSelectedElement.Value = true;");                                           // FhirConstructGeneration.cs:72
                                else                                                                                                        // FhirConstructGeneration.cs:73
                                    block.AppendCode($"temp4.UserSelectedElement.Value = false;");                                          // FhirConstructGeneration.cs:74
                            }                                                                                                               // FhirConstructGeneration.cs:75
                            if (temp3.UserSelectedElement.ElementId != null)                                                                // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp4.UserSelectedElement.ElementId = \"{temp3.UserSelectedElement.ElementId}\";");      // FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (temp3.ElementId != null)                                                                                        // FhirConstructGeneration.cs:137
                            block.AppendCode($"temp4.ElementId = \"{temp3.ElementId}\";");                                                  // FhirConstructGeneration.cs:138
                        block.AppendCode($"retVal.Coding.Add(temp4);");                                                                     // FhirConstructGeneration.cs:171
                        block.CloseBrace();                                                                                                 // FhirConstructGeneration.cs:172
                    }                                                                                                                       // FhirConstructGeneration.cs:173
                }                                                                                                                           // FhirConstructGeneration.cs:174
                if (fix.TextElement != null)                                                                                                // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.TextElement = new FhirString();");                                                        // FhirConstructGeneration.cs:209
                    if (fix.TextElement.Value != null)                                                                                      // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.TextElement.Value = \"{fix.TextElement.Value}\";");                                       // FhirConstructGeneration.cs:138
                    if (fix.TextElement.ElementId != null)                                                                                  // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.TextElement.ElementId = \"{fix.TextElement.ElementId}\";");                               // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:338
            block                                                                                                                           // FhirConstructGeneration.cs:339
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:340
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:341
                ;                                                                                                                           // FhirConstructGeneration.cs:342
            return  true;                                                                                                                   // FhirConstructGeneration.cs:343
        }                                                                                                                                   // FhirConstructGeneration.cs:344
                                                                                                                                            // FhirConstructGeneration.cs:315
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:319
            Coding fix,                                                                                                                     // FhirConstructGeneration.cs:320
            String methodName,                                                                                                              // FhirConstructGeneration.cs:321
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:322
        {                                                                                                                                   // FhirConstructGeneration.cs:323
                                                                                                                                            // FhirConstructGeneration.cs:325
            block                                                                                                                           // FhirConstructGeneration.cs:326
                .AppendCode($"{methodAccess} Coding {methodName}()")                                                                        // FhirConstructGeneration.cs:327
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:328
                .AppendCode("Coding retVal = new Coding();")                                                                                // FhirConstructGeneration.cs:329
                ;                                                                                                                           // FhirConstructGeneration.cs:330
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:331
            {                                                                                                                               // FhirConstructGeneration.cs:332
                if (fix.SystemElement != null)                                                                                              // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.SystemElement = new FhirUri();");                                                         // FhirConstructGeneration.cs:209
                    if (fix.SystemElement.Value != null)                                                                                    // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.SystemElement.Value = \"{fix.SystemElement.Value}\";");                                   // FhirConstructGeneration.cs:138
                    if (fix.SystemElement.ElementId != null)                                                                                // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.SystemElement.ElementId = \"{fix.SystemElement.ElementId}\";");                           // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.VersionElement != null)                                                                                             // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.VersionElement = new FhirString();");                                                     // FhirConstructGeneration.cs:209
                    if (fix.VersionElement.Value != null)                                                                                   // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.VersionElement.Value = \"{fix.VersionElement.Value}\";");                                 // FhirConstructGeneration.cs:138
                    if (fix.VersionElement.ElementId != null)                                                                               // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.VersionElement.ElementId = \"{fix.VersionElement.ElementId}\";");                         // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.CodeElement != null)                                                                                                // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.CodeElement = new Code();");                                                              // FhirConstructGeneration.cs:209
                    if (fix.CodeElement.Value != null)                                                                                      // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.CodeElement.Value = \"{fix.CodeElement.Value}\";");                                       // FhirConstructGeneration.cs:138
                    if (fix.CodeElement.ElementId != null)                                                                                  // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.CodeElement.ElementId = \"{fix.CodeElement.ElementId}\";");                               // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.DisplayElement != null)                                                                                             // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.DisplayElement = new FhirString();");                                                     // FhirConstructGeneration.cs:209
                    if (fix.DisplayElement.Value != null)                                                                                   // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.DisplayElement.Value = \"{fix.DisplayElement.Value}\";");                                 // FhirConstructGeneration.cs:138
                    if (fix.DisplayElement.ElementId != null)                                                                               // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.DisplayElement.ElementId = \"{fix.DisplayElement.ElementId}\";");                         // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.UserSelectedElement != null)                                                                                        // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.UserSelectedElement = new FhirBoolean();");                                               // FhirConstructGeneration.cs:209
                    if (fix.UserSelectedElement.Value.HasValue == true)                                                                     // FhirConstructGeneration.cs:69
                    {                                                                                                                       // FhirConstructGeneration.cs:70
                        if (fix.UserSelectedElement.Value.Value == true)                                                                    // FhirConstructGeneration.cs:71
                            block.AppendCode($"retVal.UserSelectedElement.Value = true;");                                                  // FhirConstructGeneration.cs:72
                        else                                                                                                                // FhirConstructGeneration.cs:73
                            block.AppendCode($"retVal.UserSelectedElement.Value = false;");                                                 // FhirConstructGeneration.cs:74
                    }                                                                                                                       // FhirConstructGeneration.cs:75
                    if (fix.UserSelectedElement.ElementId != null)                                                                          // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.UserSelectedElement.ElementId = \"{fix.UserSelectedElement.ElementId}\";");               // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:338
            block                                                                                                                           // FhirConstructGeneration.cs:339
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:340
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:341
                ;                                                                                                                           // FhirConstructGeneration.cs:342
            return  true;                                                                                                                   // FhirConstructGeneration.cs:343
        }                                                                                                                                   // FhirConstructGeneration.cs:344
                                                                                                                                            // FhirConstructGeneration.cs:315
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:319
            ContactDetail fix,                                                                                                              // FhirConstructGeneration.cs:320
            String methodName,                                                                                                              // FhirConstructGeneration.cs:321
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:322
        {                                                                                                                                   // FhirConstructGeneration.cs:323
                                                                                                                                            // FhirConstructGeneration.cs:325
            block                                                                                                                           // FhirConstructGeneration.cs:326
                .AppendCode($"{methodAccess} ContactDetail {methodName}()")                                                                 // FhirConstructGeneration.cs:327
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:328
                .AppendCode("ContactDetail retVal = new ContactDetail();")                                                                  // FhirConstructGeneration.cs:329
                ;                                                                                                                           // FhirConstructGeneration.cs:330
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:331
            {                                                                                                                               // FhirConstructGeneration.cs:332
                if (fix.NameElement != null)                                                                                                // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.NameElement = new FhirString();");                                                        // FhirConstructGeneration.cs:209
                    if (fix.NameElement.Value != null)                                                                                      // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.NameElement.Value = \"{fix.NameElement.Value}\";");                                       // FhirConstructGeneration.cs:138
                    if (fix.NameElement.ElementId != null)                                                                                  // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.NameElement.ElementId = \"{fix.NameElement.ElementId}\";");                               // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.Telecom != null)                                                                                                    // FhirConstructGeneration.cs:159
                {                                                                                                                           // FhirConstructGeneration.cs:160
                    block.AppendCode($"retVal.Telecom = new List<ContactPoint>();");                                                        // FhirConstructGeneration.cs:161
                    foreach (var temp5 in fix.Telecom)                                                                                      // FhirConstructGeneration.cs:162
                    {                                                                                                                       // FhirConstructGeneration.cs:163
                        block.OpenBrace();                                                                                                  // FhirConstructGeneration.cs:164
                        block.AppendCode("var temp6 = new ContactPoint();");                                                                // FhirConstructGeneration.cs:165
                        if (temp5.SystemElement != null)                                                                                    // FhirConstructGeneration.cs:147
                            block.AppendCode($"temp6.SystemElement = new Code<ContactPoint.ContactPointSystem>(ContactPoint.ContactPointSystem.{temp5.SystemElement.Value});");// FhirConstructGeneration.cs:148
                        if (temp5.ValueElement != null)                                                                                     // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"temp6.ValueElement = new FhirString();");                                                // FhirConstructGeneration.cs:209
                            if (temp5.ValueElement.Value != null)                                                                           // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp6.ValueElement.Value = \"{temp5.ValueElement.Value}\";");                            // FhirConstructGeneration.cs:138
                            if (temp5.ValueElement.ElementId != null)                                                                       // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp6.ValueElement.ElementId = \"{temp5.ValueElement.ElementId}\";");                    // FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (temp5.UseElement != null)                                                                                       // FhirConstructGeneration.cs:147
                            block.AppendCode($"temp6.UseElement = new Code<ContactPoint.ContactPointUse>(ContactPoint.ContactPointUse.{temp5.UseElement.Value});");// FhirConstructGeneration.cs:148
                        if (temp5.RankElement != null)                                                                                      // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"temp6.RankElement = new PositiveInt();");                                                // FhirConstructGeneration.cs:209
                            if (temp5.RankElement.Value.HasValue == true)                                                                   // FhirConstructGeneration.cs:130
                                block.AppendCode($"temp6.RankElement.Value = new Nullable<int>((int) {temp5.RankElement.Value.Value});");   // FhirConstructGeneration.cs:131
                            if (temp5.RankElement.ElementId != null)                                                                        // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp6.RankElement.ElementId = \"{temp5.RankElement.ElementId}\";");                      // FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (temp5.Period != null)                                                                                           // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"temp6.Period = new Period();");                                                          // FhirConstructGeneration.cs:209
                            if (temp5.Period.StartElement != null)                                                                          // FhirConstructGeneration.cs:207
                            {                                                                                                               // FhirConstructGeneration.cs:208
                                    block.AppendCode($"temp6.Period.StartElement = new FhirDateTime();");                                   // FhirConstructGeneration.cs:209
                                if (temp5.Period.StartElement.Value != null)                                                                // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp6.Period.StartElement.Value = \"{temp5.Period.StartElement.Value}\";");          // FhirConstructGeneration.cs:138
                                if (temp5.Period.StartElement.ElementId != null)                                                            // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp6.Period.StartElement.ElementId = \"{temp5.Period.StartElement.ElementId}\";");  // FhirConstructGeneration.cs:138
                            }                                                                                                               // FhirConstructGeneration.cs:213
                            if (temp5.Period.EndElement != null)                                                                            // FhirConstructGeneration.cs:207
                            {                                                                                                               // FhirConstructGeneration.cs:208
                                    block.AppendCode($"temp6.Period.EndElement = new FhirDateTime();");                                     // FhirConstructGeneration.cs:209
                                if (temp5.Period.EndElement.Value != null)                                                                  // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp6.Period.EndElement.Value = \"{temp5.Period.EndElement.Value}\";");              // FhirConstructGeneration.cs:138
                                if (temp5.Period.EndElement.ElementId != null)                                                              // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp6.Period.EndElement.ElementId = \"{temp5.Period.EndElement.ElementId}\";");      // FhirConstructGeneration.cs:138
                            }                                                                                                               // FhirConstructGeneration.cs:213
                            if (temp5.Period.ElementId != null)                                                                             // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp6.Period.ElementId = \"{temp5.Period.ElementId}\";");                                // FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (temp5.ElementId != null)                                                                                        // FhirConstructGeneration.cs:137
                            block.AppendCode($"temp6.ElementId = \"{temp5.ElementId}\";");                                                  // FhirConstructGeneration.cs:138
                        block.AppendCode($"retVal.Telecom.Add(temp6);");                                                                    // FhirConstructGeneration.cs:171
                        block.CloseBrace();                                                                                                 // FhirConstructGeneration.cs:172
                    }                                                                                                                       // FhirConstructGeneration.cs:173
                }                                                                                                                           // FhirConstructGeneration.cs:174
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:338
            block                                                                                                                           // FhirConstructGeneration.cs:339
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:340
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:341
                ;                                                                                                                           // FhirConstructGeneration.cs:342
            return  true;                                                                                                                   // FhirConstructGeneration.cs:343
        }                                                                                                                                   // FhirConstructGeneration.cs:344
                                                                                                                                            // FhirConstructGeneration.cs:315
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:319
            ContactPoint fix,                                                                                                               // FhirConstructGeneration.cs:320
            String methodName,                                                                                                              // FhirConstructGeneration.cs:321
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:322
        {                                                                                                                                   // FhirConstructGeneration.cs:323
                                                                                                                                            // FhirConstructGeneration.cs:325
            block                                                                                                                           // FhirConstructGeneration.cs:326
                .AppendCode($"{methodAccess} ContactPoint {methodName}()")                                                                  // FhirConstructGeneration.cs:327
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:328
                .AppendCode("ContactPoint retVal = new ContactPoint();")                                                                    // FhirConstructGeneration.cs:329
                ;                                                                                                                           // FhirConstructGeneration.cs:330
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:331
            {                                                                                                                               // FhirConstructGeneration.cs:332
                if (fix.SystemElement != null)                                                                                              // FhirConstructGeneration.cs:147
                    block.AppendCode($"retVal.SystemElement = new Code<ContactPoint.ContactPointSystem>(ContactPoint.ContactPointSystem.{fix.SystemElement.Value});");// FhirConstructGeneration.cs:148
                if (fix.ValueElement != null)                                                                                               // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.ValueElement = new FhirString();");                                                       // FhirConstructGeneration.cs:209
                    if (fix.ValueElement.Value != null)                                                                                     // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.ValueElement.Value = \"{fix.ValueElement.Value}\";");                                     // FhirConstructGeneration.cs:138
                    if (fix.ValueElement.ElementId != null)                                                                                 // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.ValueElement.ElementId = \"{fix.ValueElement.ElementId}\";");                             // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.UseElement != null)                                                                                                 // FhirConstructGeneration.cs:147
                    block.AppendCode($"retVal.UseElement = new Code<ContactPoint.ContactPointUse>(ContactPoint.ContactPointUse.{fix.UseElement.Value});");// FhirConstructGeneration.cs:148
                if (fix.RankElement != null)                                                                                                // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.RankElement = new PositiveInt();");                                                       // FhirConstructGeneration.cs:209
                    if (fix.RankElement.Value.HasValue == true)                                                                             // FhirConstructGeneration.cs:130
                        block.AppendCode($"retVal.RankElement.Value = new Nullable<int>((int) {fix.RankElement.Value.Value});");            // FhirConstructGeneration.cs:131
                    if (fix.RankElement.ElementId != null)                                                                                  // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.RankElement.ElementId = \"{fix.RankElement.ElementId}\";");                               // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.Period != null)                                                                                                     // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.Period = new Period();");                                                                 // FhirConstructGeneration.cs:209
                    if (fix.Period.StartElement != null)                                                                                    // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Period.StartElement = new FhirDateTime();");                                          // FhirConstructGeneration.cs:209
                        if (fix.Period.StartElement.Value != null)                                                                          // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Period.StartElement.Value = \"{fix.Period.StartElement.Value}\";");                   // FhirConstructGeneration.cs:138
                        if (fix.Period.StartElement.ElementId != null)                                                                      // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Period.StartElement.ElementId = \"{fix.Period.StartElement.ElementId}\";");           // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Period.EndElement != null)                                                                                      // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Period.EndElement = new FhirDateTime();");                                            // FhirConstructGeneration.cs:209
                        if (fix.Period.EndElement.Value != null)                                                                            // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Period.EndElement.Value = \"{fix.Period.EndElement.Value}\";");                       // FhirConstructGeneration.cs:138
                        if (fix.Period.EndElement.ElementId != null)                                                                        // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Period.EndElement.ElementId = \"{fix.Period.EndElement.ElementId}\";");               // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Period.ElementId != null)                                                                                       // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.Period.ElementId = \"{fix.Period.ElementId}\";");                                         // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:338
            block                                                                                                                           // FhirConstructGeneration.cs:339
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:340
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:341
                ;                                                                                                                           // FhirConstructGeneration.cs:342
            return  true;                                                                                                                   // FhirConstructGeneration.cs:343
        }                                                                                                                                   // FhirConstructGeneration.cs:344
                                                                                                                                            // FhirConstructGeneration.cs:315
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:319
            Contributor fix,                                                                                                                // FhirConstructGeneration.cs:320
            String methodName,                                                                                                              // FhirConstructGeneration.cs:321
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:322
        {                                                                                                                                   // FhirConstructGeneration.cs:323
                                                                                                                                            // FhirConstructGeneration.cs:325
            block                                                                                                                           // FhirConstructGeneration.cs:326
                .AppendCode($"{methodAccess} Contributor {methodName}()")                                                                   // FhirConstructGeneration.cs:327
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:328
                .AppendCode("Contributor retVal = new Contributor();")                                                                      // FhirConstructGeneration.cs:329
                ;                                                                                                                           // FhirConstructGeneration.cs:330
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:331
            {                                                                                                                               // FhirConstructGeneration.cs:332
                if (fix.TypeElement != null)                                                                                                // FhirConstructGeneration.cs:147
                    block.AppendCode($"retVal.TypeElement = new Code<Contributor.ContributorType>(Contributor.ContributorType.{fix.TypeElement.Value});");// FhirConstructGeneration.cs:148
                if (fix.NameElement != null)                                                                                                // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.NameElement = new FhirString();");                                                        // FhirConstructGeneration.cs:209
                    if (fix.NameElement.Value != null)                                                                                      // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.NameElement.Value = \"{fix.NameElement.Value}\";");                                       // FhirConstructGeneration.cs:138
                    if (fix.NameElement.ElementId != null)                                                                                  // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.NameElement.ElementId = \"{fix.NameElement.ElementId}\";");                               // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.Contact != null)                                                                                                    // FhirConstructGeneration.cs:159
                {                                                                                                                           // FhirConstructGeneration.cs:160
                    block.AppendCode($"retVal.Contact = new List<ContactDetail>();");                                                       // FhirConstructGeneration.cs:161
                    foreach (var temp7 in fix.Contact)                                                                                      // FhirConstructGeneration.cs:162
                    {                                                                                                                       // FhirConstructGeneration.cs:163
                        block.OpenBrace();                                                                                                  // FhirConstructGeneration.cs:164
                        block.AppendCode("var temp8 = new ContactDetail();");                                                               // FhirConstructGeneration.cs:165
                        if (temp7.NameElement != null)                                                                                      // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"temp8.NameElement = new FhirString();");                                                 // FhirConstructGeneration.cs:209
                            if (temp7.NameElement.Value != null)                                                                            // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp8.NameElement.Value = \"{temp7.NameElement.Value}\";");                              // FhirConstructGeneration.cs:138
                            if (temp7.NameElement.ElementId != null)                                                                        // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp8.NameElement.ElementId = \"{temp7.NameElement.ElementId}\";");                      // FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (temp7.Telecom != null)                                                                                          // FhirConstructGeneration.cs:159
                        {                                                                                                                   // FhirConstructGeneration.cs:160
                            block.AppendCode($"temp8.Telecom = new List<ContactPoint>();");                                                 // FhirConstructGeneration.cs:161
                            foreach (var temp9 in temp7.Telecom)                                                                            // FhirConstructGeneration.cs:162
                            {                                                                                                               // FhirConstructGeneration.cs:163
                                block.OpenBrace();                                                                                          // FhirConstructGeneration.cs:164
                                block.AppendCode("var temp10 = new ContactPoint();");                                                       // FhirConstructGeneration.cs:165
                                if (temp9.SystemElement != null)                                                                            // FhirConstructGeneration.cs:147
                                    block.AppendCode($"temp10.SystemElement = new Code<ContactPoint.ContactPointSystem>(ContactPoint.ContactPointSystem.{temp9.SystemElement.Value});");// FhirConstructGeneration.cs:148
                                if (temp9.ValueElement != null)                                                                             // FhirConstructGeneration.cs:207
                                {                                                                                                           // FhirConstructGeneration.cs:208
                                        block.AppendCode($"temp10.ValueElement = new FhirString();");                                       // FhirConstructGeneration.cs:209
                                    if (temp9.ValueElement.Value != null)                                                                   // FhirConstructGeneration.cs:137
                                        block.AppendCode($"temp10.ValueElement.Value = \"{temp9.ValueElement.Value}\";");                   // FhirConstructGeneration.cs:138
                                    if (temp9.ValueElement.ElementId != null)                                                               // FhirConstructGeneration.cs:137
                                        block.AppendCode($"temp10.ValueElement.ElementId = \"{temp9.ValueElement.ElementId}\";");           // FhirConstructGeneration.cs:138
                                }                                                                                                           // FhirConstructGeneration.cs:213
                                if (temp9.UseElement != null)                                                                               // FhirConstructGeneration.cs:147
                                    block.AppendCode($"temp10.UseElement = new Code<ContactPoint.ContactPointUse>(ContactPoint.ContactPointUse.{temp9.UseElement.Value});");// FhirConstructGeneration.cs:148
                                if (temp9.RankElement != null)                                                                              // FhirConstructGeneration.cs:207
                                {                                                                                                           // FhirConstructGeneration.cs:208
                                        block.AppendCode($"temp10.RankElement = new PositiveInt();");                                       // FhirConstructGeneration.cs:209
                                    if (temp9.RankElement.Value.HasValue == true)                                                           // FhirConstructGeneration.cs:130
                                        block.AppendCode($"temp10.RankElement.Value = new Nullable<int>((int) {temp9.RankElement.Value.Value});");// FhirConstructGeneration.cs:131
                                    if (temp9.RankElement.ElementId != null)                                                                // FhirConstructGeneration.cs:137
                                        block.AppendCode($"temp10.RankElement.ElementId = \"{temp9.RankElement.ElementId}\";");             // FhirConstructGeneration.cs:138
                                }                                                                                                           // FhirConstructGeneration.cs:213
                                if (temp9.Period != null)                                                                                   // FhirConstructGeneration.cs:207
                                {                                                                                                           // FhirConstructGeneration.cs:208
                                        block.AppendCode($"temp10.Period = new Period();");                                                 // FhirConstructGeneration.cs:209
                                    if (temp9.Period.StartElement != null)                                                                  // FhirConstructGeneration.cs:207
                                    {                                                                                                       // FhirConstructGeneration.cs:208
                                            block.AppendCode($"temp10.Period.StartElement = new FhirDateTime();");                          // FhirConstructGeneration.cs:209
                                        if (temp9.Period.StartElement.Value != null)                                                        // FhirConstructGeneration.cs:137
                                            block.AppendCode($"temp10.Period.StartElement.Value = \"{temp9.Period.StartElement.Value}\";"); // FhirConstructGeneration.cs:138
                                        if (temp9.Period.StartElement.ElementId != null)                                                    // FhirConstructGeneration.cs:137
                                            block.AppendCode($"temp10.Period.StartElement.ElementId = \"{temp9.Period.StartElement.ElementId}\";");// FhirConstructGeneration.cs:138
                                    }                                                                                                       // FhirConstructGeneration.cs:213
                                    if (temp9.Period.EndElement != null)                                                                    // FhirConstructGeneration.cs:207
                                    {                                                                                                       // FhirConstructGeneration.cs:208
                                            block.AppendCode($"temp10.Period.EndElement = new FhirDateTime();");                            // FhirConstructGeneration.cs:209
                                        if (temp9.Period.EndElement.Value != null)                                                          // FhirConstructGeneration.cs:137
                                            block.AppendCode($"temp10.Period.EndElement.Value = \"{temp9.Period.EndElement.Value}\";");     // FhirConstructGeneration.cs:138
                                        if (temp9.Period.EndElement.ElementId != null)                                                      // FhirConstructGeneration.cs:137
                                            block.AppendCode($"temp10.Period.EndElement.ElementId = \"{temp9.Period.EndElement.ElementId}\";");// FhirConstructGeneration.cs:138
                                    }                                                                                                       // FhirConstructGeneration.cs:213
                                    if (temp9.Period.ElementId != null)                                                                     // FhirConstructGeneration.cs:137
                                        block.AppendCode($"temp10.Period.ElementId = \"{temp9.Period.ElementId}\";");                       // FhirConstructGeneration.cs:138
                                }                                                                                                           // FhirConstructGeneration.cs:213
                                if (temp9.ElementId != null)                                                                                // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp10.ElementId = \"{temp9.ElementId}\";");                                         // FhirConstructGeneration.cs:138
                                block.AppendCode($"temp8.Telecom.Add(temp10);");                                                            // FhirConstructGeneration.cs:171
                                block.CloseBrace();                                                                                         // FhirConstructGeneration.cs:172
                            }                                                                                                               // FhirConstructGeneration.cs:173
                        }                                                                                                                   // FhirConstructGeneration.cs:174
                        if (temp7.ElementId != null)                                                                                        // FhirConstructGeneration.cs:137
                            block.AppendCode($"temp8.ElementId = \"{temp7.ElementId}\";");                                                  // FhirConstructGeneration.cs:138
                        block.AppendCode($"retVal.Contact.Add(temp8);");                                                                    // FhirConstructGeneration.cs:171
                        block.CloseBrace();                                                                                                 // FhirConstructGeneration.cs:172
                    }                                                                                                                       // FhirConstructGeneration.cs:173
                }                                                                                                                           // FhirConstructGeneration.cs:174
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:338
            block                                                                                                                           // FhirConstructGeneration.cs:339
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:340
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:341
                ;                                                                                                                           // FhirConstructGeneration.cs:342
            return  true;                                                                                                                   // FhirConstructGeneration.cs:343
        }                                                                                                                                   // FhirConstructGeneration.cs:344
                                                                                                                                            // FhirConstructGeneration.cs:315
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:319
            Count fix,                                                                                                                      // FhirConstructGeneration.cs:320
            String methodName,                                                                                                              // FhirConstructGeneration.cs:321
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:322
        {                                                                                                                                   // FhirConstructGeneration.cs:323
                                                                                                                                            // FhirConstructGeneration.cs:325
            block                                                                                                                           // FhirConstructGeneration.cs:326
                .AppendCode($"{methodAccess} Count {methodName}()")                                                                         // FhirConstructGeneration.cs:327
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:328
                .AppendCode("Count retVal = new Count();")                                                                                  // FhirConstructGeneration.cs:329
                ;                                                                                                                           // FhirConstructGeneration.cs:330
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:331
            {                                                                                                                               // FhirConstructGeneration.cs:332
                if (fix.ValueElement != null)                                                                                               // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.ValueElement = new FhirDecimal();");                                                      // FhirConstructGeneration.cs:209
                    if (fix.ValueElement.Value.HasValue == true)                                                                            // FhirConstructGeneration.cs:123
                        block.AppendCode($"retVal.ValueElement.Value = new Nullable<decimal>((decimal) {fix.ValueElement.Value.Value});");  // FhirConstructGeneration.cs:124
                    if (fix.ValueElement.ElementId != null)                                                                                 // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.ValueElement.ElementId = \"{fix.ValueElement.ElementId}\";");                             // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.ComparatorElement != null)                                                                                          // FhirConstructGeneration.cs:147
                    block.AppendCode($"retVal.ComparatorElement = new Code<Quantity.QuantityComparator>(Quantity.QuantityComparator.{fix.ComparatorElement.Value});");// FhirConstructGeneration.cs:148
                if (fix.UnitElement != null)                                                                                                // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.UnitElement = new FhirString();");                                                        // FhirConstructGeneration.cs:209
                    if (fix.UnitElement.Value != null)                                                                                      // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.UnitElement.Value = \"{fix.UnitElement.Value}\";");                                       // FhirConstructGeneration.cs:138
                    if (fix.UnitElement.ElementId != null)                                                                                  // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.UnitElement.ElementId = \"{fix.UnitElement.ElementId}\";");                               // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.SystemElement != null)                                                                                              // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.SystemElement = new FhirUri();");                                                         // FhirConstructGeneration.cs:209
                    if (fix.SystemElement.Value != null)                                                                                    // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.SystemElement.Value = \"{fix.SystemElement.Value}\";");                                   // FhirConstructGeneration.cs:138
                    if (fix.SystemElement.ElementId != null)                                                                                // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.SystemElement.ElementId = \"{fix.SystemElement.ElementId}\";");                           // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.CodeElement != null)                                                                                                // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.CodeElement = new Code();");                                                              // FhirConstructGeneration.cs:209
                    if (fix.CodeElement.Value != null)                                                                                      // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.CodeElement.Value = \"{fix.CodeElement.Value}\";");                                       // FhirConstructGeneration.cs:138
                    if (fix.CodeElement.ElementId != null)                                                                                  // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.CodeElement.ElementId = \"{fix.CodeElement.ElementId}\";");                               // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:338
            block                                                                                                                           // FhirConstructGeneration.cs:339
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:340
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:341
                ;                                                                                                                           // FhirConstructGeneration.cs:342
            return  true;                                                                                                                   // FhirConstructGeneration.cs:343
        }                                                                                                                                   // FhirConstructGeneration.cs:344
                                                                                                                                            // FhirConstructGeneration.cs:315
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:319
            DataRequirement fix,                                                                                                            // FhirConstructGeneration.cs:320
            String methodName,                                                                                                              // FhirConstructGeneration.cs:321
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:322
        {                                                                                                                                   // FhirConstructGeneration.cs:323
                                                                                                                                            // FhirConstructGeneration.cs:325
            block                                                                                                                           // FhirConstructGeneration.cs:326
                .AppendCode($"{methodAccess} DataRequirement {methodName}()")                                                               // FhirConstructGeneration.cs:327
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:328
                .AppendCode("DataRequirement retVal = new DataRequirement();")                                                              // FhirConstructGeneration.cs:329
                ;                                                                                                                           // FhirConstructGeneration.cs:330
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:331
            {                                                                                                                               // FhirConstructGeneration.cs:332
                if (fix.TypeElement != null)                                                                                                // FhirConstructGeneration.cs:147
                    block.AppendCode($"retVal.TypeElement = new Code<FHIRAllTypes>(FHIRAllTypes.{fix.TypeElement.Value});");                // FhirConstructGeneration.cs:148
                if (fix.ProfileElement != null)                                                                                             // FhirConstructGeneration.cs:159
                {                                                                                                                           // FhirConstructGeneration.cs:160
                    block.AppendCode($"retVal.ProfileElement = new List<FhirUri>();");                                                      // FhirConstructGeneration.cs:161
                    foreach (var temp11 in fix.ProfileElement)                                                                              // FhirConstructGeneration.cs:162
                    {                                                                                                                       // FhirConstructGeneration.cs:163
                        block.OpenBrace();                                                                                                  // FhirConstructGeneration.cs:164
                        block.AppendCode("var temp12 = new FhirUri();");                                                                    // FhirConstructGeneration.cs:165
                        if (temp11.Value != null)                                                                                           // FhirConstructGeneration.cs:137
                            block.AppendCode($"temp12.Value = \"{temp11.Value}\";");                                                        // FhirConstructGeneration.cs:138
                        if (temp11.ElementId != null)                                                                                       // FhirConstructGeneration.cs:137
                            block.AppendCode($"temp12.ElementId = \"{temp11.ElementId}\";");                                                // FhirConstructGeneration.cs:138
                        block.AppendCode($"retVal.ProfileElement.Add(temp12);");                                                            // FhirConstructGeneration.cs:171
                        block.CloseBrace();                                                                                                 // FhirConstructGeneration.cs:172
                    }                                                                                                                       // FhirConstructGeneration.cs:173
                }                                                                                                                           // FhirConstructGeneration.cs:174
                if (fix.MustSupportElement != null)                                                                                         // FhirConstructGeneration.cs:159
                {                                                                                                                           // FhirConstructGeneration.cs:160
                    block.AppendCode($"retVal.MustSupportElement = new List<FhirString>();");                                               // FhirConstructGeneration.cs:161
                    foreach (var temp13 in fix.MustSupportElement)                                                                          // FhirConstructGeneration.cs:162
                    {                                                                                                                       // FhirConstructGeneration.cs:163
                        block.OpenBrace();                                                                                                  // FhirConstructGeneration.cs:164
                        block.AppendCode("var temp14 = new FhirString();");                                                                 // FhirConstructGeneration.cs:165
                        if (temp13.Value != null)                                                                                           // FhirConstructGeneration.cs:137
                            block.AppendCode($"temp14.Value = \"{temp13.Value}\";");                                                        // FhirConstructGeneration.cs:138
                        if (temp13.ElementId != null)                                                                                       // FhirConstructGeneration.cs:137
                            block.AppendCode($"temp14.ElementId = \"{temp13.ElementId}\";");                                                // FhirConstructGeneration.cs:138
                        block.AppendCode($"retVal.MustSupportElement.Add(temp14);");                                                        // FhirConstructGeneration.cs:171
                        block.CloseBrace();                                                                                                 // FhirConstructGeneration.cs:172
                    }                                                                                                                       // FhirConstructGeneration.cs:173
                }                                                                                                                           // FhirConstructGeneration.cs:174
                if (fix.CodeFilter != null)                                                                                                 // FhirConstructGeneration.cs:159
                {                                                                                                                           // FhirConstructGeneration.cs:160
                    block.AppendCode($"retVal.CodeFilter = new List<DataRequirement.CodeFilterComponent>();");                              // FhirConstructGeneration.cs:161
                    foreach (var temp15 in fix.CodeFilter)                                                                                  // FhirConstructGeneration.cs:162
                    {                                                                                                                       // FhirConstructGeneration.cs:163
                        block.OpenBrace();                                                                                                  // FhirConstructGeneration.cs:164
                        block.AppendCode("var temp16 = new DataRequirement.CodeFilterComponent();");                                        // FhirConstructGeneration.cs:165
                        if (temp15.PathElement != null)                                                                                     // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"temp16.PathElement = new FhirString();");                                                // FhirConstructGeneration.cs:209
                            if (temp15.PathElement.Value != null)                                                                           // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp16.PathElement.Value = \"{temp15.PathElement.Value}\";");                            // FhirConstructGeneration.cs:138
                            if (temp15.PathElement.ElementId != null)                                                                       // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp16.PathElement.ElementId = \"{temp15.PathElement.ElementId}\";");                    // FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (temp15.ValueCodeElement != null)                                                                                // FhirConstructGeneration.cs:159
                        {                                                                                                                   // FhirConstructGeneration.cs:160
                            block.AppendCode($"temp16.ValueCodeElement = new List<Code>();");                                               // FhirConstructGeneration.cs:161
                            foreach (var temp17 in temp15.ValueCodeElement)                                                                 // FhirConstructGeneration.cs:162
                            {                                                                                                               // FhirConstructGeneration.cs:163
                                block.OpenBrace();                                                                                          // FhirConstructGeneration.cs:164
                                block.AppendCode("var temp18 = new Code();");                                                               // FhirConstructGeneration.cs:165
                                if (temp17.Value != null)                                                                                   // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp18.Value = \"{temp17.Value}\";");                                                // FhirConstructGeneration.cs:138
                                if (temp17.ElementId != null)                                                                               // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp18.ElementId = \"{temp17.ElementId}\";");                                        // FhirConstructGeneration.cs:138
                                block.AppendCode($"temp16.ValueCodeElement.Add(temp18);");                                                  // FhirConstructGeneration.cs:171
                                block.CloseBrace();                                                                                         // FhirConstructGeneration.cs:172
                            }                                                                                                               // FhirConstructGeneration.cs:173
                        }                                                                                                                   // FhirConstructGeneration.cs:174
                        if (temp15.ValueCoding != null)                                                                                     // FhirConstructGeneration.cs:159
                        {                                                                                                                   // FhirConstructGeneration.cs:160
                            block.AppendCode($"temp16.ValueCoding = new List<Coding>();");                                                  // FhirConstructGeneration.cs:161
                            foreach (var temp19 in temp15.ValueCoding)                                                                      // FhirConstructGeneration.cs:162
                            {                                                                                                               // FhirConstructGeneration.cs:163
                                block.OpenBrace();                                                                                          // FhirConstructGeneration.cs:164
                                block.AppendCode("var temp20 = new Coding();");                                                             // FhirConstructGeneration.cs:165
                                if (temp19.SystemElement != null)                                                                           // FhirConstructGeneration.cs:207
                                {                                                                                                           // FhirConstructGeneration.cs:208
                                        block.AppendCode($"temp20.SystemElement = new FhirUri();");                                         // FhirConstructGeneration.cs:209
                                    if (temp19.SystemElement.Value != null)                                                                 // FhirConstructGeneration.cs:137
                                        block.AppendCode($"temp20.SystemElement.Value = \"{temp19.SystemElement.Value}\";");                // FhirConstructGeneration.cs:138
                                    if (temp19.SystemElement.ElementId != null)                                                             // FhirConstructGeneration.cs:137
                                        block.AppendCode($"temp20.SystemElement.ElementId = \"{temp19.SystemElement.ElementId}\";");        // FhirConstructGeneration.cs:138
                                }                                                                                                           // FhirConstructGeneration.cs:213
                                if (temp19.VersionElement != null)                                                                          // FhirConstructGeneration.cs:207
                                {                                                                                                           // FhirConstructGeneration.cs:208
                                        block.AppendCode($"temp20.VersionElement = new FhirString();");                                     // FhirConstructGeneration.cs:209
                                    if (temp19.VersionElement.Value != null)                                                                // FhirConstructGeneration.cs:137
                                        block.AppendCode($"temp20.VersionElement.Value = \"{temp19.VersionElement.Value}\";");              // FhirConstructGeneration.cs:138
                                    if (temp19.VersionElement.ElementId != null)                                                            // FhirConstructGeneration.cs:137
                                        block.AppendCode($"temp20.VersionElement.ElementId = \"{temp19.VersionElement.ElementId}\";");      // FhirConstructGeneration.cs:138
                                }                                                                                                           // FhirConstructGeneration.cs:213
                                if (temp19.CodeElement != null)                                                                             // FhirConstructGeneration.cs:207
                                {                                                                                                           // FhirConstructGeneration.cs:208
                                        block.AppendCode($"temp20.CodeElement = new Code();");                                              // FhirConstructGeneration.cs:209
                                    if (temp19.CodeElement.Value != null)                                                                   // FhirConstructGeneration.cs:137
                                        block.AppendCode($"temp20.CodeElement.Value = \"{temp19.CodeElement.Value}\";");                    // FhirConstructGeneration.cs:138
                                    if (temp19.CodeElement.ElementId != null)                                                               // FhirConstructGeneration.cs:137
                                        block.AppendCode($"temp20.CodeElement.ElementId = \"{temp19.CodeElement.ElementId}\";");            // FhirConstructGeneration.cs:138
                                }                                                                                                           // FhirConstructGeneration.cs:213
                                if (temp19.DisplayElement != null)                                                                          // FhirConstructGeneration.cs:207
                                {                                                                                                           // FhirConstructGeneration.cs:208
                                        block.AppendCode($"temp20.DisplayElement = new FhirString();");                                     // FhirConstructGeneration.cs:209
                                    if (temp19.DisplayElement.Value != null)                                                                // FhirConstructGeneration.cs:137
                                        block.AppendCode($"temp20.DisplayElement.Value = \"{temp19.DisplayElement.Value}\";");              // FhirConstructGeneration.cs:138
                                    if (temp19.DisplayElement.ElementId != null)                                                            // FhirConstructGeneration.cs:137
                                        block.AppendCode($"temp20.DisplayElement.ElementId = \"{temp19.DisplayElement.ElementId}\";");      // FhirConstructGeneration.cs:138
                                }                                                                                                           // FhirConstructGeneration.cs:213
                                if (temp19.UserSelectedElement != null)                                                                     // FhirConstructGeneration.cs:207
                                {                                                                                                           // FhirConstructGeneration.cs:208
                                        block.AppendCode($"temp20.UserSelectedElement = new FhirBoolean();");                               // FhirConstructGeneration.cs:209
                                    if (temp19.UserSelectedElement.Value.HasValue == true)                                                  // FhirConstructGeneration.cs:69
                                    {                                                                                                       // FhirConstructGeneration.cs:70
                                        if (temp19.UserSelectedElement.Value.Value == true)                                                 // FhirConstructGeneration.cs:71
                                            block.AppendCode($"temp20.UserSelectedElement.Value = true;");                                  // FhirConstructGeneration.cs:72
                                        else                                                                                                // FhirConstructGeneration.cs:73
                                            block.AppendCode($"temp20.UserSelectedElement.Value = false;");                                 // FhirConstructGeneration.cs:74
                                    }                                                                                                       // FhirConstructGeneration.cs:75
                                    if (temp19.UserSelectedElement.ElementId != null)                                                       // FhirConstructGeneration.cs:137
                                        block.AppendCode($"temp20.UserSelectedElement.ElementId = \"{temp19.UserSelectedElement.ElementId}\";");// FhirConstructGeneration.cs:138
                                }                                                                                                           // FhirConstructGeneration.cs:213
                                if (temp19.ElementId != null)                                                                               // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp20.ElementId = \"{temp19.ElementId}\";");                                        // FhirConstructGeneration.cs:138
                                block.AppendCode($"temp16.ValueCoding.Add(temp20);");                                                       // FhirConstructGeneration.cs:171
                                block.CloseBrace();                                                                                         // FhirConstructGeneration.cs:172
                            }                                                                                                               // FhirConstructGeneration.cs:173
                        }                                                                                                                   // FhirConstructGeneration.cs:174
                        if (temp15.ValueCodeableConcept != null)                                                                            // FhirConstructGeneration.cs:159
                        {                                                                                                                   // FhirConstructGeneration.cs:160
                            block.AppendCode($"temp16.ValueCodeableConcept = new List<CodeableConcept>();");                                // FhirConstructGeneration.cs:161
                            foreach (var temp21 in temp15.ValueCodeableConcept)                                                             // FhirConstructGeneration.cs:162
                            {                                                                                                               // FhirConstructGeneration.cs:163
                                block.OpenBrace();                                                                                          // FhirConstructGeneration.cs:164
                                block.AppendCode("var temp22 = new CodeableConcept();");                                                    // FhirConstructGeneration.cs:165
                                if (temp21.Coding != null)                                                                                  // FhirConstructGeneration.cs:159
                                {                                                                                                           // FhirConstructGeneration.cs:160
                                    block.AppendCode($"temp22.Coding = new List<Coding>();");                                               // FhirConstructGeneration.cs:161
                                    foreach (var temp23 in temp21.Coding)                                                                   // FhirConstructGeneration.cs:162
                                    {                                                                                                       // FhirConstructGeneration.cs:163
                                        block.OpenBrace();                                                                                  // FhirConstructGeneration.cs:164
                                        block.AppendCode("var temp24 = new Coding();");                                                     // FhirConstructGeneration.cs:165
                                        if (temp23.SystemElement != null)                                                                   // FhirConstructGeneration.cs:207
                                        {                                                                                                   // FhirConstructGeneration.cs:208
                                                block.AppendCode($"temp24.SystemElement = new FhirUri();");                                 // FhirConstructGeneration.cs:209
                                            if (temp23.SystemElement.Value != null)                                                         // FhirConstructGeneration.cs:137
                                                block.AppendCode($"temp24.SystemElement.Value = \"{temp23.SystemElement.Value}\";");        // FhirConstructGeneration.cs:138
                                            if (temp23.SystemElement.ElementId != null)                                                     // FhirConstructGeneration.cs:137
                                                block.AppendCode($"temp24.SystemElement.ElementId = \"{temp23.SystemElement.ElementId}\";");// FhirConstructGeneration.cs:138
                                        }                                                                                                   // FhirConstructGeneration.cs:213
                                        if (temp23.VersionElement != null)                                                                  // FhirConstructGeneration.cs:207
                                        {                                                                                                   // FhirConstructGeneration.cs:208
                                                block.AppendCode($"temp24.VersionElement = new FhirString();");                             // FhirConstructGeneration.cs:209
                                            if (temp23.VersionElement.Value != null)                                                        // FhirConstructGeneration.cs:137
                                                block.AppendCode($"temp24.VersionElement.Value = \"{temp23.VersionElement.Value}\";");      // FhirConstructGeneration.cs:138
                                            if (temp23.VersionElement.ElementId != null)                                                    // FhirConstructGeneration.cs:137
                                                block.AppendCode($"temp24.VersionElement.ElementId = \"{temp23.VersionElement.ElementId}\";");// FhirConstructGeneration.cs:138
                                        }                                                                                                   // FhirConstructGeneration.cs:213
                                        if (temp23.CodeElement != null)                                                                     // FhirConstructGeneration.cs:207
                                        {                                                                                                   // FhirConstructGeneration.cs:208
                                                block.AppendCode($"temp24.CodeElement = new Code();");                                      // FhirConstructGeneration.cs:209
                                            if (temp23.CodeElement.Value != null)                                                           // FhirConstructGeneration.cs:137
                                                block.AppendCode($"temp24.CodeElement.Value = \"{temp23.CodeElement.Value}\";");            // FhirConstructGeneration.cs:138
                                            if (temp23.CodeElement.ElementId != null)                                                       // FhirConstructGeneration.cs:137
                                                block.AppendCode($"temp24.CodeElement.ElementId = \"{temp23.CodeElement.ElementId}\";");    // FhirConstructGeneration.cs:138
                                        }                                                                                                   // FhirConstructGeneration.cs:213
                                        if (temp23.DisplayElement != null)                                                                  // FhirConstructGeneration.cs:207
                                        {                                                                                                   // FhirConstructGeneration.cs:208
                                                block.AppendCode($"temp24.DisplayElement = new FhirString();");                             // FhirConstructGeneration.cs:209
                                            if (temp23.DisplayElement.Value != null)                                                        // FhirConstructGeneration.cs:137
                                                block.AppendCode($"temp24.DisplayElement.Value = \"{temp23.DisplayElement.Value}\";");      // FhirConstructGeneration.cs:138
                                            if (temp23.DisplayElement.ElementId != null)                                                    // FhirConstructGeneration.cs:137
                                                block.AppendCode($"temp24.DisplayElement.ElementId = \"{temp23.DisplayElement.ElementId}\";");// FhirConstructGeneration.cs:138
                                        }                                                                                                   // FhirConstructGeneration.cs:213
                                        if (temp23.UserSelectedElement != null)                                                             // FhirConstructGeneration.cs:207
                                        {                                                                                                   // FhirConstructGeneration.cs:208
                                                block.AppendCode($"temp24.UserSelectedElement = new FhirBoolean();");                       // FhirConstructGeneration.cs:209
                                            if (temp23.UserSelectedElement.Value.HasValue == true)                                          // FhirConstructGeneration.cs:69
                                            {                                                                                               // FhirConstructGeneration.cs:70
                                                if (temp23.UserSelectedElement.Value.Value == true)                                         // FhirConstructGeneration.cs:71
                                                    block.AppendCode($"temp24.UserSelectedElement.Value = true;");                          // FhirConstructGeneration.cs:72
                                                else                                                                                        // FhirConstructGeneration.cs:73
                                                    block.AppendCode($"temp24.UserSelectedElement.Value = false;");                         // FhirConstructGeneration.cs:74
                                            }                                                                                               // FhirConstructGeneration.cs:75
                                            if (temp23.UserSelectedElement.ElementId != null)                                               // FhirConstructGeneration.cs:137
                                                block.AppendCode($"temp24.UserSelectedElement.ElementId = \"{temp23.UserSelectedElement.ElementId}\";");// FhirConstructGeneration.cs:138
                                        }                                                                                                   // FhirConstructGeneration.cs:213
                                        if (temp23.ElementId != null)                                                                       // FhirConstructGeneration.cs:137
                                            block.AppendCode($"temp24.ElementId = \"{temp23.ElementId}\";");                                // FhirConstructGeneration.cs:138
                                        block.AppendCode($"temp22.Coding.Add(temp24);");                                                    // FhirConstructGeneration.cs:171
                                        block.CloseBrace();                                                                                 // FhirConstructGeneration.cs:172
                                    }                                                                                                       // FhirConstructGeneration.cs:173
                                }                                                                                                           // FhirConstructGeneration.cs:174
                                if (temp21.TextElement != null)                                                                             // FhirConstructGeneration.cs:207
                                {                                                                                                           // FhirConstructGeneration.cs:208
                                        block.AppendCode($"temp22.TextElement = new FhirString();");                                        // FhirConstructGeneration.cs:209
                                    if (temp21.TextElement.Value != null)                                                                   // FhirConstructGeneration.cs:137
                                        block.AppendCode($"temp22.TextElement.Value = \"{temp21.TextElement.Value}\";");                    // FhirConstructGeneration.cs:138
                                    if (temp21.TextElement.ElementId != null)                                                               // FhirConstructGeneration.cs:137
                                        block.AppendCode($"temp22.TextElement.ElementId = \"{temp21.TextElement.ElementId}\";");            // FhirConstructGeneration.cs:138
                                }                                                                                                           // FhirConstructGeneration.cs:213
                                if (temp21.ElementId != null)                                                                               // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp22.ElementId = \"{temp21.ElementId}\";");                                        // FhirConstructGeneration.cs:138
                                block.AppendCode($"temp16.ValueCodeableConcept.Add(temp22);");                                              // FhirConstructGeneration.cs:171
                                block.CloseBrace();                                                                                         // FhirConstructGeneration.cs:172
                            }                                                                                                               // FhirConstructGeneration.cs:173
                        }                                                                                                                   // FhirConstructGeneration.cs:174
                        if (temp15.ElementId != null)                                                                                       // FhirConstructGeneration.cs:137
                            block.AppendCode($"temp16.ElementId = \"{temp15.ElementId}\";");                                                // FhirConstructGeneration.cs:138
                        block.AppendCode($"retVal.CodeFilter.Add(temp16);");                                                                // FhirConstructGeneration.cs:171
                        block.CloseBrace();                                                                                                 // FhirConstructGeneration.cs:172
                    }                                                                                                                       // FhirConstructGeneration.cs:173
                }                                                                                                                           // FhirConstructGeneration.cs:174
                if (fix.DateFilter != null)                                                                                                 // FhirConstructGeneration.cs:159
                {                                                                                                                           // FhirConstructGeneration.cs:160
                    block.AppendCode($"retVal.DateFilter = new List<DataRequirement.DateFilterComponent>();");                              // FhirConstructGeneration.cs:161
                    foreach (var temp25 in fix.DateFilter)                                                                                  // FhirConstructGeneration.cs:162
                    {                                                                                                                       // FhirConstructGeneration.cs:163
                        block.OpenBrace();                                                                                                  // FhirConstructGeneration.cs:164
                        block.AppendCode("var temp26 = new DataRequirement.DateFilterComponent();");                                        // FhirConstructGeneration.cs:165
                        if (temp25.PathElement != null)                                                                                     // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"temp26.PathElement = new FhirString();");                                                // FhirConstructGeneration.cs:209
                            if (temp25.PathElement.Value != null)                                                                           // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp26.PathElement.Value = \"{temp25.PathElement.Value}\";");                            // FhirConstructGeneration.cs:138
                            if (temp25.PathElement.ElementId != null)                                                                       // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp26.PathElement.ElementId = \"{temp25.PathElement.ElementId}\";");                    // FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (temp25.ElementId != null)                                                                                       // FhirConstructGeneration.cs:137
                            block.AppendCode($"temp26.ElementId = \"{temp25.ElementId}\";");                                                // FhirConstructGeneration.cs:138
                        block.AppendCode($"retVal.DateFilter.Add(temp26);");                                                                // FhirConstructGeneration.cs:171
                        block.CloseBrace();                                                                                                 // FhirConstructGeneration.cs:172
                    }                                                                                                                       // FhirConstructGeneration.cs:173
                }                                                                                                                           // FhirConstructGeneration.cs:174
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:338
            block                                                                                                                           // FhirConstructGeneration.cs:339
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:340
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:341
                ;                                                                                                                           // FhirConstructGeneration.cs:342
            return  true;                                                                                                                   // FhirConstructGeneration.cs:343
        }                                                                                                                                   // FhirConstructGeneration.cs:344
                                                                                                                                            // FhirConstructGeneration.cs:315
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:319
            Distance fix,                                                                                                                   // FhirConstructGeneration.cs:320
            String methodName,                                                                                                              // FhirConstructGeneration.cs:321
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:322
        {                                                                                                                                   // FhirConstructGeneration.cs:323
                                                                                                                                            // FhirConstructGeneration.cs:325
            block                                                                                                                           // FhirConstructGeneration.cs:326
                .AppendCode($"{methodAccess} Distance {methodName}()")                                                                      // FhirConstructGeneration.cs:327
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:328
                .AppendCode("Distance retVal = new Distance();")                                                                            // FhirConstructGeneration.cs:329
                ;                                                                                                                           // FhirConstructGeneration.cs:330
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:331
            {                                                                                                                               // FhirConstructGeneration.cs:332
                if (fix.ValueElement != null)                                                                                               // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.ValueElement = new FhirDecimal();");                                                      // FhirConstructGeneration.cs:209
                    if (fix.ValueElement.Value.HasValue == true)                                                                            // FhirConstructGeneration.cs:123
                        block.AppendCode($"retVal.ValueElement.Value = new Nullable<decimal>((decimal) {fix.ValueElement.Value.Value});");  // FhirConstructGeneration.cs:124
                    if (fix.ValueElement.ElementId != null)                                                                                 // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.ValueElement.ElementId = \"{fix.ValueElement.ElementId}\";");                             // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.ComparatorElement != null)                                                                                          // FhirConstructGeneration.cs:147
                    block.AppendCode($"retVal.ComparatorElement = new Code<Quantity.QuantityComparator>(Quantity.QuantityComparator.{fix.ComparatorElement.Value});");// FhirConstructGeneration.cs:148
                if (fix.UnitElement != null)                                                                                                // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.UnitElement = new FhirString();");                                                        // FhirConstructGeneration.cs:209
                    if (fix.UnitElement.Value != null)                                                                                      // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.UnitElement.Value = \"{fix.UnitElement.Value}\";");                                       // FhirConstructGeneration.cs:138
                    if (fix.UnitElement.ElementId != null)                                                                                  // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.UnitElement.ElementId = \"{fix.UnitElement.ElementId}\";");                               // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.SystemElement != null)                                                                                              // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.SystemElement = new FhirUri();");                                                         // FhirConstructGeneration.cs:209
                    if (fix.SystemElement.Value != null)                                                                                    // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.SystemElement.Value = \"{fix.SystemElement.Value}\";");                                   // FhirConstructGeneration.cs:138
                    if (fix.SystemElement.ElementId != null)                                                                                // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.SystemElement.ElementId = \"{fix.SystemElement.ElementId}\";");                           // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.CodeElement != null)                                                                                                // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.CodeElement = new Code();");                                                              // FhirConstructGeneration.cs:209
                    if (fix.CodeElement.Value != null)                                                                                      // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.CodeElement.Value = \"{fix.CodeElement.Value}\";");                                       // FhirConstructGeneration.cs:138
                    if (fix.CodeElement.ElementId != null)                                                                                  // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.CodeElement.ElementId = \"{fix.CodeElement.ElementId}\";");                               // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:338
            block                                                                                                                           // FhirConstructGeneration.cs:339
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:340
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:341
                ;                                                                                                                           // FhirConstructGeneration.cs:342
            return  true;                                                                                                                   // FhirConstructGeneration.cs:343
        }                                                                                                                                   // FhirConstructGeneration.cs:344
                                                                                                                                            // FhirConstructGeneration.cs:315
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:319
            Dosage fix,                                                                                                                     // FhirConstructGeneration.cs:320
            String methodName,                                                                                                              // FhirConstructGeneration.cs:321
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:322
        {                                                                                                                                   // FhirConstructGeneration.cs:323
                                                                                                                                            // FhirConstructGeneration.cs:325
            block                                                                                                                           // FhirConstructGeneration.cs:326
                .AppendCode($"{methodAccess} Dosage {methodName}()")                                                                        // FhirConstructGeneration.cs:327
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:328
                .AppendCode("Dosage retVal = new Dosage();")                                                                                // FhirConstructGeneration.cs:329
                ;                                                                                                                           // FhirConstructGeneration.cs:330
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:331
            {                                                                                                                               // FhirConstructGeneration.cs:332
                if (fix.SequenceElement != null)                                                                                            // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.SequenceElement = new Integer();");                                                       // FhirConstructGeneration.cs:209
                    if (fix.SequenceElement.Value.HasValue == true)                                                                         // FhirConstructGeneration.cs:130
                        block.AppendCode($"retVal.SequenceElement.Value = new Nullable<int>((int) {fix.SequenceElement.Value.Value});");    // FhirConstructGeneration.cs:131
                    if (fix.SequenceElement.ElementId != null)                                                                              // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.SequenceElement.ElementId = \"{fix.SequenceElement.ElementId}\";");                       // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.TextElement != null)                                                                                                // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.TextElement = new FhirString();");                                                        // FhirConstructGeneration.cs:209
                    if (fix.TextElement.Value != null)                                                                                      // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.TextElement.Value = \"{fix.TextElement.Value}\";");                                       // FhirConstructGeneration.cs:138
                    if (fix.TextElement.ElementId != null)                                                                                  // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.TextElement.ElementId = \"{fix.TextElement.ElementId}\";");                               // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.AdditionalInstruction != null)                                                                                      // FhirConstructGeneration.cs:159
                {                                                                                                                           // FhirConstructGeneration.cs:160
                    block.AppendCode($"retVal.AdditionalInstruction = new List<CodeableConcept>();");                                       // FhirConstructGeneration.cs:161
                    foreach (var temp27 in fix.AdditionalInstruction)                                                                       // FhirConstructGeneration.cs:162
                    {                                                                                                                       // FhirConstructGeneration.cs:163
                        block.OpenBrace();                                                                                                  // FhirConstructGeneration.cs:164
                        block.AppendCode("var temp28 = new CodeableConcept();");                                                            // FhirConstructGeneration.cs:165
                        if (temp27.Coding != null)                                                                                          // FhirConstructGeneration.cs:159
                        {                                                                                                                   // FhirConstructGeneration.cs:160
                            block.AppendCode($"temp28.Coding = new List<Coding>();");                                                       // FhirConstructGeneration.cs:161
                            foreach (var temp29 in temp27.Coding)                                                                           // FhirConstructGeneration.cs:162
                            {                                                                                                               // FhirConstructGeneration.cs:163
                                block.OpenBrace();                                                                                          // FhirConstructGeneration.cs:164
                                block.AppendCode("var temp30 = new Coding();");                                                             // FhirConstructGeneration.cs:165
                                if (temp29.SystemElement != null)                                                                           // FhirConstructGeneration.cs:207
                                {                                                                                                           // FhirConstructGeneration.cs:208
                                        block.AppendCode($"temp30.SystemElement = new FhirUri();");                                         // FhirConstructGeneration.cs:209
                                    if (temp29.SystemElement.Value != null)                                                                 // FhirConstructGeneration.cs:137
                                        block.AppendCode($"temp30.SystemElement.Value = \"{temp29.SystemElement.Value}\";");                // FhirConstructGeneration.cs:138
                                    if (temp29.SystemElement.ElementId != null)                                                             // FhirConstructGeneration.cs:137
                                        block.AppendCode($"temp30.SystemElement.ElementId = \"{temp29.SystemElement.ElementId}\";");        // FhirConstructGeneration.cs:138
                                }                                                                                                           // FhirConstructGeneration.cs:213
                                if (temp29.VersionElement != null)                                                                          // FhirConstructGeneration.cs:207
                                {                                                                                                           // FhirConstructGeneration.cs:208
                                        block.AppendCode($"temp30.VersionElement = new FhirString();");                                     // FhirConstructGeneration.cs:209
                                    if (temp29.VersionElement.Value != null)                                                                // FhirConstructGeneration.cs:137
                                        block.AppendCode($"temp30.VersionElement.Value = \"{temp29.VersionElement.Value}\";");              // FhirConstructGeneration.cs:138
                                    if (temp29.VersionElement.ElementId != null)                                                            // FhirConstructGeneration.cs:137
                                        block.AppendCode($"temp30.VersionElement.ElementId = \"{temp29.VersionElement.ElementId}\";");      // FhirConstructGeneration.cs:138
                                }                                                                                                           // FhirConstructGeneration.cs:213
                                if (temp29.CodeElement != null)                                                                             // FhirConstructGeneration.cs:207
                                {                                                                                                           // FhirConstructGeneration.cs:208
                                        block.AppendCode($"temp30.CodeElement = new Code();");                                              // FhirConstructGeneration.cs:209
                                    if (temp29.CodeElement.Value != null)                                                                   // FhirConstructGeneration.cs:137
                                        block.AppendCode($"temp30.CodeElement.Value = \"{temp29.CodeElement.Value}\";");                    // FhirConstructGeneration.cs:138
                                    if (temp29.CodeElement.ElementId != null)                                                               // FhirConstructGeneration.cs:137
                                        block.AppendCode($"temp30.CodeElement.ElementId = \"{temp29.CodeElement.ElementId}\";");            // FhirConstructGeneration.cs:138
                                }                                                                                                           // FhirConstructGeneration.cs:213
                                if (temp29.DisplayElement != null)                                                                          // FhirConstructGeneration.cs:207
                                {                                                                                                           // FhirConstructGeneration.cs:208
                                        block.AppendCode($"temp30.DisplayElement = new FhirString();");                                     // FhirConstructGeneration.cs:209
                                    if (temp29.DisplayElement.Value != null)                                                                // FhirConstructGeneration.cs:137
                                        block.AppendCode($"temp30.DisplayElement.Value = \"{temp29.DisplayElement.Value}\";");              // FhirConstructGeneration.cs:138
                                    if (temp29.DisplayElement.ElementId != null)                                                            // FhirConstructGeneration.cs:137
                                        block.AppendCode($"temp30.DisplayElement.ElementId = \"{temp29.DisplayElement.ElementId}\";");      // FhirConstructGeneration.cs:138
                                }                                                                                                           // FhirConstructGeneration.cs:213
                                if (temp29.UserSelectedElement != null)                                                                     // FhirConstructGeneration.cs:207
                                {                                                                                                           // FhirConstructGeneration.cs:208
                                        block.AppendCode($"temp30.UserSelectedElement = new FhirBoolean();");                               // FhirConstructGeneration.cs:209
                                    if (temp29.UserSelectedElement.Value.HasValue == true)                                                  // FhirConstructGeneration.cs:69
                                    {                                                                                                       // FhirConstructGeneration.cs:70
                                        if (temp29.UserSelectedElement.Value.Value == true)                                                 // FhirConstructGeneration.cs:71
                                            block.AppendCode($"temp30.UserSelectedElement.Value = true;");                                  // FhirConstructGeneration.cs:72
                                        else                                                                                                // FhirConstructGeneration.cs:73
                                            block.AppendCode($"temp30.UserSelectedElement.Value = false;");                                 // FhirConstructGeneration.cs:74
                                    }                                                                                                       // FhirConstructGeneration.cs:75
                                    if (temp29.UserSelectedElement.ElementId != null)                                                       // FhirConstructGeneration.cs:137
                                        block.AppendCode($"temp30.UserSelectedElement.ElementId = \"{temp29.UserSelectedElement.ElementId}\";");// FhirConstructGeneration.cs:138
                                }                                                                                                           // FhirConstructGeneration.cs:213
                                if (temp29.ElementId != null)                                                                               // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp30.ElementId = \"{temp29.ElementId}\";");                                        // FhirConstructGeneration.cs:138
                                block.AppendCode($"temp28.Coding.Add(temp30);");                                                            // FhirConstructGeneration.cs:171
                                block.CloseBrace();                                                                                         // FhirConstructGeneration.cs:172
                            }                                                                                                               // FhirConstructGeneration.cs:173
                        }                                                                                                                   // FhirConstructGeneration.cs:174
                        if (temp27.TextElement != null)                                                                                     // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"temp28.TextElement = new FhirString();");                                                // FhirConstructGeneration.cs:209
                            if (temp27.TextElement.Value != null)                                                                           // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp28.TextElement.Value = \"{temp27.TextElement.Value}\";");                            // FhirConstructGeneration.cs:138
                            if (temp27.TextElement.ElementId != null)                                                                       // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp28.TextElement.ElementId = \"{temp27.TextElement.ElementId}\";");                    // FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (temp27.ElementId != null)                                                                                       // FhirConstructGeneration.cs:137
                            block.AppendCode($"temp28.ElementId = \"{temp27.ElementId}\";");                                                // FhirConstructGeneration.cs:138
                        block.AppendCode($"retVal.AdditionalInstruction.Add(temp28);");                                                     // FhirConstructGeneration.cs:171
                        block.CloseBrace();                                                                                                 // FhirConstructGeneration.cs:172
                    }                                                                                                                       // FhirConstructGeneration.cs:173
                }                                                                                                                           // FhirConstructGeneration.cs:174
                if (fix.PatientInstructionElement != null)                                                                                  // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.PatientInstructionElement = new FhirString();");                                          // FhirConstructGeneration.cs:209
                    if (fix.PatientInstructionElement.Value != null)                                                                        // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.PatientInstructionElement.Value = \"{fix.PatientInstructionElement.Value}\";");           // FhirConstructGeneration.cs:138
                    if (fix.PatientInstructionElement.ElementId != null)                                                                    // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.PatientInstructionElement.ElementId = \"{fix.PatientInstructionElement.ElementId}\";");   // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.Timing != null)                                                                                                     // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.Timing = new Timing();");                                                                 // FhirConstructGeneration.cs:209
                    if (fix.Timing.EventElement != null)                                                                                    // FhirConstructGeneration.cs:159
                    {                                                                                                                       // FhirConstructGeneration.cs:160
                        block.AppendCode($"retVal.Timing.EventElement = new List<FhirDateTime>();");                                        // FhirConstructGeneration.cs:161
                        foreach (var temp31 in fix.Timing.EventElement)                                                                     // FhirConstructGeneration.cs:162
                        {                                                                                                                   // FhirConstructGeneration.cs:163
                            block.OpenBrace();                                                                                              // FhirConstructGeneration.cs:164
                            block.AppendCode("var temp32 = new FhirDateTime();");                                                           // FhirConstructGeneration.cs:165
                            if (temp31.Value != null)                                                                                       // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp32.Value = \"{temp31.Value}\";");                                                    // FhirConstructGeneration.cs:138
                            if (temp31.ElementId != null)                                                                                   // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp32.ElementId = \"{temp31.ElementId}\";");                                            // FhirConstructGeneration.cs:138
                            block.AppendCode($"retVal.Timing.EventElement.Add(temp32);");                                                   // FhirConstructGeneration.cs:171
                            block.CloseBrace();                                                                                             // FhirConstructGeneration.cs:172
                        }                                                                                                                   // FhirConstructGeneration.cs:173
                    }                                                                                                                       // FhirConstructGeneration.cs:174
                    if (fix.Timing.Repeat != null)                                                                                          // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Timing.Repeat = new Timing.RepeatComponent();");                                      // FhirConstructGeneration.cs:209
                        if (fix.Timing.Repeat.CountElement != null)                                                                         // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"retVal.Timing.Repeat.CountElement = new Integer();");                                    // FhirConstructGeneration.cs:209
                            if (fix.Timing.Repeat.CountElement.Value.HasValue == true)                                                      // FhirConstructGeneration.cs:130
                                block.AppendCode($"retVal.Timing.Repeat.CountElement.Value = new Nullable<int>((int) {fix.Timing.Repeat.CountElement.Value.Value});");// FhirConstructGeneration.cs:131
                            if (fix.Timing.Repeat.CountElement.ElementId != null)                                                           // FhirConstructGeneration.cs:137
                                block.AppendCode($"retVal.Timing.Repeat.CountElement.ElementId = \"{fix.Timing.Repeat.CountElement.ElementId}\";");// FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (fix.Timing.Repeat.CountMaxElement != null)                                                                      // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"retVal.Timing.Repeat.CountMaxElement = new Integer();");                                 // FhirConstructGeneration.cs:209
                            if (fix.Timing.Repeat.CountMaxElement.Value.HasValue == true)                                                   // FhirConstructGeneration.cs:130
                                block.AppendCode($"retVal.Timing.Repeat.CountMaxElement.Value = new Nullable<int>((int) {fix.Timing.Repeat.CountMaxElement.Value.Value});");// FhirConstructGeneration.cs:131
                            if (fix.Timing.Repeat.CountMaxElement.ElementId != null)                                                        // FhirConstructGeneration.cs:137
                                block.AppendCode($"retVal.Timing.Repeat.CountMaxElement.ElementId = \"{fix.Timing.Repeat.CountMaxElement.ElementId}\";");// FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (fix.Timing.Repeat.DurationElement != null)                                                                      // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"retVal.Timing.Repeat.DurationElement = new FhirDecimal();");                             // FhirConstructGeneration.cs:209
                            if (fix.Timing.Repeat.DurationElement.Value.HasValue == true)                                                   // FhirConstructGeneration.cs:123
                                block.AppendCode($"retVal.Timing.Repeat.DurationElement.Value = new Nullable<decimal>((decimal) {fix.Timing.Repeat.DurationElement.Value.Value});");// FhirConstructGeneration.cs:124
                            if (fix.Timing.Repeat.DurationElement.ElementId != null)                                                        // FhirConstructGeneration.cs:137
                                block.AppendCode($"retVal.Timing.Repeat.DurationElement.ElementId = \"{fix.Timing.Repeat.DurationElement.ElementId}\";");// FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (fix.Timing.Repeat.DurationMaxElement != null)                                                                   // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"retVal.Timing.Repeat.DurationMaxElement = new FhirDecimal();");                          // FhirConstructGeneration.cs:209
                            if (fix.Timing.Repeat.DurationMaxElement.Value.HasValue == true)                                                // FhirConstructGeneration.cs:123
                                block.AppendCode($"retVal.Timing.Repeat.DurationMaxElement.Value = new Nullable<decimal>((decimal) {fix.Timing.Repeat.DurationMaxElement.Value.Value});");// FhirConstructGeneration.cs:124
                            if (fix.Timing.Repeat.DurationMaxElement.ElementId != null)                                                     // FhirConstructGeneration.cs:137
                                block.AppendCode($"retVal.Timing.Repeat.DurationMaxElement.ElementId = \"{fix.Timing.Repeat.DurationMaxElement.ElementId}\";");// FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (fix.Timing.Repeat.DurationUnitElement != null)                                                                  // FhirConstructGeneration.cs:147
                            block.AppendCode($"retVal.Timing.Repeat.DurationUnitElement = new Code<Timing.UnitsOfTime>(Timing.UnitsOfTime.{fix.Timing.Repeat.DurationUnitElement.Value});");// FhirConstructGeneration.cs:148
                        if (fix.Timing.Repeat.FrequencyElement != null)                                                                     // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"retVal.Timing.Repeat.FrequencyElement = new Integer();");                                // FhirConstructGeneration.cs:209
                            if (fix.Timing.Repeat.FrequencyElement.Value.HasValue == true)                                                  // FhirConstructGeneration.cs:130
                                block.AppendCode($"retVal.Timing.Repeat.FrequencyElement.Value = new Nullable<int>((int) {fix.Timing.Repeat.FrequencyElement.Value.Value});");// FhirConstructGeneration.cs:131
                            if (fix.Timing.Repeat.FrequencyElement.ElementId != null)                                                       // FhirConstructGeneration.cs:137
                                block.AppendCode($"retVal.Timing.Repeat.FrequencyElement.ElementId = \"{fix.Timing.Repeat.FrequencyElement.ElementId}\";");// FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (fix.Timing.Repeat.FrequencyMaxElement != null)                                                                  // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"retVal.Timing.Repeat.FrequencyMaxElement = new Integer();");                             // FhirConstructGeneration.cs:209
                            if (fix.Timing.Repeat.FrequencyMaxElement.Value.HasValue == true)                                               // FhirConstructGeneration.cs:130
                                block.AppendCode($"retVal.Timing.Repeat.FrequencyMaxElement.Value = new Nullable<int>((int) {fix.Timing.Repeat.FrequencyMaxElement.Value.Value});");// FhirConstructGeneration.cs:131
                            if (fix.Timing.Repeat.FrequencyMaxElement.ElementId != null)                                                    // FhirConstructGeneration.cs:137
                                block.AppendCode($"retVal.Timing.Repeat.FrequencyMaxElement.ElementId = \"{fix.Timing.Repeat.FrequencyMaxElement.ElementId}\";");// FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (fix.Timing.Repeat.PeriodElement != null)                                                                        // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"retVal.Timing.Repeat.PeriodElement = new FhirDecimal();");                               // FhirConstructGeneration.cs:209
                            if (fix.Timing.Repeat.PeriodElement.Value.HasValue == true)                                                     // FhirConstructGeneration.cs:123
                                block.AppendCode($"retVal.Timing.Repeat.PeriodElement.Value = new Nullable<decimal>((decimal) {fix.Timing.Repeat.PeriodElement.Value.Value});");// FhirConstructGeneration.cs:124
                            if (fix.Timing.Repeat.PeriodElement.ElementId != null)                                                          // FhirConstructGeneration.cs:137
                                block.AppendCode($"retVal.Timing.Repeat.PeriodElement.ElementId = \"{fix.Timing.Repeat.PeriodElement.ElementId}\";");// FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (fix.Timing.Repeat.PeriodMaxElement != null)                                                                     // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"retVal.Timing.Repeat.PeriodMaxElement = new FhirDecimal();");                            // FhirConstructGeneration.cs:209
                            if (fix.Timing.Repeat.PeriodMaxElement.Value.HasValue == true)                                                  // FhirConstructGeneration.cs:123
                                block.AppendCode($"retVal.Timing.Repeat.PeriodMaxElement.Value = new Nullable<decimal>((decimal) {fix.Timing.Repeat.PeriodMaxElement.Value.Value});");// FhirConstructGeneration.cs:124
                            if (fix.Timing.Repeat.PeriodMaxElement.ElementId != null)                                                       // FhirConstructGeneration.cs:137
                                block.AppendCode($"retVal.Timing.Repeat.PeriodMaxElement.ElementId = \"{fix.Timing.Repeat.PeriodMaxElement.ElementId}\";");// FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (fix.Timing.Repeat.PeriodUnitElement != null)                                                                    // FhirConstructGeneration.cs:147
                            block.AppendCode($"retVal.Timing.Repeat.PeriodUnitElement = new Code<Timing.UnitsOfTime>(Timing.UnitsOfTime.{fix.Timing.Repeat.PeriodUnitElement.Value});");// FhirConstructGeneration.cs:148
                        if (fix.Timing.Repeat.DayOfWeekElement != null)                                                                     // FhirConstructGeneration.cs:159
                        {                                                                                                                   // FhirConstructGeneration.cs:160
                            block.AppendCode($"retVal.Timing.Repeat.DayOfWeekElement = new List<Code<DaysOfWeek>>();");                     // FhirConstructGeneration.cs:161
                            foreach (var temp33 in fix.Timing.Repeat.DayOfWeekElement)                                                      // FhirConstructGeneration.cs:162
                            {                                                                                                               // FhirConstructGeneration.cs:163
                                block.OpenBrace();                                                                                          // FhirConstructGeneration.cs:164
                                block.AppendCode("var temp34 = new Code<DaysOfWeek>();");                                                   // FhirConstructGeneration.cs:165
                                if (temp33.Value.HasValue == true)                                                                          // FhirConstructGeneration.cs:184
                                    block.AppendCode($"temp34.Value = DaysOfWeek.{temp33.Value.Value};");                                   // FhirConstructGeneration.cs:185
                                if (temp33.ElementId != null)                                                                               // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp34.ElementId = \"{temp33.ElementId}\";");                                        // FhirConstructGeneration.cs:138
                                block.AppendCode($"retVal.Timing.Repeat.DayOfWeekElement.Add(temp34);");                                    // FhirConstructGeneration.cs:171
                                block.CloseBrace();                                                                                         // FhirConstructGeneration.cs:172
                            }                                                                                                               // FhirConstructGeneration.cs:173
                        }                                                                                                                   // FhirConstructGeneration.cs:174
                        if (fix.Timing.Repeat.TimeOfDayElement != null)                                                                     // FhirConstructGeneration.cs:159
                        {                                                                                                                   // FhirConstructGeneration.cs:160
                            block.AppendCode($"retVal.Timing.Repeat.TimeOfDayElement = new List<Time>();");                                 // FhirConstructGeneration.cs:161
                            foreach (var temp35 in fix.Timing.Repeat.TimeOfDayElement)                                                      // FhirConstructGeneration.cs:162
                            {                                                                                                               // FhirConstructGeneration.cs:163
                                block.OpenBrace();                                                                                          // FhirConstructGeneration.cs:164
                                block.AppendCode("var temp36 = new Time();");                                                               // FhirConstructGeneration.cs:165
                                if (temp35.Value != null)                                                                                   // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp36.Value = \"{temp35.Value}\";");                                                // FhirConstructGeneration.cs:138
                                if (temp35.ElementId != null)                                                                               // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp36.ElementId = \"{temp35.ElementId}\";");                                        // FhirConstructGeneration.cs:138
                                block.AppendCode($"retVal.Timing.Repeat.TimeOfDayElement.Add(temp36);");                                    // FhirConstructGeneration.cs:171
                                block.CloseBrace();                                                                                         // FhirConstructGeneration.cs:172
                            }                                                                                                               // FhirConstructGeneration.cs:173
                        }                                                                                                                   // FhirConstructGeneration.cs:174
                        if (fix.Timing.Repeat.WhenElement != null)                                                                          // FhirConstructGeneration.cs:159
                        {                                                                                                                   // FhirConstructGeneration.cs:160
                            block.AppendCode($"retVal.Timing.Repeat.WhenElement = new List<Code<Timing.EventTiming>>();");                  // FhirConstructGeneration.cs:161
                            foreach (var temp37 in fix.Timing.Repeat.WhenElement)                                                           // FhirConstructGeneration.cs:162
                            {                                                                                                               // FhirConstructGeneration.cs:163
                                block.OpenBrace();                                                                                          // FhirConstructGeneration.cs:164
                                block.AppendCode("var temp38 = new Code<Timing.EventTiming>();");                                           // FhirConstructGeneration.cs:165
                                if (temp37.Value.HasValue == true)                                                                          // FhirConstructGeneration.cs:184
                                    block.AppendCode($"temp38.Value = Timing.EventTiming.{temp37.Value.Value};");                           // FhirConstructGeneration.cs:185
                                if (temp37.ElementId != null)                                                                               // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp38.ElementId = \"{temp37.ElementId}\";");                                        // FhirConstructGeneration.cs:138
                                block.AppendCode($"retVal.Timing.Repeat.WhenElement.Add(temp38);");                                         // FhirConstructGeneration.cs:171
                                block.CloseBrace();                                                                                         // FhirConstructGeneration.cs:172
                            }                                                                                                               // FhirConstructGeneration.cs:173
                        }                                                                                                                   // FhirConstructGeneration.cs:174
                        if (fix.Timing.Repeat.OffsetElement != null)                                                                        // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"retVal.Timing.Repeat.OffsetElement = new UnsignedInt();");                               // FhirConstructGeneration.cs:209
                            if (fix.Timing.Repeat.OffsetElement.Value.HasValue == true)                                                     // FhirConstructGeneration.cs:130
                                block.AppendCode($"retVal.Timing.Repeat.OffsetElement.Value = new Nullable<int>((int) {fix.Timing.Repeat.OffsetElement.Value.Value});");// FhirConstructGeneration.cs:131
                            if (fix.Timing.Repeat.OffsetElement.ElementId != null)                                                          // FhirConstructGeneration.cs:137
                                block.AppendCode($"retVal.Timing.Repeat.OffsetElement.ElementId = \"{fix.Timing.Repeat.OffsetElement.ElementId}\";");// FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (fix.Timing.Repeat.ElementId != null)                                                                            // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Timing.Repeat.ElementId = \"{fix.Timing.Repeat.ElementId}\";");                       // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Timing.Code != null)                                                                                            // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Timing.Code = new CodeableConcept();");                                               // FhirConstructGeneration.cs:209
                        if (fix.Timing.Code.Coding != null)                                                                                 // FhirConstructGeneration.cs:159
                        {                                                                                                                   // FhirConstructGeneration.cs:160
                            block.AppendCode($"retVal.Timing.Code.Coding = new List<Coding>();");                                           // FhirConstructGeneration.cs:161
                            foreach (var temp39 in fix.Timing.Code.Coding)                                                                  // FhirConstructGeneration.cs:162
                            {                                                                                                               // FhirConstructGeneration.cs:163
                                block.OpenBrace();                                                                                          // FhirConstructGeneration.cs:164
                                block.AppendCode("var temp40 = new Coding();");                                                             // FhirConstructGeneration.cs:165
                                if (temp39.SystemElement != null)                                                                           // FhirConstructGeneration.cs:207
                                {                                                                                                           // FhirConstructGeneration.cs:208
                                        block.AppendCode($"temp40.SystemElement = new FhirUri();");                                         // FhirConstructGeneration.cs:209
                                    if (temp39.SystemElement.Value != null)                                                                 // FhirConstructGeneration.cs:137
                                        block.AppendCode($"temp40.SystemElement.Value = \"{temp39.SystemElement.Value}\";");                // FhirConstructGeneration.cs:138
                                    if (temp39.SystemElement.ElementId != null)                                                             // FhirConstructGeneration.cs:137
                                        block.AppendCode($"temp40.SystemElement.ElementId = \"{temp39.SystemElement.ElementId}\";");        // FhirConstructGeneration.cs:138
                                }                                                                                                           // FhirConstructGeneration.cs:213
                                if (temp39.VersionElement != null)                                                                          // FhirConstructGeneration.cs:207
                                {                                                                                                           // FhirConstructGeneration.cs:208
                                        block.AppendCode($"temp40.VersionElement = new FhirString();");                                     // FhirConstructGeneration.cs:209
                                    if (temp39.VersionElement.Value != null)                                                                // FhirConstructGeneration.cs:137
                                        block.AppendCode($"temp40.VersionElement.Value = \"{temp39.VersionElement.Value}\";");              // FhirConstructGeneration.cs:138
                                    if (temp39.VersionElement.ElementId != null)                                                            // FhirConstructGeneration.cs:137
                                        block.AppendCode($"temp40.VersionElement.ElementId = \"{temp39.VersionElement.ElementId}\";");      // FhirConstructGeneration.cs:138
                                }                                                                                                           // FhirConstructGeneration.cs:213
                                if (temp39.CodeElement != null)                                                                             // FhirConstructGeneration.cs:207
                                {                                                                                                           // FhirConstructGeneration.cs:208
                                        block.AppendCode($"temp40.CodeElement = new Code();");                                              // FhirConstructGeneration.cs:209
                                    if (temp39.CodeElement.Value != null)                                                                   // FhirConstructGeneration.cs:137
                                        block.AppendCode($"temp40.CodeElement.Value = \"{temp39.CodeElement.Value}\";");                    // FhirConstructGeneration.cs:138
                                    if (temp39.CodeElement.ElementId != null)                                                               // FhirConstructGeneration.cs:137
                                        block.AppendCode($"temp40.CodeElement.ElementId = \"{temp39.CodeElement.ElementId}\";");            // FhirConstructGeneration.cs:138
                                }                                                                                                           // FhirConstructGeneration.cs:213
                                if (temp39.DisplayElement != null)                                                                          // FhirConstructGeneration.cs:207
                                {                                                                                                           // FhirConstructGeneration.cs:208
                                        block.AppendCode($"temp40.DisplayElement = new FhirString();");                                     // FhirConstructGeneration.cs:209
                                    if (temp39.DisplayElement.Value != null)                                                                // FhirConstructGeneration.cs:137
                                        block.AppendCode($"temp40.DisplayElement.Value = \"{temp39.DisplayElement.Value}\";");              // FhirConstructGeneration.cs:138
                                    if (temp39.DisplayElement.ElementId != null)                                                            // FhirConstructGeneration.cs:137
                                        block.AppendCode($"temp40.DisplayElement.ElementId = \"{temp39.DisplayElement.ElementId}\";");      // FhirConstructGeneration.cs:138
                                }                                                                                                           // FhirConstructGeneration.cs:213
                                if (temp39.UserSelectedElement != null)                                                                     // FhirConstructGeneration.cs:207
                                {                                                                                                           // FhirConstructGeneration.cs:208
                                        block.AppendCode($"temp40.UserSelectedElement = new FhirBoolean();");                               // FhirConstructGeneration.cs:209
                                    if (temp39.UserSelectedElement.Value.HasValue == true)                                                  // FhirConstructGeneration.cs:69
                                    {                                                                                                       // FhirConstructGeneration.cs:70
                                        if (temp39.UserSelectedElement.Value.Value == true)                                                 // FhirConstructGeneration.cs:71
                                            block.AppendCode($"temp40.UserSelectedElement.Value = true;");                                  // FhirConstructGeneration.cs:72
                                        else                                                                                                // FhirConstructGeneration.cs:73
                                            block.AppendCode($"temp40.UserSelectedElement.Value = false;");                                 // FhirConstructGeneration.cs:74
                                    }                                                                                                       // FhirConstructGeneration.cs:75
                                    if (temp39.UserSelectedElement.ElementId != null)                                                       // FhirConstructGeneration.cs:137
                                        block.AppendCode($"temp40.UserSelectedElement.ElementId = \"{temp39.UserSelectedElement.ElementId}\";");// FhirConstructGeneration.cs:138
                                }                                                                                                           // FhirConstructGeneration.cs:213
                                if (temp39.ElementId != null)                                                                               // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp40.ElementId = \"{temp39.ElementId}\";");                                        // FhirConstructGeneration.cs:138
                                block.AppendCode($"retVal.Timing.Code.Coding.Add(temp40);");                                                // FhirConstructGeneration.cs:171
                                block.CloseBrace();                                                                                         // FhirConstructGeneration.cs:172
                            }                                                                                                               // FhirConstructGeneration.cs:173
                        }                                                                                                                   // FhirConstructGeneration.cs:174
                        if (fix.Timing.Code.TextElement != null)                                                                            // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"retVal.Timing.Code.TextElement = new FhirString();");                                    // FhirConstructGeneration.cs:209
                            if (fix.Timing.Code.TextElement.Value != null)                                                                  // FhirConstructGeneration.cs:137
                                block.AppendCode($"retVal.Timing.Code.TextElement.Value = \"{fix.Timing.Code.TextElement.Value}\";");       // FhirConstructGeneration.cs:138
                            if (fix.Timing.Code.TextElement.ElementId != null)                                                              // FhirConstructGeneration.cs:137
                                block.AppendCode($"retVal.Timing.Code.TextElement.ElementId = \"{fix.Timing.Code.TextElement.ElementId}\";");// FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (fix.Timing.Code.ElementId != null)                                                                              // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Timing.Code.ElementId = \"{fix.Timing.Code.ElementId}\";");                           // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Timing.ElementId != null)                                                                                       // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.Timing.ElementId = \"{fix.Timing.ElementId}\";");                                         // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.Site != null)                                                                                                       // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.Site = new CodeableConcept();");                                                          // FhirConstructGeneration.cs:209
                    if (fix.Site.Coding != null)                                                                                            // FhirConstructGeneration.cs:159
                    {                                                                                                                       // FhirConstructGeneration.cs:160
                        block.AppendCode($"retVal.Site.Coding = new List<Coding>();");                                                      // FhirConstructGeneration.cs:161
                        foreach (var temp41 in fix.Site.Coding)                                                                             // FhirConstructGeneration.cs:162
                        {                                                                                                                   // FhirConstructGeneration.cs:163
                            block.OpenBrace();                                                                                              // FhirConstructGeneration.cs:164
                            block.AppendCode("var temp42 = new Coding();");                                                                 // FhirConstructGeneration.cs:165
                            if (temp41.SystemElement != null)                                                                               // FhirConstructGeneration.cs:207
                            {                                                                                                               // FhirConstructGeneration.cs:208
                                    block.AppendCode($"temp42.SystemElement = new FhirUri();");                                             // FhirConstructGeneration.cs:209
                                if (temp41.SystemElement.Value != null)                                                                     // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp42.SystemElement.Value = \"{temp41.SystemElement.Value}\";");                    // FhirConstructGeneration.cs:138
                                if (temp41.SystemElement.ElementId != null)                                                                 // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp42.SystemElement.ElementId = \"{temp41.SystemElement.ElementId}\";");            // FhirConstructGeneration.cs:138
                            }                                                                                                               // FhirConstructGeneration.cs:213
                            if (temp41.VersionElement != null)                                                                              // FhirConstructGeneration.cs:207
                            {                                                                                                               // FhirConstructGeneration.cs:208
                                    block.AppendCode($"temp42.VersionElement = new FhirString();");                                         // FhirConstructGeneration.cs:209
                                if (temp41.VersionElement.Value != null)                                                                    // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp42.VersionElement.Value = \"{temp41.VersionElement.Value}\";");                  // FhirConstructGeneration.cs:138
                                if (temp41.VersionElement.ElementId != null)                                                                // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp42.VersionElement.ElementId = \"{temp41.VersionElement.ElementId}\";");          // FhirConstructGeneration.cs:138
                            }                                                                                                               // FhirConstructGeneration.cs:213
                            if (temp41.CodeElement != null)                                                                                 // FhirConstructGeneration.cs:207
                            {                                                                                                               // FhirConstructGeneration.cs:208
                                    block.AppendCode($"temp42.CodeElement = new Code();");                                                  // FhirConstructGeneration.cs:209
                                if (temp41.CodeElement.Value != null)                                                                       // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp42.CodeElement.Value = \"{temp41.CodeElement.Value}\";");                        // FhirConstructGeneration.cs:138
                                if (temp41.CodeElement.ElementId != null)                                                                   // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp42.CodeElement.ElementId = \"{temp41.CodeElement.ElementId}\";");                // FhirConstructGeneration.cs:138
                            }                                                                                                               // FhirConstructGeneration.cs:213
                            if (temp41.DisplayElement != null)                                                                              // FhirConstructGeneration.cs:207
                            {                                                                                                               // FhirConstructGeneration.cs:208
                                    block.AppendCode($"temp42.DisplayElement = new FhirString();");                                         // FhirConstructGeneration.cs:209
                                if (temp41.DisplayElement.Value != null)                                                                    // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp42.DisplayElement.Value = \"{temp41.DisplayElement.Value}\";");                  // FhirConstructGeneration.cs:138
                                if (temp41.DisplayElement.ElementId != null)                                                                // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp42.DisplayElement.ElementId = \"{temp41.DisplayElement.ElementId}\";");          // FhirConstructGeneration.cs:138
                            }                                                                                                               // FhirConstructGeneration.cs:213
                            if (temp41.UserSelectedElement != null)                                                                         // FhirConstructGeneration.cs:207
                            {                                                                                                               // FhirConstructGeneration.cs:208
                                    block.AppendCode($"temp42.UserSelectedElement = new FhirBoolean();");                                   // FhirConstructGeneration.cs:209
                                if (temp41.UserSelectedElement.Value.HasValue == true)                                                      // FhirConstructGeneration.cs:69
                                {                                                                                                           // FhirConstructGeneration.cs:70
                                    if (temp41.UserSelectedElement.Value.Value == true)                                                     // FhirConstructGeneration.cs:71
                                        block.AppendCode($"temp42.UserSelectedElement.Value = true;");                                      // FhirConstructGeneration.cs:72
                                    else                                                                                                    // FhirConstructGeneration.cs:73
                                        block.AppendCode($"temp42.UserSelectedElement.Value = false;");                                     // FhirConstructGeneration.cs:74
                                }                                                                                                           // FhirConstructGeneration.cs:75
                                if (temp41.UserSelectedElement.ElementId != null)                                                           // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp42.UserSelectedElement.ElementId = \"{temp41.UserSelectedElement.ElementId}\";");// FhirConstructGeneration.cs:138
                            }                                                                                                               // FhirConstructGeneration.cs:213
                            if (temp41.ElementId != null)                                                                                   // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp42.ElementId = \"{temp41.ElementId}\";");                                            // FhirConstructGeneration.cs:138
                            block.AppendCode($"retVal.Site.Coding.Add(temp42);");                                                           // FhirConstructGeneration.cs:171
                            block.CloseBrace();                                                                                             // FhirConstructGeneration.cs:172
                        }                                                                                                                   // FhirConstructGeneration.cs:173
                    }                                                                                                                       // FhirConstructGeneration.cs:174
                    if (fix.Site.TextElement != null)                                                                                       // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Site.TextElement = new FhirString();");                                               // FhirConstructGeneration.cs:209
                        if (fix.Site.TextElement.Value != null)                                                                             // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Site.TextElement.Value = \"{fix.Site.TextElement.Value}\";");                         // FhirConstructGeneration.cs:138
                        if (fix.Site.TextElement.ElementId != null)                                                                         // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Site.TextElement.ElementId = \"{fix.Site.TextElement.ElementId}\";");                 // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Site.ElementId != null)                                                                                         // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.Site.ElementId = \"{fix.Site.ElementId}\";");                                             // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.Route != null)                                                                                                      // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.Route = new CodeableConcept();");                                                         // FhirConstructGeneration.cs:209
                    if (fix.Route.Coding != null)                                                                                           // FhirConstructGeneration.cs:159
                    {                                                                                                                       // FhirConstructGeneration.cs:160
                        block.AppendCode($"retVal.Route.Coding = new List<Coding>();");                                                     // FhirConstructGeneration.cs:161
                        foreach (var temp43 in fix.Route.Coding)                                                                            // FhirConstructGeneration.cs:162
                        {                                                                                                                   // FhirConstructGeneration.cs:163
                            block.OpenBrace();                                                                                              // FhirConstructGeneration.cs:164
                            block.AppendCode("var temp44 = new Coding();");                                                                 // FhirConstructGeneration.cs:165
                            if (temp43.SystemElement != null)                                                                               // FhirConstructGeneration.cs:207
                            {                                                                                                               // FhirConstructGeneration.cs:208
                                    block.AppendCode($"temp44.SystemElement = new FhirUri();");                                             // FhirConstructGeneration.cs:209
                                if (temp43.SystemElement.Value != null)                                                                     // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp44.SystemElement.Value = \"{temp43.SystemElement.Value}\";");                    // FhirConstructGeneration.cs:138
                                if (temp43.SystemElement.ElementId != null)                                                                 // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp44.SystemElement.ElementId = \"{temp43.SystemElement.ElementId}\";");            // FhirConstructGeneration.cs:138
                            }                                                                                                               // FhirConstructGeneration.cs:213
                            if (temp43.VersionElement != null)                                                                              // FhirConstructGeneration.cs:207
                            {                                                                                                               // FhirConstructGeneration.cs:208
                                    block.AppendCode($"temp44.VersionElement = new FhirString();");                                         // FhirConstructGeneration.cs:209
                                if (temp43.VersionElement.Value != null)                                                                    // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp44.VersionElement.Value = \"{temp43.VersionElement.Value}\";");                  // FhirConstructGeneration.cs:138
                                if (temp43.VersionElement.ElementId != null)                                                                // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp44.VersionElement.ElementId = \"{temp43.VersionElement.ElementId}\";");          // FhirConstructGeneration.cs:138
                            }                                                                                                               // FhirConstructGeneration.cs:213
                            if (temp43.CodeElement != null)                                                                                 // FhirConstructGeneration.cs:207
                            {                                                                                                               // FhirConstructGeneration.cs:208
                                    block.AppendCode($"temp44.CodeElement = new Code();");                                                  // FhirConstructGeneration.cs:209
                                if (temp43.CodeElement.Value != null)                                                                       // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp44.CodeElement.Value = \"{temp43.CodeElement.Value}\";");                        // FhirConstructGeneration.cs:138
                                if (temp43.CodeElement.ElementId != null)                                                                   // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp44.CodeElement.ElementId = \"{temp43.CodeElement.ElementId}\";");                // FhirConstructGeneration.cs:138
                            }                                                                                                               // FhirConstructGeneration.cs:213
                            if (temp43.DisplayElement != null)                                                                              // FhirConstructGeneration.cs:207
                            {                                                                                                               // FhirConstructGeneration.cs:208
                                    block.AppendCode($"temp44.DisplayElement = new FhirString();");                                         // FhirConstructGeneration.cs:209
                                if (temp43.DisplayElement.Value != null)                                                                    // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp44.DisplayElement.Value = \"{temp43.DisplayElement.Value}\";");                  // FhirConstructGeneration.cs:138
                                if (temp43.DisplayElement.ElementId != null)                                                                // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp44.DisplayElement.ElementId = \"{temp43.DisplayElement.ElementId}\";");          // FhirConstructGeneration.cs:138
                            }                                                                                                               // FhirConstructGeneration.cs:213
                            if (temp43.UserSelectedElement != null)                                                                         // FhirConstructGeneration.cs:207
                            {                                                                                                               // FhirConstructGeneration.cs:208
                                    block.AppendCode($"temp44.UserSelectedElement = new FhirBoolean();");                                   // FhirConstructGeneration.cs:209
                                if (temp43.UserSelectedElement.Value.HasValue == true)                                                      // FhirConstructGeneration.cs:69
                                {                                                                                                           // FhirConstructGeneration.cs:70
                                    if (temp43.UserSelectedElement.Value.Value == true)                                                     // FhirConstructGeneration.cs:71
                                        block.AppendCode($"temp44.UserSelectedElement.Value = true;");                                      // FhirConstructGeneration.cs:72
                                    else                                                                                                    // FhirConstructGeneration.cs:73
                                        block.AppendCode($"temp44.UserSelectedElement.Value = false;");                                     // FhirConstructGeneration.cs:74
                                }                                                                                                           // FhirConstructGeneration.cs:75
                                if (temp43.UserSelectedElement.ElementId != null)                                                           // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp44.UserSelectedElement.ElementId = \"{temp43.UserSelectedElement.ElementId}\";");// FhirConstructGeneration.cs:138
                            }                                                                                                               // FhirConstructGeneration.cs:213
                            if (temp43.ElementId != null)                                                                                   // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp44.ElementId = \"{temp43.ElementId}\";");                                            // FhirConstructGeneration.cs:138
                            block.AppendCode($"retVal.Route.Coding.Add(temp44);");                                                          // FhirConstructGeneration.cs:171
                            block.CloseBrace();                                                                                             // FhirConstructGeneration.cs:172
                        }                                                                                                                   // FhirConstructGeneration.cs:173
                    }                                                                                                                       // FhirConstructGeneration.cs:174
                    if (fix.Route.TextElement != null)                                                                                      // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Route.TextElement = new FhirString();");                                              // FhirConstructGeneration.cs:209
                        if (fix.Route.TextElement.Value != null)                                                                            // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Route.TextElement.Value = \"{fix.Route.TextElement.Value}\";");                       // FhirConstructGeneration.cs:138
                        if (fix.Route.TextElement.ElementId != null)                                                                        // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Route.TextElement.ElementId = \"{fix.Route.TextElement.ElementId}\";");               // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Route.ElementId != null)                                                                                        // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.Route.ElementId = \"{fix.Route.ElementId}\";");                                           // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.Method != null)                                                                                                     // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.Method = new CodeableConcept();");                                                        // FhirConstructGeneration.cs:209
                    if (fix.Method.Coding != null)                                                                                          // FhirConstructGeneration.cs:159
                    {                                                                                                                       // FhirConstructGeneration.cs:160
                        block.AppendCode($"retVal.Method.Coding = new List<Coding>();");                                                    // FhirConstructGeneration.cs:161
                        foreach (var temp45 in fix.Method.Coding)                                                                           // FhirConstructGeneration.cs:162
                        {                                                                                                                   // FhirConstructGeneration.cs:163
                            block.OpenBrace();                                                                                              // FhirConstructGeneration.cs:164
                            block.AppendCode("var temp46 = new Coding();");                                                                 // FhirConstructGeneration.cs:165
                            if (temp45.SystemElement != null)                                                                               // FhirConstructGeneration.cs:207
                            {                                                                                                               // FhirConstructGeneration.cs:208
                                    block.AppendCode($"temp46.SystemElement = new FhirUri();");                                             // FhirConstructGeneration.cs:209
                                if (temp45.SystemElement.Value != null)                                                                     // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp46.SystemElement.Value = \"{temp45.SystemElement.Value}\";");                    // FhirConstructGeneration.cs:138
                                if (temp45.SystemElement.ElementId != null)                                                                 // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp46.SystemElement.ElementId = \"{temp45.SystemElement.ElementId}\";");            // FhirConstructGeneration.cs:138
                            }                                                                                                               // FhirConstructGeneration.cs:213
                            if (temp45.VersionElement != null)                                                                              // FhirConstructGeneration.cs:207
                            {                                                                                                               // FhirConstructGeneration.cs:208
                                    block.AppendCode($"temp46.VersionElement = new FhirString();");                                         // FhirConstructGeneration.cs:209
                                if (temp45.VersionElement.Value != null)                                                                    // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp46.VersionElement.Value = \"{temp45.VersionElement.Value}\";");                  // FhirConstructGeneration.cs:138
                                if (temp45.VersionElement.ElementId != null)                                                                // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp46.VersionElement.ElementId = \"{temp45.VersionElement.ElementId}\";");          // FhirConstructGeneration.cs:138
                            }                                                                                                               // FhirConstructGeneration.cs:213
                            if (temp45.CodeElement != null)                                                                                 // FhirConstructGeneration.cs:207
                            {                                                                                                               // FhirConstructGeneration.cs:208
                                    block.AppendCode($"temp46.CodeElement = new Code();");                                                  // FhirConstructGeneration.cs:209
                                if (temp45.CodeElement.Value != null)                                                                       // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp46.CodeElement.Value = \"{temp45.CodeElement.Value}\";");                        // FhirConstructGeneration.cs:138
                                if (temp45.CodeElement.ElementId != null)                                                                   // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp46.CodeElement.ElementId = \"{temp45.CodeElement.ElementId}\";");                // FhirConstructGeneration.cs:138
                            }                                                                                                               // FhirConstructGeneration.cs:213
                            if (temp45.DisplayElement != null)                                                                              // FhirConstructGeneration.cs:207
                            {                                                                                                               // FhirConstructGeneration.cs:208
                                    block.AppendCode($"temp46.DisplayElement = new FhirString();");                                         // FhirConstructGeneration.cs:209
                                if (temp45.DisplayElement.Value != null)                                                                    // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp46.DisplayElement.Value = \"{temp45.DisplayElement.Value}\";");                  // FhirConstructGeneration.cs:138
                                if (temp45.DisplayElement.ElementId != null)                                                                // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp46.DisplayElement.ElementId = \"{temp45.DisplayElement.ElementId}\";");          // FhirConstructGeneration.cs:138
                            }                                                                                                               // FhirConstructGeneration.cs:213
                            if (temp45.UserSelectedElement != null)                                                                         // FhirConstructGeneration.cs:207
                            {                                                                                                               // FhirConstructGeneration.cs:208
                                    block.AppendCode($"temp46.UserSelectedElement = new FhirBoolean();");                                   // FhirConstructGeneration.cs:209
                                if (temp45.UserSelectedElement.Value.HasValue == true)                                                      // FhirConstructGeneration.cs:69
                                {                                                                                                           // FhirConstructGeneration.cs:70
                                    if (temp45.UserSelectedElement.Value.Value == true)                                                     // FhirConstructGeneration.cs:71
                                        block.AppendCode($"temp46.UserSelectedElement.Value = true;");                                      // FhirConstructGeneration.cs:72
                                    else                                                                                                    // FhirConstructGeneration.cs:73
                                        block.AppendCode($"temp46.UserSelectedElement.Value = false;");                                     // FhirConstructGeneration.cs:74
                                }                                                                                                           // FhirConstructGeneration.cs:75
                                if (temp45.UserSelectedElement.ElementId != null)                                                           // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp46.UserSelectedElement.ElementId = \"{temp45.UserSelectedElement.ElementId}\";");// FhirConstructGeneration.cs:138
                            }                                                                                                               // FhirConstructGeneration.cs:213
                            if (temp45.ElementId != null)                                                                                   // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp46.ElementId = \"{temp45.ElementId}\";");                                            // FhirConstructGeneration.cs:138
                            block.AppendCode($"retVal.Method.Coding.Add(temp46);");                                                         // FhirConstructGeneration.cs:171
                            block.CloseBrace();                                                                                             // FhirConstructGeneration.cs:172
                        }                                                                                                                   // FhirConstructGeneration.cs:173
                    }                                                                                                                       // FhirConstructGeneration.cs:174
                    if (fix.Method.TextElement != null)                                                                                     // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Method.TextElement = new FhirString();");                                             // FhirConstructGeneration.cs:209
                        if (fix.Method.TextElement.Value != null)                                                                           // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Method.TextElement.Value = \"{fix.Method.TextElement.Value}\";");                     // FhirConstructGeneration.cs:138
                        if (fix.Method.TextElement.ElementId != null)                                                                       // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Method.TextElement.ElementId = \"{fix.Method.TextElement.ElementId}\";");             // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Method.ElementId != null)                                                                                       // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.Method.ElementId = \"{fix.Method.ElementId}\";");                                         // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.MaxDosePerPeriod != null)                                                                                           // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.MaxDosePerPeriod = new Ratio();");                                                        // FhirConstructGeneration.cs:209
                    if (fix.MaxDosePerPeriod.Numerator != null)                                                                             // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.MaxDosePerPeriod.Numerator = new Quantity();");                                       // FhirConstructGeneration.cs:209
                        if (fix.MaxDosePerPeriod.Numerator.ValueElement != null)                                                            // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"retVal.MaxDosePerPeriod.Numerator.ValueElement = new FhirDecimal();");                   // FhirConstructGeneration.cs:209
                            if (fix.MaxDosePerPeriod.Numerator.ValueElement.Value.HasValue == true)                                         // FhirConstructGeneration.cs:123
                                block.AppendCode($"retVal.MaxDosePerPeriod.Numerator.ValueElement.Value = new Nullable<decimal>((decimal) {fix.MaxDosePerPeriod.Numerator.ValueElement.Value.Value});");// FhirConstructGeneration.cs:124
                            if (fix.MaxDosePerPeriod.Numerator.ValueElement.ElementId != null)                                              // FhirConstructGeneration.cs:137
                                block.AppendCode($"retVal.MaxDosePerPeriod.Numerator.ValueElement.ElementId = \"{fix.MaxDosePerPeriod.Numerator.ValueElement.ElementId}\";");// FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (fix.MaxDosePerPeriod.Numerator.ComparatorElement != null)                                                       // FhirConstructGeneration.cs:147
                            block.AppendCode($"retVal.MaxDosePerPeriod.Numerator.ComparatorElement = new Code<Quantity.QuantityComparator>(Quantity.QuantityComparator.{fix.MaxDosePerPeriod.Numerator.ComparatorElement.Value});");// FhirConstructGeneration.cs:148
                        if (fix.MaxDosePerPeriod.Numerator.UnitElement != null)                                                             // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"retVal.MaxDosePerPeriod.Numerator.UnitElement = new FhirString();");                     // FhirConstructGeneration.cs:209
                            if (fix.MaxDosePerPeriod.Numerator.UnitElement.Value != null)                                                   // FhirConstructGeneration.cs:137
                                block.AppendCode($"retVal.MaxDosePerPeriod.Numerator.UnitElement.Value = \"{fix.MaxDosePerPeriod.Numerator.UnitElement.Value}\";");// FhirConstructGeneration.cs:138
                            if (fix.MaxDosePerPeriod.Numerator.UnitElement.ElementId != null)                                               // FhirConstructGeneration.cs:137
                                block.AppendCode($"retVal.MaxDosePerPeriod.Numerator.UnitElement.ElementId = \"{fix.MaxDosePerPeriod.Numerator.UnitElement.ElementId}\";");// FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (fix.MaxDosePerPeriod.Numerator.SystemElement != null)                                                           // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"retVal.MaxDosePerPeriod.Numerator.SystemElement = new FhirUri();");                      // FhirConstructGeneration.cs:209
                            if (fix.MaxDosePerPeriod.Numerator.SystemElement.Value != null)                                                 // FhirConstructGeneration.cs:137
                                block.AppendCode($"retVal.MaxDosePerPeriod.Numerator.SystemElement.Value = \"{fix.MaxDosePerPeriod.Numerator.SystemElement.Value}\";");// FhirConstructGeneration.cs:138
                            if (fix.MaxDosePerPeriod.Numerator.SystemElement.ElementId != null)                                             // FhirConstructGeneration.cs:137
                                block.AppendCode($"retVal.MaxDosePerPeriod.Numerator.SystemElement.ElementId = \"{fix.MaxDosePerPeriod.Numerator.SystemElement.ElementId}\";");// FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (fix.MaxDosePerPeriod.Numerator.CodeElement != null)                                                             // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"retVal.MaxDosePerPeriod.Numerator.CodeElement = new Code();");                           // FhirConstructGeneration.cs:209
                            if (fix.MaxDosePerPeriod.Numerator.CodeElement.Value != null)                                                   // FhirConstructGeneration.cs:137
                                block.AppendCode($"retVal.MaxDosePerPeriod.Numerator.CodeElement.Value = \"{fix.MaxDosePerPeriod.Numerator.CodeElement.Value}\";");// FhirConstructGeneration.cs:138
                            if (fix.MaxDosePerPeriod.Numerator.CodeElement.ElementId != null)                                               // FhirConstructGeneration.cs:137
                                block.AppendCode($"retVal.MaxDosePerPeriod.Numerator.CodeElement.ElementId = \"{fix.MaxDosePerPeriod.Numerator.CodeElement.ElementId}\";");// FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (fix.MaxDosePerPeriod.Numerator.ElementId != null)                                                               // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.MaxDosePerPeriod.Numerator.ElementId = \"{fix.MaxDosePerPeriod.Numerator.ElementId}\";");// FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.MaxDosePerPeriod.Denominator != null)                                                                           // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.MaxDosePerPeriod.Denominator = new Quantity();");                                     // FhirConstructGeneration.cs:209
                        if (fix.MaxDosePerPeriod.Denominator.ValueElement != null)                                                          // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"retVal.MaxDosePerPeriod.Denominator.ValueElement = new FhirDecimal();");                 // FhirConstructGeneration.cs:209
                            if (fix.MaxDosePerPeriod.Denominator.ValueElement.Value.HasValue == true)                                       // FhirConstructGeneration.cs:123
                                block.AppendCode($"retVal.MaxDosePerPeriod.Denominator.ValueElement.Value = new Nullable<decimal>((decimal) {fix.MaxDosePerPeriod.Denominator.ValueElement.Value.Value});");// FhirConstructGeneration.cs:124
                            if (fix.MaxDosePerPeriod.Denominator.ValueElement.ElementId != null)                                            // FhirConstructGeneration.cs:137
                                block.AppendCode($"retVal.MaxDosePerPeriod.Denominator.ValueElement.ElementId = \"{fix.MaxDosePerPeriod.Denominator.ValueElement.ElementId}\";");// FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (fix.MaxDosePerPeriod.Denominator.ComparatorElement != null)                                                     // FhirConstructGeneration.cs:147
                            block.AppendCode($"retVal.MaxDosePerPeriod.Denominator.ComparatorElement = new Code<Quantity.QuantityComparator>(Quantity.QuantityComparator.{fix.MaxDosePerPeriod.Denominator.ComparatorElement.Value});");// FhirConstructGeneration.cs:148
                        if (fix.MaxDosePerPeriod.Denominator.UnitElement != null)                                                           // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"retVal.MaxDosePerPeriod.Denominator.UnitElement = new FhirString();");                   // FhirConstructGeneration.cs:209
                            if (fix.MaxDosePerPeriod.Denominator.UnitElement.Value != null)                                                 // FhirConstructGeneration.cs:137
                                block.AppendCode($"retVal.MaxDosePerPeriod.Denominator.UnitElement.Value = \"{fix.MaxDosePerPeriod.Denominator.UnitElement.Value}\";");// FhirConstructGeneration.cs:138
                            if (fix.MaxDosePerPeriod.Denominator.UnitElement.ElementId != null)                                             // FhirConstructGeneration.cs:137
                                block.AppendCode($"retVal.MaxDosePerPeriod.Denominator.UnitElement.ElementId = \"{fix.MaxDosePerPeriod.Denominator.UnitElement.ElementId}\";");// FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (fix.MaxDosePerPeriod.Denominator.SystemElement != null)                                                         // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"retVal.MaxDosePerPeriod.Denominator.SystemElement = new FhirUri();");                    // FhirConstructGeneration.cs:209
                            if (fix.MaxDosePerPeriod.Denominator.SystemElement.Value != null)                                               // FhirConstructGeneration.cs:137
                                block.AppendCode($"retVal.MaxDosePerPeriod.Denominator.SystemElement.Value = \"{fix.MaxDosePerPeriod.Denominator.SystemElement.Value}\";");// FhirConstructGeneration.cs:138
                            if (fix.MaxDosePerPeriod.Denominator.SystemElement.ElementId != null)                                           // FhirConstructGeneration.cs:137
                                block.AppendCode($"retVal.MaxDosePerPeriod.Denominator.SystemElement.ElementId = \"{fix.MaxDosePerPeriod.Denominator.SystemElement.ElementId}\";");// FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (fix.MaxDosePerPeriod.Denominator.CodeElement != null)                                                           // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"retVal.MaxDosePerPeriod.Denominator.CodeElement = new Code();");                         // FhirConstructGeneration.cs:209
                            if (fix.MaxDosePerPeriod.Denominator.CodeElement.Value != null)                                                 // FhirConstructGeneration.cs:137
                                block.AppendCode($"retVal.MaxDosePerPeriod.Denominator.CodeElement.Value = \"{fix.MaxDosePerPeriod.Denominator.CodeElement.Value}\";");// FhirConstructGeneration.cs:138
                            if (fix.MaxDosePerPeriod.Denominator.CodeElement.ElementId != null)                                             // FhirConstructGeneration.cs:137
                                block.AppendCode($"retVal.MaxDosePerPeriod.Denominator.CodeElement.ElementId = \"{fix.MaxDosePerPeriod.Denominator.CodeElement.ElementId}\";");// FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (fix.MaxDosePerPeriod.Denominator.ElementId != null)                                                             // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.MaxDosePerPeriod.Denominator.ElementId = \"{fix.MaxDosePerPeriod.Denominator.ElementId}\";");// FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.MaxDosePerPeriod.ElementId != null)                                                                             // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.MaxDosePerPeriod.ElementId = \"{fix.MaxDosePerPeriod.ElementId}\";");                     // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.MaxDosePerAdministration != null)                                                                                   // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.MaxDosePerAdministration = new Quantity();");                                             // FhirConstructGeneration.cs:209
                    if (fix.MaxDosePerAdministration.ValueElement != null)                                                                  // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.MaxDosePerAdministration.ValueElement = new FhirDecimal();");                         // FhirConstructGeneration.cs:209
                        if (fix.MaxDosePerAdministration.ValueElement.Value.HasValue == true)                                               // FhirConstructGeneration.cs:123
                            block.AppendCode($"retVal.MaxDosePerAdministration.ValueElement.Value = new Nullable<decimal>((decimal) {fix.MaxDosePerAdministration.ValueElement.Value.Value});");// FhirConstructGeneration.cs:124
                        if (fix.MaxDosePerAdministration.ValueElement.ElementId != null)                                                    // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.MaxDosePerAdministration.ValueElement.ElementId = \"{fix.MaxDosePerAdministration.ValueElement.ElementId}\";");// FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.MaxDosePerAdministration.ComparatorElement != null)                                                             // FhirConstructGeneration.cs:147
                        block.AppendCode($"retVal.MaxDosePerAdministration.ComparatorElement = new Code<Quantity.QuantityComparator>(Quantity.QuantityComparator.{fix.MaxDosePerAdministration.ComparatorElement.Value});");// FhirConstructGeneration.cs:148
                    if (fix.MaxDosePerAdministration.UnitElement != null)                                                                   // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.MaxDosePerAdministration.UnitElement = new FhirString();");                           // FhirConstructGeneration.cs:209
                        if (fix.MaxDosePerAdministration.UnitElement.Value != null)                                                         // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.MaxDosePerAdministration.UnitElement.Value = \"{fix.MaxDosePerAdministration.UnitElement.Value}\";");// FhirConstructGeneration.cs:138
                        if (fix.MaxDosePerAdministration.UnitElement.ElementId != null)                                                     // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.MaxDosePerAdministration.UnitElement.ElementId = \"{fix.MaxDosePerAdministration.UnitElement.ElementId}\";");// FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.MaxDosePerAdministration.SystemElement != null)                                                                 // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.MaxDosePerAdministration.SystemElement = new FhirUri();");                            // FhirConstructGeneration.cs:209
                        if (fix.MaxDosePerAdministration.SystemElement.Value != null)                                                       // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.MaxDosePerAdministration.SystemElement.Value = \"{fix.MaxDosePerAdministration.SystemElement.Value}\";");// FhirConstructGeneration.cs:138
                        if (fix.MaxDosePerAdministration.SystemElement.ElementId != null)                                                   // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.MaxDosePerAdministration.SystemElement.ElementId = \"{fix.MaxDosePerAdministration.SystemElement.ElementId}\";");// FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.MaxDosePerAdministration.CodeElement != null)                                                                   // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.MaxDosePerAdministration.CodeElement = new Code();");                                 // FhirConstructGeneration.cs:209
                        if (fix.MaxDosePerAdministration.CodeElement.Value != null)                                                         // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.MaxDosePerAdministration.CodeElement.Value = \"{fix.MaxDosePerAdministration.CodeElement.Value}\";");// FhirConstructGeneration.cs:138
                        if (fix.MaxDosePerAdministration.CodeElement.ElementId != null)                                                     // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.MaxDosePerAdministration.CodeElement.ElementId = \"{fix.MaxDosePerAdministration.CodeElement.ElementId}\";");// FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.MaxDosePerAdministration.ElementId != null)                                                                     // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.MaxDosePerAdministration.ElementId = \"{fix.MaxDosePerAdministration.ElementId}\";");     // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.MaxDosePerLifetime != null)                                                                                         // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.MaxDosePerLifetime = new Quantity();");                                                   // FhirConstructGeneration.cs:209
                    if (fix.MaxDosePerLifetime.ValueElement != null)                                                                        // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.MaxDosePerLifetime.ValueElement = new FhirDecimal();");                               // FhirConstructGeneration.cs:209
                        if (fix.MaxDosePerLifetime.ValueElement.Value.HasValue == true)                                                     // FhirConstructGeneration.cs:123
                            block.AppendCode($"retVal.MaxDosePerLifetime.ValueElement.Value = new Nullable<decimal>((decimal) {fix.MaxDosePerLifetime.ValueElement.Value.Value});");// FhirConstructGeneration.cs:124
                        if (fix.MaxDosePerLifetime.ValueElement.ElementId != null)                                                          // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.MaxDosePerLifetime.ValueElement.ElementId = \"{fix.MaxDosePerLifetime.ValueElement.ElementId}\";");// FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.MaxDosePerLifetime.ComparatorElement != null)                                                                   // FhirConstructGeneration.cs:147
                        block.AppendCode($"retVal.MaxDosePerLifetime.ComparatorElement = new Code<Quantity.QuantityComparator>(Quantity.QuantityComparator.{fix.MaxDosePerLifetime.ComparatorElement.Value});");// FhirConstructGeneration.cs:148
                    if (fix.MaxDosePerLifetime.UnitElement != null)                                                                         // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.MaxDosePerLifetime.UnitElement = new FhirString();");                                 // FhirConstructGeneration.cs:209
                        if (fix.MaxDosePerLifetime.UnitElement.Value != null)                                                               // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.MaxDosePerLifetime.UnitElement.Value = \"{fix.MaxDosePerLifetime.UnitElement.Value}\";");// FhirConstructGeneration.cs:138
                        if (fix.MaxDosePerLifetime.UnitElement.ElementId != null)                                                           // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.MaxDosePerLifetime.UnitElement.ElementId = \"{fix.MaxDosePerLifetime.UnitElement.ElementId}\";");// FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.MaxDosePerLifetime.SystemElement != null)                                                                       // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.MaxDosePerLifetime.SystemElement = new FhirUri();");                                  // FhirConstructGeneration.cs:209
                        if (fix.MaxDosePerLifetime.SystemElement.Value != null)                                                             // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.MaxDosePerLifetime.SystemElement.Value = \"{fix.MaxDosePerLifetime.SystemElement.Value}\";");// FhirConstructGeneration.cs:138
                        if (fix.MaxDosePerLifetime.SystemElement.ElementId != null)                                                         // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.MaxDosePerLifetime.SystemElement.ElementId = \"{fix.MaxDosePerLifetime.SystemElement.ElementId}\";");// FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.MaxDosePerLifetime.CodeElement != null)                                                                         // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.MaxDosePerLifetime.CodeElement = new Code();");                                       // FhirConstructGeneration.cs:209
                        if (fix.MaxDosePerLifetime.CodeElement.Value != null)                                                               // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.MaxDosePerLifetime.CodeElement.Value = \"{fix.MaxDosePerLifetime.CodeElement.Value}\";");// FhirConstructGeneration.cs:138
                        if (fix.MaxDosePerLifetime.CodeElement.ElementId != null)                                                           // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.MaxDosePerLifetime.CodeElement.ElementId = \"{fix.MaxDosePerLifetime.CodeElement.ElementId}\";");// FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.MaxDosePerLifetime.ElementId != null)                                                                           // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.MaxDosePerLifetime.ElementId = \"{fix.MaxDosePerLifetime.ElementId}\";");                 // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:338
            block                                                                                                                           // FhirConstructGeneration.cs:339
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:340
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:341
                ;                                                                                                                           // FhirConstructGeneration.cs:342
            return  true;                                                                                                                   // FhirConstructGeneration.cs:343
        }                                                                                                                                   // FhirConstructGeneration.cs:344
                                                                                                                                            // FhirConstructGeneration.cs:315
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:319
            Duration fix,                                                                                                                   // FhirConstructGeneration.cs:320
            String methodName,                                                                                                              // FhirConstructGeneration.cs:321
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:322
        {                                                                                                                                   // FhirConstructGeneration.cs:323
                                                                                                                                            // FhirConstructGeneration.cs:325
            block                                                                                                                           // FhirConstructGeneration.cs:326
                .AppendCode($"{methodAccess} Duration {methodName}()")                                                                      // FhirConstructGeneration.cs:327
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:328
                .AppendCode("Duration retVal = new Duration();")                                                                            // FhirConstructGeneration.cs:329
                ;                                                                                                                           // FhirConstructGeneration.cs:330
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:331
            {                                                                                                                               // FhirConstructGeneration.cs:332
                if (fix.ValueElement != null)                                                                                               // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.ValueElement = new FhirDecimal();");                                                      // FhirConstructGeneration.cs:209
                    if (fix.ValueElement.Value.HasValue == true)                                                                            // FhirConstructGeneration.cs:123
                        block.AppendCode($"retVal.ValueElement.Value = new Nullable<decimal>((decimal) {fix.ValueElement.Value.Value});");  // FhirConstructGeneration.cs:124
                    if (fix.ValueElement.ElementId != null)                                                                                 // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.ValueElement.ElementId = \"{fix.ValueElement.ElementId}\";");                             // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.ComparatorElement != null)                                                                                          // FhirConstructGeneration.cs:147
                    block.AppendCode($"retVal.ComparatorElement = new Code<Quantity.QuantityComparator>(Quantity.QuantityComparator.{fix.ComparatorElement.Value});");// FhirConstructGeneration.cs:148
                if (fix.UnitElement != null)                                                                                                // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.UnitElement = new FhirString();");                                                        // FhirConstructGeneration.cs:209
                    if (fix.UnitElement.Value != null)                                                                                      // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.UnitElement.Value = \"{fix.UnitElement.Value}\";");                                       // FhirConstructGeneration.cs:138
                    if (fix.UnitElement.ElementId != null)                                                                                  // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.UnitElement.ElementId = \"{fix.UnitElement.ElementId}\";");                               // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.SystemElement != null)                                                                                              // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.SystemElement = new FhirUri();");                                                         // FhirConstructGeneration.cs:209
                    if (fix.SystemElement.Value != null)                                                                                    // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.SystemElement.Value = \"{fix.SystemElement.Value}\";");                                   // FhirConstructGeneration.cs:138
                    if (fix.SystemElement.ElementId != null)                                                                                // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.SystemElement.ElementId = \"{fix.SystemElement.ElementId}\";");                           // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.CodeElement != null)                                                                                                // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.CodeElement = new Code();");                                                              // FhirConstructGeneration.cs:209
                    if (fix.CodeElement.Value != null)                                                                                      // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.CodeElement.Value = \"{fix.CodeElement.Value}\";");                                       // FhirConstructGeneration.cs:138
                    if (fix.CodeElement.ElementId != null)                                                                                  // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.CodeElement.ElementId = \"{fix.CodeElement.ElementId}\";");                               // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:338
            block                                                                                                                           // FhirConstructGeneration.cs:339
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:340
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:341
                ;                                                                                                                           // FhirConstructGeneration.cs:342
            return  true;                                                                                                                   // FhirConstructGeneration.cs:343
        }                                                                                                                                   // FhirConstructGeneration.cs:344
                                                                                                                                            // FhirConstructGeneration.cs:315
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:319
            ElementDefinition fix,                                                                                                          // FhirConstructGeneration.cs:320
            String methodName,                                                                                                              // FhirConstructGeneration.cs:321
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:322
        {                                                                                                                                   // FhirConstructGeneration.cs:323
                                                                                                                                            // FhirConstructGeneration.cs:325
            block                                                                                                                           // FhirConstructGeneration.cs:326
                .AppendCode($"{methodAccess} ElementDefinition {methodName}()")                                                             // FhirConstructGeneration.cs:327
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:328
                .AppendCode("ElementDefinition retVal = new ElementDefinition();")                                                          // FhirConstructGeneration.cs:329
                ;                                                                                                                           // FhirConstructGeneration.cs:330
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:331
            {                                                                                                                               // FhirConstructGeneration.cs:332
                if (fix.PathElement != null)                                                                                                // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.PathElement = new FhirString();");                                                        // FhirConstructGeneration.cs:209
                    if (fix.PathElement.Value != null)                                                                                      // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.PathElement.Value = \"{fix.PathElement.Value}\";");                                       // FhirConstructGeneration.cs:138
                    if (fix.PathElement.ElementId != null)                                                                                  // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.PathElement.ElementId = \"{fix.PathElement.ElementId}\";");                               // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.RepresentationElement != null)                                                                                      // FhirConstructGeneration.cs:159
                {                                                                                                                           // FhirConstructGeneration.cs:160
                    block.AppendCode($"retVal.RepresentationElement = new List<Code<ElementDefinition.PropertyRepresentation>>();");        // FhirConstructGeneration.cs:161
                    foreach (var temp47 in fix.RepresentationElement)                                                                       // FhirConstructGeneration.cs:162
                    {                                                                                                                       // FhirConstructGeneration.cs:163
                        block.OpenBrace();                                                                                                  // FhirConstructGeneration.cs:164
                        block.AppendCode("var temp48 = new Code<ElementDefinition.PropertyRepresentation>();");                             // FhirConstructGeneration.cs:165
                        if (temp47.Value.HasValue == true)                                                                                  // FhirConstructGeneration.cs:184
                            block.AppendCode($"temp48.Value = ElementDefinition.PropertyRepresentation.{temp47.Value.Value};");             // FhirConstructGeneration.cs:185
                        if (temp47.ElementId != null)                                                                                       // FhirConstructGeneration.cs:137
                            block.AppendCode($"temp48.ElementId = \"{temp47.ElementId}\";");                                                // FhirConstructGeneration.cs:138
                        block.AppendCode($"retVal.RepresentationElement.Add(temp48);");                                                     // FhirConstructGeneration.cs:171
                        block.CloseBrace();                                                                                                 // FhirConstructGeneration.cs:172
                    }                                                                                                                       // FhirConstructGeneration.cs:173
                }                                                                                                                           // FhirConstructGeneration.cs:174
                if (fix.SliceNameElement != null)                                                                                           // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.SliceNameElement = new FhirString();");                                                   // FhirConstructGeneration.cs:209
                    if (fix.SliceNameElement.Value != null)                                                                                 // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.SliceNameElement.Value = \"{fix.SliceNameElement.Value}\";");                             // FhirConstructGeneration.cs:138
                    if (fix.SliceNameElement.ElementId != null)                                                                             // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.SliceNameElement.ElementId = \"{fix.SliceNameElement.ElementId}\";");                     // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.LabelElement != null)                                                                                               // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.LabelElement = new FhirString();");                                                       // FhirConstructGeneration.cs:209
                    if (fix.LabelElement.Value != null)                                                                                     // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.LabelElement.Value = \"{fix.LabelElement.Value}\";");                                     // FhirConstructGeneration.cs:138
                    if (fix.LabelElement.ElementId != null)                                                                                 // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.LabelElement.ElementId = \"{fix.LabelElement.ElementId}\";");                             // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.Code != null)                                                                                                       // FhirConstructGeneration.cs:159
                {                                                                                                                           // FhirConstructGeneration.cs:160
                    block.AppendCode($"retVal.Code = new List<Coding>();");                                                                 // FhirConstructGeneration.cs:161
                    foreach (var temp49 in fix.Code)                                                                                        // FhirConstructGeneration.cs:162
                    {                                                                                                                       // FhirConstructGeneration.cs:163
                        block.OpenBrace();                                                                                                  // FhirConstructGeneration.cs:164
                        block.AppendCode("var temp50 = new Coding();");                                                                     // FhirConstructGeneration.cs:165
                        if (temp49.SystemElement != null)                                                                                   // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"temp50.SystemElement = new FhirUri();");                                                 // FhirConstructGeneration.cs:209
                            if (temp49.SystemElement.Value != null)                                                                         // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp50.SystemElement.Value = \"{temp49.SystemElement.Value}\";");                        // FhirConstructGeneration.cs:138
                            if (temp49.SystemElement.ElementId != null)                                                                     // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp50.SystemElement.ElementId = \"{temp49.SystemElement.ElementId}\";");                // FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (temp49.VersionElement != null)                                                                                  // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"temp50.VersionElement = new FhirString();");                                             // FhirConstructGeneration.cs:209
                            if (temp49.VersionElement.Value != null)                                                                        // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp50.VersionElement.Value = \"{temp49.VersionElement.Value}\";");                      // FhirConstructGeneration.cs:138
                            if (temp49.VersionElement.ElementId != null)                                                                    // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp50.VersionElement.ElementId = \"{temp49.VersionElement.ElementId}\";");              // FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (temp49.CodeElement != null)                                                                                     // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"temp50.CodeElement = new Code();");                                                      // FhirConstructGeneration.cs:209
                            if (temp49.CodeElement.Value != null)                                                                           // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp50.CodeElement.Value = \"{temp49.CodeElement.Value}\";");                            // FhirConstructGeneration.cs:138
                            if (temp49.CodeElement.ElementId != null)                                                                       // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp50.CodeElement.ElementId = \"{temp49.CodeElement.ElementId}\";");                    // FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (temp49.DisplayElement != null)                                                                                  // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"temp50.DisplayElement = new FhirString();");                                             // FhirConstructGeneration.cs:209
                            if (temp49.DisplayElement.Value != null)                                                                        // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp50.DisplayElement.Value = \"{temp49.DisplayElement.Value}\";");                      // FhirConstructGeneration.cs:138
                            if (temp49.DisplayElement.ElementId != null)                                                                    // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp50.DisplayElement.ElementId = \"{temp49.DisplayElement.ElementId}\";");              // FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (temp49.UserSelectedElement != null)                                                                             // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"temp50.UserSelectedElement = new FhirBoolean();");                                       // FhirConstructGeneration.cs:209
                            if (temp49.UserSelectedElement.Value.HasValue == true)                                                          // FhirConstructGeneration.cs:69
                            {                                                                                                               // FhirConstructGeneration.cs:70
                                if (temp49.UserSelectedElement.Value.Value == true)                                                         // FhirConstructGeneration.cs:71
                                    block.AppendCode($"temp50.UserSelectedElement.Value = true;");                                          // FhirConstructGeneration.cs:72
                                else                                                                                                        // FhirConstructGeneration.cs:73
                                    block.AppendCode($"temp50.UserSelectedElement.Value = false;");                                         // FhirConstructGeneration.cs:74
                            }                                                                                                               // FhirConstructGeneration.cs:75
                            if (temp49.UserSelectedElement.ElementId != null)                                                               // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp50.UserSelectedElement.ElementId = \"{temp49.UserSelectedElement.ElementId}\";");    // FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (temp49.ElementId != null)                                                                                       // FhirConstructGeneration.cs:137
                            block.AppendCode($"temp50.ElementId = \"{temp49.ElementId}\";");                                                // FhirConstructGeneration.cs:138
                        block.AppendCode($"retVal.Code.Add(temp50);");                                                                      // FhirConstructGeneration.cs:171
                        block.CloseBrace();                                                                                                 // FhirConstructGeneration.cs:172
                    }                                                                                                                       // FhirConstructGeneration.cs:173
                }                                                                                                                           // FhirConstructGeneration.cs:174
                if (fix.Slicing != null)                                                                                                    // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.Slicing = new ElementDefinition.SlicingComponent();");                                    // FhirConstructGeneration.cs:209
                    if (fix.Slicing.Discriminator != null)                                                                                  // FhirConstructGeneration.cs:159
                    {                                                                                                                       // FhirConstructGeneration.cs:160
                        block.AppendCode($"retVal.Slicing.Discriminator = new List<ElementDefinition.DiscriminatorComponent>();");          // FhirConstructGeneration.cs:161
                        foreach (var temp51 in fix.Slicing.Discriminator)                                                                   // FhirConstructGeneration.cs:162
                        {                                                                                                                   // FhirConstructGeneration.cs:163
                            block.OpenBrace();                                                                                              // FhirConstructGeneration.cs:164
                            block.AppendCode("var temp52 = new ElementDefinition.DiscriminatorComponent();");                               // FhirConstructGeneration.cs:165
                            if (temp51.TypeElement != null)                                                                                 // FhirConstructGeneration.cs:147
                                block.AppendCode($"temp52.TypeElement = new Code<ElementDefinition.DiscriminatorType>(ElementDefinition.DiscriminatorType.{temp51.TypeElement.Value});");// FhirConstructGeneration.cs:148
                            if (temp51.PathElement != null)                                                                                 // FhirConstructGeneration.cs:207
                            {                                                                                                               // FhirConstructGeneration.cs:208
                                    block.AppendCode($"temp52.PathElement = new FhirString();");                                            // FhirConstructGeneration.cs:209
                                if (temp51.PathElement.Value != null)                                                                       // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp52.PathElement.Value = \"{temp51.PathElement.Value}\";");                        // FhirConstructGeneration.cs:138
                                if (temp51.PathElement.ElementId != null)                                                                   // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp52.PathElement.ElementId = \"{temp51.PathElement.ElementId}\";");                // FhirConstructGeneration.cs:138
                            }                                                                                                               // FhirConstructGeneration.cs:213
                            if (temp51.ElementId != null)                                                                                   // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp52.ElementId = \"{temp51.ElementId}\";");                                            // FhirConstructGeneration.cs:138
                            block.AppendCode($"retVal.Slicing.Discriminator.Add(temp52);");                                                 // FhirConstructGeneration.cs:171
                            block.CloseBrace();                                                                                             // FhirConstructGeneration.cs:172
                        }                                                                                                                   // FhirConstructGeneration.cs:173
                    }                                                                                                                       // FhirConstructGeneration.cs:174
                    if (fix.Slicing.DescriptionElement != null)                                                                             // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Slicing.DescriptionElement = new FhirString();");                                     // FhirConstructGeneration.cs:209
                        if (fix.Slicing.DescriptionElement.Value != null)                                                                   // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Slicing.DescriptionElement.Value = \"{fix.Slicing.DescriptionElement.Value}\";");     // FhirConstructGeneration.cs:138
                        if (fix.Slicing.DescriptionElement.ElementId != null)                                                               // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Slicing.DescriptionElement.ElementId = \"{fix.Slicing.DescriptionElement.ElementId}\";");// FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Slicing.OrderedElement != null)                                                                                 // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Slicing.OrderedElement = new FhirBoolean();");                                        // FhirConstructGeneration.cs:209
                        if (fix.Slicing.OrderedElement.Value.HasValue == true)                                                              // FhirConstructGeneration.cs:69
                        {                                                                                                                   // FhirConstructGeneration.cs:70
                            if (fix.Slicing.OrderedElement.Value.Value == true)                                                             // FhirConstructGeneration.cs:71
                                block.AppendCode($"retVal.Slicing.OrderedElement.Value = true;");                                           // FhirConstructGeneration.cs:72
                            else                                                                                                            // FhirConstructGeneration.cs:73
                                block.AppendCode($"retVal.Slicing.OrderedElement.Value = false;");                                          // FhirConstructGeneration.cs:74
                        }                                                                                                                   // FhirConstructGeneration.cs:75
                        if (fix.Slicing.OrderedElement.ElementId != null)                                                                   // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Slicing.OrderedElement.ElementId = \"{fix.Slicing.OrderedElement.ElementId}\";");     // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Slicing.RulesElement != null)                                                                                   // FhirConstructGeneration.cs:147
                        block.AppendCode($"retVal.Slicing.RulesElement = new Code<ElementDefinition.SlicingRules>(ElementDefinition.SlicingRules.{fix.Slicing.RulesElement.Value});");// FhirConstructGeneration.cs:148
                    if (fix.Slicing.ElementId != null)                                                                                      // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.Slicing.ElementId = \"{fix.Slicing.ElementId}\";");                                       // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.ShortElement != null)                                                                                               // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.ShortElement = new FhirString();");                                                       // FhirConstructGeneration.cs:209
                    if (fix.ShortElement.Value != null)                                                                                     // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.ShortElement.Value = \"{fix.ShortElement.Value}\";");                                     // FhirConstructGeneration.cs:138
                    if (fix.ShortElement.ElementId != null)                                                                                 // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.ShortElement.ElementId = \"{fix.ShortElement.ElementId}\";");                             // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.DefinitionElement != null)                                                                                          // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.DefinitionElement = new Markdown();");                                                    // FhirConstructGeneration.cs:209
                    if (fix.DefinitionElement.Value != null)                                                                                // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.DefinitionElement.Value = \"{fix.DefinitionElement.Value}\";");                           // FhirConstructGeneration.cs:138
                    if (fix.DefinitionElement.ElementId != null)                                                                            // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.DefinitionElement.ElementId = \"{fix.DefinitionElement.ElementId}\";");                   // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.CommentElement != null)                                                                                             // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.CommentElement = new Markdown();");                                                       // FhirConstructGeneration.cs:209
                    if (fix.CommentElement.Value != null)                                                                                   // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.CommentElement.Value = \"{fix.CommentElement.Value}\";");                                 // FhirConstructGeneration.cs:138
                    if (fix.CommentElement.ElementId != null)                                                                               // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.CommentElement.ElementId = \"{fix.CommentElement.ElementId}\";");                         // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.RequirementsElement != null)                                                                                        // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.RequirementsElement = new Markdown();");                                                  // FhirConstructGeneration.cs:209
                    if (fix.RequirementsElement.Value != null)                                                                              // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.RequirementsElement.Value = \"{fix.RequirementsElement.Value}\";");                       // FhirConstructGeneration.cs:138
                    if (fix.RequirementsElement.ElementId != null)                                                                          // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.RequirementsElement.ElementId = \"{fix.RequirementsElement.ElementId}\";");               // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.AliasElement != null)                                                                                               // FhirConstructGeneration.cs:159
                {                                                                                                                           // FhirConstructGeneration.cs:160
                    block.AppendCode($"retVal.AliasElement = new List<FhirString>();");                                                     // FhirConstructGeneration.cs:161
                    foreach (var temp53 in fix.AliasElement)                                                                                // FhirConstructGeneration.cs:162
                    {                                                                                                                       // FhirConstructGeneration.cs:163
                        block.OpenBrace();                                                                                                  // FhirConstructGeneration.cs:164
                        block.AppendCode("var temp54 = new FhirString();");                                                                 // FhirConstructGeneration.cs:165
                        if (temp53.Value != null)                                                                                           // FhirConstructGeneration.cs:137
                            block.AppendCode($"temp54.Value = \"{temp53.Value}\";");                                                        // FhirConstructGeneration.cs:138
                        if (temp53.ElementId != null)                                                                                       // FhirConstructGeneration.cs:137
                            block.AppendCode($"temp54.ElementId = \"{temp53.ElementId}\";");                                                // FhirConstructGeneration.cs:138
                        block.AppendCode($"retVal.AliasElement.Add(temp54);");                                                              // FhirConstructGeneration.cs:171
                        block.CloseBrace();                                                                                                 // FhirConstructGeneration.cs:172
                    }                                                                                                                       // FhirConstructGeneration.cs:173
                }                                                                                                                           // FhirConstructGeneration.cs:174
                if (fix.MinElement != null)                                                                                                 // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.MinElement = new UnsignedInt();");                                                        // FhirConstructGeneration.cs:209
                    if (fix.MinElement.Value.HasValue == true)                                                                              // FhirConstructGeneration.cs:130
                        block.AppendCode($"retVal.MinElement.Value = new Nullable<int>((int) {fix.MinElement.Value.Value});");              // FhirConstructGeneration.cs:131
                    if (fix.MinElement.ElementId != null)                                                                                   // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.MinElement.ElementId = \"{fix.MinElement.ElementId}\";");                                 // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.MaxElement != null)                                                                                                 // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.MaxElement = new FhirString();");                                                         // FhirConstructGeneration.cs:209
                    if (fix.MaxElement.Value != null)                                                                                       // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.MaxElement.Value = \"{fix.MaxElement.Value}\";");                                         // FhirConstructGeneration.cs:138
                    if (fix.MaxElement.ElementId != null)                                                                                   // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.MaxElement.ElementId = \"{fix.MaxElement.ElementId}\";");                                 // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.Base != null)                                                                                                       // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.Base = new ElementDefinition.BaseComponent();");                                          // FhirConstructGeneration.cs:209
                    if (fix.Base.PathElement != null)                                                                                       // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Base.PathElement = new FhirString();");                                               // FhirConstructGeneration.cs:209
                        if (fix.Base.PathElement.Value != null)                                                                             // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Base.PathElement.Value = \"{fix.Base.PathElement.Value}\";");                         // FhirConstructGeneration.cs:138
                        if (fix.Base.PathElement.ElementId != null)                                                                         // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Base.PathElement.ElementId = \"{fix.Base.PathElement.ElementId}\";");                 // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Base.MinElement != null)                                                                                        // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Base.MinElement = new UnsignedInt();");                                               // FhirConstructGeneration.cs:209
                        if (fix.Base.MinElement.Value.HasValue == true)                                                                     // FhirConstructGeneration.cs:130
                            block.AppendCode($"retVal.Base.MinElement.Value = new Nullable<int>((int) {fix.Base.MinElement.Value.Value});");// FhirConstructGeneration.cs:131
                        if (fix.Base.MinElement.ElementId != null)                                                                          // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Base.MinElement.ElementId = \"{fix.Base.MinElement.ElementId}\";");                   // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Base.MaxElement != null)                                                                                        // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Base.MaxElement = new FhirString();");                                                // FhirConstructGeneration.cs:209
                        if (fix.Base.MaxElement.Value != null)                                                                              // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Base.MaxElement.Value = \"{fix.Base.MaxElement.Value}\";");                           // FhirConstructGeneration.cs:138
                        if (fix.Base.MaxElement.ElementId != null)                                                                          // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Base.MaxElement.ElementId = \"{fix.Base.MaxElement.ElementId}\";");                   // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Base.ElementId != null)                                                                                         // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.Base.ElementId = \"{fix.Base.ElementId}\";");                                             // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.ContentReferenceElement != null)                                                                                    // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.ContentReferenceElement = new FhirUri();");                                               // FhirConstructGeneration.cs:209
                    if (fix.ContentReferenceElement.Value != null)                                                                          // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.ContentReferenceElement.Value = \"{fix.ContentReferenceElement.Value}\";");               // FhirConstructGeneration.cs:138
                    if (fix.ContentReferenceElement.ElementId != null)                                                                      // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.ContentReferenceElement.ElementId = \"{fix.ContentReferenceElement.ElementId}\";");       // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.Type != null)                                                                                                       // FhirConstructGeneration.cs:159
                {                                                                                                                           // FhirConstructGeneration.cs:160
                    block.AppendCode($"retVal.Type = new List<ElementDefinition.TypeRefComponent>();");                                     // FhirConstructGeneration.cs:161
                    foreach (var temp55 in fix.Type)                                                                                        // FhirConstructGeneration.cs:162
                    {                                                                                                                       // FhirConstructGeneration.cs:163
                        block.OpenBrace();                                                                                                  // FhirConstructGeneration.cs:164
                        block.AppendCode("var temp56 = new ElementDefinition.TypeRefComponent();");                                         // FhirConstructGeneration.cs:165
                        if (temp55.CodeElement != null)                                                                                     // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"temp56.CodeElement = new FhirUri();");                                                   // FhirConstructGeneration.cs:209
                            if (temp55.CodeElement.Value != null)                                                                           // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp56.CodeElement.Value = \"{temp55.CodeElement.Value}\";");                            // FhirConstructGeneration.cs:138
                            if (temp55.CodeElement.ElementId != null)                                                                       // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp56.CodeElement.ElementId = \"{temp55.CodeElement.ElementId}\";");                    // FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (temp55.ProfileElement != null)                                                                                  // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"temp56.ProfileElement = new FhirUri();");                                                // FhirConstructGeneration.cs:209
                            if (temp55.ProfileElement.Value != null)                                                                        // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp56.ProfileElement.Value = \"{temp55.ProfileElement.Value}\";");                      // FhirConstructGeneration.cs:138
                            if (temp55.ProfileElement.ElementId != null)                                                                    // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp56.ProfileElement.ElementId = \"{temp55.ProfileElement.ElementId}\";");              // FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (temp55.TargetProfileElement != null)                                                                            // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"temp56.TargetProfileElement = new FhirUri();");                                          // FhirConstructGeneration.cs:209
                            if (temp55.TargetProfileElement.Value != null)                                                                  // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp56.TargetProfileElement.Value = \"{temp55.TargetProfileElement.Value}\";");          // FhirConstructGeneration.cs:138
                            if (temp55.TargetProfileElement.ElementId != null)                                                              // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp56.TargetProfileElement.ElementId = \"{temp55.TargetProfileElement.ElementId}\";");  // FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (temp55.AggregationElement != null)                                                                              // FhirConstructGeneration.cs:159
                        {                                                                                                                   // FhirConstructGeneration.cs:160
                            block.AppendCode($"temp56.AggregationElement = new List<Code<ElementDefinition.AggregationMode>>();");          // FhirConstructGeneration.cs:161
                            foreach (var temp57 in temp55.AggregationElement)                                                               // FhirConstructGeneration.cs:162
                            {                                                                                                               // FhirConstructGeneration.cs:163
                                block.OpenBrace();                                                                                          // FhirConstructGeneration.cs:164
                                block.AppendCode("var temp58 = new Code<ElementDefinition.AggregationMode>();");                            // FhirConstructGeneration.cs:165
                                if (temp57.Value.HasValue == true)                                                                          // FhirConstructGeneration.cs:184
                                    block.AppendCode($"temp58.Value = ElementDefinition.AggregationMode.{temp57.Value.Value};");            // FhirConstructGeneration.cs:185
                                if (temp57.ElementId != null)                                                                               // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp58.ElementId = \"{temp57.ElementId}\";");                                        // FhirConstructGeneration.cs:138
                                block.AppendCode($"temp56.AggregationElement.Add(temp58);");                                                // FhirConstructGeneration.cs:171
                                block.CloseBrace();                                                                                         // FhirConstructGeneration.cs:172
                            }                                                                                                               // FhirConstructGeneration.cs:173
                        }                                                                                                                   // FhirConstructGeneration.cs:174
                        if (temp55.VersioningElement != null)                                                                               // FhirConstructGeneration.cs:147
                            block.AppendCode($"temp56.VersioningElement = new Code<ElementDefinition.ReferenceVersionRules>(ElementDefinition.ReferenceVersionRules.{temp55.VersioningElement.Value});");// FhirConstructGeneration.cs:148
                        if (temp55.ElementId != null)                                                                                       // FhirConstructGeneration.cs:137
                            block.AppendCode($"temp56.ElementId = \"{temp55.ElementId}\";");                                                // FhirConstructGeneration.cs:138
                        block.AppendCode($"retVal.Type.Add(temp56);");                                                                      // FhirConstructGeneration.cs:171
                        block.CloseBrace();                                                                                                 // FhirConstructGeneration.cs:172
                    }                                                                                                                       // FhirConstructGeneration.cs:173
                }                                                                                                                           // FhirConstructGeneration.cs:174
                if (fix.MeaningWhenMissingElement != null)                                                                                  // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.MeaningWhenMissingElement = new Markdown();");                                            // FhirConstructGeneration.cs:209
                    if (fix.MeaningWhenMissingElement.Value != null)                                                                        // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.MeaningWhenMissingElement.Value = \"{fix.MeaningWhenMissingElement.Value}\";");           // FhirConstructGeneration.cs:138
                    if (fix.MeaningWhenMissingElement.ElementId != null)                                                                    // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.MeaningWhenMissingElement.ElementId = \"{fix.MeaningWhenMissingElement.ElementId}\";");   // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.OrderMeaningElement != null)                                                                                        // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.OrderMeaningElement = new FhirString();");                                                // FhirConstructGeneration.cs:209
                    if (fix.OrderMeaningElement.Value != null)                                                                              // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.OrderMeaningElement.Value = \"{fix.OrderMeaningElement.Value}\";");                       // FhirConstructGeneration.cs:138
                    if (fix.OrderMeaningElement.ElementId != null)                                                                          // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.OrderMeaningElement.ElementId = \"{fix.OrderMeaningElement.ElementId}\";");               // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.Example != null)                                                                                                    // FhirConstructGeneration.cs:159
                {                                                                                                                           // FhirConstructGeneration.cs:160
                    block.AppendCode($"retVal.Example = new List<ElementDefinition.ExampleComponent>();");                                  // FhirConstructGeneration.cs:161
                    foreach (var temp59 in fix.Example)                                                                                     // FhirConstructGeneration.cs:162
                    {                                                                                                                       // FhirConstructGeneration.cs:163
                        block.OpenBrace();                                                                                                  // FhirConstructGeneration.cs:164
                        block.AppendCode("var temp60 = new ElementDefinition.ExampleComponent();");                                         // FhirConstructGeneration.cs:165
                        if (temp59.LabelElement != null)                                                                                    // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"temp60.LabelElement = new FhirString();");                                               // FhirConstructGeneration.cs:209
                            if (temp59.LabelElement.Value != null)                                                                          // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp60.LabelElement.Value = \"{temp59.LabelElement.Value}\";");                          // FhirConstructGeneration.cs:138
                            if (temp59.LabelElement.ElementId != null)                                                                      // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp60.LabelElement.ElementId = \"{temp59.LabelElement.ElementId}\";");                  // FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (temp59.ElementId != null)                                                                                       // FhirConstructGeneration.cs:137
                            block.AppendCode($"temp60.ElementId = \"{temp59.ElementId}\";");                                                // FhirConstructGeneration.cs:138
                        block.AppendCode($"retVal.Example.Add(temp60);");                                                                   // FhirConstructGeneration.cs:171
                        block.CloseBrace();                                                                                                 // FhirConstructGeneration.cs:172
                    }                                                                                                                       // FhirConstructGeneration.cs:173
                }                                                                                                                           // FhirConstructGeneration.cs:174
                if (fix.MaxLengthElement != null)                                                                                           // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.MaxLengthElement = new Integer();");                                                      // FhirConstructGeneration.cs:209
                    if (fix.MaxLengthElement.Value.HasValue == true)                                                                        // FhirConstructGeneration.cs:130
                        block.AppendCode($"retVal.MaxLengthElement.Value = new Nullable<int>((int) {fix.MaxLengthElement.Value.Value});");  // FhirConstructGeneration.cs:131
                    if (fix.MaxLengthElement.ElementId != null)                                                                             // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.MaxLengthElement.ElementId = \"{fix.MaxLengthElement.ElementId}\";");                     // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.ConditionElement != null)                                                                                           // FhirConstructGeneration.cs:159
                {                                                                                                                           // FhirConstructGeneration.cs:160
                    block.AppendCode($"retVal.ConditionElement = new List<Id>();");                                                         // FhirConstructGeneration.cs:161
                    foreach (var temp61 in fix.ConditionElement)                                                                            // FhirConstructGeneration.cs:162
                    {                                                                                                                       // FhirConstructGeneration.cs:163
                        block.OpenBrace();                                                                                                  // FhirConstructGeneration.cs:164
                        block.AppendCode("var temp62 = new Id();");                                                                         // FhirConstructGeneration.cs:165
                        if (temp61.Value != null)                                                                                           // FhirConstructGeneration.cs:137
                            block.AppendCode($"temp62.Value = \"{temp61.Value}\";");                                                        // FhirConstructGeneration.cs:138
                        if (temp61.ElementId != null)                                                                                       // FhirConstructGeneration.cs:137
                            block.AppendCode($"temp62.ElementId = \"{temp61.ElementId}\";");                                                // FhirConstructGeneration.cs:138
                        block.AppendCode($"retVal.ConditionElement.Add(temp62);");                                                          // FhirConstructGeneration.cs:171
                        block.CloseBrace();                                                                                                 // FhirConstructGeneration.cs:172
                    }                                                                                                                       // FhirConstructGeneration.cs:173
                }                                                                                                                           // FhirConstructGeneration.cs:174
                if (fix.Constraint != null)                                                                                                 // FhirConstructGeneration.cs:159
                {                                                                                                                           // FhirConstructGeneration.cs:160
                    block.AppendCode($"retVal.Constraint = new List<ElementDefinition.ConstraintComponent>();");                            // FhirConstructGeneration.cs:161
                    foreach (var temp63 in fix.Constraint)                                                                                  // FhirConstructGeneration.cs:162
                    {                                                                                                                       // FhirConstructGeneration.cs:163
                        block.OpenBrace();                                                                                                  // FhirConstructGeneration.cs:164
                        block.AppendCode("var temp64 = new ElementDefinition.ConstraintComponent();");                                      // FhirConstructGeneration.cs:165
                        if (temp63.KeyElement != null)                                                                                      // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"temp64.KeyElement = new Id();");                                                         // FhirConstructGeneration.cs:209
                            if (temp63.KeyElement.Value != null)                                                                            // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp64.KeyElement.Value = \"{temp63.KeyElement.Value}\";");                              // FhirConstructGeneration.cs:138
                            if (temp63.KeyElement.ElementId != null)                                                                        // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp64.KeyElement.ElementId = \"{temp63.KeyElement.ElementId}\";");                      // FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (temp63.RequirementsElement != null)                                                                             // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"temp64.RequirementsElement = new FhirString();");                                        // FhirConstructGeneration.cs:209
                            if (temp63.RequirementsElement.Value != null)                                                                   // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp64.RequirementsElement.Value = \"{temp63.RequirementsElement.Value}\";");            // FhirConstructGeneration.cs:138
                            if (temp63.RequirementsElement.ElementId != null)                                                               // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp64.RequirementsElement.ElementId = \"{temp63.RequirementsElement.ElementId}\";");    // FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (temp63.SeverityElement != null)                                                                                 // FhirConstructGeneration.cs:147
                            block.AppendCode($"temp64.SeverityElement = new Code<ElementDefinition.ConstraintSeverity>(ElementDefinition.ConstraintSeverity.{temp63.SeverityElement.Value});");// FhirConstructGeneration.cs:148
                        if (temp63.HumanElement != null)                                                                                    // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"temp64.HumanElement = new FhirString();");                                               // FhirConstructGeneration.cs:209
                            if (temp63.HumanElement.Value != null)                                                                          // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp64.HumanElement.Value = \"{temp63.HumanElement.Value}\";");                          // FhirConstructGeneration.cs:138
                            if (temp63.HumanElement.ElementId != null)                                                                      // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp64.HumanElement.ElementId = \"{temp63.HumanElement.ElementId}\";");                  // FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (temp63.ExpressionElement != null)                                                                               // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"temp64.ExpressionElement = new FhirString();");                                          // FhirConstructGeneration.cs:209
                            if (temp63.ExpressionElement.Value != null)                                                                     // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp64.ExpressionElement.Value = \"{temp63.ExpressionElement.Value}\";");                // FhirConstructGeneration.cs:138
                            if (temp63.ExpressionElement.ElementId != null)                                                                 // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp64.ExpressionElement.ElementId = \"{temp63.ExpressionElement.ElementId}\";");        // FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (temp63.XpathElement != null)                                                                                    // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"temp64.XpathElement = new FhirString();");                                               // FhirConstructGeneration.cs:209
                            if (temp63.XpathElement.Value != null)                                                                          // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp64.XpathElement.Value = \"{temp63.XpathElement.Value}\";");                          // FhirConstructGeneration.cs:138
                            if (temp63.XpathElement.ElementId != null)                                                                      // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp64.XpathElement.ElementId = \"{temp63.XpathElement.ElementId}\";");                  // FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (temp63.SourceElement != null)                                                                                   // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"temp64.SourceElement = new FhirUri();");                                                 // FhirConstructGeneration.cs:209
                            if (temp63.SourceElement.Value != null)                                                                         // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp64.SourceElement.Value = \"{temp63.SourceElement.Value}\";");                        // FhirConstructGeneration.cs:138
                            if (temp63.SourceElement.ElementId != null)                                                                     // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp64.SourceElement.ElementId = \"{temp63.SourceElement.ElementId}\";");                // FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (temp63.ElementId != null)                                                                                       // FhirConstructGeneration.cs:137
                            block.AppendCode($"temp64.ElementId = \"{temp63.ElementId}\";");                                                // FhirConstructGeneration.cs:138
                        block.AppendCode($"retVal.Constraint.Add(temp64);");                                                                // FhirConstructGeneration.cs:171
                        block.CloseBrace();                                                                                                 // FhirConstructGeneration.cs:172
                    }                                                                                                                       // FhirConstructGeneration.cs:173
                }                                                                                                                           // FhirConstructGeneration.cs:174
                if (fix.MustSupportElement != null)                                                                                         // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.MustSupportElement = new FhirBoolean();");                                                // FhirConstructGeneration.cs:209
                    if (fix.MustSupportElement.Value.HasValue == true)                                                                      // FhirConstructGeneration.cs:69
                    {                                                                                                                       // FhirConstructGeneration.cs:70
                        if (fix.MustSupportElement.Value.Value == true)                                                                     // FhirConstructGeneration.cs:71
                            block.AppendCode($"retVal.MustSupportElement.Value = true;");                                                   // FhirConstructGeneration.cs:72
                        else                                                                                                                // FhirConstructGeneration.cs:73
                            block.AppendCode($"retVal.MustSupportElement.Value = false;");                                                  // FhirConstructGeneration.cs:74
                    }                                                                                                                       // FhirConstructGeneration.cs:75
                    if (fix.MustSupportElement.ElementId != null)                                                                           // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.MustSupportElement.ElementId = \"{fix.MustSupportElement.ElementId}\";");                 // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.IsModifierElement != null)                                                                                          // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.IsModifierElement = new FhirBoolean();");                                                 // FhirConstructGeneration.cs:209
                    if (fix.IsModifierElement.Value.HasValue == true)                                                                       // FhirConstructGeneration.cs:69
                    {                                                                                                                       // FhirConstructGeneration.cs:70
                        if (fix.IsModifierElement.Value.Value == true)                                                                      // FhirConstructGeneration.cs:71
                            block.AppendCode($"retVal.IsModifierElement.Value = true;");                                                    // FhirConstructGeneration.cs:72
                        else                                                                                                                // FhirConstructGeneration.cs:73
                            block.AppendCode($"retVal.IsModifierElement.Value = false;");                                                   // FhirConstructGeneration.cs:74
                    }                                                                                                                       // FhirConstructGeneration.cs:75
                    if (fix.IsModifierElement.ElementId != null)                                                                            // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.IsModifierElement.ElementId = \"{fix.IsModifierElement.ElementId}\";");                   // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.IsSummaryElement != null)                                                                                           // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.IsSummaryElement = new FhirBoolean();");                                                  // FhirConstructGeneration.cs:209
                    if (fix.IsSummaryElement.Value.HasValue == true)                                                                        // FhirConstructGeneration.cs:69
                    {                                                                                                                       // FhirConstructGeneration.cs:70
                        if (fix.IsSummaryElement.Value.Value == true)                                                                       // FhirConstructGeneration.cs:71
                            block.AppendCode($"retVal.IsSummaryElement.Value = true;");                                                     // FhirConstructGeneration.cs:72
                        else                                                                                                                // FhirConstructGeneration.cs:73
                            block.AppendCode($"retVal.IsSummaryElement.Value = false;");                                                    // FhirConstructGeneration.cs:74
                    }                                                                                                                       // FhirConstructGeneration.cs:75
                    if (fix.IsSummaryElement.ElementId != null)                                                                             // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.IsSummaryElement.ElementId = \"{fix.IsSummaryElement.ElementId}\";");                     // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.Binding != null)                                                                                                    // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.Binding = new ElementDefinition.ElementDefinitionBindingComponent();");                   // FhirConstructGeneration.cs:209
                    if (fix.Binding.StrengthElement != null)                                                                                // FhirConstructGeneration.cs:147
                        block.AppendCode($"retVal.Binding.StrengthElement = new Code<BindingStrength>(BindingStrength.{fix.Binding.StrengthElement.Value});");// FhirConstructGeneration.cs:148
                    if (fix.Binding.DescriptionElement != null)                                                                             // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Binding.DescriptionElement = new FhirString();");                                     // FhirConstructGeneration.cs:209
                        if (fix.Binding.DescriptionElement.Value != null)                                                                   // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Binding.DescriptionElement.Value = \"{fix.Binding.DescriptionElement.Value}\";");     // FhirConstructGeneration.cs:138
                        if (fix.Binding.DescriptionElement.ElementId != null)                                                               // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Binding.DescriptionElement.ElementId = \"{fix.Binding.DescriptionElement.ElementId}\";");// FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Binding.ElementId != null)                                                                                      // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.Binding.ElementId = \"{fix.Binding.ElementId}\";");                                       // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.Mapping != null)                                                                                                    // FhirConstructGeneration.cs:159
                {                                                                                                                           // FhirConstructGeneration.cs:160
                    block.AppendCode($"retVal.Mapping = new List<ElementDefinition.MappingComponent>();");                                  // FhirConstructGeneration.cs:161
                    foreach (var temp65 in fix.Mapping)                                                                                     // FhirConstructGeneration.cs:162
                    {                                                                                                                       // FhirConstructGeneration.cs:163
                        block.OpenBrace();                                                                                                  // FhirConstructGeneration.cs:164
                        block.AppendCode("var temp66 = new ElementDefinition.MappingComponent();");                                         // FhirConstructGeneration.cs:165
                        if (temp65.IdentityElement != null)                                                                                 // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"temp66.IdentityElement = new Id();");                                                    // FhirConstructGeneration.cs:209
                            if (temp65.IdentityElement.Value != null)                                                                       // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp66.IdentityElement.Value = \"{temp65.IdentityElement.Value}\";");                    // FhirConstructGeneration.cs:138
                            if (temp65.IdentityElement.ElementId != null)                                                                   // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp66.IdentityElement.ElementId = \"{temp65.IdentityElement.ElementId}\";");            // FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (temp65.LanguageElement != null)                                                                                 // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"temp66.LanguageElement = new Code();");                                                  // FhirConstructGeneration.cs:209
                            if (temp65.LanguageElement.Value != null)                                                                       // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp66.LanguageElement.Value = \"{temp65.LanguageElement.Value}\";");                    // FhirConstructGeneration.cs:138
                            if (temp65.LanguageElement.ElementId != null)                                                                   // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp66.LanguageElement.ElementId = \"{temp65.LanguageElement.ElementId}\";");            // FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (temp65.MapElement != null)                                                                                      // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"temp66.MapElement = new FhirString();");                                                 // FhirConstructGeneration.cs:209
                            if (temp65.MapElement.Value != null)                                                                            // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp66.MapElement.Value = \"{temp65.MapElement.Value}\";");                              // FhirConstructGeneration.cs:138
                            if (temp65.MapElement.ElementId != null)                                                                        // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp66.MapElement.ElementId = \"{temp65.MapElement.ElementId}\";");                      // FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (temp65.CommentElement != null)                                                                                  // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"temp66.CommentElement = new FhirString();");                                             // FhirConstructGeneration.cs:209
                            if (temp65.CommentElement.Value != null)                                                                        // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp66.CommentElement.Value = \"{temp65.CommentElement.Value}\";");                      // FhirConstructGeneration.cs:138
                            if (temp65.CommentElement.ElementId != null)                                                                    // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp66.CommentElement.ElementId = \"{temp65.CommentElement.ElementId}\";");              // FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (temp65.ElementId != null)                                                                                       // FhirConstructGeneration.cs:137
                            block.AppendCode($"temp66.ElementId = \"{temp65.ElementId}\";");                                                // FhirConstructGeneration.cs:138
                        block.AppendCode($"retVal.Mapping.Add(temp66);");                                                                   // FhirConstructGeneration.cs:171
                        block.CloseBrace();                                                                                                 // FhirConstructGeneration.cs:172
                    }                                                                                                                       // FhirConstructGeneration.cs:173
                }                                                                                                                           // FhirConstructGeneration.cs:174
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:338
            block                                                                                                                           // FhirConstructGeneration.cs:339
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:340
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:341
                ;                                                                                                                           // FhirConstructGeneration.cs:342
            return  true;                                                                                                                   // FhirConstructGeneration.cs:343
        }                                                                                                                                   // FhirConstructGeneration.cs:344
                                                                                                                                            // FhirConstructGeneration.cs:315
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:319
            Extension fix,                                                                                                                  // FhirConstructGeneration.cs:320
            String methodName,                                                                                                              // FhirConstructGeneration.cs:321
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:322
        {                                                                                                                                   // FhirConstructGeneration.cs:323
                                                                                                                                            // FhirConstructGeneration.cs:325
            block                                                                                                                           // FhirConstructGeneration.cs:326
                .AppendCode($"{methodAccess} Extension {methodName}()")                                                                     // FhirConstructGeneration.cs:327
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:328
                .AppendCode("Extension retVal = new Extension();")                                                                          // FhirConstructGeneration.cs:329
                ;                                                                                                                           // FhirConstructGeneration.cs:330
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:331
            {                                                                                                                               // FhirConstructGeneration.cs:332
                if (fix.Url != null)                                                                                                        // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.Url = \"{fix.Url}\";");                                                                       // FhirConstructGeneration.cs:138
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:338
            block                                                                                                                           // FhirConstructGeneration.cs:339
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:340
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:341
                ;                                                                                                                           // FhirConstructGeneration.cs:342
            return  true;                                                                                                                   // FhirConstructGeneration.cs:343
        }                                                                                                                                   // FhirConstructGeneration.cs:344
                                                                                                                                            // FhirConstructGeneration.cs:315
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:319
            HumanName fix,                                                                                                                  // FhirConstructGeneration.cs:320
            String methodName,                                                                                                              // FhirConstructGeneration.cs:321
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:322
        {                                                                                                                                   // FhirConstructGeneration.cs:323
                                                                                                                                            // FhirConstructGeneration.cs:325
            block                                                                                                                           // FhirConstructGeneration.cs:326
                .AppendCode($"{methodAccess} HumanName {methodName}()")                                                                     // FhirConstructGeneration.cs:327
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:328
                .AppendCode("HumanName retVal = new HumanName();")                                                                          // FhirConstructGeneration.cs:329
                ;                                                                                                                           // FhirConstructGeneration.cs:330
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:331
            {                                                                                                                               // FhirConstructGeneration.cs:332
                if (fix.UseElement != null)                                                                                                 // FhirConstructGeneration.cs:147
                    block.AppendCode($"retVal.UseElement = new Code<HumanName.NameUse>(HumanName.NameUse.{fix.UseElement.Value});");        // FhirConstructGeneration.cs:148
                if (fix.TextElement != null)                                                                                                // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.TextElement = new FhirString();");                                                        // FhirConstructGeneration.cs:209
                    if (fix.TextElement.Value != null)                                                                                      // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.TextElement.Value = \"{fix.TextElement.Value}\";");                                       // FhirConstructGeneration.cs:138
                    if (fix.TextElement.ElementId != null)                                                                                  // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.TextElement.ElementId = \"{fix.TextElement.ElementId}\";");                               // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.FamilyElement != null)                                                                                              // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.FamilyElement = new FhirString();");                                                      // FhirConstructGeneration.cs:209
                    if (fix.FamilyElement.Value != null)                                                                                    // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.FamilyElement.Value = \"{fix.FamilyElement.Value}\";");                                   // FhirConstructGeneration.cs:138
                    if (fix.FamilyElement.ElementId != null)                                                                                // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.FamilyElement.ElementId = \"{fix.FamilyElement.ElementId}\";");                           // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.GivenElement != null)                                                                                               // FhirConstructGeneration.cs:159
                {                                                                                                                           // FhirConstructGeneration.cs:160
                    block.AppendCode($"retVal.GivenElement = new List<FhirString>();");                                                     // FhirConstructGeneration.cs:161
                    foreach (var temp67 in fix.GivenElement)                                                                                // FhirConstructGeneration.cs:162
                    {                                                                                                                       // FhirConstructGeneration.cs:163
                        block.OpenBrace();                                                                                                  // FhirConstructGeneration.cs:164
                        block.AppendCode("var temp68 = new FhirString();");                                                                 // FhirConstructGeneration.cs:165
                        if (temp67.Value != null)                                                                                           // FhirConstructGeneration.cs:137
                            block.AppendCode($"temp68.Value = \"{temp67.Value}\";");                                                        // FhirConstructGeneration.cs:138
                        if (temp67.ElementId != null)                                                                                       // FhirConstructGeneration.cs:137
                            block.AppendCode($"temp68.ElementId = \"{temp67.ElementId}\";");                                                // FhirConstructGeneration.cs:138
                        block.AppendCode($"retVal.GivenElement.Add(temp68);");                                                              // FhirConstructGeneration.cs:171
                        block.CloseBrace();                                                                                                 // FhirConstructGeneration.cs:172
                    }                                                                                                                       // FhirConstructGeneration.cs:173
                }                                                                                                                           // FhirConstructGeneration.cs:174
                if (fix.PrefixElement != null)                                                                                              // FhirConstructGeneration.cs:159
                {                                                                                                                           // FhirConstructGeneration.cs:160
                    block.AppendCode($"retVal.PrefixElement = new List<FhirString>();");                                                    // FhirConstructGeneration.cs:161
                    foreach (var temp69 in fix.PrefixElement)                                                                               // FhirConstructGeneration.cs:162
                    {                                                                                                                       // FhirConstructGeneration.cs:163
                        block.OpenBrace();                                                                                                  // FhirConstructGeneration.cs:164
                        block.AppendCode("var temp70 = new FhirString();");                                                                 // FhirConstructGeneration.cs:165
                        if (temp69.Value != null)                                                                                           // FhirConstructGeneration.cs:137
                            block.AppendCode($"temp70.Value = \"{temp69.Value}\";");                                                        // FhirConstructGeneration.cs:138
                        if (temp69.ElementId != null)                                                                                       // FhirConstructGeneration.cs:137
                            block.AppendCode($"temp70.ElementId = \"{temp69.ElementId}\";");                                                // FhirConstructGeneration.cs:138
                        block.AppendCode($"retVal.PrefixElement.Add(temp70);");                                                             // FhirConstructGeneration.cs:171
                        block.CloseBrace();                                                                                                 // FhirConstructGeneration.cs:172
                    }                                                                                                                       // FhirConstructGeneration.cs:173
                }                                                                                                                           // FhirConstructGeneration.cs:174
                if (fix.SuffixElement != null)                                                                                              // FhirConstructGeneration.cs:159
                {                                                                                                                           // FhirConstructGeneration.cs:160
                    block.AppendCode($"retVal.SuffixElement = new List<FhirString>();");                                                    // FhirConstructGeneration.cs:161
                    foreach (var temp71 in fix.SuffixElement)                                                                               // FhirConstructGeneration.cs:162
                    {                                                                                                                       // FhirConstructGeneration.cs:163
                        block.OpenBrace();                                                                                                  // FhirConstructGeneration.cs:164
                        block.AppendCode("var temp72 = new FhirString();");                                                                 // FhirConstructGeneration.cs:165
                        if (temp71.Value != null)                                                                                           // FhirConstructGeneration.cs:137
                            block.AppendCode($"temp72.Value = \"{temp71.Value}\";");                                                        // FhirConstructGeneration.cs:138
                        if (temp71.ElementId != null)                                                                                       // FhirConstructGeneration.cs:137
                            block.AppendCode($"temp72.ElementId = \"{temp71.ElementId}\";");                                                // FhirConstructGeneration.cs:138
                        block.AppendCode($"retVal.SuffixElement.Add(temp72);");                                                             // FhirConstructGeneration.cs:171
                        block.CloseBrace();                                                                                                 // FhirConstructGeneration.cs:172
                    }                                                                                                                       // FhirConstructGeneration.cs:173
                }                                                                                                                           // FhirConstructGeneration.cs:174
                if (fix.Period != null)                                                                                                     // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.Period = new Period();");                                                                 // FhirConstructGeneration.cs:209
                    if (fix.Period.StartElement != null)                                                                                    // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Period.StartElement = new FhirDateTime();");                                          // FhirConstructGeneration.cs:209
                        if (fix.Period.StartElement.Value != null)                                                                          // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Period.StartElement.Value = \"{fix.Period.StartElement.Value}\";");                   // FhirConstructGeneration.cs:138
                        if (fix.Period.StartElement.ElementId != null)                                                                      // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Period.StartElement.ElementId = \"{fix.Period.StartElement.ElementId}\";");           // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Period.EndElement != null)                                                                                      // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Period.EndElement = new FhirDateTime();");                                            // FhirConstructGeneration.cs:209
                        if (fix.Period.EndElement.Value != null)                                                                            // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Period.EndElement.Value = \"{fix.Period.EndElement.Value}\";");                       // FhirConstructGeneration.cs:138
                        if (fix.Period.EndElement.ElementId != null)                                                                        // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Period.EndElement.ElementId = \"{fix.Period.EndElement.ElementId}\";");               // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Period.ElementId != null)                                                                                       // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.Period.ElementId = \"{fix.Period.ElementId}\";");                                         // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:338
            block                                                                                                                           // FhirConstructGeneration.cs:339
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:340
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:341
                ;                                                                                                                           // FhirConstructGeneration.cs:342
            return  true;                                                                                                                   // FhirConstructGeneration.cs:343
        }                                                                                                                                   // FhirConstructGeneration.cs:344
                                                                                                                                            // FhirConstructGeneration.cs:315
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:319
            Identifier fix,                                                                                                                 // FhirConstructGeneration.cs:320
            String methodName,                                                                                                              // FhirConstructGeneration.cs:321
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:322
        {                                                                                                                                   // FhirConstructGeneration.cs:323
                                                                                                                                            // FhirConstructGeneration.cs:325
            block                                                                                                                           // FhirConstructGeneration.cs:326
                .AppendCode($"{methodAccess} Identifier {methodName}()")                                                                    // FhirConstructGeneration.cs:327
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:328
                .AppendCode("Identifier retVal = new Identifier();")                                                                        // FhirConstructGeneration.cs:329
                ;                                                                                                                           // FhirConstructGeneration.cs:330
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:331
            {                                                                                                                               // FhirConstructGeneration.cs:332
                if (fix.UseElement != null)                                                                                                 // FhirConstructGeneration.cs:147
                    block.AppendCode($"retVal.UseElement = new Code<Identifier.IdentifierUse>(Identifier.IdentifierUse.{fix.UseElement.Value});");// FhirConstructGeneration.cs:148
                if (fix.Type != null)                                                                                                       // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.Type = new CodeableConcept();");                                                          // FhirConstructGeneration.cs:209
                    if (fix.Type.Coding != null)                                                                                            // FhirConstructGeneration.cs:159
                    {                                                                                                                       // FhirConstructGeneration.cs:160
                        block.AppendCode($"retVal.Type.Coding = new List<Coding>();");                                                      // FhirConstructGeneration.cs:161
                        foreach (var temp73 in fix.Type.Coding)                                                                             // FhirConstructGeneration.cs:162
                        {                                                                                                                   // FhirConstructGeneration.cs:163
                            block.OpenBrace();                                                                                              // FhirConstructGeneration.cs:164
                            block.AppendCode("var temp74 = new Coding();");                                                                 // FhirConstructGeneration.cs:165
                            if (temp73.SystemElement != null)                                                                               // FhirConstructGeneration.cs:207
                            {                                                                                                               // FhirConstructGeneration.cs:208
                                    block.AppendCode($"temp74.SystemElement = new FhirUri();");                                             // FhirConstructGeneration.cs:209
                                if (temp73.SystemElement.Value != null)                                                                     // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp74.SystemElement.Value = \"{temp73.SystemElement.Value}\";");                    // FhirConstructGeneration.cs:138
                                if (temp73.SystemElement.ElementId != null)                                                                 // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp74.SystemElement.ElementId = \"{temp73.SystemElement.ElementId}\";");            // FhirConstructGeneration.cs:138
                            }                                                                                                               // FhirConstructGeneration.cs:213
                            if (temp73.VersionElement != null)                                                                              // FhirConstructGeneration.cs:207
                            {                                                                                                               // FhirConstructGeneration.cs:208
                                    block.AppendCode($"temp74.VersionElement = new FhirString();");                                         // FhirConstructGeneration.cs:209
                                if (temp73.VersionElement.Value != null)                                                                    // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp74.VersionElement.Value = \"{temp73.VersionElement.Value}\";");                  // FhirConstructGeneration.cs:138
                                if (temp73.VersionElement.ElementId != null)                                                                // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp74.VersionElement.ElementId = \"{temp73.VersionElement.ElementId}\";");          // FhirConstructGeneration.cs:138
                            }                                                                                                               // FhirConstructGeneration.cs:213
                            if (temp73.CodeElement != null)                                                                                 // FhirConstructGeneration.cs:207
                            {                                                                                                               // FhirConstructGeneration.cs:208
                                    block.AppendCode($"temp74.CodeElement = new Code();");                                                  // FhirConstructGeneration.cs:209
                                if (temp73.CodeElement.Value != null)                                                                       // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp74.CodeElement.Value = \"{temp73.CodeElement.Value}\";");                        // FhirConstructGeneration.cs:138
                                if (temp73.CodeElement.ElementId != null)                                                                   // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp74.CodeElement.ElementId = \"{temp73.CodeElement.ElementId}\";");                // FhirConstructGeneration.cs:138
                            }                                                                                                               // FhirConstructGeneration.cs:213
                            if (temp73.DisplayElement != null)                                                                              // FhirConstructGeneration.cs:207
                            {                                                                                                               // FhirConstructGeneration.cs:208
                                    block.AppendCode($"temp74.DisplayElement = new FhirString();");                                         // FhirConstructGeneration.cs:209
                                if (temp73.DisplayElement.Value != null)                                                                    // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp74.DisplayElement.Value = \"{temp73.DisplayElement.Value}\";");                  // FhirConstructGeneration.cs:138
                                if (temp73.DisplayElement.ElementId != null)                                                                // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp74.DisplayElement.ElementId = \"{temp73.DisplayElement.ElementId}\";");          // FhirConstructGeneration.cs:138
                            }                                                                                                               // FhirConstructGeneration.cs:213
                            if (temp73.UserSelectedElement != null)                                                                         // FhirConstructGeneration.cs:207
                            {                                                                                                               // FhirConstructGeneration.cs:208
                                    block.AppendCode($"temp74.UserSelectedElement = new FhirBoolean();");                                   // FhirConstructGeneration.cs:209
                                if (temp73.UserSelectedElement.Value.HasValue == true)                                                      // FhirConstructGeneration.cs:69
                                {                                                                                                           // FhirConstructGeneration.cs:70
                                    if (temp73.UserSelectedElement.Value.Value == true)                                                     // FhirConstructGeneration.cs:71
                                        block.AppendCode($"temp74.UserSelectedElement.Value = true;");                                      // FhirConstructGeneration.cs:72
                                    else                                                                                                    // FhirConstructGeneration.cs:73
                                        block.AppendCode($"temp74.UserSelectedElement.Value = false;");                                     // FhirConstructGeneration.cs:74
                                }                                                                                                           // FhirConstructGeneration.cs:75
                                if (temp73.UserSelectedElement.ElementId != null)                                                           // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp74.UserSelectedElement.ElementId = \"{temp73.UserSelectedElement.ElementId}\";");// FhirConstructGeneration.cs:138
                            }                                                                                                               // FhirConstructGeneration.cs:213
                            if (temp73.ElementId != null)                                                                                   // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp74.ElementId = \"{temp73.ElementId}\";");                                            // FhirConstructGeneration.cs:138
                            block.AppendCode($"retVal.Type.Coding.Add(temp74);");                                                           // FhirConstructGeneration.cs:171
                            block.CloseBrace();                                                                                             // FhirConstructGeneration.cs:172
                        }                                                                                                                   // FhirConstructGeneration.cs:173
                    }                                                                                                                       // FhirConstructGeneration.cs:174
                    if (fix.Type.TextElement != null)                                                                                       // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Type.TextElement = new FhirString();");                                               // FhirConstructGeneration.cs:209
                        if (fix.Type.TextElement.Value != null)                                                                             // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Type.TextElement.Value = \"{fix.Type.TextElement.Value}\";");                         // FhirConstructGeneration.cs:138
                        if (fix.Type.TextElement.ElementId != null)                                                                         // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Type.TextElement.ElementId = \"{fix.Type.TextElement.ElementId}\";");                 // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Type.ElementId != null)                                                                                         // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.Type.ElementId = \"{fix.Type.ElementId}\";");                                             // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.SystemElement != null)                                                                                              // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.SystemElement = new FhirUri();");                                                         // FhirConstructGeneration.cs:209
                    if (fix.SystemElement.Value != null)                                                                                    // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.SystemElement.Value = \"{fix.SystemElement.Value}\";");                                   // FhirConstructGeneration.cs:138
                    if (fix.SystemElement.ElementId != null)                                                                                // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.SystemElement.ElementId = \"{fix.SystemElement.ElementId}\";");                           // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.ValueElement != null)                                                                                               // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.ValueElement = new FhirString();");                                                       // FhirConstructGeneration.cs:209
                    if (fix.ValueElement.Value != null)                                                                                     // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.ValueElement.Value = \"{fix.ValueElement.Value}\";");                                     // FhirConstructGeneration.cs:138
                    if (fix.ValueElement.ElementId != null)                                                                                 // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.ValueElement.ElementId = \"{fix.ValueElement.ElementId}\";");                             // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.Period != null)                                                                                                     // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.Period = new Period();");                                                                 // FhirConstructGeneration.cs:209
                    if (fix.Period.StartElement != null)                                                                                    // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Period.StartElement = new FhirDateTime();");                                          // FhirConstructGeneration.cs:209
                        if (fix.Period.StartElement.Value != null)                                                                          // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Period.StartElement.Value = \"{fix.Period.StartElement.Value}\";");                   // FhirConstructGeneration.cs:138
                        if (fix.Period.StartElement.ElementId != null)                                                                      // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Period.StartElement.ElementId = \"{fix.Period.StartElement.ElementId}\";");           // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Period.EndElement != null)                                                                                      // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Period.EndElement = new FhirDateTime();");                                            // FhirConstructGeneration.cs:209
                        if (fix.Period.EndElement.Value != null)                                                                            // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Period.EndElement.Value = \"{fix.Period.EndElement.Value}\";");                       // FhirConstructGeneration.cs:138
                        if (fix.Period.EndElement.ElementId != null)                                                                        // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Period.EndElement.ElementId = \"{fix.Period.EndElement.ElementId}\";");               // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Period.ElementId != null)                                                                                       // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.Period.ElementId = \"{fix.Period.ElementId}\";");                                         // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:338
            block                                                                                                                           // FhirConstructGeneration.cs:339
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:340
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:341
                ;                                                                                                                           // FhirConstructGeneration.cs:342
            return  true;                                                                                                                   // FhirConstructGeneration.cs:343
        }                                                                                                                                   // FhirConstructGeneration.cs:344
                                                                                                                                            // FhirConstructGeneration.cs:315
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:319
            Meta fix,                                                                                                                       // FhirConstructGeneration.cs:320
            String methodName,                                                                                                              // FhirConstructGeneration.cs:321
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:322
        {                                                                                                                                   // FhirConstructGeneration.cs:323
                                                                                                                                            // FhirConstructGeneration.cs:325
            block                                                                                                                           // FhirConstructGeneration.cs:326
                .AppendCode($"{methodAccess} Meta {methodName}()")                                                                          // FhirConstructGeneration.cs:327
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:328
                .AppendCode("Meta retVal = new Meta();")                                                                                    // FhirConstructGeneration.cs:329
                ;                                                                                                                           // FhirConstructGeneration.cs:330
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:331
            {                                                                                                                               // FhirConstructGeneration.cs:332
                if (fix.VersionIdElement != null)                                                                                           // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.VersionIdElement = new Id();");                                                           // FhirConstructGeneration.cs:209
                    if (fix.VersionIdElement.Value != null)                                                                                 // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.VersionIdElement.Value = \"{fix.VersionIdElement.Value}\";");                             // FhirConstructGeneration.cs:138
                    if (fix.VersionIdElement.ElementId != null)                                                                             // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.VersionIdElement.ElementId = \"{fix.VersionIdElement.ElementId}\";");                     // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.LastUpdatedElement != null)                                                                                         // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.LastUpdatedElement = new Instant();");                                                    // FhirConstructGeneration.cs:209
                    if (fix.LastUpdatedElement.Value.HasValue == true)                                                                      // FhirConstructGeneration.cs:109
                    {                                                                                                                       // FhirConstructGeneration.cs:110
                        DateTimeOffset x = fix.LastUpdatedElement.Value.Value;                                                              // FhirConstructGeneration.cs:111
                        block                                                                                                               // FhirConstructGeneration.cs:112
                            .AppendCode($"retVal.LastUpdatedElement.Value = new DateTimeOffset({x.Year}, {x.Month}, {x.Day},")              // FhirConstructGeneration.cs:113
                            .AppendCode($"    {x.Hour}, {x.Minute}, {x.Second}, {x.Millisecond},")                                          // FhirConstructGeneration.cs:114
                            .AppendCode($"    new TimeSpan({x.Offset.Hours}, {x.Offset.Minutes}, {x.Offset.Seconds}));")                    // FhirConstructGeneration.cs:115
                        ;                                                                                                                   // FhirConstructGeneration.cs:116
                    }                                                                                                                       // FhirConstructGeneration.cs:117
                    if (fix.LastUpdatedElement.ElementId != null)                                                                           // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.LastUpdatedElement.ElementId = \"{fix.LastUpdatedElement.ElementId}\";");                 // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.ProfileElement != null)                                                                                             // FhirConstructGeneration.cs:159
                {                                                                                                                           // FhirConstructGeneration.cs:160
                    block.AppendCode($"retVal.ProfileElement = new List<FhirUri>();");                                                      // FhirConstructGeneration.cs:161
                    foreach (var temp75 in fix.ProfileElement)                                                                              // FhirConstructGeneration.cs:162
                    {                                                                                                                       // FhirConstructGeneration.cs:163
                        block.OpenBrace();                                                                                                  // FhirConstructGeneration.cs:164
                        block.AppendCode("var temp76 = new FhirUri();");                                                                    // FhirConstructGeneration.cs:165
                        if (temp75.Value != null)                                                                                           // FhirConstructGeneration.cs:137
                            block.AppendCode($"temp76.Value = \"{temp75.Value}\";");                                                        // FhirConstructGeneration.cs:138
                        if (temp75.ElementId != null)                                                                                       // FhirConstructGeneration.cs:137
                            block.AppendCode($"temp76.ElementId = \"{temp75.ElementId}\";");                                                // FhirConstructGeneration.cs:138
                        block.AppendCode($"retVal.ProfileElement.Add(temp76);");                                                            // FhirConstructGeneration.cs:171
                        block.CloseBrace();                                                                                                 // FhirConstructGeneration.cs:172
                    }                                                                                                                       // FhirConstructGeneration.cs:173
                }                                                                                                                           // FhirConstructGeneration.cs:174
                if (fix.Security != null)                                                                                                   // FhirConstructGeneration.cs:159
                {                                                                                                                           // FhirConstructGeneration.cs:160
                    block.AppendCode($"retVal.Security = new List<Coding>();");                                                             // FhirConstructGeneration.cs:161
                    foreach (var temp77 in fix.Security)                                                                                    // FhirConstructGeneration.cs:162
                    {                                                                                                                       // FhirConstructGeneration.cs:163
                        block.OpenBrace();                                                                                                  // FhirConstructGeneration.cs:164
                        block.AppendCode("var temp78 = new Coding();");                                                                     // FhirConstructGeneration.cs:165
                        if (temp77.SystemElement != null)                                                                                   // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"temp78.SystemElement = new FhirUri();");                                                 // FhirConstructGeneration.cs:209
                            if (temp77.SystemElement.Value != null)                                                                         // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp78.SystemElement.Value = \"{temp77.SystemElement.Value}\";");                        // FhirConstructGeneration.cs:138
                            if (temp77.SystemElement.ElementId != null)                                                                     // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp78.SystemElement.ElementId = \"{temp77.SystemElement.ElementId}\";");                // FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (temp77.VersionElement != null)                                                                                  // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"temp78.VersionElement = new FhirString();");                                             // FhirConstructGeneration.cs:209
                            if (temp77.VersionElement.Value != null)                                                                        // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp78.VersionElement.Value = \"{temp77.VersionElement.Value}\";");                      // FhirConstructGeneration.cs:138
                            if (temp77.VersionElement.ElementId != null)                                                                    // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp78.VersionElement.ElementId = \"{temp77.VersionElement.ElementId}\";");              // FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (temp77.CodeElement != null)                                                                                     // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"temp78.CodeElement = new Code();");                                                      // FhirConstructGeneration.cs:209
                            if (temp77.CodeElement.Value != null)                                                                           // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp78.CodeElement.Value = \"{temp77.CodeElement.Value}\";");                            // FhirConstructGeneration.cs:138
                            if (temp77.CodeElement.ElementId != null)                                                                       // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp78.CodeElement.ElementId = \"{temp77.CodeElement.ElementId}\";");                    // FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (temp77.DisplayElement != null)                                                                                  // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"temp78.DisplayElement = new FhirString();");                                             // FhirConstructGeneration.cs:209
                            if (temp77.DisplayElement.Value != null)                                                                        // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp78.DisplayElement.Value = \"{temp77.DisplayElement.Value}\";");                      // FhirConstructGeneration.cs:138
                            if (temp77.DisplayElement.ElementId != null)                                                                    // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp78.DisplayElement.ElementId = \"{temp77.DisplayElement.ElementId}\";");              // FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (temp77.UserSelectedElement != null)                                                                             // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"temp78.UserSelectedElement = new FhirBoolean();");                                       // FhirConstructGeneration.cs:209
                            if (temp77.UserSelectedElement.Value.HasValue == true)                                                          // FhirConstructGeneration.cs:69
                            {                                                                                                               // FhirConstructGeneration.cs:70
                                if (temp77.UserSelectedElement.Value.Value == true)                                                         // FhirConstructGeneration.cs:71
                                    block.AppendCode($"temp78.UserSelectedElement.Value = true;");                                          // FhirConstructGeneration.cs:72
                                else                                                                                                        // FhirConstructGeneration.cs:73
                                    block.AppendCode($"temp78.UserSelectedElement.Value = false;");                                         // FhirConstructGeneration.cs:74
                            }                                                                                                               // FhirConstructGeneration.cs:75
                            if (temp77.UserSelectedElement.ElementId != null)                                                               // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp78.UserSelectedElement.ElementId = \"{temp77.UserSelectedElement.ElementId}\";");    // FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (temp77.ElementId != null)                                                                                       // FhirConstructGeneration.cs:137
                            block.AppendCode($"temp78.ElementId = \"{temp77.ElementId}\";");                                                // FhirConstructGeneration.cs:138
                        block.AppendCode($"retVal.Security.Add(temp78);");                                                                  // FhirConstructGeneration.cs:171
                        block.CloseBrace();                                                                                                 // FhirConstructGeneration.cs:172
                    }                                                                                                                       // FhirConstructGeneration.cs:173
                }                                                                                                                           // FhirConstructGeneration.cs:174
                if (fix.Tag != null)                                                                                                        // FhirConstructGeneration.cs:159
                {                                                                                                                           // FhirConstructGeneration.cs:160
                    block.AppendCode($"retVal.Tag = new List<Coding>();");                                                                  // FhirConstructGeneration.cs:161
                    foreach (var temp79 in fix.Tag)                                                                                         // FhirConstructGeneration.cs:162
                    {                                                                                                                       // FhirConstructGeneration.cs:163
                        block.OpenBrace();                                                                                                  // FhirConstructGeneration.cs:164
                        block.AppendCode("var temp80 = new Coding();");                                                                     // FhirConstructGeneration.cs:165
                        if (temp79.SystemElement != null)                                                                                   // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"temp80.SystemElement = new FhirUri();");                                                 // FhirConstructGeneration.cs:209
                            if (temp79.SystemElement.Value != null)                                                                         // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp80.SystemElement.Value = \"{temp79.SystemElement.Value}\";");                        // FhirConstructGeneration.cs:138
                            if (temp79.SystemElement.ElementId != null)                                                                     // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp80.SystemElement.ElementId = \"{temp79.SystemElement.ElementId}\";");                // FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (temp79.VersionElement != null)                                                                                  // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"temp80.VersionElement = new FhirString();");                                             // FhirConstructGeneration.cs:209
                            if (temp79.VersionElement.Value != null)                                                                        // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp80.VersionElement.Value = \"{temp79.VersionElement.Value}\";");                      // FhirConstructGeneration.cs:138
                            if (temp79.VersionElement.ElementId != null)                                                                    // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp80.VersionElement.ElementId = \"{temp79.VersionElement.ElementId}\";");              // FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (temp79.CodeElement != null)                                                                                     // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"temp80.CodeElement = new Code();");                                                      // FhirConstructGeneration.cs:209
                            if (temp79.CodeElement.Value != null)                                                                           // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp80.CodeElement.Value = \"{temp79.CodeElement.Value}\";");                            // FhirConstructGeneration.cs:138
                            if (temp79.CodeElement.ElementId != null)                                                                       // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp80.CodeElement.ElementId = \"{temp79.CodeElement.ElementId}\";");                    // FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (temp79.DisplayElement != null)                                                                                  // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"temp80.DisplayElement = new FhirString();");                                             // FhirConstructGeneration.cs:209
                            if (temp79.DisplayElement.Value != null)                                                                        // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp80.DisplayElement.Value = \"{temp79.DisplayElement.Value}\";");                      // FhirConstructGeneration.cs:138
                            if (temp79.DisplayElement.ElementId != null)                                                                    // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp80.DisplayElement.ElementId = \"{temp79.DisplayElement.ElementId}\";");              // FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (temp79.UserSelectedElement != null)                                                                             // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"temp80.UserSelectedElement = new FhirBoolean();");                                       // FhirConstructGeneration.cs:209
                            if (temp79.UserSelectedElement.Value.HasValue == true)                                                          // FhirConstructGeneration.cs:69
                            {                                                                                                               // FhirConstructGeneration.cs:70
                                if (temp79.UserSelectedElement.Value.Value == true)                                                         // FhirConstructGeneration.cs:71
                                    block.AppendCode($"temp80.UserSelectedElement.Value = true;");                                          // FhirConstructGeneration.cs:72
                                else                                                                                                        // FhirConstructGeneration.cs:73
                                    block.AppendCode($"temp80.UserSelectedElement.Value = false;");                                         // FhirConstructGeneration.cs:74
                            }                                                                                                               // FhirConstructGeneration.cs:75
                            if (temp79.UserSelectedElement.ElementId != null)                                                               // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp80.UserSelectedElement.ElementId = \"{temp79.UserSelectedElement.ElementId}\";");    // FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (temp79.ElementId != null)                                                                                       // FhirConstructGeneration.cs:137
                            block.AppendCode($"temp80.ElementId = \"{temp79.ElementId}\";");                                                // FhirConstructGeneration.cs:138
                        block.AppendCode($"retVal.Tag.Add(temp80);");                                                                       // FhirConstructGeneration.cs:171
                        block.CloseBrace();                                                                                                 // FhirConstructGeneration.cs:172
                    }                                                                                                                       // FhirConstructGeneration.cs:173
                }                                                                                                                           // FhirConstructGeneration.cs:174
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:338
            block                                                                                                                           // FhirConstructGeneration.cs:339
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:340
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:341
                ;                                                                                                                           // FhirConstructGeneration.cs:342
            return  true;                                                                                                                   // FhirConstructGeneration.cs:343
        }                                                                                                                                   // FhirConstructGeneration.cs:344
                                                                                                                                            // FhirConstructGeneration.cs:315
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:319
            Money fix,                                                                                                                      // FhirConstructGeneration.cs:320
            String methodName,                                                                                                              // FhirConstructGeneration.cs:321
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:322
        {                                                                                                                                   // FhirConstructGeneration.cs:323
                                                                                                                                            // FhirConstructGeneration.cs:325
            block                                                                                                                           // FhirConstructGeneration.cs:326
                .AppendCode($"{methodAccess} Money {methodName}()")                                                                         // FhirConstructGeneration.cs:327
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:328
                .AppendCode("Money retVal = new Money();")                                                                                  // FhirConstructGeneration.cs:329
                ;                                                                                                                           // FhirConstructGeneration.cs:330
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:331
            {                                                                                                                               // FhirConstructGeneration.cs:332
                if (fix.ValueElement != null)                                                                                               // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.ValueElement = new FhirDecimal();");                                                      // FhirConstructGeneration.cs:209
                    if (fix.ValueElement.Value.HasValue == true)                                                                            // FhirConstructGeneration.cs:123
                        block.AppendCode($"retVal.ValueElement.Value = new Nullable<decimal>((decimal) {fix.ValueElement.Value.Value});");  // FhirConstructGeneration.cs:124
                    if (fix.ValueElement.ElementId != null)                                                                                 // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.ValueElement.ElementId = \"{fix.ValueElement.ElementId}\";");                             // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.ComparatorElement != null)                                                                                          // FhirConstructGeneration.cs:147
                    block.AppendCode($"retVal.ComparatorElement = new Code<Quantity.QuantityComparator>(Quantity.QuantityComparator.{fix.ComparatorElement.Value});");// FhirConstructGeneration.cs:148
                if (fix.UnitElement != null)                                                                                                // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.UnitElement = new FhirString();");                                                        // FhirConstructGeneration.cs:209
                    if (fix.UnitElement.Value != null)                                                                                      // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.UnitElement.Value = \"{fix.UnitElement.Value}\";");                                       // FhirConstructGeneration.cs:138
                    if (fix.UnitElement.ElementId != null)                                                                                  // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.UnitElement.ElementId = \"{fix.UnitElement.ElementId}\";");                               // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.SystemElement != null)                                                                                              // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.SystemElement = new FhirUri();");                                                         // FhirConstructGeneration.cs:209
                    if (fix.SystemElement.Value != null)                                                                                    // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.SystemElement.Value = \"{fix.SystemElement.Value}\";");                                   // FhirConstructGeneration.cs:138
                    if (fix.SystemElement.ElementId != null)                                                                                // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.SystemElement.ElementId = \"{fix.SystemElement.ElementId}\";");                           // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.CodeElement != null)                                                                                                // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.CodeElement = new Code();");                                                              // FhirConstructGeneration.cs:209
                    if (fix.CodeElement.Value != null)                                                                                      // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.CodeElement.Value = \"{fix.CodeElement.Value}\";");                                       // FhirConstructGeneration.cs:138
                    if (fix.CodeElement.ElementId != null)                                                                                  // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.CodeElement.ElementId = \"{fix.CodeElement.ElementId}\";");                               // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:338
            block                                                                                                                           // FhirConstructGeneration.cs:339
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:340
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:341
                ;                                                                                                                           // FhirConstructGeneration.cs:342
            return  true;                                                                                                                   // FhirConstructGeneration.cs:343
        }                                                                                                                                   // FhirConstructGeneration.cs:344
                                                                                                                                            // FhirConstructGeneration.cs:315
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:319
            Narrative fix,                                                                                                                  // FhirConstructGeneration.cs:320
            String methodName,                                                                                                              // FhirConstructGeneration.cs:321
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:322
        {                                                                                                                                   // FhirConstructGeneration.cs:323
                                                                                                                                            // FhirConstructGeneration.cs:325
            block                                                                                                                           // FhirConstructGeneration.cs:326
                .AppendCode($"{methodAccess} Narrative {methodName}()")                                                                     // FhirConstructGeneration.cs:327
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:328
                .AppendCode("Narrative retVal = new Narrative();")                                                                          // FhirConstructGeneration.cs:329
                ;                                                                                                                           // FhirConstructGeneration.cs:330
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:331
            {                                                                                                                               // FhirConstructGeneration.cs:332
                if (fix.StatusElement != null)                                                                                              // FhirConstructGeneration.cs:147
                    block.AppendCode($"retVal.StatusElement = new Code<Narrative.NarrativeStatus>(Narrative.NarrativeStatus.{fix.StatusElement.Value});");// FhirConstructGeneration.cs:148
                if (fix.Div != null)                                                                                                        // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.Div = \"{fix.Div}\";");                                                                       // FhirConstructGeneration.cs:138
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:338
            block                                                                                                                           // FhirConstructGeneration.cs:339
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:340
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:341
                ;                                                                                                                           // FhirConstructGeneration.cs:342
            return  true;                                                                                                                   // FhirConstructGeneration.cs:343
        }                                                                                                                                   // FhirConstructGeneration.cs:344
                                                                                                                                            // FhirConstructGeneration.cs:315
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:319
            ParameterDefinition fix,                                                                                                        // FhirConstructGeneration.cs:320
            String methodName,                                                                                                              // FhirConstructGeneration.cs:321
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:322
        {                                                                                                                                   // FhirConstructGeneration.cs:323
                                                                                                                                            // FhirConstructGeneration.cs:325
            block                                                                                                                           // FhirConstructGeneration.cs:326
                .AppendCode($"{methodAccess} ParameterDefinition {methodName}()")                                                           // FhirConstructGeneration.cs:327
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:328
                .AppendCode("ParameterDefinition retVal = new ParameterDefinition();")                                                      // FhirConstructGeneration.cs:329
                ;                                                                                                                           // FhirConstructGeneration.cs:330
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:331
            {                                                                                                                               // FhirConstructGeneration.cs:332
                if (fix.NameElement != null)                                                                                                // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.NameElement = new Code();");                                                              // FhirConstructGeneration.cs:209
                    if (fix.NameElement.Value != null)                                                                                      // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.NameElement.Value = \"{fix.NameElement.Value}\";");                                       // FhirConstructGeneration.cs:138
                    if (fix.NameElement.ElementId != null)                                                                                  // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.NameElement.ElementId = \"{fix.NameElement.ElementId}\";");                               // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.UseElement != null)                                                                                                 // FhirConstructGeneration.cs:147
                    block.AppendCode($"retVal.UseElement = new Code<OperationParameterUse>(OperationParameterUse.{fix.UseElement.Value});");// FhirConstructGeneration.cs:148
                if (fix.MinElement != null)                                                                                                 // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.MinElement = new Integer();");                                                            // FhirConstructGeneration.cs:209
                    if (fix.MinElement.Value.HasValue == true)                                                                              // FhirConstructGeneration.cs:130
                        block.AppendCode($"retVal.MinElement.Value = new Nullable<int>((int) {fix.MinElement.Value.Value});");              // FhirConstructGeneration.cs:131
                    if (fix.MinElement.ElementId != null)                                                                                   // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.MinElement.ElementId = \"{fix.MinElement.ElementId}\";");                                 // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.MaxElement != null)                                                                                                 // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.MaxElement = new FhirString();");                                                         // FhirConstructGeneration.cs:209
                    if (fix.MaxElement.Value != null)                                                                                       // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.MaxElement.Value = \"{fix.MaxElement.Value}\";");                                         // FhirConstructGeneration.cs:138
                    if (fix.MaxElement.ElementId != null)                                                                                   // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.MaxElement.ElementId = \"{fix.MaxElement.ElementId}\";");                                 // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.DocumentationElement != null)                                                                                       // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.DocumentationElement = new FhirString();");                                               // FhirConstructGeneration.cs:209
                    if (fix.DocumentationElement.Value != null)                                                                             // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.DocumentationElement.Value = \"{fix.DocumentationElement.Value}\";");                     // FhirConstructGeneration.cs:138
                    if (fix.DocumentationElement.ElementId != null)                                                                         // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.DocumentationElement.ElementId = \"{fix.DocumentationElement.ElementId}\";");             // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.TypeElement != null)                                                                                                // FhirConstructGeneration.cs:147
                    block.AppendCode($"retVal.TypeElement = new Code<FHIRAllTypes>(FHIRAllTypes.{fix.TypeElement.Value});");                // FhirConstructGeneration.cs:148
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:338
            block                                                                                                                           // FhirConstructGeneration.cs:339
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:340
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:341
                ;                                                                                                                           // FhirConstructGeneration.cs:342
            return  true;                                                                                                                   // FhirConstructGeneration.cs:343
        }                                                                                                                                   // FhirConstructGeneration.cs:344
                                                                                                                                            // FhirConstructGeneration.cs:315
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:319
            Period fix,                                                                                                                     // FhirConstructGeneration.cs:320
            String methodName,                                                                                                              // FhirConstructGeneration.cs:321
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:322
        {                                                                                                                                   // FhirConstructGeneration.cs:323
                                                                                                                                            // FhirConstructGeneration.cs:325
            block                                                                                                                           // FhirConstructGeneration.cs:326
                .AppendCode($"{methodAccess} Period {methodName}()")                                                                        // FhirConstructGeneration.cs:327
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:328
                .AppendCode("Period retVal = new Period();")                                                                                // FhirConstructGeneration.cs:329
                ;                                                                                                                           // FhirConstructGeneration.cs:330
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:331
            {                                                                                                                               // FhirConstructGeneration.cs:332
                if (fix.StartElement != null)                                                                                               // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.StartElement = new FhirDateTime();");                                                     // FhirConstructGeneration.cs:209
                    if (fix.StartElement.Value != null)                                                                                     // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.StartElement.Value = \"{fix.StartElement.Value}\";");                                     // FhirConstructGeneration.cs:138
                    if (fix.StartElement.ElementId != null)                                                                                 // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.StartElement.ElementId = \"{fix.StartElement.ElementId}\";");                             // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.EndElement != null)                                                                                                 // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.EndElement = new FhirDateTime();");                                                       // FhirConstructGeneration.cs:209
                    if (fix.EndElement.Value != null)                                                                                       // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.EndElement.Value = \"{fix.EndElement.Value}\";");                                         // FhirConstructGeneration.cs:138
                    if (fix.EndElement.ElementId != null)                                                                                   // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.EndElement.ElementId = \"{fix.EndElement.ElementId}\";");                                 // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:338
            block                                                                                                                           // FhirConstructGeneration.cs:339
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:340
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:341
                ;                                                                                                                           // FhirConstructGeneration.cs:342
            return  true;                                                                                                                   // FhirConstructGeneration.cs:343
        }                                                                                                                                   // FhirConstructGeneration.cs:344
                                                                                                                                            // FhirConstructGeneration.cs:315
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:319
            Quantity fix,                                                                                                                   // FhirConstructGeneration.cs:320
            String methodName,                                                                                                              // FhirConstructGeneration.cs:321
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:322
        {                                                                                                                                   // FhirConstructGeneration.cs:323
                                                                                                                                            // FhirConstructGeneration.cs:325
            block                                                                                                                           // FhirConstructGeneration.cs:326
                .AppendCode($"{methodAccess} Quantity {methodName}()")                                                                      // FhirConstructGeneration.cs:327
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:328
                .AppendCode("Quantity retVal = new Quantity();")                                                                            // FhirConstructGeneration.cs:329
                ;                                                                                                                           // FhirConstructGeneration.cs:330
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:331
            {                                                                                                                               // FhirConstructGeneration.cs:332
                if (fix.ValueElement != null)                                                                                               // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.ValueElement = new FhirDecimal();");                                                      // FhirConstructGeneration.cs:209
                    if (fix.ValueElement.Value.HasValue == true)                                                                            // FhirConstructGeneration.cs:123
                        block.AppendCode($"retVal.ValueElement.Value = new Nullable<decimal>((decimal) {fix.ValueElement.Value.Value});");  // FhirConstructGeneration.cs:124
                    if (fix.ValueElement.ElementId != null)                                                                                 // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.ValueElement.ElementId = \"{fix.ValueElement.ElementId}\";");                             // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.ComparatorElement != null)                                                                                          // FhirConstructGeneration.cs:147
                    block.AppendCode($"retVal.ComparatorElement = new Code<Quantity.QuantityComparator>(Quantity.QuantityComparator.{fix.ComparatorElement.Value});");// FhirConstructGeneration.cs:148
                if (fix.UnitElement != null)                                                                                                // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.UnitElement = new FhirString();");                                                        // FhirConstructGeneration.cs:209
                    if (fix.UnitElement.Value != null)                                                                                      // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.UnitElement.Value = \"{fix.UnitElement.Value}\";");                                       // FhirConstructGeneration.cs:138
                    if (fix.UnitElement.ElementId != null)                                                                                  // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.UnitElement.ElementId = \"{fix.UnitElement.ElementId}\";");                               // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.SystemElement != null)                                                                                              // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.SystemElement = new FhirUri();");                                                         // FhirConstructGeneration.cs:209
                    if (fix.SystemElement.Value != null)                                                                                    // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.SystemElement.Value = \"{fix.SystemElement.Value}\";");                                   // FhirConstructGeneration.cs:138
                    if (fix.SystemElement.ElementId != null)                                                                                // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.SystemElement.ElementId = \"{fix.SystemElement.ElementId}\";");                           // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.CodeElement != null)                                                                                                // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.CodeElement = new Code();");                                                              // FhirConstructGeneration.cs:209
                    if (fix.CodeElement.Value != null)                                                                                      // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.CodeElement.Value = \"{fix.CodeElement.Value}\";");                                       // FhirConstructGeneration.cs:138
                    if (fix.CodeElement.ElementId != null)                                                                                  // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.CodeElement.ElementId = \"{fix.CodeElement.ElementId}\";");                               // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:338
            block                                                                                                                           // FhirConstructGeneration.cs:339
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:340
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:341
                ;                                                                                                                           // FhirConstructGeneration.cs:342
            return  true;                                                                                                                   // FhirConstructGeneration.cs:343
        }                                                                                                                                   // FhirConstructGeneration.cs:344
                                                                                                                                            // FhirConstructGeneration.cs:315
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:319
            Range fix,                                                                                                                      // FhirConstructGeneration.cs:320
            String methodName,                                                                                                              // FhirConstructGeneration.cs:321
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:322
        {                                                                                                                                   // FhirConstructGeneration.cs:323
                                                                                                                                            // FhirConstructGeneration.cs:325
            block                                                                                                                           // FhirConstructGeneration.cs:326
                .AppendCode($"{methodAccess} Range {methodName}()")                                                                         // FhirConstructGeneration.cs:327
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:328
                .AppendCode("Range retVal = new Range();")                                                                                  // FhirConstructGeneration.cs:329
                ;                                                                                                                           // FhirConstructGeneration.cs:330
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:331
            {                                                                                                                               // FhirConstructGeneration.cs:332
                if (fix.Low != null)                                                                                                        // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.Low = new Quantity();");                                                                  // FhirConstructGeneration.cs:209
                    if (fix.Low.ValueElement != null)                                                                                       // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Low.ValueElement = new FhirDecimal();");                                              // FhirConstructGeneration.cs:209
                        if (fix.Low.ValueElement.Value.HasValue == true)                                                                    // FhirConstructGeneration.cs:123
                            block.AppendCode($"retVal.Low.ValueElement.Value = new Nullable<decimal>((decimal) {fix.Low.ValueElement.Value.Value});");// FhirConstructGeneration.cs:124
                        if (fix.Low.ValueElement.ElementId != null)                                                                         // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Low.ValueElement.ElementId = \"{fix.Low.ValueElement.ElementId}\";");                 // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Low.ComparatorElement != null)                                                                                  // FhirConstructGeneration.cs:147
                        block.AppendCode($"retVal.Low.ComparatorElement = new Code<Quantity.QuantityComparator>(Quantity.QuantityComparator.{fix.Low.ComparatorElement.Value});");// FhirConstructGeneration.cs:148
                    if (fix.Low.UnitElement != null)                                                                                        // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Low.UnitElement = new FhirString();");                                                // FhirConstructGeneration.cs:209
                        if (fix.Low.UnitElement.Value != null)                                                                              // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Low.UnitElement.Value = \"{fix.Low.UnitElement.Value}\";");                           // FhirConstructGeneration.cs:138
                        if (fix.Low.UnitElement.ElementId != null)                                                                          // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Low.UnitElement.ElementId = \"{fix.Low.UnitElement.ElementId}\";");                   // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Low.SystemElement != null)                                                                                      // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Low.SystemElement = new FhirUri();");                                                 // FhirConstructGeneration.cs:209
                        if (fix.Low.SystemElement.Value != null)                                                                            // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Low.SystemElement.Value = \"{fix.Low.SystemElement.Value}\";");                       // FhirConstructGeneration.cs:138
                        if (fix.Low.SystemElement.ElementId != null)                                                                        // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Low.SystemElement.ElementId = \"{fix.Low.SystemElement.ElementId}\";");               // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Low.CodeElement != null)                                                                                        // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Low.CodeElement = new Code();");                                                      // FhirConstructGeneration.cs:209
                        if (fix.Low.CodeElement.Value != null)                                                                              // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Low.CodeElement.Value = \"{fix.Low.CodeElement.Value}\";");                           // FhirConstructGeneration.cs:138
                        if (fix.Low.CodeElement.ElementId != null)                                                                          // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Low.CodeElement.ElementId = \"{fix.Low.CodeElement.ElementId}\";");                   // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Low.ElementId != null)                                                                                          // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.Low.ElementId = \"{fix.Low.ElementId}\";");                                               // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.High != null)                                                                                                       // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.High = new Quantity();");                                                                 // FhirConstructGeneration.cs:209
                    if (fix.High.ValueElement != null)                                                                                      // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.High.ValueElement = new FhirDecimal();");                                             // FhirConstructGeneration.cs:209
                        if (fix.High.ValueElement.Value.HasValue == true)                                                                   // FhirConstructGeneration.cs:123
                            block.AppendCode($"retVal.High.ValueElement.Value = new Nullable<decimal>((decimal) {fix.High.ValueElement.Value.Value});");// FhirConstructGeneration.cs:124
                        if (fix.High.ValueElement.ElementId != null)                                                                        // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.High.ValueElement.ElementId = \"{fix.High.ValueElement.ElementId}\";");               // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.High.ComparatorElement != null)                                                                                 // FhirConstructGeneration.cs:147
                        block.AppendCode($"retVal.High.ComparatorElement = new Code<Quantity.QuantityComparator>(Quantity.QuantityComparator.{fix.High.ComparatorElement.Value});");// FhirConstructGeneration.cs:148
                    if (fix.High.UnitElement != null)                                                                                       // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.High.UnitElement = new FhirString();");                                               // FhirConstructGeneration.cs:209
                        if (fix.High.UnitElement.Value != null)                                                                             // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.High.UnitElement.Value = \"{fix.High.UnitElement.Value}\";");                         // FhirConstructGeneration.cs:138
                        if (fix.High.UnitElement.ElementId != null)                                                                         // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.High.UnitElement.ElementId = \"{fix.High.UnitElement.ElementId}\";");                 // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.High.SystemElement != null)                                                                                     // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.High.SystemElement = new FhirUri();");                                                // FhirConstructGeneration.cs:209
                        if (fix.High.SystemElement.Value != null)                                                                           // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.High.SystemElement.Value = \"{fix.High.SystemElement.Value}\";");                     // FhirConstructGeneration.cs:138
                        if (fix.High.SystemElement.ElementId != null)                                                                       // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.High.SystemElement.ElementId = \"{fix.High.SystemElement.ElementId}\";");             // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.High.CodeElement != null)                                                                                       // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.High.CodeElement = new Code();");                                                     // FhirConstructGeneration.cs:209
                        if (fix.High.CodeElement.Value != null)                                                                             // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.High.CodeElement.Value = \"{fix.High.CodeElement.Value}\";");                         // FhirConstructGeneration.cs:138
                        if (fix.High.CodeElement.ElementId != null)                                                                         // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.High.CodeElement.ElementId = \"{fix.High.CodeElement.ElementId}\";");                 // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.High.ElementId != null)                                                                                         // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.High.ElementId = \"{fix.High.ElementId}\";");                                             // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:338
            block                                                                                                                           // FhirConstructGeneration.cs:339
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:340
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:341
                ;                                                                                                                           // FhirConstructGeneration.cs:342
            return  true;                                                                                                                   // FhirConstructGeneration.cs:343
        }                                                                                                                                   // FhirConstructGeneration.cs:344
                                                                                                                                            // FhirConstructGeneration.cs:315
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:319
            Ratio fix,                                                                                                                      // FhirConstructGeneration.cs:320
            String methodName,                                                                                                              // FhirConstructGeneration.cs:321
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:322
        {                                                                                                                                   // FhirConstructGeneration.cs:323
                                                                                                                                            // FhirConstructGeneration.cs:325
            block                                                                                                                           // FhirConstructGeneration.cs:326
                .AppendCode($"{methodAccess} Ratio {methodName}()")                                                                         // FhirConstructGeneration.cs:327
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:328
                .AppendCode("Ratio retVal = new Ratio();")                                                                                  // FhirConstructGeneration.cs:329
                ;                                                                                                                           // FhirConstructGeneration.cs:330
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:331
            {                                                                                                                               // FhirConstructGeneration.cs:332
                if (fix.Numerator != null)                                                                                                  // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.Numerator = new Quantity();");                                                            // FhirConstructGeneration.cs:209
                    if (fix.Numerator.ValueElement != null)                                                                                 // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Numerator.ValueElement = new FhirDecimal();");                                        // FhirConstructGeneration.cs:209
                        if (fix.Numerator.ValueElement.Value.HasValue == true)                                                              // FhirConstructGeneration.cs:123
                            block.AppendCode($"retVal.Numerator.ValueElement.Value = new Nullable<decimal>((decimal) {fix.Numerator.ValueElement.Value.Value});");// FhirConstructGeneration.cs:124
                        if (fix.Numerator.ValueElement.ElementId != null)                                                                   // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Numerator.ValueElement.ElementId = \"{fix.Numerator.ValueElement.ElementId}\";");     // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Numerator.ComparatorElement != null)                                                                            // FhirConstructGeneration.cs:147
                        block.AppendCode($"retVal.Numerator.ComparatorElement = new Code<Quantity.QuantityComparator>(Quantity.QuantityComparator.{fix.Numerator.ComparatorElement.Value});");// FhirConstructGeneration.cs:148
                    if (fix.Numerator.UnitElement != null)                                                                                  // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Numerator.UnitElement = new FhirString();");                                          // FhirConstructGeneration.cs:209
                        if (fix.Numerator.UnitElement.Value != null)                                                                        // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Numerator.UnitElement.Value = \"{fix.Numerator.UnitElement.Value}\";");               // FhirConstructGeneration.cs:138
                        if (fix.Numerator.UnitElement.ElementId != null)                                                                    // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Numerator.UnitElement.ElementId = \"{fix.Numerator.UnitElement.ElementId}\";");       // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Numerator.SystemElement != null)                                                                                // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Numerator.SystemElement = new FhirUri();");                                           // FhirConstructGeneration.cs:209
                        if (fix.Numerator.SystemElement.Value != null)                                                                      // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Numerator.SystemElement.Value = \"{fix.Numerator.SystemElement.Value}\";");           // FhirConstructGeneration.cs:138
                        if (fix.Numerator.SystemElement.ElementId != null)                                                                  // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Numerator.SystemElement.ElementId = \"{fix.Numerator.SystemElement.ElementId}\";");   // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Numerator.CodeElement != null)                                                                                  // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Numerator.CodeElement = new Code();");                                                // FhirConstructGeneration.cs:209
                        if (fix.Numerator.CodeElement.Value != null)                                                                        // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Numerator.CodeElement.Value = \"{fix.Numerator.CodeElement.Value}\";");               // FhirConstructGeneration.cs:138
                        if (fix.Numerator.CodeElement.ElementId != null)                                                                    // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Numerator.CodeElement.ElementId = \"{fix.Numerator.CodeElement.ElementId}\";");       // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Numerator.ElementId != null)                                                                                    // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.Numerator.ElementId = \"{fix.Numerator.ElementId}\";");                                   // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.Denominator != null)                                                                                                // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.Denominator = new Quantity();");                                                          // FhirConstructGeneration.cs:209
                    if (fix.Denominator.ValueElement != null)                                                                               // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Denominator.ValueElement = new FhirDecimal();");                                      // FhirConstructGeneration.cs:209
                        if (fix.Denominator.ValueElement.Value.HasValue == true)                                                            // FhirConstructGeneration.cs:123
                            block.AppendCode($"retVal.Denominator.ValueElement.Value = new Nullable<decimal>((decimal) {fix.Denominator.ValueElement.Value.Value});");// FhirConstructGeneration.cs:124
                        if (fix.Denominator.ValueElement.ElementId != null)                                                                 // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Denominator.ValueElement.ElementId = \"{fix.Denominator.ValueElement.ElementId}\";"); // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Denominator.ComparatorElement != null)                                                                          // FhirConstructGeneration.cs:147
                        block.AppendCode($"retVal.Denominator.ComparatorElement = new Code<Quantity.QuantityComparator>(Quantity.QuantityComparator.{fix.Denominator.ComparatorElement.Value});");// FhirConstructGeneration.cs:148
                    if (fix.Denominator.UnitElement != null)                                                                                // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Denominator.UnitElement = new FhirString();");                                        // FhirConstructGeneration.cs:209
                        if (fix.Denominator.UnitElement.Value != null)                                                                      // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Denominator.UnitElement.Value = \"{fix.Denominator.UnitElement.Value}\";");           // FhirConstructGeneration.cs:138
                        if (fix.Denominator.UnitElement.ElementId != null)                                                                  // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Denominator.UnitElement.ElementId = \"{fix.Denominator.UnitElement.ElementId}\";");   // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Denominator.SystemElement != null)                                                                              // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Denominator.SystemElement = new FhirUri();");                                         // FhirConstructGeneration.cs:209
                        if (fix.Denominator.SystemElement.Value != null)                                                                    // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Denominator.SystemElement.Value = \"{fix.Denominator.SystemElement.Value}\";");       // FhirConstructGeneration.cs:138
                        if (fix.Denominator.SystemElement.ElementId != null)                                                                // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Denominator.SystemElement.ElementId = \"{fix.Denominator.SystemElement.ElementId}\";");// FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Denominator.CodeElement != null)                                                                                // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Denominator.CodeElement = new Code();");                                              // FhirConstructGeneration.cs:209
                        if (fix.Denominator.CodeElement.Value != null)                                                                      // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Denominator.CodeElement.Value = \"{fix.Denominator.CodeElement.Value}\";");           // FhirConstructGeneration.cs:138
                        if (fix.Denominator.CodeElement.ElementId != null)                                                                  // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Denominator.CodeElement.ElementId = \"{fix.Denominator.CodeElement.ElementId}\";");   // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Denominator.ElementId != null)                                                                                  // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.Denominator.ElementId = \"{fix.Denominator.ElementId}\";");                               // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:338
            block                                                                                                                           // FhirConstructGeneration.cs:339
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:340
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:341
                ;                                                                                                                           // FhirConstructGeneration.cs:342
            return  true;                                                                                                                   // FhirConstructGeneration.cs:343
        }                                                                                                                                   // FhirConstructGeneration.cs:344
                                                                                                                                            // FhirConstructGeneration.cs:315
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:319
            ResourceReference fix,                                                                                                          // FhirConstructGeneration.cs:320
            String methodName,                                                                                                              // FhirConstructGeneration.cs:321
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:322
        {                                                                                                                                   // FhirConstructGeneration.cs:323
                                                                                                                                            // FhirConstructGeneration.cs:325
            block                                                                                                                           // FhirConstructGeneration.cs:326
                .AppendCode($"{methodAccess} ResourceReference {methodName}()")                                                             // FhirConstructGeneration.cs:327
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:328
                .AppendCode("ResourceReference retVal = new ResourceReference();")                                                          // FhirConstructGeneration.cs:329
                ;                                                                                                                           // FhirConstructGeneration.cs:330
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:331
            {                                                                                                                               // FhirConstructGeneration.cs:332
                if (fix.ReferenceElement != null)                                                                                           // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.ReferenceElement = new FhirString();");                                                   // FhirConstructGeneration.cs:209
                    if (fix.ReferenceElement.Value != null)                                                                                 // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.ReferenceElement.Value = \"{fix.ReferenceElement.Value}\";");                             // FhirConstructGeneration.cs:138
                    if (fix.ReferenceElement.ElementId != null)                                                                             // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.ReferenceElement.ElementId = \"{fix.ReferenceElement.ElementId}\";");                     // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.Identifier != null)                                                                                                 // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.Identifier = new Identifier();");                                                         // FhirConstructGeneration.cs:209
                    if (fix.Identifier.UseElement != null)                                                                                  // FhirConstructGeneration.cs:147
                        block.AppendCode($"retVal.Identifier.UseElement = new Code<Identifier.IdentifierUse>(Identifier.IdentifierUse.{fix.Identifier.UseElement.Value});");// FhirConstructGeneration.cs:148
                    if (fix.Identifier.Type != null)                                                                                        // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Identifier.Type = new CodeableConcept();");                                           // FhirConstructGeneration.cs:209
                        if (fix.Identifier.Type.Coding != null)                                                                             // FhirConstructGeneration.cs:159
                        {                                                                                                                   // FhirConstructGeneration.cs:160
                            block.AppendCode($"retVal.Identifier.Type.Coding = new List<Coding>();");                                       // FhirConstructGeneration.cs:161
                            foreach (var temp81 in fix.Identifier.Type.Coding)                                                              // FhirConstructGeneration.cs:162
                            {                                                                                                               // FhirConstructGeneration.cs:163
                                block.OpenBrace();                                                                                          // FhirConstructGeneration.cs:164
                                block.AppendCode("var temp82 = new Coding();");                                                             // FhirConstructGeneration.cs:165
                                if (temp81.SystemElement != null)                                                                           // FhirConstructGeneration.cs:207
                                {                                                                                                           // FhirConstructGeneration.cs:208
                                        block.AppendCode($"temp82.SystemElement = new FhirUri();");                                         // FhirConstructGeneration.cs:209
                                    if (temp81.SystemElement.Value != null)                                                                 // FhirConstructGeneration.cs:137
                                        block.AppendCode($"temp82.SystemElement.Value = \"{temp81.SystemElement.Value}\";");                // FhirConstructGeneration.cs:138
                                    if (temp81.SystemElement.ElementId != null)                                                             // FhirConstructGeneration.cs:137
                                        block.AppendCode($"temp82.SystemElement.ElementId = \"{temp81.SystemElement.ElementId}\";");        // FhirConstructGeneration.cs:138
                                }                                                                                                           // FhirConstructGeneration.cs:213
                                if (temp81.VersionElement != null)                                                                          // FhirConstructGeneration.cs:207
                                {                                                                                                           // FhirConstructGeneration.cs:208
                                        block.AppendCode($"temp82.VersionElement = new FhirString();");                                     // FhirConstructGeneration.cs:209
                                    if (temp81.VersionElement.Value != null)                                                                // FhirConstructGeneration.cs:137
                                        block.AppendCode($"temp82.VersionElement.Value = \"{temp81.VersionElement.Value}\";");              // FhirConstructGeneration.cs:138
                                    if (temp81.VersionElement.ElementId != null)                                                            // FhirConstructGeneration.cs:137
                                        block.AppendCode($"temp82.VersionElement.ElementId = \"{temp81.VersionElement.ElementId}\";");      // FhirConstructGeneration.cs:138
                                }                                                                                                           // FhirConstructGeneration.cs:213
                                if (temp81.CodeElement != null)                                                                             // FhirConstructGeneration.cs:207
                                {                                                                                                           // FhirConstructGeneration.cs:208
                                        block.AppendCode($"temp82.CodeElement = new Code();");                                              // FhirConstructGeneration.cs:209
                                    if (temp81.CodeElement.Value != null)                                                                   // FhirConstructGeneration.cs:137
                                        block.AppendCode($"temp82.CodeElement.Value = \"{temp81.CodeElement.Value}\";");                    // FhirConstructGeneration.cs:138
                                    if (temp81.CodeElement.ElementId != null)                                                               // FhirConstructGeneration.cs:137
                                        block.AppendCode($"temp82.CodeElement.ElementId = \"{temp81.CodeElement.ElementId}\";");            // FhirConstructGeneration.cs:138
                                }                                                                                                           // FhirConstructGeneration.cs:213
                                if (temp81.DisplayElement != null)                                                                          // FhirConstructGeneration.cs:207
                                {                                                                                                           // FhirConstructGeneration.cs:208
                                        block.AppendCode($"temp82.DisplayElement = new FhirString();");                                     // FhirConstructGeneration.cs:209
                                    if (temp81.DisplayElement.Value != null)                                                                // FhirConstructGeneration.cs:137
                                        block.AppendCode($"temp82.DisplayElement.Value = \"{temp81.DisplayElement.Value}\";");              // FhirConstructGeneration.cs:138
                                    if (temp81.DisplayElement.ElementId != null)                                                            // FhirConstructGeneration.cs:137
                                        block.AppendCode($"temp82.DisplayElement.ElementId = \"{temp81.DisplayElement.ElementId}\";");      // FhirConstructGeneration.cs:138
                                }                                                                                                           // FhirConstructGeneration.cs:213
                                if (temp81.UserSelectedElement != null)                                                                     // FhirConstructGeneration.cs:207
                                {                                                                                                           // FhirConstructGeneration.cs:208
                                        block.AppendCode($"temp82.UserSelectedElement = new FhirBoolean();");                               // FhirConstructGeneration.cs:209
                                    if (temp81.UserSelectedElement.Value.HasValue == true)                                                  // FhirConstructGeneration.cs:69
                                    {                                                                                                       // FhirConstructGeneration.cs:70
                                        if (temp81.UserSelectedElement.Value.Value == true)                                                 // FhirConstructGeneration.cs:71
                                            block.AppendCode($"temp82.UserSelectedElement.Value = true;");                                  // FhirConstructGeneration.cs:72
                                        else                                                                                                // FhirConstructGeneration.cs:73
                                            block.AppendCode($"temp82.UserSelectedElement.Value = false;");                                 // FhirConstructGeneration.cs:74
                                    }                                                                                                       // FhirConstructGeneration.cs:75
                                    if (temp81.UserSelectedElement.ElementId != null)                                                       // FhirConstructGeneration.cs:137
                                        block.AppendCode($"temp82.UserSelectedElement.ElementId = \"{temp81.UserSelectedElement.ElementId}\";");// FhirConstructGeneration.cs:138
                                }                                                                                                           // FhirConstructGeneration.cs:213
                                if (temp81.ElementId != null)                                                                               // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp82.ElementId = \"{temp81.ElementId}\";");                                        // FhirConstructGeneration.cs:138
                                block.AppendCode($"retVal.Identifier.Type.Coding.Add(temp82);");                                            // FhirConstructGeneration.cs:171
                                block.CloseBrace();                                                                                         // FhirConstructGeneration.cs:172
                            }                                                                                                               // FhirConstructGeneration.cs:173
                        }                                                                                                                   // FhirConstructGeneration.cs:174
                        if (fix.Identifier.Type.TextElement != null)                                                                        // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"retVal.Identifier.Type.TextElement = new FhirString();");                                // FhirConstructGeneration.cs:209
                            if (fix.Identifier.Type.TextElement.Value != null)                                                              // FhirConstructGeneration.cs:137
                                block.AppendCode($"retVal.Identifier.Type.TextElement.Value = \"{fix.Identifier.Type.TextElement.Value}\";");// FhirConstructGeneration.cs:138
                            if (fix.Identifier.Type.TextElement.ElementId != null)                                                          // FhirConstructGeneration.cs:137
                                block.AppendCode($"retVal.Identifier.Type.TextElement.ElementId = \"{fix.Identifier.Type.TextElement.ElementId}\";");// FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (fix.Identifier.Type.ElementId != null)                                                                          // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Identifier.Type.ElementId = \"{fix.Identifier.Type.ElementId}\";");                   // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Identifier.SystemElement != null)                                                                               // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Identifier.SystemElement = new FhirUri();");                                          // FhirConstructGeneration.cs:209
                        if (fix.Identifier.SystemElement.Value != null)                                                                     // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Identifier.SystemElement.Value = \"{fix.Identifier.SystemElement.Value}\";");         // FhirConstructGeneration.cs:138
                        if (fix.Identifier.SystemElement.ElementId != null)                                                                 // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Identifier.SystemElement.ElementId = \"{fix.Identifier.SystemElement.ElementId}\";"); // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Identifier.ValueElement != null)                                                                                // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Identifier.ValueElement = new FhirString();");                                        // FhirConstructGeneration.cs:209
                        if (fix.Identifier.ValueElement.Value != null)                                                                      // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Identifier.ValueElement.Value = \"{fix.Identifier.ValueElement.Value}\";");           // FhirConstructGeneration.cs:138
                        if (fix.Identifier.ValueElement.ElementId != null)                                                                  // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Identifier.ValueElement.ElementId = \"{fix.Identifier.ValueElement.ElementId}\";");   // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Identifier.Period != null)                                                                                      // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Identifier.Period = new Period();");                                                  // FhirConstructGeneration.cs:209
                        if (fix.Identifier.Period.StartElement != null)                                                                     // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"retVal.Identifier.Period.StartElement = new FhirDateTime();");                           // FhirConstructGeneration.cs:209
                            if (fix.Identifier.Period.StartElement.Value != null)                                                           // FhirConstructGeneration.cs:137
                                block.AppendCode($"retVal.Identifier.Period.StartElement.Value = \"{fix.Identifier.Period.StartElement.Value}\";");// FhirConstructGeneration.cs:138
                            if (fix.Identifier.Period.StartElement.ElementId != null)                                                       // FhirConstructGeneration.cs:137
                                block.AppendCode($"retVal.Identifier.Period.StartElement.ElementId = \"{fix.Identifier.Period.StartElement.ElementId}\";");// FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (fix.Identifier.Period.EndElement != null)                                                                       // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"retVal.Identifier.Period.EndElement = new FhirDateTime();");                             // FhirConstructGeneration.cs:209
                            if (fix.Identifier.Period.EndElement.Value != null)                                                             // FhirConstructGeneration.cs:137
                                block.AppendCode($"retVal.Identifier.Period.EndElement.Value = \"{fix.Identifier.Period.EndElement.Value}\";");// FhirConstructGeneration.cs:138
                            if (fix.Identifier.Period.EndElement.ElementId != null)                                                         // FhirConstructGeneration.cs:137
                                block.AppendCode($"retVal.Identifier.Period.EndElement.ElementId = \"{fix.Identifier.Period.EndElement.ElementId}\";");// FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (fix.Identifier.Period.ElementId != null)                                                                        // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Identifier.Period.ElementId = \"{fix.Identifier.Period.ElementId}\";");               // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Identifier.ElementId != null)                                                                                   // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.Identifier.ElementId = \"{fix.Identifier.ElementId}\";");                                 // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.DisplayElement != null)                                                                                             // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.DisplayElement = new FhirString();");                                                     // FhirConstructGeneration.cs:209
                    if (fix.DisplayElement.Value != null)                                                                                   // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.DisplayElement.Value = \"{fix.DisplayElement.Value}\";");                                 // FhirConstructGeneration.cs:138
                    if (fix.DisplayElement.ElementId != null)                                                                               // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.DisplayElement.ElementId = \"{fix.DisplayElement.ElementId}\";");                         // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:338
            block                                                                                                                           // FhirConstructGeneration.cs:339
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:340
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:341
                ;                                                                                                                           // FhirConstructGeneration.cs:342
            return  true;                                                                                                                   // FhirConstructGeneration.cs:343
        }                                                                                                                                   // FhirConstructGeneration.cs:344
                                                                                                                                            // FhirConstructGeneration.cs:315
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:319
            RelatedArtifact fix,                                                                                                            // FhirConstructGeneration.cs:320
            String methodName,                                                                                                              // FhirConstructGeneration.cs:321
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:322
        {                                                                                                                                   // FhirConstructGeneration.cs:323
                                                                                                                                            // FhirConstructGeneration.cs:325
            block                                                                                                                           // FhirConstructGeneration.cs:326
                .AppendCode($"{methodAccess} RelatedArtifact {methodName}()")                                                               // FhirConstructGeneration.cs:327
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:328
                .AppendCode("RelatedArtifact retVal = new RelatedArtifact();")                                                              // FhirConstructGeneration.cs:329
                ;                                                                                                                           // FhirConstructGeneration.cs:330
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:331
            {                                                                                                                               // FhirConstructGeneration.cs:332
                if (fix.TypeElement != null)                                                                                                // FhirConstructGeneration.cs:147
                    block.AppendCode($"retVal.TypeElement = new Code<RelatedArtifact.RelatedArtifactType>(RelatedArtifact.RelatedArtifactType.{fix.TypeElement.Value});");// FhirConstructGeneration.cs:148
                if (fix.DisplayElement != null)                                                                                             // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.DisplayElement = new FhirString();");                                                     // FhirConstructGeneration.cs:209
                    if (fix.DisplayElement.Value != null)                                                                                   // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.DisplayElement.Value = \"{fix.DisplayElement.Value}\";");                                 // FhirConstructGeneration.cs:138
                    if (fix.DisplayElement.ElementId != null)                                                                               // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.DisplayElement.ElementId = \"{fix.DisplayElement.ElementId}\";");                         // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.CitationElement != null)                                                                                            // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.CitationElement = new FhirString();");                                                    // FhirConstructGeneration.cs:209
                    if (fix.CitationElement.Value != null)                                                                                  // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.CitationElement.Value = \"{fix.CitationElement.Value}\";");                               // FhirConstructGeneration.cs:138
                    if (fix.CitationElement.ElementId != null)                                                                              // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.CitationElement.ElementId = \"{fix.CitationElement.ElementId}\";");                       // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.UrlElement != null)                                                                                                 // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.UrlElement = new FhirUri();");                                                            // FhirConstructGeneration.cs:209
                    if (fix.UrlElement.Value != null)                                                                                       // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.UrlElement.Value = \"{fix.UrlElement.Value}\";");                                         // FhirConstructGeneration.cs:138
                    if (fix.UrlElement.ElementId != null)                                                                                   // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.UrlElement.ElementId = \"{fix.UrlElement.ElementId}\";");                                 // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.Document != null)                                                                                                   // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.Document = new Attachment();");                                                           // FhirConstructGeneration.cs:209
                    if (fix.Document.ContentTypeElement != null)                                                                            // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Document.ContentTypeElement = new Code();");                                          // FhirConstructGeneration.cs:209
                        if (fix.Document.ContentTypeElement.Value != null)                                                                  // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Document.ContentTypeElement.Value = \"{fix.Document.ContentTypeElement.Value}\";");   // FhirConstructGeneration.cs:138
                        if (fix.Document.ContentTypeElement.ElementId != null)                                                              // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Document.ContentTypeElement.ElementId = \"{fix.Document.ContentTypeElement.ElementId}\";");// FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Document.LanguageElement != null)                                                                               // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Document.LanguageElement = new Code();");                                             // FhirConstructGeneration.cs:209
                        if (fix.Document.LanguageElement.Value != null)                                                                     // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Document.LanguageElement.Value = \"{fix.Document.LanguageElement.Value}\";");         // FhirConstructGeneration.cs:138
                        if (fix.Document.LanguageElement.ElementId != null)                                                                 // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Document.LanguageElement.ElementId = \"{fix.Document.LanguageElement.ElementId}\";"); // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Document.DataElement != null)                                                                                   // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Document.DataElement = new Base64Binary();");                                         // FhirConstructGeneration.cs:209
                        if (fix.Document.DataElement.Value != null)                                                                         // FhirConstructGeneration.cs:81
                        {                                                                                                                   // FhirConstructGeneration.cs:82
                            block.OpenBrace();                                                                                              // FhirConstructGeneration.cs:83
                            block.AppendCode($"byte[] data = new byte[]");                                                                  // FhirConstructGeneration.cs:84
                            block.OpenBrace();                                                                                              // FhirConstructGeneration.cs:85
                            Int32 i = 0;                                                                                                    // FhirConstructGeneration.cs:86
                            while (i < fix.Document.DataElement.Value.Length)                                                               // FhirConstructGeneration.cs:87
                            {                                                                                                               // FhirConstructGeneration.cs:88
                                Int32 j = 0;                                                                                                // FhirConstructGeneration.cs:89
                                StringBuilder sb = new StringBuilder();                                                                     // FhirConstructGeneration.cs:90
                                while ((i < fix.Document.DataElement.Value.Length) && (j < 32))                                             // FhirConstructGeneration.cs:91
                                {                                                                                                           // FhirConstructGeneration.cs:92
                                    sb.Append($"{fix.Document.DataElement.Value[i]}");                                                      // FhirConstructGeneration.cs:93
                                    if (i < fix.Document.DataElement.Value.Length - 1) sb.Append(",");                                      // FhirConstructGeneration.cs:94
                                    j += 1;                                                                                                 // FhirConstructGeneration.cs:95
                                    i += 1;                                                                                                 // FhirConstructGeneration.cs:96
                                }                                                                                                           // FhirConstructGeneration.cs:97
                                block.AppendCode($"{sb.ToString()}");                                                                       // FhirConstructGeneration.cs:98
                            }                                                                                                               // FhirConstructGeneration.cs:99
                            block.CloseBrace(";");                                                                                          // FhirConstructGeneration.cs:100
                            block.AppendCode($"retVal.Document.DataElement.Value = data;");                                                 // FhirConstructGeneration.cs:101
                            block.CloseBrace(";");                                                                                          // FhirConstructGeneration.cs:102
                        }                                                                                                                   // FhirConstructGeneration.cs:103
                        if (fix.Document.DataElement.ElementId != null)                                                                     // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Document.DataElement.ElementId = \"{fix.Document.DataElement.ElementId}\";");         // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Document.UrlElement != null)                                                                                    // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Document.UrlElement = new FhirUri();");                                               // FhirConstructGeneration.cs:209
                        if (fix.Document.UrlElement.Value != null)                                                                          // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Document.UrlElement.Value = \"{fix.Document.UrlElement.Value}\";");                   // FhirConstructGeneration.cs:138
                        if (fix.Document.UrlElement.ElementId != null)                                                                      // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Document.UrlElement.ElementId = \"{fix.Document.UrlElement.ElementId}\";");           // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Document.SizeElement != null)                                                                                   // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Document.SizeElement = new UnsignedInt();");                                          // FhirConstructGeneration.cs:209
                        if (fix.Document.SizeElement.Value.HasValue == true)                                                                // FhirConstructGeneration.cs:130
                            block.AppendCode($"retVal.Document.SizeElement.Value = new Nullable<int>((int) {fix.Document.SizeElement.Value.Value});");// FhirConstructGeneration.cs:131
                        if (fix.Document.SizeElement.ElementId != null)                                                                     // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Document.SizeElement.ElementId = \"{fix.Document.SizeElement.ElementId}\";");         // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Document.HashElement != null)                                                                                   // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Document.HashElement = new Base64Binary();");                                         // FhirConstructGeneration.cs:209
                        if (fix.Document.HashElement.Value != null)                                                                         // FhirConstructGeneration.cs:81
                        {                                                                                                                   // FhirConstructGeneration.cs:82
                            block.OpenBrace();                                                                                              // FhirConstructGeneration.cs:83
                            block.AppendCode($"byte[] data = new byte[]");                                                                  // FhirConstructGeneration.cs:84
                            block.OpenBrace();                                                                                              // FhirConstructGeneration.cs:85
                            Int32 i = 0;                                                                                                    // FhirConstructGeneration.cs:86
                            while (i < fix.Document.HashElement.Value.Length)                                                               // FhirConstructGeneration.cs:87
                            {                                                                                                               // FhirConstructGeneration.cs:88
                                Int32 j = 0;                                                                                                // FhirConstructGeneration.cs:89
                                StringBuilder sb = new StringBuilder();                                                                     // FhirConstructGeneration.cs:90
                                while ((i < fix.Document.HashElement.Value.Length) && (j < 32))                                             // FhirConstructGeneration.cs:91
                                {                                                                                                           // FhirConstructGeneration.cs:92
                                    sb.Append($"{fix.Document.HashElement.Value[i]}");                                                      // FhirConstructGeneration.cs:93
                                    if (i < fix.Document.HashElement.Value.Length - 1) sb.Append(",");                                      // FhirConstructGeneration.cs:94
                                    j += 1;                                                                                                 // FhirConstructGeneration.cs:95
                                    i += 1;                                                                                                 // FhirConstructGeneration.cs:96
                                }                                                                                                           // FhirConstructGeneration.cs:97
                                block.AppendCode($"{sb.ToString()}");                                                                       // FhirConstructGeneration.cs:98
                            }                                                                                                               // FhirConstructGeneration.cs:99
                            block.CloseBrace(";");                                                                                          // FhirConstructGeneration.cs:100
                            block.AppendCode($"retVal.Document.HashElement.Value = data;");                                                 // FhirConstructGeneration.cs:101
                            block.CloseBrace(";");                                                                                          // FhirConstructGeneration.cs:102
                        }                                                                                                                   // FhirConstructGeneration.cs:103
                        if (fix.Document.HashElement.ElementId != null)                                                                     // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Document.HashElement.ElementId = \"{fix.Document.HashElement.ElementId}\";");         // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Document.TitleElement != null)                                                                                  // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Document.TitleElement = new FhirString();");                                          // FhirConstructGeneration.cs:209
                        if (fix.Document.TitleElement.Value != null)                                                                        // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Document.TitleElement.Value = \"{fix.Document.TitleElement.Value}\";");               // FhirConstructGeneration.cs:138
                        if (fix.Document.TitleElement.ElementId != null)                                                                    // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Document.TitleElement.ElementId = \"{fix.Document.TitleElement.ElementId}\";");       // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Document.CreationElement != null)                                                                               // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Document.CreationElement = new FhirDateTime();");                                     // FhirConstructGeneration.cs:209
                        if (fix.Document.CreationElement.Value != null)                                                                     // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Document.CreationElement.Value = \"{fix.Document.CreationElement.Value}\";");         // FhirConstructGeneration.cs:138
                        if (fix.Document.CreationElement.ElementId != null)                                                                 // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Document.CreationElement.ElementId = \"{fix.Document.CreationElement.ElementId}\";"); // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Document.ElementId != null)                                                                                     // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.Document.ElementId = \"{fix.Document.ElementId}\";");                                     // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:338
            block                                                                                                                           // FhirConstructGeneration.cs:339
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:340
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:341
                ;                                                                                                                           // FhirConstructGeneration.cs:342
            return  true;                                                                                                                   // FhirConstructGeneration.cs:343
        }                                                                                                                                   // FhirConstructGeneration.cs:344
                                                                                                                                            // FhirConstructGeneration.cs:315
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:319
            SampledData fix,                                                                                                                // FhirConstructGeneration.cs:320
            String methodName,                                                                                                              // FhirConstructGeneration.cs:321
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:322
        {                                                                                                                                   // FhirConstructGeneration.cs:323
                                                                                                                                            // FhirConstructGeneration.cs:325
            block                                                                                                                           // FhirConstructGeneration.cs:326
                .AppendCode($"{methodAccess} SampledData {methodName}()")                                                                   // FhirConstructGeneration.cs:327
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:328
                .AppendCode("SampledData retVal = new SampledData();")                                                                      // FhirConstructGeneration.cs:329
                ;                                                                                                                           // FhirConstructGeneration.cs:330
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:331
            {                                                                                                                               // FhirConstructGeneration.cs:332
                if (fix.Origin != null)                                                                                                     // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.Origin = new Quantity();");                                                               // FhirConstructGeneration.cs:209
                    if (fix.Origin.ValueElement != null)                                                                                    // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Origin.ValueElement = new FhirDecimal();");                                           // FhirConstructGeneration.cs:209
                        if (fix.Origin.ValueElement.Value.HasValue == true)                                                                 // FhirConstructGeneration.cs:123
                            block.AppendCode($"retVal.Origin.ValueElement.Value = new Nullable<decimal>((decimal) {fix.Origin.ValueElement.Value.Value});");// FhirConstructGeneration.cs:124
                        if (fix.Origin.ValueElement.ElementId != null)                                                                      // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Origin.ValueElement.ElementId = \"{fix.Origin.ValueElement.ElementId}\";");           // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Origin.ComparatorElement != null)                                                                               // FhirConstructGeneration.cs:147
                        block.AppendCode($"retVal.Origin.ComparatorElement = new Code<Quantity.QuantityComparator>(Quantity.QuantityComparator.{fix.Origin.ComparatorElement.Value});");// FhirConstructGeneration.cs:148
                    if (fix.Origin.UnitElement != null)                                                                                     // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Origin.UnitElement = new FhirString();");                                             // FhirConstructGeneration.cs:209
                        if (fix.Origin.UnitElement.Value != null)                                                                           // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Origin.UnitElement.Value = \"{fix.Origin.UnitElement.Value}\";");                     // FhirConstructGeneration.cs:138
                        if (fix.Origin.UnitElement.ElementId != null)                                                                       // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Origin.UnitElement.ElementId = \"{fix.Origin.UnitElement.ElementId}\";");             // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Origin.SystemElement != null)                                                                                   // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Origin.SystemElement = new FhirUri();");                                              // FhirConstructGeneration.cs:209
                        if (fix.Origin.SystemElement.Value != null)                                                                         // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Origin.SystemElement.Value = \"{fix.Origin.SystemElement.Value}\";");                 // FhirConstructGeneration.cs:138
                        if (fix.Origin.SystemElement.ElementId != null)                                                                     // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Origin.SystemElement.ElementId = \"{fix.Origin.SystemElement.ElementId}\";");         // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Origin.CodeElement != null)                                                                                     // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Origin.CodeElement = new Code();");                                                   // FhirConstructGeneration.cs:209
                        if (fix.Origin.CodeElement.Value != null)                                                                           // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Origin.CodeElement.Value = \"{fix.Origin.CodeElement.Value}\";");                     // FhirConstructGeneration.cs:138
                        if (fix.Origin.CodeElement.ElementId != null)                                                                       // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Origin.CodeElement.ElementId = \"{fix.Origin.CodeElement.ElementId}\";");             // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Origin.ElementId != null)                                                                                       // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.Origin.ElementId = \"{fix.Origin.ElementId}\";");                                         // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.PeriodElement != null)                                                                                              // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.PeriodElement = new FhirDecimal();");                                                     // FhirConstructGeneration.cs:209
                    if (fix.PeriodElement.Value.HasValue == true)                                                                           // FhirConstructGeneration.cs:123
                        block.AppendCode($"retVal.PeriodElement.Value = new Nullable<decimal>((decimal) {fix.PeriodElement.Value.Value});");// FhirConstructGeneration.cs:124
                    if (fix.PeriodElement.ElementId != null)                                                                                // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.PeriodElement.ElementId = \"{fix.PeriodElement.ElementId}\";");                           // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.FactorElement != null)                                                                                              // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.FactorElement = new FhirDecimal();");                                                     // FhirConstructGeneration.cs:209
                    if (fix.FactorElement.Value.HasValue == true)                                                                           // FhirConstructGeneration.cs:123
                        block.AppendCode($"retVal.FactorElement.Value = new Nullable<decimal>((decimal) {fix.FactorElement.Value.Value});");// FhirConstructGeneration.cs:124
                    if (fix.FactorElement.ElementId != null)                                                                                // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.FactorElement.ElementId = \"{fix.FactorElement.ElementId}\";");                           // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.LowerLimitElement != null)                                                                                          // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.LowerLimitElement = new FhirDecimal();");                                                 // FhirConstructGeneration.cs:209
                    if (fix.LowerLimitElement.Value.HasValue == true)                                                                       // FhirConstructGeneration.cs:123
                        block.AppendCode($"retVal.LowerLimitElement.Value = new Nullable<decimal>((decimal) {fix.LowerLimitElement.Value.Value});");// FhirConstructGeneration.cs:124
                    if (fix.LowerLimitElement.ElementId != null)                                                                            // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.LowerLimitElement.ElementId = \"{fix.LowerLimitElement.ElementId}\";");                   // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.UpperLimitElement != null)                                                                                          // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.UpperLimitElement = new FhirDecimal();");                                                 // FhirConstructGeneration.cs:209
                    if (fix.UpperLimitElement.Value.HasValue == true)                                                                       // FhirConstructGeneration.cs:123
                        block.AppendCode($"retVal.UpperLimitElement.Value = new Nullable<decimal>((decimal) {fix.UpperLimitElement.Value.Value});");// FhirConstructGeneration.cs:124
                    if (fix.UpperLimitElement.ElementId != null)                                                                            // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.UpperLimitElement.ElementId = \"{fix.UpperLimitElement.ElementId}\";");                   // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.DimensionsElement != null)                                                                                          // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.DimensionsElement = new PositiveInt();");                                                 // FhirConstructGeneration.cs:209
                    if (fix.DimensionsElement.Value.HasValue == true)                                                                       // FhirConstructGeneration.cs:130
                        block.AppendCode($"retVal.DimensionsElement.Value = new Nullable<int>((int) {fix.DimensionsElement.Value.Value});");// FhirConstructGeneration.cs:131
                    if (fix.DimensionsElement.ElementId != null)                                                                            // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.DimensionsElement.ElementId = \"{fix.DimensionsElement.ElementId}\";");                   // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.DataElement != null)                                                                                                // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.DataElement = new FhirString();");                                                        // FhirConstructGeneration.cs:209
                    if (fix.DataElement.Value != null)                                                                                      // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.DataElement.Value = \"{fix.DataElement.Value}\";");                                       // FhirConstructGeneration.cs:138
                    if (fix.DataElement.ElementId != null)                                                                                  // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.DataElement.ElementId = \"{fix.DataElement.ElementId}\";");                               // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:338
            block                                                                                                                           // FhirConstructGeneration.cs:339
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:340
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:341
                ;                                                                                                                           // FhirConstructGeneration.cs:342
            return  true;                                                                                                                   // FhirConstructGeneration.cs:343
        }                                                                                                                                   // FhirConstructGeneration.cs:344
                                                                                                                                            // FhirConstructGeneration.cs:315
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:319
            Signature fix,                                                                                                                  // FhirConstructGeneration.cs:320
            String methodName,                                                                                                              // FhirConstructGeneration.cs:321
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:322
        {                                                                                                                                   // FhirConstructGeneration.cs:323
                                                                                                                                            // FhirConstructGeneration.cs:325
            block                                                                                                                           // FhirConstructGeneration.cs:326
                .AppendCode($"{methodAccess} Signature {methodName}()")                                                                     // FhirConstructGeneration.cs:327
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:328
                .AppendCode("Signature retVal = new Signature();")                                                                          // FhirConstructGeneration.cs:329
                ;                                                                                                                           // FhirConstructGeneration.cs:330
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:331
            {                                                                                                                               // FhirConstructGeneration.cs:332
                if (fix.Type != null)                                                                                                       // FhirConstructGeneration.cs:159
                {                                                                                                                           // FhirConstructGeneration.cs:160
                    block.AppendCode($"retVal.Type = new List<Coding>();");                                                                 // FhirConstructGeneration.cs:161
                    foreach (var temp83 in fix.Type)                                                                                        // FhirConstructGeneration.cs:162
                    {                                                                                                                       // FhirConstructGeneration.cs:163
                        block.OpenBrace();                                                                                                  // FhirConstructGeneration.cs:164
                        block.AppendCode("var temp84 = new Coding();");                                                                     // FhirConstructGeneration.cs:165
                        if (temp83.SystemElement != null)                                                                                   // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"temp84.SystemElement = new FhirUri();");                                                 // FhirConstructGeneration.cs:209
                            if (temp83.SystemElement.Value != null)                                                                         // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp84.SystemElement.Value = \"{temp83.SystemElement.Value}\";");                        // FhirConstructGeneration.cs:138
                            if (temp83.SystemElement.ElementId != null)                                                                     // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp84.SystemElement.ElementId = \"{temp83.SystemElement.ElementId}\";");                // FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (temp83.VersionElement != null)                                                                                  // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"temp84.VersionElement = new FhirString();");                                             // FhirConstructGeneration.cs:209
                            if (temp83.VersionElement.Value != null)                                                                        // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp84.VersionElement.Value = \"{temp83.VersionElement.Value}\";");                      // FhirConstructGeneration.cs:138
                            if (temp83.VersionElement.ElementId != null)                                                                    // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp84.VersionElement.ElementId = \"{temp83.VersionElement.ElementId}\";");              // FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (temp83.CodeElement != null)                                                                                     // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"temp84.CodeElement = new Code();");                                                      // FhirConstructGeneration.cs:209
                            if (temp83.CodeElement.Value != null)                                                                           // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp84.CodeElement.Value = \"{temp83.CodeElement.Value}\";");                            // FhirConstructGeneration.cs:138
                            if (temp83.CodeElement.ElementId != null)                                                                       // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp84.CodeElement.ElementId = \"{temp83.CodeElement.ElementId}\";");                    // FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (temp83.DisplayElement != null)                                                                                  // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"temp84.DisplayElement = new FhirString();");                                             // FhirConstructGeneration.cs:209
                            if (temp83.DisplayElement.Value != null)                                                                        // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp84.DisplayElement.Value = \"{temp83.DisplayElement.Value}\";");                      // FhirConstructGeneration.cs:138
                            if (temp83.DisplayElement.ElementId != null)                                                                    // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp84.DisplayElement.ElementId = \"{temp83.DisplayElement.ElementId}\";");              // FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (temp83.UserSelectedElement != null)                                                                             // FhirConstructGeneration.cs:207
                        {                                                                                                                   // FhirConstructGeneration.cs:208
                                block.AppendCode($"temp84.UserSelectedElement = new FhirBoolean();");                                       // FhirConstructGeneration.cs:209
                            if (temp83.UserSelectedElement.Value.HasValue == true)                                                          // FhirConstructGeneration.cs:69
                            {                                                                                                               // FhirConstructGeneration.cs:70
                                if (temp83.UserSelectedElement.Value.Value == true)                                                         // FhirConstructGeneration.cs:71
                                    block.AppendCode($"temp84.UserSelectedElement.Value = true;");                                          // FhirConstructGeneration.cs:72
                                else                                                                                                        // FhirConstructGeneration.cs:73
                                    block.AppendCode($"temp84.UserSelectedElement.Value = false;");                                         // FhirConstructGeneration.cs:74
                            }                                                                                                               // FhirConstructGeneration.cs:75
                            if (temp83.UserSelectedElement.ElementId != null)                                                               // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp84.UserSelectedElement.ElementId = \"{temp83.UserSelectedElement.ElementId}\";");    // FhirConstructGeneration.cs:138
                        }                                                                                                                   // FhirConstructGeneration.cs:213
                        if (temp83.ElementId != null)                                                                                       // FhirConstructGeneration.cs:137
                            block.AppendCode($"temp84.ElementId = \"{temp83.ElementId}\";");                                                // FhirConstructGeneration.cs:138
                        block.AppendCode($"retVal.Type.Add(temp84);");                                                                      // FhirConstructGeneration.cs:171
                        block.CloseBrace();                                                                                                 // FhirConstructGeneration.cs:172
                    }                                                                                                                       // FhirConstructGeneration.cs:173
                }                                                                                                                           // FhirConstructGeneration.cs:174
                if (fix.WhenElement != null)                                                                                                // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.WhenElement = new Instant();");                                                           // FhirConstructGeneration.cs:209
                    if (fix.WhenElement.Value.HasValue == true)                                                                             // FhirConstructGeneration.cs:109
                    {                                                                                                                       // FhirConstructGeneration.cs:110
                        DateTimeOffset x = fix.WhenElement.Value.Value;                                                                     // FhirConstructGeneration.cs:111
                        block                                                                                                               // FhirConstructGeneration.cs:112
                            .AppendCode($"retVal.WhenElement.Value = new DateTimeOffset({x.Year}, {x.Month}, {x.Day},")                     // FhirConstructGeneration.cs:113
                            .AppendCode($"    {x.Hour}, {x.Minute}, {x.Second}, {x.Millisecond},")                                          // FhirConstructGeneration.cs:114
                            .AppendCode($"    new TimeSpan({x.Offset.Hours}, {x.Offset.Minutes}, {x.Offset.Seconds}));")                    // FhirConstructGeneration.cs:115
                        ;                                                                                                                   // FhirConstructGeneration.cs:116
                    }                                                                                                                       // FhirConstructGeneration.cs:117
                    if (fix.WhenElement.ElementId != null)                                                                                  // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.WhenElement.ElementId = \"{fix.WhenElement.ElementId}\";");                               // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.ContentTypeElement != null)                                                                                         // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.ContentTypeElement = new Code();");                                                       // FhirConstructGeneration.cs:209
                    if (fix.ContentTypeElement.Value != null)                                                                               // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.ContentTypeElement.Value = \"{fix.ContentTypeElement.Value}\";");                         // FhirConstructGeneration.cs:138
                    if (fix.ContentTypeElement.ElementId != null)                                                                           // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.ContentTypeElement.ElementId = \"{fix.ContentTypeElement.ElementId}\";");                 // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.BlobElement != null)                                                                                                // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.BlobElement = new Base64Binary();");                                                      // FhirConstructGeneration.cs:209
                    if (fix.BlobElement.Value != null)                                                                                      // FhirConstructGeneration.cs:81
                    {                                                                                                                       // FhirConstructGeneration.cs:82
                        block.OpenBrace();                                                                                                  // FhirConstructGeneration.cs:83
                        block.AppendCode($"byte[] data = new byte[]");                                                                      // FhirConstructGeneration.cs:84
                        block.OpenBrace();                                                                                                  // FhirConstructGeneration.cs:85
                        Int32 i = 0;                                                                                                        // FhirConstructGeneration.cs:86
                        while (i < fix.BlobElement.Value.Length)                                                                            // FhirConstructGeneration.cs:87
                        {                                                                                                                   // FhirConstructGeneration.cs:88
                            Int32 j = 0;                                                                                                    // FhirConstructGeneration.cs:89
                            StringBuilder sb = new StringBuilder();                                                                         // FhirConstructGeneration.cs:90
                            while ((i < fix.BlobElement.Value.Length) && (j < 32))                                                          // FhirConstructGeneration.cs:91
                            {                                                                                                               // FhirConstructGeneration.cs:92
                                sb.Append($"{fix.BlobElement.Value[i]}");                                                                   // FhirConstructGeneration.cs:93
                                if (i < fix.BlobElement.Value.Length - 1) sb.Append(",");                                                   // FhirConstructGeneration.cs:94
                                j += 1;                                                                                                     // FhirConstructGeneration.cs:95
                                i += 1;                                                                                                     // FhirConstructGeneration.cs:96
                            }                                                                                                               // FhirConstructGeneration.cs:97
                            block.AppendCode($"{sb.ToString()}");                                                                           // FhirConstructGeneration.cs:98
                        }                                                                                                                   // FhirConstructGeneration.cs:99
                        block.CloseBrace(";");                                                                                              // FhirConstructGeneration.cs:100
                        block.AppendCode($"retVal.BlobElement.Value = data;");                                                              // FhirConstructGeneration.cs:101
                        block.CloseBrace(";");                                                                                              // FhirConstructGeneration.cs:102
                    }                                                                                                                       // FhirConstructGeneration.cs:103
                    if (fix.BlobElement.ElementId != null)                                                                                  // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.BlobElement.ElementId = \"{fix.BlobElement.ElementId}\";");                               // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:338
            block                                                                                                                           // FhirConstructGeneration.cs:339
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:340
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:341
                ;                                                                                                                           // FhirConstructGeneration.cs:342
            return  true;                                                                                                                   // FhirConstructGeneration.cs:343
        }                                                                                                                                   // FhirConstructGeneration.cs:344
                                                                                                                                            // FhirConstructGeneration.cs:315
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:319
            SimpleQuantity fix,                                                                                                             // FhirConstructGeneration.cs:320
            String methodName,                                                                                                              // FhirConstructGeneration.cs:321
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:322
        {                                                                                                                                   // FhirConstructGeneration.cs:323
                                                                                                                                            // FhirConstructGeneration.cs:325
            block                                                                                                                           // FhirConstructGeneration.cs:326
                .AppendCode($"{methodAccess} SimpleQuantity {methodName}()")                                                                // FhirConstructGeneration.cs:327
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:328
                .AppendCode("SimpleQuantity retVal = new SimpleQuantity();")                                                                // FhirConstructGeneration.cs:329
                ;                                                                                                                           // FhirConstructGeneration.cs:330
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:331
            {                                                                                                                               // FhirConstructGeneration.cs:332
                if (fix.ValueElement != null)                                                                                               // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.ValueElement = new FhirDecimal();");                                                      // FhirConstructGeneration.cs:209
                    if (fix.ValueElement.Value.HasValue == true)                                                                            // FhirConstructGeneration.cs:123
                        block.AppendCode($"retVal.ValueElement.Value = new Nullable<decimal>((decimal) {fix.ValueElement.Value.Value});");  // FhirConstructGeneration.cs:124
                    if (fix.ValueElement.ElementId != null)                                                                                 // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.ValueElement.ElementId = \"{fix.ValueElement.ElementId}\";");                             // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.ComparatorElement != null)                                                                                          // FhirConstructGeneration.cs:147
                    block.AppendCode($"retVal.ComparatorElement = new Code<Quantity.QuantityComparator>(Quantity.QuantityComparator.{fix.ComparatorElement.Value});");// FhirConstructGeneration.cs:148
                if (fix.UnitElement != null)                                                                                                // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.UnitElement = new FhirString();");                                                        // FhirConstructGeneration.cs:209
                    if (fix.UnitElement.Value != null)                                                                                      // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.UnitElement.Value = \"{fix.UnitElement.Value}\";");                                       // FhirConstructGeneration.cs:138
                    if (fix.UnitElement.ElementId != null)                                                                                  // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.UnitElement.ElementId = \"{fix.UnitElement.ElementId}\";");                               // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.SystemElement != null)                                                                                              // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.SystemElement = new FhirUri();");                                                         // FhirConstructGeneration.cs:209
                    if (fix.SystemElement.Value != null)                                                                                    // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.SystemElement.Value = \"{fix.SystemElement.Value}\";");                                   // FhirConstructGeneration.cs:138
                    if (fix.SystemElement.ElementId != null)                                                                                // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.SystemElement.ElementId = \"{fix.SystemElement.ElementId}\";");                           // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.CodeElement != null)                                                                                                // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.CodeElement = new Code();");                                                              // FhirConstructGeneration.cs:209
                    if (fix.CodeElement.Value != null)                                                                                      // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.CodeElement.Value = \"{fix.CodeElement.Value}\";");                                       // FhirConstructGeneration.cs:138
                    if (fix.CodeElement.ElementId != null)                                                                                  // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.CodeElement.ElementId = \"{fix.CodeElement.ElementId}\";");                               // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:338
            block                                                                                                                           // FhirConstructGeneration.cs:339
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:340
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:341
                ;                                                                                                                           // FhirConstructGeneration.cs:342
            return  true;                                                                                                                   // FhirConstructGeneration.cs:343
        }                                                                                                                                   // FhirConstructGeneration.cs:344
                                                                                                                                            // FhirConstructGeneration.cs:315
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:319
            Timing fix,                                                                                                                     // FhirConstructGeneration.cs:320
            String methodName,                                                                                                              // FhirConstructGeneration.cs:321
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:322
        {                                                                                                                                   // FhirConstructGeneration.cs:323
                                                                                                                                            // FhirConstructGeneration.cs:325
            block                                                                                                                           // FhirConstructGeneration.cs:326
                .AppendCode($"{methodAccess} Timing {methodName}()")                                                                        // FhirConstructGeneration.cs:327
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:328
                .AppendCode("Timing retVal = new Timing();")                                                                                // FhirConstructGeneration.cs:329
                ;                                                                                                                           // FhirConstructGeneration.cs:330
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:331
            {                                                                                                                               // FhirConstructGeneration.cs:332
                if (fix.EventElement != null)                                                                                               // FhirConstructGeneration.cs:159
                {                                                                                                                           // FhirConstructGeneration.cs:160
                    block.AppendCode($"retVal.EventElement = new List<FhirDateTime>();");                                                   // FhirConstructGeneration.cs:161
                    foreach (var temp85 in fix.EventElement)                                                                                // FhirConstructGeneration.cs:162
                    {                                                                                                                       // FhirConstructGeneration.cs:163
                        block.OpenBrace();                                                                                                  // FhirConstructGeneration.cs:164
                        block.AppendCode("var temp86 = new FhirDateTime();");                                                               // FhirConstructGeneration.cs:165
                        if (temp85.Value != null)                                                                                           // FhirConstructGeneration.cs:137
                            block.AppendCode($"temp86.Value = \"{temp85.Value}\";");                                                        // FhirConstructGeneration.cs:138
                        if (temp85.ElementId != null)                                                                                       // FhirConstructGeneration.cs:137
                            block.AppendCode($"temp86.ElementId = \"{temp85.ElementId}\";");                                                // FhirConstructGeneration.cs:138
                        block.AppendCode($"retVal.EventElement.Add(temp86);");                                                              // FhirConstructGeneration.cs:171
                        block.CloseBrace();                                                                                                 // FhirConstructGeneration.cs:172
                    }                                                                                                                       // FhirConstructGeneration.cs:173
                }                                                                                                                           // FhirConstructGeneration.cs:174
                if (fix.Repeat != null)                                                                                                     // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.Repeat = new Timing.RepeatComponent();");                                                 // FhirConstructGeneration.cs:209
                    if (fix.Repeat.CountElement != null)                                                                                    // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Repeat.CountElement = new Integer();");                                               // FhirConstructGeneration.cs:209
                        if (fix.Repeat.CountElement.Value.HasValue == true)                                                                 // FhirConstructGeneration.cs:130
                            block.AppendCode($"retVal.Repeat.CountElement.Value = new Nullable<int>((int) {fix.Repeat.CountElement.Value.Value});");// FhirConstructGeneration.cs:131
                        if (fix.Repeat.CountElement.ElementId != null)                                                                      // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Repeat.CountElement.ElementId = \"{fix.Repeat.CountElement.ElementId}\";");           // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Repeat.CountMaxElement != null)                                                                                 // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Repeat.CountMaxElement = new Integer();");                                            // FhirConstructGeneration.cs:209
                        if (fix.Repeat.CountMaxElement.Value.HasValue == true)                                                              // FhirConstructGeneration.cs:130
                            block.AppendCode($"retVal.Repeat.CountMaxElement.Value = new Nullable<int>((int) {fix.Repeat.CountMaxElement.Value.Value});");// FhirConstructGeneration.cs:131
                        if (fix.Repeat.CountMaxElement.ElementId != null)                                                                   // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Repeat.CountMaxElement.ElementId = \"{fix.Repeat.CountMaxElement.ElementId}\";");     // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Repeat.DurationElement != null)                                                                                 // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Repeat.DurationElement = new FhirDecimal();");                                        // FhirConstructGeneration.cs:209
                        if (fix.Repeat.DurationElement.Value.HasValue == true)                                                              // FhirConstructGeneration.cs:123
                            block.AppendCode($"retVal.Repeat.DurationElement.Value = new Nullable<decimal>((decimal) {fix.Repeat.DurationElement.Value.Value});");// FhirConstructGeneration.cs:124
                        if (fix.Repeat.DurationElement.ElementId != null)                                                                   // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Repeat.DurationElement.ElementId = \"{fix.Repeat.DurationElement.ElementId}\";");     // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Repeat.DurationMaxElement != null)                                                                              // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Repeat.DurationMaxElement = new FhirDecimal();");                                     // FhirConstructGeneration.cs:209
                        if (fix.Repeat.DurationMaxElement.Value.HasValue == true)                                                           // FhirConstructGeneration.cs:123
                            block.AppendCode($"retVal.Repeat.DurationMaxElement.Value = new Nullable<decimal>((decimal) {fix.Repeat.DurationMaxElement.Value.Value});");// FhirConstructGeneration.cs:124
                        if (fix.Repeat.DurationMaxElement.ElementId != null)                                                                // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Repeat.DurationMaxElement.ElementId = \"{fix.Repeat.DurationMaxElement.ElementId}\";");// FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Repeat.DurationUnitElement != null)                                                                             // FhirConstructGeneration.cs:147
                        block.AppendCode($"retVal.Repeat.DurationUnitElement = new Code<Timing.UnitsOfTime>(Timing.UnitsOfTime.{fix.Repeat.DurationUnitElement.Value});");// FhirConstructGeneration.cs:148
                    if (fix.Repeat.FrequencyElement != null)                                                                                // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Repeat.FrequencyElement = new Integer();");                                           // FhirConstructGeneration.cs:209
                        if (fix.Repeat.FrequencyElement.Value.HasValue == true)                                                             // FhirConstructGeneration.cs:130
                            block.AppendCode($"retVal.Repeat.FrequencyElement.Value = new Nullable<int>((int) {fix.Repeat.FrequencyElement.Value.Value});");// FhirConstructGeneration.cs:131
                        if (fix.Repeat.FrequencyElement.ElementId != null)                                                                  // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Repeat.FrequencyElement.ElementId = \"{fix.Repeat.FrequencyElement.ElementId}\";");   // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Repeat.FrequencyMaxElement != null)                                                                             // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Repeat.FrequencyMaxElement = new Integer();");                                        // FhirConstructGeneration.cs:209
                        if (fix.Repeat.FrequencyMaxElement.Value.HasValue == true)                                                          // FhirConstructGeneration.cs:130
                            block.AppendCode($"retVal.Repeat.FrequencyMaxElement.Value = new Nullable<int>((int) {fix.Repeat.FrequencyMaxElement.Value.Value});");// FhirConstructGeneration.cs:131
                        if (fix.Repeat.FrequencyMaxElement.ElementId != null)                                                               // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Repeat.FrequencyMaxElement.ElementId = \"{fix.Repeat.FrequencyMaxElement.ElementId}\";");// FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Repeat.PeriodElement != null)                                                                                   // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Repeat.PeriodElement = new FhirDecimal();");                                          // FhirConstructGeneration.cs:209
                        if (fix.Repeat.PeriodElement.Value.HasValue == true)                                                                // FhirConstructGeneration.cs:123
                            block.AppendCode($"retVal.Repeat.PeriodElement.Value = new Nullable<decimal>((decimal) {fix.Repeat.PeriodElement.Value.Value});");// FhirConstructGeneration.cs:124
                        if (fix.Repeat.PeriodElement.ElementId != null)                                                                     // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Repeat.PeriodElement.ElementId = \"{fix.Repeat.PeriodElement.ElementId}\";");         // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Repeat.PeriodMaxElement != null)                                                                                // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Repeat.PeriodMaxElement = new FhirDecimal();");                                       // FhirConstructGeneration.cs:209
                        if (fix.Repeat.PeriodMaxElement.Value.HasValue == true)                                                             // FhirConstructGeneration.cs:123
                            block.AppendCode($"retVal.Repeat.PeriodMaxElement.Value = new Nullable<decimal>((decimal) {fix.Repeat.PeriodMaxElement.Value.Value});");// FhirConstructGeneration.cs:124
                        if (fix.Repeat.PeriodMaxElement.ElementId != null)                                                                  // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Repeat.PeriodMaxElement.ElementId = \"{fix.Repeat.PeriodMaxElement.ElementId}\";");   // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Repeat.PeriodUnitElement != null)                                                                               // FhirConstructGeneration.cs:147
                        block.AppendCode($"retVal.Repeat.PeriodUnitElement = new Code<Timing.UnitsOfTime>(Timing.UnitsOfTime.{fix.Repeat.PeriodUnitElement.Value});");// FhirConstructGeneration.cs:148
                    if (fix.Repeat.DayOfWeekElement != null)                                                                                // FhirConstructGeneration.cs:159
                    {                                                                                                                       // FhirConstructGeneration.cs:160
                        block.AppendCode($"retVal.Repeat.DayOfWeekElement = new List<Code<DaysOfWeek>>();");                                // FhirConstructGeneration.cs:161
                        foreach (var temp87 in fix.Repeat.DayOfWeekElement)                                                                 // FhirConstructGeneration.cs:162
                        {                                                                                                                   // FhirConstructGeneration.cs:163
                            block.OpenBrace();                                                                                              // FhirConstructGeneration.cs:164
                            block.AppendCode("var temp88 = new Code<DaysOfWeek>();");                                                       // FhirConstructGeneration.cs:165
                            if (temp87.Value.HasValue == true)                                                                              // FhirConstructGeneration.cs:184
                                block.AppendCode($"temp88.Value = DaysOfWeek.{temp87.Value.Value};");                                       // FhirConstructGeneration.cs:185
                            if (temp87.ElementId != null)                                                                                   // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp88.ElementId = \"{temp87.ElementId}\";");                                            // FhirConstructGeneration.cs:138
                            block.AppendCode($"retVal.Repeat.DayOfWeekElement.Add(temp88);");                                               // FhirConstructGeneration.cs:171
                            block.CloseBrace();                                                                                             // FhirConstructGeneration.cs:172
                        }                                                                                                                   // FhirConstructGeneration.cs:173
                    }                                                                                                                       // FhirConstructGeneration.cs:174
                    if (fix.Repeat.TimeOfDayElement != null)                                                                                // FhirConstructGeneration.cs:159
                    {                                                                                                                       // FhirConstructGeneration.cs:160
                        block.AppendCode($"retVal.Repeat.TimeOfDayElement = new List<Time>();");                                            // FhirConstructGeneration.cs:161
                        foreach (var temp89 in fix.Repeat.TimeOfDayElement)                                                                 // FhirConstructGeneration.cs:162
                        {                                                                                                                   // FhirConstructGeneration.cs:163
                            block.OpenBrace();                                                                                              // FhirConstructGeneration.cs:164
                            block.AppendCode("var temp90 = new Time();");                                                                   // FhirConstructGeneration.cs:165
                            if (temp89.Value != null)                                                                                       // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp90.Value = \"{temp89.Value}\";");                                                    // FhirConstructGeneration.cs:138
                            if (temp89.ElementId != null)                                                                                   // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp90.ElementId = \"{temp89.ElementId}\";");                                            // FhirConstructGeneration.cs:138
                            block.AppendCode($"retVal.Repeat.TimeOfDayElement.Add(temp90);");                                               // FhirConstructGeneration.cs:171
                            block.CloseBrace();                                                                                             // FhirConstructGeneration.cs:172
                        }                                                                                                                   // FhirConstructGeneration.cs:173
                    }                                                                                                                       // FhirConstructGeneration.cs:174
                    if (fix.Repeat.WhenElement != null)                                                                                     // FhirConstructGeneration.cs:159
                    {                                                                                                                       // FhirConstructGeneration.cs:160
                        block.AppendCode($"retVal.Repeat.WhenElement = new List<Code<Timing.EventTiming>>();");                             // FhirConstructGeneration.cs:161
                        foreach (var temp91 in fix.Repeat.WhenElement)                                                                      // FhirConstructGeneration.cs:162
                        {                                                                                                                   // FhirConstructGeneration.cs:163
                            block.OpenBrace();                                                                                              // FhirConstructGeneration.cs:164
                            block.AppendCode("var temp92 = new Code<Timing.EventTiming>();");                                               // FhirConstructGeneration.cs:165
                            if (temp91.Value.HasValue == true)                                                                              // FhirConstructGeneration.cs:184
                                block.AppendCode($"temp92.Value = Timing.EventTiming.{temp91.Value.Value};");                               // FhirConstructGeneration.cs:185
                            if (temp91.ElementId != null)                                                                                   // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp92.ElementId = \"{temp91.ElementId}\";");                                            // FhirConstructGeneration.cs:138
                            block.AppendCode($"retVal.Repeat.WhenElement.Add(temp92);");                                                    // FhirConstructGeneration.cs:171
                            block.CloseBrace();                                                                                             // FhirConstructGeneration.cs:172
                        }                                                                                                                   // FhirConstructGeneration.cs:173
                    }                                                                                                                       // FhirConstructGeneration.cs:174
                    if (fix.Repeat.OffsetElement != null)                                                                                   // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Repeat.OffsetElement = new UnsignedInt();");                                          // FhirConstructGeneration.cs:209
                        if (fix.Repeat.OffsetElement.Value.HasValue == true)                                                                // FhirConstructGeneration.cs:130
                            block.AppendCode($"retVal.Repeat.OffsetElement.Value = new Nullable<int>((int) {fix.Repeat.OffsetElement.Value.Value});");// FhirConstructGeneration.cs:131
                        if (fix.Repeat.OffsetElement.ElementId != null)                                                                     // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Repeat.OffsetElement.ElementId = \"{fix.Repeat.OffsetElement.ElementId}\";");         // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Repeat.ElementId != null)                                                                                       // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.Repeat.ElementId = \"{fix.Repeat.ElementId}\";");                                         // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.Code != null)                                                                                                       // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.Code = new CodeableConcept();");                                                          // FhirConstructGeneration.cs:209
                    if (fix.Code.Coding != null)                                                                                            // FhirConstructGeneration.cs:159
                    {                                                                                                                       // FhirConstructGeneration.cs:160
                        block.AppendCode($"retVal.Code.Coding = new List<Coding>();");                                                      // FhirConstructGeneration.cs:161
                        foreach (var temp93 in fix.Code.Coding)                                                                             // FhirConstructGeneration.cs:162
                        {                                                                                                                   // FhirConstructGeneration.cs:163
                            block.OpenBrace();                                                                                              // FhirConstructGeneration.cs:164
                            block.AppendCode("var temp94 = new Coding();");                                                                 // FhirConstructGeneration.cs:165
                            if (temp93.SystemElement != null)                                                                               // FhirConstructGeneration.cs:207
                            {                                                                                                               // FhirConstructGeneration.cs:208
                                    block.AppendCode($"temp94.SystemElement = new FhirUri();");                                             // FhirConstructGeneration.cs:209
                                if (temp93.SystemElement.Value != null)                                                                     // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp94.SystemElement.Value = \"{temp93.SystemElement.Value}\";");                    // FhirConstructGeneration.cs:138
                                if (temp93.SystemElement.ElementId != null)                                                                 // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp94.SystemElement.ElementId = \"{temp93.SystemElement.ElementId}\";");            // FhirConstructGeneration.cs:138
                            }                                                                                                               // FhirConstructGeneration.cs:213
                            if (temp93.VersionElement != null)                                                                              // FhirConstructGeneration.cs:207
                            {                                                                                                               // FhirConstructGeneration.cs:208
                                    block.AppendCode($"temp94.VersionElement = new FhirString();");                                         // FhirConstructGeneration.cs:209
                                if (temp93.VersionElement.Value != null)                                                                    // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp94.VersionElement.Value = \"{temp93.VersionElement.Value}\";");                  // FhirConstructGeneration.cs:138
                                if (temp93.VersionElement.ElementId != null)                                                                // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp94.VersionElement.ElementId = \"{temp93.VersionElement.ElementId}\";");          // FhirConstructGeneration.cs:138
                            }                                                                                                               // FhirConstructGeneration.cs:213
                            if (temp93.CodeElement != null)                                                                                 // FhirConstructGeneration.cs:207
                            {                                                                                                               // FhirConstructGeneration.cs:208
                                    block.AppendCode($"temp94.CodeElement = new Code();");                                                  // FhirConstructGeneration.cs:209
                                if (temp93.CodeElement.Value != null)                                                                       // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp94.CodeElement.Value = \"{temp93.CodeElement.Value}\";");                        // FhirConstructGeneration.cs:138
                                if (temp93.CodeElement.ElementId != null)                                                                   // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp94.CodeElement.ElementId = \"{temp93.CodeElement.ElementId}\";");                // FhirConstructGeneration.cs:138
                            }                                                                                                               // FhirConstructGeneration.cs:213
                            if (temp93.DisplayElement != null)                                                                              // FhirConstructGeneration.cs:207
                            {                                                                                                               // FhirConstructGeneration.cs:208
                                    block.AppendCode($"temp94.DisplayElement = new FhirString();");                                         // FhirConstructGeneration.cs:209
                                if (temp93.DisplayElement.Value != null)                                                                    // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp94.DisplayElement.Value = \"{temp93.DisplayElement.Value}\";");                  // FhirConstructGeneration.cs:138
                                if (temp93.DisplayElement.ElementId != null)                                                                // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp94.DisplayElement.ElementId = \"{temp93.DisplayElement.ElementId}\";");          // FhirConstructGeneration.cs:138
                            }                                                                                                               // FhirConstructGeneration.cs:213
                            if (temp93.UserSelectedElement != null)                                                                         // FhirConstructGeneration.cs:207
                            {                                                                                                               // FhirConstructGeneration.cs:208
                                    block.AppendCode($"temp94.UserSelectedElement = new FhirBoolean();");                                   // FhirConstructGeneration.cs:209
                                if (temp93.UserSelectedElement.Value.HasValue == true)                                                      // FhirConstructGeneration.cs:69
                                {                                                                                                           // FhirConstructGeneration.cs:70
                                    if (temp93.UserSelectedElement.Value.Value == true)                                                     // FhirConstructGeneration.cs:71
                                        block.AppendCode($"temp94.UserSelectedElement.Value = true;");                                      // FhirConstructGeneration.cs:72
                                    else                                                                                                    // FhirConstructGeneration.cs:73
                                        block.AppendCode($"temp94.UserSelectedElement.Value = false;");                                     // FhirConstructGeneration.cs:74
                                }                                                                                                           // FhirConstructGeneration.cs:75
                                if (temp93.UserSelectedElement.ElementId != null)                                                           // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp94.UserSelectedElement.ElementId = \"{temp93.UserSelectedElement.ElementId}\";");// FhirConstructGeneration.cs:138
                            }                                                                                                               // FhirConstructGeneration.cs:213
                            if (temp93.ElementId != null)                                                                                   // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp94.ElementId = \"{temp93.ElementId}\";");                                            // FhirConstructGeneration.cs:138
                            block.AppendCode($"retVal.Code.Coding.Add(temp94);");                                                           // FhirConstructGeneration.cs:171
                            block.CloseBrace();                                                                                             // FhirConstructGeneration.cs:172
                        }                                                                                                                   // FhirConstructGeneration.cs:173
                    }                                                                                                                       // FhirConstructGeneration.cs:174
                    if (fix.Code.TextElement != null)                                                                                       // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Code.TextElement = new FhirString();");                                               // FhirConstructGeneration.cs:209
                        if (fix.Code.TextElement.Value != null)                                                                             // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Code.TextElement.Value = \"{fix.Code.TextElement.Value}\";");                         // FhirConstructGeneration.cs:138
                        if (fix.Code.TextElement.ElementId != null)                                                                         // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Code.TextElement.ElementId = \"{fix.Code.TextElement.ElementId}\";");                 // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Code.ElementId != null)                                                                                         // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.Code.ElementId = \"{fix.Code.ElementId}\";");                                             // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:338
            block                                                                                                                           // FhirConstructGeneration.cs:339
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:340
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:341
                ;                                                                                                                           // FhirConstructGeneration.cs:342
            return  true;                                                                                                                   // FhirConstructGeneration.cs:343
        }                                                                                                                                   // FhirConstructGeneration.cs:344
                                                                                                                                            // FhirConstructGeneration.cs:315
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:319
            TriggerDefinition fix,                                                                                                          // FhirConstructGeneration.cs:320
            String methodName,                                                                                                              // FhirConstructGeneration.cs:321
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:322
        {                                                                                                                                   // FhirConstructGeneration.cs:323
                                                                                                                                            // FhirConstructGeneration.cs:325
            block                                                                                                                           // FhirConstructGeneration.cs:326
                .AppendCode($"{methodAccess} TriggerDefinition {methodName}()")                                                             // FhirConstructGeneration.cs:327
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:328
                .AppendCode("TriggerDefinition retVal = new TriggerDefinition();")                                                          // FhirConstructGeneration.cs:329
                ;                                                                                                                           // FhirConstructGeneration.cs:330
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:331
            {                                                                                                                               // FhirConstructGeneration.cs:332
                if (fix.TypeElement != null)                                                                                                // FhirConstructGeneration.cs:147
                    block.AppendCode($"retVal.TypeElement = new Code<TriggerDefinition.TriggerType>(TriggerDefinition.TriggerType.{fix.TypeElement.Value});");// FhirConstructGeneration.cs:148
                if (fix.EventNameElement != null)                                                                                           // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.EventNameElement = new FhirString();");                                                   // FhirConstructGeneration.cs:209
                    if (fix.EventNameElement.Value != null)                                                                                 // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.EventNameElement.Value = \"{fix.EventNameElement.Value}\";");                             // FhirConstructGeneration.cs:138
                    if (fix.EventNameElement.ElementId != null)                                                                             // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.EventNameElement.ElementId = \"{fix.EventNameElement.ElementId}\";");                     // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.EventData != null)                                                                                                  // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.EventData = new DataRequirement();");                                                     // FhirConstructGeneration.cs:209
                    if (fix.EventData.TypeElement != null)                                                                                  // FhirConstructGeneration.cs:147
                        block.AppendCode($"retVal.EventData.TypeElement = new Code<FHIRAllTypes>(FHIRAllTypes.{fix.EventData.TypeElement.Value});");// FhirConstructGeneration.cs:148
                    if (fix.EventData.ProfileElement != null)                                                                               // FhirConstructGeneration.cs:159
                    {                                                                                                                       // FhirConstructGeneration.cs:160
                        block.AppendCode($"retVal.EventData.ProfileElement = new List<FhirUri>();");                                        // FhirConstructGeneration.cs:161
                        foreach (var temp95 in fix.EventData.ProfileElement)                                                                // FhirConstructGeneration.cs:162
                        {                                                                                                                   // FhirConstructGeneration.cs:163
                            block.OpenBrace();                                                                                              // FhirConstructGeneration.cs:164
                            block.AppendCode("var temp96 = new FhirUri();");                                                                // FhirConstructGeneration.cs:165
                            if (temp95.Value != null)                                                                                       // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp96.Value = \"{temp95.Value}\";");                                                    // FhirConstructGeneration.cs:138
                            if (temp95.ElementId != null)                                                                                   // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp96.ElementId = \"{temp95.ElementId}\";");                                            // FhirConstructGeneration.cs:138
                            block.AppendCode($"retVal.EventData.ProfileElement.Add(temp96);");                                              // FhirConstructGeneration.cs:171
                            block.CloseBrace();                                                                                             // FhirConstructGeneration.cs:172
                        }                                                                                                                   // FhirConstructGeneration.cs:173
                    }                                                                                                                       // FhirConstructGeneration.cs:174
                    if (fix.EventData.MustSupportElement != null)                                                                           // FhirConstructGeneration.cs:159
                    {                                                                                                                       // FhirConstructGeneration.cs:160
                        block.AppendCode($"retVal.EventData.MustSupportElement = new List<FhirString>();");                                 // FhirConstructGeneration.cs:161
                        foreach (var temp97 in fix.EventData.MustSupportElement)                                                            // FhirConstructGeneration.cs:162
                        {                                                                                                                   // FhirConstructGeneration.cs:163
                            block.OpenBrace();                                                                                              // FhirConstructGeneration.cs:164
                            block.AppendCode("var temp98 = new FhirString();");                                                             // FhirConstructGeneration.cs:165
                            if (temp97.Value != null)                                                                                       // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp98.Value = \"{temp97.Value}\";");                                                    // FhirConstructGeneration.cs:138
                            if (temp97.ElementId != null)                                                                                   // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp98.ElementId = \"{temp97.ElementId}\";");                                            // FhirConstructGeneration.cs:138
                            block.AppendCode($"retVal.EventData.MustSupportElement.Add(temp98);");                                          // FhirConstructGeneration.cs:171
                            block.CloseBrace();                                                                                             // FhirConstructGeneration.cs:172
                        }                                                                                                                   // FhirConstructGeneration.cs:173
                    }                                                                                                                       // FhirConstructGeneration.cs:174
                    if (fix.EventData.CodeFilter != null)                                                                                   // FhirConstructGeneration.cs:159
                    {                                                                                                                       // FhirConstructGeneration.cs:160
                        block.AppendCode($"retVal.EventData.CodeFilter = new List<DataRequirement.CodeFilterComponent>();");                // FhirConstructGeneration.cs:161
                        foreach (var temp99 in fix.EventData.CodeFilter)                                                                    // FhirConstructGeneration.cs:162
                        {                                                                                                                   // FhirConstructGeneration.cs:163
                            block.OpenBrace();                                                                                              // FhirConstructGeneration.cs:164
                            block.AppendCode("var temp100 = new DataRequirement.CodeFilterComponent();");                                   // FhirConstructGeneration.cs:165
                            if (temp99.PathElement != null)                                                                                 // FhirConstructGeneration.cs:207
                            {                                                                                                               // FhirConstructGeneration.cs:208
                                    block.AppendCode($"temp100.PathElement = new FhirString();");                                           // FhirConstructGeneration.cs:209
                                if (temp99.PathElement.Value != null)                                                                       // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp100.PathElement.Value = \"{temp99.PathElement.Value}\";");                       // FhirConstructGeneration.cs:138
                                if (temp99.PathElement.ElementId != null)                                                                   // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp100.PathElement.ElementId = \"{temp99.PathElement.ElementId}\";");               // FhirConstructGeneration.cs:138
                            }                                                                                                               // FhirConstructGeneration.cs:213
                            if (temp99.ValueCodeElement != null)                                                                            // FhirConstructGeneration.cs:159
                            {                                                                                                               // FhirConstructGeneration.cs:160
                                block.AppendCode($"temp100.ValueCodeElement = new List<Code>();");                                          // FhirConstructGeneration.cs:161
                                foreach (var temp101 in temp99.ValueCodeElement)                                                            // FhirConstructGeneration.cs:162
                                {                                                                                                           // FhirConstructGeneration.cs:163
                                    block.OpenBrace();                                                                                      // FhirConstructGeneration.cs:164
                                    block.AppendCode("var temp102 = new Code();");                                                          // FhirConstructGeneration.cs:165
                                    if (temp101.Value != null)                                                                              // FhirConstructGeneration.cs:137
                                        block.AppendCode($"temp102.Value = \"{temp101.Value}\";");                                          // FhirConstructGeneration.cs:138
                                    if (temp101.ElementId != null)                                                                          // FhirConstructGeneration.cs:137
                                        block.AppendCode($"temp102.ElementId = \"{temp101.ElementId}\";");                                  // FhirConstructGeneration.cs:138
                                    block.AppendCode($"temp100.ValueCodeElement.Add(temp102);");                                            // FhirConstructGeneration.cs:171
                                    block.CloseBrace();                                                                                     // FhirConstructGeneration.cs:172
                                }                                                                                                           // FhirConstructGeneration.cs:173
                            }                                                                                                               // FhirConstructGeneration.cs:174
                            if (temp99.ValueCoding != null)                                                                                 // FhirConstructGeneration.cs:159
                            {                                                                                                               // FhirConstructGeneration.cs:160
                                block.AppendCode($"temp100.ValueCoding = new List<Coding>();");                                             // FhirConstructGeneration.cs:161
                                foreach (var temp103 in temp99.ValueCoding)                                                                 // FhirConstructGeneration.cs:162
                                {                                                                                                           // FhirConstructGeneration.cs:163
                                    block.OpenBrace();                                                                                      // FhirConstructGeneration.cs:164
                                    block.AppendCode("var temp104 = new Coding();");                                                        // FhirConstructGeneration.cs:165
                                    if (temp103.SystemElement != null)                                                                      // FhirConstructGeneration.cs:207
                                    {                                                                                                       // FhirConstructGeneration.cs:208
                                            block.AppendCode($"temp104.SystemElement = new FhirUri();");                                    // FhirConstructGeneration.cs:209
                                        if (temp103.SystemElement.Value != null)                                                            // FhirConstructGeneration.cs:137
                                            block.AppendCode($"temp104.SystemElement.Value = \"{temp103.SystemElement.Value}\";");          // FhirConstructGeneration.cs:138
                                        if (temp103.SystemElement.ElementId != null)                                                        // FhirConstructGeneration.cs:137
                                            block.AppendCode($"temp104.SystemElement.ElementId = \"{temp103.SystemElement.ElementId}\";");  // FhirConstructGeneration.cs:138
                                    }                                                                                                       // FhirConstructGeneration.cs:213
                                    if (temp103.VersionElement != null)                                                                     // FhirConstructGeneration.cs:207
                                    {                                                                                                       // FhirConstructGeneration.cs:208
                                            block.AppendCode($"temp104.VersionElement = new FhirString();");                                // FhirConstructGeneration.cs:209
                                        if (temp103.VersionElement.Value != null)                                                           // FhirConstructGeneration.cs:137
                                            block.AppendCode($"temp104.VersionElement.Value = \"{temp103.VersionElement.Value}\";");        // FhirConstructGeneration.cs:138
                                        if (temp103.VersionElement.ElementId != null)                                                       // FhirConstructGeneration.cs:137
                                            block.AppendCode($"temp104.VersionElement.ElementId = \"{temp103.VersionElement.ElementId}\";");// FhirConstructGeneration.cs:138
                                    }                                                                                                       // FhirConstructGeneration.cs:213
                                    if (temp103.CodeElement != null)                                                                        // FhirConstructGeneration.cs:207
                                    {                                                                                                       // FhirConstructGeneration.cs:208
                                            block.AppendCode($"temp104.CodeElement = new Code();");                                         // FhirConstructGeneration.cs:209
                                        if (temp103.CodeElement.Value != null)                                                              // FhirConstructGeneration.cs:137
                                            block.AppendCode($"temp104.CodeElement.Value = \"{temp103.CodeElement.Value}\";");              // FhirConstructGeneration.cs:138
                                        if (temp103.CodeElement.ElementId != null)                                                          // FhirConstructGeneration.cs:137
                                            block.AppendCode($"temp104.CodeElement.ElementId = \"{temp103.CodeElement.ElementId}\";");      // FhirConstructGeneration.cs:138
                                    }                                                                                                       // FhirConstructGeneration.cs:213
                                    if (temp103.DisplayElement != null)                                                                     // FhirConstructGeneration.cs:207
                                    {                                                                                                       // FhirConstructGeneration.cs:208
                                            block.AppendCode($"temp104.DisplayElement = new FhirString();");                                // FhirConstructGeneration.cs:209
                                        if (temp103.DisplayElement.Value != null)                                                           // FhirConstructGeneration.cs:137
                                            block.AppendCode($"temp104.DisplayElement.Value = \"{temp103.DisplayElement.Value}\";");        // FhirConstructGeneration.cs:138
                                        if (temp103.DisplayElement.ElementId != null)                                                       // FhirConstructGeneration.cs:137
                                            block.AppendCode($"temp104.DisplayElement.ElementId = \"{temp103.DisplayElement.ElementId}\";");// FhirConstructGeneration.cs:138
                                    }                                                                                                       // FhirConstructGeneration.cs:213
                                    if (temp103.UserSelectedElement != null)                                                                // FhirConstructGeneration.cs:207
                                    {                                                                                                       // FhirConstructGeneration.cs:208
                                            block.AppendCode($"temp104.UserSelectedElement = new FhirBoolean();");                          // FhirConstructGeneration.cs:209
                                        if (temp103.UserSelectedElement.Value.HasValue == true)                                             // FhirConstructGeneration.cs:69
                                        {                                                                                                   // FhirConstructGeneration.cs:70
                                            if (temp103.UserSelectedElement.Value.Value == true)                                            // FhirConstructGeneration.cs:71
                                                block.AppendCode($"temp104.UserSelectedElement.Value = true;");                             // FhirConstructGeneration.cs:72
                                            else                                                                                            // FhirConstructGeneration.cs:73
                                                block.AppendCode($"temp104.UserSelectedElement.Value = false;");                            // FhirConstructGeneration.cs:74
                                        }                                                                                                   // FhirConstructGeneration.cs:75
                                        if (temp103.UserSelectedElement.ElementId != null)                                                  // FhirConstructGeneration.cs:137
                                            block.AppendCode($"temp104.UserSelectedElement.ElementId = \"{temp103.UserSelectedElement.ElementId}\";");// FhirConstructGeneration.cs:138
                                    }                                                                                                       // FhirConstructGeneration.cs:213
                                    if (temp103.ElementId != null)                                                                          // FhirConstructGeneration.cs:137
                                        block.AppendCode($"temp104.ElementId = \"{temp103.ElementId}\";");                                  // FhirConstructGeneration.cs:138
                                    block.AppendCode($"temp100.ValueCoding.Add(temp104);");                                                 // FhirConstructGeneration.cs:171
                                    block.CloseBrace();                                                                                     // FhirConstructGeneration.cs:172
                                }                                                                                                           // FhirConstructGeneration.cs:173
                            }                                                                                                               // FhirConstructGeneration.cs:174
                            if (temp99.ValueCodeableConcept != null)                                                                        // FhirConstructGeneration.cs:159
                            {                                                                                                               // FhirConstructGeneration.cs:160
                                block.AppendCode($"temp100.ValueCodeableConcept = new List<CodeableConcept>();");                           // FhirConstructGeneration.cs:161
                                foreach (var temp105 in temp99.ValueCodeableConcept)                                                        // FhirConstructGeneration.cs:162
                                {                                                                                                           // FhirConstructGeneration.cs:163
                                    block.OpenBrace();                                                                                      // FhirConstructGeneration.cs:164
                                    block.AppendCode("var temp106 = new CodeableConcept();");                                               // FhirConstructGeneration.cs:165
                                    if (temp105.Coding != null)                                                                             // FhirConstructGeneration.cs:159
                                    {                                                                                                       // FhirConstructGeneration.cs:160
                                        block.AppendCode($"temp106.Coding = new List<Coding>();");                                          // FhirConstructGeneration.cs:161
                                        foreach (var temp107 in temp105.Coding)                                                             // FhirConstructGeneration.cs:162
                                        {                                                                                                   // FhirConstructGeneration.cs:163
                                            block.OpenBrace();                                                                              // FhirConstructGeneration.cs:164
                                            block.AppendCode("var temp108 = new Coding();");                                                // FhirConstructGeneration.cs:165
                                            if (temp107.SystemElement != null)                                                              // FhirConstructGeneration.cs:207
                                            {                                                                                               // FhirConstructGeneration.cs:208
                                                    block.AppendCode($"temp108.SystemElement = new FhirUri();");                            // FhirConstructGeneration.cs:209
                                                if (temp107.SystemElement.Value != null)                                                    // FhirConstructGeneration.cs:137
                                                    block.AppendCode($"temp108.SystemElement.Value = \"{temp107.SystemElement.Value}\";");  // FhirConstructGeneration.cs:138
                                                if (temp107.SystemElement.ElementId != null)                                                // FhirConstructGeneration.cs:137
                                                    block.AppendCode($"temp108.SystemElement.ElementId = \"{temp107.SystemElement.ElementId}\";");// FhirConstructGeneration.cs:138
                                            }                                                                                               // FhirConstructGeneration.cs:213
                                            if (temp107.VersionElement != null)                                                             // FhirConstructGeneration.cs:207
                                            {                                                                                               // FhirConstructGeneration.cs:208
                                                    block.AppendCode($"temp108.VersionElement = new FhirString();");                        // FhirConstructGeneration.cs:209
                                                if (temp107.VersionElement.Value != null)                                                   // FhirConstructGeneration.cs:137
                                                    block.AppendCode($"temp108.VersionElement.Value = \"{temp107.VersionElement.Value}\";");// FhirConstructGeneration.cs:138
                                                if (temp107.VersionElement.ElementId != null)                                               // FhirConstructGeneration.cs:137
                                                    block.AppendCode($"temp108.VersionElement.ElementId = \"{temp107.VersionElement.ElementId}\";");// FhirConstructGeneration.cs:138
                                            }                                                                                               // FhirConstructGeneration.cs:213
                                            if (temp107.CodeElement != null)                                                                // FhirConstructGeneration.cs:207
                                            {                                                                                               // FhirConstructGeneration.cs:208
                                                    block.AppendCode($"temp108.CodeElement = new Code();");                                 // FhirConstructGeneration.cs:209
                                                if (temp107.CodeElement.Value != null)                                                      // FhirConstructGeneration.cs:137
                                                    block.AppendCode($"temp108.CodeElement.Value = \"{temp107.CodeElement.Value}\";");      // FhirConstructGeneration.cs:138
                                                if (temp107.CodeElement.ElementId != null)                                                  // FhirConstructGeneration.cs:137
                                                    block.AppendCode($"temp108.CodeElement.ElementId = \"{temp107.CodeElement.ElementId}\";");// FhirConstructGeneration.cs:138
                                            }                                                                                               // FhirConstructGeneration.cs:213
                                            if (temp107.DisplayElement != null)                                                             // FhirConstructGeneration.cs:207
                                            {                                                                                               // FhirConstructGeneration.cs:208
                                                    block.AppendCode($"temp108.DisplayElement = new FhirString();");                        // FhirConstructGeneration.cs:209
                                                if (temp107.DisplayElement.Value != null)                                                   // FhirConstructGeneration.cs:137
                                                    block.AppendCode($"temp108.DisplayElement.Value = \"{temp107.DisplayElement.Value}\";");// FhirConstructGeneration.cs:138
                                                if (temp107.DisplayElement.ElementId != null)                                               // FhirConstructGeneration.cs:137
                                                    block.AppendCode($"temp108.DisplayElement.ElementId = \"{temp107.DisplayElement.ElementId}\";");// FhirConstructGeneration.cs:138
                                            }                                                                                               // FhirConstructGeneration.cs:213
                                            if (temp107.UserSelectedElement != null)                                                        // FhirConstructGeneration.cs:207
                                            {                                                                                               // FhirConstructGeneration.cs:208
                                                    block.AppendCode($"temp108.UserSelectedElement = new FhirBoolean();");                  // FhirConstructGeneration.cs:209
                                                if (temp107.UserSelectedElement.Value.HasValue == true)                                     // FhirConstructGeneration.cs:69
                                                {                                                                                           // FhirConstructGeneration.cs:70
                                                    if (temp107.UserSelectedElement.Value.Value == true)                                    // FhirConstructGeneration.cs:71
                                                        block.AppendCode($"temp108.UserSelectedElement.Value = true;");                     // FhirConstructGeneration.cs:72
                                                    else                                                                                    // FhirConstructGeneration.cs:73
                                                        block.AppendCode($"temp108.UserSelectedElement.Value = false;");                    // FhirConstructGeneration.cs:74
                                                }                                                                                           // FhirConstructGeneration.cs:75
                                                if (temp107.UserSelectedElement.ElementId != null)                                          // FhirConstructGeneration.cs:137
                                                    block.AppendCode($"temp108.UserSelectedElement.ElementId = \"{temp107.UserSelectedElement.ElementId}\";");// FhirConstructGeneration.cs:138
                                            }                                                                                               // FhirConstructGeneration.cs:213
                                            if (temp107.ElementId != null)                                                                  // FhirConstructGeneration.cs:137
                                                block.AppendCode($"temp108.ElementId = \"{temp107.ElementId}\";");                          // FhirConstructGeneration.cs:138
                                            block.AppendCode($"temp106.Coding.Add(temp108);");                                              // FhirConstructGeneration.cs:171
                                            block.CloseBrace();                                                                             // FhirConstructGeneration.cs:172
                                        }                                                                                                   // FhirConstructGeneration.cs:173
                                    }                                                                                                       // FhirConstructGeneration.cs:174
                                    if (temp105.TextElement != null)                                                                        // FhirConstructGeneration.cs:207
                                    {                                                                                                       // FhirConstructGeneration.cs:208
                                            block.AppendCode($"temp106.TextElement = new FhirString();");                                   // FhirConstructGeneration.cs:209
                                        if (temp105.TextElement.Value != null)                                                              // FhirConstructGeneration.cs:137
                                            block.AppendCode($"temp106.TextElement.Value = \"{temp105.TextElement.Value}\";");              // FhirConstructGeneration.cs:138
                                        if (temp105.TextElement.ElementId != null)                                                          // FhirConstructGeneration.cs:137
                                            block.AppendCode($"temp106.TextElement.ElementId = \"{temp105.TextElement.ElementId}\";");      // FhirConstructGeneration.cs:138
                                    }                                                                                                       // FhirConstructGeneration.cs:213
                                    if (temp105.ElementId != null)                                                                          // FhirConstructGeneration.cs:137
                                        block.AppendCode($"temp106.ElementId = \"{temp105.ElementId}\";");                                  // FhirConstructGeneration.cs:138
                                    block.AppendCode($"temp100.ValueCodeableConcept.Add(temp106);");                                        // FhirConstructGeneration.cs:171
                                    block.CloseBrace();                                                                                     // FhirConstructGeneration.cs:172
                                }                                                                                                           // FhirConstructGeneration.cs:173
                            }                                                                                                               // FhirConstructGeneration.cs:174
                            if (temp99.ElementId != null)                                                                                   // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp100.ElementId = \"{temp99.ElementId}\";");                                           // FhirConstructGeneration.cs:138
                            block.AppendCode($"retVal.EventData.CodeFilter.Add(temp100);");                                                 // FhirConstructGeneration.cs:171
                            block.CloseBrace();                                                                                             // FhirConstructGeneration.cs:172
                        }                                                                                                                   // FhirConstructGeneration.cs:173
                    }                                                                                                                       // FhirConstructGeneration.cs:174
                    if (fix.EventData.DateFilter != null)                                                                                   // FhirConstructGeneration.cs:159
                    {                                                                                                                       // FhirConstructGeneration.cs:160
                        block.AppendCode($"retVal.EventData.DateFilter = new List<DataRequirement.DateFilterComponent>();");                // FhirConstructGeneration.cs:161
                        foreach (var temp109 in fix.EventData.DateFilter)                                                                   // FhirConstructGeneration.cs:162
                        {                                                                                                                   // FhirConstructGeneration.cs:163
                            block.OpenBrace();                                                                                              // FhirConstructGeneration.cs:164
                            block.AppendCode("var temp110 = new DataRequirement.DateFilterComponent();");                                   // FhirConstructGeneration.cs:165
                            if (temp109.PathElement != null)                                                                                // FhirConstructGeneration.cs:207
                            {                                                                                                               // FhirConstructGeneration.cs:208
                                    block.AppendCode($"temp110.PathElement = new FhirString();");                                           // FhirConstructGeneration.cs:209
                                if (temp109.PathElement.Value != null)                                                                      // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp110.PathElement.Value = \"{temp109.PathElement.Value}\";");                      // FhirConstructGeneration.cs:138
                                if (temp109.PathElement.ElementId != null)                                                                  // FhirConstructGeneration.cs:137
                                    block.AppendCode($"temp110.PathElement.ElementId = \"{temp109.PathElement.ElementId}\";");              // FhirConstructGeneration.cs:138
                            }                                                                                                               // FhirConstructGeneration.cs:213
                            if (temp109.ElementId != null)                                                                                  // FhirConstructGeneration.cs:137
                                block.AppendCode($"temp110.ElementId = \"{temp109.ElementId}\";");                                          // FhirConstructGeneration.cs:138
                            block.AppendCode($"retVal.EventData.DateFilter.Add(temp110);");                                                 // FhirConstructGeneration.cs:171
                            block.CloseBrace();                                                                                             // FhirConstructGeneration.cs:172
                        }                                                                                                                   // FhirConstructGeneration.cs:173
                    }                                                                                                                       // FhirConstructGeneration.cs:174
                    if (fix.EventData.ElementId != null)                                                                                    // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.EventData.ElementId = \"{fix.EventData.ElementId}\";");                                   // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:338
            block                                                                                                                           // FhirConstructGeneration.cs:339
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:340
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:341
                ;                                                                                                                           // FhirConstructGeneration.cs:342
            return  true;                                                                                                                   // FhirConstructGeneration.cs:343
        }                                                                                                                                   // FhirConstructGeneration.cs:344
                                                                                                                                            // FhirConstructGeneration.cs:315
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:319
            UsageContext fix,                                                                                                               // FhirConstructGeneration.cs:320
            String methodName,                                                                                                              // FhirConstructGeneration.cs:321
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:322
        {                                                                                                                                   // FhirConstructGeneration.cs:323
                                                                                                                                            // FhirConstructGeneration.cs:325
            block                                                                                                                           // FhirConstructGeneration.cs:326
                .AppendCode($"{methodAccess} UsageContext {methodName}()")                                                                  // FhirConstructGeneration.cs:327
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:328
                .AppendCode("UsageContext retVal = new UsageContext();")                                                                    // FhirConstructGeneration.cs:329
                ;                                                                                                                           // FhirConstructGeneration.cs:330
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:331
            {                                                                                                                               // FhirConstructGeneration.cs:332
                if (fix.Code != null)                                                                                                       // FhirConstructGeneration.cs:207
                {                                                                                                                           // FhirConstructGeneration.cs:208
                        block.AppendCode($"retVal.Code = new Coding();");                                                                   // FhirConstructGeneration.cs:209
                    if (fix.Code.SystemElement != null)                                                                                     // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Code.SystemElement = new FhirUri();");                                                // FhirConstructGeneration.cs:209
                        if (fix.Code.SystemElement.Value != null)                                                                           // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Code.SystemElement.Value = \"{fix.Code.SystemElement.Value}\";");                     // FhirConstructGeneration.cs:138
                        if (fix.Code.SystemElement.ElementId != null)                                                                       // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Code.SystemElement.ElementId = \"{fix.Code.SystemElement.ElementId}\";");             // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Code.VersionElement != null)                                                                                    // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Code.VersionElement = new FhirString();");                                            // FhirConstructGeneration.cs:209
                        if (fix.Code.VersionElement.Value != null)                                                                          // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Code.VersionElement.Value = \"{fix.Code.VersionElement.Value}\";");                   // FhirConstructGeneration.cs:138
                        if (fix.Code.VersionElement.ElementId != null)                                                                      // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Code.VersionElement.ElementId = \"{fix.Code.VersionElement.ElementId}\";");           // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Code.CodeElement != null)                                                                                       // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Code.CodeElement = new Code();");                                                     // FhirConstructGeneration.cs:209
                        if (fix.Code.CodeElement.Value != null)                                                                             // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Code.CodeElement.Value = \"{fix.Code.CodeElement.Value}\";");                         // FhirConstructGeneration.cs:138
                        if (fix.Code.CodeElement.ElementId != null)                                                                         // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Code.CodeElement.ElementId = \"{fix.Code.CodeElement.ElementId}\";");                 // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Code.DisplayElement != null)                                                                                    // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Code.DisplayElement = new FhirString();");                                            // FhirConstructGeneration.cs:209
                        if (fix.Code.DisplayElement.Value != null)                                                                          // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Code.DisplayElement.Value = \"{fix.Code.DisplayElement.Value}\";");                   // FhirConstructGeneration.cs:138
                        if (fix.Code.DisplayElement.ElementId != null)                                                                      // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Code.DisplayElement.ElementId = \"{fix.Code.DisplayElement.ElementId}\";");           // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Code.UserSelectedElement != null)                                                                               // FhirConstructGeneration.cs:207
                    {                                                                                                                       // FhirConstructGeneration.cs:208
                            block.AppendCode($"retVal.Code.UserSelectedElement = new FhirBoolean();");                                      // FhirConstructGeneration.cs:209
                        if (fix.Code.UserSelectedElement.Value.HasValue == true)                                                            // FhirConstructGeneration.cs:69
                        {                                                                                                                   // FhirConstructGeneration.cs:70
                            if (fix.Code.UserSelectedElement.Value.Value == true)                                                           // FhirConstructGeneration.cs:71
                                block.AppendCode($"retVal.Code.UserSelectedElement.Value = true;");                                         // FhirConstructGeneration.cs:72
                            else                                                                                                            // FhirConstructGeneration.cs:73
                                block.AppendCode($"retVal.Code.UserSelectedElement.Value = false;");                                        // FhirConstructGeneration.cs:74
                        }                                                                                                                   // FhirConstructGeneration.cs:75
                        if (fix.Code.UserSelectedElement.ElementId != null)                                                                 // FhirConstructGeneration.cs:137
                            block.AppendCode($"retVal.Code.UserSelectedElement.ElementId = \"{fix.Code.UserSelectedElement.ElementId}\";"); // FhirConstructGeneration.cs:138
                    }                                                                                                                       // FhirConstructGeneration.cs:213
                    if (fix.Code.ElementId != null)                                                                                         // FhirConstructGeneration.cs:137
                        block.AppendCode($"retVal.Code.ElementId = \"{fix.Code.ElementId}\";");                                             // FhirConstructGeneration.cs:138
                }                                                                                                                           // FhirConstructGeneration.cs:213
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:338
            block                                                                                                                           // FhirConstructGeneration.cs:339
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:340
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:341
                ;                                                                                                                           // FhirConstructGeneration.cs:342
            return  true;                                                                                                                   // FhirConstructGeneration.cs:343
        }                                                                                                                                   // FhirConstructGeneration.cs:344
                                                                                                                                            // FhirConstructGeneration.cs:246
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:250
            Base64Binary fix,                                                                                                               // FhirConstructGeneration.cs:251
            String methodName,                                                                                                              // FhirConstructGeneration.cs:252
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:253
        {                                                                                                                                   // FhirConstructGeneration.cs:254
                                                                                                                                            // FhirConstructGeneration.cs:256
            block                                                                                                                           // FhirConstructGeneration.cs:257
                .AppendCode($"{methodAccess} Base64Binary {methodName}()")                                                                  // FhirConstructGeneration.cs:258
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:259
                .AppendCode("Base64Binary retVal = new Base64Binary();")                                                                    // FhirConstructGeneration.cs:260
                ;                                                                                                                           // FhirConstructGeneration.cs:261
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:262
            {                                                                                                                               // FhirConstructGeneration.cs:263
                if (fix.Value != null)                                                                                                      // FhirConstructGeneration.cs:81
                {                                                                                                                           // FhirConstructGeneration.cs:82
                    block.OpenBrace();                                                                                                      // FhirConstructGeneration.cs:83
                    block.AppendCode($"byte[] data = new byte[]");                                                                          // FhirConstructGeneration.cs:84
                    block.OpenBrace();                                                                                                      // FhirConstructGeneration.cs:85
                    Int32 i = 0;                                                                                                            // FhirConstructGeneration.cs:86
                    while (i < fix.Value.Length)                                                                                            // FhirConstructGeneration.cs:87
                    {                                                                                                                       // FhirConstructGeneration.cs:88
                        Int32 j = 0;                                                                                                        // FhirConstructGeneration.cs:89
                        StringBuilder sb = new StringBuilder();                                                                             // FhirConstructGeneration.cs:90
                        while ((i < fix.Value.Length) && (j < 32))                                                                          // FhirConstructGeneration.cs:91
                        {                                                                                                                   // FhirConstructGeneration.cs:92
                            sb.Append($"{fix.Value[i]}");                                                                                   // FhirConstructGeneration.cs:93
                            if (i < fix.Value.Length - 1) sb.Append(",");                                                                   // FhirConstructGeneration.cs:94
                            j += 1;                                                                                                         // FhirConstructGeneration.cs:95
                            i += 1;                                                                                                         // FhirConstructGeneration.cs:96
                        }                                                                                                                   // FhirConstructGeneration.cs:97
                        block.AppendCode($"{sb.ToString()}");                                                                               // FhirConstructGeneration.cs:98
                    }                                                                                                                       // FhirConstructGeneration.cs:99
                    block.CloseBrace(";");                                                                                                  // FhirConstructGeneration.cs:100
                    block.AppendCode($"retVal.Value = data;");                                                                              // FhirConstructGeneration.cs:101
                    block.CloseBrace(";");                                                                                                  // FhirConstructGeneration.cs:102
                }                                                                                                                           // FhirConstructGeneration.cs:103
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:269
            block                                                                                                                           // FhirConstructGeneration.cs:270
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:271
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:272
                ;                                                                                                                           // FhirConstructGeneration.cs:273
            return  true;                                                                                                                   // FhirConstructGeneration.cs:274
        }                                                                                                                                   // FhirConstructGeneration.cs:275
                                                                                                                                            // FhirConstructGeneration.cs:246
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:250
            FhirBoolean fix,                                                                                                                // FhirConstructGeneration.cs:251
            String methodName,                                                                                                              // FhirConstructGeneration.cs:252
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:253
        {                                                                                                                                   // FhirConstructGeneration.cs:254
                                                                                                                                            // FhirConstructGeneration.cs:256
            block                                                                                                                           // FhirConstructGeneration.cs:257
                .AppendCode($"{methodAccess} FhirBoolean {methodName}()")                                                                   // FhirConstructGeneration.cs:258
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:259
                .AppendCode("FhirBoolean retVal = new FhirBoolean();")                                                                      // FhirConstructGeneration.cs:260
                ;                                                                                                                           // FhirConstructGeneration.cs:261
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:262
            {                                                                                                                               // FhirConstructGeneration.cs:263
                if (fix.Value.HasValue == true)                                                                                             // FhirConstructGeneration.cs:69
                {                                                                                                                           // FhirConstructGeneration.cs:70
                    if (fix.Value.Value == true)                                                                                            // FhirConstructGeneration.cs:71
                        block.AppendCode($"retVal.Value = true;");                                                                          // FhirConstructGeneration.cs:72
                    else                                                                                                                    // FhirConstructGeneration.cs:73
                        block.AppendCode($"retVal.Value = false;");                                                                         // FhirConstructGeneration.cs:74
                }                                                                                                                           // FhirConstructGeneration.cs:75
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:269
            block                                                                                                                           // FhirConstructGeneration.cs:270
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:271
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:272
                ;                                                                                                                           // FhirConstructGeneration.cs:273
            return  true;                                                                                                                   // FhirConstructGeneration.cs:274
        }                                                                                                                                   // FhirConstructGeneration.cs:275
                                                                                                                                            // FhirConstructGeneration.cs:246
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:250
            Code fix,                                                                                                                       // FhirConstructGeneration.cs:251
            String methodName,                                                                                                              // FhirConstructGeneration.cs:252
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:253
        {                                                                                                                                   // FhirConstructGeneration.cs:254
                                                                                                                                            // FhirConstructGeneration.cs:256
            block                                                                                                                           // FhirConstructGeneration.cs:257
                .AppendCode($"{methodAccess} Code {methodName}()")                                                                          // FhirConstructGeneration.cs:258
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:259
                .AppendCode("Code retVal = new Code();")                                                                                    // FhirConstructGeneration.cs:260
                ;                                                                                                                           // FhirConstructGeneration.cs:261
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:262
            {                                                                                                                               // FhirConstructGeneration.cs:263
                if (fix.Value != null)                                                                                                      // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.Value = \"{fix.Value}\";");                                                                   // FhirConstructGeneration.cs:138
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:269
            block                                                                                                                           // FhirConstructGeneration.cs:270
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:271
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:272
                ;                                                                                                                           // FhirConstructGeneration.cs:273
            return  true;                                                                                                                   // FhirConstructGeneration.cs:274
        }                                                                                                                                   // FhirConstructGeneration.cs:275
                                                                                                                                            // FhirConstructGeneration.cs:246
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:250
            Date fix,                                                                                                                       // FhirConstructGeneration.cs:251
            String methodName,                                                                                                              // FhirConstructGeneration.cs:252
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:253
        {                                                                                                                                   // FhirConstructGeneration.cs:254
                                                                                                                                            // FhirConstructGeneration.cs:256
            block                                                                                                                           // FhirConstructGeneration.cs:257
                .AppendCode($"{methodAccess} Date {methodName}()")                                                                          // FhirConstructGeneration.cs:258
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:259
                .AppendCode("Date retVal = new Date();")                                                                                    // FhirConstructGeneration.cs:260
                ;                                                                                                                           // FhirConstructGeneration.cs:261
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:262
            {                                                                                                                               // FhirConstructGeneration.cs:263
                if (fix.Value != null)                                                                                                      // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.Value = \"{fix.Value}\";");                                                                   // FhirConstructGeneration.cs:138
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:269
            block                                                                                                                           // FhirConstructGeneration.cs:270
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:271
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:272
                ;                                                                                                                           // FhirConstructGeneration.cs:273
            return  true;                                                                                                                   // FhirConstructGeneration.cs:274
        }                                                                                                                                   // FhirConstructGeneration.cs:275
                                                                                                                                            // FhirConstructGeneration.cs:246
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:250
            FhirDateTime fix,                                                                                                               // FhirConstructGeneration.cs:251
            String methodName,                                                                                                              // FhirConstructGeneration.cs:252
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:253
        {                                                                                                                                   // FhirConstructGeneration.cs:254
                                                                                                                                            // FhirConstructGeneration.cs:256
            block                                                                                                                           // FhirConstructGeneration.cs:257
                .AppendCode($"{methodAccess} FhirDateTime {methodName}()")                                                                  // FhirConstructGeneration.cs:258
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:259
                .AppendCode("FhirDateTime retVal = new FhirDateTime();")                                                                    // FhirConstructGeneration.cs:260
                ;                                                                                                                           // FhirConstructGeneration.cs:261
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:262
            {                                                                                                                               // FhirConstructGeneration.cs:263
                if (fix.Value != null)                                                                                                      // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.Value = \"{fix.Value}\";");                                                                   // FhirConstructGeneration.cs:138
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:269
            block                                                                                                                           // FhirConstructGeneration.cs:270
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:271
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:272
                ;                                                                                                                           // FhirConstructGeneration.cs:273
            return  true;                                                                                                                   // FhirConstructGeneration.cs:274
        }                                                                                                                                   // FhirConstructGeneration.cs:275
                                                                                                                                            // FhirConstructGeneration.cs:246
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:250
            FhirDecimal fix,                                                                                                                // FhirConstructGeneration.cs:251
            String methodName,                                                                                                              // FhirConstructGeneration.cs:252
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:253
        {                                                                                                                                   // FhirConstructGeneration.cs:254
                                                                                                                                            // FhirConstructGeneration.cs:256
            block                                                                                                                           // FhirConstructGeneration.cs:257
                .AppendCode($"{methodAccess} FhirDecimal {methodName}()")                                                                   // FhirConstructGeneration.cs:258
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:259
                .AppendCode("FhirDecimal retVal = new FhirDecimal();")                                                                      // FhirConstructGeneration.cs:260
                ;                                                                                                                           // FhirConstructGeneration.cs:261
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:262
            {                                                                                                                               // FhirConstructGeneration.cs:263
                if (fix.Value.HasValue == true)                                                                                             // FhirConstructGeneration.cs:123
                    block.AppendCode($"retVal.Value = new Nullable<decimal>((decimal) {fix.Value.Value});");                                // FhirConstructGeneration.cs:124
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:269
            block                                                                                                                           // FhirConstructGeneration.cs:270
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:271
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:272
                ;                                                                                                                           // FhirConstructGeneration.cs:273
            return  true;                                                                                                                   // FhirConstructGeneration.cs:274
        }                                                                                                                                   // FhirConstructGeneration.cs:275
                                                                                                                                            // FhirConstructGeneration.cs:246
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:250
            Id fix,                                                                                                                         // FhirConstructGeneration.cs:251
            String methodName,                                                                                                              // FhirConstructGeneration.cs:252
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:253
        {                                                                                                                                   // FhirConstructGeneration.cs:254
                                                                                                                                            // FhirConstructGeneration.cs:256
            block                                                                                                                           // FhirConstructGeneration.cs:257
                .AppendCode($"{methodAccess} Id {methodName}()")                                                                            // FhirConstructGeneration.cs:258
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:259
                .AppendCode("Id retVal = new Id();")                                                                                        // FhirConstructGeneration.cs:260
                ;                                                                                                                           // FhirConstructGeneration.cs:261
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:262
            {                                                                                                                               // FhirConstructGeneration.cs:263
                if (fix.Value != null)                                                                                                      // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.Value = \"{fix.Value}\";");                                                                   // FhirConstructGeneration.cs:138
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:269
            block                                                                                                                           // FhirConstructGeneration.cs:270
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:271
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:272
                ;                                                                                                                           // FhirConstructGeneration.cs:273
            return  true;                                                                                                                   // FhirConstructGeneration.cs:274
        }                                                                                                                                   // FhirConstructGeneration.cs:275
                                                                                                                                            // FhirConstructGeneration.cs:246
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:250
            Instant fix,                                                                                                                    // FhirConstructGeneration.cs:251
            String methodName,                                                                                                              // FhirConstructGeneration.cs:252
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:253
        {                                                                                                                                   // FhirConstructGeneration.cs:254
                                                                                                                                            // FhirConstructGeneration.cs:256
            block                                                                                                                           // FhirConstructGeneration.cs:257
                .AppendCode($"{methodAccess} Instant {methodName}()")                                                                       // FhirConstructGeneration.cs:258
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:259
                .AppendCode("Instant retVal = new Instant();")                                                                              // FhirConstructGeneration.cs:260
                ;                                                                                                                           // FhirConstructGeneration.cs:261
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:262
            {                                                                                                                               // FhirConstructGeneration.cs:263
                if (fix.Value.HasValue == true)                                                                                             // FhirConstructGeneration.cs:109
                {                                                                                                                           // FhirConstructGeneration.cs:110
                    DateTimeOffset x = fix.Value.Value;                                                                                     // FhirConstructGeneration.cs:111
                    block                                                                                                                   // FhirConstructGeneration.cs:112
                        .AppendCode($"retVal.Value = new DateTimeOffset({x.Year}, {x.Month}, {x.Day},")                                     // FhirConstructGeneration.cs:113
                        .AppendCode($"    {x.Hour}, {x.Minute}, {x.Second}, {x.Millisecond},")                                              // FhirConstructGeneration.cs:114
                        .AppendCode($"    new TimeSpan({x.Offset.Hours}, {x.Offset.Minutes}, {x.Offset.Seconds}));")                        // FhirConstructGeneration.cs:115
                    ;                                                                                                                       // FhirConstructGeneration.cs:116
                }                                                                                                                           // FhirConstructGeneration.cs:117
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:269
            block                                                                                                                           // FhirConstructGeneration.cs:270
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:271
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:272
                ;                                                                                                                           // FhirConstructGeneration.cs:273
            return  true;                                                                                                                   // FhirConstructGeneration.cs:274
        }                                                                                                                                   // FhirConstructGeneration.cs:275
                                                                                                                                            // FhirConstructGeneration.cs:246
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:250
            Integer fix,                                                                                                                    // FhirConstructGeneration.cs:251
            String methodName,                                                                                                              // FhirConstructGeneration.cs:252
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:253
        {                                                                                                                                   // FhirConstructGeneration.cs:254
                                                                                                                                            // FhirConstructGeneration.cs:256
            block                                                                                                                           // FhirConstructGeneration.cs:257
                .AppendCode($"{methodAccess} Integer {methodName}()")                                                                       // FhirConstructGeneration.cs:258
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:259
                .AppendCode("Integer retVal = new Integer();")                                                                              // FhirConstructGeneration.cs:260
                ;                                                                                                                           // FhirConstructGeneration.cs:261
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:262
            {                                                                                                                               // FhirConstructGeneration.cs:263
                if (fix.Value.HasValue == true)                                                                                             // FhirConstructGeneration.cs:130
                    block.AppendCode($"retVal.Value = new Nullable<int>((int) {fix.Value.Value});");                                        // FhirConstructGeneration.cs:131
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:269
            block                                                                                                                           // FhirConstructGeneration.cs:270
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:271
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:272
                ;                                                                                                                           // FhirConstructGeneration.cs:273
            return  true;                                                                                                                   // FhirConstructGeneration.cs:274
        }                                                                                                                                   // FhirConstructGeneration.cs:275
                                                                                                                                            // FhirConstructGeneration.cs:246
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:250
            Markdown fix,                                                                                                                   // FhirConstructGeneration.cs:251
            String methodName,                                                                                                              // FhirConstructGeneration.cs:252
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:253
        {                                                                                                                                   // FhirConstructGeneration.cs:254
                                                                                                                                            // FhirConstructGeneration.cs:256
            block                                                                                                                           // FhirConstructGeneration.cs:257
                .AppendCode($"{methodAccess} Markdown {methodName}()")                                                                      // FhirConstructGeneration.cs:258
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:259
                .AppendCode("Markdown retVal = new Markdown();")                                                                            // FhirConstructGeneration.cs:260
                ;                                                                                                                           // FhirConstructGeneration.cs:261
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:262
            {                                                                                                                               // FhirConstructGeneration.cs:263
                if (fix.Value != null)                                                                                                      // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.Value = \"{fix.Value}\";");                                                                   // FhirConstructGeneration.cs:138
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:269
            block                                                                                                                           // FhirConstructGeneration.cs:270
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:271
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:272
                ;                                                                                                                           // FhirConstructGeneration.cs:273
            return  true;                                                                                                                   // FhirConstructGeneration.cs:274
        }                                                                                                                                   // FhirConstructGeneration.cs:275
                                                                                                                                            // FhirConstructGeneration.cs:246
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:250
            Oid fix,                                                                                                                        // FhirConstructGeneration.cs:251
            String methodName,                                                                                                              // FhirConstructGeneration.cs:252
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:253
        {                                                                                                                                   // FhirConstructGeneration.cs:254
                                                                                                                                            // FhirConstructGeneration.cs:256
            block                                                                                                                           // FhirConstructGeneration.cs:257
                .AppendCode($"{methodAccess} Oid {methodName}()")                                                                           // FhirConstructGeneration.cs:258
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:259
                .AppendCode("Oid retVal = new Oid();")                                                                                      // FhirConstructGeneration.cs:260
                ;                                                                                                                           // FhirConstructGeneration.cs:261
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:262
            {                                                                                                                               // FhirConstructGeneration.cs:263
                if (fix.Value != null)                                                                                                      // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.Value = \"{fix.Value}\";");                                                                   // FhirConstructGeneration.cs:138
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:269
            block                                                                                                                           // FhirConstructGeneration.cs:270
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:271
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:272
                ;                                                                                                                           // FhirConstructGeneration.cs:273
            return  true;                                                                                                                   // FhirConstructGeneration.cs:274
        }                                                                                                                                   // FhirConstructGeneration.cs:275
                                                                                                                                            // FhirConstructGeneration.cs:246
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:250
            PositiveInt fix,                                                                                                                // FhirConstructGeneration.cs:251
            String methodName,                                                                                                              // FhirConstructGeneration.cs:252
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:253
        {                                                                                                                                   // FhirConstructGeneration.cs:254
                                                                                                                                            // FhirConstructGeneration.cs:256
            block                                                                                                                           // FhirConstructGeneration.cs:257
                .AppendCode($"{methodAccess} PositiveInt {methodName}()")                                                                   // FhirConstructGeneration.cs:258
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:259
                .AppendCode("PositiveInt retVal = new PositiveInt();")                                                                      // FhirConstructGeneration.cs:260
                ;                                                                                                                           // FhirConstructGeneration.cs:261
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:262
            {                                                                                                                               // FhirConstructGeneration.cs:263
                if (fix.Value.HasValue == true)                                                                                             // FhirConstructGeneration.cs:130
                    block.AppendCode($"retVal.Value = new Nullable<int>((int) {fix.Value.Value});");                                        // FhirConstructGeneration.cs:131
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:269
            block                                                                                                                           // FhirConstructGeneration.cs:270
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:271
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:272
                ;                                                                                                                           // FhirConstructGeneration.cs:273
            return  true;                                                                                                                   // FhirConstructGeneration.cs:274
        }                                                                                                                                   // FhirConstructGeneration.cs:275
                                                                                                                                            // FhirConstructGeneration.cs:246
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:250
            FhirString fix,                                                                                                                 // FhirConstructGeneration.cs:251
            String methodName,                                                                                                              // FhirConstructGeneration.cs:252
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:253
        {                                                                                                                                   // FhirConstructGeneration.cs:254
                                                                                                                                            // FhirConstructGeneration.cs:256
            block                                                                                                                           // FhirConstructGeneration.cs:257
                .AppendCode($"{methodAccess} FhirString {methodName}()")                                                                    // FhirConstructGeneration.cs:258
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:259
                .AppendCode("FhirString retVal = new FhirString();")                                                                        // FhirConstructGeneration.cs:260
                ;                                                                                                                           // FhirConstructGeneration.cs:261
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:262
            {                                                                                                                               // FhirConstructGeneration.cs:263
                if (fix.Value != null)                                                                                                      // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.Value = \"{fix.Value}\";");                                                                   // FhirConstructGeneration.cs:138
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:269
            block                                                                                                                           // FhirConstructGeneration.cs:270
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:271
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:272
                ;                                                                                                                           // FhirConstructGeneration.cs:273
            return  true;                                                                                                                   // FhirConstructGeneration.cs:274
        }                                                                                                                                   // FhirConstructGeneration.cs:275
                                                                                                                                            // FhirConstructGeneration.cs:246
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:250
            Time fix,                                                                                                                       // FhirConstructGeneration.cs:251
            String methodName,                                                                                                              // FhirConstructGeneration.cs:252
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:253
        {                                                                                                                                   // FhirConstructGeneration.cs:254
                                                                                                                                            // FhirConstructGeneration.cs:256
            block                                                                                                                           // FhirConstructGeneration.cs:257
                .AppendCode($"{methodAccess} Time {methodName}()")                                                                          // FhirConstructGeneration.cs:258
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:259
                .AppendCode("Time retVal = new Time();")                                                                                    // FhirConstructGeneration.cs:260
                ;                                                                                                                           // FhirConstructGeneration.cs:261
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:262
            {                                                                                                                               // FhirConstructGeneration.cs:263
                if (fix.Value != null)                                                                                                      // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.Value = \"{fix.Value}\";");                                                                   // FhirConstructGeneration.cs:138
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:269
            block                                                                                                                           // FhirConstructGeneration.cs:270
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:271
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:272
                ;                                                                                                                           // FhirConstructGeneration.cs:273
            return  true;                                                                                                                   // FhirConstructGeneration.cs:274
        }                                                                                                                                   // FhirConstructGeneration.cs:275
                                                                                                                                            // FhirConstructGeneration.cs:246
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:250
            UnsignedInt fix,                                                                                                                // FhirConstructGeneration.cs:251
            String methodName,                                                                                                              // FhirConstructGeneration.cs:252
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:253
        {                                                                                                                                   // FhirConstructGeneration.cs:254
                                                                                                                                            // FhirConstructGeneration.cs:256
            block                                                                                                                           // FhirConstructGeneration.cs:257
                .AppendCode($"{methodAccess} UnsignedInt {methodName}()")                                                                   // FhirConstructGeneration.cs:258
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:259
                .AppendCode("UnsignedInt retVal = new UnsignedInt();")                                                                      // FhirConstructGeneration.cs:260
                ;                                                                                                                           // FhirConstructGeneration.cs:261
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:262
            {                                                                                                                               // FhirConstructGeneration.cs:263
                if (fix.Value.HasValue == true)                                                                                             // FhirConstructGeneration.cs:130
                    block.AppendCode($"retVal.Value = new Nullable<int>((int) {fix.Value.Value});");                                        // FhirConstructGeneration.cs:131
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:269
            block                                                                                                                           // FhirConstructGeneration.cs:270
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:271
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:272
                ;                                                                                                                           // FhirConstructGeneration.cs:273
            return  true;                                                                                                                   // FhirConstructGeneration.cs:274
        }                                                                                                                                   // FhirConstructGeneration.cs:275
                                                                                                                                            // FhirConstructGeneration.cs:246
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:250
            FhirUri fix,                                                                                                                    // FhirConstructGeneration.cs:251
            String methodName,                                                                                                              // FhirConstructGeneration.cs:252
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:253
        {                                                                                                                                   // FhirConstructGeneration.cs:254
                                                                                                                                            // FhirConstructGeneration.cs:256
            block                                                                                                                           // FhirConstructGeneration.cs:257
                .AppendCode($"{methodAccess} FhirUri {methodName}()")                                                                       // FhirConstructGeneration.cs:258
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:259
                .AppendCode("FhirUri retVal = new FhirUri();")                                                                              // FhirConstructGeneration.cs:260
                ;                                                                                                                           // FhirConstructGeneration.cs:261
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:262
            {                                                                                                                               // FhirConstructGeneration.cs:263
                if (fix.Value != null)                                                                                                      // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.Value = \"{fix.Value}\";");                                                                   // FhirConstructGeneration.cs:138
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:269
            block                                                                                                                           // FhirConstructGeneration.cs:270
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:271
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:272
                ;                                                                                                                           // FhirConstructGeneration.cs:273
            return  true;                                                                                                                   // FhirConstructGeneration.cs:274
        }                                                                                                                                   // FhirConstructGeneration.cs:275
                                                                                                                                            // FhirConstructGeneration.cs:246
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:250
            Uuid fix,                                                                                                                       // FhirConstructGeneration.cs:251
            String methodName,                                                                                                              // FhirConstructGeneration.cs:252
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:253
        {                                                                                                                                   // FhirConstructGeneration.cs:254
                                                                                                                                            // FhirConstructGeneration.cs:256
            block                                                                                                                           // FhirConstructGeneration.cs:257
                .AppendCode($"{methodAccess} Uuid {methodName}()")                                                                          // FhirConstructGeneration.cs:258
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:259
                .AppendCode("Uuid retVal = new Uuid();")                                                                                    // FhirConstructGeneration.cs:260
                ;                                                                                                                           // FhirConstructGeneration.cs:261
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:262
            {                                                                                                                               // FhirConstructGeneration.cs:263
                if (fix.Value != null)                                                                                                      // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.Value = \"{fix.Value}\";");                                                                   // FhirConstructGeneration.cs:138
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:269
            block                                                                                                                           // FhirConstructGeneration.cs:270
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:271
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:272
                ;                                                                                                                           // FhirConstructGeneration.cs:273
            return  true;                                                                                                                   // FhirConstructGeneration.cs:274
        }                                                                                                                                   // FhirConstructGeneration.cs:275
                                                                                                                                            // FhirConstructGeneration.cs:246
        /// <summary>
        /// Return c# text to create indicated element.
        /// </summary>
        static public bool Construct(CodeBlockNested block,                                                                                 // FhirConstructGeneration.cs:250
            XHtml fix,                                                                                                                      // FhirConstructGeneration.cs:251
            String methodName,                                                                                                              // FhirConstructGeneration.cs:252
            String methodAccess = "public")                                                                                                 // FhirConstructGeneration.cs:253
        {                                                                                                                                   // FhirConstructGeneration.cs:254
                                                                                                                                            // FhirConstructGeneration.cs:256
            block                                                                                                                           // FhirConstructGeneration.cs:257
                .AppendCode($"{methodAccess} XHtml {methodName}()")                                                                         // FhirConstructGeneration.cs:258
                .OpenBrace()                                                                                                                // FhirConstructGeneration.cs:259
                .AppendCode("XHtml retVal = new XHtml();")                                                                                  // FhirConstructGeneration.cs:260
                ;                                                                                                                           // FhirConstructGeneration.cs:261
            if (fix != null)                                                                                                                // FhirConstructGeneration.cs:262
            {                                                                                                                               // FhirConstructGeneration.cs:263
                if (fix.Value != null)                                                                                                      // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.Value = \"{fix.Value}\";");                                                                   // FhirConstructGeneration.cs:138
                if (fix.ElementId != null)                                                                                                  // FhirConstructGeneration.cs:137
                    block.AppendCode($"retVal.ElementId = \"{fix.ElementId}\";");                                                           // FhirConstructGeneration.cs:138
            }                                                                                                                               // FhirConstructGeneration.cs:269
            block                                                                                                                           // FhirConstructGeneration.cs:270
                .AppendCode("return retVal;")                                                                                               // FhirConstructGeneration.cs:271
                .CloseBrace()                                                                                                               // FhirConstructGeneration.cs:272
                ;                                                                                                                           // FhirConstructGeneration.cs:273
            return  true;                                                                                                                   // FhirConstructGeneration.cs:274
        }                                                                                                                                   // FhirConstructGeneration.cs:275
    }                                                                                                                                       // FhirConstructGeneration.cs:384
}                                                                                                                                           // FhirConstructGeneration.cs:385
