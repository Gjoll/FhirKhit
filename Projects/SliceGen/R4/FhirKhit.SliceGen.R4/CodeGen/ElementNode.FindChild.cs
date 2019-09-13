using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using FhirKhit.Tools;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Model;
using Hl7.Fhir.Support.Model;
using System.Diagnostics;
using Hl7.FhirPath;
                                                                                                                                            // CodeGeneration.cs:253
namespace FhirKhit.SliceGen.R4
{                                                                                                                                           // CodeGeneration.cs:255
    public partial class ElementNode                                                                                                        // CodeGeneration.cs:256
    {                                                                                                                                       // CodeGeneration.cs:257
        /// <summary>
        /// Create ElementNode for child of common/primitive Fhir data type elements
        /// </summary>
        public ElementNode FindCommonChild(String parentPath, String childName)                                                             // CodeGeneration.cs:271
        {                                                                                                                                   // CodeGeneration.cs:272
            switch (this.FhirItemType.FriendlyName())                                                                                       // CodeGeneration.cs:273
            {                                                                                                                               // CodeGeneration.cs:274
                case "Ratio": return FindChildRatio(parentPath, childName);                                                                 // CodeGeneration.cs:167
                case "Period": return FindChildPeriod(parentPath, childName);                                                               // CodeGeneration.cs:167
                case "Range": return FindChildRange(parentPath, childName);                                                                 // CodeGeneration.cs:167
                case "Attachment": return FindChildAttachment(parentPath, childName);                                                       // CodeGeneration.cs:167
                case "Identifier": return FindChildIdentifier(parentPath, childName);                                                       // CodeGeneration.cs:167
                case "Annotation": return FindChildAnnotation(parentPath, childName);                                                       // CodeGeneration.cs:167
                case "HumanName": return FindChildHumanName(parentPath, childName);                                                         // CodeGeneration.cs:167
                case "CodeableConcept": return FindChildCodeableConcept(parentPath, childName);                                             // CodeGeneration.cs:167
                case "ContactPoint": return FindChildContactPoint(parentPath, childName);                                                   // CodeGeneration.cs:167
                case "Coding": return FindChildCoding(parentPath, childName);                                                               // CodeGeneration.cs:167
                case "Money": return FindChildMoney(parentPath, childName);                                                                 // CodeGeneration.cs:167
                case "Address": return FindChildAddress(parentPath, childName);                                                             // CodeGeneration.cs:167
                case "Timing": return FindChildTiming(parentPath, childName);                                                               // CodeGeneration.cs:167
                case "Quantity": return FindChildQuantity(parentPath, childName);                                                           // CodeGeneration.cs:167
                case "SampledData": return FindChildSampledData(parentPath, childName);                                                     // CodeGeneration.cs:167
                case "Signature": return FindChildSignature(parentPath, childName);                                                         // CodeGeneration.cs:167
                case "Age": return FindChildAge(parentPath, childName);                                                                     // CodeGeneration.cs:167
                case "Distance": return FindChildDistance(parentPath, childName);                                                           // CodeGeneration.cs:167
                case "Duration": return FindChildDuration(parentPath, childName);                                                           // CodeGeneration.cs:167
                case "Count": return FindChildCount(parentPath, childName);                                                                 // CodeGeneration.cs:167
                case "MoneyQuantity": return FindChildMoneyQuantity(parentPath, childName);                                                 // CodeGeneration.cs:167
                case "SimpleQuantity": return FindChildSimpleQuantity(parentPath, childName);                                               // CodeGeneration.cs:167
                case "Extension": return FindChildExtension(parentPath, childName);                                                         // CodeGeneration.cs:167
                default: return null;                                                                                                       // CodeGeneration.cs:304
            }                                                                                                                               // CodeGeneration.cs:305
        }                                                                                                                                   // CodeGeneration.cs:306
                                                                                                                                            // CodeGeneration.cs:171
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementNode FindChildRatio(String parentPath, String childName)                                                                     // CodeGeneration.cs:175
        {                                                                                                                                   // CodeGeneration.cs:176
            ElementNode retVal;                                                                                                             // CodeGeneration.cs:177
            switch (childName)                                                                                                              // CodeGeneration.cs:178
            {                                                                                                                               // CodeGeneration.cs:179
                case "numerator":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.numerator",                                                                                   // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(Quantity), nameof(Ratio.Numerator));                                           // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "denominator":                                                                                                         // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.denominator",                                                                                 // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(Quantity), nameof(Ratio.Denominator));                                         // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "id":                                                                                                                  // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.id",                                                                                          // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(string), nameof(Ratio.ElementId));                                             // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "extension":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.extension",                                                                                   // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(Ratio.Extension));                                    // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                default: return null;                                                                                                       // CodeGeneration.cs:223
            }                                                                                                                               // CodeGeneration.cs:224
            this.childNodeDictionary.Add(childName, retVal);                                                                                // CodeGeneration.cs:225
            return retVal;                                                                                                                  // CodeGeneration.cs:226
        }                                                                                                                                   // CodeGeneration.cs:227
                                                                                                                                            // CodeGeneration.cs:171
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementNode FindChildPeriod(String parentPath, String childName)                                                                    // CodeGeneration.cs:175
        {                                                                                                                                   // CodeGeneration.cs:176
            ElementNode retVal;                                                                                                             // CodeGeneration.cs:177
            switch (childName)                                                                                                              // CodeGeneration.cs:178
            {                                                                                                                               // CodeGeneration.cs:179
                case "start":                                                                                                               // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.start",                                                                                       // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirDateTime), nameof(Period.StartElement));                                   // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "end":                                                                                                                 // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.end",                                                                                         // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirDateTime), nameof(Period.EndElement));                                     // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "id":                                                                                                                  // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.id",                                                                                          // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(string), nameof(Period.ElementId));                                            // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "extension":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.extension",                                                                                   // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(Period.Extension));                                   // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                default: return null;                                                                                                       // CodeGeneration.cs:223
            }                                                                                                                               // CodeGeneration.cs:224
            this.childNodeDictionary.Add(childName, retVal);                                                                                // CodeGeneration.cs:225
            return retVal;                                                                                                                  // CodeGeneration.cs:226
        }                                                                                                                                   // CodeGeneration.cs:227
                                                                                                                                            // CodeGeneration.cs:171
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementNode FindChildRange(String parentPath, String childName)                                                                     // CodeGeneration.cs:175
        {                                                                                                                                   // CodeGeneration.cs:176
            ElementNode retVal;                                                                                                             // CodeGeneration.cs:177
            switch (childName)                                                                                                              // CodeGeneration.cs:178
            {                                                                                                                               // CodeGeneration.cs:179
                case "low":                                                                                                                 // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.low",                                                                                         // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(SimpleQuantity), nameof(Range.Low));                                           // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "high":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.high",                                                                                        // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(SimpleQuantity), nameof(Range.High));                                          // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "id":                                                                                                                  // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.id",                                                                                          // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(string), nameof(Range.ElementId));                                             // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "extension":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.extension",                                                                                   // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(Range.Extension));                                    // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                default: return null;                                                                                                       // CodeGeneration.cs:223
            }                                                                                                                               // CodeGeneration.cs:224
            this.childNodeDictionary.Add(childName, retVal);                                                                                // CodeGeneration.cs:225
            return retVal;                                                                                                                  // CodeGeneration.cs:226
        }                                                                                                                                   // CodeGeneration.cs:227
                                                                                                                                            // CodeGeneration.cs:171
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementNode FindChildAttachment(String parentPath, String childName)                                                                // CodeGeneration.cs:175
        {                                                                                                                                   // CodeGeneration.cs:176
            ElementNode retVal;                                                                                                             // CodeGeneration.cs:177
            switch (childName)                                                                                                              // CodeGeneration.cs:178
            {                                                                                                                               // CodeGeneration.cs:179
                case "contentType":                                                                                                         // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.contentType",                                                                                 // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(Code), nameof(Attachment.ContentTypeElement));                                 // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "language":                                                                                                            // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.language",                                                                                    // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(Code), nameof(Attachment.LanguageElement));                                    // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "data":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.data",                                                                                        // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(Base64Binary), nameof(Attachment.DataElement));                                // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "url":                                                                                                                 // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.url",                                                                                         // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirUrl), nameof(Attachment.UrlElement));                                      // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "size":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.size",                                                                                        // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(UnsignedInt), nameof(Attachment.SizeElement));                                 // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "hash":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.hash",                                                                                        // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(Base64Binary), nameof(Attachment.HashElement));                                // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "title":                                                                                                               // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.title",                                                                                       // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirString), nameof(Attachment.TitleElement));                                 // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "creation":                                                                                                            // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.creation",                                                                                    // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirDateTime), nameof(Attachment.CreationElement));                            // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "id":                                                                                                                  // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.id",                                                                                          // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(string), nameof(Attachment.ElementId));                                        // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "extension":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.extension",                                                                                   // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(Attachment.Extension));                               // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                default: return null;                                                                                                       // CodeGeneration.cs:223
            }                                                                                                                               // CodeGeneration.cs:224
            this.childNodeDictionary.Add(childName, retVal);                                                                                // CodeGeneration.cs:225
            return retVal;                                                                                                                  // CodeGeneration.cs:226
        }                                                                                                                                   // CodeGeneration.cs:227
                                                                                                                                            // CodeGeneration.cs:171
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementNode FindChildIdentifier(String parentPath, String childName)                                                                // CodeGeneration.cs:175
        {                                                                                                                                   // CodeGeneration.cs:176
            ElementNode retVal;                                                                                                             // CodeGeneration.cs:177
            switch (childName)                                                                                                              // CodeGeneration.cs:178
            {                                                                                                                               // CodeGeneration.cs:179
                case "use":                                                                                                                 // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.use",                                                                                         // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(Code<Identifier.IdentifierUse>), nameof(Identifier.UseElement));               // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "type":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.type",                                                                                        // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(CodeableConcept), nameof(Identifier.Type));                                    // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "system":                                                                                                              // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.system",                                                                                      // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirUri), nameof(Identifier.SystemElement));                                   // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "value":                                                                                                               // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.value",                                                                                       // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirString), nameof(Identifier.ValueElement));                                 // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "period":                                                                                                              // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.period",                                                                                      // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(Period), nameof(Identifier.Period));                                           // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "assigner":                                                                                                            // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.assigner",                                                                                    // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(ResourceReference), nameof(Identifier.Assigner));                              // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "id":                                                                                                                  // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.id",                                                                                          // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(string), nameof(Identifier.ElementId));                                        // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "extension":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.extension",                                                                                   // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(Identifier.Extension));                               // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                default: return null;                                                                                                       // CodeGeneration.cs:223
            }                                                                                                                               // CodeGeneration.cs:224
            this.childNodeDictionary.Add(childName, retVal);                                                                                // CodeGeneration.cs:225
            return retVal;                                                                                                                  // CodeGeneration.cs:226
        }                                                                                                                                   // CodeGeneration.cs:227
                                                                                                                                            // CodeGeneration.cs:171
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementNode FindChildAnnotation(String parentPath, String childName)                                                                // CodeGeneration.cs:175
        {                                                                                                                                   // CodeGeneration.cs:176
            ElementNode retVal;                                                                                                             // CodeGeneration.cs:177
            switch (childName)                                                                                                              // CodeGeneration.cs:178
            {                                                                                                                               // CodeGeneration.cs:179
                case "author":                                                                                                              // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.author",                                                                                      // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(Element), nameof(Annotation.Author));                                          // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "time":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.time",                                                                                        // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirDateTime), nameof(Annotation.TimeElement));                                // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "text":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.text",                                                                                        // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(Markdown), nameof(Annotation.Text));                                           // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "id":                                                                                                                  // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.id",                                                                                          // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(string), nameof(Annotation.ElementId));                                        // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "extension":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.extension",                                                                                   // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(Annotation.Extension));                               // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                default: return null;                                                                                                       // CodeGeneration.cs:223
            }                                                                                                                               // CodeGeneration.cs:224
            this.childNodeDictionary.Add(childName, retVal);                                                                                // CodeGeneration.cs:225
            return retVal;                                                                                                                  // CodeGeneration.cs:226
        }                                                                                                                                   // CodeGeneration.cs:227
                                                                                                                                            // CodeGeneration.cs:171
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementNode FindChildHumanName(String parentPath, String childName)                                                                 // CodeGeneration.cs:175
        {                                                                                                                                   // CodeGeneration.cs:176
            ElementNode retVal;                                                                                                             // CodeGeneration.cs:177
            switch (childName)                                                                                                              // CodeGeneration.cs:178
            {                                                                                                                               // CodeGeneration.cs:179
                case "use":                                                                                                                 // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.use",                                                                                         // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(Code<HumanName.NameUse>), nameof(HumanName.UseElement));                       // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "text":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.text",                                                                                        // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirString), nameof(HumanName.TextElement));                                   // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "family":                                                                                                              // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.family",                                                                                      // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirString), nameof(HumanName.FamilyElement));                                 // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "given":                                                                                                               // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.given",                                                                                       // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(List<FhirString>), nameof(HumanName.GivenElement));                            // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "prefix":                                                                                                              // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.prefix",                                                                                      // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(List<FhirString>), nameof(HumanName.PrefixElement));                           // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "suffix":                                                                                                              // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.suffix",                                                                                      // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(List<FhirString>), nameof(HumanName.SuffixElement));                           // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "period":                                                                                                              // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.period",                                                                                      // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(Period), nameof(HumanName.Period));                                            // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "id":                                                                                                                  // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.id",                                                                                          // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(string), nameof(HumanName.ElementId));                                         // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "extension":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.extension",                                                                                   // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(HumanName.Extension));                                // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                default: return null;                                                                                                       // CodeGeneration.cs:223
            }                                                                                                                               // CodeGeneration.cs:224
            this.childNodeDictionary.Add(childName, retVal);                                                                                // CodeGeneration.cs:225
            return retVal;                                                                                                                  // CodeGeneration.cs:226
        }                                                                                                                                   // CodeGeneration.cs:227
                                                                                                                                            // CodeGeneration.cs:171
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementNode FindChildCodeableConcept(String parentPath, String childName)                                                           // CodeGeneration.cs:175
        {                                                                                                                                   // CodeGeneration.cs:176
            ElementNode retVal;                                                                                                             // CodeGeneration.cs:177
            switch (childName)                                                                                                              // CodeGeneration.cs:178
            {                                                                                                                               // CodeGeneration.cs:179
                case "coding":                                                                                                              // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.coding",                                                                                      // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(List<Coding>), nameof(CodeableConcept.Coding));                                // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "text":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.text",                                                                                        // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirString), nameof(CodeableConcept.TextElement));                             // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "id":                                                                                                                  // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.id",                                                                                          // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(string), nameof(CodeableConcept.ElementId));                                   // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "extension":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.extension",                                                                                   // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(CodeableConcept.Extension));                          // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                default: return null;                                                                                                       // CodeGeneration.cs:223
            }                                                                                                                               // CodeGeneration.cs:224
            this.childNodeDictionary.Add(childName, retVal);                                                                                // CodeGeneration.cs:225
            return retVal;                                                                                                                  // CodeGeneration.cs:226
        }                                                                                                                                   // CodeGeneration.cs:227
                                                                                                                                            // CodeGeneration.cs:171
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementNode FindChildContactPoint(String parentPath, String childName)                                                              // CodeGeneration.cs:175
        {                                                                                                                                   // CodeGeneration.cs:176
            ElementNode retVal;                                                                                                             // CodeGeneration.cs:177
            switch (childName)                                                                                                              // CodeGeneration.cs:178
            {                                                                                                                               // CodeGeneration.cs:179
                case "system":                                                                                                              // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.system",                                                                                      // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(Code<ContactPoint.ContactPointSystem>), nameof(ContactPoint.SystemElement));   // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "value":                                                                                                               // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.value",                                                                                       // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirString), nameof(ContactPoint.ValueElement));                               // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "use":                                                                                                                 // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.use",                                                                                         // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(Code<ContactPoint.ContactPointUse>), nameof(ContactPoint.UseElement));         // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "rank":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.rank",                                                                                        // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(PositiveInt), nameof(ContactPoint.RankElement));                               // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "period":                                                                                                              // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.period",                                                                                      // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(Period), nameof(ContactPoint.Period));                                         // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "id":                                                                                                                  // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.id",                                                                                          // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(string), nameof(ContactPoint.ElementId));                                      // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "extension":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.extension",                                                                                   // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(ContactPoint.Extension));                             // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                default: return null;                                                                                                       // CodeGeneration.cs:223
            }                                                                                                                               // CodeGeneration.cs:224
            this.childNodeDictionary.Add(childName, retVal);                                                                                // CodeGeneration.cs:225
            return retVal;                                                                                                                  // CodeGeneration.cs:226
        }                                                                                                                                   // CodeGeneration.cs:227
                                                                                                                                            // CodeGeneration.cs:171
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementNode FindChildCoding(String parentPath, String childName)                                                                    // CodeGeneration.cs:175
        {                                                                                                                                   // CodeGeneration.cs:176
            ElementNode retVal;                                                                                                             // CodeGeneration.cs:177
            switch (childName)                                                                                                              // CodeGeneration.cs:178
            {                                                                                                                               // CodeGeneration.cs:179
                case "system":                                                                                                              // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.system",                                                                                      // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirUri), nameof(Coding.SystemElement));                                       // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "version":                                                                                                             // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.version",                                                                                     // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirString), nameof(Coding.VersionElement));                                   // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "code":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.code",                                                                                        // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(Code), nameof(Coding.CodeElement));                                            // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "display":                                                                                                             // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.display",                                                                                     // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirString), nameof(Coding.DisplayElement));                                   // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "userSelected":                                                                                                        // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.userSelected",                                                                                // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirBoolean), nameof(Coding.UserSelectedElement));                             // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "id":                                                                                                                  // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.id",                                                                                          // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(string), nameof(Coding.ElementId));                                            // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "extension":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.extension",                                                                                   // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(Coding.Extension));                                   // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                default: return null;                                                                                                       // CodeGeneration.cs:223
            }                                                                                                                               // CodeGeneration.cs:224
            this.childNodeDictionary.Add(childName, retVal);                                                                                // CodeGeneration.cs:225
            return retVal;                                                                                                                  // CodeGeneration.cs:226
        }                                                                                                                                   // CodeGeneration.cs:227
                                                                                                                                            // CodeGeneration.cs:171
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementNode FindChildMoney(String parentPath, String childName)                                                                     // CodeGeneration.cs:175
        {                                                                                                                                   // CodeGeneration.cs:176
            ElementNode retVal;                                                                                                             // CodeGeneration.cs:177
            switch (childName)                                                                                                              // CodeGeneration.cs:178
            {                                                                                                                               // CodeGeneration.cs:179
                case "value":                                                                                                               // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.value",                                                                                       // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirDecimal), nameof(Money.ValueElement));                                     // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "currency":                                                                                                            // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.currency",                                                                                    // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(Code<Money.Currencies>), nameof(Money.CurrencyElement));                       // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "id":                                                                                                                  // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.id",                                                                                          // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(string), nameof(Money.ElementId));                                             // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "extension":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.extension",                                                                                   // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(Money.Extension));                                    // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                default: return null;                                                                                                       // CodeGeneration.cs:223
            }                                                                                                                               // CodeGeneration.cs:224
            this.childNodeDictionary.Add(childName, retVal);                                                                                // CodeGeneration.cs:225
            return retVal;                                                                                                                  // CodeGeneration.cs:226
        }                                                                                                                                   // CodeGeneration.cs:227
                                                                                                                                            // CodeGeneration.cs:171
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementNode FindChildAddress(String parentPath, String childName)                                                                   // CodeGeneration.cs:175
        {                                                                                                                                   // CodeGeneration.cs:176
            ElementNode retVal;                                                                                                             // CodeGeneration.cs:177
            switch (childName)                                                                                                              // CodeGeneration.cs:178
            {                                                                                                                               // CodeGeneration.cs:179
                case "use":                                                                                                                 // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.use",                                                                                         // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(Code<Address.AddressUse>), nameof(Address.UseElement));                        // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "type":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.type",                                                                                        // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(Code<Address.AddressType>), nameof(Address.TypeElement));                      // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "text":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.text",                                                                                        // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirString), nameof(Address.TextElement));                                     // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "line":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.line",                                                                                        // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(List<FhirString>), nameof(Address.LineElement));                               // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "city":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.city",                                                                                        // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirString), nameof(Address.CityElement));                                     // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "district":                                                                                                            // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.district",                                                                                    // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirString), nameof(Address.DistrictElement));                                 // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "state":                                                                                                               // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.state",                                                                                       // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirString), nameof(Address.StateElement));                                    // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "postalCode":                                                                                                          // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.postalCode",                                                                                  // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirString), nameof(Address.PostalCodeElement));                               // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "country":                                                                                                             // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.country",                                                                                     // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirString), nameof(Address.CountryElement));                                  // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "period":                                                                                                              // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.period",                                                                                      // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(Period), nameof(Address.Period));                                              // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "id":                                                                                                                  // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.id",                                                                                          // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(string), nameof(Address.ElementId));                                           // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "extension":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.extension",                                                                                   // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(Address.Extension));                                  // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                default: return null;                                                                                                       // CodeGeneration.cs:223
            }                                                                                                                               // CodeGeneration.cs:224
            this.childNodeDictionary.Add(childName, retVal);                                                                                // CodeGeneration.cs:225
            return retVal;                                                                                                                  // CodeGeneration.cs:226
        }                                                                                                                                   // CodeGeneration.cs:227
                                                                                                                                            // CodeGeneration.cs:171
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementNode FindChildTiming(String parentPath, String childName)                                                                    // CodeGeneration.cs:175
        {                                                                                                                                   // CodeGeneration.cs:176
            ElementNode retVal;                                                                                                             // CodeGeneration.cs:177
            switch (childName)                                                                                                              // CodeGeneration.cs:178
            {                                                                                                                               // CodeGeneration.cs:179
                case "event":                                                                                                               // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.event",                                                                                       // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(List<FhirDateTime>), nameof(Timing.EventElement));                             // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "repeat":                                                                                                              // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.repeat",                                                                                      // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(Timing.RepeatComponent), nameof(Timing.Repeat));                               // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "code":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.code",                                                                                        // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(CodeableConcept), nameof(Timing.Code));                                        // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "modifierExtension":                                                                                                   // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.modifierExtension",                                                                           // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(Timing.ModifierExtension));                           // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "id":                                                                                                                  // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.id",                                                                                          // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(string), nameof(Timing.ElementId));                                            // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "extension":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.extension",                                                                                   // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(Timing.Extension));                                   // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                default: return null;                                                                                                       // CodeGeneration.cs:223
            }                                                                                                                               // CodeGeneration.cs:224
            this.childNodeDictionary.Add(childName, retVal);                                                                                // CodeGeneration.cs:225
            return retVal;                                                                                                                  // CodeGeneration.cs:226
        }                                                                                                                                   // CodeGeneration.cs:227
                                                                                                                                            // CodeGeneration.cs:171
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementNode FindChildQuantity(String parentPath, String childName)                                                                  // CodeGeneration.cs:175
        {                                                                                                                                   // CodeGeneration.cs:176
            ElementNode retVal;                                                                                                             // CodeGeneration.cs:177
            switch (childName)                                                                                                              // CodeGeneration.cs:178
            {                                                                                                                               // CodeGeneration.cs:179
                case "value":                                                                                                               // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.value",                                                                                       // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirDecimal), nameof(Quantity.ValueElement));                                  // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "comparator":                                                                                                          // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.comparator",                                                                                  // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(Code<Quantity.QuantityComparator>), nameof(Quantity.ComparatorElement));       // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "unit":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.unit",                                                                                        // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirString), nameof(Quantity.UnitElement));                                    // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "system":                                                                                                              // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.system",                                                                                      // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirUri), nameof(Quantity.SystemElement));                                     // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "code":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.code",                                                                                        // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(Code), nameof(Quantity.CodeElement));                                          // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "id":                                                                                                                  // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.id",                                                                                          // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(string), nameof(Quantity.ElementId));                                          // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "extension":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.extension",                                                                                   // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(Quantity.Extension));                                 // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                default: return null;                                                                                                       // CodeGeneration.cs:223
            }                                                                                                                               // CodeGeneration.cs:224
            this.childNodeDictionary.Add(childName, retVal);                                                                                // CodeGeneration.cs:225
            return retVal;                                                                                                                  // CodeGeneration.cs:226
        }                                                                                                                                   // CodeGeneration.cs:227
                                                                                                                                            // CodeGeneration.cs:171
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementNode FindChildSampledData(String parentPath, String childName)                                                               // CodeGeneration.cs:175
        {                                                                                                                                   // CodeGeneration.cs:176
            ElementNode retVal;                                                                                                             // CodeGeneration.cs:177
            switch (childName)                                                                                                              // CodeGeneration.cs:178
            {                                                                                                                               // CodeGeneration.cs:179
                case "origin":                                                                                                              // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.origin",                                                                                      // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(SimpleQuantity), nameof(SampledData.Origin));                                  // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "period":                                                                                                              // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.period",                                                                                      // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirDecimal), nameof(SampledData.PeriodElement));                              // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "factor":                                                                                                              // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.factor",                                                                                      // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirDecimal), nameof(SampledData.FactorElement));                              // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "lowerLimit":                                                                                                          // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.lowerLimit",                                                                                  // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirDecimal), nameof(SampledData.LowerLimitElement));                          // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "upperLimit":                                                                                                          // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.upperLimit",                                                                                  // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirDecimal), nameof(SampledData.UpperLimitElement));                          // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "dimensions":                                                                                                          // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.dimensions",                                                                                  // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(PositiveInt), nameof(SampledData.DimensionsElement));                          // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "data":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.data",                                                                                        // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirString), nameof(SampledData.DataElement));                                 // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "id":                                                                                                                  // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.id",                                                                                          // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(string), nameof(SampledData.ElementId));                                       // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "extension":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.extension",                                                                                   // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(SampledData.Extension));                              // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                default: return null;                                                                                                       // CodeGeneration.cs:223
            }                                                                                                                               // CodeGeneration.cs:224
            this.childNodeDictionary.Add(childName, retVal);                                                                                // CodeGeneration.cs:225
            return retVal;                                                                                                                  // CodeGeneration.cs:226
        }                                                                                                                                   // CodeGeneration.cs:227
                                                                                                                                            // CodeGeneration.cs:171
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementNode FindChildSignature(String parentPath, String childName)                                                                 // CodeGeneration.cs:175
        {                                                                                                                                   // CodeGeneration.cs:176
            ElementNode retVal;                                                                                                             // CodeGeneration.cs:177
            switch (childName)                                                                                                              // CodeGeneration.cs:178
            {                                                                                                                               // CodeGeneration.cs:179
                case "type":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.type",                                                                                        // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(List<Coding>), nameof(Signature.Type));                                        // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "when":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.when",                                                                                        // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(Instant), nameof(Signature.WhenElement));                                      // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "who":                                                                                                                 // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.who",                                                                                         // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(ResourceReference), nameof(Signature.Who));                                    // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "onBehalfOf":                                                                                                          // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.onBehalfOf",                                                                                  // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(ResourceReference), nameof(Signature.OnBehalfOf));                             // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "targetFormat":                                                                                                        // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.targetFormat",                                                                                // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(Code), nameof(Signature.TargetFormatElement));                                 // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "sigFormat":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.sigFormat",                                                                                   // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(Code), nameof(Signature.SigFormatElement));                                    // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "data":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.data",                                                                                        // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(Base64Binary), nameof(Signature.DataElement));                                 // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "id":                                                                                                                  // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.id",                                                                                          // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(string), nameof(Signature.ElementId));                                         // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "extension":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.extension",                                                                                   // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(Signature.Extension));                                // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                default: return null;                                                                                                       // CodeGeneration.cs:223
            }                                                                                                                               // CodeGeneration.cs:224
            this.childNodeDictionary.Add(childName, retVal);                                                                                // CodeGeneration.cs:225
            return retVal;                                                                                                                  // CodeGeneration.cs:226
        }                                                                                                                                   // CodeGeneration.cs:227
                                                                                                                                            // CodeGeneration.cs:171
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementNode FindChildAge(String parentPath, String childName)                                                                       // CodeGeneration.cs:175
        {                                                                                                                                   // CodeGeneration.cs:176
            ElementNode retVal;                                                                                                             // CodeGeneration.cs:177
            switch (childName)                                                                                                              // CodeGeneration.cs:178
            {                                                                                                                               // CodeGeneration.cs:179
                case "value":                                                                                                               // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.value",                                                                                       // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirDecimal), nameof(Age.ValueElement));                                       // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "comparator":                                                                                                          // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.comparator",                                                                                  // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(Code<Quantity.QuantityComparator>), nameof(Age.ComparatorElement));            // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "unit":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.unit",                                                                                        // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirString), nameof(Age.UnitElement));                                         // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "system":                                                                                                              // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.system",                                                                                      // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirUri), nameof(Age.SystemElement));                                          // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "code":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.code",                                                                                        // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(Code), nameof(Age.CodeElement));                                               // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "id":                                                                                                                  // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.id",                                                                                          // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(string), nameof(Age.ElementId));                                               // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "extension":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.extension",                                                                                   // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(Age.Extension));                                      // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                default: return null;                                                                                                       // CodeGeneration.cs:223
            }                                                                                                                               // CodeGeneration.cs:224
            this.childNodeDictionary.Add(childName, retVal);                                                                                // CodeGeneration.cs:225
            return retVal;                                                                                                                  // CodeGeneration.cs:226
        }                                                                                                                                   // CodeGeneration.cs:227
                                                                                                                                            // CodeGeneration.cs:171
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementNode FindChildDistance(String parentPath, String childName)                                                                  // CodeGeneration.cs:175
        {                                                                                                                                   // CodeGeneration.cs:176
            ElementNode retVal;                                                                                                             // CodeGeneration.cs:177
            switch (childName)                                                                                                              // CodeGeneration.cs:178
            {                                                                                                                               // CodeGeneration.cs:179
                case "value":                                                                                                               // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.value",                                                                                       // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirDecimal), nameof(Distance.ValueElement));                                  // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "comparator":                                                                                                          // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.comparator",                                                                                  // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(Code<Quantity.QuantityComparator>), nameof(Distance.ComparatorElement));       // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "unit":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.unit",                                                                                        // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirString), nameof(Distance.UnitElement));                                    // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "system":                                                                                                              // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.system",                                                                                      // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirUri), nameof(Distance.SystemElement));                                     // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "code":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.code",                                                                                        // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(Code), nameof(Distance.CodeElement));                                          // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "id":                                                                                                                  // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.id",                                                                                          // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(string), nameof(Distance.ElementId));                                          // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "extension":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.extension",                                                                                   // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(Distance.Extension));                                 // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                default: return null;                                                                                                       // CodeGeneration.cs:223
            }                                                                                                                               // CodeGeneration.cs:224
            this.childNodeDictionary.Add(childName, retVal);                                                                                // CodeGeneration.cs:225
            return retVal;                                                                                                                  // CodeGeneration.cs:226
        }                                                                                                                                   // CodeGeneration.cs:227
                                                                                                                                            // CodeGeneration.cs:171
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementNode FindChildDuration(String parentPath, String childName)                                                                  // CodeGeneration.cs:175
        {                                                                                                                                   // CodeGeneration.cs:176
            ElementNode retVal;                                                                                                             // CodeGeneration.cs:177
            switch (childName)                                                                                                              // CodeGeneration.cs:178
            {                                                                                                                               // CodeGeneration.cs:179
                case "value":                                                                                                               // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.value",                                                                                       // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirDecimal), nameof(Duration.ValueElement));                                  // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "comparator":                                                                                                          // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.comparator",                                                                                  // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(Code<Quantity.QuantityComparator>), nameof(Duration.ComparatorElement));       // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "unit":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.unit",                                                                                        // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirString), nameof(Duration.UnitElement));                                    // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "system":                                                                                                              // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.system",                                                                                      // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirUri), nameof(Duration.SystemElement));                                     // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "code":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.code",                                                                                        // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(Code), nameof(Duration.CodeElement));                                          // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "id":                                                                                                                  // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.id",                                                                                          // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(string), nameof(Duration.ElementId));                                          // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "extension":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.extension",                                                                                   // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(Duration.Extension));                                 // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                default: return null;                                                                                                       // CodeGeneration.cs:223
            }                                                                                                                               // CodeGeneration.cs:224
            this.childNodeDictionary.Add(childName, retVal);                                                                                // CodeGeneration.cs:225
            return retVal;                                                                                                                  // CodeGeneration.cs:226
        }                                                                                                                                   // CodeGeneration.cs:227
                                                                                                                                            // CodeGeneration.cs:171
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementNode FindChildCount(String parentPath, String childName)                                                                     // CodeGeneration.cs:175
        {                                                                                                                                   // CodeGeneration.cs:176
            ElementNode retVal;                                                                                                             // CodeGeneration.cs:177
            switch (childName)                                                                                                              // CodeGeneration.cs:178
            {                                                                                                                               // CodeGeneration.cs:179
                case "value":                                                                                                               // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.value",                                                                                       // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirDecimal), nameof(Count.ValueElement));                                     // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "comparator":                                                                                                          // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.comparator",                                                                                  // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(Code<Quantity.QuantityComparator>), nameof(Count.ComparatorElement));          // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "unit":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.unit",                                                                                        // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirString), nameof(Count.UnitElement));                                       // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "system":                                                                                                              // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.system",                                                                                      // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirUri), nameof(Count.SystemElement));                                        // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "code":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.code",                                                                                        // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(Code), nameof(Count.CodeElement));                                             // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "id":                                                                                                                  // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.id",                                                                                          // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(string), nameof(Count.ElementId));                                             // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "extension":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.extension",                                                                                   // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(Count.Extension));                                    // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                default: return null;                                                                                                       // CodeGeneration.cs:223
            }                                                                                                                               // CodeGeneration.cs:224
            this.childNodeDictionary.Add(childName, retVal);                                                                                // CodeGeneration.cs:225
            return retVal;                                                                                                                  // CodeGeneration.cs:226
        }                                                                                                                                   // CodeGeneration.cs:227
                                                                                                                                            // CodeGeneration.cs:171
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementNode FindChildMoneyQuantity(String parentPath, String childName)                                                             // CodeGeneration.cs:175
        {                                                                                                                                   // CodeGeneration.cs:176
            ElementNode retVal;                                                                                                             // CodeGeneration.cs:177
            switch (childName)                                                                                                              // CodeGeneration.cs:178
            {                                                                                                                               // CodeGeneration.cs:179
                case "value":                                                                                                               // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.value",                                                                                       // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirDecimal), nameof(MoneyQuantity.ValueElement));                             // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "comparator":                                                                                                          // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.comparator",                                                                                  // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(Code<Quantity.QuantityComparator>), nameof(MoneyQuantity.ComparatorElement));  // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "unit":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.unit",                                                                                        // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirString), nameof(MoneyQuantity.UnitElement));                               // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "system":                                                                                                              // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.system",                                                                                      // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirUri), nameof(MoneyQuantity.SystemElement));                                // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "code":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.code",                                                                                        // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(Code), nameof(MoneyQuantity.CodeElement));                                     // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "id":                                                                                                                  // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.id",                                                                                          // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(string), nameof(MoneyQuantity.ElementId));                                     // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "extension":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.extension",                                                                                   // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(MoneyQuantity.Extension));                            // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                default: return null;                                                                                                       // CodeGeneration.cs:223
            }                                                                                                                               // CodeGeneration.cs:224
            this.childNodeDictionary.Add(childName, retVal);                                                                                // CodeGeneration.cs:225
            return retVal;                                                                                                                  // CodeGeneration.cs:226
        }                                                                                                                                   // CodeGeneration.cs:227
                                                                                                                                            // CodeGeneration.cs:171
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementNode FindChildSimpleQuantity(String parentPath, String childName)                                                            // CodeGeneration.cs:175
        {                                                                                                                                   // CodeGeneration.cs:176
            ElementNode retVal;                                                                                                             // CodeGeneration.cs:177
            switch (childName)                                                                                                              // CodeGeneration.cs:178
            {                                                                                                                               // CodeGeneration.cs:179
                case "value":                                                                                                               // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.value",                                                                                       // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirDecimal), nameof(SimpleQuantity.ValueElement));                            // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "comparator":                                                                                                          // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.comparator",                                                                                  // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(Code<Quantity.QuantityComparator>), nameof(SimpleQuantity.ComparatorElement)); // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "unit":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.unit",                                                                                        // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirString), nameof(SimpleQuantity.UnitElement));                              // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "system":                                                                                                              // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.system",                                                                                      // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(FhirUri), nameof(SimpleQuantity.SystemElement));                               // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "code":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.code",                                                                                        // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(Code), nameof(SimpleQuantity.CodeElement));                                    // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "id":                                                                                                                  // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.id",                                                                                          // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(string), nameof(SimpleQuantity.ElementId));                                    // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "extension":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.extension",                                                                                   // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(SimpleQuantity.Extension));                           // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                default: return null;                                                                                                       // CodeGeneration.cs:223
            }                                                                                                                               // CodeGeneration.cs:224
            this.childNodeDictionary.Add(childName, retVal);                                                                                // CodeGeneration.cs:225
            return retVal;                                                                                                                  // CodeGeneration.cs:226
        }                                                                                                                                   // CodeGeneration.cs:227
                                                                                                                                            // CodeGeneration.cs:171
        /// <summary>
        /// Manually add the children of a Coding element.
        /// </summary>
        ElementNode FindChildExtension(String parentPath, String childName)                                                                 // CodeGeneration.cs:175
        {                                                                                                                                   // CodeGeneration.cs:176
            ElementNode retVal;                                                                                                             // CodeGeneration.cs:177
            switch (childName)                                                                                                              // CodeGeneration.cs:178
            {                                                                                                                               // CodeGeneration.cs:179
                case "url":                                                                                                                 // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.url",                                                                                         // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(string), nameof(Extension.Url));                                               // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "value":                                                                                                               // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.value",                                                                                       // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(Element), nameof(Extension.Value));                                            // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "id":                                                                                                                  // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.id",                                                                                          // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(string), nameof(Extension.ElementId));                                         // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                case "extension":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.extension",                                                                                   // CodeGeneration.cs:211
                        Min = 1,                                                                                                            // CodeGeneration.cs:212
                        Max = "1"                                                                                                           // CodeGeneration.cs:213
                    };                                                                                                                      // CodeGeneration.cs:214
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(Extension.Extension));                                // CodeGeneration.cs:215
                    break;                                                                                                                  // CodeGeneration.cs:216
                };                                                                                                                          // CodeGeneration.cs:217
                default: return null;                                                                                                       // CodeGeneration.cs:223
            }                                                                                                                               // CodeGeneration.cs:224
            this.childNodeDictionary.Add(childName, retVal);                                                                                // CodeGeneration.cs:225
            return retVal;                                                                                                                  // CodeGeneration.cs:226
        }                                                                                                                                   // CodeGeneration.cs:227
    }                                                                                                                                       // CodeGeneration.cs:263
}                                                                                                                                           // CodeGeneration.cs:264
