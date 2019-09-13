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
                                                                                                                                            // CodeGeneration.cs:254
namespace FhirKhit.SliceGen.R4
{                                                                                                                                           // CodeGeneration.cs:256
    public partial class ElementNode                                                                                                        // CodeGeneration.cs:257
    {                                                                                                                                       // CodeGeneration.cs:258
        /// <summary>
        /// Create ElementNode for child of common/primitive Fhir data type elements
        /// </summary>
        public ElementNode FindCommonChild(String parentPath, String childName)                                                             // CodeGeneration.cs:272
        {                                                                                                                                   // CodeGeneration.cs:273
            switch (this.FhirItemType.FriendlyName())                                                                                       // CodeGeneration.cs:274
            {                                                                                                                               // CodeGeneration.cs:275
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
                default: return null;                                                                                                       // CodeGeneration.cs:305
            }                                                                                                                               // CodeGeneration.cs:306
        }                                                                                                                                   // CodeGeneration.cs:307
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
                        Short = "Ratio.numerator common attribute",                                                                         // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(Quantity), nameof(Ratio.Numerator));                                           // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "denominator":                                                                                                         // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.denominator",                                                                                 // CodeGeneration.cs:211
                        Short = "Ratio.denominator common attribute",                                                                       // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(Quantity), nameof(Ratio.Denominator));                                         // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "id":                                                                                                                  // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.id",                                                                                          // CodeGeneration.cs:211
                        Short = "Ratio.id common attribute",                                                                                // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(string), nameof(Ratio.ElementId));                                             // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "extension":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.extension",                                                                                   // CodeGeneration.cs:211
                        Short = "Ratio.extension common attribute",                                                                         // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(Ratio.Extension));                                    // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                default: return null;                                                                                                       // CodeGeneration.cs:224
            }                                                                                                                               // CodeGeneration.cs:225
            this.childNodeDictionary.Add(childName, retVal);                                                                                // CodeGeneration.cs:226
            return retVal;                                                                                                                  // CodeGeneration.cs:227
        }                                                                                                                                   // CodeGeneration.cs:228
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
                        Short = "Period.start common attribute",                                                                            // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirDateTime), nameof(Period.StartElement));                                   // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "end":                                                                                                                 // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.end",                                                                                         // CodeGeneration.cs:211
                        Short = "Period.end common attribute",                                                                              // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirDateTime), nameof(Period.EndElement));                                     // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "id":                                                                                                                  // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.id",                                                                                          // CodeGeneration.cs:211
                        Short = "Period.id common attribute",                                                                               // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(string), nameof(Period.ElementId));                                            // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "extension":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.extension",                                                                                   // CodeGeneration.cs:211
                        Short = "Period.extension common attribute",                                                                        // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(Period.Extension));                                   // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                default: return null;                                                                                                       // CodeGeneration.cs:224
            }                                                                                                                               // CodeGeneration.cs:225
            this.childNodeDictionary.Add(childName, retVal);                                                                                // CodeGeneration.cs:226
            return retVal;                                                                                                                  // CodeGeneration.cs:227
        }                                                                                                                                   // CodeGeneration.cs:228
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
                        Short = "Range.low common attribute",                                                                               // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(SimpleQuantity), nameof(Range.Low));                                           // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "high":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.high",                                                                                        // CodeGeneration.cs:211
                        Short = "Range.high common attribute",                                                                              // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(SimpleQuantity), nameof(Range.High));                                          // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "id":                                                                                                                  // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.id",                                                                                          // CodeGeneration.cs:211
                        Short = "Range.id common attribute",                                                                                // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(string), nameof(Range.ElementId));                                             // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "extension":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.extension",                                                                                   // CodeGeneration.cs:211
                        Short = "Range.extension common attribute",                                                                         // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(Range.Extension));                                    // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                default: return null;                                                                                                       // CodeGeneration.cs:224
            }                                                                                                                               // CodeGeneration.cs:225
            this.childNodeDictionary.Add(childName, retVal);                                                                                // CodeGeneration.cs:226
            return retVal;                                                                                                                  // CodeGeneration.cs:227
        }                                                                                                                                   // CodeGeneration.cs:228
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
                        Short = "Attachment.contentType common attribute",                                                                  // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(Code), nameof(Attachment.ContentTypeElement));                                 // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "language":                                                                                                            // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.language",                                                                                    // CodeGeneration.cs:211
                        Short = "Attachment.language common attribute",                                                                     // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(Code), nameof(Attachment.LanguageElement));                                    // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "data":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.data",                                                                                        // CodeGeneration.cs:211
                        Short = "Attachment.data common attribute",                                                                         // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(Base64Binary), nameof(Attachment.DataElement));                                // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "url":                                                                                                                 // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.url",                                                                                         // CodeGeneration.cs:211
                        Short = "Attachment.url common attribute",                                                                          // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirUrl), nameof(Attachment.UrlElement));                                      // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "size":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.size",                                                                                        // CodeGeneration.cs:211
                        Short = "Attachment.size common attribute",                                                                         // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(UnsignedInt), nameof(Attachment.SizeElement));                                 // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "hash":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.hash",                                                                                        // CodeGeneration.cs:211
                        Short = "Attachment.hash common attribute",                                                                         // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(Base64Binary), nameof(Attachment.HashElement));                                // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "title":                                                                                                               // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.title",                                                                                       // CodeGeneration.cs:211
                        Short = "Attachment.title common attribute",                                                                        // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirString), nameof(Attachment.TitleElement));                                 // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "creation":                                                                                                            // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.creation",                                                                                    // CodeGeneration.cs:211
                        Short = "Attachment.creation common attribute",                                                                     // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirDateTime), nameof(Attachment.CreationElement));                            // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "id":                                                                                                                  // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.id",                                                                                          // CodeGeneration.cs:211
                        Short = "Attachment.id common attribute",                                                                           // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(string), nameof(Attachment.ElementId));                                        // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "extension":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.extension",                                                                                   // CodeGeneration.cs:211
                        Short = "Attachment.extension common attribute",                                                                    // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(Attachment.Extension));                               // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                default: return null;                                                                                                       // CodeGeneration.cs:224
            }                                                                                                                               // CodeGeneration.cs:225
            this.childNodeDictionary.Add(childName, retVal);                                                                                // CodeGeneration.cs:226
            return retVal;                                                                                                                  // CodeGeneration.cs:227
        }                                                                                                                                   // CodeGeneration.cs:228
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
                        Short = "Identifier.use common attribute",                                                                          // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(Code<Identifier.IdentifierUse>), nameof(Identifier.UseElement));               // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "type":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.type",                                                                                        // CodeGeneration.cs:211
                        Short = "Identifier.type common attribute",                                                                         // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(CodeableConcept), nameof(Identifier.Type));                                    // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "system":                                                                                                              // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.system",                                                                                      // CodeGeneration.cs:211
                        Short = "Identifier.system common attribute",                                                                       // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirUri), nameof(Identifier.SystemElement));                                   // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "value":                                                                                                               // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.value",                                                                                       // CodeGeneration.cs:211
                        Short = "Identifier.value common attribute",                                                                        // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirString), nameof(Identifier.ValueElement));                                 // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "period":                                                                                                              // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.period",                                                                                      // CodeGeneration.cs:211
                        Short = "Identifier.period common attribute",                                                                       // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(Period), nameof(Identifier.Period));                                           // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "assigner":                                                                                                            // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.assigner",                                                                                    // CodeGeneration.cs:211
                        Short = "Identifier.assigner common attribute",                                                                     // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(ResourceReference), nameof(Identifier.Assigner));                              // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "id":                                                                                                                  // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.id",                                                                                          // CodeGeneration.cs:211
                        Short = "Identifier.id common attribute",                                                                           // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(string), nameof(Identifier.ElementId));                                        // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "extension":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.extension",                                                                                   // CodeGeneration.cs:211
                        Short = "Identifier.extension common attribute",                                                                    // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(Identifier.Extension));                               // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                default: return null;                                                                                                       // CodeGeneration.cs:224
            }                                                                                                                               // CodeGeneration.cs:225
            this.childNodeDictionary.Add(childName, retVal);                                                                                // CodeGeneration.cs:226
            return retVal;                                                                                                                  // CodeGeneration.cs:227
        }                                                                                                                                   // CodeGeneration.cs:228
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
                        Short = "Annotation.author common attribute",                                                                       // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(Element), nameof(Annotation.Author));                                          // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "time":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.time",                                                                                        // CodeGeneration.cs:211
                        Short = "Annotation.time common attribute",                                                                         // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirDateTime), nameof(Annotation.TimeElement));                                // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "text":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.text",                                                                                        // CodeGeneration.cs:211
                        Short = "Annotation.text common attribute",                                                                         // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(Markdown), nameof(Annotation.Text));                                           // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "id":                                                                                                                  // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.id",                                                                                          // CodeGeneration.cs:211
                        Short = "Annotation.id common attribute",                                                                           // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(string), nameof(Annotation.ElementId));                                        // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "extension":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.extension",                                                                                   // CodeGeneration.cs:211
                        Short = "Annotation.extension common attribute",                                                                    // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(Annotation.Extension));                               // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                default: return null;                                                                                                       // CodeGeneration.cs:224
            }                                                                                                                               // CodeGeneration.cs:225
            this.childNodeDictionary.Add(childName, retVal);                                                                                // CodeGeneration.cs:226
            return retVal;                                                                                                                  // CodeGeneration.cs:227
        }                                                                                                                                   // CodeGeneration.cs:228
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
                        Short = "HumanName.use common attribute",                                                                           // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(Code<HumanName.NameUse>), nameof(HumanName.UseElement));                       // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "text":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.text",                                                                                        // CodeGeneration.cs:211
                        Short = "HumanName.text common attribute",                                                                          // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirString), nameof(HumanName.TextElement));                                   // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "family":                                                                                                              // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.family",                                                                                      // CodeGeneration.cs:211
                        Short = "HumanName.family common attribute",                                                                        // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirString), nameof(HumanName.FamilyElement));                                 // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "given":                                                                                                               // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.given",                                                                                       // CodeGeneration.cs:211
                        Short = "HumanName.given common attribute",                                                                         // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(List<FhirString>), nameof(HumanName.GivenElement));                            // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "prefix":                                                                                                              // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.prefix",                                                                                      // CodeGeneration.cs:211
                        Short = "HumanName.prefix common attribute",                                                                        // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(List<FhirString>), nameof(HumanName.PrefixElement));                           // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "suffix":                                                                                                              // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.suffix",                                                                                      // CodeGeneration.cs:211
                        Short = "HumanName.suffix common attribute",                                                                        // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(List<FhirString>), nameof(HumanName.SuffixElement));                           // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "period":                                                                                                              // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.period",                                                                                      // CodeGeneration.cs:211
                        Short = "HumanName.period common attribute",                                                                        // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(Period), nameof(HumanName.Period));                                            // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "id":                                                                                                                  // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.id",                                                                                          // CodeGeneration.cs:211
                        Short = "HumanName.id common attribute",                                                                            // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(string), nameof(HumanName.ElementId));                                         // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "extension":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.extension",                                                                                   // CodeGeneration.cs:211
                        Short = "HumanName.extension common attribute",                                                                     // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(HumanName.Extension));                                // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                default: return null;                                                                                                       // CodeGeneration.cs:224
            }                                                                                                                               // CodeGeneration.cs:225
            this.childNodeDictionary.Add(childName, retVal);                                                                                // CodeGeneration.cs:226
            return retVal;                                                                                                                  // CodeGeneration.cs:227
        }                                                                                                                                   // CodeGeneration.cs:228
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
                        Short = "CodeableConcept.coding common attribute",                                                                  // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(List<Coding>), nameof(CodeableConcept.Coding));                                // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "text":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.text",                                                                                        // CodeGeneration.cs:211
                        Short = "CodeableConcept.text common attribute",                                                                    // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirString), nameof(CodeableConcept.TextElement));                             // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "id":                                                                                                                  // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.id",                                                                                          // CodeGeneration.cs:211
                        Short = "CodeableConcept.id common attribute",                                                                      // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(string), nameof(CodeableConcept.ElementId));                                   // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "extension":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.extension",                                                                                   // CodeGeneration.cs:211
                        Short = "CodeableConcept.extension common attribute",                                                               // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(CodeableConcept.Extension));                          // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                default: return null;                                                                                                       // CodeGeneration.cs:224
            }                                                                                                                               // CodeGeneration.cs:225
            this.childNodeDictionary.Add(childName, retVal);                                                                                // CodeGeneration.cs:226
            return retVal;                                                                                                                  // CodeGeneration.cs:227
        }                                                                                                                                   // CodeGeneration.cs:228
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
                        Short = "ContactPoint.system common attribute",                                                                     // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(Code<ContactPoint.ContactPointSystem>), nameof(ContactPoint.SystemElement));   // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "value":                                                                                                               // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.value",                                                                                       // CodeGeneration.cs:211
                        Short = "ContactPoint.value common attribute",                                                                      // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirString), nameof(ContactPoint.ValueElement));                               // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "use":                                                                                                                 // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.use",                                                                                         // CodeGeneration.cs:211
                        Short = "ContactPoint.use common attribute",                                                                        // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(Code<ContactPoint.ContactPointUse>), nameof(ContactPoint.UseElement));         // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "rank":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.rank",                                                                                        // CodeGeneration.cs:211
                        Short = "ContactPoint.rank common attribute",                                                                       // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(PositiveInt), nameof(ContactPoint.RankElement));                               // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "period":                                                                                                              // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.period",                                                                                      // CodeGeneration.cs:211
                        Short = "ContactPoint.period common attribute",                                                                     // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(Period), nameof(ContactPoint.Period));                                         // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "id":                                                                                                                  // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.id",                                                                                          // CodeGeneration.cs:211
                        Short = "ContactPoint.id common attribute",                                                                         // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(string), nameof(ContactPoint.ElementId));                                      // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "extension":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.extension",                                                                                   // CodeGeneration.cs:211
                        Short = "ContactPoint.extension common attribute",                                                                  // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(ContactPoint.Extension));                             // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                default: return null;                                                                                                       // CodeGeneration.cs:224
            }                                                                                                                               // CodeGeneration.cs:225
            this.childNodeDictionary.Add(childName, retVal);                                                                                // CodeGeneration.cs:226
            return retVal;                                                                                                                  // CodeGeneration.cs:227
        }                                                                                                                                   // CodeGeneration.cs:228
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
                        Short = "Coding.system common attribute",                                                                           // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirUri), nameof(Coding.SystemElement));                                       // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "version":                                                                                                             // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.version",                                                                                     // CodeGeneration.cs:211
                        Short = "Coding.version common attribute",                                                                          // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirString), nameof(Coding.VersionElement));                                   // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "code":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.code",                                                                                        // CodeGeneration.cs:211
                        Short = "Coding.code common attribute",                                                                             // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(Code), nameof(Coding.CodeElement));                                            // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "display":                                                                                                             // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.display",                                                                                     // CodeGeneration.cs:211
                        Short = "Coding.display common attribute",                                                                          // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirString), nameof(Coding.DisplayElement));                                   // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "userSelected":                                                                                                        // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.userSelected",                                                                                // CodeGeneration.cs:211
                        Short = "Coding.userSelected common attribute",                                                                     // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirBoolean), nameof(Coding.UserSelectedElement));                             // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "id":                                                                                                                  // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.id",                                                                                          // CodeGeneration.cs:211
                        Short = "Coding.id common attribute",                                                                               // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(string), nameof(Coding.ElementId));                                            // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "extension":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.extension",                                                                                   // CodeGeneration.cs:211
                        Short = "Coding.extension common attribute",                                                                        // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(Coding.Extension));                                   // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                default: return null;                                                                                                       // CodeGeneration.cs:224
            }                                                                                                                               // CodeGeneration.cs:225
            this.childNodeDictionary.Add(childName, retVal);                                                                                // CodeGeneration.cs:226
            return retVal;                                                                                                                  // CodeGeneration.cs:227
        }                                                                                                                                   // CodeGeneration.cs:228
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
                        Short = "Money.value common attribute",                                                                             // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirDecimal), nameof(Money.ValueElement));                                     // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "currency":                                                                                                            // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.currency",                                                                                    // CodeGeneration.cs:211
                        Short = "Money.currency common attribute",                                                                          // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(Code<Money.Currencies>), nameof(Money.CurrencyElement));                       // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "id":                                                                                                                  // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.id",                                                                                          // CodeGeneration.cs:211
                        Short = "Money.id common attribute",                                                                                // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(string), nameof(Money.ElementId));                                             // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "extension":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.extension",                                                                                   // CodeGeneration.cs:211
                        Short = "Money.extension common attribute",                                                                         // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(Money.Extension));                                    // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                default: return null;                                                                                                       // CodeGeneration.cs:224
            }                                                                                                                               // CodeGeneration.cs:225
            this.childNodeDictionary.Add(childName, retVal);                                                                                // CodeGeneration.cs:226
            return retVal;                                                                                                                  // CodeGeneration.cs:227
        }                                                                                                                                   // CodeGeneration.cs:228
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
                        Short = "Address.use common attribute",                                                                             // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(Code<Address.AddressUse>), nameof(Address.UseElement));                        // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "type":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.type",                                                                                        // CodeGeneration.cs:211
                        Short = "Address.type common attribute",                                                                            // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(Code<Address.AddressType>), nameof(Address.TypeElement));                      // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "text":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.text",                                                                                        // CodeGeneration.cs:211
                        Short = "Address.text common attribute",                                                                            // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirString), nameof(Address.TextElement));                                     // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "line":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.line",                                                                                        // CodeGeneration.cs:211
                        Short = "Address.line common attribute",                                                                            // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(List<FhirString>), nameof(Address.LineElement));                               // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "city":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.city",                                                                                        // CodeGeneration.cs:211
                        Short = "Address.city common attribute",                                                                            // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirString), nameof(Address.CityElement));                                     // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "district":                                                                                                            // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.district",                                                                                    // CodeGeneration.cs:211
                        Short = "Address.district common attribute",                                                                        // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirString), nameof(Address.DistrictElement));                                 // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "state":                                                                                                               // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.state",                                                                                       // CodeGeneration.cs:211
                        Short = "Address.state common attribute",                                                                           // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirString), nameof(Address.StateElement));                                    // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "postalCode":                                                                                                          // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.postalCode",                                                                                  // CodeGeneration.cs:211
                        Short = "Address.postalCode common attribute",                                                                      // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirString), nameof(Address.PostalCodeElement));                               // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "country":                                                                                                             // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.country",                                                                                     // CodeGeneration.cs:211
                        Short = "Address.country common attribute",                                                                         // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirString), nameof(Address.CountryElement));                                  // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "period":                                                                                                              // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.period",                                                                                      // CodeGeneration.cs:211
                        Short = "Address.period common attribute",                                                                          // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(Period), nameof(Address.Period));                                              // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "id":                                                                                                                  // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.id",                                                                                          // CodeGeneration.cs:211
                        Short = "Address.id common attribute",                                                                              // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(string), nameof(Address.ElementId));                                           // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "extension":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.extension",                                                                                   // CodeGeneration.cs:211
                        Short = "Address.extension common attribute",                                                                       // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(Address.Extension));                                  // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                default: return null;                                                                                                       // CodeGeneration.cs:224
            }                                                                                                                               // CodeGeneration.cs:225
            this.childNodeDictionary.Add(childName, retVal);                                                                                // CodeGeneration.cs:226
            return retVal;                                                                                                                  // CodeGeneration.cs:227
        }                                                                                                                                   // CodeGeneration.cs:228
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
                        Short = "Timing.event common attribute",                                                                            // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(List<FhirDateTime>), nameof(Timing.EventElement));                             // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "repeat":                                                                                                              // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.repeat",                                                                                      // CodeGeneration.cs:211
                        Short = "Timing.repeat common attribute",                                                                           // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(Timing.RepeatComponent), nameof(Timing.Repeat));                               // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "code":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.code",                                                                                        // CodeGeneration.cs:211
                        Short = "Timing.code common attribute",                                                                             // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(CodeableConcept), nameof(Timing.Code));                                        // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "modifierExtension":                                                                                                   // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.modifierExtension",                                                                           // CodeGeneration.cs:211
                        Short = "Timing.modifierExtension common attribute",                                                                // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(Timing.ModifierExtension));                           // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "id":                                                                                                                  // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.id",                                                                                          // CodeGeneration.cs:211
                        Short = "Timing.id common attribute",                                                                               // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(string), nameof(Timing.ElementId));                                            // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "extension":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.extension",                                                                                   // CodeGeneration.cs:211
                        Short = "Timing.extension common attribute",                                                                        // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(Timing.Extension));                                   // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                default: return null;                                                                                                       // CodeGeneration.cs:224
            }                                                                                                                               // CodeGeneration.cs:225
            this.childNodeDictionary.Add(childName, retVal);                                                                                // CodeGeneration.cs:226
            return retVal;                                                                                                                  // CodeGeneration.cs:227
        }                                                                                                                                   // CodeGeneration.cs:228
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
                        Short = "Quantity.value common attribute",                                                                          // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirDecimal), nameof(Quantity.ValueElement));                                  // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "comparator":                                                                                                          // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.comparator",                                                                                  // CodeGeneration.cs:211
                        Short = "Quantity.comparator common attribute",                                                                     // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(Code<Quantity.QuantityComparator>), nameof(Quantity.ComparatorElement));       // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "unit":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.unit",                                                                                        // CodeGeneration.cs:211
                        Short = "Quantity.unit common attribute",                                                                           // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirString), nameof(Quantity.UnitElement));                                    // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "system":                                                                                                              // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.system",                                                                                      // CodeGeneration.cs:211
                        Short = "Quantity.system common attribute",                                                                         // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirUri), nameof(Quantity.SystemElement));                                     // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "code":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.code",                                                                                        // CodeGeneration.cs:211
                        Short = "Quantity.code common attribute",                                                                           // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(Code), nameof(Quantity.CodeElement));                                          // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "id":                                                                                                                  // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.id",                                                                                          // CodeGeneration.cs:211
                        Short = "Quantity.id common attribute",                                                                             // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(string), nameof(Quantity.ElementId));                                          // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "extension":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.extension",                                                                                   // CodeGeneration.cs:211
                        Short = "Quantity.extension common attribute",                                                                      // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(Quantity.Extension));                                 // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                default: return null;                                                                                                       // CodeGeneration.cs:224
            }                                                                                                                               // CodeGeneration.cs:225
            this.childNodeDictionary.Add(childName, retVal);                                                                                // CodeGeneration.cs:226
            return retVal;                                                                                                                  // CodeGeneration.cs:227
        }                                                                                                                                   // CodeGeneration.cs:228
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
                        Short = "SampledData.origin common attribute",                                                                      // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(SimpleQuantity), nameof(SampledData.Origin));                                  // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "period":                                                                                                              // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.period",                                                                                      // CodeGeneration.cs:211
                        Short = "SampledData.period common attribute",                                                                      // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirDecimal), nameof(SampledData.PeriodElement));                              // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "factor":                                                                                                              // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.factor",                                                                                      // CodeGeneration.cs:211
                        Short = "SampledData.factor common attribute",                                                                      // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirDecimal), nameof(SampledData.FactorElement));                              // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "lowerLimit":                                                                                                          // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.lowerLimit",                                                                                  // CodeGeneration.cs:211
                        Short = "SampledData.lowerLimit common attribute",                                                                  // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirDecimal), nameof(SampledData.LowerLimitElement));                          // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "upperLimit":                                                                                                          // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.upperLimit",                                                                                  // CodeGeneration.cs:211
                        Short = "SampledData.upperLimit common attribute",                                                                  // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirDecimal), nameof(SampledData.UpperLimitElement));                          // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "dimensions":                                                                                                          // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.dimensions",                                                                                  // CodeGeneration.cs:211
                        Short = "SampledData.dimensions common attribute",                                                                  // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(PositiveInt), nameof(SampledData.DimensionsElement));                          // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "data":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.data",                                                                                        // CodeGeneration.cs:211
                        Short = "SampledData.data common attribute",                                                                        // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirString), nameof(SampledData.DataElement));                                 // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "id":                                                                                                                  // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.id",                                                                                          // CodeGeneration.cs:211
                        Short = "SampledData.id common attribute",                                                                          // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(string), nameof(SampledData.ElementId));                                       // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "extension":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.extension",                                                                                   // CodeGeneration.cs:211
                        Short = "SampledData.extension common attribute",                                                                   // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(SampledData.Extension));                              // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                default: return null;                                                                                                       // CodeGeneration.cs:224
            }                                                                                                                               // CodeGeneration.cs:225
            this.childNodeDictionary.Add(childName, retVal);                                                                                // CodeGeneration.cs:226
            return retVal;                                                                                                                  // CodeGeneration.cs:227
        }                                                                                                                                   // CodeGeneration.cs:228
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
                        Short = "Signature.type common attribute",                                                                          // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(List<Coding>), nameof(Signature.Type));                                        // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "when":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.when",                                                                                        // CodeGeneration.cs:211
                        Short = "Signature.when common attribute",                                                                          // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(Instant), nameof(Signature.WhenElement));                                      // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "who":                                                                                                                 // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.who",                                                                                         // CodeGeneration.cs:211
                        Short = "Signature.who common attribute",                                                                           // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(ResourceReference), nameof(Signature.Who));                                    // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "onBehalfOf":                                                                                                          // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.onBehalfOf",                                                                                  // CodeGeneration.cs:211
                        Short = "Signature.onBehalfOf common attribute",                                                                    // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(ResourceReference), nameof(Signature.OnBehalfOf));                             // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "targetFormat":                                                                                                        // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.targetFormat",                                                                                // CodeGeneration.cs:211
                        Short = "Signature.targetFormat common attribute",                                                                  // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(Code), nameof(Signature.TargetFormatElement));                                 // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "sigFormat":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.sigFormat",                                                                                   // CodeGeneration.cs:211
                        Short = "Signature.sigFormat common attribute",                                                                     // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(Code), nameof(Signature.SigFormatElement));                                    // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "data":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.data",                                                                                        // CodeGeneration.cs:211
                        Short = "Signature.data common attribute",                                                                          // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(Base64Binary), nameof(Signature.DataElement));                                 // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "id":                                                                                                                  // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.id",                                                                                          // CodeGeneration.cs:211
                        Short = "Signature.id common attribute",                                                                            // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(string), nameof(Signature.ElementId));                                         // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "extension":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.extension",                                                                                   // CodeGeneration.cs:211
                        Short = "Signature.extension common attribute",                                                                     // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(Signature.Extension));                                // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                default: return null;                                                                                                       // CodeGeneration.cs:224
            }                                                                                                                               // CodeGeneration.cs:225
            this.childNodeDictionary.Add(childName, retVal);                                                                                // CodeGeneration.cs:226
            return retVal;                                                                                                                  // CodeGeneration.cs:227
        }                                                                                                                                   // CodeGeneration.cs:228
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
                        Short = "Age.value common attribute",                                                                               // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirDecimal), nameof(Age.ValueElement));                                       // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "comparator":                                                                                                          // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.comparator",                                                                                  // CodeGeneration.cs:211
                        Short = "Age.comparator common attribute",                                                                          // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(Code<Quantity.QuantityComparator>), nameof(Age.ComparatorElement));            // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "unit":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.unit",                                                                                        // CodeGeneration.cs:211
                        Short = "Age.unit common attribute",                                                                                // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirString), nameof(Age.UnitElement));                                         // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "system":                                                                                                              // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.system",                                                                                      // CodeGeneration.cs:211
                        Short = "Age.system common attribute",                                                                              // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirUri), nameof(Age.SystemElement));                                          // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "code":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.code",                                                                                        // CodeGeneration.cs:211
                        Short = "Age.code common attribute",                                                                                // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(Code), nameof(Age.CodeElement));                                               // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "id":                                                                                                                  // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.id",                                                                                          // CodeGeneration.cs:211
                        Short = "Age.id common attribute",                                                                                  // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(string), nameof(Age.ElementId));                                               // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "extension":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.extension",                                                                                   // CodeGeneration.cs:211
                        Short = "Age.extension common attribute",                                                                           // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(Age.Extension));                                      // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                default: return null;                                                                                                       // CodeGeneration.cs:224
            }                                                                                                                               // CodeGeneration.cs:225
            this.childNodeDictionary.Add(childName, retVal);                                                                                // CodeGeneration.cs:226
            return retVal;                                                                                                                  // CodeGeneration.cs:227
        }                                                                                                                                   // CodeGeneration.cs:228
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
                        Short = "Distance.value common attribute",                                                                          // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirDecimal), nameof(Distance.ValueElement));                                  // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "comparator":                                                                                                          // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.comparator",                                                                                  // CodeGeneration.cs:211
                        Short = "Distance.comparator common attribute",                                                                     // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(Code<Quantity.QuantityComparator>), nameof(Distance.ComparatorElement));       // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "unit":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.unit",                                                                                        // CodeGeneration.cs:211
                        Short = "Distance.unit common attribute",                                                                           // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirString), nameof(Distance.UnitElement));                                    // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "system":                                                                                                              // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.system",                                                                                      // CodeGeneration.cs:211
                        Short = "Distance.system common attribute",                                                                         // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirUri), nameof(Distance.SystemElement));                                     // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "code":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.code",                                                                                        // CodeGeneration.cs:211
                        Short = "Distance.code common attribute",                                                                           // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(Code), nameof(Distance.CodeElement));                                          // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "id":                                                                                                                  // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.id",                                                                                          // CodeGeneration.cs:211
                        Short = "Distance.id common attribute",                                                                             // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(string), nameof(Distance.ElementId));                                          // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "extension":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.extension",                                                                                   // CodeGeneration.cs:211
                        Short = "Distance.extension common attribute",                                                                      // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(Distance.Extension));                                 // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                default: return null;                                                                                                       // CodeGeneration.cs:224
            }                                                                                                                               // CodeGeneration.cs:225
            this.childNodeDictionary.Add(childName, retVal);                                                                                // CodeGeneration.cs:226
            return retVal;                                                                                                                  // CodeGeneration.cs:227
        }                                                                                                                                   // CodeGeneration.cs:228
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
                        Short = "Duration.value common attribute",                                                                          // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirDecimal), nameof(Duration.ValueElement));                                  // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "comparator":                                                                                                          // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.comparator",                                                                                  // CodeGeneration.cs:211
                        Short = "Duration.comparator common attribute",                                                                     // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(Code<Quantity.QuantityComparator>), nameof(Duration.ComparatorElement));       // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "unit":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.unit",                                                                                        // CodeGeneration.cs:211
                        Short = "Duration.unit common attribute",                                                                           // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirString), nameof(Duration.UnitElement));                                    // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "system":                                                                                                              // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.system",                                                                                      // CodeGeneration.cs:211
                        Short = "Duration.system common attribute",                                                                         // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirUri), nameof(Duration.SystemElement));                                     // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "code":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.code",                                                                                        // CodeGeneration.cs:211
                        Short = "Duration.code common attribute",                                                                           // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(Code), nameof(Duration.CodeElement));                                          // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "id":                                                                                                                  // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.id",                                                                                          // CodeGeneration.cs:211
                        Short = "Duration.id common attribute",                                                                             // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(string), nameof(Duration.ElementId));                                          // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "extension":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.extension",                                                                                   // CodeGeneration.cs:211
                        Short = "Duration.extension common attribute",                                                                      // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(Duration.Extension));                                 // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                default: return null;                                                                                                       // CodeGeneration.cs:224
            }                                                                                                                               // CodeGeneration.cs:225
            this.childNodeDictionary.Add(childName, retVal);                                                                                // CodeGeneration.cs:226
            return retVal;                                                                                                                  // CodeGeneration.cs:227
        }                                                                                                                                   // CodeGeneration.cs:228
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
                        Short = "Count.value common attribute",                                                                             // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirDecimal), nameof(Count.ValueElement));                                     // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "comparator":                                                                                                          // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.comparator",                                                                                  // CodeGeneration.cs:211
                        Short = "Count.comparator common attribute",                                                                        // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(Code<Quantity.QuantityComparator>), nameof(Count.ComparatorElement));          // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "unit":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.unit",                                                                                        // CodeGeneration.cs:211
                        Short = "Count.unit common attribute",                                                                              // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirString), nameof(Count.UnitElement));                                       // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "system":                                                                                                              // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.system",                                                                                      // CodeGeneration.cs:211
                        Short = "Count.system common attribute",                                                                            // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirUri), nameof(Count.SystemElement));                                        // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "code":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.code",                                                                                        // CodeGeneration.cs:211
                        Short = "Count.code common attribute",                                                                              // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(Code), nameof(Count.CodeElement));                                             // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "id":                                                                                                                  // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.id",                                                                                          // CodeGeneration.cs:211
                        Short = "Count.id common attribute",                                                                                // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(string), nameof(Count.ElementId));                                             // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "extension":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.extension",                                                                                   // CodeGeneration.cs:211
                        Short = "Count.extension common attribute",                                                                         // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(Count.Extension));                                    // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                default: return null;                                                                                                       // CodeGeneration.cs:224
            }                                                                                                                               // CodeGeneration.cs:225
            this.childNodeDictionary.Add(childName, retVal);                                                                                // CodeGeneration.cs:226
            return retVal;                                                                                                                  // CodeGeneration.cs:227
        }                                                                                                                                   // CodeGeneration.cs:228
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
                        Short = "MoneyQuantity.value common attribute",                                                                     // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirDecimal), nameof(MoneyQuantity.ValueElement));                             // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "comparator":                                                                                                          // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.comparator",                                                                                  // CodeGeneration.cs:211
                        Short = "MoneyQuantity.comparator common attribute",                                                                // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(Code<Quantity.QuantityComparator>), nameof(MoneyQuantity.ComparatorElement));  // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "unit":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.unit",                                                                                        // CodeGeneration.cs:211
                        Short = "MoneyQuantity.unit common attribute",                                                                      // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirString), nameof(MoneyQuantity.UnitElement));                               // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "system":                                                                                                              // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.system",                                                                                      // CodeGeneration.cs:211
                        Short = "MoneyQuantity.system common attribute",                                                                    // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirUri), nameof(MoneyQuantity.SystemElement));                                // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "code":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.code",                                                                                        // CodeGeneration.cs:211
                        Short = "MoneyQuantity.code common attribute",                                                                      // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(Code), nameof(MoneyQuantity.CodeElement));                                     // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "id":                                                                                                                  // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.id",                                                                                          // CodeGeneration.cs:211
                        Short = "MoneyQuantity.id common attribute",                                                                        // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(string), nameof(MoneyQuantity.ElementId));                                     // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "extension":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.extension",                                                                                   // CodeGeneration.cs:211
                        Short = "MoneyQuantity.extension common attribute",                                                                 // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(MoneyQuantity.Extension));                            // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                default: return null;                                                                                                       // CodeGeneration.cs:224
            }                                                                                                                               // CodeGeneration.cs:225
            this.childNodeDictionary.Add(childName, retVal);                                                                                // CodeGeneration.cs:226
            return retVal;                                                                                                                  // CodeGeneration.cs:227
        }                                                                                                                                   // CodeGeneration.cs:228
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
                        Short = "SimpleQuantity.value common attribute",                                                                    // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirDecimal), nameof(SimpleQuantity.ValueElement));                            // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "comparator":                                                                                                          // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.comparator",                                                                                  // CodeGeneration.cs:211
                        Short = "SimpleQuantity.comparator common attribute",                                                               // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(Code<Quantity.QuantityComparator>), nameof(SimpleQuantity.ComparatorElement)); // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "unit":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.unit",                                                                                        // CodeGeneration.cs:211
                        Short = "SimpleQuantity.unit common attribute",                                                                     // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirString), nameof(SimpleQuantity.UnitElement));                              // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "system":                                                                                                              // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.system",                                                                                      // CodeGeneration.cs:211
                        Short = "SimpleQuantity.system common attribute",                                                                   // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(FhirUri), nameof(SimpleQuantity.SystemElement));                               // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "code":                                                                                                                // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.code",                                                                                        // CodeGeneration.cs:211
                        Short = "SimpleQuantity.code common attribute",                                                                     // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(Code), nameof(SimpleQuantity.CodeElement));                                    // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "id":                                                                                                                  // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.id",                                                                                          // CodeGeneration.cs:211
                        Short = "SimpleQuantity.id common attribute",                                                                       // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(string), nameof(SimpleQuantity.ElementId));                                    // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "extension":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.extension",                                                                                   // CodeGeneration.cs:211
                        Short = "SimpleQuantity.extension common attribute",                                                                // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(SimpleQuantity.Extension));                           // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                default: return null;                                                                                                       // CodeGeneration.cs:224
            }                                                                                                                               // CodeGeneration.cs:225
            this.childNodeDictionary.Add(childName, retVal);                                                                                // CodeGeneration.cs:226
            return retVal;                                                                                                                  // CodeGeneration.cs:227
        }                                                                                                                                   // CodeGeneration.cs:228
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
                        Short = "Extension.url common attribute",                                                                           // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(string), nameof(Extension.Url));                                               // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "value":                                                                                                               // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.value",                                                                                       // CodeGeneration.cs:211
                        Short = "Extension.value common attribute",                                                                         // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(Element), nameof(Extension.Value));                                            // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "id":                                                                                                                  // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.id",                                                                                          // CodeGeneration.cs:211
                        Short = "Extension.id common attribute",                                                                            // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(string), nameof(Extension.ElementId));                                         // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                case "extension":                                                                                                           // CodeGeneration.cs:207
                {                                                                                                                           // CodeGeneration.cs:208
                    ElementDefinition e = new ElementDefinition                                                                             // CodeGeneration.cs:209
                    {                                                                                                                       // CodeGeneration.cs:210
                        Path = $"{parentPath}.extension",                                                                                   // CodeGeneration.cs:211
                        Short = "Extension.extension common attribute",                                                                     // CodeGeneration.cs:212
                        Min = 1,                                                                                                            // CodeGeneration.cs:213
                        Max = "1"                                                                                                           // CodeGeneration.cs:214
                    };                                                                                                                      // CodeGeneration.cs:215
                    retVal = new ElementNode(this, e, typeof(List<Extension>), nameof(Extension.Extension));                                // CodeGeneration.cs:216
                    break;                                                                                                                  // CodeGeneration.cs:217
                };                                                                                                                          // CodeGeneration.cs:218
                default: return null;                                                                                                       // CodeGeneration.cs:224
            }                                                                                                                               // CodeGeneration.cs:225
            this.childNodeDictionary.Add(childName, retVal);                                                                                // CodeGeneration.cs:226
            return retVal;                                                                                                                  // CodeGeneration.cs:227
        }                                                                                                                                   // CodeGeneration.cs:228
    }                                                                                                                                       // CodeGeneration.cs:264
}                                                                                                                                           // CodeGeneration.cs:265
